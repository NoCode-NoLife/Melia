using System;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Events
{
	/// <summary>
	/// Arguments for events related to a player character.
	/// </summary>
	public class PlayerEventArgs : EventArgs
	{
		/// <summary>
		/// Returns the character associated with the event.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="character"></param>
		public PlayerEventArgs(Character character)
		{
			this.Character = character;
		}
	}

	/// <summary>
	/// Arguments for events related to a player character.
	/// </summary>
	public class PlayerChatEventArgs : EventArgs
	{
		/// <summary>
		/// Returns the character associated with the event.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Returns what the player said.
		/// </summary>
		public string Message { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="message"></param>
		public PlayerChatEventArgs(Character character, string message)
		{
			this.Character = character;
			this.Message = message;
		}
	}

	/// <summary>
	/// Arguments for the PlayerSkillLevelChanged event..
	/// </summary>
	public class PlayerSkillLevelChangedEventArgs : EventArgs
	{
		/// <summary>
		/// Returns the character associated with the event.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Returns the skill which's level changed.
		/// </summary>
		public Skill Skill { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skill"></param>
		public PlayerSkillLevelChangedEventArgs(Character character, Skill skill)
		{
			this.Character = character;
			this.Skill = skill;
		}
	}

	/// <summary>
	/// Arguments events related to players gaining or losing items.
	/// </summary>
	public class PlayerItemEventArgs : EventArgs
	{
		/// <summary>
		/// Returns the character associated with the event.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Returns the id of the relevant item.
		/// </summary>
		public int ItemId { get; }

		/// <summary>
		/// Returns the item amount related to this event, such as the
		/// amount gained or lost.
		/// </summary>
		public int Amount { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="itemId"></param>
		/// <param name="amount"></param>
		public PlayerItemEventArgs(Character character, int itemId, int amount)
		{
			this.Character = character;
			this.ItemId = itemId;
			this.Amount = amount;
		}
	}

	/// <summary>
	/// Arguments for the PlayerGameReady event.
	/// </summary>
	public class PlayerGameReadyEventArgs : EventArgs
	{
		/// <summary>
		/// Returns a reference to the character logging in.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Gets or sets whether to continue the login process after
		/// the event.
		/// </summary>
		public bool CancelHandling { get; set; }

		/// <summary>
		/// Creates new event arguments.
		/// </summary>
		/// <param name="character"></param>
		public PlayerGameReadyEventArgs(Character character)
		{
			this.Character = character;
		}
	}

	/// <summary>
	/// Arguments for the PlayerDialog event.
	/// </summary>
	public class PlayerDialogEventArgs : EventArgs
	{
		/// <summary>
		/// Returns a reference to the character.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Returns a reference to the NPC associated with the dialog.
		/// </summary>
		public Npc Npc { get; }

		/// <summary>
		/// Returns the dialog title.
		/// </summary>
		public string DialogTitle { get; }

		/// <summary>
		/// Returns the dialog text.
		/// </summary>
		public string DialogText { get; }

		/// <summary>
		/// Creates new event arguments.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="npc"></param>
		/// <param name="dialogText"></param>
		public PlayerDialogEventArgs(Character character, Npc npc, string dialogTitle, string dialogText)
		{
			this.Character = character;
			this.Npc = npc;
			this.DialogTitle = dialogTitle;
			this.DialogText = dialogText;
		}
	}
}
