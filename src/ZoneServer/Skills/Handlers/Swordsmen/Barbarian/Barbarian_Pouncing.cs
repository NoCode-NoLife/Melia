using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Pads;
using Melia.Zone.Pads.Handlers;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using Yggdrasil.Util;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handler for the Barbarian skill Pouncing
	/// </summary>
	[SkillHandler(SkillId.Barbarian_Pouncing)]
	public class Barbarian_Pouncing : IDynamicCasted
	{
		/// <summary>
		/// Called when the user starts casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			caster.StartBuff(BuffId.Pouncing_Buff, TimeSpan.Zero);

			var padName = PadName.Barbarian_Pouncing;
			var length = 35f;

			var rhWeaponType = caster.Components.Get<InventoryComponent>()?.GetItem(EquipSlot.RightHand)?.Data.EquipType1;
			var lhWeaponType = caster.Components.Get<InventoryComponent>()?.GetItem(EquipSlot.LeftHand)?.Data.EquipType1;
			var swordAndDagger = rhWeaponType == EquipType.Sword && lhWeaponType == EquipType.Dagger;
			var updateInverval = TimeSpan.FromMilliseconds(swordAndDagger ? 240 : 300);

			// Barbarian41 uses a different pad, which has double range
			// but you can't move
			if (caster.IsAbilityActive(AbilityId.Barbarian41))
			{
				padName = PadName.Barbarian_Pouncing_Abil;
				length = 70f;
			}

			var pad = Pad.Create(padName, caster, skill, caster.Position, new Square(caster.Position, caster.Direction, length, 35), new PadOptions
			{
				LifeTime = TimeSpan.FromMilliseconds(3500),
				UpdateInterval = updateInverval,
				MaxActorCount = 6,
			});

			caster.Map.AddPad(pad);
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			caster.StopBuff(BuffId.Pouncing_Buff);
		}
	}
	/// <summary>
	/// Handler for the Barbarian_Pouncing pad, creates and disables the effect.
	/// </summary>
	[PadHandler(PadName.Barbarian_Pouncing)]
	public class Barbarian_Pouncing_Pad : IUpdatePadHandler
	{
		/// <summary>
		/// Called in regular intervals while the pad is on a map.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public virtual void Updated(object sender, PadTriggerArgs args)
		{
			if (!args.Creator.IsBuffActive(BuffId.Pouncing_Buff))
			{
				args.Trigger.Destroy();
				return;
			}

			args.Trigger.Position = args.Creator.Position;
			args.Trigger.Direction = args.Creator.Direction;

			this.ApplyDamage(sender, args);
		}

		/// <summary>
		/// Applies damage to targets in the pad area every update.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void ApplyDamage(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var skill = args.Skill;

			var targets = pad.Trigger.GetAttackableEntities(caster);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var damageDelay = TimeSpan.Zero;
				var skillHitDelay = TimeSpan.Zero;

				var modifier = SkillModifier.MultiHit(3);

				// Wild Nature effects - 6% damage per stack
				// 6% chance per stack of double damage to stunned targets
				if (caster.TryGetBuff(BuffId.ScudInstinct_Buff, out var wildNature))
				{
					modifier.DamageMultiplier += 0.06f * wildNature.OverbuffCounter;

					if (target.IsBuffActive(BuffId.Stun) && RandomProvider.Get().Next(100) < wildNature.OverbuffCounter * 6)
						modifier.DamageMultiplier++;
				}

				var weaponType = caster.Components.Get<InventoryComponent>()?.GetItem(EquipSlot.RightHand)?.Data.EquipType1;
				if (weaponType == EquipType.THSword)
					modifier.BonusCritChance += 30;

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

				if (caster.IsAbilityActive(AbilityId.Barbarian4))
				{
					skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
					skillHit.ApplyKnockBack(target);
				}
				else
				{
					skillHit.HitEffect = HitEffect.Impact;
				}

				Send.ZC_SKILL_HIT_INFO(caster, skillHit);
			}
		}
	}

	/// <summary>
	/// Handler for the Barbarian_Pouncing_Abil pad.
	/// </summary>
	[PadHandler(PadName.Barbarian_Pouncing_Abil)]
	public class Barbarian_Pouncing_Abil : Barbarian_Pouncing_Pad
	{
		// Functionally the same as the basic pad?
	}
}
