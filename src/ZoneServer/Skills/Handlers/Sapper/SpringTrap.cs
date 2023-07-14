using System;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.Skills.SplashAreas;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Sapper
{
	/// <summary>
	/// Handler for the Sapper skill Spring Trap.
	/// </summary>
	[SkillHandler(SkillId.Sapper_SpringTrap)]
	public class SpringTrap : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, creates an trap on the floor that
		/// continue scan for targets and once triggered moves the
		/// them away by certain distance
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

			this.PlaceTrap(caster, skill, farPos);
		}

		/// <summary>
		/// Places the trap object on the floor
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="farPos"></param>
		private async void PlaceTrap(ICombatEntity caster, Skill skill, Position farPos)
		{
			await Task.Delay(100);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, caster.Position);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, ForceId.GetNew(), null);

			await Task.Delay(600);

			farPos = caster.Position.GetRelative(caster.Direction, 25);
			var effectid = ForceId.GetNew();

			Send.ZC_NORMAL.GroundEffect_59(caster, caster.Direction, "Sapper_SpringTrap", skill.Id, farPos, effectid, true);

			var trapObject = new Mob(300009, MonsterType.Friendly);

			trapObject.Position = farPos;
			trapObject.Direction = caster.Direction;
			trapObject.FromGround = true;
			trapObject.Properties.SetFloat(PropertyName.FIXMSPD_BM, 0);
			trapObject.Owner = caster;

			trapObject.Components.Add(new BuffComponent(trapObject));

			caster.Map.AddMonster(trapObject);

			Send.ZC_OWNER(caster, trapObject);
			Send.ZC_FACTION(caster, trapObject, FactionType.Trap);
			Send.ZC_NORMAL.Skill_5C(caster, trapObject, skill.Id, effectid);

			trapObject.StartBuff(BuffId.Cover_Buff, TimeSpan.Zero);

			await Task.Delay(1000);

			var cancellationTokenSource = new CancellationTokenSource();

			this.AlertRange(caster, skill, trapObject, effectid, cancellationTokenSource);

			if (caster.PlacedTraps != null)
				caster.PlacedTraps.Add(trapObject);

			// The trap auto-disables after 25 seconds
			await Task.Delay(TimeSpan.FromSeconds(25));

			if (trapObject != null && !trapObject.IsDead)
			{
				cancellationTokenSource.Cancel();
				caster.Map.RemoveMonster(trapObject);
				if (caster.PlacedTraps.Contains(trapObject))
					caster.PlacedTraps.Remove(trapObject);
			}
		}

		/// <summary>
		/// Routine that scans for targets that may trigger the trap explosion
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="trap"></param>
		/// <param name="effectId"></param>
		private async void AlertRange(ICombatEntity caster, Skill skill, Mob trap, int effectId, CancellationTokenSource cancellationTokenSource)
		{
			var splashArea = new Circle(trap.Position, 30);

			Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

			var triggerCount = 0;

			var splashTriggerArea = new Circle(trap.Position, 35);

			Debug.ShowShape(caster.Map, splashTriggerArea, edgePoints: false);

			while (!cancellationTokenSource.IsCancellationRequested)
			{
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
				if (targets.Count > 0)
				{
					var targetsInTrigerArea = caster.Map.GetAttackableEntitiesIn(caster, splashTriggerArea);

					foreach (var target in targetsInTrigerArea.LimitBySDR(caster, skill))
					{
						if (target.Components.Get<BuffComponent>().Has(BuffId.SpringTrap_Debuff))
						{
							continue;
						}

						if (triggerCount >= 5)
						{
							caster.Map.RemoveMonster(trap);
							break;
						}

						this.TriggerTrap(caster, skill, target, effectId, trap, cancellationTokenSource);
						triggerCount++;
					}
				}
				await Task.Delay(200);
			}
		}

		/// <summary>
		/// Trigger the trap effect once a target step on it
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="target"></param>
		/// <param name="effectId"></param>
		/// <param name="trap"></param>
		private void TriggerTrap(ICombatEntity caster, Skill skill, ICombatEntity target, int effectId, Mob trap, CancellationTokenSource cancellationTokenSource)
		{
			var buffComponent = target.Components.Get<BuffComponent>();
			buffComponent?.Remove(BuffId.Cover_Buff);

			cancellationTokenSource.Cancel();

			Send.ZC_NORMAL.PlayAnimationOnEffect_6D(caster, effectId);
			Send.ZC_NORMAL.Skill_E3(caster, target, "SHOW_SKILL_ATTRIBUTE");

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult);

			var knockBackDistance = 35;
			var knockBackPos = target.Position.GetRelative(trap.Direction.Backwards, knockBackDistance);
			var angle = target.GetDirection(knockBackPos).DegreeAngle;
			var kb = new KnockBackInfo(trap.Position, knockBackPos, skill);

			Send.ZC_KNOCKDOWN_INFO(caster, target, kb);

			target.Position = kb.ToPosition;

			Send.ZC_HIT_INFO(caster, target, skill, hit);
			target.StartBuff(BuffId.SpringTrap_Debuff, TimeSpan.FromSeconds(25));

			if (caster.PlacedTraps.Contains(trap))
				caster.PlacedTraps.Remove(trap);
		}
	}
}
