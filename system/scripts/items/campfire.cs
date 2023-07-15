//--- Melia Script ----------------------------------------------------------
// Campfire (Bonfire)
//--- Description -----------------------------------------------------------
// Handles the creation of campfires and the buff they give.
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Scripting;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Maps;

public class CampfireActionScript : GeneralScript
{
	private const int CampfireMonsterId = 46011;
	private const int FirewoodItemId = 645337;
	private const int AreaOfEffectSize = 150;
	private const int MinDistanceToFires = 150;
	private const int MaxDistanceToCreator = 50;
	private readonly static TimeSpan CampfireDuration = TimeSpan.FromMinutes(5);
	private readonly static TimeSpan BuffApplyCheckDelay = TimeSpan.FromSeconds(1);

	[ScriptableFunction("SCR_PUT_CAMPFIRE")]
	public CustomCommandResult SCR_PUT_CAMPFIRE(Character character, int numArg1, int numArg2, int numArg3)
	{
		var campfirePos = new Position(numArg1, 0, numArg2);

		if (!character.Map.Ground.TryGetHeightAt(campfirePos, out var height))
		{
			character.ServerMessage(Localization.Get("You can't build a bonfire in this location."));
			return CustomCommandResult.Okay;
		}
		else
		{
			campfirePos.Y = height;
		}

		if (!character.Position.InRange2D(campfirePos, MaxDistanceToCreator))
		{
			character.ServerMessage(Localization.Get("This location is too far away."));
			return CustomCommandResult.Okay;
		}

		if (AnyCampfiresNearby(character.Map, campfirePos))
		{
			character.ServerMessage(Localization.Get("There is already a bonfire nearby."));
			return CustomCommandResult.Okay;
		}

		if (!character.Inventory.HasItem(FirewoodItemId))
		{
			character.ServerMessage(Localization.Get("You need Firewood to build a bonfire."));
			return CustomCommandResult.Okay;
		}

		CreateCampfire(character, campfirePos);

		character.Inventory.Remove(FirewoodItemId, 1, InventoryItemRemoveMsg.Used);

		return CustomCommandResult.Okay;
	}

	private static bool AnyCampfiresNearby(Map map, Position pos)
	{
		var area = new Circle(pos, MinDistanceToFires);
		var monsters = map.GetActorsIn<Mob>(area);

		var anyCampfires = monsters.Any(a => a.Id == CampfireMonsterId);
		return anyCampfires;
	}

	private static void CreateCampfire(Character creator, Position pos)
	{
		var campfire = new Mob(CampfireMonsterId, MonsterType.NPC);
		campfire.Faction = FactionType.Neutral;
		campfire.Position = pos;
		campfire.Direction = creator.Direction;
		campfire.AttachEffect("F_bg_fire003");

		creator.Map.AddMonster(campfire);

		ApplyBuff(creator, campfire);
	}

	private static async void ApplyBuff(Character creator, Mob campfire)
	{
		var area = new Circle(creator.Position, AreaOfEffectSize);
		var endTime = DateTime.Now + CampfireDuration;

		IList<Character> characters;

		while (DateTime.Now < endTime)
		{
			characters = creator.Map.GetActorsIn<Character>(area);

			foreach (var character in characters)
			{
				if (character.IsSitting && !character.Buffs.Has(BuffId.campfire_Buff))
					character.Buffs.Start(BuffId.campfire_Buff, TimeSpan.Zero);
			}

			await Task.Delay(BuffApplyCheckDelay);
		}

		// We logged the server sending a death packet before removing
		// the campfire, which presumably means that they're killing
		// it. The death packet doesn't appear to do anything visually
		// though, so it would just be more packets than we need.
		creator.Map.RemoveMonster(campfire);

		characters = creator.Map.GetActorsIn<Character>(area);
		foreach (var character in characters)
			character.Buffs.Stop(BuffId.campfire_Buff);
	}
}
