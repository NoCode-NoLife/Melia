//--- Melia Script ----------------------------------------------------------
// Campfire (Bonfire)
//--- Description -----------------------------------------------------------
// Handles the creation of campfires and the buff they give.
//---------------------------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Zone.Scripting;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;

public class CampfireActionScript : GeneralScript
{
	private const int CampfireMonsterId = 46011;
	private const int FirewoodItemId = 645337;
	private const int AreaOfEffectSize = 150;
	private const int MinDistanceToFires = 1;
	private const int DistanceToCreator = 35;
	private readonly static TimeSpan CampfireDuration = TimeSpan.FromMinutes(5);
	private readonly static TimeSpan BuffApplyCheckDelay = TimeSpan.FromSeconds(1);

	[ScriptableFunction("SCR_PUT_CAMPFIRE")]
	public CustomCommandResult SCR_PUT_CAMPFIRE(Character character, int numArg1, int numArg2, int numArg3)
	{
		var area = new Circle(character.Position, MinDistanceToFires);
		var monsters = character.Map.GetActorsIn<Mob>(area);

		var anyCampfires = monsters.Any(a => a.Id == CampfireMonsterId);
		if (anyCampfires)
		{
			character.ServerMessage(Localization.Get("There is already a bonfire placed nearby."));
			return CustomCommandResult.Okay;
		}

		if (!character.Inventory.HasItem(FirewoodItemId))
		{
			character.ServerMessage(Localization.Get("You need a Firewood to build a bonfire."));
			return CustomCommandResult.Okay;
		}

		this.CreateCampfire(character);

		character.Inventory.Remove(FirewoodItemId, 1, InventoryItemRemoveMsg.Used);

		return CustomCommandResult.Okay;
	}

	private void CreateCampfire(Character character)
	{
		var position = character.Position.GetRelative(character.Direction, DistanceToCreator);

		var campfire = new Mob(CampfireMonsterId, MonsterType.NPC);
		campfire.Faction = FactionType.Neutral;
		campfire.Position = position;
		campfire.Direction = character.Direction;

		character.Map.AddMonster(campfire);

		this.ApplyBuff(character, campfire);
	}

	private async void ApplyBuff(Character creator, Mob bonfire)
	{
		var area = new Circle(creator.Position, AreaOfEffectSize);
		var endTime = DateTime.Now + CampfireDuration;

		while (DateTime.Now < endTime)
		{
			var characters = creator.Map.GetActorsIn<Character>(area);

			foreach (var character in characters)
			{
				if (character.IsSitting && !character.Buffs.Has(BuffId.campfire_Buff))
					character.Buffs.Start(BuffId.campfire_Buff, TimeSpan.Zero);
			}

			await Task.Delay(BuffApplyCheckDelay);
		}

		creator.Map.RemoveMonster(bonfire);
	}
}
