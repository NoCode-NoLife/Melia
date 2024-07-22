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
using Yggdrasil.Util;

namespace Melia.Zone.Skills.Handlers.Scout.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Recupero.
	/// </summary>
	[SkillHandler(SkillId.Arditi_Recupero)]
	public class Recupero : IGroundSkillHandler
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

			// Remove Buff
			var removeDebuffRatio = Math.Clamp(this.GetRemoveDebuffRatio(skill), 0, 100);
			var rnd = RandomProvider.Get();

			if (removeDebuffRatio == 100 || rnd.Next(100) < removeDebuffRatio)
			{
				caster.RemoveRandomDebuff();
			}

			// Recovery HP
			// Properties.GetFloat(PropertyName.MHP)
			var beforeHP = caster.Properties.GetFloat(PropertyName.HP);
			var maxHP = caster.Properties.GetFloat(PropertyName.MHP);
			var healAmount = this.GetMaxHPRecoveryRatio(caster, skill);
			var addHp = Math.Min(healAmount, maxHP * 0.5f);
			caster.Heal(addHp, 0);
			var afterHP = caster.Properties.GetFloat(PropertyName.HP);

			if (beforeHP < afterHP)
			{
				Send.ZC_HEAL_INFO(caster, afterHP - beforeHP, maxHP, HealType.Hp);
			}

			// Recovery Stamina
			if (caster is Character casterCharacter)
			{
				var maxSta = caster.Properties.GetFloat(PropertyName.MaxSta);
				var addStamina = maxSta * this.GetStaminaRecoveryRatio(skill);
				casterCharacter.ModifyStamina((int)addStamina);
			}

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, originPos, caster.Position.GetDirection(farPos), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);
		}

		/// <summary>
		/// Gets the Max HP recovery ratio
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		private float GetMaxHPRecoveryRatio(ICombatEntity caster, Skill skill)
		{
			var addHP = skill.Level * 535f;
			var SCR_Get_AbilityReinforceRate = ScriptableFunctions.Skill.Get("SCR_Get_AbilityReinforceRate");
			var value = addHP + (addHP * SCR_Get_AbilityReinforceRate(skill));

			if (value < 0)
				value = 0;

			return value;
		}

		/// <summary>
		/// Gets the Stamina recovery ratio
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		private float GetStaminaRecoveryRatio(Skill skill)
		{
			var value = skill.Level + 5f;
			var SCR_Get_AbilityReinforceRate = ScriptableFunctions.Skill.Get("SCR_Get_AbilityReinforceRate");

			value = value * SCR_Get_AbilityReinforceRate(skill);

			if (value < 0)
				value = 0;

			return (float)value;
		}

		/// <summary>
		/// Returns the remove Debuff ratio
		/// </summary>
		/// <returns></returns>
		private int GetRemoveDebuffRatio(Skill skill)
		{
			return skill.Level * 10;
		}
	}
}
