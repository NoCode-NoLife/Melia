using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handle for the Swashbuckling Debuff
	/// </summary>
	[BuffHandler(BuffId.SwashBuckling_Debuff)]
	public class SwashBuckling_Debuff : BuffHandler
	{
		private const float BlockReductionPerLevel = 0.04f;
		private const float DodgeReductionPerLevel = 0.04f;

		public override void OnStart(Buff buff)
		{
			// The skill's description states that the block and dodge only applies
			// to attacks from the caster, but our current implementation applies
			// to all incoming damage.
			// 
			// It also says that this grants a movement speed buff, but testing
			// has shown none.

			var target = buff.Target;

			var blockLoss = this.GetBlockPenalty(buff);
			var dodgeLoss = this.GetDodgePenalty(buff);

			AddPropertyModifier(buff, target, PropertyName.BLK_BM, -blockLoss);
			AddPropertyModifier(buff, target, PropertyName.DR_BM, -dodgeLoss);
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;

			RemovePropertyModifier(buff, target, PropertyName.BLK_BM);
			RemovePropertyModifier(buff, target, PropertyName.DR_BM);
		}

		private float GetBlockPenalty(Buff buff)
		{
			var curVal = buff.Target.Properties.GetFloat(PropertyName.BLK);

			var skillLevel = buff.NumArg1;
			var reductionRate = BlockReductionPerLevel * skillLevel;

			var reduction = curVal * reductionRate;
			return reduction;
		}

		private float GetDodgePenalty(Buff buff)
		{
			var curVal = buff.Target.Properties.GetFloat(PropertyName.DR);

			var skillLevel = buff.NumArg1;
			var reductionRate = DodgeReductionPerLevel * skillLevel;

			var reduction = curVal * reductionRate;
			return reduction;
		}
	}
}
