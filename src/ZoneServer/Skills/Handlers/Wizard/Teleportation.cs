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

	/// <summary>
	/// Handler for the Psychokino skill Teleportation.
	/// </summary>
	/// <remarks>
	/// Experimental and untested handler for the Psychokino version
	/// of the Teleportation skill that is no longer in use. The main
	/// difference to the Wizard Teleportation is that this one allows
	/// the caster to teleport back to their previous location if they
	/// use the skill again within a certain time frame.
	/// </remarks>
	[SkillHandler(SkillId.Psychokino_Teleportation)]
	public class PsychokinoTeleportation : IGroundSkillHandler
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

			var lastUse = skill.Vars.Get<DateTime>("Melia.LastUse", DateTime.Now);
			var usedRecently = (DateTime.Now - lastUse) < ReUseTime;
			var isSecondUse = usedRecently && skill.OverheatCounter >= 1;

			Position targetPos;
			if (isSecondUse && skill.Vars.TryGet<Position>("Melia.LastPos", out var lastPos))
			{
				targetPos = lastPos;
			}
			else
			{
				targetPos = caster.Position.GetRelative(caster.Direction, TeleportationDistance);
				if (!caster.Map.Ground.TryGetHeightAt(targetPos, out var height))
					return;

				targetPos.Y = height;
			}

			skill.Vars.Set("Melia.LastPos", caster.Position);

			caster.Position = targetPos;
			Send.ZC_SET_POS(caster, targetPos);
		}
	}
}
