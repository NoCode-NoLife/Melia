using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;
using Yggdrasil.Logging;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.Buffs
{
	/// <summary>
	/// Buff
	/// </summary>
	public class Buff : IUpdateable
	{
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
		public TimeSpan RemainingDuration => Math2.Max(TimeSpan.Zero, this.Duration - this.RunTime);

		/// <summary>
		/// Index in world collection?
		/// </summary>
		public int Handle { get; }

		/// <summary>
		/// Returns the buff's temporary variables.
		/// </summary>
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
		/// Returns true if the the buff's data defines an update time.
		/// </summary>
		/// <returns></returns>
		public bool HasUpdateTime => this.Data.UpdateTime != TimeSpan.Zero;

		/// <summary>
		/// Gets or sets the next time the buff is updated.
		/// </summary>
		private DateTime NextUpdateTime { get; set; }

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
		/// <param name="duration">Use MinValue to use the buff's default duration.</param>
		/// <param name="target"></param>
		/// <param name="caster"></param>
		/// <param name="skillId">Id of the skill associated with this buff.</param>
		public Buff(BuffId buffId, float numArg1, float numArg2, TimeSpan duration, ICombatEntity target, ICombatEntity caster, SkillId skillId = SkillId.Normal_Attack)
		{
			this.Id = buffId;
			this.NumArg1 = numArg1;
			this.NumArg2 = numArg2;
			this.Duration = duration;
			this.Target = target;
			this.Caster = caster;
			this.SkillId = skillId;

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

			if (this.Duration == TimeSpan.MinValue)
				this.Duration = this.Data.Duration;

			if (this.HasDuration)
				this.RemovalTime = DateTime.Now.Add(this.Duration);

			if (this.HasUpdateTime)
				this.NextUpdateTime = DateTime.Now.Add(this.Data.UpdateTime);
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
		/// Start buff behavior
		/// </summary>
		public void Start()
		{
			if (this.HasDuration)
				this.RemovalTime = DateTime.Now.Add(this.Duration);

			this.Handler?.OnStart(this);
		}

		/// <summary>
		/// End buff behavior
		/// </summary>
		public void End()
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
			if (DateTime.Now >= this.NextUpdateTime)
			{
				this.Handler?.WhileActive(this);
				this.NextUpdateTime = DateTime.Now.Add(this.Data.UpdateTime);
				this.RunTime += this.Data.UpdateTime;
			}
		}
	}
}
