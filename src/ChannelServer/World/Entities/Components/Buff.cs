using System;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;

namespace Melia.Channel.World
{
	/// <summary>
	/// Modeled after Skill class
	/// </summary>
	public class Buff
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
		public int SkillId { get; }

		/// <summary>
		/// The buff's data from the buff database.
		/// </summary>
		public BuffData Data { get; }
		
		/// <summary>
		/// The buff's duration, separate from database duration
		/// because database duration is inaccurate.
		/// </summary>
		public int Duration { get; }

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
		/// If the buff has an update time
		/// </summary>
		/// <returns></returns>
		public bool HasUpdateTime() => this.Data.UpdateTime != 0;

		/// <summary>
		/// The buff's removal time
		/// </summary>
		public DateTime NextUpdateTime { get; set; }

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="buffId"></param>
		/// <param name="duration"></param>
		/// <param name="skillId"></param>
		public Buff(ICombatEntity caster, ICombatEntity target, BuffId buffId, int duration = 0, int skillId = 1)
		{
			this.Caster = caster;
			this.Target = target;
			this.Id = buffId;
			this.SkillId = skillId;
			this.Handle = ChannelServer.Instance.World.CreateBuffHandle();
			this.Data = ChannelServer.Instance.Data.BuffDb.Find(buffId) ?? throw new ArgumentException($"Unknown buff '{buffId}'.");
			if (duration == 0)
			{
				if (this.Data.Duration != 0)
				{
					this.Duration = this.Data.Duration;
					this.RemovalTime = DateTime.Now.AddMilliseconds(this.Data.Duration);
				}
			}
			else
			{
				this.Duration = duration;
				this.RemovalTime = DateTime.Now.AddMilliseconds(duration);
			}
			if (this.HasUpdateTime())
				this.NextUpdateTime = DateTime.Now.AddMilliseconds(this.Data.UpdateTime);
		}

		/// <summary>
		/// Get Next Update Time
		/// </summary>
		public void Update()
		{
			if (this.HasUpdateTime())
				this.NextUpdateTime = DateTime.Now.AddMilliseconds(this.Data.UpdateTime);
		}

		/// <summary>
		/// Increase overbuff counter
		/// </summary>
		public void IncreaseOverbuff()
		{
			this.OverbuffCounter++;
		}
	}
}
