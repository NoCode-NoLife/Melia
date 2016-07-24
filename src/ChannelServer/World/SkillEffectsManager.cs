using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.World.SkillEffects;
using Melia.Shared.World;
using Melia.Channel.Network;
using Melia.Shared.Util;

namespace Melia.Channel.World
{
	/// <summary>
	/// The SkillEffectManager is in charge of managing all effects in a given actor.
	/// IT CURRENTLY WORKS ONLY FOR CHARACTERS, SINCE ITS SENDING CLIENT UPDATES TO CHARACTERS. CHANGE BASED ON FUTURE RESEARCH ON PACKETS FOR NPCs.
	/// </summary>
	public class SkillEffectsManager
	{
		/// <summary>
		/// Owner of this manager
		/// </summary>
		public Actor owner;
		/// <summary>
		/// The list of effects being handled by this manager.
		/// </summary>
		public List<SkillEffect> effects;

		/// <summary>
		/// Class Constructor
		/// </summary>
		/// <param name="ownerActor">The owner of this manager</param>
		public SkillEffectsManager(Actor ownerActor)
		{
			// Initialize variables
			this.owner = ownerActor;
			this.effects = new List<SkillEffect>();
		}

		/// <summary>
		/// This function is called in a tick basis, by the actor (usually an Entity) to process effects over that actor.
		/// </summary>
		/*
		public void ProcessEffects()
		{
			// Lock effects list
			lock (effects)
			{
				// Tick every effect
				foreach (var effect in this.effects.ToList())
				{
					//if (effect != null)
						//effect.Process();
				}
			}
		}
		*/

		/// <summary>
		/// This function is called to add an effect to this manager. 
		/// * It will update client accordingly (Adding a BUFF to client when necessary)
		/// * If the effect already exist in this actor, it will extend its expireTime.
		/// This function is in charge of activate the effect after added to actor by the first time.
		/// Note: Buff stack notifications takes place in ZC_BUFF_ADD, called by this process.
		/// </summary>
		/// <param name="effect">The effect to be added to this actor</param>
		public void AddEffect(SkillEffect effect)
		{
			// Get skill for this effect
			Skill skill = effect.skillComp.skill;

			switch (effect.behaviorType)
			{
				case EffectBehaviorType.INSTANT:
					{
						effect.owner = this.owner;
						effect.OnAdd();
						break;
					}
				case EffectBehaviorType.BUFF:
					{
						// Prevent processing this effect, if it has no skill associated.
						if (skill == null)
							return;

						// Lock the effects list
						lock (effects)
						{
							// Check if this new effect is already in this actor, to prevent adding it twice.
							foreach (var currentEffect in effects)
							{
								if (currentEffect.GetSkillId() == effect.GetSkillId() && currentEffect.Data.EffectType == currentEffect.Data.EffectType)
								{
									// At this point, the effect already exist in this actor, so update necessary data and notify the client
									currentEffect.expireTime = DateTime.Now.AddSeconds(currentEffect.Data.LifeTime);

									// We only send the update if necessary (when there is a time displayed in the client or is a stackable effect)
									bool update = true;
									if (currentEffect.Data.LifeTime == 0 && !currentEffect.Data.CanStack)
										update = false;

									if (update)
										if (owner is IEntity)
										{
											// Update buff
											Send.ZC_BUFF_ADD((IEntity)owner, currentEffect, true);
										}

									return;
								}
							}

							// At this point, the effect is a NEW effect, so we add it to the list of effects and activate it (by calling OnAdd() in the effect).
							effect.owner = this.owner;
							effects.Add(effect);
							effect.StartTask();
							//effect.OnAdd();
							if (owner is IEntity)
							{
								// Send client about this new buff addition.
								Send.ZC_BUFF_ADD((IEntity)owner, effect, false);
							}
						}
						break;
					}
					default:
					{
						Log.Error("Effect {0} has no BehaviorType and can't be applied.", effect.Data.EffectType);
						break;
					}
					
			}

			

		}

		/// <summary>
		/// This function removes all effects for a given skill. Updating client accordingly.
		/// </summary
		/// <param name="skill">The skill containing the effects to remvoe from this actor</param>
		public void RemoveEffectsBySkill(Skill skill)
		{
			// Lock effects
			lock (effects)
			{
				// Search through all effects, trying to find all effects belonging to the given skill, removing all effects
				for (int i = effects.Count - 1; i >= 0; i--)
				{
					if (effects[i].GetSkillId() == skill.Id)
					{
						RemoveEffectByIndex(i);
					}
				}
			}
		}

		/// <summary>
		/// Remove all effects for this entity
		/// </summary>
		/// <param name="i">index in effects List in this manager</param>
		public void RemoveAllEffects()
		{
			lock (effects)
			{
				for (int i = effects.Count - 1; i >= 0; i--)
				{
					RemoveEffectByIndex(i);
				}
			}
		}

		/// <summary>
		/// This function will remove an effect from the list, desactivate it, and notify client about it.
		/// </summary>
		/// <param name="i">index in effects List in this manager</param>
		private void RemoveEffectByIndex(int i)
		{
			SkillEffect selectedEffect;

			selectedEffect = effects[i];
			// Deactivate effect
			selectedEffect.Exit();
			// Remove effect from actor
			effects.RemoveAt(i);
			if (owner is IEntity)
			{
				// Update client
				Send.ZC_BUFF_REMOVE((IEntity)owner, selectedEffect);
			}
		}

	}
}
