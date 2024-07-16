using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers.Scout.Assassin
{
	/// <summary>
	/// Handle for the Hasisas Buff, which increases the target's Attack speed and Crit damage
	/// </summary>
	[BuffHandler(BuffId.Hasisas_Buff)]
	public class Hasisas_Buff : BuffHandler
	{
		private const float AspdBonusBase = 155;
		private const float AspdBonusPerLevel = 20;
		private const float CritBonusBase = 3f;
		private const float CritBonusPerLevel = 1.5f;
		private const float HpLossRate = 0.01f;

		public override void OnStart(Buff buff)
		{
			var aspdBonus = this.GetAspdBonus(buff);
			var critBonus = this.GetCritBonus(buff);

			AddPropertyModifier(buff, buff.Target, PropertyName.ASPD_BM, aspdBonus);
			AddPropertyModifier(buff, buff.Target, PropertyName.CRTATK_BM, critBonus);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.ASPD_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.CRTATK_BM);
		}

		public override void WhileActive(Buff buff)
		{
			this.ReduceHp(buff);
			this.UpdateCritBonus(buff);
		}

		/// <summary>
		/// Reduces tha buff target's HP.
		/// </summary>
		/// <param name="buff"></param>
		private void ReduceHp(Buff buff)
		{
			if (Feature.IsEnabled("HasisasNoHpLoss"))
				return;

			// The description stats an HP loss of 1% per 10 seconds,
			// which matches the buff's update time. Should a user
			// change it, the description would no longer be accurate,
			// but we'll leave it like this for now because we have
			// no great way of keeping track of passage of time.
			// TODO: Pass time passed into WhileActive.

			var maxHp = buff.Target.Properties.GetFloat(PropertyName.MHP);
			var loss = maxHp * HpLossRate;

			// TODO: We probably don't need handling for monsters,
			//   but this should still get updated once we have a
			//   general HP modifier. Or perhaps it should be a
			//   damage hit? TBD.
			if (buff.Target is Character character)
				character.ModifyHp(-loss);
		}

		/// <summary>
		/// Updates the crit bonus based on the amount of HP lost.
		/// </summary>
		/// <param name="buff"></param>
		private void UpdateCritBonus(Buff buff)
		{
			if (Feature.IsEnabled("HasisasNoHpCritBonus"))
				return;

			UpdatePropertyModifier(buff, buff.Target, PropertyName.CRTATK_BM, this.GetCritBonus(buff));
		}

		/// <summary>
		/// Returns the ASPD bonus to use.
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetAspdBonus(Buff buff)
		{
			return AspdBonusBase + AspdBonusPerLevel * buff.NumArg1;
		}

		/// <summary>
		/// Returns the crit bonus to use.
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetCritBonus(Buff buff)
		{
			if (Feature.IsEnabled("HasisasNoHpCritBonus"))
				return CritBonusBase + CritBonusPerLevel * buff.NumArg1;

			var target = buff.Target;
			var maxHp = target.Properties.GetFloat(PropertyName.MHP);
			var hp = target.Properties.GetFloat(PropertyName.HP);

			// The bonus is equal to the percentage of HP lost
			var bonus = (1f - (hp / maxHp)) * 100f;

			return bonus;
		}
	}
}
