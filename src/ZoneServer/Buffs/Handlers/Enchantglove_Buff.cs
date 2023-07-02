using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Enchant Glove Buff, which increases the target's accuracy (Hit Rate)
	/// </summary>
	[BuffHandler(BuffId.Enchantglove_Buff)]
	public class Enchantglove_Buff : BuffHandler
	{
		private float hitRateBonus = 0;

		public override void OnStart(Buff buff)
		{
			var target = buff.Target as Character;
			var SCR_Get_Character_MAXPATK = ScriptableFunctions.Character.Get("SCR_Get_Character_MAXPATK");

			// It is not applyed to characters without Gloves
			if (target != null && target.Inventory.GetEquip(EquipSlot.Gloves) != null)
			{
				var caster = buff.Caster as Character;

				// Apply penality when the CASTER Max Physical Attack is lower than the TARGET Max Physical Attack
				// TODO: Find out the exacly value of the penality (We are applying 50%)
				var penalityValue = SCR_Get_Character_MAXPATK(caster) < SCR_Get_Character_MAXPATK(target) ? 0.5f : 1f;

				// Based on in game values (tooltip)
				hitRateBonus = (6.3f + (1.2f * buff.Data.Level)) * penalityValue;

				// TODO: Apply "Enchant Gloves: Enchant" (passive adquire through attribute points)
				
				buff.Target.Properties.Modify(PropertyName.HR_BM, hitRateBonus);
			}
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target as Character;

			if (target != null)
			{
				buff.Target.Properties.Modify(PropertyName.HR_BM, -hitRateBonus);
			}
		}
	}
}
