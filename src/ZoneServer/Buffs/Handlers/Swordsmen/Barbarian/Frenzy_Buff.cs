using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handler for the Frenzy Buff, which increases attack speed
	/// damage dealt, and damage received as long as you keep
	/// attacking the same target.
	/// </summary>
	/// <remarks>
	/// NumArg1: None
	/// NumArg2: None
	/// 
	/// Note that this buff stores the character you have frenzy
	/// against as the caster, while the character having the
	/// frenzy is the target.
	/// </remarks>
	[BuffHandler(BuffId.Frenzy_Buff)]
	public class Frenzy_Buff : BuffHandler, IBuffCombatDefenseBeforeCalcHandler
	{
		private const float ASpdBonusBase = 150;
		private const float ASpdBonusPerStack = 10;

		public override void OnStart(Buff buff)
		{
			this.UpdateStacks(buff);
			this.UpdateBonus(buff);
		}

		public override void WhileActive(Buff buff)
		{
			if (buff.OverbuffCounter == 0)
			{
				buff.Target.StopBuff(BuffId.Frenzy_Buff);
				return;
			}

			// Decay one stack every tick
			buff.OverbuffCounter--;
			Send.ZC_BUFF_UPDATE(buff.Target, buff);

			this.UpdateBonus(buff);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.ASPD_BM);
		}

		public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// The user takes 0.5% more damage per stack of Frenzy. The damage
			// increase part can be found in the Franzy skill handler.
			modifier.DamageMultiplier += 0.005f * buff.OverbuffCounter;
		}

		/// <summary>
		/// Updates stacks, capping the overbuff counter at the current maximum.
		/// </summary>
		/// <param name="buff"></param>
		private void UpdateStacks(Buff buff)
		{
			var maxStacks = 2;

			// Increase max stacks based on Frenzy skill level
			if (buff.Target.TryGetSkill(SkillId.Barbarian_Frenzy, out var frenzySkill))
				maxStacks = frenzySkill.Level * 2;

			// Half max stacks if Barbarian22 is active
			if (buff.Target.IsAbilityActive(AbilityId.Barbarian22))
				maxStacks /= 2;

			if (buff.OverbuffCounter > maxStacks)
				buff.OverbuffCounter = maxStacks;
		}

		/// <summary>
		/// Adds or updates the buff's attack speed bonus.
		/// </summary>
		/// <param name="buff"></param>
		private void UpdateBonus(Buff buff)
		{
			UpdatePropertyModifier(buff, buff.Target, PropertyName.ASPD_BM, ASpdBonusBase + buff.OverbuffCounter * ASpdBonusPerStack);
		}
	}
}
