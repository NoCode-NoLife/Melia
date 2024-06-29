using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Restrain Buff, which reduces maximum HP
	/// </summary>
	[BuffHandler(BuffId.Restrain_Buff)]
	public class Restrain : BuffHandler
	{
		private const string VarName = "Melia.MaxHPPenalty";
		private const float MaxHPDropBase = 50f;
		private const float MaxHPDropPerLevel = 28f;

		public override void OnStart(Buff buff)
		{
			var penalty = this.GetMaxHPPenalty(buff);
			buff.Vars.SetFloat(VarName, penalty);

			buff.Target.Properties.Modify(PropertyName.MHP_BM, -penalty);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(VarName, out var penalty))
				buff.Target.Properties.Modify(PropertyName.MHP_BM, penalty);
		}

		private float GetMaxHPPenalty(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return MaxHPDropBase + skillLevel * MaxHPDropPerLevel;
		}
	}
}
