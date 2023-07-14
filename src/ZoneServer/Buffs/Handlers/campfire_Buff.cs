using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for the Campfire Buff (aka Bonfire), which increases the
	/// target's HP, SP, and Stamina recovery.
	/// </summary>
	[BuffHandler(BuffId.campfire_Buff)]
	public class Campfire_Buff : BuffHandler
	{
		private const int StaminaRecoveryBonus = 600;
		private const float HpSpRecoveryRate = 0.10f;

		public override void OnStart(Buff buff)
		{
			buff.Target.Properties.Modify(PropertyName.RSta_BM, StaminaRecoveryBonus);
		}

		public override void OnEnd(Buff buff)
		{
			buff.Target.Properties.Modify(PropertyName.RSta_BM, -StaminaRecoveryBonus);
		}

		public override void WhileActive(Buff buff)
		{
			var target = buff.Target;

			var maxHp = target.Properties.GetFloat(PropertyName.MHP);
			var maxSp = target.Properties.GetFloat(PropertyName.MSP);

			if (target.Hp < maxHp)
				target.Heal(maxHp * HpSpRecoveryRate, 0);

			if (target is Character character && character.Sp < maxSp)
				character.ModifySp(maxSp * HpSpRecoveryRate);
		}
	}
}
