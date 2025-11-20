using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Zone.Events.Arguments;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Util;

namespace Melia.Zone.World.Quests.Modifiers
{
	/// <summary>
	/// A modifier that gives a chance to add drops to a monster.
	/// </summary>
	public class ItemDropModifier : QuestModifier
	{
		/// <summary>
		/// Returns the item id that a monster drops.
		/// </summary>
		public int ItemId { get; }

		/// <summary>
		/// Returns the amount of chance the monster has to drop an item.
		/// </summary>
		public float DropChance { get; }

		/// <summary>
		/// Returns the tags which monsters must match to qualify for this
		/// objective.
		/// </summary>
		public HashSet<int> MonsterIds { get; }

		public ItemDropModifier(int itemId, float dropChance, params int[] monsterIds)
		{
			this.ItemId = itemId;
			this.DropChance = dropChance;
			this.MonsterIds = new HashSet<int>(monsterIds);
		}

		public ItemDropModifier(int itemId, float dropChance, params string[] monsterIds)
		{
			this.ItemId = itemId;
			this.DropChance = dropChance;
			this.MonsterIds = new HashSet<int>(monsterIds.Length);

			for (var i = 0; i < monsterIds.Length; i++)
			{
				var monster = monsterIds[i];
				if (ZoneServer.Instance.Data.MonsterDb.TryFind(monster, out var data))
					this.MonsterIds.Add(data.Id);
			}
		}

		/// <summary>
		/// Sets up event subscriptions.
		/// </summary>
		public override void Load()
		{
			ZoneServer.Instance.ServerEvents.EntityKilled.Subscribe(this.OnEntityKilled);
		}

		/// <summary>
		/// Cleans up event subscriptions.
		/// </summary>
		public override void Unload()
		{
			ZoneServer.Instance.ServerEvents.EntityKilled.Unsubscribe(this.OnEntityKilled);
		}

		/// <summary>
		/// Called when a character dies.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnEntityKilled(object sender, CombatEventArgs args)
		{
			if (args.Target is not Mob monster)
				return;

			if (args.Attacker is not Character character)
				return;

			character.Quests.UpdateModifiers<ItemDropModifier>((quest, modifier, progress) =>
			{
				if (modifier.IsTarget(monster))
				{
					// Check drop chance
				var rnd = RandomProvider.Get();
				if (rnd.NextDouble() < modifier.DropChance)
				{
					// Add item directly to player's inventory
					character.Inventory.Add(modifier.ItemId, 1, InventoryAddType.PickUp);
				}
				}
			});
		}

		/// <summary>
		/// Returns true if the given monster is a target for this objective.
		/// </summary>
		/// <param name="monster"></param>
		/// <returns></returns>
		private bool IsTarget(IMonster monster)
		{
			return this.MonsterIds.Contains(monster.Id);
		}
	}
}
