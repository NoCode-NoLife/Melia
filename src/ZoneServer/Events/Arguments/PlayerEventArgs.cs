using System;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Events.Arguments
{
	/// <summary>
	/// Arguments for events related to a player character.
	/// </summary>
	/// <param name="character"></param>
	public class PlayerEventArgs(Character character) : EventArgs
	{
		/// <summary>
		/// Returns the character associated with the event.
		/// </summary>
		public Character Character { get; } = character;
	}

	/// <summary>
	/// Arguments for events related to a player character.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="message"></param>
	public class PlayerChatEventArgs(Character character, string message) : EventArgs
	{
		/// <summary>
		/// Returns the character associated with the event.
		/// </summary>
		public Character Character { get; } = character;

		/// <summary>
		/// Returns what the player said.
		/// </summary>
		public string Message { get; } = message;
	}

	/// <summary>
	/// Arguments for the PlayerSkillLevelChanged event..
	/// </summary>
	/// <param name="character"></param>
	/// <param name="skill"></param>
	public class PlayerSkillLevelChangedEventArgs(Character character, Skill skill) : EventArgs
	{
		/// <summary>
		/// Returns the character associated with the event.
		/// </summary>
		public Character Character { get; } = character;

		/// <summary>
		/// Returns the skill which's level changed.
		/// </summary>
		public Skill Skill { get; } = skill;
	}

	/// <summary>
	/// Arguments events related to players gaining or losing items.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="itemId"></param>
	/// <param name="amount"></param>
	public class PlayerItemEventArgs(Character character, int itemId, int amount) : EventArgs
	{
		/// <summary>
		/// Returns the character associated with the event.
		/// </summary>
		public Character Character { get; } = character;

		/// <summary>
		/// Returns the id of the relevant item.
		/// </summary>
		public int ItemId { get; } = itemId;

		/// <summary>
		/// Returns the item amount related to this event, such as the
		/// amount gained or lost.
		/// </summary>
		public int Amount { get; } = amount;
	}

	/// <summary>
	/// Arguments for the PlayerGameReady event.
	/// </summary>
	/// <param name="character"></param>
	public class PlayerGameReadyEventArgs(Character character) : EventArgs
	{
		/// <summary>
		/// Returns a reference to the character logging in.
		/// </summary>
		public Character Character { get; } = character;

		/// <summary>
		/// Gets or sets whether to continue the login process after
		/// the event.
		/// </summary>
		public bool CancelHandling { get; set; } = false;
	}

	/// <summary>
	/// Arguments for the PlayerDialog event.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="npc"></param>
	/// <param name="dialogTitle"></param>
	/// <param name="dialogText"></param>
	public class PlayerDialogEventArgs(Character character, Npc npc, string dialogTitle, string dialogText) : EventArgs
	{
		/// <summary>
		/// Returns a reference to the character.
		/// </summary>
		public Character Character { get; } = character;

		/// <summary>
		/// Returns a reference to the NPC associated with the dialog.
		/// </summary>
		public Npc Npc { get; } = npc;

		/// <summary>
		/// Returns the dialog title.
		/// </summary>
		public string DialogTitle { get; } = dialogTitle;

		/// <summary>
		/// Returns the dialog text.
		/// </summary>
		public string DialogText { get; } = dialogText;
	}
}
