//--- Melia Script ----------------------------------------------------------
// World Map
//--- Description -----------------------------------------------------------
// Makes changes to the world and mini maps, such as removing the level
// ranges, to accomodate customization better.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class WorldMapClientScript : ClientScript
{
	public override void Load()
	{
		this.LoadAllScripts();
		this.LoadIesMods();
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		this.SendAllScripts(e.Character);
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
}
