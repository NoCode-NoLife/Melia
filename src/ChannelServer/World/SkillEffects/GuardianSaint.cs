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

namespace Melia.Channel.World.SkillEffects
{
	/// <summary>
	/// 
	/// </summary>
	public class GuardianSaint : SkillEffect
	{
		/// <summary>
		/// 
		/// </summary>
		private int _interactionsCount;
		private int _maxInteractions;

		/// <summary>
		/// Constructor
		/// </summary>
		public GuardianSaint(SkillEffectData effectData, SkillDataComponent skillComp) : base(effectData, skillComp)
		{
			_interactionsCount = 0;
			_maxInteractions = effectData.Amount;
		}

		/// <summary>
		/// It creates and return an instance of this effect, initializing it with provided SkillDataComponent
		/// </summary>
		/// <param name="skillComp">SkillDataComponent used to initialize the new instance</param>
		public override SkillEffect NewInstance(SkillEffectData effectData, SkillDataComponent skillComp)
		{
			return new GuardianSaint(effectData, skillComp);
		}

		/// <summary>
		/// This is a virtual function called when this effect got added in target.
		/// </summary>
		public override void OnAdd()
		{
			// Subscribe this effect to receive events from this target.
			Log.Debug("Subscribe to CASTER TAKEDAMAGE: CASTER:{0} TARGET: {1}", skillComp.caster.Handle, skillComp.target.Handle);
			ChannelServer.Instance.World.SubscribeToEvent(WorldManager.EventTypes.TAKE_DAMAGE, TakeDamage, skillComp.caster.Handle);

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
			Log.Debug("UNSBISCRIBE to CASTER TAKEDAMAGE: CASTER:{0} TARGET: {1} !!!!!", skillComp.caster.Handle, skillComp.target.Handle);
			ChannelServer.Instance.World.UnsubscribeFromEvent(WorldManager.EventTypes.TAKE_DAMAGE, TakeDamage, skillComp.caster.Handle);
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
		public EventResult TakeDamage(EventData evData)
		{
			Log.Debug("Calling GuardianSaint TakeDamage delegate!");
			Log.Debug("interactions count: {0}/{1}", _interactionsCount, _maxInteractions);

			EventResult evResult = new EventResult();

			// Prevent other hits to go through.
			if (_interactionsCount >= _maxInteractions)
				return evResult;

			// Increase interactions 
			_interactionsCount++;

			var rnd = new Random();
			var changeOfHit = rnd.Next(0, 10);

			// If the caster gets protected by Guardian Saint skill
			Log.Debug("Rand {0}", changeOfHit);
			if (changeOfHit > 5)
			{
				this.skillComp.target.TakeDamage((int)evData.damage, evData.damageFrom);

				SkillResult sResult = new SkillResult();
				sResult.actor = (Entity)this.skillComp.target;
				sResult.targetHandle = this.skillComp.target.Handle;
				sResult.skillHandle = this.skillComp.skill.Handle;
				sResult.value = evData.damage;
				sResult.type = 1;
				List<SkillResult> hitResults = new List<SkillResult>();
				hitResults.Add(sResult);

				Send.ZC_SKILL_HIT_INFO(evData.damageFrom, hitResults);

				/// TODO how to prevent damage to caster when succeed?
				evResult.iValue = 1;

				this.skillComp.caster.SetOneHitInmunity(true);
			}

			// Remove this effect if condition met
			if (_interactionsCount >= _maxInteractions)
			{
				this.skillComp.target.skillEffectsManager.RemoveEffectsBySkill(this.skillComp.skill);
			}
				

			return evResult;

		}

	}
}
