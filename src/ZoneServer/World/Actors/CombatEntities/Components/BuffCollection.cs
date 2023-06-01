using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs;
using Melia.Zone.Network;
using Yggdrasil.Composition;

namespace Melia.Zone.World.Actors.CombatEntities.Components
{
	/// <summary>
	/// Buff collection and manager for an entity.
	/// </summary>
	public class BuffCollection : CombatEntityComponent, IUpdatableComponent
	{
		private readonly Dictionary<BuffId, Buff> _buffs = new Dictionary<BuffId, Buff>();

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="entity"></param>
		public BuffCollection(ICombatEntity entity) : base(entity)
		{
		}

		/// <summary>
		/// Returns the amount of buffs in the collection.
		/// </summary>
		public int Count { get { lock (_buffs) return _buffs.Count; } }

		/// <summary>
		/// Adds given buff without updating the client, replaces the
		/// buff if it was already active.
		/// </summary>
		/// <param name="buff"></param>
		private void AddSilent(Buff buff)
		{
			lock (_buffs)
				_buffs[buff.Id] = buff;

			buff.IncreaseOverbuff();
			buff.Start();
		}

		/// <summary>
		/// Adds given buff and updates the client, replaces the
		/// buff if it was already active.
		/// </summary>
		/// <param name="buff"></param>
		private void Add(Buff buff)
		{
			this.AddSilent(buff);
			Send.ZC_BUFF_ADD(this.Entity, buff);
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
		/// Removes buff with given id, returns false if it
		/// didn't exist. Doesn't update the client.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		private bool RemoveSilent(Buff buff)
		{
			buff.End();

			lock (_buffs)
				return _buffs.Remove(buff.Id);
		}

		/// <summary>
		/// Removes buff, returns false if it didn't exist. 
		/// Updates the client on success.
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private bool Remove(Buff buff)
		{
			var removed = this.RemoveSilent(buff);
			if (removed)
				Send.ZC_BUFF_REMOVE(this.Entity, buff);

			return removed;
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
		/// Stops and removes all active buffs.
		/// </summary>
		public void RemoveAll()
		{
			var buffs = this.GetList();
			foreach (var buff in buffs)
				this.Remove(buff);
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
		/// Starts the buff with the given id, returns the created buff.
		/// If the buff was already active, it gets overbuffed.
		/// </summary>
		/// <remarks>
		/// Uses the duration from the buff's data by default.
		/// </remarks>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public Buff Start(BuffId buffId)
			=> this.Start(buffId, TimeSpan.MinValue);

		/// <summary>
		/// Starts the buff with the given id. If the buff is already active,
		/// it gets overbuffed. Returns the created or modified buff.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="duration">Custom duration of the buff.</param>
		/// <returns></returns>
		public Buff Start(BuffId buffId, TimeSpan duration)
			=> this.Start(buffId, 0, 0, duration, this.Entity);

		/// <summary>
		/// Starts the buff with the given id. If the buff is already active,
		/// it gets overbuffed. Returns the created or modified buff.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="numArg1"></param>
		/// <param name="numArg2"></param>
		/// <param name="duration">Custom duration of the buff.</param>
		/// <param name="caster">The entity that casted the buff.</param>
		/// <returns></returns>
		public Buff Start(BuffId buffId, float numArg1, float numArg2, TimeSpan duration, ICombatEntity caster)
		{
			if (!this.TryGet(buffId, out var buff))
			{
				buff = new Buff(buffId, numArg1, numArg2, duration, this.Entity, caster ?? this.Entity);
				this.Add(buff);
			}
			else
			{
				this.Overbuff(buff);
			}

			return buff;
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
