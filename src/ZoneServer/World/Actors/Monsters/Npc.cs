using System;
using Melia.Shared.Scripting;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting.Dialogues;
using Yggdrasil.Geometry;
using Yggdrasil.Util;
using System.Threading.Tasks;
using Melia.Zone.World.Actors.Pads;
using Melia.Zone.Skills;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World.Actors.Monsters
{
	/// <summary>
	/// A non-player character that supports dialogues.
	/// </summary>
	public class Npc : MonsterInName, ITriggerableArea, IUpdateable
	{
		// TODO: Determine whether NPCs and mobs should actually be
		//   separate classes. NPCs don't typically fight, and many
		//   of them can't even move, but perhaps there are mobs
		//   with triggers? This needs some research.

		/// <summary>
		/// Returns the NPC's state.
		/// </summary>
		public NpcState State { get; private set; }

		/// <summary>
		/// Returns the function to call when the NPC is triggered via click.
		/// </summary>
		public DialogFunc DialogFunc { get; private set; }

		/// <summary>
		/// Returns the function called when someone steps into the NPC's
		/// trigger area.
		/// </summary>
		public TriggerActorFuncAsync EnterFunc { get; private set; }

		/// <summary>
		/// Returns the function called when someone steps out of the NPC's
		/// trigger area.
		/// </summary>
		public TriggerActorFuncAsync LeaveFunc { get; private set; }

		/// <summary>
		/// Returns the area in which the NPC's enter and leave functions
		/// are triggered.
		/// </summary>
		public IShapeF Area { get; private set; }

		/// <summary>
		/// Returns the NPC's variables.
		/// </summary>
		/// <remarks>
		/// NPC variables are temporary and are not saved across server
		/// restarts.
		/// </remarks>
		public Variables Vars { get; } = new Variables();

		/// <summary>
		/// Creates new NPC.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="name"></param>
		/// <param name="location"></param>
		/// <param name="direction"></param>
		public Npc(int monsterClassId, string name, Location location, Direction direction)
			: base(monsterClassId)
		{
			this.Name = name;
			this.Position = location.Position;
			this.Direction = direction;
		}

		/// <summary>
		/// Changes the NPC's state and updates the nearby clients.
		/// </summary>
		/// <param name="state"></param>
		public void SetState(NpcState state)
		{
			this.State = state;
			Send.ZC_SET_NPC_STATE(this);
		}

		/// <summary>
		/// Sets up a function that is called when the NPC is triggered
		/// via click.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="func"></param>
		public void SetClickTrigger(string name, DialogFunc func)
		{
			this.DialogName = name;
			this.DialogFunc = func;
		}

		/// <summary>
		/// Sets up a function that is called when the NPC is triggered
		/// by stepping into the given area.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="func"></param>
		public void SetEnterTrigger(string name, TriggerActorFuncAsync func)
		{
			this.EnterName = name;
			this.EnterFunc = func;
		}

		/// <summary>
		/// Sets up a function that is called when the NPC is triggered
		/// by stepping into the given area.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="func"></param>
		public void SetEnterTrigger(string name, TriggerActorFuncSync func)
		{
			this.SetEnterTrigger(name, async (args) =>
			{
				func(args);
				await Task.CompletedTask;
			});
		}

		/// <summary>
		/// Sets up a function that is called when the NPC is triggered
		/// by stepping into the given area.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="func"></param>
		public void SetLeaveTrigger(string name, TriggerActorFuncAsync func)
		{
			this.LeaveName = name;
			this.LeaveFunc = func;
		}

		/// <summary>
		/// Sets the trigger area for the NPC's enter and leave triggers.
		/// </summary>
		/// <param name="area"></param>
		public void SetTriggerArea(IShapeF area)
		{
			this.Area = area;
		}

		/// <summary>
		/// Updates NPC and its components.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			this.Effects.Update(elapsed);
		}

		/// <summary>
		/// Makes the NPC say the given message, which will display via
		/// chat bubble above their head.
		/// </summary>
		/// <param name="format"></param>
		/// <param name="args"></param>
		public void Say(string format, params object[] args)
		{
			var message = args?.Length == 0 ? format : string.Format(format, args);
			Send.ZC_CHAT(this, message);
		}
	}

	/// <summary>
	/// An object that defines an area and functions to trigger when
	/// said area is entered or left.
	/// </summary>
	public interface ITriggerableArea : IActor
	{
		/// <summary>
		/// Returns a function to call when someone enters the area.
		/// </summary>
		TriggerActorFuncAsync EnterFunc { get; }

		/// <summary>
		/// Returns a function to call when someone leaves the area.
		/// </summary>
		TriggerActorFuncAsync LeaveFunc { get; }

		/// <summary>
		/// Area in which the enter and leave functions are triggered.
		/// </summary>
		IShapeF Area { get; }
	}

	/// <summary>
	/// A function that can be used as a synchronous trigger callback.
	/// </summary>
	/// <param name="args"></param>
	/// <returns></returns>
	public delegate void TriggerFuncSync(TriggerArgs args);

	/// <summary>
	/// A function that can be used as an asynchronous trigger callback.
	/// </summary>
	/// <param name="args"></param>
	/// <returns></returns>
	public delegate Task TriggerFuncAsync(TriggerArgs args);

	/// <summary>
	/// A function that can be used as a synchronous trigger callback.
	/// </summary>
	/// <param name="args"></param>
	/// <returns></returns>
	public delegate void TriggerActorFuncSync(TriggerActorArgs args);

	/// <summary>
	/// A function that can be used as an asynchronous trigger callback.
	/// </summary>
	/// <param name="args"></param>
	/// <returns></returns>
	public delegate Task TriggerActorFuncAsync(TriggerActorArgs args);

	/// <summary>
	/// The event arguments for pad trigger events.
	/// </summary>
	public class TriggerArgs : EventArgs
	{
		/// <summary>
		/// Returns how the trigger was triggered.
		/// </summary>
		public TriggerType Type { get; }

		/// <summary>
		/// Returns the trigger that was triggered.
		/// </summary>
		public IActor Trigger { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="trigger"></param>
		/// <param name="initiator"></param>
		public TriggerArgs(TriggerType type, IActor trigger)
		{
			this.Type = type;
			this.Trigger = trigger;
		}
	}

	/// <summary>
	/// The event arguments for pad trigger events.
	/// </summary>
	public class TriggerActorArgs : EventArgs
	{
		/// <summary>
		/// Returns how the trigger was triggered.
		/// </summary>
		public TriggerType Type { get; }

		/// <summary>
		/// Returns the trigger that was triggered.
		/// </summary>
		public IActor Trigger { get; }

		/// <summary>
		/// Returns the triggering actor that triggered the triggerarable trigger
		/// in a most triggerable way. Trigger.
		/// </summary>
		public IActor Initiator { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="trigger"></param>
		/// <param name="initiator"></param>
		public TriggerActorArgs(TriggerType type, IActor trigger, IActor initiator)
		{
			this.Type = type;
			this.Trigger = trigger;
			this.Initiator = initiator;
		}
	}

	/// <summary>
	/// The event arguments for pad trigger events.
	/// </summary>
	public class PadTriggerArgs : EventArgs
	{
		/// <summary>
		/// Returns how the trigger was triggered.
		/// </summary>
		public TriggerType Type { get; }

		/// <summary>
		/// Returns the pad that was triggered.
		/// </summary>
		public Pad Trigger { get; }

		/// <summary>
		/// Returns the actor that created the pad.
		/// </summary>
		public ICombatEntity Creator { get; }

		/// <summary>
		/// Returns the skill used in the creation of the pad.
		/// </summary>
		public Skill Skill { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="trigger"></param>
		/// <param name="creator"></param>
		/// <param name="skill"></param>
		public PadTriggerArgs(TriggerType type, Pad trigger, ICombatEntity creator, Skill skill)
		{
			this.Type = type;
			this.Trigger = trigger;
			this.Creator = creator;
			this.Skill = skill;
		}
	}

	/// <summary>
	/// The event arguments for pad trigger events.
	/// </summary>
	public class PadTriggerActorArgs : EventArgs
	{
		/// <summary>
		/// Returns how the trigger was triggered.
		/// </summary>
		public TriggerType Type { get; }

		/// <summary>
		/// Returns the pad that was triggered.
		/// </summary>
		public Pad Trigger { get; }

		/// <summary>
		/// Returns the triggering actor that triggered the triggerarable trigger
		/// in a most triggerable way. Trigger.
		/// </summary>
		public ICombatEntity Initiator { get; }

		/// <summary>
		/// Returns the actor that created the pad.
		/// </summary>
		public ICombatEntity Creator { get; }

		/// <summary>
		/// Returns the skill used in the creation of the pad.
		/// </summary>
		public Skill Skill { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="trigger"></param>
		/// <param name="initiator"></param>
		/// <param name="creator"></param>
		/// <param name="skill"></param>
		public PadTriggerActorArgs(TriggerType type, Pad trigger, ICombatEntity initiator, ICombatEntity creator, Skill skill)
		{
			this.Type = type;
			this.Trigger = trigger;
			this.Initiator = initiator;
			this.Creator = creator;
			this.Skill = skill;
		}
	}

	/// <summary>
	/// Defines how a trigger was triggered.
	/// </summary>
	public enum TriggerType
	{
		/// <summary>
		/// The trigger was created.
		/// </summary>
		Create,

		/// <summary>
		/// The trigger was destroyed.
		/// </summary>
		Destroy,

		/// <summary>
		/// An actor stepped into the trigger area.
		/// </summary>
		/// <remarks>
		/// Triggers only once per actor, when they initially enter the area.
		/// </remarks>
		Enter,

		/// <summary>
		/// An actor stepped out of the trigger area.
		/// </summary>
		/// <remarks>
		/// Triggers only once per actor, when they leave the area.
		/// </remarks>
		Leave,

		/// <summary>
		/// An update trigger that is raised in regular intervals while the
		/// trigger exists.
		/// </summary>
		/// <remarks>
		/// Triggers only once, regardless of the number of actors inside a
		/// trigger area. Use TriggerComponent.GetActors to retrieve a list
		/// of actors currently inside the area.
		/// </remarks>
		Update,
	}
}
