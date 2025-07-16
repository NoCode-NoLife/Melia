using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Matador
{
	/// <summary>
	/// Handle for the Muleta Cast Buff, which makes the character immune to some type of attacks.
	/// </summary>
	[BuffHandler(BuffId.Muleta_Cast_Buff)]
	public class Muleta_Cast_Buff : BuffHandler, IBuffCombatAttackAfterCalcHandler
	{
		/// <summary>
		/// Makes the character immune to some type of physical attacks,
		/// Also can decrease cooldown for Matador skills on hits.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnAttackAfterCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!target.IsBuffActive(BuffId.Muleta_Cast_Buff))
				return;

			// Melee physical attacks ignored when counter-attacking (Matador).
			if (skill.Data.AttackType == SkillAttackType.Slash || skill.Data.AttackType == SkillAttackType.Strike || skill.Data.AttackType == SkillAttackType.Melee)
			{
				// Muleta: Counterattack Master
				if (attacker.Race == RaceType.Widling || target.IsAbilityActive(AbilityId.Matador8))
				{
					target.StopBuff(BuffId.IS_Channeling_Buff);

					if (target is Character targetCharacter)
					{
						// [Arts] Muleta: Faena
						// Casts Faena instead of default attack when counter-attacking
						if (targetCharacter.IsAbilityActive(AbilityId.Matador26))
							Send.ZC_NORMAL.ForceClientCastSkill(targetCharacter, SkillId.Matador_Muleta, SkillId.Matador_Muleta_Faena);
						else
							Send.ZC_NORMAL.ForceClientCastSkill(targetCharacter, SkillId.Matador_Muleta, SkillId.Muleta_Attack);

						// Muleta: Showtime
						if (targetCharacter.IsAbilityActive(AbilityId.Matador16) && targetCharacter.TryGetAbility(AbilityId.Matador16, out var ability))
						{
							var reductionInSeconds = ability.Level;
							var matadorSkillTreeDataList = ZoneServer.Instance.Data.SkillTreeDb.FindSkillIds(JobId.Matador);

							foreach (var charSkill in targetCharacter.Skills.GetList())
							{
								if (charSkill.Id == SkillId.Matador_Muleta)
									continue;

								if (matadorSkillTreeDataList.Contains(charSkill.Id) && charSkill.IsOnCooldown)
									charSkill.ReduceCooldown(TimeSpan.FromSeconds(reductionInSeconds));
							}
						}
					}
				}

				modifier.FinalDamageMultiplier *= 0;
			}
		}
	}
}
