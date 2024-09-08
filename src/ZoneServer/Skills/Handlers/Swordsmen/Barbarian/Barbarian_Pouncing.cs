using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using Yggdrasil.Util;
using static Melia.Zone.Skills.SkillUseFunctions;
using static Melia.Shared.Util.TaskHelper;

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

			// Barbarian41 uses a different pad, which has double range
			// but you can't move
			if (caster.IsAbilityActive(AbilityId.Barbarian41))
			{
				padName = PadName.Barbarian_Pouncing_Abil;
				length = 70f;
			}

			var pad = new Pad(padName, caster, skill, new Square(caster.Position, caster.Direction, length, 35));
			pad.Position = caster.Position;
			pad.Trigger.LifeTime = TimeSpan.FromMilliseconds(3500);
			pad.Trigger.MaxActorCount = 6;

			var rhWeaponType = caster.Components.Get<InventoryComponent>()?.GetItem(EquipSlot.RightHand)?.Data.EquipType1;
			var lhWeaponType = caster.Components.Get<InventoryComponent>()?.GetItem(EquipSlot.LeftHand)?.Data.EquipType1;
			if (rhWeaponType == EquipType.Sword && lhWeaponType == EquipType.Dagger)
			{
				pad.Trigger.UpdateInterval = TimeSpan.FromMilliseconds(240);
			}
			else
			{
				pad.Trigger.UpdateInterval = TimeSpan.FromMilliseconds(300);
			}
			pad.Trigger.Subscribe(TriggerType.Update, this.OnTriggerUpdate);

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

		/// <summary>
		/// Called when an actor enters the area of the attack.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnTriggerUpdate(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var skill = args.Skill;

			var targets = pad.Trigger.GetAttackableEntities(caster);

			foreach (var target in targets.LimitBySDR(caster, skill))
				this.Attack(skill, caster, target);
		}

		/// <summary>
		/// Attacks the target one time.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private void Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
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
				{
					modifier.DamageMultiplier++;
				}
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
				skillHit.HitInfo.Type = skill.Data.KnockDownHitType;
				target.Position = skillHit.KnockBackInfo.ToPosition;
			}
			else
			{
				skillHit.HitEffect = HitEffect.Impact;
			}
			Send.ZC_SKILL_HIT_INFO(caster, skillHit);
		}
	}
}
