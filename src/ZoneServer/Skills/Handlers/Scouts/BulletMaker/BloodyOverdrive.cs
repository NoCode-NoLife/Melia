using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yggdrasil.Util;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scouts.BulletMaker
{
	/// <summary>
	/// Handles the Bullet Maker's skill Bloody Overdrive.
	/// </summary>
	[SkillHandler(SkillId.Bulletmarker_BloodyOverdrive)]
	public class BloodyOverdrive : IGroundSkillHandler
	{
		// Since it's not know the internals for this skill
		// We are randomizing it a bit to feel more smooth
		private const int HitAttackChance = 50;

		/// <summary>
		/// Handles the skill, shots the pistol around damaging nearby enemies
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			if (!caster.IsBuffActive(BuffId.DoubleGunStance_Buff))
				return;

			skill.IncreaseOverheat();
			caster.TurnTowards(target);
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, Position.Zero);

			// Increase by one the stack count for Overheating buff
			if (!caster.IsBuffActive(BuffId.Outrage_Buff))
				caster.StartBuff(BuffId.Overheating_Buff, TimeSpan.FromSeconds(35));

			// @TODO: Can't be knockdown back/down while casting the skill
			caster.StartBuff(BuffId.Skill_SuperArmor_Buff, TimeSpan.FromSeconds(1));

			// Bloody Overdrive: Invincible
			if (caster.IsAbilityActive(AbilityId.Bulletmarker12))
			{
				caster.StartBuff(BuffId.Skill_NoDamage_Buff, TimeSpan.FromSeconds(1));
			}

			if (caster.TryGetBuff(BuffId.Outrage_Buff, out var outrageBuff) && outrageBuff.OverbuffCounter > 0)
			{
				caster.Components.Get<BuffComponent>().Overbuff(outrageBuff, -1);
			}

			CallSafe(this.Attack(skill, caster));
		}

		/// <summary>
		/// Execute the attack to nearby enemies wihtin a delay
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <returns></returns>
		private async Task Attack(Skill skill, ICombatEntity caster)
		{
			var splashArea = new Circle(caster.Position, 80);

			Debug.ShowShape(caster.Map, splashArea, TimeSpan.FromSeconds(2));

			var tagets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var indexHelper = 0;
			var rnd = RandomProvider.Get();

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, null);

			for (int i = 0; i < 4; i++)
			{
				if (rnd.Next(100) < HitAttackChance)
					continue;
				
				var skillHits = new List<SkillHitInfo>();

				foreach (var hitTarget in tagets.LimitRandom(23))
				{
					this.AddSkillHitInfo(caster, hitTarget, skill, TimeSpan.Zero, skillHits, indexHelper);
				}

				await Task.Delay(TimeSpan.FromMilliseconds(400));

				Send.ZC_SKILL_HIT_INFO(caster, skillHits);
			}

			// Bloody Overdrive: Ricochet
			if (caster.IsAbilityActive(AbilityId.Bulletmarker8))
			{
				foreach (var hitTarget in tagets.LimitBySDR(caster, skill))
				{
					if (this.TryGetRicochetTarget(caster, hitTarget, skill, out var ricochetTarget))
					{
						var skillHitResult = SCR_SkillHit(caster, ricochetTarget, skill);
						ricochetTarget.TakeDamage(skillHitResult.Damage, caster);

						var hit = new HitInfo(caster, hitTarget, skill, skillHitResult);
						hit.ForceId = ForceId.GetNew();
						hit.ResultType = HitResultType.Hit;

						Send.ZC_HIT_INFO(caster, ricochetTarget, hit);
					}
				}
			}

		}

		/// <summary>
		/// Adds a new HitInfo to the processing list
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="skillHitDelay"></param>
		/// <param name="skillHits"></param>
		/// <param name="indexHelper"></param>
		private void AddSkillHitInfo(ICombatEntity caster, ICombatEntity target, Skill skill, TimeSpan skillHitDelay, List<SkillHitInfo> skillHits, int indexHelper)
		{
			indexHelper++;

			var skillHitResult = SCR_SkillHit(caster, target, skill);

			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, TimeSpan.FromMilliseconds(400 * indexHelper), skillHitDelay);

			skillHits.Add(skillHit);
		}

		/// <summary>
		/// Returns the closest target to the main target to ricochet the attack off to.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="mainTarget"></param>
		/// <param name="skill"></param>
		/// <param name="ricochetTarget"></param>
		/// <returns></returns>
		private bool TryGetRicochetTarget(ICombatEntity caster, ICombatEntity mainTarget, Skill skill, out ICombatEntity ricochetTarget)
		{
			var splashPos = caster.Position;
			var splashRadius = 50;
			var splashArea = new Circle(mainTarget.Position, splashRadius);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			if (!targets.Any())
			{
				ricochetTarget = null;
				return false;
			}

			ricochetTarget = targets.GetClosest(mainTarget.Position, a => a != mainTarget);
			return ricochetTarget != null;
		}
	}
}
