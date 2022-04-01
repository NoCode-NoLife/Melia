using System;
using Melia.Channel.Skills;
using Melia.Channel.World.Entities;

namespace Melia.Channel.World
{
	/// <summary>
	/// Holds public events.
	/// </summary>
	public class EventManager
	{
		//-------------------------------------------------------------------
		//  Time Events
		//-------------------------------------------------------------------

		/// <summary>
		/// Raised on every heartbeat tick.
		/// </summary>
		public event Action<DateTime> WorldTick;
		public void OnWorldTick(DateTime now) => WorldTick?.Invoke(now);

		/// <summary>
		/// Raised every full real-life second.
		/// </summary>
		public event Action<DateTime> SecondTick;
		public void OnSecondTick(DateTime now) => SecondTick?.Invoke(now);

		/// <summary>
		/// Raised every full real-life minute.
		/// </summary>
		public event Action<DateTime> MinuteTick;
		public void OnMinuteTick(DateTime now) => MinuteTick?.Invoke(now);

		/// <summary>
		/// Raised every full five real-life minutes.
		/// </summary>
		public event Action<DateTime> FiveMinutesTick;
		public void OnFiveMinutesTick(DateTime now) => FiveMinutesTick?.Invoke(now);

		/// <summary>
		/// Raised every full fifteen real-life minutes.
		/// </summary>
		public event Action<DateTime> FifteenMinutesTick;
		public void OnFifteenMinutesTick(DateTime now) => FifteenMinutesTick?.Invoke(now);

		/// <summary>
		/// Raised every full twenty real-life minutes.
		/// </summary>
		public event Action<DateTime> TwentyMinutesTick;
		public void OnTwentyMinutesTick(DateTime now) => TwentyMinutesTick?.Invoke(now);

		/// <summary>
		/// Raised every full thirty real-life minutes.
		/// </summary>
		public event Action<DateTime> ThirtyMinutesTick;
		public void OnThirtyMinutesTick(DateTime now) => ThirtyMinutesTick?.Invoke(now);

		/// <summary>
		/// Raised every full real-life hour.
		/// </summary>
		public event Action<DateTime> HourTick;
		public void OnHourTick(DateTime now) => HourTick?.Invoke(now);

		//-------------------------------------------------------------------
		//  Player Events
		//-------------------------------------------------------------------

		/// <summary>
		/// Raised a few seconds after a player logged in.
		/// </summary>
		public event Action<Character> PlayerLoggedIn;
		public void OnPlayerLoggedIn(Character entity) => PlayerLoggedIn?.Invoke(entity);

		/// <summary>
		/// Raised when a player logged out.
		/// </summary>
		public event Action<Character> PlayerLoggedOut;
		public void OnPlayerLoggedOut(Character entity) => PlayerLoggedOut?.Invoke(entity);

		/// <summary>
		/// Raised when a player enters a map.
		/// </summary>
		public event Action<Character> PlayerEntersMap;
		public void OnPlayerEntersMap(Character entity) => PlayerEntersMap?.Invoke(entity);

		/// <summary>
		/// Raised when a player leaves a map.
		/// </summary>
		public event Action<Character> PlayerExitsMap;
		public void OnPlayerExitsMap(Character entity) => PlayerExitsMap?.Invoke(entity);

		/// <summary>
		/// Raised when a player used an item.
		/// </summary>
		public event Action<Character, Item> PlayerUsedItem;
		public void OnPlayerUsedItem(Character character, Item item) => PlayerUsedItem?.Invoke(character, item);

		/// <summary>
		/// Raised when a player equipped an item.
		/// </summary>
		public event Action<Character, Item> PlayerEquipped;
		public void OnPlayerEquipped(Character character, Item item) => PlayerEquipped?.Invoke(character, item);

		/// <summary>
		/// Raised when a player unequipped an item.
		/// </summary>
		public event Action<Character, Item> PlayerUnequipped;
		public void OnPlayerUnequipped(Character character, Item item) => PlayerUnequipped?.Invoke(character, item);

