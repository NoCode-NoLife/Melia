//--- Melia Script ----------------------------------------------------------
// Ability Point Cost
//--- Description -----------------------------------------------------------
// Modifies the client's ability point cost function to return the server's
// configured value.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class AbilityPointCostClientScript : ClientScript
{
	public override void Load()
	{
		this.LoadAllScripts();
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		var exchangeRate = ZoneServer.Instance.Conf.World.AbilityPointCost;

		this.SendRawLuaScript(e.Character, $@"
			Melia.Override(""GET_SILVER_BY_ONE_ABILITY_POINT_CALC"", function(original)
				return {exchangeRate};
			end)
		");
	}
}
