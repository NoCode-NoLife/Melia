using System.Reflection.Metadata;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Scout.Assassin
{
	/// <summary>
	/// Handle for the Hasisas Buff, which increases the target's Attack speed and Crit damage
	/// </summary>
	[BuffHandler(BuffId.Hasisas_Buff)]
	public class Hasisas : BuffHandler
	{
		private const string AspdVarName = "Melia.AttackSpeedBonus";
		private const string CritVarName = "Melia.CritDamageBonus";
		private const float AspdBonusBase = 155;
		private const float AspdBonusPerLevel = 20;
		private const float CritBonusBase = 3f;
		private const float CritBonusPerLevel = 1.5f;

		public override void OnStart(Buff buff)
		{
			var aspdBonus = AspdBonusBase + AspdBonusPerLevel * buff.NumArg1;
			buff.Vars.SetFloat(AspdVarName, aspdBonus);

			var critBonus = CritBonusBase + CritBonusPerLevel * buff.NumArg1;
			buff.Vars.SetFloat(CritVarName, critBonus);

			buff.Target.Properties.Modify(PropertyName.ASPD_BM, aspdBonus);
			buff.Target.Properties.Modify(PropertyName.CRTATK_BM, critBonus);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(AspdVarName, out var aspdBonus))
				buff.Target.Properties.Modify(PropertyName.ASPD_BM, -aspdBonus);

			if (buff.Vars.TryGetFloat(CritVarName, out var critBonus))
				buff.Target.Properties.Modify(PropertyName.CRTATK_BM, -critBonus);
		}
	}
}
