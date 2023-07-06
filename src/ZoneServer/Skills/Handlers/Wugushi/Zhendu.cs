using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Skills.Handlers.Wugushi
{
	/// <summary>
	/// Handler for the Wugushi skill Zhendu.
	/// </summary>
	[SkillHandler(SkillId.Wugushi_Zhendu)]
	public class Zhendu : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, applying a buff to the caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		/// <exception cref="NotImplementedException"></exception>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Direction dir)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			var duration = TimeSpan.FromMinutes(30);
			caster.Components.Get<BuffComponent>().Start(BuffId.Zhendu_Buff, skill.Level, 0, duration, caster, skill);

			var character = caster as Character;

			if (character != null)
			{
				Send.ZC_NORMAL.Skill_59(character, caster.Handle, "", skill.Id, caster.Position, caster.Position.GetDirection(caster.Position));
			}

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, null);
		}
	}
}
