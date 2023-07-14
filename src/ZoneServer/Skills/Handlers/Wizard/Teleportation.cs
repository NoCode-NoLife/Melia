using System;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Skills.Handlers.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Teleportation.
	/// </summary>
	[SkillHandler(SkillId.Wizard_Teleportation)]
	public class WizardTeleportation : IGroundSkillHandler
	{
		private const float TeleportationDistance = 100;
		private static readonly TimeSpan ReUseTime = TimeSpan.FromSeconds(2);

		/// <summary>
		/// Handles skill, teleporting caster.
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

			// Increase max overheat if "Teleportation: Return" is active,
			// which allows gives the user a brief window in which they
			// can teleport back to the position they teleported from.
			var overheatMaxCount = 1;
			if (caster.Components.Get<AbilityComponent>().IsActive(AbilityId.Wizard30))
				overheatMaxCount = 2;

			skill.IncreaseOverheat(overheatMaxCount);
			caster.SetAttackState(true);

			caster.StartBuff(BuffId.Teleportation_Buff, 0, 0, TimeSpan.FromSeconds(1), caster);
			caster.StartBuff(BuffId.Skill_NoDamage_Buff, 0, 0, TimeSpan.FromSeconds(1), caster);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			var now = DateTime.Now;
			var usedRecently = false;

			if (skill.Vars.TryGet("Melia.LastUse", out DateTime lastUse))
				usedRecently = (DateTime.Now - lastUse) < ReUseTime;

			Position targetPos;
			if (usedRecently && skill.Vars.TryGet<Position>("Melia.LastPos", out var lastPos))
			{
				targetPos = lastPos;
			}
			else
			{
				targetPos = caster.Position.GetRelative(caster.Direction, TeleportationDistance);
				targetPos = caster.Map.Ground.GetLastValidPosition(caster.Position, targetPos);
			}

			skill.Vars.Set("Melia.LastPos", caster.Position);
			skill.Vars.Set("Melia.LastUse", now);

			caster.Position = targetPos;
			Send.ZC_SET_POS(caster, targetPos);
		}
	}
}
