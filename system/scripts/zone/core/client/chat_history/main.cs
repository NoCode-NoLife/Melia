﻿//--- Melia Script ----------------------------------------------------------
// Chat History
//--- Description -----------------------------------------------------------
// Modifies chat frame to add a history of the previous sent messages
// that the player can cycle through with the up and down keys.
//--- Details ---------------------------------------------------------------
// The script sets up a timer on the chat input frame that fires every
// couple milliseconds and checks for keyboard input. If the up or down
// keys are pressed, the script will cycle through the chat history
// and replace the input box's text with the previous messages.
// The list of messages is extended whenever the player sends a message.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Zone.Events;
using Melia.Zone.Scripting;

public class ChatHistoryClientScript : ClientScript
{
	public override void Load()
	{
		this.LoadAllScripts();
	}

	[On("PlayerReady")]
	protected void OnPlayerReady(object sender, PlayerEventArgs e)
	{
		this.SendAllScripts(e.Character);
	}
}
