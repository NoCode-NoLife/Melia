using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Matador
{
	/// <summary>
	/// Handler for the Matador skill Faena
	/// </summary>
	[SkillHandler(SkillId.Matador_Faena)]
	public class Matador_Faena : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, hit enemies in front
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			caster.StartBuff(BuffId.Faena_Buff);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			var splashArea = new Square(caster.Position, caster.Direction, 55, 20);

			CallSafe(this.Attack(skill, caster, splashArea));
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var removeBuffDelay = TimeSpan.FromMilliseconds(600);
			var damageDelay = TimeSpan.Zero;

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(4);

				var targetSize = SizeType.M;

				if (target is Mob mob)
					targetSize = mob.Data.Size;

				// Increase Final Damage by 20% against Large and Boss monsters
				if (targetSize == SizeType.L || target.Rank == MonsterRank.Boss)
					modifier.FinalDamageMultiplier += 0.2f;

				// Increase Critical Chance by 50%
				modifier.MinCritChance *= 1.5f;

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

				target.TakeDamage(skillHitResult.Damage, caster);

				var hit = new HitInfo(caster, target, skill, skillHitResult.Damage, skillHitResult.Result, modifier.HitCount, TimeSpan.FromMilliseconds(150));

				Send.ZC_HIT_INFO(caster, target, hit);
			}

			await Task.Delay(removeBuffDelay);

			caster.StopBuff(BuffId.Faena_Buff);
		}
	}
}
