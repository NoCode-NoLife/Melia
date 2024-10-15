//--- Melia Script ----------------------------------------------------------
// Server Configuration
//--- Description -----------------------------------------------------------
// Gives client read access to the world configuration.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Scripting;

[Priority(100)]
public class ServerConfClientScript : ClientScript
{
	protected override void Load()
	{
		this.LoadAllScripts();
	}

	protected override void Ready(Character character)
	{
		this.SendAllScripts(character);
		this.SendOptionsTable(character);
	}

	private void SendOptionsTable(Character character)
	{
		var table = new LuaTable();

		foreach (var option in ZoneServer.Instance.Conf.World.GetOptions())
		{
			table.Insert(option.Key, option.Value);

			if (table.SerializedSize > 1900)
			{
				this.SendRawLuaScript(character, "Melia.Conf.Init(" + table.Serialize() + ")");
				table.Clear();
			}
		}

		if (table.Count != 0)
			this.SendRawLuaScript(character, "Melia.Conf.Init(" + table.Serialize() + ")");
	}
}
