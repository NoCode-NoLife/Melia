using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scouts.BulletMaker
{
	/// <summary>
	/// Handles the Bullet Maker's skill Rest In Peace (R.I.P.).
	/// </summary>
	[SkillHandler(SkillId.Bulletmarker_RestInPeace)]
	public class Bulletmarker_RestInPeace : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, shoot with the pistol and hits enemies in front
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

			var skillHits1 = new List<SkillHitInfo>();
			var skillHits2 = new List<SkillHitInfo>();

			var splashArea = new Square(caster.Position, caster.Direction, 150, 30);

			var tagets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var otherTarget in tagets.LimitBySDR(caster, skill))
			{
				this.AddSkillHitInfo(caster, otherTarget, skill, TimeSpan.FromMilliseconds(23), TimeSpan.Zero, skillHits1);
				this.AddSkillHitInfo(caster, otherTarget, skill, TimeSpan.FromMilliseconds(478), TimeSpan.Zero, skillHits2);
			}

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, skillHits1);
			Send.ZC_SKILL_HIT_INFO(caster, skillHits2);

			if (caster.TryGetBuff(BuffId.Outrage_Buff, out var outrageBuff) && outrageBuff.OverbuffCounter > 0)
			{
				caster.Components.Get<BuffComponent>().Overbuff(outrageBuff, -1);
			}
		}

		/// <summary>
		/// Adds a new HitInfo to the processing list
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="damageDelay"></param>
		/// <param name="skillHitDelay"></param>
		/// <param name="skillHits"></param>
		private void AddSkillHitInfo(ICombatEntity caster, ICombatEntity target, Skill skill, TimeSpan damageDelay, TimeSpan skillHitDelay, List<SkillHitInfo> skillHits)
		{
			var modifier = SkillModifier.Default;
			modifier.HitCount = 2;

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

			// Increase the damage 55% if caster has Outrage Buff
			if (caster.IsBuffActive(BuffId.Outrage_Buff))
				skillHitResult.Damage *= 1.55f;

			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);

			skillHits.Add(skillHit);
		}
	}
}
