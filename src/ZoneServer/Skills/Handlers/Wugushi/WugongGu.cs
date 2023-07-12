using System;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Wugushi
{
	/// <summary>
	/// Handler for the Wugushi skill WugongGu.
	/// </summary>
	[SkillHandler(SkillId.Wugushi_WugongGu)]
	public class WugongGu : ITargetSkillHandler
	{
		/// <summary>
		/// Handles skill, damages targets.
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
			caster.Components.Get<CombatComponent>().SetAttackState(true);
			var characterCaster = caster as Character;

			if (target == null)
			{
				Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, caster.Position, caster.Position.GetDirection(caster.Position), Position.Zero);
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			if (characterCaster != null)
			{
				var direction = caster.Position.GetDirection(target.Position);
				characterCaster.Rotate(direction);
			}
			
			var damageDelay = TimeSpan.FromMilliseconds(200);

			var skillHitResult = SCR_SkillHit(caster, target, skill);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, TimeSpan.Zero);
			skillHit.ForceId = ForceId.GetNew();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, target.Handle, caster.Position, caster.Position.GetDirection(target.Position), Position.Zero);
			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHit);
			Send.ZC_NORMAL.Skill_E3(characterCaster, target, "STAGE_1");

			target.Components.Get<BuffComponent>().Start(BuffId.Virus_Debuff, skill.Level, skillHitResult.Damage, TimeSpan.FromSeconds(10), caster);
		}
	}
}
