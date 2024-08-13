using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsman.Rodelero
{
	/// <summary>
	/// Handler for the Rodelero skill Shield Charge
	/// </summary>
	[SkillHandler(SkillId.Rodelero_ShieldCharge)]
	public class Rodelero_ShieldCharge : IDynamicCasted
	{
		private readonly static TimeSpan DebuffDuration = TimeSpan.FromSeconds(10);

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

			caster.StartBuff(BuffId.ShieldCharge_Buff, TimeSpan.Zero);

			var pad = new Pad(PadName.Rodelero_ShieldCharge, caster, skill, new Square(caster.Position, caster.Direction, 20, 20));
			pad.Position = caster.Position;
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(5);
			pad.Trigger.MaxActorCount = 3;

			// TODO: This update interval is impractically low. We need an option
			//   to just use the creator's position instead of the pad's position
			//   for collisions.
			pad.Trigger.UpdateInterval = TimeSpan.FromMilliseconds(50);
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
			caster.StopBuff(BuffId.ShieldCharge_Buff);
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

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

			skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
			skillHit.HitInfo.Type = skill.Data.KnockDownHitType;
			target.Position = skillHit.KnockBackInfo.ToPosition;

			if (caster.IsBuffActive(BuffId.DashRun))
				target.StartBuff(BuffId.Common_Slow, skill.Level, 0, DebuffDuration, caster);

			Send.ZC_SKILL_HIT_INFO(caster, skillHit);
		}
	}
}
