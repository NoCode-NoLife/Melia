Combat Events
=============================================================================

Most of the server's internal combat calculations are handled by a series
of [scriptable functions](../scripting/scriptable_functions.md), found in
our core scripts. In many cases, all we have to do to calculate a skill's
damage is call into this system and use the returned values to determine
the outcome of the attack.

However, some skills and buffs need to make slight adjustments to the
combat calculations. For this purpose we provide hooks into the combat
calculation process, which are able to set modifiers or otherwise adjust
the calculations as needed.

As a practical example, consider a buff that doubles the attacker's
damage against boss monsters. Without events or another system that
allows us to make modifications to the calculations, we'd have to
handle such a case explicitly inside our core code.

```cs
[ScriptableFunction]
public float SCR_CalculateDamage(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
{
    // ...

    skillHitResult.Damage = SCR_GetRandomAtk(attacker, target, skill, modifier, skillHitResult);

    // ...

    // Increase damage multiplier by 1 (100%) for boss monsters
    if (attacker.IsBuffActive(BuffId.BossDamageBuff) && target.Rank == MonsterRank.Boss)
        modifier.DamageMultiplier += 1;

    // ...
}
```

This approach would generally work, but the resulting code would become
rather unwieldy and difficult to maintain over time, as we add hundreds
of buff and skill effects to our calculations. In addition to this, the
code for skills and buffs would get split up over various files.


Calculation Modifiers and Events
-----------------------------------------------------------------------------

The better approach is to use the aforementioned modification hooks, which
are set up by default for skills, buffs, abilities, and equipment, and are
called as appropriate, like for active buffs and equipped items.

The easiest way to register a calculation modifier is by using the
`CombatCalcModifier` attribute on a method with the following signature:

```cs
void (ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
```

Within this method, you can make adjustments to the `modifier` or
`skillHitResult` parameters, which in turn will affect how the
calculations play out. To expand on the example from before, we could
implement the boss damage buff like this:

```cs
[CombatCalcModifier(CombatCalcPhase.BeforeCalc, BuffId.BossDamageBuff)]
public void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
{
    if (attacker.IsBuffActive(BuffId.BossDamageBuff) && target.Rank == MonsterRank.Boss)
        modifier.DamageMultiplier += 1;
}
```

This method can be placed in the buff handler for `BossDamageBuff`, and it
will automatically be called during calculations.

Note that only one modifier can be registered for each phase and skill,
buff, ability, or piece of equipment. Internally, these become scriptable
functions with names like `SCR_Combat_BeforeCalc_Ranger_SteadyAim`.


Calculations Phases
-----------------------------------------------------------------------------

There are multiple points during the calculation process that can be
hijacked to make adjustments, which are defined by the `CombatCalcPhase`
class. They are as follows, in the order they are called.

### BeforeCalc

Occurs before the combat calculations begin.

### BeforeBonuses

Occurs after the basic combat calculations have been performed, but before
bonuses such as race and size multipliers are applied.

### AfterBonuses

Occurs after the basic combat calculations have been performed and all
bonuses have been applied. Only crit and block calculations follow this
phase, before AfterCalc is triggered.

### AfterCalc

Occurs after all combat calculations have been performed, including
bonuses.


The phase you choose will largely depend on the needs of the skill or
buff in question. `BeforeCalc` for example is usually used to apply damage
multipliers, so they're ready during the calculations. `AfterCalc` on the
other hand is often used to overwrite results of the calculations, such as
changing the final damage or toggling effects such as knock back.


Attackers vs Targets
-----------------------------------------------------------------------------

The calculation modifier functions are called once for each relevant usage
of a skill. For example, if an enemy attacks a Swordsman while they have
the Bear buff active, the method `SCR_Combat_BeforeCalc_Bear_Buff` will be
called, which may be setup like this:

```cs
[CombatCalcModifier(CombatCalcPhase.BeforeCalc, BuffId.Bear_Buff)]
public void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
{
    var skillLevel = buff.NumArg1;
    var multiplierReduction = skillLevel * 0.02f;

    modifier.DamageMultiplier -= multiplierReduction;
}
```

Since a buff may exist on either the attacker or the target though, this
method will also be called if that Swordsman attacks the enemy while the
buff is active. As a result, the Swordsman would deal reduced damage to
the enemy as well, which is not usually the intended behavior.

For this reason, it's important to check whether the buff is active on the
*target*, so that the attacked Swordsman receives a damage reduction, but
the attacked enemy does not. This can be done like so:

```cs
[CombatCalcModifier(CombatCalcPhase.BeforeCalc, BuffId.Bear_Buff)]
public void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
{
    if (!target.TryGetBuff(BuffId.Bear_Buff, out var buff))
        return;

    var skillLevel = buff.NumArg1;
    var multiplierReduction = skillLevel * 0.02f;

    modifier.DamageMultiplier -= multiplierReduction;
}
```
