using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using Yggdrasil.Logging;
using Yggdrasil.Util;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Hoplite
{
	/// <summary>
	/// Handler for the Hoplite skill Long Stride
	/// </summary>
	[SkillHandler(SkillId.QuarrelShooter_ScatterCaltrop)]
	public class QuarrelShooter_ScatterCaltrop : IGroundSkillHandler
	{
		public const int MaxDistance = 100;

		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!skill.Vars.TryGet<Position>("Melia.ToolGroundPos", out var targetPos))
			{
				caster.ServerMessage(Localization.Get("No target location specified."));
				Send.ZC_SKILL_CAST_CANCEL(caster);
				return;
			}

			if (!caster.Map.Ground.IsValidPosition(targetPos))
			{
				caster.ServerMessage(Localization.Get("Invalid target location."));
				Send.ZC_SKILL_CAST_CANCEL(caster);
				return;
			}

			if ((int)caster.Position.Get2DDistance(targetPos) > MaxDistance)
			{
				caster.ServerMessage(Localization.Get("Too far."));
				Send.ZC_SKILL_CAST_CANCEL(caster);
				return;
			}

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, originPos, targetPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPos, null);

			var padArea = new Circle(targetPos, 50);

			CallSafe(this.SetPad(skill, caster, padArea));
		}

		/// <summary>
		/// Places the pad
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task SetPad(Skill skill, ICombatEntity caster, Circle padArea)
		{
			var initialDelay = TimeSpan.FromMilliseconds(350);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(initialDelay);

			// TODO Missing animation.  Needs MSL Throw and MSL Pad Throw

			var pad = new Pad(PadName.ScatterCaltrop_Pad, caster, skill, padArea);
			pad.Position = padArea.Center;
			pad.Trigger.MaxActorCount = 6;
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(10);
			pad.Trigger.UpdateInterval = TimeSpan.FromSeconds(1);
			pad.Trigger.Subscribe(TriggerType.Update, this.Attack);
			pad.Trigger.Subscribe(TriggerType.Destroy, this.Expire);

			caster.Map.AddPad(pad);
		}

		/// <summary>
		/// Called by the pad every second to damage
		/// targets inside of it
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void Attack(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;
			var skill = args.Skill;

			var damageDelay = TimeSpan.FromMilliseconds(100);
			var skillHitDelay = TimeSpan.Zero;			

			var targets = pad.Trigger.GetAttackableEntities(creator);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets)
			{
				if (target.MoveType == MoveType.Flying || target.MoveType == MoveType.Fly)
					continue;

				var skillHitResult = SCR_SkillHit(creator, target, skill);
				target.TakeDamage(skillHitResult.Damage, creator);

				var skillHit = new SkillHitInfo(creator, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				target.StartBuff(BuffId.ScatterCaltrop_Debuff, skill.Level, 0, TimeSpan.FromSeconds(1), creator);

				// QuarrelShooter3 inflicts bleed at 8% chance per level
				if (creator.TryGetActiveAbilityLevel(AbilityId.QuarrelShooter3, out var level) && RandomProvider.Get().Next(100) < 8 * level)
				{
					// Unknown duration and damage
					var damage = skillHitResult.Damage * 0.05f;
					target.StartBuff(BuffId.UC_bleed, skill.Level, damage, TimeSpan.FromSeconds(5), creator);
				}

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(creator, hits);
		}

		/// <summary>
		/// Called by the pad when its time elapses
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void Expire(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;
			var skill = args.Skill;

			var targets = pad.Trigger.GetAttackableEntities(creator);

			foreach (var target in targets)
			{
				if (target.MoveType == MoveType.Flying || target.MoveType == MoveType.Fly)
					continue;

				target.StartBuff(BuffId.ScatterCaltrop_Hole_Debuff, skill.Level, 0, TimeSpan.FromSeconds(2), creator);
			}
		}
	}
}
