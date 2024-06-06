using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handle for the Swashbuckling Debuff
	/// Note that the ingame tooltip implies that this reduction in Block / Dodge rate is only to attacks from
	/// the caster, which is currently not the case
	/// The ingame tooltip also says that this grants a movement speed buff, but testing seems to show no increase
	/// </summary>
	[BuffHandler(BuffId.SwashBuckling_Debuff)]
	public class SwashBuckling_Debuff : BuffHandler
	{
		private const string VarNameBlock = "Melia.BlkRatePenalty";
		private const float BlockReductionPerLevel = 0.06f; // 6%

		private const string VarNameDodge = "Melia.DrRatePenalty";
		private const float DodgeReductionPerLevel = 0.06f; // 6%

		public override void OnStart(Buff buff)
		{
			var blockLoss = this.GetBlockPenalty(buff) * buff.Target.Properties.GetFloat(PropertyName.BlockRate);
			buff.Vars.SetFloat(VarNameBlock, blockLoss);

			buff.Target.Properties.Modify(PropertyName.BLK_BM, -blockLoss);

			var dodgeLoss = this.GetBlockPenalty(buff) * buff.Target.Properties.GetFloat(PropertyName.DodgeRate);
			buff.Vars.SetFloat(VarNameDodge, dodgeLoss);

			buff.Target.Properties.Modify(PropertyName.DR_BM, -dodgeLoss);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(VarNameBlock, out var blockLoss))
				buff.Target.Properties.Modify(PropertyName.BLK_BM, blockLoss);

			if (buff.Vars.TryGetFloat(VarNameDodge, out var dodgeLoss))
				buff.Target.Properties.Modify(PropertyName.DR_BM, dodgeLoss);
		}

		private float GetBlockPenalty(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return skillLevel * BlockReductionPerLevel;
		}

		private float GetDodgePenalty(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return skillLevel * DodgeReductionPerLevel;
		}
	}
}
