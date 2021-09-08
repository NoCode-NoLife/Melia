using System.Threading.Tasks;
using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.Skills.General
{
	/// <summary>
	/// Generic Ground Skill Handler
	/// </summary>
	public class GroundSkillHandler : IGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition)
		{
			var castedRange = castPosition.Get3DDistance(targetPosition);
			if (castedRange > skill.Data.MaxRange)
			{
				Log.Warning("GroundSkillHandler: Player {0} cast skill with id {1} farther than max range ({2} > {3}).", caster.Name, skill.Id, castedRange, skill.Data.MaxRange);
				return;
			}

			// TODO: Cancel if not enough SP?

			if (skill.SpendSp > 0)
				caster.ModifySp(-skill.SpendSp);

			if (skill.CanOverheat)
				skill.OverheatCounter++; // Replace with IncreaseOverheat, it's more verbose?

			Send.ZC_OVERHEAT_CHANGED(caster, skill);

			if (!skill.CanOverheat || skill.IsOverheated)
			{
				Send.ZC_COOLDOWN_CHANGED(caster, skill);
				skill.ResetOverheat();
			}

			Send.ZC_SKILL_READY(caster, skill, caster.Position, targetPosition);

			switch (skill.Id)
			{
				case SkillId.Wizard_MagicMissile:
				{
					var targets = caster.Map.GetAttackableEntitiesInRange(caster, targetPosition, (int)skill.Data.SplashRange);
					var damage = caster.GetRandomPAtk() + 100;

					Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, targets, damage);

					foreach (var target in targets)
					{
						Send.ZC_NORMAL_SkillParticleEffect(caster, 1234);
						Send.ZC_SYNC_START(caster, 1234, 1);
						Send.ZC_NORMAL_Skill_16(caster, target, targetPosition);
						Send.ZC_SYNC_END(caster, 1234, 0);

						if (target.TakeDamage(damage, caster, 0))
							Send.ZC_SKILL_CAST_CANCEL(caster, target);
					}
					break;
				}

				case SkillId.Archer_Multishot:
				{
					var targets = caster.Map.GetAttackableEntitiesInRange(caster, targetPosition, (int)skill.Data.SplashRange);
					var damage = caster.GetRandomPAtk();

					Send.ZC_NORMAL_Skill_4E(caster, skill.Id, 1);
					Send.ZC_NORMAL_Skill(caster, skill, targetPosition, caster.Direction, true);
					Send.ZC_NORMAL_Unknown_06(caster, targetPosition);
					Send.ZC_SYNC_START(caster, 1234, 1);
					Send.ZC_SYNC_END(caster, 1234, 0);
					Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, 1234, skill.Data.HitDelay);
					Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, null, 0);
					Send.ZC_SYNC_EXEC(caster, 1234);

					for (var i = 0; i < 10; i++)
					{
						Task.Delay(skill.Data.HitDelay).ContinueWith(_ =>
						{
							Send.ZC_NORMAL_Unknown_06(caster, targetPosition);
							Send.ZC_SYNC_START(caster, 1234, 1);
							Send.ZC_SYNC_END(caster, 1234, 0);
							Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, 1234, skill.Data.HitDelay);
							Send.ZC_SYNC_EXEC(caster, 1234);

							foreach (var target in targets)
							{
								if (target.TakeDamage(damage, caster, DamageVisibilityModifier.Hit, i + 1))
									Send.ZC_SKILL_CAST_CANCEL(caster, target);
							}
						});
					}

					Send.ZC_SKILL_DISABLE(caster);
					break;
				}

				default:
				{
					var targets = caster.Map.GetAttackableEntitiesInRange(caster, targetPosition, (int)skill.Data.SplashRange);
					var damage = caster.GetRandomPAtk() + 100;

					Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, targets, damage);

					foreach (var target in targets)
					{
						if (target.TakeDamage(damage, caster, 0))
							Send.ZC_SKILL_CAST_CANCEL(caster, target);
					}
					break;
				}
			}
		}
	}
}
