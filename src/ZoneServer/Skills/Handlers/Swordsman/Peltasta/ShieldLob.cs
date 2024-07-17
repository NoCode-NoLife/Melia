using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.L10N;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using System.Threading;

namespace Melia.Zone.Skills.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handler for the Peltasta skill Shield Lob.
	/// </summary>
	[SkillHandler(SkillId.Peltasta_ShieldLob)]
	public class Peltasta_ShieldLob : IGroundSkillHandler
	{
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

			ThrowShield(skill, caster, farPos);
		}


		/// <summary>
		/// Handles the spawning and throwing of the shield
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void ThrowShield(Skill skill, ICombatEntity caster, Position originPos)
		{
			// Spawn the shield
			var skillHandle = ZoneServer.Instance.World.CreateSkillHandle();
			var shieldMonster = new Mob(57001, MonsterType.Friendly);			

			shieldMonster.Position = caster.Position.GetRelative(caster.Direction, 25f);
			shieldMonster.Direction = caster.Direction;
			shieldMonster.FromGround = false;
			shieldMonster.Components.Add(new MovementComponent(shieldMonster));
			Send.ZC_NORMAL.SkillPad(caster, skill, "Peltasta_ShieldLob2", shieldMonster.Position, shieldMonster.Direction, -0.7853982f, 0, skillHandle, 30);			

			caster.Map.AddMonster(shieldMonster);


			// Set the shield graphic to match the character's shield
			if (caster is Character character)
			{
				var shield = character.Inventory.GetItem(EquipSlot.LeftHand).Data;
				Send.ZC_NORMAL.SetPadModel(shieldMonster, "warrior_f_", shield.Id);
			}
			Send.ZC_NORMAL.Skill_ItemRotate(shieldMonster, 90);
			Send.ZC_NORMAL.SpinObject(shieldMonster);
			Send.ZC_NORMAL.Skill_SetActorHeight(shieldMonster, skillHandle, 22);
			Send.ZC_NORMAL.AttachEffect(shieldMonster, "I_light004_violet", 1.5f);

			// Begin the shield throw, throwing shield outwards to the far point
			var movement = shieldMonster.Components.Get<MovementComponent>();
			movement.SetFixedMoveSpeed(150f);
			movement.SetMoveSpeedType(MoveSpeedType.Run);
			var endingPosition = originPos.GetRelative(caster.Direction, 100f);
			endingPosition = caster.Map.Ground.GetLastValidPosition(caster.Position, endingPosition);
			var moveTime = movement.MoveTo(endingPosition);
			Send.ZC_NORMAL.Skill_EffectMovement(caster, skillHandle, endingPosition, 150);
			
			var cancelToken = new CancellationTokenSource();
			checkShieldCollision(skill, caster, shieldMonster, cancelToken);
			await Task.Delay(moveTime);

			// Reached destination, pause briefly before returning
			await Task.Delay(TimeSpan.FromMilliseconds(500));

			// Return trip back to player.
			movement.SetFixedMoveSpeed(200f);
			cancelToken.Cancel();
			cancelToken = new CancellationTokenSource();
			checkShieldCollision(skill, caster, shieldMonster, cancelToken);

			// We loop over this a few times so the shield homes in on your location even if you're moving
			for (int i = 0; i < 5; i++) 
			{ 
				moveTime = movement.MoveTo(caster.Position);
				Send.ZC_NORMAL.Skill_EffectMovement(caster, skillHandle, caster.Position, 200);
				await Task.Delay(moveTime.Divide(3));
			}

			// Should be close enough to your position, return to the player
			moveTime = movement.MoveTo(caster.Position);
			Send.ZC_NORMAL.Skill_EffectMovement(caster, skillHandle, caster.Position, 200);
			await Task.Delay(moveTime);

			// Shield has returned, remove the shield and restore the shield to your hand
			cancelToken.Cancel();
			Send.ZC_NORMAL.SkillPad(caster, skill, "Peltasta_ShieldLob2", originPos, caster.Direction, 0, 145.8735f, skillHandle, 30, false);
			caster.Map.RemoveMonster(shieldMonster);			
		}



		/// <summary>
		/// Checks to see if the Shield collides with any enemies
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void checkShieldCollision(Skill skill, ICombatEntity caster, Mob shieldMonster, CancellationTokenSource cancelToken)
		{
			// We have to track sr manually since this skill
			// checks for targets constantly as its hitbox moves
			List<ICombatEntity> hitTargets = new List<ICombatEntity>();
			var sr = (int)skill.Properties.GetFloat(PropertyName.SkillSR);
			if (ZoneServer.Instance.Conf.World.DisableSDR)
				sr = int.MaxValue;

			while (!cancelToken.IsCancellationRequested)
			{
				var splashArea = new Circle(shieldMonster.Position, 40);

				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
				// you can't hit the same target twice (until the shield is on the way back)
				if (targets.Count > 0)
					targets.RemoveAll(hitTargets.Contains);

				var targetsLeft = sr - hitTargets.Count;

				if (targets.Count > targetsLeft)
					targets.RemoveRange(targetsLeft, targets.Count - targetsLeft);

				if (targets.Count > 0)
				{
					hitTargets.AddRange(targets);
					Attack(skill, caster, targets);
				}

				await Task.Delay(TimeSpan.FromMilliseconds(50));
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

			var bonusPatk = 0f;

			if (caster.TryGetBuff(BuffId.HighGuard_Abil_Buff, out var highGuardAbilBuff) && caster is Character character)
			{
				// adds bonus Patk based on shield physical defense
				var shield = character.Inventory.GetItem(EquipSlot.LeftHand).Data;
				bonusPatk = highGuardAbilBuff.NumArg1 * 0.06f * shield.Def;
			}

			var hits = new List<SkillHitInfo>();

			foreach (var target in targets)
			{
				var modifier = SkillModifier.MultiHit(4);
				modifier.BonusPAtk = bonusPatk;

				if (target.TryGetBuff(BuffId.SwashBuckling_Debuff, out var swashBuckingDebuff))
				{
					// takes 10% more damage if under the effect of Swashbuckling from the caster
					if (swashBuckingDebuff.Caster == caster)
						modifier.DamageMultiplier += 0.1f;
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
