using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Concentrate Buff.  This buff is mainly handled through calc_combat,
	/// but we have to track the initial number of hits that it lasts for.
	/// </summary>
	[BuffHandler(BuffId.Concentrate_Buff)]
	public class Concentrate : BuffHandler
	{
		private const string HitsVarName = "Melia.HitsLeft";

		public override void OnStart(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			buff.Vars.SetFloat(HitsVarName, skillLevel * 2);
		}
	}
}
