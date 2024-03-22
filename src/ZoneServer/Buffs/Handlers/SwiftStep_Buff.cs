using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Swift Step Buff, which increases the target's evasion.
	/// </summary>
	[BuffHandler(BuffId.SwiftStep_Buff)]
	public class SwiftStep_Buff : BuffHandler
	{
		private const string DrVarName = "Melia.DodgeRateBonus";
		private const string MovingShotVarName = "Melia.MovingShotBonus";
		private const float DodgeRateBonusPerLevel = 0.03f;
		private const float MovingShotBonusPerLevel = 0.2f;

		public override void OnStart(Buff buff)
		{
			var drBonus = this.GetDodgeRateBonus(buff);
			buff.Vars.SetFloat(DrVarName, drBonus);

			var movingShotBonus = this.GetMovingShotBonus(buff);
			buff.Vars.SetFloat(MovingShotVarName, movingShotBonus);

			buff.Target.Properties.Modify(PropertyName.DR_RATE_BM, drBonus);
			buff.Target.Properties.Modify(PropertyName.MovingShot_BM, movingShotBonus);

			if (buff.Target is Character character)
				Send.ZC_MOVE_SPEED(character);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(DrVarName, out var drBonus))
				buff.Target.Properties.Modify(PropertyName.DR_RATE_BM, -drBonus);

			if (buff.Vars.TryGetFloat(MovingShotVarName, out var movingShotBonus))
				buff.Target.Properties.Modify(PropertyName.MovingShot_BM, -movingShotBonus);

			if (buff.Target is Character character)
				Send.ZC_MOVE_SPEED(character);
		}

		private float GetDodgeRateBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return skillLevel * DodgeRateBonusPerLevel;
		}

		private float GetMovingShotBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return skillLevel * MovingShotBonusPerLevel;
		}
	}
}
