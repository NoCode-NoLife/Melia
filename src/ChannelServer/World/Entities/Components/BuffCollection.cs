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
	/// Buff collection and manager for an entity.
	/// </summary>
	public class BuffCollection : IUpdatableComponent
	{
		private readonly Dictionary<BuffId, Buff> _buffs = new Dictionary<BuffId, Buff>();

		/// <summary>
		/// The owner of the collection.
		/// </summary>
		public ICombatEntity Entity { get; }

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="entity"></param>
		public BuffCollection(ICombatEntity entity)
		{
			this.Entity = entity;
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

			buff.IncreaseOverbuff();
			buff.Start();
		}

		/// <summary>
		/// Adds given buff and updates the client.
		/// </summary>
		/// <param name="buff"></param>
		public void Add(Buff buff)
		{
			this.AddSilent(buff);
			Send.ZC_BUFF_ADD(this.Entity, buff);
		}

		/// <summary>
		/// Adds and activates given buffs. If the buffs already exist,
		/// they get overbuffed.
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
		private void Update(BuffId buffId)
		{
			var buff = this.Get(buffId);
			if (buff != null)
			{
				buff.IncreaseOverbuff();
				buff.Start();

				Send.ZC_BUFF_UPDATE(this.Entity, buff);
			}
		}

		/// <summary>
		/// Removes buff with given id, returns false if it
		/// didn't exist. Doesn't update the client.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public bool RemoveSilent(Buff buff)
		{
			buff.End();

			lock (_buffs)
				return _buffs.Remove(buff.Id);
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
			return this.Remove(buff);
		}

		/// <summary>
		/// Removes buff, returns false if it didn't exist. 
		/// Updates the client on success.
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		public bool Remove(Buff buff)
		{
			var removed = this.RemoveSilent(buff);
			if (removed)
				Send.ZC_BUFF_REMOVE(this.Entity, buff);

			return removed;
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
		public void Update(TimeSpan elapsed)
		{
			List<Buff> toUpdate = null;
			List<Buff> toRemove = null;
			var now = DateTime.Now;

			lock (_buffs)
			{
				foreach (var buff in _buffs.Values)
				{
					if (buff.HasUpdateTime)
					{
						if (toUpdate == null)
							toUpdate = new List<Buff>();

						toUpdate.Add(buff);
					}
					if (buff.HasDuration && now >= buff.RemovalTime)
					{
						if (toRemove == null)
							toRemove = new List<Buff>();

						toRemove.Add(buff);
					}
				}
			}

			if (toUpdate != null)
			{
				foreach (var buff in toUpdate)
					buff.Update(elapsed);
			}

			if (toRemove != null)
			{
				foreach (var buff in toRemove)
					this.Remove(buff);
			}
		}
	}
}
