using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Buffs.Handlers.Swordsman.Peltasta;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handler for the Peltasta skill Shield Lob.
	/// </summary>
	[SkillHandler(SkillId.Peltasta_ShieldLob)]
	public class Peltasta_ShieldLob : IGroundSkillHandler
	{
		private const float ShieldFlyDistance = 100f;
		private const float ShieldFlySpeedForward = 150f;
		private const float ShieldFlySpeedBack = 200f;

		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(farPos);
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			this.ThrowShield(skill, caster, farPos);
		}

		/// <summary>
		/// Handles the spawning and throwing of the shield
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void ThrowShield(Skill skill, ICombatEntity caster, Position originPos)
		{
			var cancelToken = new CancellationTokenSource();

			var padHandle = ZoneServer.Instance.World.CreatePadHandle();
			var shieldMonster = this.CreateShieldMonster(skill, caster, padHandle);

			// Throw shield, hitting targets while it's moving, with a slight
			// delay in between
			await this.MoveShieldForward(shieldMonster, caster, skill, padHandle, originPos);
			await Task.Delay(TimeSpan.FromMilliseconds(500));
			await this.MoveShieldBack(shieldMonster, caster, skill, padHandle, originPos);

			this.RemoveShieldMonster(shieldMonster, caster, skill, padHandle, originPos);
		}

		/// <summary>
		/// Makes shield fly forward in the direction the caster is facing.
		/// Method returns once it arrived.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="shieldMonster"></param>
		/// <param name="padHandle"></param>
		/// <param name="originPos"></param>
		/// <returns></returns>
		private async Task MoveShieldForward(Mob shieldMonster, ICombatEntity caster, Skill skill, int padHandle, Position originPos)
		{
			var movement = shieldMonster.Components.Get<MovementComponent>();
			movement.SetFixedMoveSpeed(ShieldFlySpeedForward);
			movement.SetMoveSpeedType(MoveSpeedType.Run);

			var dest = originPos.GetRelative(caster.Direction, ShieldFlyDistance);
			var moveTime = movement.MoveTo(dest);

			Send.ZC_NORMAL.SkillEffectMovement(caster, padHandle, dest, ShieldFlySpeedForward);

			var cancelToken = new CancellationTokenSource();
			this.CheckShieldCollision(skill, caster, shieldMonster, cancelToken);

			await Task.Delay(moveTime);
			cancelToken.Cancel();
		}

		/// <summary>
		/// Makes shield fly back to the caster. Method returns once it arrived.
		/// </summary>
		/// <param name="shieldMonster"></param>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="padHandle"></param>
		/// <param name="originPos"></param>
		/// <param name="distance"></param>
		/// <returns></returns>
		private async Task MoveShieldBack(Mob shieldMonster, ICombatEntity caster, Skill skill, int padHandle, Position originPos)
		{
			var movement = shieldMonster.Components.Get<MovementComponent>();
			movement.SetFixedMoveSpeed(ShieldFlySpeedBack);
			movement.SetMoveSpeedType(MoveSpeedType.Run);

			var cancelToken = new CancellationTokenSource();
			this.CheckShieldCollision(skill, caster, shieldMonster, cancelToken);

			// We loop over this a few times so the shield homes in on your location
			// even if you're moving
			for (var i = 0; i < 5; i++)
			{
				var moveTime = movement.MoveTo(caster.Position);
				Send.ZC_NORMAL.SkillEffectMovement(caster, padHandle, caster.Position, ShieldFlySpeedBack);

				await Task.Delay(250);
			}

			var endMoveTime = movement.MoveTo(caster.Position);
			Send.ZC_NORMAL.SkillEffectMovement(caster, padHandle, caster.Position, ShieldFlySpeedBack);

			await Task.Delay(endMoveTime);
			cancelToken.Cancel();
		}

		/// <summary>
		/// Creates a monster that represents the shield being thrown.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="padHandle"></param>
		/// <returns></returns>
		private Mob CreateShieldMonster(Skill skill, ICombatEntity caster, int padHandle)
		{
			var shieldMonster = new Mob(57001, MonsterType.Friendly);

			shieldMonster.Position = caster.Position.GetRelative(caster.Direction, 25f);
			shieldMonster.Direction = caster.Direction;
			shieldMonster.FromGround = false;
			shieldMonster.Components.Add(new MovementComponent(shieldMonster));

			Send.ZC_NORMAL.SkillPad(caster, skill, "Peltasta_ShieldLob2", shieldMonster.Position, shieldMonster.Direction, -0.7853982f, 0, padHandle, 30, true);
			caster.Map.AddMonster(shieldMonster);

			this.DressUpShield(caster, padHandle, shieldMonster);

			return shieldMonster;
		}

		/// <summary>
		/// Removes the shield monster from the map.
		/// </summary>
		/// <param name="shieldMonster"></param>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="padHandle"></param>
		/// <param name="originPos"></param>
		private void RemoveShieldMonster(Mob shieldMonster, ICombatEntity caster, Skill skill, int padHandle, Position originPos)
		{
			Send.ZC_NORMAL.SkillPad(caster, skill, "Peltasta_ShieldLob2", originPos, caster.Direction, 0, 145.8735f, padHandle, 30, false);
			caster.Map.RemoveMonster(shieldMonster);
		}

		/// <summary>
		/// Dresses up the shield monster to look like the player's shield.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="padHandle"></param>
		/// <param name="shieldMonster"></param>
		private void DressUpShield(ICombatEntity caster, int padHandle, Mob shieldMonster)
		{
			if (caster is Character character)
			{
				var shield = character.Inventory.GetItem(EquipSlot.LeftHand).Data;
				Send.ZC_NORMAL.SetPadModel(shieldMonster, "warrior_f_", shield.Id);
			}

			Send.ZC_NORMAL.SkillItemRotate(shieldMonster, 90);
			Send.ZC_NORMAL.SpinObject(shieldMonster);
			Send.ZC_NORMAL.SkillSetActorHeight(shieldMonster, padHandle, 22);
			Send.ZC_NORMAL.AttachEffect(shieldMonster, "I_light004_violet", 1.5f);
		}

		/// <summary>
		/// Checks to see if the Shield collides with any enemies
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="shieldMonster"></param>
		/// <param name="cancelToken"></param>
		private async void CheckShieldCollision(Skill skill, ICombatEntity caster, Mob shieldMonster, CancellationTokenSource cancelToken)
		{
			// We have to track sr manually since this skill
			// checks for targets constantly as its hitbox moves

			var hitTargets = new List<ICombatEntity>();

			var sr = (int)skill.Properties.GetFloat(PropertyName.SkillSR);
			if (ZoneServer.Instance.Conf.World.DisableSDR)
				sr = int.MaxValue;

			while (!cancelToken.IsCancellationRequested)
			{
				var splashArea = new Circle(shieldMonster.Position, 40);

				// You can't hit the same target twice (until the shield is on
				// the way back)
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
				if (targets.Count > 0)
					targets.RemoveAll(hitTargets.Contains);

				var targetsLeft = sr - hitTargets.Count;

				if (targets.Count > targetsLeft)
					targets.RemoveRange(targetsLeft, targets.Count - targetsLeft);

				if (targets.Count > 0)
				{
					hitTargets.AddRange(targets);
					this.Attack(skill, caster, targets);
				}

				await Task.Delay(100);
			}
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="targets"></param>
		private void Attack(Skill skill, ICombatEntity caster, List<ICombatEntity> targets)
		{
			var damageDelay = TimeSpan.FromMilliseconds(100);
			var skillHitDelay = TimeSpan.Zero;

			var bonusPAtk = HighGuard_Abil_Buff.GetBonusPAtk(caster);

			var hits = new List<SkillHitInfo>();

			foreach (var target in targets)
			{
				var modifier = SkillModifier.MultiHit(4);
				modifier.BonusPAtk = bonusPAtk;

				// Increase damage by 10% if target is under the effect of
				// Swashbuckling from the caster
				if (target.TryGetBuff(BuffId.SwashBuckling_Debuff, out var swashBuckingDebuff))
				{
					if (swashBuckingDebuff.Caster == caster)
						modifier.DamageMultiplier += 0.10f;
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
