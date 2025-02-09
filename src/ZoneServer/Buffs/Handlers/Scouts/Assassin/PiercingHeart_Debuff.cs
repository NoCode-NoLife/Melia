using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Scout.Assassin
{
	/// <summary>
	/// Handle for the Piercing Heart debuff, which prevents healing
	/// </summary>
	[BuffHandler(BuffId.PiercingHeart_Debuff)]
	public class PiercingHeart_Debuff : BuffHandler
	{
		/// <summary>
		/// Eliminates all healing if the entity has the piercing heart debuff.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="hpAmount"></param>
		/// <returns></returns>
		public static bool TryApply(ICombatEntity entity, ref float hpAmount)
		{
			if (!entity.TryGetBuff(BuffId.PiercingHeart_Debuff, out var buff))
				return false;

			hpAmount = 0;

			return true;
		}
	}
}
