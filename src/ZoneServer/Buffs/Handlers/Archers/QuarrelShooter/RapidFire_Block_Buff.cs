using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.QuarrelShooter
{
	/// <summary>
	/// Buff handler for Rapidfire Block Buff, which grants
	/// extra block.
	/// </summary>
	[BuffHandler(BuffId.RapidFire_Block_Buff)]
	public class RapidFire_Block_Buff : BuffHandler
	{
		private const float BlkBuffRate = 0.2f;

		/// <summary>
		/// Starts buff, increasing Block
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = buff.Target;

			var bonusBlk = target.Properties.GetFloat(PropertyName.BLK) * BlkBuffRate;

			AddPropertyModifier(buff, buff.Target, PropertyName.BLK_BM, bonusBlk);
		}

		/// <summary>
		/// Ends the buff, resetting Block.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.BLK_BM);
		}
	}
}
