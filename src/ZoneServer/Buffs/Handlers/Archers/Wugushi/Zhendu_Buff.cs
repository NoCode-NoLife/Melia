using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handle for the Zhendy Buff.
	/// </summary>
	[BuffHandler(BuffId.Zhendu_Buff)]
	public class Zhendu_Buff : BuffHandler, IBuffCombatDefenseBeforeCalcHandler
	{
		/// <summary>
		/// Applies the buff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			var wugushiSKills = new List<SkillId>() { SkillId.Wugushi_JincanGu, SkillId.Wugushi_JincanGuBug, SkillId.Wugushi_LatentVenom, SkillId.Wugushi_NeedleBlow, SkillId.Wugushi_WideMiasma, SkillId.Wugushi_WugongGu, SkillId.Wugushi_CrescendoBane };

			if (wugushiSKills.Contains(skill.Id))
			{
				var skillLevel = buff.NumArg1;
				var multiplierIncrease = this.GetIncreaseDamageValue((int)skillLevel);

				modifier.DamageMultiplier += multiplierIncrease;
			}
		}

		/// <summary>
		/// Return the multiplier value that will increase the Wugushi skill's damage by a percentage
		/// </summary>
		/// <param name="skillLevel"></param>
		private float GetIncreaseDamageValue(int skillLevel)
		{
			return 1 + (5 + skillLevel * 2) / 100f;
		}
	}
}
