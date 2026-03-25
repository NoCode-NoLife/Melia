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
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Rodelero
{
	/// <summary>
	/// Handler for the Rodelero skill Shield Charge
	/// </summary>
	[SkillHandler(SkillId.Rodelero_ShieldCharge)]
	public class Rodelero_ShieldCharge : IDynamicCasted
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

			caster.StartBuff(BuffId.ShieldCharge_Buff);

			// TODO: This update interval is impractically low. We need an
			// option to just use the creator's position instead of the
			// pad's position for collisions.

			var pad = Pad.Create(PadName.Rodelero_ShieldCharge, caster, skill, caster.Position, new Square(caster.Position, caster.Direction, 20, 20), new PadOptions
			{
				LifeTime = TimeSpan.FromSeconds(5),
				UpdateInterval = TimeSpan.FromMilliseconds(50),
				MaxActorCount = 3,
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
			caster.StopBuff(BuffId.ShieldCharge_Buff);
		}
	}

	/// <summary>
	/// Handler for the Rodelero_ShieldCharge pad, creates and disables the effect.
	/// </summary>
	[PadHandler(PadName.Rodelero_ShieldCharge)]
	public class Rodelero_ShieldCharge_Pad : IUpdatePadHandler
	{
		/// <summary>
		/// Called in regular intervals while the pad is on a map.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Updated(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var skill = args.Skill;

			if (!caster.IsBuffActive(BuffId.ShieldCharge_Buff))
			{
				pad.Destroy();
				return;
			}

			pad.Position = caster.Position;

			var targets = pad.Trigger.GetAttackableEntities(caster);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var damageDelay = TimeSpan.Zero;
				var skillHitDelay = TimeSpan.Zero;

				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

				skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
				skillHit.ApplyKnockBack(target);

				if (caster.IsBuffActive(BuffId.DashRun))
					target.StartBuff(BuffId.Common_Slow, skill.Level, 0, TimeSpan.FromSeconds(10), caster);

				Send.ZC_SKILL_HIT_INFO(caster, skillHit);
			}
		}
	}
}
