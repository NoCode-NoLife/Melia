//--- Melia Script ----------------------------------------------------------
// Server Configuration
//--- Description -----------------------------------------------------------
// Gives client read access to the world configuration.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone;
using Melia.Zone.Events;
using Melia.Zone.Scripting;
using Yggdrasil.Scripting;

[Priority(100)]
public class ServerConfClientScript : ClientScript
{
	public override void Load()
	{
		this.LoadAllScripts();
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		this.SendAllScripts(e.Character);

		var table = new LuaTable();

		foreach (var option in ZoneServer.Instance.Conf.World.GetOptions())
		{
			table.Insert(option.Key, option.Value);

			if (table.SerializedSize > 1900)
			{
				this.SendRawLuaScript(e.Character, "Melia.Conf.Init(" + table.Serialize() + ")");
				table.Clear();
			}
		}

		if (table.Count != 0)
			this.SendRawLuaScript(e.Character, "Melia.Conf.Init(" + table.Serialize() + ")");
	}
}
