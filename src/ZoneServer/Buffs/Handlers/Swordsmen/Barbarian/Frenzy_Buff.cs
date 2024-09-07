using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Yggdrasil.Logging;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handler for the Frenzy Buff, which increases attack speed
	/// damage dealt, and damage received as long as you keep
	/// attacking the same target.
	/// </summary>
	/// <remarks>
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
			var maxStacks = 2;
			if (buff.Target.TryGetSkill(SkillId.Barbarian_Frenzy, out var frenzySkill))
				maxStacks = frenzySkill.Level * 2;

			// Barbarian22 halves the maximum stacks
			if (buff.Target.IsAbilityActive(AbilityId.Barbarian22))
				maxStacks /= 2;

			if (buff.OverbuffCounter > maxStacks)
			{
				// don't allow it to overbuff any further
				buff.OverbuffCounter = maxStacks;
			}

			// Add or update the bonus ASpd
			ApplyASpdBonus(buff);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.ASPD_BM);
		}

		public override void WhileActive(Buff buff)
		{
			// decay 1 overbuff counter
			if (buff.OverbuffCounter > 1)
			{
				buff.OverbuffCounter--;
				Send.ZC_BUFF_UPDATE(buff.Target, buff);

				ApplyASpdBonus(buff);
			}
			else
			{
				buff.Target.StopBuff(BuffId.Frenzy_Buff);
			}
		}

		public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// The user takes 0.5% more damage per stack of Frenzy
			// The increase to your outgoing damage is the in Frenzy Skill
			modifier.DamageMultiplier += 0.005f * buff.OverbuffCounter;
		}

		/// <summary>
		/// Applies the bonus Aspd, while also removing any previous buff beforehand
		/// </summary>
		/// <param name="buff"></param>
		private void ApplyASpdBonus(Buff buff)
		{
			// reset the aspd buff if it's already present so it doesn't stack
			RemovePropertyModifier(buff, buff.Target, PropertyName.ASPD_BM);

			AddPropertyModifier(buff, buff.Target, PropertyName.ASPD_BM, ASpdBonusBase + buff.OverbuffCounter * ASpdBonusPerStack);
		}
	}
}
