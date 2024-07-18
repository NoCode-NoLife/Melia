using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
using Melia.Zone.World.Actors.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using Melia.Zone.World.Actors.Pads.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handler for the Peltasta skill Shield Lob.
	/// </summary>
	[SkillHandler(SkillId.Peltasta_ShieldLob)]
	public class Peltasta_ShieldLob : IGroundSkillHandler
	{
		private const float ShieldFlyDistance = 100;
		private const float ShieldFlySpeedForward = 150;

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

			//this.ThrowShield(skill, caster, farPos);
			//return;

			var pad = new Pad("Peltasta_ShieldLob", caster, skill, new Circle(caster.Position, 40));
			pad.Position = caster.Position.GetRelative(caster.Direction, 25);
			pad.Speed = ShieldFlySpeedForward;

			pad.Components.Get<TriggerComponent>().UpdateInterval = TimeSpan.FromMilliseconds(100);

			pad.Components.Get<TriggerComponent>().Created += async (sender, args) =>
			{
				var pad = args.Trigger as Pad;
				var creator = pad.Creator as ICombatEntity;

				var shieldMonster = new Mob(57001, MonsterType.Friendly);

				shieldMonster.Position = creator.Position.GetRelative(creator.Direction, 25f);
				shieldMonster.Direction = creator.Direction;
				shieldMonster.FromGround = false;
				shieldMonster.Components.Add(new MovementComponent(shieldMonster));

				Send.ZC_NORMAL.SkillPad(creator, skill, "Peltasta_ShieldLob2", shieldMonster.Position, shieldMonster.Direction, -0.7853982f, 0, pad.Handle, 30, true);
				creator.Map.AddMonster(shieldMonster);

				if (creator is Character character)
				{
					var shield = character.Inventory.GetItem(EquipSlot.LeftHand).Data;
					Send.ZC_NORMAL.SetPadModel(shieldMonster, "warrior_f_", shield.Id);
				}

				Send.ZC_NORMAL.SkillItemRotate(shieldMonster, 90, 0, 0);
				Send.ZC_NORMAL.SpinObject(shieldMonster);
				Send.ZC_NORMAL.SkillSetActorHeight(shieldMonster, pad.Handle, 22);
				Send.ZC_NORMAL.AttachEffect(shieldMonster, "I_light004_violet", 1.5f);

				pad.Variables.Set("shieldMonster", shieldMonster);

				var flyDest = creator.Position.GetRelative(creator.Direction, ShieldFlyDistance);
				var moveTime = pad.Components.Get<PadMovementComponent>().MoveTo(flyDest);
				await Task.Delay(moveTime);

				await Task.Delay(500);

				moveTime = pad.Components.Get<PadMovementComponent>().MoveTo(creator.Position);
				await Task.Delay(moveTime);

				pad.Destroy();
			};

			pad.Components.Get<TriggerComponent>().Entered += (sender, args) =>
			{
				var pad = args.Trigger as Pad;
				var creator = pad.Creator as ICombatEntity;
				var target = args.Initiator as ICombatEntity;

				var concurrentCount = pad.Variables.GetInt("concurrentCount", 0);
				if (concurrentCount >= 8)
					return;

				pad.Variables.Set("concurrentCount", concurrentCount + 1);

				if (!creator.CanAttack(target))
					return;

				this.Attack(skill, caster, [target]);
			};

			pad.Components.Get<TriggerComponent>().Left += (sender, args) =>
			{
				var concurrentCount = pad.Variables.GetInt("concurrentCount", 0);
				pad.Variables.Set("concurrentCount", Math.Max(0, concurrentCount - 1));
			};

			pad.Components.Get<TriggerComponent>().Destroyed += (sender, args) =>
			{
				var pad = args.Trigger as Pad;
				var shieldMonster = pad.Variables.Get<Mob>("shieldMonster");

				Send.ZC_NORMAL.SkillPad(caster, skill, "Peltasta_ShieldLob2", originPos, caster.Direction, 0, 145.8735f, pad.Handle, 30, false);
				caster.Map.RemoveMonster(shieldMonster);
			};

			caster.Map.AddPad(pad);
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
