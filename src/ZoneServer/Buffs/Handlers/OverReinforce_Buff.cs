using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Over Reinforce Buff, which increases the target's physical and magic attack
	/// </summary>
	[BuffHandler(BuffId.OverReinforce_Buff)]
	public class OverReinforce_Buff : BuffHandler
	{
		private float attackBonus = 0;

		public override void OnStart(Buff buff)
		{
			var target = buff.Target as Character;

			if (target != null)
			{
				// Based on in game values (tooltip)
				attackBonus = 1308 + (349 * buff.Data.Level);

				buff.Target.Properties.Modify(PropertyName.MATK_BM, attackBonus);
				buff.Target.Properties.Modify(PropertyName.PATK_BM, attackBonus);
			}
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target as Character;

			if (target != null)
			{
				buff.Target.Properties.Modify(PropertyName.MATK_BM, -attackBonus);
				buff.Target.Properties.Modify(PropertyName.PATK_BM, -attackBonus);
			}
		}
	}
}
