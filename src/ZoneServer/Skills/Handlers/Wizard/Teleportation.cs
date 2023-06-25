using System;
using System.Threading;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Skills.Handlers.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Teleportation.
	/// </summary>
	[SkillHandler(SkillId.Wizard_Teleportation)]
	public class WizardTeleportation : IGroundSkillHandler
	{
		private const float TeleportationDistance = 100;

		/// <summary>
		/// Handles skill, teleporting caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		/// <exception cref="NotImplementedException"></exception>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.Components.Get<CombatComponent>().SetAttackState(true);

			caster.Components.Get<BuffComponent>().Start(BuffId.Teleportation_Buff, 0, 0, TimeSpan.FromSeconds(1), caster);
			caster.Components.Get<BuffComponent>().Start(BuffId.Skill_NoDamage_Buff, 0, 0, TimeSpan.FromSeconds(1), caster);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			var targetPos = caster.Position.GetRelative(caster.Direction, TeleportationDistance);
			if (!caster.Map.Ground.TryGetHeightAt(targetPos, out var height))
				return;

			targetPos.Y = height;

			caster.Position = targetPos;
			Send.ZC_SET_POS(caster, targetPos);
		}
	}
}
