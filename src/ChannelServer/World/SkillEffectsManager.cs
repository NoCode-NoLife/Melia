using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.World.SkillEffects;
using Melia.Shared.World;
using Melia.Channel.Network;

namespace Melia.Channel.World
{
	public class SkillEffectsManager
	{
		public Actor owner;
		public List<SkillEffect> effects;

		public SkillEffectsManager(Actor ownerActor)
		{
			this.owner = ownerActor;

			this.effects = new List<SkillEffect>();
		}

		public void AddEffect(SkillEffect effect)
		{
			
			Skill skill = effect.skillComp.skill;

			if (skill == null)
				return;

			lock (effects)
			{
				foreach (var currentEffect in effects)
				{
					if (currentEffect.GetSkillHandle() == effect.GetSkillHandle())
					{

						if (skill.Data.buffCanStack)
						{
							// Stack effect
							currentEffect.OnStack();
						}

						currentEffect.expireTime = DateTime.Now.AddSeconds(skill.Data.buffLifeInSeconds);

						bool update = true;
						if (skill.Data.buffLifeInSeconds == 0 && !skill.Data.buffCanStack)
							update = false;

						if (update)
							// Update buff
							Send.ZC_BUFF_ADD_3((Character)owner, currentEffect, true);

						return;
					}
				}

				effects.Add(effect);
				effect.OnAdd();
				Send.ZC_BUFF_ADD_3((Character)owner, effect, false);
			}

		}

		public void RemoveExpiredEffects()
		{
			SkillEffect selectedEffect;

			lock (effects)
			{
				for (int i = effects.Count - 1; i >= 0; i--)
				{
					if (!effects[i].isPermanent && effects[i].expireTime < DateTime.Now)
					{
						selectedEffect = effects[i];
						selectedEffect.OnRemove();
						effects.RemoveAt(i);
						Send.ZC_BUFF_REMOVE_2((Character)owner, selectedEffect);
					}
				}
			}
		}

		public void RemoveEffectsBySkill(Skill skill)
		{
			SkillEffect selectedEffect;

			lock (effects)
			{
				for (int i = effects.Count - 1; i >= 0; i--)
				{
					if (effects[i].GetSkillHandle() == skill.Handle)
					{
						selectedEffect = effects[i];
						selectedEffect.OnRemove();
						effects.RemoveAt(i);
						Send.ZC_BUFF_REMOVE_2((Character)owner, selectedEffect);
					}
				}
			}
		}

	}
}
