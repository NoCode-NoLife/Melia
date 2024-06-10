using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Lethargy main debuff that reduces a target's attack
	/// and evasion properties.
	/// </summary>
	[BuffHandler(BuffId.Lethargy_Debuff)]
	public class Lethargy_Debuff : BuffHandler
	{
		private const string PAtkVarName = "Melia.PAtkDebuff";
		private const string MAtkVarName = "Melia.MAtkDebuff";
		private const string DRVarName = "Melia.DRDebuff";
		private const float AtkReductionRatePerLevel = 2;
		private const float EvasionReductionRatePerLevel = 1;

		public override void OnStart(Buff buff)
		{
			// We have to reduce PATK_BM and MATK_BM by a percentage of
			// their min/max values, but I'm not sure how the reference
			// values are supposed to be calculated, so we'll use the
			// average for now.
			var minPAtk = buff.Target.Properties.GetFloat(PropertyName.MINPATK);
			var maxPAtk = buff.Target.Properties.GetFloat(PropertyName.MAXPATK);
			var patk = (minPAtk + maxPAtk) / 2;

			var minMAtk = buff.Target.Properties.GetFloat(PropertyName.MINMATK);
			var maxMAtk = buff.Target.Properties.GetFloat(PropertyName.MAXMATK);
			var matk = (minMAtk + maxMAtk) / 2;

			var dr = buff.Target.Properties.GetFloat(PropertyName.DR);

			var atkRate = buff.NumArg1 * AtkReductionRatePerLevel;
			var drRate = buff.NumArg1 * EvasionReductionRatePerLevel;

			var patkDebuff = patk * (atkRate / 100f);
			var matkDebuff = matk * (atkRate / 100f);
			var drDebuff = dr * (drRate / 100f);

			buff.Vars.SetFloat(PAtkVarName, patkDebuff);
			buff.Vars.SetFloat(MAtkVarName, matkDebuff);
			buff.Vars.SetFloat(DRVarName, drDebuff);

			buff.Target.Properties.Modify(PropertyName.PATK_BM, -patkDebuff);
			buff.Target.Properties.Modify(PropertyName.MATK_BM, -matkDebuff);
			buff.Target.Properties.Modify(PropertyName.DR_BM, -drDebuff);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(PAtkVarName, out var patkDebuff))
				buff.Target.Properties.Modify(PropertyName.PATK_BM, patkDebuff);

			if (buff.Vars.TryGetFloat(MAtkVarName, out var matkDebuff))
				buff.Target.Properties.Modify(PropertyName.MATK_BM, matkDebuff);

			if (buff.Vars.TryGetFloat(DRVarName, out var drDebuff))
				buff.Target.Properties.Modify(PropertyName.DR_BM, drDebuff);
		}
	}
}
