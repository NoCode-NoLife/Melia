using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors.CombatEntities.Components
{
	/// <summary>
	/// Cooldown manager component.
	/// </summary>
	public class CooldownComponent : CombatEntityComponent, IUpdateable
	{
		private readonly object _syncLock = new object();
		private readonly Dictionary<CooldownId, Cooldown> _cooldowns = new Dictionary<CooldownId, Cooldown>();
		private readonly List<Cooldown> _over = new List<Cooldown>();

		/// <summary>
		/// Creates new component.
		/// </summary>
		/// <param name="entity"></param>
		public CooldownComponent(ICombatEntity entity) : base(entity)
		{
		}

		/// <summary>
		/// Starts a cooldown with the given duration. If the cooldown
		/// is already active, it's restarted with the new duration.
		/// </summary>
		/// <param name="cooldownId"></param>
		/// <param name="duration"></param>
		public void Start(CooldownId cooldownId, TimeSpan duration)
		{
			var cooldown = new Cooldown(cooldownId, duration);

			lock (_syncLock)
			{
				if (_cooldowns.TryGetValue(cooldownId, out var existingCooldown))
				{
					cooldown = existingCooldown;
					cooldown.Change(duration);
				}
				else
				{
					_cooldowns[cooldownId] = cooldown;
				}
			}

			if (this.Entity is Character character)
				Send.ZC_COOLDOWN_CHANGED(character, cooldown);
		}

		/// <summary>
		/// Reduce a cooldown by a given duration
		/// </summary>
		/// <param name="cooldownId"></param>
		/// <param name="duration"></param>
		public void Reduce(CooldownId cooldownId, TimeSpan duration)
		{
			lock (_syncLock)
			{
				if (_cooldowns.TryGetValue(cooldownId, out var existingCooldown))
				{
					var cooldown = existingCooldown;
					cooldown.Update(duration);

					if (cooldown.Remaining == TimeSpan.Zero)
						_cooldowns.Remove(cooldown.Id);

					if (this.Entity is Character character)
						Send.ZC_COOLDOWN_CHANGED(character, cooldown, duration.TotalMilliseconds);
				}
			}
		}

		/// <summary>
		/// Adds the cooldown without updating the client. Overwrites
		/// existing cooldowns.
		/// </summary>
		/// <param name="cooldown"></param>
		internal void Restore(Cooldown cooldown)
		{
			lock (_syncLock)
				_cooldowns[cooldown.Id] = cooldown;
		}

		/// <summary>
		/// Return the Cooldown Object for the given CooldownId
		/// existing cooldowns.
		/// </summary>
		/// <param name="cooldown"></param>
		internal Cooldown GetCooldown(CooldownId cooldownId)
		{
			lock (_syncLock)
				return _cooldowns[cooldownId];
		}

		/// <summary>
		/// Returns a list of all cooldowns.
		/// </summary>
		/// <returns></returns>
		public Cooldown[] GetAll()
		{
			lock (_syncLock)
				return _cooldowns.Values.ToArray();
		}

		/// <summary>
		/// Returns true if the given cooldown is active.
		/// </summary>
		/// <param name="cooldownId"></param>
		/// <returns></returns>
		public bool IsOnCooldown(CooldownId cooldownId)
		{
			lock (_syncLock)
			{
				if (_cooldowns.TryGetValue(cooldownId, out var cooldown))
					return DateTime.Now < cooldown.EndTime;

				return false;
			}
		}

		/// <summary>
		/// Returns the remaining time until the given cooldown is over.
		/// Returns Zero if the cooldown is not active.
		/// </summary>
		/// <param name="cooldownId"></param>
		/// <returns></returns>
		public TimeSpan GetRemain(CooldownId cooldownId)
		{
			lock (_syncLock)
			{
				if (_cooldowns.TryGetValue(cooldownId, out var cooldown))
					return cooldown.Remaining;
			}

			return TimeSpan.Zero;
		}

		/// <summary>
		/// Updates the cooldowns and removes them when they're over.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			lock (_syncLock)
			{
				_over.Clear();

				foreach (var cooldown in _cooldowns.Values)
				{
					cooldown.Update(elapsed);

					if (cooldown.Remaining == TimeSpan.Zero)
						_over.Add(cooldown);
				}

				foreach (var cooldown in _over)
					_cooldowns.Remove(cooldown.Id);
			}
		}
	}

	public class Cooldown
	{
		/// <summary>
		/// Returns the cooldown's class id.
		/// </summary>
		public CooldownId Id { get; }

		/// <summary>
		/// Returns the cooldown's total duration.
		/// </summary>
		public TimeSpan Duration { get; private set; }

		/// <summary>
		/// Returns the time until the cooldown is over.
		/// </summary>
		public TimeSpan Remaining { get; private set; }

		/// <summary>
		/// Returns the time when the cooldown started.
		/// </summary>
		public DateTime StartTime { get; private set; }

		/// <summary>
		/// Returns the time when the cooldown will be over.
		/// </summary>
		public DateTime EndTime => this.StartTime + this.Duration;

		/// <summary>
		/// Creates new cooldown.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="duration"></param>
		public Cooldown(CooldownId id, TimeSpan duration)
			: this(id, duration, duration, DateTime.Now)
		{
		}

		/// <summary>
		/// Creates new cooldown.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="remaining"></param>
		/// <param name="duration"></param>
		/// <param name="startTime"></param>
		public Cooldown(CooldownId id, TimeSpan remaining, TimeSpan duration, DateTime startTime)
		{
			this.Id = id;
			this.Duration = duration;
			this.Remaining = remaining;
			this.StartTime = startTime;
		}

		/// <summary>
		/// Changes the cooldown's duration, effectively restarting it
		/// with the new duration.
		/// </summary>
		/// <param name="duration"></param>
		public void Change(TimeSpan duration)
		{
			this.Duration = duration;
			this.Remaining = duration;
			this.StartTime = DateTime.Now;
		}

		/// <summary>
		/// Updates the cooldown's remaining time.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			this.Remaining = Math2.Max(TimeSpan.Zero, this.Remaining - elapsed);
		}
	}
}
