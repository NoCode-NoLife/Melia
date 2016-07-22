using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Channel.World.SkillHandlers;
using Melia.Channel.World.SectorActors;
using Melia.Shared.Data.Database;

namespace Melia.Channel.World.SkillEffects
{
	/// <summary>
	/// EffectSafetyZone is an effect that acts like a BUFF that handles actions when the affected actor receives a hit, and applies stats changes.
	/// NOTE: This effect was called "Safety Zone" because it was created for Cleric's Safety Zone skill (skillId 40003), but it got used for other skills.
	///       It should be renamed later, when finding an appropiate name and funcionality. The idea is to abstract its effect to be able to be used by different skill.
	/// </summary>
	public class EffectSafetyZone : SkillEffect
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public EffectSafetyZone(SkillEffectData effectData, SkillDataComponent skillComp) : base(effectData, skillComp) {
			this.behaviorType = EffectBehaviorType.BUFF;
		}

		/// <summary>
		/// It creates and return an instance of this effect, initializing it with provided SkillDataComponent
		/// </summary>
		/// <param name="skillComp">SkillDataComponent used to initialize the new instance</param>
		public override SkillEffect NewInstance(SkillEffectData effectData, SkillDataComponent skillComp)
		{
			return new EffectSafetyZone(effectData, skillComp);
		}

		/// <summary>
		/// This is a virtual function called when this effect got added in target.
		/// </summary>
		public override void OnAdd()
		{
			// Subscribe this effect to receive events from this target.
			ChannelServer.Instance.World.SubscribeToEvent(WorldManager.EventTypes.ADJUST_DAMAGE_MODIFIER, ReceivedHit, skillComp.target.Handle);

			// Add stats modifiers to target
			Skill skill = skillComp.skill;
			foreach (var statMod in skill.GetData().statModifiers.Values)
			{
				skillComp.target.statsManager.AddStatMod(this.Handle, statMod);
			}
		}

		/// <summary>
		/// Virtual function called when this effects got removed from target.
		/// </summary>
		public override void OnRemove()
		{
			// Unsubscribe this effect from event system.
			ChannelServer.Instance.World.UnsubscribeFromEvent(WorldManager.EventTypes.ADJUST_DAMAGE_MODIFIER, ReceivedHit, skillComp.target.Handle);
			// Remove stats modifiers
			Skill skill = skillComp.skill;
			foreach (var statMod in skill.GetData().statModifiers)
			{
				skillComp.target.statsManager.RemoveStatMods(this.Handle);
			}
		}

		/// <summary>
		/// Virtual function called when this effect is applied again on the same target, and is a stackable effect.
		/// </summary>
		public override void OnStack()
		{
			//
			base.OnStack();

			// Add stats mods to target, based on stack level
			/// TODO
			//skillComp.target.statsManager.AddStatMod(this.Handle, statMod)
		}

		/// <summary>
		/// Function that is delegated to the World's event system. It will be invoked on EventTypes.ADJUST_DAMAGE_MODIFIER event.
		/// </summary>
		public EventResult ReceivedHit(EventData evData)
		{
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

			return null;
		}

	}
}
