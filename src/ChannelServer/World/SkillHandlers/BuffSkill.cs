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
		override public SkillResult ProcessSkill(Actor target, Skill skill)
		{
			SkillResult skillResult = null;
			if (target is IEntity)
			{
				var entityTarget = (IEntity)target;

				skillResult = new SkillResult();
				skillResult.actor = target;
				skillResult.skillHandle = skill.Handle;
				skillResult.targetHandle = target.Handle;
				skillResult.value = 0;

				SkillDataComponent skillComp = new SkillDataComponent();
				skillComp.skill = skill;
				skillComp.skillHandler = this;
				skillComp.caster = skill.owner;
				skillComp.target = (IEntity) target;

				foreach (var effect in skill.effects)
				{
					SkillEffect newEffect = effect.NewInstance(skillComp);
					entityTarget.skillEffectsManager.AddEffect(newEffect);
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
