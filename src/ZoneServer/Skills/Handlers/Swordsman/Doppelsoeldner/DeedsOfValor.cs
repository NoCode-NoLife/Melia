using System;
using Melia.Shared.L10N;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Skills.Handlers.Swordsman.Doppelsoeldner
{
	/// <summary>
	/// Handler for the Doppelsoeldner skill Deeds of Valor.
	/// </summary>
	[SkillHandler(SkillId.Doppelsoeldner_DeedsOfValor)]
	public class DeedsOfValor : ISelfSkillHandler
	{
		public const float baseDamageMultiplier = 1.15f;  // 15% damage bonus
		public const float damageMultiplierPerLevel = 0.01f;  // 1% damage bonus per level

		/// <summary>
		/// Handles skill, applying the buff to the caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Direction dir)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			var target = caster;

			var duration = TimeSpan.FromMinutes(30);
			target.StartBuff(BuffId.DeedsOfValor, skill.Level, baseDamageMultiplier + damageMultiplierPerLevel * skill.Level, duration, caster);

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, target, null);
		}
	}
}
