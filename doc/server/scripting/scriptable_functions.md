Scriptable Functions
=============================================================================

## Introduction

In essence, scriptable functions are C# methods like any other,
but the server gathers them and saves references to them, to
be able to later call them from anywhere. This makes it easy
to quickly call methods by name globally, which is particularly
handy for overwriting methods from scripts or to reference
methods by name, as is done for item usage scripts.

## Example

To illustrate this, take a look at the following scriptable
function, which is referenced in the item data by its name,
`SCR_USE_ITEM_EXPCARD`. When the item is called, we get the
function by name and call it with the arguments defined in
the item data.
```cs
[ScriptableFunction]
public ItemUseResult SCR_USE_ITEM_EXPCARD(Character character, Item item, string strArg, float numArg1, float numArg2)
{
	var baseExp = (long)numArg1;
	var jobExp = (long)(baseExp * 0.77f);

	character.GiveExp(baseExp, jobExp, null);
	character.PlayEffect("F_sys_expcard_normal");

	return ItemUseResult.Okay;
}
```

## Attribute

The way we accomplish this is via the `ScriptableFunction` attribute.
Every function that is part of a `GeneralScript` and is decorated with
this attribute will be considered a scriptable function, using either
the function's name or the string defined in the attribute. For example,
the following function would get registered as `SCR_USE_ITEM_EXPCARD`
as well.

```cs
[ScriptableFunction("SCR_USE_ITEM_EXPCARD")]
public ItemUseResult UseExpCard(Character character, Item item, string strArg, float numArg1, float numArg2)
```

## Types

Because of the nature of C#'s static typing, we only support
pre-defined delegate types as scriptable functions. The defined
types are as follows.

```cs
float Character(Character character);
float Monster(Mob monster);
float Skill(Skill skill);
float Combat(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult);
SkillHitResult SkillHit(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier);
ItemUseResult ItemScriptFunc(Character character, Item item, string strArg, float numArg1, float numArg2);
NormalTxResult NormalTx(Character character, string strArg);
NormalTxResult NormalTxNum(Character character, int[] numArgs);
DialogTxResult DialogTx(Character character, DialogTxArgs args);
CustomCommandResult CustomCommand(Character character, int numArg1, int numArg2, int numArg3);
bool AbilityUnlock(Character character, string argStr, int argInt, AbilityData data);
void AbilityPrice(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time);
```

If you use the `ScriptableFunction` attribute on any functions
that match any of these signatures inside a `GeneralScript`,
they will be picked up and can then be called from anywhere.

## Execution

To call any scriptable function, simply get their reference
and then call them like any other delegate.

```cs
var func = ScriptableFunctions.Character.Get("SCR_Get_Character_MAXPATK");
var maxPatk = func(character);

// ...
```

## Usage

Internally we primarily use scriptable functions for item interactions
and combat calculations, where this feature makes it easier for us to
interact with the client and take advantage of existing information.

For example, most any combat skill uses the function `SCR_SkillHit`
to calculate the skill damage and determine the hit outcome, such as
whether a crit or dodge should occur. These functions being scriptable
also means that they can easily be overwritten from custom scripts,
which may allow users to modify their behavior. If you dislike certain
formulas for example, changing them might be a rather simple matter.
The following example will change crit chance to always be 50%,
no matter what.

```cs
[ScriptableFunction]
public float SCR_GetCritChance(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
{
	return 50;
}
```

## More

To find more examples and figure out which functions may exist for
potential overwrites, we recommend studying the scripts found in Melia. Particularly the files in `system/scripts/zone/core/`.
