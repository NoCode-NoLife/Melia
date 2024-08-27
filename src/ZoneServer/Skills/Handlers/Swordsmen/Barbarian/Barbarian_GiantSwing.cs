using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using static Melia.Zone.Skills.SkillUseFunctions;
using static Melia.Shared.Util.TaskHelper;

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
			var hits = new List<SkillHitInfo>();

			if (!targets.Any())
			{
				Send.ZC_PLAY_ANI(caster, "idle1");
				Send.ZC_NORMAL.ClearEffects(caster);
				Send.ZC_SKILL_CAST_CANCEL(caster);
				Send.ZC_NORMAL.SkillCancelCancel(caster, skill.Id);
				return;
			}

			// the chain can only hit one target, which is chosen randomly
			var target = targets.LimitRandom(1).First();

			Send.ZC_NORMAL.SpinObject(caster, 0, 9, 0.2f, 1);

			var cancelToken = new CancellationTokenSource();
			CallSafe(SpinTarget(caster, target, cancelToken.Token));

			// This is an optional custom effect that causes the spin to also
			// deal damage in the chain's radius
			// CallSafe(SpinAttack(skill, caster, target, new Circle(caster.Position, ChainLength)));

			var modifier = SkillModifier.Default;

			// Wild Nature effects - 12% damage per stack
			if (caster.TryGetBuff(BuffId.ScudInstinct_Buff, out var wildNature))
			{
				modifier.DamageMultiplier += 0.12f * wildNature.OverbuffCounter;
			}

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

			// this skill's animation doesn't end unless you cancel it
			Send.ZC_NORMAL.SpinObject(caster, 0, 0, 0, 0);
			Send.ZC_PLAY_ANI(caster, "idle1");
			caster.TurnTowards(chainDirection);
			Send.ZC_NORMAL.SkillCancelCancel(caster, skill.Id);


			target.StartBuff(BuffId.giantswing_Debuff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);

			var targetPos = chainPos.GetRelative(chainDirection, TossDistance);
			targetPos = caster.Map.Ground.GetLastValidPosition(target.Position, targetPos);

			// have to stop the target before the leapjump or their position can get messed up
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
		/// <param name="duration"></param>
		private async Task SpinTarget(ICombatEntity caster, ICombatEntity target, CancellationToken cancelToken)
		{
			var tickTime = TimeSpan.FromMilliseconds(70);

			while (!cancelToken.IsCancellationRequested)
			{
				target.Position = new Position(caster.Position.GetRelative(caster.Direction, ChainLength));
				Send.ZC_SET_POS(target);
				Send.ZC_NORMAL.PlayEffect(target, "F_burstup022_smoke", 0.7f);

				await Task.Delay(tickTime);
			}
		}


		/// <summary>
		/// Deals damage to other targets in the range of the spin
		/// </summary>
		/// <remarks>
		/// This is custom functionality, the original skill did not
		/// hit additional targets, but it definitely feels like it
		/// should have done something like this
		/// </remarks>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task SpinAttack(Skill skill, ICombatEntity caster, ICombatEntity spinTarget, ISplashArea splashArea)
		{
			var hits = new List<SkillHitInfo>();
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			var totalHits = 9;
			var delayBetweenRepeats = TimeSpan.FromMilliseconds(300);

			var damageMultiplier = 0f;

			// Wild Nature effects - 12% damage per stack
			// Need to check this here because this could expire
			// during the attack
			if (caster.TryGetBuff(BuffId.ScudInstinct_Buff, out var wildNature))
			{
				damageMultiplier += 0.12f * wildNature.OverbuffCounter;
			}

			var divisor = 3f;

			// deals more damage if the thrown target is larger
			switch (spinTarget.EffectiveSize)
			{
				case SizeType.XXL:
				case SizeType.XL:
					divisor = 1.5f;
					break;
				case SizeType.L:
					divisor = 2f;
					break;
				case SizeType.S:
					divisor = 4f;
					break;
			}

			for (var i = 0; i < totalHits; ++i)
			{
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					if (target == spinTarget)
						continue;

					var modifier = SkillModifier.Default;
					modifier.DamageMultiplier += damageMultiplier;

					var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
					skillHitResult.Damage /= divisor;
					target.TakeDamage(skillHitResult.Damage, caster);

					var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
					skillHit.HitEffect = HitEffect.Impact;

					hits.Add(skillHit);

					// this actually gets applied every time, but the animation
					// is so long it's useful to apply it on every hit
					target.StartBuff(BuffId.giantswing_Debuff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);
				}

				Send.ZC_SKILL_HIT_INFO(caster, hits);

				if (i < totalHits - 1)
					await Task.Delay(delayBetweenRepeats);

				hits.Clear();
			}
		}
	}
}
