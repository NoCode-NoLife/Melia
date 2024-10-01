using System;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Components;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.Ranger
{
	/// <summary>
	/// Handles the Ranger skill Strafe
	/// </summary>
	[SkillHandler(SkillId.Ranger_Strafe)]
	public class Ranger_Strafe : IGroundSkillHandler
	{
		public const float JumpDistance = 40f;

		/// <summary>
		/// Handles the skill
		/// </summary>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position targetPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			if (target == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			if (!caster.InSkillUseRange(skill, target))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			CallSafe(this.Attack(skill, caster, target));
		}

		/// <summary>
		/// Performs the actual attack
		/// </summary>
		public async Task Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var jumpDelay = TimeSpan.FromMilliseconds(300);
			var animationDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			var previousStrafes = 0f;

			// first grab and remove the strafe enable buff.
			if (caster.TryGetBuff(BuffId.Ranger_StrapingShot, out var enableBuff))
			{
				previousStrafes = enableBuff.NumArg1;
				caster.StopBuff(BuffId.Ranger_StrapingShot);
			} else
			{
				// can't use skill without the buff
				return;
			}
			
			// First perform the jump
			var targetPos = caster.Position.GetRelative(caster.Direction, JumpDistance);
			targetPos = caster.Map.Ground.GetLastValidPosition(caster.Position, targetPos);									
			
			caster.Position = targetPos;
			Send.ZC_NORMAL.LeapJump(caster, targetPos, 1.5f, 0.1f, 1f, 0.2f, 1f, 3);

			await Task.Delay(jumpDelay);


			// Now fire the arrow
			var modifier = SkillModifier.Default;

			if (caster.IsAbilityActive(AbilityId.Ranger54))
			{
				modifier.DamageMultiplier += 1f;
			}

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
			target.TakeDamage(skillHitResult.Damage, caster);
			var hit = new HitInfo(caster, target, skill, skillHitResult);
			hit.ForceId = ForceId.GetNew();
			hit.ResultType = HitResultType.Unk8;

			Send.ZC_NORMAL.PlayForceEffect(hit.ForceId, caster, caster, target, "I_arrow009_red", 0.2f, "arrow_cast", "F_hit_good", 1, "arrow_blow", "SLOW", 800);
			Send.ZC_HIT_INFO(caster, target, hit);

			await Task.Delay(animationDelay);

			caster.TurnTowards(target);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, target.Position, null);			

			Ranger_CriticalShot.TryActivateDoubleTake(skill, caster, target);
			Ranger_CriticalShot.TryReduceCooldown(skill, caster, skillHitResult);

			// Ranger54 lets you chain strafe up to 3 times,
			// but you don't get the evasion buff
			if (caster.IsAbilityActive(AbilityId.Ranger54))
			{
				if (previousStrafes < 2)
				{
					previousStrafes++;
					caster.StartBuff(BuffId.Ranger_StrapingShot, previousStrafes, 0, TimeSpan.FromSeconds(3), caster);
				}
			}
			else
			{
				if (skillHitResult.Result != HitResultType.Dodge)
					caster.StartBuff(BuffId.Ranger_StrapingShot_Dodge_Buff, skill.Level, 0, TimeSpan.FromSeconds(2), caster);
			}
		}


		/// <summary>
		/// Attempts to give the buff that allows the use of Strafe
		/// </summary>
		public static void TryApplyStrafeBuff(ICombatEntity caster)
		{
			var buffDuration = TimeSpan.FromSeconds(3);

			if (caster.TryGetSkill(SkillId.Ranger_Strafe, out var strafe))
			{
				if (!strafe.IsOnCooldown)
				{
					caster.StartBuff(BuffId.Ranger_StrapingShot, 0, 0, TimeSpan.FromSeconds(3), caster);
				}
			}
		}
	}
}
