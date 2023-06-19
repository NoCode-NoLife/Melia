using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.General
{
	/// <summary>
	/// Generic handler for ground skills.
	/// </summary>
	public class GroundSkillHandler : IGroundSkillHandler
	{
		public void Handle(Skill skill, ICombatEntity caster, Position castPosition, Position targetPosition, ICombatEntity designatedTarget)
		{
			var castedRange = castPosition.Get3DDistance(targetPosition);
			if (castedRange > skill.Data.MaxRange)
			{
				Log.Warning("GroundSkillHandler: Player {0} cast skill with id {1} farther than max range ({2} > {3}).", caster.Name, skill.Id, castedRange, skill.Data.MaxRange);
				return;
			}

			if (skill.SpendSp > 0)
				caster.Properties.Modify(PropertyName.SP, -skill.SpendSp);

			skill.IncreaseOverheat();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, targetPosition);

			switch (skill.Id)
			{
				case SkillId.Wizard_MagicMissile:
				{
					var targets = caster.Map.GetAttackableEntitiesInRange(caster, targetPosition, (int)skill.Data.SplashRange);
					var damage = SCR_GetRandomAtk(caster, null, skill);

					var hits = new List<SkillHitInfo>();
					var anyDead = false;

					foreach (var target in targets)
					{
						if (caster is Character characterCaster)
						{
							Send.ZC_NORMAL.SkillParticleEffect(characterCaster, 1234);
							Send.ZC_SYNC_START(characterCaster, 1234, 1);
							Send.ZC_NORMAL.Skill_16(characterCaster, target, targetPosition);
							Send.ZC_SYNC_END(characterCaster, 1234, 0);
						}

						if (target.TakeDamage(damage, caster))
							anyDead = true;

						var skillHitInfo = new SkillHitInfo(caster, target, skill, damage, TimeSpan.FromMilliseconds(306), TimeSpan.FromMilliseconds(50));
						hits.Add(skillHitInfo);
					}

					Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, hits);

					if (anyDead)
						Send.ZC_SKILL_CAST_CANCEL(caster);

					break;
				}

				case SkillId.Archer_Multishot:
				{
					var targets = caster.Map.GetAttackableEntitiesInRange(caster, targetPosition, (int)skill.Data.SplashRange);
					var damage = SCR_GetRandomAtk(caster, null, skill);

					var characterCaster = caster as Character;
					if (characterCaster != null)
					{
						Send.ZC_NORMAL.Skill_4E(characterCaster, skill.Id, 1);
						Send.ZC_NORMAL.Skill(characterCaster, skill, targetPosition, caster.Direction, true);
						Send.ZC_NORMAL.Unknown_06(characterCaster, targetPosition);
						Send.ZC_SYNC_START(characterCaster, 1234, 1);
						Send.ZC_SYNC_END(characterCaster, 1234, 0);
						Send.ZC_SYNC_EXEC_BY_SKILL_TIME(characterCaster, 1234, skill.Data.DefaultHitDelay);
						Send.ZC_SKILL_MELEE_GROUND(characterCaster, skill, targetPosition, null);
						Send.ZC_SYNC_EXEC(characterCaster, 1234);
					}

					for (var i = 0; i < 10; i++)
					{
						Task.Delay(skill.Data.DefaultHitDelay).ContinueWith(_ =>
						{
							if (characterCaster != null)
							{
								Send.ZC_NORMAL.Unknown_06(characterCaster, targetPosition);
								Send.ZC_SYNC_START(characterCaster, 1234, 1);
								Send.ZC_SYNC_END(characterCaster, 1234, 0);
								Send.ZC_SYNC_EXEC_BY_SKILL_TIME(characterCaster, 1234, skill.Data.DefaultHitDelay);
								Send.ZC_SYNC_EXEC(characterCaster, 1234);
							}

							foreach (var target in targets)
							{
								target.TakeDamage(damage, caster);
								Send.ZC_HIT_INFO(caster, target, skill, new HitInfo(damage, target.Hp, i + 1, HitResultType.MagicMissile));

								if (target.IsDead)
									Send.ZC_SKILL_CAST_CANCEL(caster);
							}
						});
					}

					if (characterCaster != null)
						Send.ZC_SKILL_DISABLE(characterCaster);
					break;
				}

				default:
				{
					var hits = new List<SkillHitInfo>();
					var anyDead = false;

					var targets = caster.Map.GetAttackableEntitiesInRange(caster, targetPosition, (int)skill.Data.SplashRange);
					var damage = SCR_GetRandomAtk(caster, null, skill);

					foreach (var target in targets)
					{
						if (target.TakeDamage(damage, caster))
							anyDead = true;

						var skillHitInfo = new SkillHitInfo(caster, target, skill, damage, TimeSpan.FromMilliseconds(306), TimeSpan.FromMilliseconds(50));
						hits.Add(skillHitInfo);
					}

					Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, hits);

					if (anyDead)
						Send.ZC_SKILL_CAST_CANCEL(caster);
					break;
				}
			}
		}
	}
}
