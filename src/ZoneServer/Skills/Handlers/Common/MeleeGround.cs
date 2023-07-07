﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Common
{
	/// <summary>
	/// Handles melee skills targeting the ground in front of the caster.
	/// </summary>
	[SkillHandler(SkillId.Normal_Attack, SkillId.Hammer_Attack, SkillId.Common_DaggerAries)]
	public class MeleeGroundSkillHandler : IMeleeGroundSkillHandler
	{
		/// <summary>
		/// Handles usage of the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="targets"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, IList<ICombatEntity> targets)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			this.Attack(skill, caster, originPos, farPos, targets);
		}

		/// <summary>
		/// Executes the actual attack after a potential delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="castPosition"></param>
		/// <param name="targetPosition"></param>
		/// <param name="targets"></param>
		private async void Attack(Skill skill, ICombatEntity caster, Position castPosition, Position targetPosition, IEnumerable<ICombatEntity> targets)
		{
			// Based on Normal_Attack posessing a hit delay of 100ms,
			// and Common_DaggerAries one of 50ms, and these two values
			// matching the logs almost 1:1, we can assume this to be
			// the correct value for the skill hit delay. Not a clue
			// about damage delay though. Though there are potentially
			// related values in older skill_bytool files.
			var damageDelay = TimeSpan.FromMilliseconds(skill.Id != SkillId.Common_DaggerAries ? 330 : 250);
			var skillHitDelay = skill.Properties.HitDelay;

			if (skillHitDelay > TimeSpan.Zero)
				await Task.Delay(skillHitDelay);

			var hits = new List<SkillHitInfo>();

			foreach (var target in targets)
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);
				target.TakeDamage(skillHitResult.Damage, caster);

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
