using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using Yggdrasil.Logging;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Cataphract
{
	/// <summary>
	/// Handler for the Cataphract skill Steed Charge.
	/// </summary>
	[SkillHandler(SkillId.Cataphract_SteedCharge)]
	public class Cataphract_SteedCharge : IGroundSkillHandler
	{
		public const float JumpDistance = 175f;
		public const float AttackDistance = 25f;

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
			// Note that the "Direction" sent with the attack packet for
			// this skill is actually wrong, so we have to use the farpos
			caster.TurnTowards(farPos);
			caster.SetAttackState(true);

			var jumpDistance = JumpDistance;
			var attackDistance = AttackDistance;

			// Cataphract40 makes it go only half as far
			if (caster.IsAbilityActive(AbilityId.Cataphract40))
			{ 
				jumpDistance /= 2f;
				attackDistance /= 2f;
			}

			var targetPos = caster.Position.GetRelative(caster.Direction, jumpDistance);

			targetPos = caster.Map.Ground.GetLastValidPosition(caster.Position, targetPos);
			var actualDistance = (float)caster.Position.Get2DDistance(targetPos);		

			var splashParam = skill.GetSplashParameters(caster, originPos, targetPos, length: actualDistance + attackDistance, width: 28, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, targetPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPos, null);

			Send.ZC_NORMAL.LeapJump(caster, targetPos, 0, 0, 1f, 0.35f, 0.7f, 0);

			CallSafe(Attack(skill, caster, splashArea));

			// Spawn Fire Pads if this is the Fire Chariot version
			if (caster.IsAbilityActive(AbilityId.Cataphract40))
			{
				// The visual of the pad extends 25 units behind the
				// pad's position.  The second pad doesn't include
				// this part in its hit area so they don't overlap.
				var pad1StartPosition = originPos.GetRelative(caster.Direction.Backwards, 25f);
				var pad1Param = skill.GetSplashParameters(caster, pad1StartPosition, targetPos, length: 75, width: 28, angle: 0);
				var pad1Area = skill.GetSplashArea(SplashType.Square, pad1Param);
				var pad1 = new Pad(PadName.Cataphract_SteedCharge, caster, skill, pad1Area);
				pad1.Position = originPos;
				pad1.Trigger.LifeTime = TimeSpan.FromSeconds(5);
				pad1.Trigger.UpdateInterval = TimeSpan.FromSeconds(1);
				pad1.Trigger.MaxActorCount = 15;
				caster.Map.AddPad(pad1);
				pad1.Trigger.Subscribe(TriggerType.Update, this.OnTriggerUpdate);

				// We don't spawn the second pad if the jump is cut short
				if (actualDistance >= 75f)
				{					
					var pad2StartPosition = originPos.GetRelative(caster.Direction, 50f);
					var pad2Param = skill.GetSplashParameters(caster, pad2StartPosition, targetPos, length: 50, width: 28, angle: 0);
					var pad2Area = skill.GetSplashArea(SplashType.Square, pad1Param);
					var pad2 = new Pad(PadName.Cataphract_SteedCharge, caster, skill, pad2Area);
					pad2.Position = originPos.GetRelative(caster.Direction, 50f);
					pad2.Trigger.LifeTime = TimeSpan.FromSeconds(5);
					pad2.Trigger.UpdateInterval = TimeSpan.FromSeconds(1);
					pad2.Trigger.MaxActorCount = 15;
					caster.Map.AddPad(pad2);
					pad2.Trigger.Subscribe(TriggerType.Update, this.OnTriggerUpdate);
				}
			}
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private static async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var hitDelay = TimeSpan.FromMilliseconds(200);
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(hitDelay);

			var bonusMultiplier = 0f;
			if (caster.TryGetSkill(SkillId.Cataphract_AcrobaticMount, out var acrobaticMount))
			{
				bonusMultiplier = 0.5f + acrobaticMount.Level * 0.06f;
			}

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(3);
				modifier.DamageMultiplier += bonusMultiplier;

				// Always criticals against slowed targets
				if (target.IsBuffActive(BuffId.Common_Slow) && caster.IsAbilityActive(AbilityId.Cataphract27))
				{
					modifier.ForcedCritical = true;
				}

				if (caster.IsAbilityActive(AbilityId.Cataphract40))
				{
					modifier.OverrideAttackAttribute = true;
					modifier.AttackAttribute = SkillAttribute.Fire;
				}

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

				if (caster.IsAbilityActive(AbilityId.Cataphract29))
				{
					skillHit.HitEffect = HitEffect.Impact;
				}
				else
				{
					skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
					skillHit.HitInfo.Type = HitType.KnockBack;
					target.Position = skillHit.KnockBackInfo.ToPosition;
				}

				hits.Add(skillHit);

				// Inflicts 3 second slow on critical hit only
				// Presumably this doesn't apply if Cataphract27 is on
				if (!caster.IsAbilityActive(AbilityId.Cataphract27))
				{
					if (skillHitResult.Result == HitResultType.Crit)
					{
						target.StartBuff(BuffId.Common_Slow, skill.Level, 0, TimeSpan.FromSeconds(3), caster);
					}
				}
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);			
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

			Log.Warning("Flame tick");

			var targets = pad.Trigger.GetAttackableEntities(caster);

			foreach (var target in targets.LimitBySDR(caster, skill))
				FireDamage(skill, caster, target);
		}


		/// <summary>
		/// Deals the damage from the pad
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private static void FireDamage(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;


			var modifier = SkillModifier.Default;
			modifier.OverrideAttackAttribute = true;
			modifier.AttackAttribute = SkillAttribute.Fire;

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

			target.TakeDamage(skillHitResult.Damage / 2, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
			skillHit.HitEffect = HitEffect.Impact;

			Send.ZC_SKILL_HIT_INFO(caster, skillHit);
		}
	}
}
