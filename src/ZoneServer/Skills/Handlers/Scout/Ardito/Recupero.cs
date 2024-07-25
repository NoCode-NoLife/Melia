using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Util;

namespace Melia.Zone.Skills.Handlers.Scout.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Recupero.
	/// </summary>
	[SkillHandler(SkillId.Arditi_Recupero)]
	public class Arditi_Recupero : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, heals the player and increases the max stamina
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			this.RemoveRandomDebuff(caster, skill);
			this.RecoverHp(caster, skill);
			this.RecoverStamina(caster, skill);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, originPos, caster.Position.GetDirection(farPos), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);
		}

		/// <summary>
		/// Potentially removes a random debuff from the caster.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		private void RemoveRandomDebuff(ICombatEntity caster, Skill skill)
		{
			var chance = this.GetRemoveDebuffChance(skill);
			caster.RemoveRandomDebuff(chance);
		}

		/// <summary>
		/// Recovers a certain amount of the caster's HP.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		private void RecoverHp(ICombatEntity caster, Skill skill)
		{
			var beforeHP = caster.Properties.GetFloat(PropertyName.HP);
			var maxHP = caster.Properties.GetFloat(PropertyName.MHP);
			var healAmount = this.GetMaxHpRecoveryRatio(caster, skill);
			var addHp = Math.Min(healAmount, maxHP * 0.5f);

			caster.Heal(addHp, 0);

			var afterHP = caster.Properties.GetFloat(PropertyName.HP);
			var amountHealed = afterHP - beforeHP;

			if (amountHealed > 0)
				Send.ZC_HEAL_INFO(caster, amountHealed, maxHP, HealType.Hp);
		}

		/// <summary>
		/// Recovers a certain amount of the caster's stamina.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		private void RecoverStamina(ICombatEntity caster, Skill skill)
		{
			if (caster is not Character casterCharacter)
				return;

			var maxSta = caster.Properties.GetFloat(PropertyName.MaxSta);
			var addStamina = maxSta * this.GetStaminaRecoveryRatio(skill);

			casterCharacter.ModifyStamina((int)addStamina);
		}

		/// <summary>
		/// Gets the Max HP recovery ratio
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		private float GetMaxHpRecoveryRatio(ICombatEntity caster, Skill skill)
		{
			var SCR_Get_AbilityReinforceRate = ScriptableFunctions.Skill.Get("SCR_Get_AbilityReinforceRate");

			var addHP = skill.Level * 535f;
			var value = Math.Max(0, addHP + (addHP * SCR_Get_AbilityReinforceRate(skill)));

			return value;
		}

		/// <summary>
		/// Gets the Stamina recovery ratio
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		private float GetStaminaRecoveryRatio(Skill skill)
		{
			var SCR_Get_AbilityReinforceRate = ScriptableFunctions.Skill.Get("SCR_Get_AbilityReinforceRate");

			var value = Math.Max(0, (skill.Level + 5) * SCR_Get_AbilityReinforceRate(skill));

			return (float)value;
		}

		/// <summary>
		/// Returns the remove Debuff ratio
		/// </summary>
		/// <returns></returns>
		private int GetRemoveDebuffChance(Skill skill)
		{
			return Math.Clamp(skill.Level * 10, 0, 100);
		}
	}
}
