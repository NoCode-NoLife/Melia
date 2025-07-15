//--- Melia Script ----------------------------------------------------------
// Ability Point Cost
//--- Description -----------------------------------------------------------
// Modifies the client's ability point cost function to return the server's
// configured value.
//---------------------------------------------------------------------------

using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;

public class AbilityPointCostClientScript : ClientScript
{
	protected override void Ready(Character character)
	{
		var exchangeRate = ZoneServer.Instance.Conf.World.AbilityPointCost;

		this.SendRawLuaScript(character, $@"
			Melia.Override(""GET_SILVER_BY_ONE_ABILITY_POINT_CALC"", function(original)
				return {exchangeRate};
			end)
		");
	}
}
