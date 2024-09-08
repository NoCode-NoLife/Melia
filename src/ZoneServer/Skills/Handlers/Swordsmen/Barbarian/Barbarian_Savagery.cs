using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handler for the Barbarian skill Savagery.
	/// </summary>
	[SkillHandler(SkillId.Barbarian_Savagery)]
	public class Barbarian_Savagery : ISelfSkillHandler
	{
		private const float BuffDuration = 50f;

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

			var criticalBonus = 0;
			if (caster.TryGetActiveAbilityLevel(AbilityId.Barbarian5, out var barbarian5Level))
				criticalBonus = 5 * barbarian5Level;

			target.StartBuff(BuffId.Savagery_Buff, skill.Level, criticalBonus, TimeSpan.FromSeconds(BuffDuration), caster);

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, target, null);
		}
	}
}
