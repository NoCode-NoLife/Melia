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
using Melia.Zone.World.Actors.Characters.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Granata.
	/// </summary>
	[SkillHandler(SkillId.Arditi_Granata)]
	public class Granata : IGroundSkillHandler
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

			farPos = caster.Position.GetRelative(caster.Direction, 50);
			caster.TurnTowards(farPos);

			if (!caster.Position.InRange2D(farPos, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			// Ability "Granata: Aim"
			// [Granata] The skill is changed to a branch target skill and can be thrown a little farther.
			if (caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi20))
			{
				// TODO: Implement this
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);;

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, originPos, caster.Position.GetDirection(farPos), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);

			this.Attack(skill, caster, originPos, farPos);
		}

		/// <summary>
		/// Execute the attack of the skill, throw a bomb
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		private async void Attack(Skill skill, ICombatEntity caster, Position originPos, Position farPos)
		{
			Send.ZC_NORMAL.ExecuteAnimation(caster, "I_archer_Lachrymator_force_mash_short#Dummy_R_HAND", 0.6f, "F_scout_Granata_explosion", 3f, farPos);

			await Task.Delay(TimeSpan.FromMilliseconds(300));

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 50, width: 50, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var damageDelay = TimeSpan.FromMilliseconds(45);
			var skillHitDelay = TimeSpan.FromMilliseconds(100);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				skillHitResult.HitCount = 6;
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;
				skillHit.ForceId = ForceId.GetNew();

				Send.ZC_SKILL_HIT_INFO(target, skillHit);
			}
		}
	}
}
