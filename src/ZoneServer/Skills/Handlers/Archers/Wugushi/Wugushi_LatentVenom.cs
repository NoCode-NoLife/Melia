﻿using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handler for the Wugushi skill Latent Venom.
	/// </summary>
	[SkillHandler(SkillId.Wugushi_LatentVenom)]
	public class Wugushi_LatentVenom : ITargetSkillHandler
	{
		/// <summary>
		/// Handles skill, hits the target applying a debuff to it. 
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			if (target == null)
			{
				Send.ZC_NORMAL.Skill_42(caster, skill.Id, caster.Direction, ForceId.GetNew());
				Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, caster.Position, caster.Direction, Position.Zero);
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				Send.ZC_NORMAL.Skill_43(caster);
				return;
			}

			caster.TurnTowards(target.Position);

			var damageDelay = TimeSpan.FromMilliseconds(200);

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, TimeSpan.Zero);
			skillHit.ForceId = ForceId.GetNew();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, target.Handle, caster.Position, caster.Direction, target.Position);
			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHit);
			Send.ZC_SHOW_EMOTICON(target, "I_emo_poison", TimeSpan.FromSeconds(100));

			target.StartBuff(BuffId.LatentVenom_Debuff, 0, 0, TimeSpan.FromSeconds(100), caster, skill.Id);
		}
	}
}
