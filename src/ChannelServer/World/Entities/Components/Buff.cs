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
		public IEntity Owner { get; }

		/// <summary>
		/// Returns the buff's id.
		/// </summary>
		public BuffId Id { get; }

		/// <summary>
		/// The buff's data from the buff database.
		/// </summary>
		public BuffData Data { get; }

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
		/// Creates a new instance.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="buffId"></param>
		/// <param name="level"></param>
		public Buff(IEntity entity, BuffId buffId)
		{
			this.Owner = entity;
			this.Id = buffId;
			this.Handle = ChannelServer.Instance.World.CreateBuffHandle();
			this.Data = ChannelServer.Instance.Data.BuffDb.Find(buffId) ?? throw new ArgumentException($"Unknown buff '{buffId}'.");
			if (this.Data.Duration != 0)
				this.RemovalTime = DateTime.Now.AddMilliseconds(Math.Max(0, this.Data.Duration));
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
