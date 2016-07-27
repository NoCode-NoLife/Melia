using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Channel.World.SkillHandlers;
using Melia.Channel.World.SectorActors;
using Melia.Channel.Network;
using Melia.Shared.Data.Database;
using Melia.Shared.Const;

namespace Melia.Channel.World.SkillEffects
{
	public class Cure : SkillEffect
	{ 

		public Cure(SkillEffectData effectData, SkillDataComponent skillComp) : base(effectData, skillComp)
		{
			this.behaviorType = EffectBehaviorType.BUFF;
		}

		/// <summary>
		/// It creates and return an instance of this effect, initializing it with provided SkillDataComponent
		/// </summary>
		/// <param name="skillComp">SkillDataComponent used to initialize the new instance</param>
		public override SkillEffect NewInstance(SkillEffectData effectData, SkillDataComponent skillComp)
		{
			return new Cure(effectData, skillComp);
		}

		public override void OnTimer()
		{
			TargetType targetType = this.skillComp.caster.GetTargetType(this.skillComp.target);

			if ((targetType & TargetType.MONSTER) != TargetType.NONE)
			{
				if (this.skillComp.caster is Character)
				{
					//
					// Check if effects' originator is a GroundSkill
					if (this.skillComp.originator != null && this.skillComp.originator is GroundSkill)
					{
						// Add GroundSkill's interaction counter, disabling the GroundSkill if reached the limit of interactions.
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

					//
					int damage = Formulas.INTAttack(this.Data.Amount, this.skillComp.caster);

					this.skillComp.target.TakeDamage(damage, this.skillComp.caster);

					SkillResult sResult = new SkillResult();
					sResult.actor = (Entity)this.skillComp.target;
					sResult.targetHandle = this.skillComp.target.Handle;
					sResult.skillHandle = this.skillComp.skill.Handle;
					sResult.value = damage;
					sResult.type = 1;
					List<SkillResult> hitResults = new List<SkillResult>();
					hitResults.Add(sResult);

					Send.ZC_SKILL_HIT_INFO(this.skillComp.caster, hitResults);

					return;
				}
			}
		}
	}
}
