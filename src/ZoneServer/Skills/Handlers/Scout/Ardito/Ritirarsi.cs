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
using Yggdrasil.Util;
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

			// TODO: Ability "Ritirarsi: Attach"
			// Doesn't jump backwards{nl}* Applies [Ritirarsi: Attach] debuff to enemies{nl}*
			// Debuffed enemies explode after 3 seconds to attack up to 7 enemies{nl}*
			// Can be attached to enemies from a certain distance away {nl}* Delays respawn by 10 seconds{nl}*
			// Ignores respawn buffs
			if (caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi18)) {}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);			
			caster.StartBuff(BuffId.Skill_NoDamage_Buff, 0, 0, TimeSpan.FromMilliseconds(1300), caster);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, originPos, caster.Position.GetDirection(farPos), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);

			var removeDebuffRatio = Math.Clamp(this.GetRemoveDebuffRatio(skill), 0, 100);
			var rnd = RandomProvider.Get();

			if (removeDebuffRatio == 100 || rnd.Next(100) < removeDebuffRatio)
			{
				caster.RemoveRandomDebuff();
			}

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
			Direction direction = Direction.Zero;

			if (originPos == farPos)
				direction = caster.Direction;
			else
				direction = originPos.GetDirection(farPos);

			var effectPosition = caster.Position.GetRelative(direction, 40);

			await Task.Delay(TimeSpan.FromMilliseconds(150));

			Send.ZC_NORMAL.SkillProjectile(caster, "I_archer_Lachrymator_force_mash002#Dummy_R_HAND", TimeSpan.FromMilliseconds(750), "F_scout_Ritirarsi", TimeSpan.FromSeconds(4), effectPosition);

			await Task.Delay(TimeSpan.FromMilliseconds(600));

			var distance = this.GetJumpDistance();
			var targetPos = caster.Position.GetRelative(caster.Direction.Backwards, distance);

			targetPos = caster.Map.Ground.GetLastValidPosition(caster.Position, targetPos);
			caster.Position = targetPos;

			Send.ZC_NORMAL.LeapJump(caster, targetPos, 0, 0, 0.5f, 0.35f, 0.7f);

			var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 40, width: 75, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.Default;
				modifier.HitCount = 6;
				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

				target.TakeDamage(skillHitResult.Damage, caster);

				var hit = new HitInfo(caster, target, skill, skillHitResult, TimeSpan.FromMilliseconds(100));
				Send.ZC_HIT_INFO(caster, target, hit);
			}
		}

		/// <summary>
		/// Returns the distance to jump back.
		/// </summary>
		/// <returns></returns>
		private float GetJumpDistance()
		{
			return 64.8254f;
		}

		/// <summary>
		/// Returns the remove Debuff ratio
		/// </summary>
		/// <returns></returns>
		private int GetRemoveDebuffRatio(Skill skill)
		{
			return skill.Level * 2;
		}
	}
}
