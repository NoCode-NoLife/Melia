﻿using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs;
using Melia.Zone.Network;
using Yggdrasil.Extensions;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors.CombatEntities.Components
{
	/// <summary>
	/// Buff collection and manager for an entity.
	/// </summary>
	public class BuffComponent : CombatEntityComponent, IUpdateable
	{
		private readonly Dictionary<BuffId, Buff> _buffs = new();

		/// <summary>
		/// Raised when a buff starts.
		/// </summary>
		public event Action<ICombatEntity, Buff> BuffStarted;

		/// <summary>
		/// Raised when a buff ends.
		/// </summary>
		public event Action<ICombatEntity, Buff> BuffEnded;

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="entity"></param>
		public BuffComponent(ICombatEntity entity) : base(entity)
		{
		}

		/// <summary>
		/// Returns the amount of buffs in the collection.
		/// </summary>
		public int Count { get { lock (_buffs) return _buffs.Count; } }

		/// <summary>
		/// Adds given buff and updates the client, replaces the
		/// buff if it was already active.
		/// </summary>
		/// <param name="buff"></param>
		private void Add(Buff buff)
		{
			lock (_buffs)
				_buffs[buff.Id] = buff;

			buff.IncreaseOverbuff();
			buff.Start();

			Send.ZC_BUFF_ADD(this.Entity, buff);

			this.BuffStarted?.Invoke(this.Entity, buff);
		}

		/// <summary>
		/// Increases the buff's overbuff and updates the client.
		/// </summary>
		/// <param name="buff"></param>
		private void Overbuff(Buff buff)
		{
			var overbuff = buff.OverbuffCounter;
			buff.IncreaseOverbuff();

			// Start again if the overbuff counter changed. Buffs that
			// don't overbuff, such as DashRun, must not get started
			// again, because their effects would get applied over
			// and over.
			if (overbuff != buff.OverbuffCounter)
				buff.Start();
			// If we don't start the buff again, we need to at least
			// extend its duration. Otherwise it may end before the
			// time displayed by the client.
			else
				buff.ExtendDuration();

			Send.ZC_BUFF_UPDATE(this.Entity, buff);
		}

		/// <summary>
		/// Adds and activates given buffs. If a buff already exists,
		/// it gets overbuffed.
		/// </summary>
		/// <param name="buffs"></param>
		public void AddOrUpdate(params Buff[] buffs)
		{
			foreach (var addBuff in buffs)
			{
				if (!this.TryGet(addBuff.Id, out var buff))
					this.Add(addBuff);
				else
					this.Overbuff(buff);
			}
		}

		/// <summary>
		/// Adds buff without starting it again or updating the client.
		/// Use for restoring saved buffs on load.
		/// </summary>
		/// <param name="buff"></param>
		internal void Restore(Buff buff)
		{
			lock (_buffs)
				_buffs[buff.Id] = buff;
		}

		/// <summary>
		/// Removes buff, returns false if it didn't exist. 
		/// Updates the client on success.
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private bool Remove(Buff buff)
		{
			lock (_buffs)
			{
				if (!_buffs.Remove(buff.Id))
					return false;
			}

			buff.End();

			Send.ZC_BUFF_REMOVE(this.Entity, buff);

			this.BuffEnded?.Invoke(this.Entity, buff);

			return true;
		}

		/// <summary>
		/// Removes buff with given id, returns false if it
		/// didn't exist. Updates the client on success.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public bool Remove(BuffId buffId)
		{
			if (!this.TryGet(buffId, out var buff))
				return false;

			return this.Remove(buff);
		}

		/// <summary>
		/// Removes a random removable buff. Returns the id of the buff that was
		/// removed, or 0 if no buff was removed.
		/// </summary>
		/// <remarks>
		/// Only considers buffs of type Buff, not Debuff.
		/// </remarks>
		/// <returns></returns>
		public BuffId RemoveRandomBuff()
		{
			var removableBuffs = this.GetAll(a => a.Data.Type == BuffType.Buff && a.Data.Removable);
			if (removableBuffs.Count == 0)
				return 0;

			var buff = removableBuffs.Random();
			this.Remove(buff);

			return buff.Id;
		}

		/// <summary>
		/// Removes a random removable debuff. Returns the id of the buff that was
		/// removed, or 0 if no buff was removed.
		/// </summary>
		/// <remarks>
		/// Only considers buffs of type Debuff, not Buff.
		/// </remarks>
		/// <returns></returns>
		public BuffId RemoveRandomDebuff()
		{
			var removableDeBuffs = this.GetAll(a => a.Data.Type == BuffType.Debuff && a.Data.Removable);
			if (removableDeBuffs.Count == 0)
				return 0;

			var buff = removableDeBuffs.Random();
			this.Remove(buff);

			return buff.Id;
		}

		/// <summary>
		/// Stops and removes all active buffs.
		/// </summary>
		public void RemoveAll()
		{
			var buffs = this.GetList();
			foreach (var buff in buffs)
				this.Remove(buff);
		}

		/// <summary>
		/// Removes all buffs that match given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		public void RemoveAll(Func<Buff, bool> predicate)
		{
			var buffs = this.GetList();
			foreach (var buff in buffs)
			{
				if (predicate(buff))
					this.Remove(buff);
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
		/// Returns a list of all active buffs that match the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public List<Buff> GetAll(Func<Buff, bool> predicate)
		{
			lock (_buffs)
				return _buffs.Values.Where(predicate).ToList();
		}

		/// <summary>
		/// Returns the number of active buffs that match the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public int CountActive(Func<Buff, bool> predicate)
		{
			lock (_buffs)
				return _buffs.Values.Count(predicate);
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
		/// Returns the overbuff counter for the given buff. Returns 0
		/// if the buff isn't active.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public int GetOverbuffCount(BuffId buffId)
		{
			if (!this.TryGet(buffId, out var buff))
				return 0;

			return buff.OverbuffCounter;
		}

		/// <summary>
		/// Starts the buff with the given id. If the buff is already active,
		/// it gets overbuffed. Returns the created or modified buff. May
		/// return null if the buff was resisted for some reason.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="numArg1"></param>
		/// <param name="numArg2"></param>
		/// <param name="duration">Custom duration of the buff.</param>
		/// <param name="caster">The entity that casted the buff.</param>
		/// <param name="skillId">The id of the skill associated with the buff.</param>
		/// <returns></returns>
		public Buff Start(BuffId buffId, float numArg1, float numArg2, TimeSpan duration, ICombatEntity caster, SkillId skillId)
		{
			// Attempt status resistance against debuffs
			// TODO: Ideally, this should happen from the buff handler,
			//   and we might also want to move the check somewhere else,
			//   so we're still able to force-apply buffs if necessary.
			if (caster != this.Entity && ZoneServer.Instance.Data.BuffDb.TryFind(buffId, out var buffData) && buffData.Type == BuffType.Debuff)
			{
				if (this.TryGet(BuffId.Cyclone_Buff_ImmuneAbil, out var cycloneImmuneBuff))
				{
					if (RandomProvider.Get().Next(100) < cycloneImmuneBuff.NumArg1 * 15)
						return null;
				}
			}

			if (!this.TryGet(buffId, out var buff))
			{
				buff = new Buff(buffId, numArg1, numArg2, duration, TimeSpan.Zero, this.Entity, caster ?? this.Entity, skillId);
				this.Add(buff);
			}
			else
			{
				this.Overbuff(buff);
			}

			return buff;
		}

		/// <summary>
		/// Stops the buff with the given id.
		/// </summary>
		/// <param name="buffId"></param>
		public void Stop(BuffId buffId)
		{
			if (this.TryGet(buffId, out var buff))
				this.Remove(buff);
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

		/// <summary>
		/// Removes buffs that aren't saved on disconnect or map change.
		/// </summary>
		public void StopTempBuffs()
		{
			List<Buff> toRemove = null;

			lock (_buffs)
			{
				foreach (var buff in _buffs.Values)
				{
					if (!buff.Data.Save)
					{
						if (toRemove == null)
							toRemove = new List<Buff>();

						toRemove.Add(buff);
					}
				}
			}

			if (toRemove != null)
			{
				foreach (var buff in toRemove)
					this.Remove(buff);
			}
		}
	}

	/// <summary>
	/// Exception for when a buff handler is not implemented.
	/// </summary>
	public class BuffNotImplementedException : Exception
	{
		/// <summary>
		/// Returns the id of the buff that wasn't implemented.
		/// </summary>
		public BuffId BuffId { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="buffId"></param>
		public BuffNotImplementedException(BuffId buffId) : base($"Buff handler for '{buffId}' not implemented.")
		{
			this.BuffId = buffId;
		}
	}
}
