//--- Melia Script ----------------------------------------------------------
// World Map
//--- Description -----------------------------------------------------------
// Makes changes to the world and mini maps, such as removing the level
// ranges, to accomodate customization better. Also handles sending of
// default icons, such as for warps.
//---------------------------------------------------------------------------

using Melia.Shared.L10N;
using Melia.Shared.Scripting;
using Melia.Shared.World;
using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;

public class WorldMapClientScript : ClientScript
{
	protected override void Load()
	{
		this.LoadAllScripts();
		this.LoadIesMods();
	}

	protected override void Ready(Character character)
	{
		this.SendAllScripts(character);
		this.SendIcons(character);
	}

	private void LoadIesMods()
	{
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 1, "Name", "Klaipeda Area"); // Episode1
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 2, "Name", "Fedimian Area"); // Episode5
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 3, "Name", "Orsha Area"); // Episode13~15
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 101, "Name", "Area 4"); // Episode2
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 102, "Name", "Area 5"); // Episode3
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 103, "Name", "Area 6"); // Episode4
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 104, "Name", "Area 7"); // Episode6
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 105, "Name", "Area 8"); // Episode7-1
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 106, "Name", "Area 9"); // Episode7-2
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 107, "Name", "Area 10"); // Episode7-3
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 108, "Name", "Area 11"); // Episode8-1
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 109, "Name", "Area 12"); // Episode8-2
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 110, "Name", "Area 13"); // Episode9-1
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 111, "Name", "Area 14"); // Episode9-2
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 112, "Name", "Area 15"); // Episode10
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 113, "Name", "Waters"); // Episode11 1
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 114, "Name", "Layered Castle Wall"); // Episode11 2
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 115, "Name", "Maple Forest"); // Episode11 3
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 116, "Name", "Eternal Resting Place"); // Episode12
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 201, "Name", "Area 16"); // sub_episode1
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 202, "Name", "Coast"); // sub_episode2
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 203, "Name", "Suburb of Fallen City"); // sub_episode3
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 204, "Name", "Shore"); // sub_episode4
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 205, "Name", "White Tree Forest"); // sub_episode5
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 206, "Name", "Nicopolis"); // sub_episode6
		ZoneServer.Instance.IesMods.Add("worldmap2_data", 207, "Name", "Memorial"); // sub_episode7
	}

	private void SendIcons(Character character)
	{
		var warps = character.Map.GetMonsters(a => a is WarpMonster);
		var table = new LuaTable();

		foreach (WarpMonster warp in warps)
		{
			var tooltip = "";
			if (ZoneServer.Instance.Data.MapDb.TryFind(warp.WarpLocation.MapId, out var targetMapData))
				tooltip = string.Format(Localization.Get("To {0}"), Localization.Get(targetMapData.Name));

			var iconTable = CreateIconTable("minimap_portal", character.Map.ClassName, warp.Position, tooltip);
			table.Insert(iconTable);
		}

		this.SendRawLuaScript(character, "Melia.World.Icons.Load(" + table.Serialize() + ")");
	}

	private LuaTable CreateIconTable(string imageName, string mapClassName, Position pos, string tooltip)
	{
		var posTable = new LuaTable();
		posTable.Insert("X", pos.X);
		posTable.Insert("Y", pos.Y);
		posTable.Insert("Z", pos.Z);

		var iconTable = new LuaTable();
		iconTable.Insert("Image", imageName);
		iconTable.Insert("Tooltip", tooltip);
		iconTable.Insert("Map", mapClassName);
		iconTable.Insert("WorldPos", posTable);

		return iconTable;
	}
}
