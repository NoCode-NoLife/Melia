using System;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Components;
using Yggdrasil.Extensions;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handler for the Barbarian skill Giant Swing.
	/// </summary>
	[SkillHandler(SkillId.Barbarian_GiantSwing)]
	public class Barbarian_GiantSwing : IGroundSkillHandler
	{
		public const float TossDistance = 150;
		public const float ChainLength = 80;

		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!skill.Vars.TryGet<Position>("Melia.ToolGroundPos", out var targetPos))
			{
				caster.ServerMessage(Localization.Get("No target location specified."));
				Send.ZC_SKILL_CAST_CANCEL(caster);
				return;
			}

			var chainPos = caster.Position.GetRelative2D(caster.Direction, ChainLength);
			if (!caster.Map.Ground.IsValidPosition(chainPos))
			{
				caster.ServerMessage(Localization.Get("Invalid Location."));
				Send.ZC_SKILL_CAST_CANCEL(caster);
				return;
			}

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			CallSafe(this.Attack(skill, caster, new Circle(targetPos, 15f), chainPos, caster.Direction));
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea, Position chainPos, Direction chainDirection)
		{
			var rotateDelay = TimeSpan.FromMilliseconds(370);
			var hitDelay = TimeSpan.FromMilliseconds(200);

			await Task.Delay(hitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			if (!targets.Any())
			{
				Send.ZC_PLAY_ANI(caster, "idle1");
				Send.ZC_NORMAL.ClearEffects(caster);
				Send.ZC_SKILL_CAST_CANCEL(caster);
				Send.ZC_NORMAL.SkillCancelCancel(caster, skill.Id);
				return;
			}

			var target = targets.Random();

			target.StopMove();
			target.AddState(StateType.Stunned);

			Send.ZC_NORMAL.PlayEffect(target, "F_hit_bad", 0.7f);
			Send.ZC_ATTACH_TO_OBJ(target, caster, "Bone_chain13", "ChainTest", TimeSpan.Zero, 100, null, 0, 0, 0);

			await Task.Delay(rotateDelay);

			var rotationCount = 9;
			var rotationDuration = 0.29f;
			var rotationTime = TimeSpan.FromSeconds(rotationCount * rotationDuration);

			Send.ZC_NORMAL.SpinObject(caster, 0, rotationCount, rotationDuration, 1);
			Send.ZC_NORMAL.AttachEffect(target, "I_smoke004", 1.5f);

			await Task.Delay(rotationTime + rotateDelay);

			Send.ZC_NORMAL.SpinObject(caster, 0, 0, 0, 0);
			Send.ZC_PLAY_ANI(caster, "idle1");
			caster.TurnTowards(chainDirection);
			Send.ZC_NORMAL.SkillCancelCancel(caster, skill.Id);

			Send.ZC_ATTACH_TO_OBJ(target, null, null, null, TimeSpan.Zero, 0, null, 0, 0, 0);
			Send.ZC_NORMAL.ClearEffects(target);

			target.RemoveState(StateType.Stunned);
			target.StartBuff(BuffId.giantswing_Debuff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);

			this.Hit(skill, caster, target);

			var targetPos = caster.Position.GetRelative2D(chainDirection, TossDistance);
			targetPos = caster.Map.Ground.GetLastValidPosition(caster.Position, targetPos);
			target.Position = targetPos;

			// This is almost certainly not the right packet for this, but it
			// will do for now, until we figure out the right one.
			Send.ZC_NORMAL.LeapJump(target, targetPos, 0.1f, 0.1f, 1f, 0.2f, 1f, 30);

			var flyTime = TimeSpan.FromMilliseconds(300);
			await Task.Delay(flyTime);

			Send.ZC_NORMAL.PlayEffect(target, "F_burstup022_smoke", 0.7f);
		}

		/// <summary>
		/// Hits target.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private void Hit(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var damageDelay = TimeSpan.FromMilliseconds(2950);
			var skillHitDelay = TimeSpan.Zero;

			var modifier = SkillModifier.Default;

			// Wild Nature effects - 12% damage per stack
			if (caster.TryGetBuff(BuffId.ScudInstinct_Buff, out var wildNature))
				modifier.DamageMultiplier += 0.12f * wildNature.OverbuffCounter;

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
			skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
			skillHit.ApplyKnockBack(target);

			Send.ZC_SKILL_HIT_INFO(caster, skillHit);
		}
	}
}
