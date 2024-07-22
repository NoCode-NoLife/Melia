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
using static Melia.Zone.Skills.SkillUseFunctions;

// TODO: Implement Ability "Granata: Aim" (AbilityId.Arditi20). A new handler probably will be necessary
namespace Melia.Zone.Skills.Handlers.Scout.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Granata.
	/// </summary>
	[SkillHandler(SkillId.Arditi_Granata)]
	public class Granata : IGroundSkillHandler
	{
		const int castLength = 70;

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

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Direction direction = Direction.Zero;

			if (originPos == farPos)
				direction = caster.Direction;
			else
				direction = originPos.GetDirection(farPos);

			var castPosition = caster.Position.GetRelative(direction, castLength);

			Send.ZC_SKILL_READY(caster, skill, originPos, originPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, originPos, caster.Position.GetDirection(castPosition), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, originPos, ForceId.GetNew(), null);

			this.Attack(skill, caster, originPos, farPos, castPosition);
		}

		/// <summary>
		/// Execute the attack of the skill, throw a bomb
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		private async void Attack(Skill skill, ICombatEntity caster, Position originPos, Position farPos, Position castPosition)
		{
			await Task.Delay(TimeSpan.FromMilliseconds(200));

			Send.ZC_NORMAL.SkillProjectile(caster, "I_archer_Lachrymator_force_mash_short#Dummy_R_HAND", TimeSpan.FromMilliseconds(600), "F_scout_Granata_explosion", TimeSpan.FromSeconds(3), castPosition);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: castLength, width: 45, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			await Task.Delay(TimeSpan.FromMilliseconds(300));

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.Default;
				modifier.HitCount = 6;
				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

				target.TakeDamage(skillHitResult.Damage, caster);

				var hit = new HitInfo(caster, target, skill, skillHitResult, TimeSpan.FromMilliseconds(100));
				Send.ZC_HIT_INFO(caster, target, hit);

				var knockBackDistance = 1;
				var knockBackPos = target.Position.GetRelative(caster.Direction, knockBackDistance);
				var angle = target.GetDirection(knockBackPos).DegreeAngle;
				var kb = new KnockBackInfo(caster.Position, knockBackPos, skill);

				Send.ZC_KNOCKDOWN_INFO(caster, target, kb);
			}
		}
	}
}
