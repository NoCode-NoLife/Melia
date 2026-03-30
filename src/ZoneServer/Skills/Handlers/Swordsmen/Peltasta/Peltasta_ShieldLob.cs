using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.Util;
using Melia.Shared.World;
using Melia.Zone.Abilities.Handlers.Swordsmen.Peltasta;
using Melia.Zone.Network;
using Melia.Zone.Pads;
using Melia.Zone.Pads.Handlers;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Peltasta
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

			var padPos = caster.Position.GetRelative2D(caster.Direction, 25);
			var pad = Pad.Create(PadName.Peltasta_ShieldLob, caster, skill, padPos, new Circle(padPos, 40), PadOptions.Default);

			caster.Map.AddPad(pad);
		}
	}

	/// <summary>
	/// Handler for the Shield Lob pad, spawning a shield modeled after the
	/// caster's shield, that flies forward and then back, Captain America
	/// style.
	/// </summary>
	[PadHandler(PadName.Peltasta_ShieldLob)]
	public class Peltasta_ShieldLob_Pad : ICreatePadHandler, IEnterPadHandler
	{
		private const float ShieldFlyDistance = 100;
		private const float ShieldFlySpeedForward = 150;
		private readonly static TimeSpan HomingTickTime = TimeSpan.FromMilliseconds(250);

		/// <summary>
		/// Called when the pad is created.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Created(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;

			pad.Movement.Speed = ShieldFlySpeedForward;
			pad.Trigger.MaxActorCount = 8;

			//if (creator.Map.IsPvp)
			//	pad.Trigger.ActorMaxCount = 4;

			var shieldMonster = pad.CreateMonster(57001, FactionType.Neutral);
			shieldMonster.AttachEffect(new AttachableEffect("I_light004_violet", 1.5f));
			pad.Map.AddMonster(shieldMonster);

			if (creator.TryGetItem(EquipSlot.LeftHand, out var lhItem))
			{
				// Check item type for shield? Though it will be funny when
				// someone manages to throw something else, and it's only
				// a visual effect anyway.
				Send.ZC_NORMAL.PadSetModel(shieldMonster, "warrior_f_", lhItem.Id);
			}

			Send.ZC_NORMAL.ActorRotate(shieldMonster, 90, 0, 0);
			Send.ZC_NORMAL.SpinObject(shieldMonster, 0, -1, 0.2f, 0);
			Send.ZC_NORMAL.PadSetMonsterAltitude(pad, shieldMonster, 22);

			TaskHelper.CallSafe(this.FlyShieldFly(pad, creator));
		}

		/// <summary>
		/// Makes shield fly forward, away from the caster, and then back.
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		private async Task FlyShieldFly(Pad pad, ICombatEntity creator)
		{
			// Forward and back, hovering a moment in between.
			await this.FlyForward(pad, creator);
			await Task.Delay(500);
			await this.FlyBack(pad, creator);

			pad.Destroy();
		}

		/// <summary>
		/// Makes shield fly a certain distance forward, in the direction
		/// the creator is facing.
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		/// <returns></returns>
		private async Task FlyForward(Pad pad, ICombatEntity creator)
		{
			var dest = creator.Position.GetRelative2D(creator.Direction, ShieldFlyDistance);
			var moveTime = pad.Movement.MoveTo(dest);

			await Task.Delay(moveTime);
		}

		/// <summary>
		/// Makes shield fly back to the creator.
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		/// <returns></returns>
		private async Task FlyBack(Pad pad, ICombatEntity creator)
		{
			// Try homing in on the creator for a while
			for (var i = 0; i < 20; ++i)
			{
				// Stop if the pad is close enough to get to the creator
				// in one tick
				var moveTimeToCreator = pad.Movement.CalcMoveToTime(creator.Position);
				if (moveTimeToCreator <= HomingTickTime)
					break;

				// Aim past the creator to ensure smooth movement if they're
				// moving away during the wait time
				var dest = pad.Position.GetRelative3D(creator.Position, 300);
				pad.Movement.MoveTo(dest);

				await Task.Delay(HomingTickTime);
			}

			// Final push to get back to the creator. Aim past the creator
			// if they're moving, to close the gap between them and where
			// the shield will disappear
			var finalDest = creator.Position;
			if (creator.Components.TryGet<MovementComponent>(out var movement) && movement.IsMoving)
				finalDest = creator.Position.GetRelative2D(creator.Direction, 50);

			var moveTime = pad.Movement.MoveTo(finalDest);
			await Task.Delay(moveTime);
		}

		/// <summary>
		/// Applies damage to targets hit by the shield.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Entered(object sender, PadTriggerActorArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var target = args.Initiator;
			var skill = pad.Skill;

			if (pad.Trigger.AtCapacity)
				return;

			if (!caster.CanDamage(target))
				return;

			var aniTime = TimeSpan.FromMilliseconds(100);
			var hitDelay = TimeSpan.Zero;

			var modifier = SkillModifier.MultiHit(4);
			modifier.BonusPAtk = Peltasta38.GetBonusPAtk(caster);

			// Debuff: "Threat", Increases damage by 10%
			if (target.TryGetBuff(BuffId.SwashBuckling_Debuff, out var swashBuckingDebuff))
			{
				if (swashBuckingDebuff.Caster == caster)
					modifier.DamageMultiplier += 0.10f;
			}

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, aniTime, hitDelay);
			skillHit.HitEffect = HitEffect.Impact;

			skillHit.ApplyDamage();
			skillHit.ApplyKnockBack();

			Send.ZC_SKILL_HIT_INFO(caster, skillHit);
		}
	}
}
