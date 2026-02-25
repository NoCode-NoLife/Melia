using Melia.Zone.Events.Arguments;
using Yggdrasil.Events;

namespace Melia.Zone.Events
{
	/// <summary>
	/// Manager for events occurring on the server, such as players logging
	/// in or killing monsters.
	/// </summary>
	public class ServerEvents
	{
		/// <summary>
		/// Manager for dynamic events that can be added and removed at runtime.
		/// </summary>
		public readonly DynamicEventManager Dynamic = new();

		// Time Events
		//-------------------------------------------------------------------

		/// <summary>
		/// Raised on every heartbeat tick.
		/// </summary>
		public readonly Event<TimeEventArgs> WorldTick = new();

		/// <summary>
		/// Raised every full real-life second.
		/// </summary>
		public readonly Event<TimeEventArgs> SecondTick = new();

		/// <summary>
		/// Raised every full real-life minute.
		/// </summary>
		public readonly Event<TimeEventArgs> MinuteTick = new();

		/// <summary>
		/// Raised every full five real-life minutes.
		/// </summary>
		public readonly Event<TimeEventArgs> FiveMinutesTick = new();

		/// <summary>
		/// Raised every full fifteen real-life minutes.
		/// </summary>
		public readonly Event<TimeEventArgs> FifteenMinutesTick = new();

		/// <summary>
		/// Raised every full twenty real-life minutes.
		/// </summary>
		public readonly Event<TimeEventArgs> TwentyMinutesTick = new();

		/// <summary>
		/// Raised every full thirty real-life minutes.
		/// </summary>
		public readonly Event<TimeEventArgs> ThirtyMinutesTick = new();

		/// <summary>
		/// Raised every full real-life hour.
		/// </summary>
		public readonly Event<TimeEventArgs> HourTick = new();

		// Player Events
		//-------------------------------------------------------------------

		/// <summary>
		/// Raised when a player logged in.
		/// </summary>
		/// <remarks>
		/// This event is raised right after the login was confirmed and
		/// before any more packets are sent to the client or they are
		/// added to the world. This makes it a good time to make 
		/// modifications to the character, but packets sent to the
		/// client might not get handled as intended yet.
		/// </remarks>
		public readonly Event<PlayerEventArgs> PlayerLoggedIn = new();

		/// <summary>
		/// Raised after the player's client loaded the map and is ready
		/// to start the game.
		/// </summary>
		/// <remarks>
		/// This event is similar to PlayerReady and fires from the same
		/// packet handler, but instead of waiting until the character
		/// and all its data is fully initialized, it fires immediately,
		/// which allows for redirects, such as rerouting the character
		/// to a different map.
		/// 
		/// If the packet handling should be stopped after executing this
		/// event, set CancelHandling on the arguments to true.
		/// </remarks>
		public readonly Event<PlayerGameReadyEventArgs> PlayerGameReady = new();

		/// <summary>
		/// Raised when a player logged in completely.
		/// </summary>
		/// <remarks>
		/// This event is raised right after we start sending the client
		/// updates about the world, such as monsters and players moving
		/// around. At this point, the client is expected to be fully
		/// loaded and ready to receive whatever you throw at it.
		/// </remarks>
		public readonly Event<PlayerEventArgs> PlayerReady = new();

		/// <summary>
		/// Raised when a player gains a new job or circle.
		/// </summary>
		public readonly Event<PlayerEventArgs> PlayerAdvancedJob = new();

		/// <summary>
		/// Raised when a player says something in public chat.
		/// </summary>
		public readonly Event<PlayerChatEventArgs> PlayerChat = new();

		/// <summary>
		/// Raised when the level of a player's skill changed.
		/// </summary>
		public readonly Event<PlayerSkillLevelChangedEventArgs> PlayerSkillLevelChanged = new();

		/// <summary>
		/// Raised when a player gains new items, such as by picking them up
		/// or buying them.
		/// </summary>
		public readonly Event<PlayerItemEventArgs> PlayerAddedItem = new();

		/// <summary>
		/// Raised when a player loses items, such as by destroying or selling them.
		/// </summary>
		public readonly Event<PlayerItemEventArgs> PlayerRemovedItem = new();

		/// <summary>
		/// Raised when a dialog message is sent to a player.
		/// </summary>
		public readonly Event<PlayerDialogEventArgs> PlayerDialog = new();

		/// <summary>
		/// Raised when a player leaves a party.
		/// </summary>
		public readonly Event<PlayerEventArgs> PlayerLeftParty = new();

		// Combat Events
		//-------------------------------------------------------------------

		/// <summary>
		/// Raised when one entity kills another.
		/// </summary>
		public readonly Event<CombatEventArgs> EntityKilled = new();

		// Monster Events
		//-------------------------------------------------------------------

		/// <summary>
		/// Raised when a monster is about to disappear.
		/// </summary>
		/// <remarks>
		/// Raised regardless of why the monster disappears, be it
		/// because it died, its summoning time ran out, or it got
		/// bored of our antics.
		/// </remarks>
		public readonly Event<MonsterEventArgs> MonsterDisappears = new();
	}
}
