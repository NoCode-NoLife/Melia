Combat Events
=============================================================================

## Introduction

Most of Melia's internal combat calculations are handled by a series
of [scriptable functions][scriptable_functions.md] found in our core
scripts. In many cases, all we have to do to calculate a skill's damage
is call into this system and use the returned values to determine the
outcome of the attack.

However, some skills and buffs need to make slight adjustments to the
combat calculations. For this purpose we provide event handler interfaces
for buffs and skills that allows them to inject their modifications.

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

## Event Handlers

The better approach is to use the aforementioned event handlers, currently
available for both buff and skill handlers. Similar to hooks, these allow
you to affect the calculations by making changes to the modifier and result
objects. The available interfaces are as follows, representing the two
different event types, `Attack` and `Defense`, and the four different
events, `BeforeCalc`, `AfterCalc`, `BeforeBonuses`, and `AfterBonuses`.

**Buffs**
- IBuffCombatAttackBeforeCalcHandler
- IBuffCombatAttackAfterCalcHandler
- IBuffCombatDefenseBeforeCalcHandler
- IBuffCombatDefenseAfterCalcHandler
- IBuffCombatAttackBeforeBonusesHandler
- IBuffCombatAttackAfterBonusesHandler
- IBuffCombatDefenseBeforeBonusesHandler
- IBuffCombatDefenseAfterBonusesHandler

**Skills**
- ISkillCombatAttackBeforeCalcHandler
- ISkillCombatAttackAfterCalcHandler
- ISkillCombatDefenseBeforeCalcHandler
- ISkillCombatDefenseAfterCalcHandler
- ISkillCombatAttackBeforeBonusesHandler
- ISkillCombatAttackAfterBonusesHandler
- ISkillCombatDefenseBeforeBonusesHandler
- ISkillCombatDefenseAfterBonusesHandler

The methods defined in these interfaces take the same parameters as a
scriptable skill hit function, in addition to either a buff or a skill,
depending on the type. These event handlers are then called for all
active buffs and passive skills of the attacker and target, and the
respective object is always that of the relevant actor in that operation.

For example, if you're attacking an enemy with the skill `Foobar`,
the system will check if there's an event handler for the `Attack`
type defined for that skill and call it. The skill passed to the
handler in that case will be the relevant skill of the attacker.

`ISkillCombatAttackBeforeCalcHandler`
```cs
void OnAttackBeforeCalc(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult)
```

Similarly, if the target of such an attack has a certain buff,
an event handler for that buff and the type `Defense` will be
searched for.

`IBuffCombatDefenseBeforeCalcHandler`
```cs
void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
```

## Event Types

What matters in using these events are the event type and sometimes the
event itself. Generally speaking, you'll want to use the `Attack` handlers
to modify the attack from the view point of the attacker, while `Defense`
is for the target. If the attacker receives a damage bonus from having
buff `Foo`, you should add an attack event handler to that buff's handler,
which will automatically be called with the attacker's respective buff
if it's active. On the other hand, the `Defense` events will be called
for the targets if they have a certain buff or passive skill.

```cs
[BuffHandler(BuffId.BossDamageBuff)]
public class BossDamageBuff : BuffHandler, IBuffCombatAttackBeforeCalcHandler
{
	public void OnAttackBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		// While BossDamageBuff is active on the attacker, increase
		// damage multiplier by 1 (100%) against boss monsters
		if (target.Rank == MonsterRank.Boss)
			modifier.DamageMultiplier += 1;
	}
}

[BuffHandler(BuffId.BossDefenseBuff)]
public class BossDamageBuff : BuffHandler, IBuffCombatDefenseBeforeCalcHandler
{
	public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
	{
		// While BossDefenseBuff is active on the target, decrease
		// damage multiplier by 0.5 (50%) if attacker is a boss
		if (attacker.Rank == MonsterRank.Boss)
			modifier.DamageMultiplier -= 0.5f;
	}
}
```

### Application

As a rule of thumb, you will mostly have to concern yourself with
only one question: Who are you checking for with an event? If you're
applying an effect based on the attacker's buffs or skills, use
`Attack`. If it's about the target's buffs or skills, use `Defense`.
For simple changes on the modifier you should then use `BeforeCalc`.

Attacker's buff/skill: `I[Buff|Skill]CombatAttackBeforeCalcHandler`
Targets's buff/skill:  `I[Buff|Skill]CombatDefenseBeforeCalcHandler`

Add the interface to your handler, let your IDE implement it, and
add your modifications. Afterwards, your event should automatically
be called if the attacker/target has the respective buff/skill
during an attack from/against them.

If your needs are more complex, we recommend studying the combat
calculations, when these events are executed, and other skills
and buffs that are already making use of them.

One example of an alternative application might be the `Link` buff,
which shares incoming damage with targets linked to it. For this it
uses the `AfterCalc` event, which is called after all calculations
are done, so it can execute attacks with the same amount of final
damage on the other targets.
