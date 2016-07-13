using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Channel.World.SkillHandlers;
using Melia.Channel.World.SectorActors;

namespace Melia.Channel.World.SkillEffects
{
	public class EffectSafetyZone : SkillEffect
	{

		public EffectSafetyZone(SkillDataComponent skillComp) : base(skillComp) {
			
		}

		public override SkillEffect NewInstance(SkillDataComponent skillComp)
		{
			return new EffectSafetyZone(skillComp);
		}

		public override void OnAdd()
		{
			Log.Debug("OnAdd effect {0} {1} {2}", this.ToString(), this.Handle, this.Id);
			ChannelServer.Instance.World.SubscribeToEvent(WorldManager.EventTypes.ADJUST_DAMAGE_MODIFIER, ReceivedHit, skillComp.target.Handle);
			// Add stats
			Skill skill = skillComp.skill;
			foreach (var statMod in skill.Data.statModifiers.Values)
			{
				skillComp.target.statsManager.AddStatMod(this.Handle, statMod);
			}
		}

		public override void OnRemove()
		{
			ChannelServer.Instance.World.UnscribscribeFromEvent(WorldManager.EventTypes.ADJUST_DAMAGE_MODIFIER, ReceivedHit, skillComp.target.Handle);
			// Remove stats
			Skill skill = skillComp.skill;
			foreach (var statMod in skill.Data.statModifiers)
			{
				skillComp.target.statsManager.RemoveStatMods(this.Handle);
			}
		}

		public override void OnTimer()
		{
			base.OnTimer();
		}

		public override void OnStack()
		{
			//
			base.OnStack();

			// Add stats

			//skillComp.target.statsManager.AddStatMod(this.Handle, statMod)
		}

		public void ReceivedHit(EventData evData)
		{
			if (this.skillComp.originator != null && this.skillComp.originator is GroundSkill)
			{
				GroundSkill groundSkill = (GroundSkill)this.skillComp.originator;
				if (groundSkill.maxInteractions > 0)
				{
					groundSkill.interactions++;
					if (groundSkill.interactions >= groundSkill.maxInteractions)
					{
						groundSkill.Disable();
					}
				}
			}
		}

	}
}
