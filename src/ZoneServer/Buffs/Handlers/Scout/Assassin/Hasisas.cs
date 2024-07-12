using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors.Characters;

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
		private const float HpLossRate = 0.01f;

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

		public override void WhileActive(Buff buff)
		{
			if (Feature.IsEnabled("HasisasNoHpLoss"))
				return;

			var target = buff.Target;

			// The description stats an HP loss of 1% per 10 seconds,
			// which matches the buff's update time. Should a user
			// change it, the description would no longer be accurate,
			// but we'll leave it like this for now because we have
			// no great way of keeping track of passage of time.
			// TODO: Pass time passed into WhileActive.

			var maxHp = target.Properties.GetFloat(PropertyName.MHP);
			var loss = maxHp * HpLossRate;

			// TODO: We probably don't need handling for monsters,
			//   but this should still get updated once we have a
			//   general HP modifier. Or perhaps it should be a
			//   damage hit? TBD.
			if (target is Character character)
				character.ModifyHp(-loss);
		}
	}
}
