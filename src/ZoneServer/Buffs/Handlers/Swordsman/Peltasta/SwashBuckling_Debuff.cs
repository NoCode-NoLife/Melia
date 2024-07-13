using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handle for the Swashbuckling Debuff
	/// Note that the ingame tooltip implies that this reduction in Block / Dodge rate is only to attacks from
	/// the caster, though this implementation affects all incoming damage
	/// The ingame tooltip also says that this grants a movement speed buff, but testing shows no increase
	/// </summary>
	[BuffHandler(BuffId.SwashBuckling_Debuff)]
	public class SwashBuckling_Debuff : BuffHandler
	{
		private const float BlockReductionPerLevel = 0.06f;
		private const float DodgeReductionPerLevel = 0.06f;

		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			var blockLoss = this.GetBlockPenalty(buff) * buff.Target.Properties.GetFloat(PropertyName.BlockRate);
			AddPropertyModifier(buff, target, PropertyName.BLK_BM, -blockLoss);

			var dodgeLoss = this.GetDodgePenalty(buff) * buff.Target.Properties.GetFloat(PropertyName.DodgeRate);
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
