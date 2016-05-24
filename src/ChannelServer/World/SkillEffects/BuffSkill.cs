using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Shared.World;
using Melia.Shared.Const;

namespace Melia.Channel.World.SkillEffects
{
	public class BuffSkill : SkillEffect
	{
		override public SkillResult ProcessSkill(Actor target, Skill skill)
		{
			SkillResult skillResult = null;
			if (target is IEntity)
			{
				var entityTarget = (IEntity)target;

				entityTarget.buffManager.AddToBuffs(skill);

				skillResult = new SkillResult();
				skillResult.actor = target;
				skillResult.skillHandle = skill.Handle;
				skillResult.targetHandle = target.Handle;
				skillResult.value = 0;
			}

			return skillResult;
		}

		public void OnAdd(Buff buff)
		{
			if (buff.owner is IEntity)
			{
				var entityTarget = (IEntity)buff.owner;
				foreach (var mod in buff.StatModifiers.Values)
				{
					entityTarget.statsManager.AddStatMod(buff.Handle, mod);
				}
			}
		}

		public void OnRemove(Buff buff)
		{
			if (buff.owner is IEntity)
			{
				var entityTarget = (IEntity)buff.owner;
				entityTarget.statsManager.RemoveStatMods(buff.Handle);
			}
		}

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
	}
}
