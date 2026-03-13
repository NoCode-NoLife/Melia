using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Swordsman
{
	/// <summary>
	/// Handle for the Gung Ho, which increases the user's attack.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.GungHo)]
	public class GungHo : BuffHandler
	{
		private const float AtkRateBonusPerLevel = 0.02f;

		/// <summary>
		/// Called every time the buff is activated, including overbuff.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="activationType"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var bonus = this.GetAtkRateBonus(buff);

			AddPropertyModifier(buff, buff.Target, PropertyName.PATK_RATE_BM, bonus);
		}

		/// <summary>
		/// Called when the buff expires or is removed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.PATK_RATE_BM);
		}

		/// <summary>
		/// Returns the attack rate bonus provided by the buff.
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetAtkRateBonus(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return skillLevel * AtkRateBonusPerLevel;
		}
	}
}
