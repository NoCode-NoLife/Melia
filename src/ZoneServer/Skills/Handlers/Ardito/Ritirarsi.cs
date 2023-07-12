using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Ritirarsi.
	/// </summary>
	[SkillHandler(SkillId.Arditi_Ritirarsi)]
	public class Ritirarsi : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="designatedTarget"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			if (!caster.Position.InRange2D(farPos, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			// Ability "Ritirarsi: Attach"
			// Doesn't jump backwards{nl}* Applies [Ritirarsi: Attach] debuff to enemies{nl}*
			// Debuffed enemies explode after 3 seconds to attack up to 7 enemies{nl}*
			// Can be attached to enemies from a certain distance away {nl}* Delays respawn by 10 seconds{nl}*
			// Ignores respawn buffs
			if (caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi18))
			{
				// TODO: Implement this
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			farPos = caster.Position.GetRelative(caster.Direction, 25);

			caster.TurnTowards(farPos);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, originPos, caster.Position.GetDirection(farPos), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);

			this.Attack(skill, caster, originPos, farPos);
		}

		/// <summary>
		/// Execute the attack, does a jump back and throws a bomb
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		private async void Attack(Skill skill, ICombatEntity caster, Position originPos, Position farPos)
		{
			Send.ZC_NORMAL.ExecuteAnimation(caster, "I_archer_Lachrymator_force_mash002#Dummy_R_HAND", 0.75f, "F_scout_Ritirarsi", 4f, farPos);

			await Task.Delay(600);

			var distance = this.GetJumpDistance();
			var targetPos = caster.Position.GetRelative(caster.Direction.Backwards, distance);
			targetPos = caster.Map.Ground.GetLastValidPosition(caster.Position, targetPos);

			caster.Position = targetPos;

			Send.ZC_NORMAL.LeapJump(caster, targetPos, 0, 0, 0.5f, 0.35f, 0.7f);
			
			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 50, width: 50, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var hit = new HitInfo(caster, target, skill, skillHitResult);

				Send.ZC_HIT_INFO(caster, target, skill, hit);

				var skillHitResult2 = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult2.Damage, caster);

				var hit2 = new HitInfo(caster, target, skill, skillHitResult2);

				Send.ZC_HIT_INFO(caster, target, skill, hit2);
			}
		}

		/// <summary>
		/// Returns the distance to jump back. Obtained by analyzing the packets
		/// </summary>
		/// <returns></returns>
		private float GetJumpDistance()
		{
			return 64.8254f;
		}
	}
}
