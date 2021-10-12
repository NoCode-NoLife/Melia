using System;
using Melia.Channel.Buffs.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;

namespace Melia.Channel.World
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
		/// Index in world collection?
		/// </summary>
		public int Handle { get; }

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
			set => _overbuffCounter = Math2.Clamp(0, this.Data.OverBuff, value);
		}

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
		public bool HasUpdateTime => this.Data.UpdateTime != 0;

		/// <summary>
		/// Gets or sets the next time the buff is updated.
		/// </summary>
		private DateTime NextUpdateTime { get; set; }

		/// <summary>
		/// Returns the buff's handler, that handles its behavior.
		/// </summary>
		private IBuffHandler Handler { get; }

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="buffId"></param>
		/// <param name="duration">0: infinite, otherwise fixed duration</param>
		/// <param name="skillId"></param>
		public Buff(ICombatEntity caster, ICombatEntity target, BuffId buffId, TimeSpan duration, SkillId skillId = SkillId.Normal_Attack)
		{
			this.Caster = caster;
			this.Target = target;
			this.Id = buffId;
			this.Duration = duration;
			this.SkillId = skillId;

			this.Handle = ChannelServer.Instance.World.CreateBuffHandle();
			this.Data = ChannelServer.Instance.Data.BuffDb.Find(buffId) ?? throw new ArgumentException($"Unknown buff '{buffId}'.");
			this.Handler = ChannelServer.Instance.BuffHandlers.GetHandler(buffId);

			if (this.HasDuration)
				this.RemovalTime = DateTime.Now.Add(this.Duration);

			if (this.HasUpdateTime)
				this.NextUpdateTime = DateTime.Now.AddMilliseconds(this.Data.UpdateTime);
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
				this.NextUpdateTime = DateTime.Now.AddMilliseconds(this.Data.UpdateTime);
			}
		}
	}
}
