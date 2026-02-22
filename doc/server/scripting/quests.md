Quest Scripts
=============================================================================

Melia uses a custom quest system that allows the creation of quests with
a wide variety of objectives, rewards, and prerequisites. The system
aims to support any type of quest available in the original game and more,
in such a way that quests can be created with ease and flexibility, and
without requiring client modifications.

Quests are commonly defined via script classes, using the dedicated type
`QuestScript`, which provides methods to specify a quest's properties.

Example Script
-----------------------------------------------------------------------------

```cs
public class KillOnions1TestQuestScript : QuestScript
{
	protected override void Load()
	{
		SetId("Melia.Test", 1);
		SetName("Onions Must Die");
		SetDescription("Slice, dice, and make these onion-shaped bastards cry for a change!");

		AddObjective("kill", "Kill 5 Kepas", new KillObjective(5, MonsterId.Onion));

		SetReceive(QuestReceiveType.Auto);
		AddPrerequisite(new LevelPrerequisite(2));

		AddReward(new ItemReward(ItemId.Card_Onion_The_Great));
		AddReward(new ItemReward(ItemId.OnionPiece_Red, 20));
		AddReward(new SilverReward(1000));
		AddReward(new ExpReward(1000, 500));
	}
}
```

Basic Information
-----------------------------------------------------------------------------

### Quest Id

The value that identifies a quest within the server is the questid, a
numeric variable that represents an id inside a namespace. The namespace
should be set to a unique identifier for a group of quests, while the id
must be a unique number between 1 and 65,535. When writing new quests,
be sure to choose a namespace unique to you, your project or the category
of quests you're working on, while incrementing the ids within.

```cs
SetId("Melia.Test", 1);
```

Internally, the id is handled as a 64 bit integer, where 48 bit represent
the namespace and 16 bit the id.

### Name and Description

The name and description are the quest information displayed on the client,
detailing what the quest is about. This information is separate from the
objectives, which are intended to inform the player about the specific
tasks.

Objectives
-----------------------------------------------------------------------------

Objectives represent jobs the player needs to carry out to complete the
quest and receive the rewards. They include tasks such as killing monsters,
talking to NPCs, collecting items, or whatever you may think of. New
types of objectives can be created easily, though many common ones will
already be available.

Existing objectives include:
- `CollectItemObjective`: Collect a certain amount of an item.
- `KillObjective`: Kill a certain number of specific enemies.
- `SkillLevelObjective`: Increase a skill's level to a certain point.
- `ManualObjective`: A manual objective, useful for triggering from NPCs.

```cs
// Player must first kill 5 Kepas and then talk to an NPC, where the
// second objective will hopefully be completed and with it the quest.
AddObjective("kill", "Kill 5 Kepas", new KillObjective(5, MonsterId.Onion));
AddObjective("talk", "Talk to Ronesa", new ManualObjective());
```

To create a new quest objective type, create a new class that inherits
from `QuestObjective`.

Prerequisites
-----------------------------------------------------------------------------

Quests can be specified to be given out in `Manual` or `Auto` mode, which
determines whether the player will automatically receive it upon meeting
certain prerequsisites, or whether you have to start it via an NPC or
other means (the default).

When choosing auto-mode, you will most likely want to set up what needs
to happen for the player to receive the quest, such as reaching a certain
level, learning a skill, or completing other quests. As with objectives,
new prerequisites can be defined easily, though many common ones are
provided by the server.

Existing prerequisites include:
- `CompletedPrerequisite`: Another quest must be completed first.
- `LevelPrerequisite`: Player needs to reach a certain level.
- `SkillPrerequisite`: A skill must be above a certain level.
- `NotSkillPrerequisite`: A skill must not be above a certain level.

Additionally, there are helpers to give more options:
- `OrPrerequisite`: Takes multiple prerequisites, of which only one needs
  to get completed for the player to meet the requirement.

```cs
// Player will automatically receive the quest once they completed
// Melia.Test quest 1 and reached level 3.
SetReceive(QuestReceiveType.Auto);
AddPrerequisite(new LevelPrerequisite(3));
AddPrerequisite(new CompletedPrerequisite("Melia.Test", 1));
```

To create a new quest prerequisite type, create a new class that inherits
from `QuestPrerequisite`.

Rewards
-----------------------------------------------------------------------------

Once the player completes a quest, they will receive all rewards that
were defined for a quest, such as items, experience points, etc. As with
objectives and prerequisites, these are flexible and you can create any
reward you can think of.

The rewards provided by default include:
- `ExpReward`: Grants a number of EXP and job EXP.
- `ItemReward`: Grants an item or number thereof.
- `SilverReward`: Grants a certain amount of silver.

```cs
AddReward(new ItemReward(ItemId.Card_Onion_The_Great));
AddReward(new ItemReward(ItemId.OnionPiece_Red, 20));
AddReward(new SilverReward(1000));
AddReward(new ExpReward(1000, 500));
```

To create a new quest reward type, create a new class that inherits
from `QuestReward`.

Hooks
-----------------------------------------------------------------------------

To keep all information and functions related to one quest within its
quest script, you can use hooks to intercept dialogues with NPCs, to
have them react differently during quests.

### Example

```cs
protected override void Load()
{
	// ...

	AddDialogHook("Ronesa", "BeforeDialog", RonesaDialog);
}

private async Task<HookResult> RonesaDialog(Dialog dialog)
{
	var character = dialog.Player;

	if (!character.Quests.IsActive(this.QuestId, "talk"))
		return HookResult.Skip;

	await dialog.Msg("Welcome, how can I help you today?");
	await dialog.Msg("Oh, you received my quest? Thank you very much for helping out with these pests.{nl}It was about time someone did something about them. Here's your reward.");

	character.Quests.Complete(this.QuestId);

	return HookResult.Break;
}
```

In this example, the accessory merchant Ronesa in Klaipeda is hooked,
with the code getting executed before her normal dialog starts. The
hook then checks whether the current quest and the objective to talk
to her are actually active, and if so, the quest dialog is executed
and the quest completed. Instead of completing the entire quest though,
you could also complete only the objective to let the player complete
the quest manually, or send them on to the next objective.

Note that NPCs need to get prepared to receive hooks though, which can
be done by explicitly executing them within their code.

```cs
AddNpc(20104, "[Accessory Merchant] Ronesa", "Ronesa", "c_Klaipe", 269, -611, 90.0, async dialog =>
{
	dialog.SetTitle("Ronesa");
	dialog.SetPortrait("Dlg_port_KLAPEDA_ACCESSORY");

	// Try to execute hooks
	if (await dialog.Hooks("BeforeDialog"))
		// Dialog that follows any potentially executed hooks
		await dialog.Msg("While you're here, do you need anything?{nl}I've got some hard-to-find stuff.");
	else
		// Dialog for when no hooks were executed
		await dialog.Msg("Welcome.{nl}Only hard-to-find stuff here.");
```
