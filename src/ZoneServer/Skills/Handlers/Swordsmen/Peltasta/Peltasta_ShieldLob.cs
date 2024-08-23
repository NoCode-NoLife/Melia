using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Abilities.Handlers.Swordsmen.Peltasta;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
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

			var pad = new Pad(PadName.Peltasta_ShieldLob, caster, skill, new Circle(caster.Position, 40));
			pad.Position = caster.Position.GetRelative(caster.Direction, 25);
			pad.Trigger.Subscribe(TriggerType.Enter, this.OnShieldCollision);

			caster.Map.AddPad(pad);
		}

		/// <summary>
		/// Called when an actor enters the shield's area.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnShieldCollision(object sender, PadTriggerActorArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;
			var target = args.Initiator;

			if (pad.Trigger.AtCapacity)
				return;

			if (!creator.CanAttack(target))
				return;

			this.Attack(pad.Skill, creator, target);
		}

		/// <summary>
		/// Attacks the target one time.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private void Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var damageDelay = TimeSpan.FromMilliseconds(100);
			var skillHitDelay = TimeSpan.Zero;

			var modifier = SkillModifier.MultiHit(4);
			modifier.BonusPAtk = Peltasta38.GetBonusPAtk(caster);

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

			Send.ZC_SKILL_HIT_INFO(caster, skillHit);
		}
	}
}
