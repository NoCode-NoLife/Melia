using System;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Ardito
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

            target = caster;
			var character = target as Character;

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, originPos, character.Position.GetDirection(farPos), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);

			// RECOVERY HP

			var maxHP = target.Properties.GetFloat(PropertyName.MHP);
			var healAmount = maxHP * this.GetMaxHPRatio(target as Character, skill);

			var addHp = healAmount - maxHP;
			if (addHp < 0)
				addHp = 0;

			// Heal max of 50% of the players HP
			if (addHp > maxHP * 0.5f)
				addHp = maxHP * 0.5f;

			character.Heal(addHp, 0);

			// RECOVERY STAMINA

			var maxSta = target.Properties.GetFloat(PropertyName.MaxSta);
			var addStamina = maxSta * this.GetStaminaRatio(target as Character, skill);
			var stamina = character.Properties.Stamina;

			var addSta = addStamina - maxSta;

			if (addSta < 0)
				addSta = 0;

			if (addSta > maxSta)
				addSta = maxSta;

			var addStaInt = Convert.ToInt32(addSta);

			var recoverySta = stamina + addSta;

			if (recoverySta > maxSta)
			{
				recoverySta = maxSta;
			}

			character.ModifyStamina(Convert.ToInt32(recoverySta));
		}

		/// <summary>
		/// Gets the MaxHP ratio
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skill"></param>
		private float GetMaxHPRatio(Character character, Skill skill)
		{
			var addHP = skill.Level * 535f;
			var SCR_Get_AbilityReinforceRate = ScriptableFunctions.Skill.Get("SCR_Get_AbilityReinforceRate");
			addHP = addHP * SCR_Get_AbilityReinforceRate(skill);

			var value = addHP - Math.Floor(character.MaxHp * 0.5);

			if (value < 0)
				value = 0;

			return (float)value;
		}

		/// <summary>
		/// Gets the Stamina ratio
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skill"></param>
		private float GetStaminaRatio(Character character, Skill skill)
		{
			var value = skill.Level + 5f;
			var SCR_Get_AbilityReinforceRate = ScriptableFunctions.Skill.Get("SCR_Get_AbilityReinforceRate");

			value = value * SCR_Get_AbilityReinforceRate(skill);

			if (value < 0)
				value = 0;

			return (float)value;
		}
	}
}
