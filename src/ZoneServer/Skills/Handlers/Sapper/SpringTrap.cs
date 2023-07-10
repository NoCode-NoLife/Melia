using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Melia.Shared.Data.Database;
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

			var character = caster as Character;

			this.PlaceTrap(character, caster, skill, farPos);
		}

		/// <summary>
		/// Places the trap object on the floor
		/// </summary>
		/// <param name="character"></param>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="farPos"></param>
		private async void PlaceTrap(Character character, ICombatEntity caster, Skill skill, Position farPos)
		{
			await Task.Delay(100);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, caster.Position);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, ForceId.GetNew(), null);

			await Task.Delay(600);

			farPos = caster.Position.GetRelative(caster.Direction, 12);
			var effectid = ForceId.GetNew();

			Send.ZC_NORMAL.GroundEffect_59(character, "Sapper_SpringTrap", skill.Id, farPos, effectid, true);

			var trapObject = new Mob(300009, MonsterType.NPC);

			trapObject.Position = farPos;
			trapObject.Direction = caster.Direction;

			trapObject.Components.Add(new BuffComponent(trapObject));

			caster.Map.AddMonster(trapObject);
			Send.ZC_ENTER_MONSTER(trapObject);
			Send.ZC_OWNER(character, trapObject);
			Send.ZC_FACTION(character.Connection, trapObject, FactionType.Trap);
			Send.ZC_NORMAL.Skill_5C(character, trapObject, skill.Id, effectid);
			trapObject.StartBuff(BuffId.Cover_Buff, TimeSpan.FromMinutes(60));

			this.AlertRange(caster, skill, trapObject, effectid);
		}

		/// <summary>
		/// Routine that scans for targets that may trigger the trap explosion
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="trap"></param>
		/// <param name="effectId"></param>
		private async void AlertRange(ICombatEntity caster, Skill skill, Mob trap, int effectId)
		{
			var splashParam = skill.GetSplashParameters(trap, trap.Position, trap.Position, length: 35, width: 35, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);

			Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

			var triggerCount = 0;

			while (true)
			{
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
				if (targets.Count > 0)
				{
					var splashTriggerParam = skill.GetSplashParameters(trap, trap.Position, trap.Position, length: 40, width: 40, angle: 0);
					var splashTriggerArea = skill.GetSplashArea(SplashType.Circle, splashParam);

					Debug.ShowShape(caster.Map, splashTriggerArea, edgePoints: false);

					var targetsInTrigerArea = caster.Map.GetAttackableEntitiesIn(caster, splashTriggerArea);

					foreach (var target in targetsInTrigerArea.LimitBySDR(caster, skill))
					{
						if (target.Components.Get<BuffComponent>().Has(BuffId.SpringTrap_Debuff))
						{
							continue;
						}

						if (triggerCount >= 5)
						{
							Send.ZC_DEAD(trap, trap.Position);
							break;
						}

						this.TriggerTrap(caster, skill, target, effectId, trap);
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
		private void TriggerTrap(ICombatEntity caster, Skill skill, ICombatEntity target, int effectId, Mob trap)
		{
			var character = caster as Character;

			Send.ZC_NORMAL.Skill_6D(character, effectId);
			Send.ZC_NORMAL.Skill_E3(character, target, "SHOW_SKILL_ATTRIBUTE");

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult);

			var knockBackDistance = 35;
			var knockBackPos = target.Position.GetRelative(trap.Direction.Backwards, knockBackDistance);
			var angle = target.GetDirection(knockBackPos).DegreeAngle;

			Send.ZC_KNOCKDOWN_INFO(character, target, target.Position, knockBackPos, angle);

			target.Position = knockBackPos;

			Send.ZC_HIT_INFO(caster, target, skill, hit);
			target.StartBuff(BuffId.SpringTrap_Debuff, TimeSpan.FromSeconds(25));
		}
	}
}
