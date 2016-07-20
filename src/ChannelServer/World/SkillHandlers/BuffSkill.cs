using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Shared.World;
using Melia.Shared.Const;
using Melia.Channel.World.SkillEffects;

namespace Melia.Channel.World.SkillHandlers
{
	public class BuffSkill : SkillHandler
	{
		/// <summary>
		/// This function is the entry point for processing the skill.
		/// </summary>
		override public SkillResult ProcessSkill(Actor target, Skill skill, Actor originator)
		{
			SkillResult skillResult = null;
			if (target is IEntity)
			{
				var entityTarget = (IEntity)target;

				skillResult = new SkillResult();
				skillResult.actor = (Entity)target;
				skillResult.skillHandle = skill.Handle;
				skillResult.targetHandle = target.Handle;
				skillResult.value = 0;


				SkillDataComponent skillComp = new SkillDataComponent();
				skillComp.skill = skill;
				skillComp.skillHandler = this;
				skillComp.caster = skill.owner;
				skillComp.target = (IEntity)target;
				skillComp.originator = originator;

				Log.Debug("Count effects: {0}", skill.GetData().effects.Count);
				foreach (var effectData in skill.GetData().effects)
				{
					Log.Debug("Processing effect {0}", effectData.EffectType);
					SkillEffect newEffect = SkillEffect.GetSkillEffect(effectData.EffectType, effectData, skillComp);
					switch (newEffect.behaviorType)
					{
						case EffectBehaviorType.INSTANT:
							{
								skillResult = newEffect.Instant();
								break;
							}
						case EffectBehaviorType.BUFF:
							{
								entityTarget.skillEffectsManager.AddEffect(newEffect);
								break;
							}
						default:
							{
								Log.Error("effect behavior is not defined. Effect cannot be applied.");
								break;
							}
					}
					
				}
			}

			return skillResult;
		}
		/*
		public void OnStack(Buff buff, int stackLevel)
		{
			if (buff.owner is IEntity)
			{
				var entityTarget = (IEntity)buff.owner;
				StatModifier tempMod;
				foreach (var mod in buff.StatModifiers.Values)
				{
					tempMod = mod;
					tempMod.modifierValue = mod.modifierValue + stackLevel;
					entityTarget.statsManager.AddStatMod(buff.Handle, tempMod);
				}
			}
		}
		*/
	}
}
