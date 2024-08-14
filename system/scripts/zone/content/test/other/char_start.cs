//--- Melia Script ----------------------------------------------------------
// Custom Character Start
//--- Description -----------------------------------------------------------
// Moves characters to a different starting area on their first login if
// they aren't there yet.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Shared.World;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class CustomCharacterStartScript : GeneralScript
{
	[On("PlayerGameReady")]
	public void OnPlayerGameReady(object sender, PlayerGameReadyEventArgs e)
	{
		var character = e.Character;

		//if (character.Variables.Perm.ActivateOnce("Melia.CustomStart"))
		//{
		//	if (character.Map.Name != "opening_zone_1")
		//	{
		//		character.Warp("opening_zone_1", new Position(-1961, 176, -4011));
		//		e.CancelHandling = true;
		//	}
		//}
	}
}
