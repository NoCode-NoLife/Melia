using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Shared.Game.Const;
using Melia.Shared.Data.Database;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Monsters;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Sapper
{
	/// <summary>
	/// Handler for the Sapper skill Claymore.
	/// </summary>
	[SkillHandler(SkillId.Sapper_Claymore)]
	public class Claymore : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, creates an trap object on the floor on
		/// the first usage and explodes it on the second usage attempt
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

			if (caster.PlacedTraps.Exists(mob => mob.Id == 57197))
			{
				this.ExplodeTrap(skill, caster);
				return;
			}

			this.PlaceTrap(skill, caster, farPos);
		}

		/// <summary>
		/// Places the trap object (mob) on the floor
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="farPos"></param>
		private void PlaceTrap(Skill skill, ICombatEntity caster, Position farPos)
		{
			Send.ZC_NORMAL.Skill_88(caster, caster, skill);

			farPos = farPos.GetRelative(caster.Direction, 12);

			var trapObject = new Mob(57197, MonsterType.Friendly);

			trapObject.Position = farPos;
			trapObject.Direction = caster.Direction;
			trapObject.FromGround = true;
			trapObject.Properties.SetFloat(PropertyName.FIXMSPD_BM, 0);
			trapObject.Owner = caster;

			trapObject.Components.Add(new BuffComponent(trapObject));
			
			caster.Map.AddMonster(trapObject);

			Send.ZC_OWNER(caster, trapObject);
			Send.ZC_FACTION(caster, trapObject, FactionType.Trap);
			Send.ZC_NORMAL.Skill_122(caster, "SAPPER_TRAP_Sapper_Claymore");
			Send.ZC_NORMAL.Skill_99(caster, trapObject);
			Send.ZC_NORMAL.Skill_C8(caster, trapObject);
			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Position.GetDirection(trapObject.Position), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, trapObject.Position, ForceId.GetNew(), null);

			Send.ZC_NORMAL.Skill_40(caster, skill.Id, "SKL_CLAYMORE_SHOT");

			trapObject.StartBuff(BuffId.Cover_Buff, TimeSpan.Zero);

			caster.PlacedTraps.Add(trapObject);
		}

		/// <summary>
		/// Handles the trap triggering explosion effect
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		private async void ExplodeTrap(Skill skill, ICombatEntity caster)
		{
			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			await Task.Delay(TimeSpan.FromMilliseconds(200));

			Send.ZC_NORMAL.Skill_88(caster, caster, null);
			Send.ZC_NORMAL.Skill_88(caster, caster, null);

			var trap = caster.PlacedTraps.Find(x => x.Id == 57197);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, trap.Direction, Position.Zero, 1);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, ForceId.GetNew(), null);

			Send.ZC_DEAD(trap);
			Send.ZC_SKILL_CAST_CANCEL(trap);

			if (caster.PlacedTraps.Contains(trap))
				caster.PlacedTraps.Remove(trap);

			caster.Map.RemoveMonster(trap, false);

			var splashParam = skill.GetSplashParameters(trap, trap.Position, trap.Position, length: 200, width: 0, angle: 60);
			var splashArea = skill.GetSplashArea(SplashType.Fan, splashParam);

			this.Attack(skill, caster, splashArea);
			
			await Task.Delay(TimeSpan.FromMilliseconds(300));

			Send.ZC_NORMAL.Skill_122(caster, "SAPPER_TRAP_Sapper_Claymore");

			trap.Buffs.Remove(BuffId.Cover_Buff);
		}

		/// <summary>
		/// Executes the actual attack.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private void Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				this.ExecuteHitInfo(skill, caster, target);
			}
		}

		/// <summary>
		/// Sends the actual Hit Info Packets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private async void ExecuteHitInfo(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult);

			Send.ZC_HIT_INFO(caster, target, skill, hit);

			await Task.Delay(TimeSpan.FromMilliseconds(100));

			var skillHitResult2 = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult2.Damage, caster);

			var hit2 = new HitInfo(caster, target, skill, skillHitResult2);

			Send.ZC_HIT_INFO(caster, target, skill, hit2);
		}
	}
}
