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

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, originPos, caster.Position.GetDirection(farPos), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);

			// RECOVERY HP
			var maxHP = target.Properties.GetFloat(PropertyName.MHP);
			var healAmount = maxHP * this.GetMaxHPRatio(caster, skill);
			var addHp = Math.Min(Math.Max(0, maxHP * 0.5f), healAmount - maxHP);	
			caster.Heal(addHp, 0);

			// RECOVERY STAMINA
			if (caster is Character casterCharacter)
			{
				var maxSta = target.Properties.GetFloat(PropertyName.MaxSta);
				var addStamina = maxSta * this.GetStaminaRatio(skill);
				var stamina = casterCharacter.Properties.Stamina;
				var addSta = Math.Min(Math.Max(0, maxSta), addStamina - maxSta);
				casterCharacter.ModifyStamina((int)addSta);
			}
		}

		/// <summary>
		/// Gets the MaxHP ratio
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skill"></param>
		private float GetMaxHPRatio(ICombatEntity caster, Skill skill)
		{
			var addHP = skill.Level * 535f;
			var SCR_Get_AbilityReinforceRate = ScriptableFunctions.Skill.Get("SCR_Get_AbilityReinforceRate");
			addHP = addHP * SCR_Get_AbilityReinforceRate(skill);

			var value = addHP - Math.Floor(caster.Properties.GetFloat(PropertyName.MHP) * 0.5);

			if (value < 0)
				value = 0;

			return (float)value;
		}

		/// <summary>
		/// Gets the Stamina ratio
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skill"></param>
		private float GetStaminaRatio(Skill skill)
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
