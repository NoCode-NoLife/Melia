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
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Hoplite
{
	/// <summary>
	/// Handler for the Hoplite skill Throwing Spear
	/// </summary>
	[SkillHandler(SkillId.Hoplite_ThrouwingSpear)]
	public class Hoplite_ThrouwingSpear : IGroundSkillHandler, IDynamicCasted
	{
		private static readonly TimeSpan HitDelay = TimeSpan.FromMilliseconds(435);
		private readonly static TimeSpan DebuffDuration = TimeSpan.FromSeconds(5);

		/// <summary>
		/// Called when the user starts casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
		}

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
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			if (caster is Character character)
				Send.ZC_NORMAL.SkillItemToss(caster, "warrior_f_", "RH", farPos, "F_smoke177", 3, 0.2f, 0, 600, 1, 240, 295, 0, TimeSpan.FromSeconds(3));

			CallSafe(this.Attack(skill, caster, new Circle(farPos, 50)));
			CallSafe(this.Explosion(caster, skill, farPos));
		}

		/// <summary>
		/// Executes the main attack
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(HitDelay);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var modifier = SkillModifier.MultiHit(3);

				var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

				if (caster.Components.TryGet<AbilityComponent>(out var abilities) && abilities.IsActive(AbilityId.Hoplite33))
				{
					skillHit.HitEffect = HitEffect.Impact;
				}
				else
				{
					skillHit.KnockBackInfo = new KnockBackInfo(caster.Position, target.Position, skill);
					skillHit.ApplyKnockBack(target);
				}

				target.StartBuff(BuffId.Common_Shock, skill.Level, 0, DebuffDuration, caster);

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}

		/// <summary>
		/// Executes follow-up attack if Hoplite33 is active.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="farPos"></param>
		/// <returns></returns>
		private async Task Explosion(ICombatEntity caster, Skill skill, Position farPos)
		{
			if (!caster.IsAbilityActive(AbilityId.Hoplite33))
				return;

			await Task.Delay(HitDelay);

			var pad = new Pad(PadName.ThrouwingSpear_Hoplite33_Pad, caster, skill, new Circle(farPos, 50));
			pad.Position = farPos;
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(2);
			pad.Trigger.Subscribe(TriggerType.Destroy, this.SpearExplosion);

			caster.Map.AddPad(pad);
		}

		/// <summary>
		/// Called by the spear explosion effect
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void SpearExplosion(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;

			this.ExplosionAttack(pad.Skill, creator, (ISplashArea)pad.Area);
		}

		/// <summary>
		/// Executes the secondary attack from the spear explosion
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private void ExplosionAttack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var hits = new List<SkillHitInfo>();

			// The explosion has its own maximum target count which is separate from the skill
			var maxTargets = 8;

			if (ZoneServer.Instance.Conf.World.DisableSDR)
				maxTargets = int.MaxValue;

			foreach (var target in targets.LimitRandom(maxTargets))
			{
				var modifier = SkillModifier.MultiHit(3);

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
