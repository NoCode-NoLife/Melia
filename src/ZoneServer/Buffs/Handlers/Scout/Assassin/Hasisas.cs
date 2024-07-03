using System.Reflection.Metadata;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Scout.Assassin
{
	/// <summary>
	/// Handle for the Bear Buff, which increases the target's defense.
	/// </summary>
	[BuffHandler(BuffId.Hasisas_Buff)]
	public class Hasisas : BuffHandler
	{
		private const string aspdVarName = "Melia.AttackSpeedBonus";
		private const string critVarName = "Melia.CritDamageBonus";
		private const float aspdBonusBase = 155;
		private const float aspdBonusPerLevel = 20;
		private const float critBonusBase = 3f;
		private const float critBonusPerLevel = 1.5f;

		public override void OnStart(Buff buff)
		{
			var aspdBonus = aspdBonusBase + aspdBonusPerLevel * buff.NumArg1;
			buff.Vars.SetFloat(aspdVarName, aspdBonus);

			var critBonus = critBonusBase + critBonusPerLevel * buff.NumArg1;
			buff.Vars.SetFloat(critVarName, critBonus);

			buff.Target.Properties.Modify(PropertyName.ASPD_BM, aspdBonus);
			buff.Target.Properties.Modify(PropertyName.CRTATK_BM, critBonus);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(aspdVarName, out var aspdBonus))
				buff.Target.Properties.Modify(PropertyName.ASPD_BM, -aspdBonus);

			if (buff.Vars.TryGetFloat(critVarName, out var critBonus))
				buff.Target.Properties.Modify(PropertyName.CRTATK_BM, -critBonus);
		}
	}
}
