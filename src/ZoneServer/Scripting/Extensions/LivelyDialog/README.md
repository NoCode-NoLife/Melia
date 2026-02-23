Lively Dialog
=============================================================================

This extension adds a way to track relationships with NPCs, affect them,
and change reactions based on them. It's modelled after a similar system
in Mabinogi, where improving the relationship with NPCs opened up hidden
shops, dialog options, and rewards.

Basics
-----------------------------------------------------------------------------

The system relies on three key values: memory, favor, and stress. Every
NPC can remember these three values for every character and they can be
used to change how NPCs react.

### Memory

Memory is a general value from 0 to 100 that indicates how well an NPC
remembers a player. The more times they talk to them, the higher the
memory. Though this value doesn't indicate whether the memory is positive
or negative.

Memory decays at a value of 1 point per real-life day, so if a player
doesn't speak to an NPC for extended periods of time, they will forget
about them.

### Favor

Favor is a value used to track how much an NPC likes or dislikes a player,
ranging from -100 to +100. It's a more short-term value, moving towards 0
at a rate of 1 point every real-life hour. Meaning, regardless of wether
an NPC likes or dislikes a player, eventually it will return to a neutral
value.

### Stress

The final value is stress, which indicates the moment to moment feelings
of an NPC towards a player. It ranges from 0 to 100 and reduces by 1
point every real-life minute.

Typically, stress should increase whenever something happens the NPC
doesn't like, such as repeatedly choosing the same dialog options,
and decrease when they're treated well. The idea is that they might
choose to temporarily change their attitude towards you if you
annoy them.

Functions
-----------------------------------------------------------------------------

The relationship values are primarily controlled via the following extension
methods.

```cs
int GetMemory(this Dialog dialog)
int GetFavor(this Dialog dialog)
int GetStress(this Dialog dialog)
int SetMemory(this Dialog dialog)
int SetFavor(this Dialog dialog)
int SetStress(this Dialog dialog)
int ModifyMemory(this Dialog dialog, int value)
int ModifyFavor(this Dialog dialog, int value)
int ModifyStress(this Dialog dialog, int value)
void ModifyRelation(this Dialog dialog, int memory, int favor, int stress)
RelationshipStatus GetRelationshipStatus(this Dialog dialog)
```

Usage Example
-----------------------------------------------------------------------------

```cs
var rel = dialog.GetRelationshipStatus();

if (rel.Level == RelationshipLevel.CloseFriends && rel.StressLevel == StressLevel.Low)
{
	await dialog.Msg(L("Hello, {pcname}! It's great to see you! How have you been?"));
	dialog.ModifyRelation(Random(2), Random(2), Random(2));
}
else if (rel.Level == RelationshipLevel.Friends && rel.StressLevel == StressLevel.Low)
{
	await dialog.Msg(L("Hello, {pcname}! Nice to see you!"));
	dialog.ModifyRelation(Random(2), Random(2), Random(2));
}
else if (rel.Level == RelationshipLevel.Acquaintances && rel.StressLevel <= StressLevel.Moderate)
{
	await dialog.Msg(L("Hello, {teamname}!"));
	dialog.ModifyRelation(Random(2), Random(2), Random(2));
}
else if (rel.Level == RelationshipLevel.Strained)
{
	await dialog.Msg(L("Hm? What do you want?"));
	dialog.ModifyRelation(Random(2), -Random(2), Random(1, 3));
}
else if (rel.Level == RelationshipLevel.Antagonistic && rel.StressLevel <= StressLevel.Moderate)
{
	await dialog.Msg(L("You're asking a lot of questions..."));
	dialog.ModifyRelation(Random(2), -Random(3), Random(1, 3));
}
else if (rel.Level == RelationshipLevel.Antagonistic && rel.StressLevel == StressLevel.High)
{
	await dialog.Msg(L("You're trying my patience... I suggest you leave."));
	dialog.ModifyRelation(Random(2), -Random(4), Random(1, 4));
}
else // Neutral
{
	await dialog.Msg(L("Hi there."));
	dialog.ModifyRelation(Random(2), 0, Random(3));
}
```