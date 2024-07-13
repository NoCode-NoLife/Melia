using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Skills.Handlers.Scout.Assassin
{
	/// <summary>
	/// Handler for the Assassin skill Hasisas.
	/// </summary>
	[SkillHandler(SkillId.Assassin_Hasisas)]
	public class Assassin_Hasisas : IGroundSkillHandler
	{
		private const int HasisasPotionId = 647010;
		private static readonly TimeSpan BuffDuration = TimeSpan.FromMinutes(30);

		/// <summary>
		/// Handles skill, applying the buff to the caster.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			if (!this.UsePotion(caster))
			{
				caster.ServerMessage(Localization.Get("You need a Hasisas Potion."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			caster.StartBuff(BuffId.Hasisas_Buff, skill.Level, 0, BuffDuration, caster);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, null);
		}

		/// <summary>
		/// Uses one Hasisas Potion if applicable. Returns false if consumption
		/// failed and the skill should not be used.
		/// </summary>
		/// <param name="caster"></param>
		/// <returns></returns>
		private bool UsePotion(ICombatEntity caster)
		{
			if (Feature.IsEnabled("HasisasNoPotion"))
				return true;

			if (caster.Components.TryGet<InventoryComponent>(out var inventory))
			{
				var removedCount = inventory.Remove(HasisasPotionId, 1, InventoryItemRemoveMsg.Used);
				if (removedCount == 0)
					return false;
			}

			return true;
		}
	}
}
