//--- Melia Script ----------------------------------------------------------
// Campfire (Bonfire)
//--- Description -----------------------------------------------------------
// Handles the creation of campfires and the buff they give.
//---------------------------------------------------------------------------

using System;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;

public class CampfireActionScript : GeneralScript
{
	[ScriptableFunction("SCR_PUT_CAMPFIRE")]
	public CustomCommandResult SCR_PUT_CAMPFIRE(Character character, int numArg1, int numArg2, int numArg3)
	{
		var area = new Circle(character.Position, 350);
		var entities = character.Map.GetEntitiesIn(character, area);

		foreach (var entity in entities)
		{
			var mob = entity as Mob;
			if (mob != null && mob.Id == 46011)
			{
				character.ServerMessage(Localization.Get("There is already a Bonfire placed near by."));
				return CustomCommandResult.Okay;
			}
		}

		if (!character.Inventory.HasItem(645337))
		{
			character.ServerMessage(Localization.Get("You need a Bonfire Kit to start a Bonfire it."));
			return CustomCommandResult.Okay;
		}

		var item = character.Inventory.Remove(645337, 1, InventoryItemRemoveMsg.Used);
		this.BonFireSpawn(character);
		return CustomCommandResult.Okay;
	}

	private void BonFireSpawn(Character character)
	{
		var bonFire = new Mob(46011, MonsterType.NPC);
		var position = character.Position.GetRelative(character.Direction, 35);
		bonFire.Position = position;
		bonFire.Direction = character.Direction;

		character.Map.AddMonster(bonFire);
		Send.ZC_FACTION(character.Connection, bonFire, FactionType.Neutral);

		var cancellationTokenSource = new CancellationTokenSource();
		this.AddBuffToNearByPlayers(character, bonFire, cancellationTokenSource.Token);
		cancellationTokenSource.CancelAfter(TimeSpan.FromMinutes(5));
	}

	private async void AddBuffToNearByPlayers(Character character, Mob bonFire, CancellationToken cancellationToken)
	{
		while (!cancellationToken.IsCancellationRequested)
		{
			var area = new Circle(character.Position, 350);
			var characters = character.Map.GetCharactersIn(character, area);

			foreach (var otherCharacter in characters)
			{
				if (otherCharacter.IsSitting && !otherCharacter.Buffs.Has(BuffId.campfire_Buff))
				{
					otherCharacter.Buffs.Start(BuffId.campfire_Buff, 0, 0, TimeSpan.Zero, otherCharacter);
				}
			}

			if (character.IsSitting && !character.Buffs.Has(BuffId.campfire_Buff))
			{
				character.Buffs.Start(BuffId.campfire_Buff, 0, 0, TimeSpan.Zero, character);
			}

			await Task.Delay(TimeSpan.FromSeconds(1));
		}

		character.Map.RemoveMonster(bonFire);
	}
}
