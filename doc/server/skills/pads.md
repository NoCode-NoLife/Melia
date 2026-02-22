Pads
=============================================================================

## Introduction

Pads are a form of AoE trigger manager and effect target in this game.
Within Melia they're defined as an area on a map, with events informing
the system about characters and monsters entering or leaving the area.
They also provide events for when the pad is created or destroyed, as
well as an update that occurs in regular intervals while the pad exists
on a map.

In addition to this functionality, pads serve as a kind of effect
receiver, as dictated by the client file `pad_skill_list.xml`.
Essentially, when a pad is created, and the client is informed
about it, it may play effects defined for it on the client-side,
which is often used for effects related to skills.

## Application

Generally speaking, you'll want to create and use a pad from within
a skill handler when the game requires it. In most cases, it's as
simple as creating the `Pad` object, along with its shape, subscribing
to its trigger's events, and adding the pad to the relevant map.

```cs
var pad = new Pad(PadName.Foobar, caster, skill, new Circle(caster.Position, 40));
pad.Trigger.Subscribe(TriggerType.Enter, this.OnPadEnter);
pad.Trigger.Subscribe(TriggerType.Update, this.OnPadUpdate);

caster.Map.AddPad(pad);

// ...

void OnPadEnter(object sender, PadTriggerActorArgs args)
{
	// React to event
}

void OnPadUpdate(object sender, PadTriggerArgs args)
{
	// React to event
}
```

## Event Types

The available events are as follows: `Create`, `Destroy`, `Update`,
`Enter`, and `Leave`. While `Enter` and `Leave` take `PadTriggerActorArgs`,
containing the actor that effectively triggered the event, the others use
`PadTriggerArgs`, without an initiator, as they occur independently.

In addition to manually subscribing to the events, you can also create
pad handler classes that are subscribed automatically if they have a
matching name. This is useful for making pads reusable and operate
independently of a specific skill.

```cs
[PadHandler("Foobar")]
public class FoobarPad : ICreatePadHandler, IDestroyPadHandler
{
	public void Created(object sender, PadTriggerArgs args)
	{
	}

	public void Destroyed(object sender, PadTriggerArgs args)
	{
	}
}
```

For every event you may subscribe to, there is a corresponding pad
handler interface. Namely, `ICreatePadHandler`, `IDestroyPadHandler`,
`IUpdatePadHandler`, `IEnterPadHandler`, and `ILeavePadHandler`.

For more concrete examples on how to create and use pads, we recommend
looking into existing skills and how they utilize them.
