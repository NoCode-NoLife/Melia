using System;
using Melia.Zone.Events.Arguments;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.World.Quests.Objectives
{
	/// <summary>
	/// Objective to collect a certain amount of an item.
	/// </summary>
	public class CollectItemObjective : QuestObjective
	{
		/// <summary>
		/// Returns the id of the item that needs to be collected.
		/// </summary>
		public int ItemId { get; }

		/// <summary>
		/// Creates a quest objective to gather a certain amount of the
		/// given type of item.
		/// </summary>
		/// <param name="itemId"></param>
		/// <param name="amount"></param>
		public CollectItemObjective(int itemId, int amount)
		{
			this.ItemId = itemId;
			this.TargetCount = amount;
		}

		/// <summary>
		/// Sets up event subscriptions.
		/// </summary>
		public override void Load()
		{
			ZoneServer.Instance.ServerEvents.PlayerAddedItem.Subscribe(OnPlayerAddedOrRemovedItem);
			ZoneServer.Instance.ServerEvents.PlayerRemovedItem.Subscribe(OnPlayerAddedOrRemovedItem);
		}

		/// <summary>
		/// Cleans up event subscriptions.
		/// </summary>
		public override void Unload()
		{
			ZoneServer.Instance.ServerEvents.PlayerAddedItem.Unsubscribe(OnPlayerAddedOrRemovedItem);
			ZoneServer.Instance.ServerEvents.PlayerRemovedItem.Unsubscribe(OnPlayerAddedOrRemovedItem);
		}

		/// <summary>
		/// Called when a player gets and starts a quest with this objective.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="newQuest"></param>
		public override void OnStart(Character character, Quest newQuest)
		{
			newQuest.UpdateObjectives<CollectItemObjective>((quest, objective, progress) =>
			{
				progress.Count = Math.Min(objective.TargetCount, character.Inventory.CountItem(objective.ItemId));
				progress.Done = progress.Count >= objective.TargetCount;
			});
		}

		/// <summary>
		/// Called when a player got or lost an item.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private static void OnPlayerAddedOrRemovedItem(object sender, PlayerItemEventArgs args)
		{
			var character = args.Character;
			var itemId = args.ItemId;

			character.Quests.UpdateObjectives<CollectItemObjective>((quest, objective, progress) =>
			{
				if (objective.ItemId == itemId && !progress.Done)
				{
					progress.Count = Math.Min(objective.TargetCount, character.Inventory.CountItem(objective.ItemId));
					progress.Done = progress.Count >= objective.TargetCount;
				}
			});
		}
	}
}
