//--- Melia Script ----------------------------------------------------------
// Kill Events
//--- Description -----------------------------------------------------------
// Events that occur when certain entites are killed.
//---------------------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.Scripting;
using Melia.Zone.Events.Arguments;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using static Melia.Shared.Util.TaskHelper;

public class KillEventsScript : GeneralScript
{
	[On("EntityKilled")]
	public void OnEntityKilled(object sender, CombatEventArgs args)
	{
		if (args.Target.Faction == FactionType.RootCrystal)
			this.OnRootCrystalKilled(args.Target, args.Attacker);
	}

	private void OnRootCrystalKilled(IActor target, ICombatEntity attacker)
	{
		attacker.StartBuff(BuffId.RootCrystalMoveSpeed, 3, 0, TimeSpan.FromMinutes(10), attacker);
		attacker.StartBuff(BuffId.RootCrystalCoolDown_BUFF, 0, 0, TimeSpan.FromMinutes(1), attacker);

		if (attacker is Character character)
			CallSafe(this.MonsterHealStamina(target, character, 100000));
	}

	private async Task MonsterHealStamina(IActor target, Character character, int staminaAmount)
	{
		await Task.Delay(200);

		character.Properties.Stamina += staminaAmount;

		// Officials don't seem to send ZC_STAMINA, but for some reason
		// the stamina doesn't update if we don't do that.
		Send.ZC_ACTION_PKS(character, target, 0, 2, 75);
		Send.ZC_MON_STAMINA(character, target, staminaAmount);
		Send.ZC_STAMINA(character, character.Properties.Stamina);

		await Task.Delay(700);

		Send.ZC_NORMAL.PlayEffect(character, "F_staup", 1, EffectLocation.Top);
	}
}
