using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.World.SkillHandlers;
using Melia.Shared.Util;

namespace Melia.Channel.World.SkillEffects
{
	public class SkillEffect
	{
		public int Id;
		public int Handle;

		private DateTime _lastProcessTime;
		private double _tickRate = 500.0;

		private DateTime _lastStackTime;
		public double tickStackRate = 1000.0;

		public DateTime expireTime;
		public bool isPermanent;

		public SkillDataComponent skillComp;

		public int stackLevel;

		public SkillEffect(SkillDataComponent skillComp)
		{
			if (skillComp.skill == null)
				return;

			Handle = ChannelServer.Instance.World.CreateHandle();

			this.skillComp = skillComp;
			this.Id = skillComp.skill.Id;
			stackLevel = 1;
			expireTime = DateTime.Now.AddSeconds(skillComp.skill.Data.buffLifeInSeconds);
			isPermanent = skillComp.skill.Data.buffIsPermanent;
			//skillComp.target.EffectAdd(this);

			_lastProcessTime = DateTime.Now;
			_lastStackTime = DateTime.Now;

		}

		virtual public SkillEffect NewInstance(SkillDataComponent skillComp)
		{
			return new SkillEffect(skillComp);
		}

		public int GetSkillId()
		{
			if (skillComp.skill != null)
				return skillComp.skill.Id;

			return -1;
		}

		public void Process()
		{
			// Check if we need to tick this process
			TimeSpan diff = DateTime.Now - _lastProcessTime;
			if (diff.TotalMilliseconds >= _tickRate)
			{
				_lastProcessTime = DateTime.Now; /// Or should be "=+ _tickRate" ? 
				OnTimer();
			}

			// Check if we need to tick for effect stack
			if (skillComp.skill.Data.buffCanStack)
			{
				diff = DateTime.Now - _lastStackTime;
				if (diff.TotalMilliseconds >= this.tickStackRate)
				{
					_lastStackTime = DateTime.Now;
					OnStack();

				}
			}

		}

		virtual public void OnAdd() { }
		virtual public void OnRemove() { }
		virtual public void OnTimer() { }
		virtual public void OnStack()
		{
			this.stackLevel += 1;
			skillComp.target.skillEffectsManager.AddEffect(this);
		}
	}
}
