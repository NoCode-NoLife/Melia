using System;
using Melia.Channel.Buffs.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;

namespace Melia.Channel.World
{
	/// <summary>
	/// Buff
	/// </summary>
	public class Buff : IUpdateable
	{
		/// <summary>
		/// The buff's owner.
		/// </summary>
		public ICombatEntity Caster { get; }

		/// <summary>
		/// The buff's target.
		/// </summary>
		public ICombatEntity Target { get; }

		/// <summary>
		/// Returns the buff's id.
		/// </summary>
		public BuffId Id { get; }

		/// <summary>
		/// Returns the buff's associated skill id.
		/// Default value is 1.
		/// </summary>
		public SkillId SkillId { get; } = SkillId.Normal_Attack;

		/// <summary>
		/// The buff's data from the buff database.
		/// </summary>
		public BuffData Data { get; }

		/// <summary>
		/// The buff's duration, separate from database duration
		/// because database duration is inaccurate.
		/// </summary>
		public TimeSpan Duration { get; } = TimeSpan.Zero;

		/// <summary>
		/// Index in world collection?
		/// </summary>
		public int Handle { get; private set; }

		/// <summary>
		/// Returns the buff's overbuff count. If this value reaches the buff's
		/// maximum overbuff, the buff has additional effects based on this
		/// counter.
		/// </summary>
		public int OverbuffCounter { get; private set; }

		/// <summary>
		/// The buff's removal time
		/// </summary>
		public DateTime RemovalTime { get; set; }

		/// <summary>
		/// If the buff has a duration
		/// </summary>
		/// <returns></returns>
		public bool HasDuration => this.Duration != TimeSpan.Zero;

		/// <summary>
		/// If the buff has an update time in the database
		/// </summary>
		/// <returns></returns>
		public bool HasUpdateTime => this.Data.UpdateTime != 0;

		/// <summary>
		/// The buff's next update time
		/// </summary>
		public DateTime NextUpdateTime { get; set; }

		/// <summary>
		/// The buff's behavior handler
		/// </summary>
		public IBuffHandler Handler { get; private set; }

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="buffId"></param>
		/// <param name="durationInMilliseconds">-1: use database default, 0: infinite, otherwise fixed duration</param>
		/// <param name="skillId"></param>
		public Buff(ICombatEntity caster, ICombatEntity target, BuffId buffId, int durationInMilliseconds = -1, SkillId skillId = SkillId.Normal_Attack)
		{
			this.Caster = caster;
			this.Target = target;
			this.Id = buffId;
			this.SkillId = skillId;
			this.Handle = ChannelServer.Instance.World.CreateBuffHandle();
			this.Data = ChannelServer.Instance.Data.BuffDb.Find(buffId) ?? throw new ArgumentException($"Unknown buff '{buffId}'.");
			this.Handler = ChannelServer.Instance.BuffHandlers.GetBuff(buffId);
			if (durationInMilliseconds == -1)
				this.Duration = TimeSpan.FromMilliseconds(this.Data.Duration);
			else
				this.Duration = TimeSpan.FromMilliseconds(durationInMilliseconds);
			if (this.HasDuration)
				this.RemovalTime = DateTime.Now.Add(this.Duration);
			if (this.HasUpdateTime)
				this.NextUpdateTime = DateTime.Now.AddMilliseconds(this.Data.UpdateTime);
		}

		/// <summary>
		/// Increase overbuff counter until the over buff limit
		/// from database
		/// </summary>
		public void IncreaseOverbuff()
		{
			if (this.OverbuffCounter < this.Data.OverBuff)
				this.OverbuffCounter++;
		}

		/// <summary>
		/// Buff Update
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
	}
}
