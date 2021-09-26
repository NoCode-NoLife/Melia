// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Channel.Network;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.EntityComponents;

namespace Melia.Channel.World
{
	/// <summary>
	/// Character buffs.
	/// </summary>
	public class Buffs : IUpdatableComponent
	{
		private readonly Dictionary<BuffId, Buff> _buffs = new Dictionary<BuffId, Buff>();

		/// <summary>
		/// The owner of this object.
		/// </summary>
		public ICombatEntity Owner { get; }

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="entity"></param>
		public Buffs(ICombatEntity entity)
		{
			this.Owner = entity;
		}

		/// <summary>
		/// Returns the amount of buffs in the collection.
		/// </summary>
		public int Count { get { lock (_buffs) return _buffs.Count; } }

		/// <summary>
		/// Adds given without updating the client. Replaces existing
		/// buffs.
		/// </summary>
		/// <param name="buff"></param>
		public void AddSilent(Buff buff)
		{
			lock (_buffs)
				_buffs[buff.Id] = buff;
		}

		/// <summary>
		/// Adds given buff and updates the client.
		/// </summary>
		/// <param name="buff"></param>
		public void Add(Buff buff)
		{
			buff.IncreaseOverbuff();
			this.AddSilent(buff);
			var handler = ChannelServer.Instance.BuffHandlers.GetBuff(buff.Id);
			handler.OnStart(buff);
			Send.ZC_BUFF_ADD(this.Owner, buff);
		}

		/// <summary>
		/// Removes buff with given id, returns false if it
		/// didn't exist. Doesn't update the client.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public bool RemoveSilent(BuffId buffId)
		{
			lock (_buffs)
				return _buffs.Remove(buffId);
		}

		/// <summary>
		/// Removes buff with given id, returns false if it
		/// didn't exist. Updates the client on success.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public bool Remove(BuffId buffId)
		{
			var buff = this.Get(buffId);
			if (buff != null)
			{
				this.Remove(buff);
			}
			return false;
		}

		/// <summary>
		/// Removes buff, returns false if it didn't exist. 
		/// Updates the client on success.
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		public bool Remove(Buff buff)
		{
			var isRemoved = false;
			lock (_buffs)
			{
				isRemoved = _buffs.Remove(buff.Id);
			}
			if (isRemoved)
			{
				var handler = ChannelServer.Instance.BuffHandlers.GetBuff(buff.Id);
				handler.OnEnd(buff);
				Send.ZC_BUFF_REMOVE(this.Owner, buff);
			}
			return isRemoved;
		}

		/// <summary>
		/// Add Buff(s) or Update Buff(s) if it exists
		/// with a given id.
		/// </summary>
		/// <param name="buffs"></param>
		public void AddOrUpdate(params Buff[] buffs)
		{
			foreach (var buff in buffs)
			{
				if (!this.Has(buff.Id))
					this.Add(buff);
				else
					this.Update(buff.Id);
			}
		}

		/// <summary>
		/// Update a buff if it exists using the buff id.
		/// </summary>
		/// <param name="buffId"></param>
		public void Update(BuffId buffId)
		{
			var buff = this.Get(buffId);
			if (buff != null)
			{
				lock (_buffs)
				{
					buff.IncreaseOverbuff();
					buff.RemovalTime = DateTime.Now.AddMilliseconds(buff.Duration);
				}
				var handler = ChannelServer.Instance.BuffHandlers.GetBuff(buff.Id);
				handler.OnStart(buff);
				Send.ZC_BUFF_UPDATE(this.Owner, buff);
			}
		}

		/// <summary>
		/// Returns buff with given id, or null if it didn't
		/// exist.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public Buff Get(BuffId buffId)
		{
			lock (_buffs)
			{
				_buffs.TryGetValue(buffId, out var result);
				return result;
			}
		}

		/// <summary>
		/// Returns buff with given id via out, returns false if the
		/// buff wasn't found.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="buff"></param>
		/// <returns></returns>
		public bool TryGet(BuffId buffId, out Buff buff)
		{
			buff = this.Get(buffId);
			return buff != null;
		}

		/// <summary>
		/// Returns buff with given class name, or null if it didn't
		/// exist.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public Buff Get(string buffClassName)
		{
			lock (_buffs)
				return _buffs.Values.FirstOrDefault(a => a.Data.ClassName == buffClassName);
		}

		/// <summary>
		/// Returns a list with all buffs.
		/// </summary>
		/// <returns></returns>
		public List<Buff> GetList()
		{
			lock (_buffs)
				return _buffs.Values.ToList();
		}

		/// <summary>
		/// Returns true if the buff exists.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public bool Has(BuffId buffId)
		{
			lock (_buffs)
				return _buffs.ContainsKey(buffId);
		}

		/// <summary>
		/// Check buffs and remove expired buffs
		/// </summary>
		public void UpdateBuffs()
		{
			List<Buff> buffsToRemove;
			List<Buff> buffsToUpdate;
			lock (_buffs)
			{
				var now = DateTime.Now;
				buffsToRemove = _buffs.Values.Where(a => now >= a.RemovalTime).ToList();
				buffsToUpdate = _buffs.Values.Where(a => now <= a.RemovalTime).ToList();
			}

			foreach (var buff in buffsToUpdate)
			{
				var handler = ChannelServer.Instance.BuffHandlers.GetBuff(buff.Id);
				if (buff.HasUpdateTime())
				{
					if (DateTime.Now > buff.NextUpdateTime)
					{
						handler.WhileActive(buff);
						buff.Update();
					}
				}
			}

			foreach (var buff in buffsToRemove)
				this.Remove(buff);
		}

		public void Update(TimeSpan elapsed)
		{
			this.UpdateBuffs();
		}
	}
}
