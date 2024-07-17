using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Tre Granata.
	/// </summary>
	[SkillHandler(SkillId.Arditi_TreGranata)]
	public class TreGranate : IGroundSkillHandler
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

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, originPos, caster.Direction, Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);

			this.Attack(skill, caster, farPos, caster.Direction);
		}

		/// <summary>
		/// Execute the skill, throw bombs
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="farPos"></param>
		/// <param name="direction"></param>
		private async void Attack(Skill skill, ICombatEntity caster, Position farPos, Direction direction)
		{
			await Task.Delay(TimeSpan.FromMilliseconds(100));

			var pos2 = farPos.GetRelative(direction, 50);
			var pos3 = pos2.GetRelative(direction, 50);
			var pos4 = pos3.GetRelative(direction, 50);

			Send.ZC_NORMAL.SkillProjectile(caster, "E_scout_TreGranata#Dummy_R_HAND", TimeSpan.FromMilliseconds(750), "F_explosion125_explosion2", TimeSpan.FromMilliseconds(2500), pos2);
			Send.ZC_NORMAL.SkillProjectile(caster, "E_scout_TreGranata#Dummy_R_HAND", TimeSpan.FromMilliseconds(750), "F_explosion125_explosion2", TimeSpan.FromMilliseconds(2500), pos3);
			Send.ZC_NORMAL.SkillProjectile(caster, "E_scout_TreGranata#Dummy_R_HAND", TimeSpan.FromMilliseconds(750), "F_explosion125_explosion2", TimeSpan.FromMilliseconds(2500), pos4);

			Send.ZC_NORMAL.SkillProjectile(caster, "", TimeSpan.FromMilliseconds(750), "", TimeSpan.FromMilliseconds(2500), pos2);

			await Task.Delay(TimeSpan.FromMilliseconds(400));

			var effectId1 = ForceId.GetNew();
			var effectId2 = ForceId.GetNew();
			var effectId3 = ForceId.GetNew();
			var effectId4 = ForceId.GetNew();

			Send.ZC_NORMAL.GroundEffect(caster, caster.Direction, "Arditi_TreGranata", skill.Id, pos2, effectId1, true);
			Send.ZC_NORMAL.GroundEffect(caster, caster.Direction, "Arditi_TreGranata", skill.Id, pos3, effectId2, true);
			Send.ZC_NORMAL.GroundEffect(caster, caster.Direction, "Arditi_TreGranata", skill.Id, pos4, effectId3, true);
			Send.ZC_NORMAL.GroundEffect(caster, caster.Direction, "Arditi_TreGranata_DamagePad", skill.Id, pos2, effectId4, true);

			var cancelationTokenSource = new CancellationTokenSource();

			this.AreaOfEffect(skill, caster, pos2, pos3, pos4, cancelationTokenSource);

			await Task.Delay(TimeSpan.FromSeconds(10));

			cancelationTokenSource.Cancel();

			Send.ZC_NORMAL.GroundEffect(caster, caster.Direction, "Arditi_TreGranata", skill.Id, pos2, effectId1, false);
			Send.ZC_NORMAL.GroundEffect(caster, caster.Direction, "Arditi_TreGranata", skill.Id, pos3, effectId2, false);
			Send.ZC_NORMAL.GroundEffect(caster, caster.Direction, "Arditi_TreGranata", skill.Id, pos4, effectId3, false);

			Send.ZC_NORMAL.GroundEffect(caster, caster.Direction, "Arditi_TreGranata_DamagePad", skill.Id, pos2, effectId4, false);
		}

		/// <summary>
		/// Area of effect that ticks dealing damage on the enemies inside
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="pos2"></param>
		/// <param name="pos3"></param>
		/// <param name="pos4"></param>
		/// <param name="cancelationTokenSource"></param>
		private async void AreaOfEffect(Skill skill, ICombatEntity caster, Position pos2, Position pos3, Position pos4, CancellationTokenSource cancelationTokenSource)
		{
			var circle = new Circle(pos2, 50);
			var circle2 = new Circle(pos3, 50);
			var circle3 = new Circle(pos4, 50);

			while (!cancelationTokenSource.Token.IsCancellationRequested)
			{
				await Task.Delay(TimeSpan.FromSeconds(1));

				var targets1 = caster.Map.GetAttackableEntitiesIn(caster, circle);
				var targets2 = caster.Map.GetAttackableEntitiesIn(caster, circle2);
				var targets3 = caster.Map.GetAttackableEntitiesIn(caster, circle3);

				var targets = targets1.Concat(targets2).Concat(targets3).ToList();
				var damageDelay = TimeSpan.FromMilliseconds(45);
				var skillHitDelay = skill.Properties.HitDelay;

				foreach (var target in targets.Distinct().ToList().LimitRandom(10))
				{
					var skillHitResult = SCR_SkillHit(caster, target, skill);

					target.TakeDamage(skillHitResult.Damage, caster);

					var hit = new HitInfo(caster, target, skill, skillHitResult);
					Send.ZC_HIT_INFO(caster, target, hit);
				}
			}
		}
	}
}
