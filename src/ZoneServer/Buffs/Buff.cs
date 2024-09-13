﻿using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.Buffs
{
	/// <summary>
	/// Buff
	/// </summary>
	public class Buff : IUpdateable
	{
		/// <summary>
		/// Returns a value that is recognized as the default duration for a buff.
		/// </summary>
		/// <remarks>
		/// If this value is passed as the duration for a buff, it will use
		/// the buff's default from its data.
		/// </remarks>
		public readonly static TimeSpan DefaultDuration = TimeSpan.MinValue;

		/// <summary>
		/// Returns a value that is recognized as an infinite duration for a buff.
		/// </summary>
		/// <remarks>
		/// If this value is passed as the duration for a buff, it won't end
		/// until it's removed manually.
		/// </remarks>
		public readonly static TimeSpan InfiniteDuration = TimeSpan.Zero;

		private int _overbuffCounter;

		/// <summary>
		/// Returns the entity that casted the buff.
		/// </summary>
		public ICombatEntity Caster { get; }

		/// <summary>
		/// Returns the entity that received the buff.
		/// </summary>
		public ICombatEntity Target { get; }

		/// <summary>
		/// Returns the buff's id.
		/// </summary>
		public BuffId Id { get; }

		/// <summary>
		/// Returns the buff's associated skill id.
		/// </summary>
		public SkillId SkillId { get; } = SkillId.Normal_Attack;

		/// <summary>
		/// The reference to the buff's data.
		/// </summary>
		public BuffData Data { get; }

		/// <summary>
		/// Returns the full duration of the buff.
		/// </summary>
		public TimeSpan Duration { get; } = TimeSpan.Zero;

		/// <summary>
		/// Returns the amount of time the buff was active.
		/// </summary>
		public TimeSpan RunTime { get; private set; }

		/// <summary>
		/// Returns the time the buff has left to run.
		/// </summary>
		public TimeSpan RemainingDuration => Math2.Max(TimeSpan.Zero, this.RemovalTime - DateTime.Now);

		/// <summary>
		/// Index in world collection?
		/// </summary>
		public int Handle { get; }

		/// <summary>
		/// Returns the buff's variables.
		/// </summary>
		/// <remarks>
		/// Saved to database together with the buff. Safe to be used to
		/// store modifiers that can be used to revert the buff's effects.
		/// </remarks>
		public Variables Vars { get; } = new Variables();

		/// <summary>
		/// Returns the buff's overbuff count.
		/// </summary>
		/// <remarks>
		/// If this value reaches the buff's maximum overbuff, the buff
		/// potentially has additional effects based on this counter.
		/// </remarks>
		public int OverbuffCounter
		{
			get => _overbuffCounter;
			set => _overbuffCounter = Math2.Clamp(0, this.MaxOverbuffCount, value);
		}

		/// <summary>
		/// Returns the buff's maximum overbuff count.
		/// </summary>
		public int MaxOverbuffCount => this.Data.OverBuff;

		/// <summary>
		/// Returns true if the buff has reached its maximum overbuff count.
		/// </summary>
		public bool IsFullyOverbuffed => _overbuffCounter >= this.MaxOverbuffCount;

		/// <summary>
		/// Returns the time at which the buff is removed.
		/// </summary>
		public DateTime RemovalTime { get; private set; }

		/// <summary>
		/// Returns true if the buff has a limited duration.
		/// </summary>
		/// <returns></returns>
		public bool HasDuration => this.Duration != TimeSpan.Zero;

		/// <summary>
		/// Gets or sets the time between updates.
		/// </summary>
		/// <remarks>
		/// Defaults to the buff's update time from its data, but can be modified
		/// to increase or decrease the time between updates going forward.
		/// </remarks>
		public TimeSpan UpdateTime { get; set; }

		/// <summary>
		/// Returns true if the the buff's data defines an update time.
		/// </summary>
		/// <returns></returns>
		public bool HasUpdateTime => this.UpdateTime != TimeSpan.Zero;

		/// <summary>
		/// Gets or sets the next time the buff is updated.
		/// </summary>
		public DateTime NextUpdateTime { get; set; }

		/// <summary>
		/// Returns the buff's handler, that handles its behavior.
		/// </summary>
		private IBuffHandler Handler { get; }

		/// <summary>
		/// Returns the first argument the buff was started with.
		/// </summary>
		public float NumArg1 { get; }

		/// <summary>
		/// Returns the second argument the buff was started with.
		/// </summary>
		public float NumArg2 { get; }

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="buffId"></param>
		/// <param name="numArg1"></param>
		/// <param name="numArg2"></param>
		/// <param name="duration">The full duration of the buff. Use MinValue to use the buff's default duration.</param>
		/// <param name="runTime">The amount of time the buff was already active.</param>
		/// <param name="target"></param>
		/// <param name="caster"></param>
		/// <param name="skillId">Id of the skill associated with this buff.</param>
		public Buff(BuffId buffId, float numArg1, float numArg2, TimeSpan duration, TimeSpan runTime, ICombatEntity target, ICombatEntity caster, SkillId skillId)
		{
			this.Id = buffId;
			this.NumArg1 = numArg1;
			this.NumArg2 = numArg2;
			this.Duration = duration;
			this.RunTime = runTime;
			this.Target = target;
			this.Caster = caster;
			this.SkillId = skillId;

			// We used to default this to Normal_Attack in the arguments.
			// Guess we'll keep that? We probably did it for a reason.
			if (this.SkillId == SkillId.None)
				this.SkillId = SkillId.Normal_Attack;

			this.Handle = ZoneServer.Instance.World.CreateBuffHandle();
			this.Data = ZoneServer.Instance.Data.BuffDb.Find(buffId) ?? throw new ArgumentException($"Unknown buff '{buffId}'.");
			this.Handler = ZoneServer.Instance.BuffHandlers.GetHandler(buffId);

			// Getting messages about missing handlers could be useful,
			// but since there are buffs that literally do nothing on
			// their own, we'd have to add dummy buff handlers to get
			// rid of the messages, so we'll ignore missing handlers
			// for now.
			//if (this.Handler == null)
			//	Log.Debug("Buff: No handler found for '{0}'.", buffId);

			if (this.Duration == DefaultDuration)
				this.Duration = this.Data.Duration;

			if (this.HasDuration)
			{
				var remaining = Math2.Max(TimeSpan.Zero, this.Duration - this.RunTime);
				this.RemovalTime = DateTime.Now.Add(remaining);
			}

			this.UpdateTime = this.Data.UpdateTime;

			if (this.HasUpdateTime)
				this.NextUpdateTime = DateTime.Now.Add(this.UpdateTime);
		}

		/// <summary>
		/// Increase overbuff counter, capped to the buff's max overbuff
		/// value.
		/// </summary>
		public void IncreaseOverbuff()
		{
			this.OverbuffCounter++;
		}

		/// <summary>
		/// Extends the buff's duration and executes the buff handler's
		/// activation behavior.
		/// </summary>
		/// <param name="activationType"></param>
		internal void Activate(ActivationType activationType)
		{
			this.ExtendDuration();

#pragma warning disable CS0618
			// Temporarily call OnStart for backwards compatibility until users
			// had time to update their buff handlers.
			this.Handler?.OnStart(this);
			this.Handler?.OnActivate(this, activationType);
			this.Handler?.OnExtend(this);
#pragma warning restore CS0618
		}

		/// <summary>
		/// Extends the buff's duration and executes the buff handler's
		/// extension behavior.
		/// </summary>
		internal void Extend()
		{
			this.ExtendDuration();
			this.Handler?.OnExtend(this);
		}

		/// <summary>
		/// Extends the buff's removal and update times if applicable.
		/// </summary>
		/// <remarks>
		/// Effectively extends the buff's duration and resets the update time,
		/// so it ticks again after the update time has passed.
		/// </remarks>
		internal void ExtendDuration()
		{
			if (this.HasDuration)
			{
				this.RunTime = TimeSpan.Zero;
				this.RemovalTime = DateTime.Now.Add(this.Duration);
			}

			if (this.HasUpdateTime)
				this.NextUpdateTime = DateTime.Now.Add(this.Data.UpdateTime);
		}

		/// <summary>
		/// Executes the buff handler's end behavior. Does not actually
		/// end or remove the buff.
		/// </summary>
		internal void End()
		{
			this.Handler?.OnEnd(this);
		}

		/// <summary>
		/// Updates the buff and handles effects that happen while the buff
		/// is active.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			if (!this.HasUpdateTime)
				return;

			if (DateTime.Now >= this.NextUpdateTime)
			{
				this.Handler?.WhileActive(this);
				this.NextUpdateTime = DateTime.Now.Add(this.UpdateTime);
				this.RunTime += this.UpdateTime;
			}
		}
	}
}
