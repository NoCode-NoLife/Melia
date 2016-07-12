using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.World.SkillHandlers;

namespace Melia.Channel.World.SkillEffects
{
	public class SkillEffect
	{
		public int Id;
		public int Handle;

		private DateTime _lastProcessTime;
		private double _tickRate = 500.0;

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
			stackLevel = 1;
			expireTime = DateTime.Now.AddSeconds(skillComp.skill.Data.buffLifeInSeconds);
			isPermanent = skillComp.skill.Data.buffIsPermanent;
			//skillComp.target.EffectAdd(this);

			_lastProcessTime = DateTime.Now;

		}

		virtual public SkillEffect NewInstance(SkillDataComponent skillComp)
		{
			return new SkillEffect(skillComp);
		}

		public int GetSkillHandle()
		{
			if (skillComp.skill != null)
				return skillComp.skill.Handle;

			return -1;
		}

		public void Process()
		{
			// Check if we need to tick this process
			TimeSpan diff = DateTime.Now - _lastProcessTime;
			if (diff.TotalMilliseconds < _tickRate)
				return;

			_lastProcessTime = DateTime.Now; /// Or should be "=+ _tickRate" ? 

			// 
			OnTimer();

		}

		virtual public void OnAdd() { }
		virtual public void OnRemove() { }
		virtual public void OnTimer() { }
		virtual public void OnStack()
		{
			stackLevel += 1;
		}
	}
}
