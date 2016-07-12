using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Channel.World.SkillHandlers;

namespace Melia.Channel.World.SkillEffects
{
	public class EffectSafetyZone : SkillEffect
	{

		public EffectSafetyZone(SkillDataComponent skillComp) : base(skillComp) {
			Id = 94;
		}

		public override SkillEffect NewInstance(SkillDataComponent skillComp)
		{
			return new EffectSafetyZone(skillComp);
		}

		public override void OnAdd()
		{
			
		}

		public override void OnRemove()
		{
			
		}

		public override void OnTimer()
		{
			
		}

		public override void OnStack()
		{
			base.OnStack();
		}

	}
}
