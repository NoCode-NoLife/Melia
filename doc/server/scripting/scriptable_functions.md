Scriptable Functions
=============================================================================

Introduction
-----------------------------------------------------------------------------

In essence, scriptable functions are C# methods like any other, but with
the difference that they are registered globally and can be retrieved by
name to call them from anywhere. This makes it easy to call or override
these methods quickly, which is particularly handy for overriding
functions from scripts or to reference methods by name, as is done for
item usage scripts.

Example
-----------------------------------------------------------------------------

To illustrate this, let's take a look at the following scriptable function,
which is referenced in the item data by its name, `SCR_USE_ITEM_EXPCARD`.
When an item with this script function is used, we get the function by
name and call it with the arguments defined in the item data.

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

Attribute
-----------------------------------------------------------------------------

The way we set up the function in the example is via the
`ScriptableFunction` attribute. This marks a method as intended for use as
a scriptable function and the server will pick these up and automatically
register them from certain classes, such as `GeneralScript` and skill
handlers.

The name of registered function defaults to the name of the method by
default, but you can also specify a custom name by passing it as an
argument. For example, the following function would be registered as
`SCR_USE_ITEM_EXPCARD` as well.

```cs
[ScriptableFunction("SCR_USE_ITEM_EXPCARD")]
public ItemUseResult UseExpCard(Character character, Item item, string strArg, float numArg1, float numArg2)
```

Alternatively, you can also register a function manually by calling the
`Register` or `TryRegister` methods on the delegate collections found
inside the static `ScriptableFunctions` class. This is useful if you
aren't able to use an attribute or you have more complex registration
and naming logic.

Types
-----------------------------------------------------------------------------

Because of the nature of C#'s static typing, we only support pre-defined
delegate types as scriptable functions. The defined function signatures
are as follows.

```cs
float Character(Character character);
float Monster(Mob monster);
float Skill(Skill skill);
float Combat(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult);
void CombatModifier(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult);
SkillHitResult SkillHit(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier);
ItemUseResult ItemScriptFunc(Character character, Item item, string strArg, float numArg1, float numArg2);
NormalTxResult NormalTx(Character character, string strArg);
NormalTxResult NormalTxNum(Character character, int[] numArgs);
DialogTxResult DialogTx(Character character, DialogTxArgs args);
CustomCommandResult CustomCommand(Character character, int numArg1, int numArg2, int numArg3);
bool AbilityUnlock(Character character, string argStr, int argInt, AbilityData data);
void AbilityPrice(Character character, AbilityData abilityData, int abilityLevel, int maxLevel, out int price, out int time);
```

If you use the `ScriptableFunction` attribute on any functions that match
any of these signatures, they will be picked up when loading the class.

## Execution

To call any scriptable function, simply get their reference
and then call them like any other delegate.

```cs
var func = ScriptableFunctions.Character.Get("SCR_Get_Character_MAXPATK");
var maxPatk = func(character);

// ...
```

You can also use a `TryGet`, as to not trigger an exception if the
function doesn't exist.

```cs
var maxPatk = 0f;

if (ScriptableFunctions.Character.TryGet("SCR_Get_Character_MAXPATK", out var func))
	maxPatk = func(character);

// ...
```

As with registering functions, you need to use the respective function
type collection for getting them, such as `Character` for the character
calculation focused functions, `Combat` for combat related functions,
and so on, as inferable from the type list above.

Usecases
-----------------------------------------------------------------------------

Internally we primarily use scriptable functions for item interactions
and combat calculations, where this feature makes it easier for us to
interact with the client and take advantage of existing information.

One example are various item and transaction scripts, which are commonly
referenced by name in the client and networking data. By having these as
scriptable functions, we can easily refer to them, call them, and modify
them as needed.

Another example are combat related functions, such as those containing
formulas or logic for determining hit outcomes. Most any combat skill uses
the function `SCR_SkillHit` and the functions it calls to calculate the
skill damage and to checker whether a crit or dodge should occur. As
scriptable functions, these can easily be overridden to modify their
behavior. If you dislike certain formulas for example, changing them might
be a rather simple matter. The following example, placed inside a user
script, will change the crit chance of all hits to always be 50%, no
matter what.

```cs
[ScriptableFunction]
public float SCR_GetCritChance(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
{
	return 50;
}
```

Overrides
-----------------------------------------------------------------------------

In cases where scripts replace and override existing functions, the original
can be retrieved via the global `ScriptableFunctions` class. The respective
method, `TryGetOverridden`, is available on all function type lists
and takes a reference to the *current* function, which it uses to
look up the function that was overridden by it.

The example below shows how the core function `SCR_Get_Character_MHP`
gets overridden and its result halved, effectively modifying characters'
max HP by -50%. Note how the function reference passed to `TryGetOverridden`
is the function that is being executed. The overridden function returned
will then be the one that was referenced by the name `SCR_Get_Character_MHP`
before the script parser encountered the newer version.

```cs
[ScriptableFunction]
public static float SCR_Get_Character_MHP(Character character)
{
	if (!ScriptableFunctions.Character.TryGetOverridden(SCR_Get_Character_MHP, out var overriddenFunc))
		throw new MissingMemberException("Overridden function SCR_Get_Character_MHP not found.");

	var originalResult = overriddenFunc(character);

	// Reduce max HP by 50%
	return (int)Math.Max(1, originalResult * 0.5f);
}
```

The function returned is always the immediate one that was overridden by
the newer version and the system keeps track of all overrides. This means
if a function is overridden multiple times, each one is able to reference
its immediate parent. This way it's possible to walk up the tree of
overrides by repeatedly passing the reference to the overridden function
to `TryGetOverridden`, should there ever be a need to find even older
versions. It's also possible to directly get the original function,
meaning the first one registered under the name, by using the
`TryGetOriginal` method instead.

Accessing overridden functions is useful primarily when modifying results,
such as the calculations of existing core functions. The original function
will be executed in its entirety and any changes it might make globally
or to its given arguments persist, regardless of what the overriding
function does.

An example of a function type that would rarely be overridden is an item
script function, as its behavior is self-contained and it returns only
the result of the item usage. Although there are cases where overriding
such a function could be used to monitor or react to certain results.

More
-----------------------------------------------------------------------------

To find more examples and learn about which functions may exist for
potential overrides, we recommend studying the scripts found in Melia.
Particularly, the files in `system/scripts/zone/core/`.
