using System;
using System.Collections.Generic;
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
using Melia.Zone.World.Actors.CombatEntities.Components;
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

			var chainPos = caster.Position.GetRelative(caster.Direction, ChainLength);
			var chainDirection = new Direction(caster.Direction);
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

			CallSafe(this.Attack(skill, caster, new Circle(targetPos, 15f), chainPos, chainDirection));
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea, Position chainPos, Direction chainDirection)
		{
			var hitDelay = TimeSpan.FromMilliseconds(200);
			var damageDelay = TimeSpan.FromMilliseconds(2950);
			var tossDelay = TimeSpan.FromMilliseconds(2700);
			var skillHitDelay = TimeSpan.Zero;

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
			var hits = new List<SkillHitInfo>();

			Send.ZC_NORMAL.SpinObject(caster, 0, 9, 0.2f, 1);

			var cancelToken = new CancellationTokenSource();
			CallSafe(this.SpinTarget(caster, target, cancelToken.Token));

			var modifier = SkillModifier.Default;

			// Wild Nature effects - 12% damage per stack
			if (caster.TryGetBuff(BuffId.ScudInstinct_Buff, out var wildNature))
				modifier.DamageMultiplier += 0.12f * wildNature.OverbuffCounter;

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
			skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
			skillHit.HitInfo.Type = skill.Data.KnockDownHitType;
			target.Position = skillHit.KnockBackInfo.ToPosition;
			hits.Add(skillHit);

			Send.ZC_SKILL_HIT_INFO(caster, hits);

			await Task.Delay(tossDelay);
			cancelToken.Cancel();

			Send.ZC_NORMAL.SpinObject(caster, 0, 0, 0, 0);
			Send.ZC_PLAY_ANI(caster, "idle1");
			caster.TurnTowards(chainDirection);
			Send.ZC_NORMAL.SkillCancelCancel(caster, skill.Id);

			target.StartBuff(BuffId.giantswing_Debuff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);

			var targetPos = chainPos.GetRelative(chainDirection, TossDistance);
			targetPos = caster.Map.Ground.GetLastValidPosition(target.Position, targetPos);

			if (target.Components.TryGet<MovementComponent>(out var movementComponent))
				movementComponent.Stop();

			target.Position = targetPos;
			Send.ZC_NORMAL.LeapJump(target, targetPos, 0.1f, 0.1f, 1f, 0.2f, 1f, 30);
		}

		/// <summary>
		/// Spins the target around.
		/// </summary>
		/// <remarks>
		/// This is not the correct implementation, it should call something like
		/// Send.ZC_ATTACH_TO_OBJ(target, null, "ChainTest", "Bone_chain13", 0.01f, 1, 1, "", 0, 0, 0);
		/// However the correct values to make this function have not been found
		/// </remarks>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="cancelToken"></param>
		private async Task SpinTarget(ICombatEntity caster, ICombatEntity target, CancellationToken cancelToken)
		{
			var tickTime = TimeSpan.FromMilliseconds(70);

			// You're totally incapacitated during the spin and can't be interacted with in any way
			target.Lock(LockType.Movement);
			target.Lock(LockType.GetHit);
			target.Lock(LockType.Attack);

			while (!cancelToken.IsCancellationRequested)
			{
				target.Position = new Position(caster.Position.GetRelative(caster.Direction, ChainLength));
				target.TurnTowards(caster);
				Send.ZC_SET_POS(target);
				Send.ZC_NORMAL.PlayEffect(target, "F_burstup022_smoke", 0.7f);

				await Task.Delay(tickTime, CancellationToken.None);
			}

			target.Unlock(LockType.Movement);
			target.Unlock(LockType.GetHit);
			target.Unlock(LockType.Attack);
		}
	}
}
