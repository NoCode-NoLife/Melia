using System;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Skills.Handlers.Enchanter
{
	/// <summary>
	/// Handler for the Enchanter skill Agility.
	/// </summary>
	[SkillHandler(SkillId.Enchanter_Agility)]
	public class Agility : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, applying a buff to the caster.
		/// </summary>
		/// <param name="skill"></param>
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

			skill.IncreaseOverheat();
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			originPos = caster.Position;

			var duration = TimeSpan.FromMinutes(30);
			caster.Components.Get<BuffComponent>().Start(BuffId.Agility_Buff, skill.Level, 0, duration, caster);

			// TODO: Apply this buff on party members and pets as well

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, originPos, null);
		}
	}
}