		/// <summary>
		/// Raised when player completes a quest.
		/// </summary>
		public event Action<Character, int> PlayerCompletesQuest;
		public void OnPlayerCompletesQuest(Character character, int questId) => PlayerCompletesQuest?.Invoke(character, questId);

		/// <summary>
		/// Raised when the level of a player's skill changed.
		/// </summary>
		public event Action<Character, Skill> PlayerSkillLevelChanged;
		public void OnPlayerSkillLevelChanged(Character character, Skill skill) => PlayerSkillLevelChanged?.Invoke(character, skill);

		/// <summary>
		/// Raised when a player used skill.
		/// </summary>
		public event Action<Character, Skill> PlayerUsedSkill;
		public void OnPlayerUsedSkill(Character character, Skill skill) => PlayerUsedSkill?.Invoke(character, skill);

		/// <summary>
		/// Raised when a player attempts to pick up an item.
		/// </summary>
		/// <remarks>
		/// This event is raised before the item is actually picked up and
		/// added to the inventory, even before the server checks whether
		/// the player has enough space in their inventory.
		/// 
		/// One potential use case is to remove an item from its region
		/// and add it to the player in another form, such as picking up
		/// a Pon item and adding it to a variable instead of to the
		/// inventory.
		/// </remarks>
		public event Action<Character, ItemMonster, EventInfo> PlayerPickingUpItem;
		public EventInfo OnPlayerPickingUpItem(Character character, ItemMonster item)
		{
			var info = new EventInfo();
			PlayerPickingUpItem?.Invoke(character, item, info);

			return info;
		}

		/// <summary>
		/// Raised when a player attempts to drop an item.
		/// </summary>
		/// <remarks>
		/// This event is raised before the item is actually dropped and
		/// removed from the inventory.
		/// </remarks>
		public event Action<Character, Item, EventInfo> PlayerDroppingItem;
		public EventInfo OnPlayerDroppingItem(Character character, Item item)
		{
			var info = new EventInfo();
			PlayerDroppingItem?.Invoke(character, item, info);

			return info;
		}

		/// <summary>
		/// Raised when a player attempts to destroy an item.
		/// </summary>
		/// <remarks>
		/// This event is raised before the item is actually dropped and
		/// removed from the inventory.
		/// </remarks>
		public event Action<Character, Item, EventInfo> PlayerDestroyingItem;
		public EventInfo OnPlayerDestroyingItem(Character character, Item item)
		{
			var info = new EventInfo();
			PlayerDestroyingItem?.Invoke(character, item, info);

			return info;
		}

		//-------------------------------------------------------------------
		//  Entity Events
		//-------------------------------------------------------------------

		/// <summary>
		/// Raised when an entity is killed by something.
		/// </summary>
		public event Action<IEntity, IEntity> EntityKilled;
		public void OnEntityKilled(IEntity entity, IEntity killer) => EntityKilled?.Invoke(entity, killer);

		/// <summary>
		/// Raised when an entity is killed by a player or player related monster (companion/summon).
		/// </summary>
		public event Action<IEntity, IEntity> EntityKilledByPlayer;
		public void OnEntityKilledByPlayer(IEntity entity, IEntity killer) => EntityKilledByPlayer?.Invoke(entity, killer);
	}

	/// <summary>
	/// Provides properties that can be used to communicate information
	/// to event callers and subscribers.
	/// </summary>
	public class EventInfo
	{
		/// <summary>
		/// Gets or sets whether this event was handled, meaning that
		/// other subscribers can potentially skip the event.
		/// </summary>
		/// <remarks>
		/// This is information only and subscribers are still free to
		/// do whatever they want. Setting this to true doesn't stop
		/// the subscriber calls.
		/// </remarks>
		public bool Handled { get; set; }

		/// <summary>
		/// Gets or sets whether the execution of the event caller should
		/// be stopped after the event was raised.
		/// </summary>
		/// <remarks>
		/// The caller is free to continue execution even if this is set
		/// to true, but all events that do use this event argument
		/// should be taking this property into consideration.
		/// </remarks>
		public bool StopCaller { get; set; }
	}
}
