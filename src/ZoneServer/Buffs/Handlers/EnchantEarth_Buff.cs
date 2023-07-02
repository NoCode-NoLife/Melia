using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Enchant Earth Buff, which increases the target's block penetration
	/// </summary>
	[BuffHandler(BuffId.EnchantEarth_Buff)]
	public class EnchantEarth_Buff : BuffHandler
	{
		private float blockPenetrationBonus = 0;

		public override void OnStart(Buff buff)
		{
			var target = buff.Target as Character;
			var SCR_Get_Character_MAXPATK = ScriptableFunctions.Character.Get("SCR_Get_Character_MAXPATK");

			if (target != null)
			{
				var caster = buff.Caster as Character;

				// Apply penality when the CASTER Max Physical Attack is lower than the TARGET Max Physical Attack
				// TODO: Find out the exacly value of the penality (We are applying 50%)
				var penalityValue = SCR_Get_Character_MAXPATK(caster) < SCR_Get_Character_MAXPATK(target) ? 0.5f : 1f;

				// Based on in game values (tooltip)
				blockPenetrationBonus = (8f + (1.6f * buff.Data.Level)) * penalityValue;

				// TODO: Apply "Enchant Earth: Enchant" (passive adquire through attribute points)

				buff.Target.Properties.Modify(PropertyName.BLK_BREAK_BM, blockPenetrationBonus);
			}
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target as Character;

			if (target != null)
			{
				buff.Target.Properties.Modify(PropertyName.BLK_BREAK_BM, -blockPenetrationBonus);
			}
		}
	}
}
