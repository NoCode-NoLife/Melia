using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Sapper
{
	/// <summary>
	/// Handler for the Sapper skill Punji Stake.
	/// </summary>
	[SkillHandler(SkillId.Sapper_PunjiStake)]
	public class PunjiStake : IDynamicCasted
	{
		private float maxCastingTime = 0;
		private Stopwatch stopwatch;

		/// <summary>
		/// Handles the skill, places a trap on the floor that continues scan for targets
		/// once triggered it deals damage to the them
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="maxCastingTime"></param>
		public void StartDynamicCast(Skill skill, ICombatEntity caster, float maxCastingTime)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			// Why are we trusting the client?
			// TODO: Find a way to get the Cast Time of a skill
			this.maxCastingTime = maxCastingTime;

			// Taglio: Tenacity
			// Duration changed to 5 seconds{ nl}
			// *Movement speed increase effect removed{ nl}
			// *Cooldown increased by 10 seconds
			if (!caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Arditi19))
			{
				caster.Properties.Modify(PropertyName.MSPD_BM, 10);
				Send.ZC_MSPD(caster);
			}

			stopwatch = Stopwatch.StartNew();
			stopwatch.Start();
		}

		/// <summary>
		/// Handles the skill stop casting dynamicly.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			var character = caster as Character;

			// Ability - Poonji Stake: Instance
			// Poonji Steak is immediately installed and damage is reduced by 50%{nl}*
			// When attacked by Punji Steak, the movement speed is fixed at 10 for 5 seconds,
			// and the damage received from the caster is increased by 30%
			if (character != null && character.Abilities.IsActive(AbilityId.Sapper42))
			{
				this.PlaceTrap(skill, caster);
				return;
			}

			if (stopwatch != null)
			{
				stopwatch.Stop();
				var elapsed = stopwatch.Elapsed;

				if (elapsed.TotalMilliseconds >= ((this.maxCastingTime * 1000) - 200))
				{
					this.PlaceTrap(skill, caster);
				}
			}
		}

		/// <summary>
		/// Places the trap object on the floor
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		private async void PlaceTrap(Skill skill, ICombatEntity caster)
		{
			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			await Task.Delay(TimeSpan.FromMilliseconds(150));

			var effectId = ForceId.GetNew();
			var farPos = caster.Position.GetRelative(caster.Direction, 25);

			Send.ZC_NORMAL.GroundEffect_59(caster, caster.Direction, "punji_stake", skill.Id, farPos, effectId, true);

			await Task.Delay(TimeSpan.FromMilliseconds(150));

			var trapObject = new Mob(57194, MonsterType.Friendly);

			trapObject.Position = farPos;
			trapObject.Direction = caster.Direction;
			trapObject.FromGround = true;
			trapObject.Properties.SetFloat(PropertyName.FIXMSPD_BM, 0);
			trapObject.Owner = caster;

			trapObject.Components.Add(new BuffComponent(trapObject));

			caster.Map.AddMonster(trapObject);

			Send.ZC_OWNER(caster, trapObject);
			Send.ZC_FACTION(caster, trapObject, FactionType.Trap);

			caster.SetAttackState(true);

			Send.ZC_NORMAL.Skill_50(caster, skill.Id, 1.5f);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Position.GetDirection(trapObject.Position), trapObject.Position);
			Send.ZC_NORMAL.Skill_5C(caster, trapObject, skill.Id, effectId);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, trapObject.Position, ForceId.GetNew(), null);

			trapObject.StartBuff(BuffId.Cover_Buff, TimeSpan.FromMinutes(60));

			var cancellationTokenSource = new CancellationTokenSource();

			this.AlertRange(skill, caster, trapObject, effectId, cancellationTokenSource);

			await Task.Delay(TimeSpan.FromSeconds(30));

			// The trap auto-triggers after 30 seconds
			if (trapObject != null && !trapObject.IsDead && !cancellationTokenSource.Token.IsCancellationRequested)
			{
				this.ExplodeTrap(skill, caster, trapObject, effectId, cancellationTokenSource);
				caster.Map.RemoveMonster(trapObject);
				cancellationTokenSource.Cancel();
			}
		}

		/// <summary>
		/// Routine that scans for targets that may trigger the trap explosion
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="trap"></param>
		/// <param name="effectId"></param>
		private async void AlertRange(Skill skill, ICombatEntity caster, Mob trap, int effectId, CancellationTokenSource cancellationTokenSource)
		{
			var splashArea = new Circle(trap.Position, 45);

			Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

			while (!cancellationTokenSource.Token.IsCancellationRequested)
			{
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
				if (targets.Count > 0)
				{
					this.ExplodeTrap(skill, caster, trap, effectId, cancellationTokenSource);
					break;
				}
				await Task.Delay(TimeSpan.FromMilliseconds(200));
			}
		}

		/// <summary>
		/// Explodes the trap object and does its following effects
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="trap"></param>
		/// <param name="effectId"></param>
		private async void ExplodeTrap(Skill skill, ICombatEntity caster, Mob trap, int effectId, CancellationTokenSource cancellationTokenSource)
		{
			cancellationTokenSource.Cancel();

			Send.ZC_NORMAL.Skill_50(caster, skill.Id, 1.5f);

			await Task.Delay(TimeSpan.FromMilliseconds(150));

			Send.ZC_NORMAL.PlayAnimationOnEffect_6D(caster, effectId);

			var splashArea = new Square(trap.Position.GetRelative(trap.Direction, -50), trap.Direction, 90, 40);

			Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				this.ExecuteAttack(caster, target, skill, trap);
			}

			await Task.Delay(TimeSpan.FromMilliseconds(800));

			Send.ZC_NORMAL.PlayAnimationOnEffect_7D(caster, skill.Id);

			await Task.Delay(TimeSpan.FromSeconds(2));

			caster.Map.RemoveMonster(trap);
			Send.ZC_NORMAL.GroundEffect_59(caster, caster.Direction, "punji_stake", skill.Id, trap.Position, effectId, false);
		}

		/// <summary>
		/// Execute the trap attack after the explosion
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="trap"></param>
		private async void ExecuteAttack(ICombatEntity caster, ICombatEntity target, Skill skill, Mob trap)
		{
			var character = caster as Character;
			var skillHitResult = SCR_SkillHit(caster, target, skill);

			// Ability - Poonji Stake: Instance
			// Poonji Steak is immediately installed and damage is reduced by 50%{nl}*
			// When attacked by Punji Steak, the movement speed is fixed at 10 for 5 seconds,
			// and the damage received from the caster is increased by 30%
			if (character != null && character.Abilities.IsActive(AbilityId.Sapper42))
			{
				skillHitResult.Damage *= 0.5f;
				this.ApplySlow(target);
				return;
			}

			var knockBackDistance = 110;
			var knockBackPos = target.Position.GetRelative(trap.Direction, knockBackDistance);
			var angle = target.GetDirection(knockBackPos).DegreeAngle;
			var kb = new KnockBackInfo(trap.Position, knockBackPos, skill);

			Send.ZC_KNOCKDOWN_INFO(caster, target, kb);

			target.Position = kb.ToPosition;

			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult);

			for (int i = 0; i < 4; i++)
			{
				Send.ZC_HIT_INFO(caster, target, skill, hit);
				await Task.Delay(TimeSpan.FromMilliseconds(100));
			}
		}

		/// <summary>
		/// Apply Slow to the targets settings its move speed to 30%
		/// </summary>
		/// <param name="target"></param>
		private async void ApplySlow(ICombatEntity target)
		{
			var mspd = target.Properties.GetFloat(PropertyName.MSPD);
			target.Properties.SetFloat(PropertyName.MSPD_BM, -(mspd * 0.7f));
			await Task.Delay(5000);
			target.Properties.SetFloat(PropertyName.MSPD_BM, (mspd * 0.7f));
		}
	}
}
