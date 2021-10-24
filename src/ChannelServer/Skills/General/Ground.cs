using System.Threading.Tasks;
using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World.Entities;
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

			if (skill.SpendSp > 0)
				caster.ModifySp(-skill.SpendSp);

			skill.IncreaseOverheat();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, targetPosition);

			switch (skill.Id)
			{
				case SkillId.Wizard_MagicMissile:
				{
					var targets = caster.Map.GetAttackableEntitiesInRange(caster, targetPosition, (int)skill.Data.SplashRange);
					var damage = caster.GetRandomMAtk();

					Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, targets, damage);

					foreach (var target in targets)
					{
						Send.ZC_NORMAL_SkillParticleEffect(caster, 1234);
						Send.ZC_SYNC_START(caster, 1234, 1);
						Send.ZC_NORMAL_Skill_16(caster, target, targetPosition);
						Send.ZC_SYNC_END(caster, 1234, 0);

						if (target.TakeDamage(damage, caster))
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
								target.TakeDamage(damage, caster);
								Send.ZC_HIT_INFO(caster, target, damage, i + 1);

								if (target.IsDead)
									Send.ZC_SKILL_CAST_CANCEL(caster, target);
							}
						});
					}

					Send.ZC_SKILL_DISABLE(caster);
					break;
					
				}
				case SkillId.Archer_SwiftStep:
				{
					var handler = ChannelServer.Instance.SkillHandlers.GetSelf(skill.Id);
					handler.Handle(skill, caster, caster.Position);
					break;
				}
				case SkillId.Cleric_Fade:
				{
					var handler = ChannelServer.Instance.SkillHandlers.GetSelf(skill.Id);
					handler.Handle(skill, caster, caster.Position);
					break;
				}
				case SkillId.Cleric_PatronSaint:
				{
					var handler = ChannelServer.Instance.SkillHandlers.GetSelf(skill.Id);
					handler.Handle(skill, caster, caster.Position);
					break;
				}

				default:
				{
					var targets = caster.Map.GetAttackableEntitiesInRange(caster, targetPosition, (int)skill.Data.SplashRange);
					var damage = caster.GetRandomAtk(skill);

					Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, targets, damage);

					foreach (var target in targets)
					{
						if (target.TakeDamage(damage, caster))
							Send.ZC_SKILL_CAST_CANCEL(caster, target);
					}
					break;
				}
			}
		}
	}
}
