using System;
using Melia.Shared.Scripting;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting.Dialogues;
using Yggdrasil.Geometry;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors.Monsters
{
	/// <summary>
	/// A non-player character that supports dialogues.
	/// </summary>
	public class Npc : MonsterInName, ITriggerableArea
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
		public DialogFunc EnterFunc { get; private set; }

		/// <summary>
		/// Returns the function called when someone steps out of the NPC's
		/// trigger area.
		/// </summary>
		public DialogFunc LeaveFunc { get; private set; }

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
		public void SetEnterTrigger(string name, DialogFunc func)
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
		public void SetLeaveTrigger(string name, DialogFunc func)
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
		DialogFunc EnterFunc { get; }

		/// <summary>
		/// Returns a function to call when someone leaves the area.
		/// </summary>
		DialogFunc LeaveFunc { get; }

		/// <summary>
		/// Area in which the enter and leave functions are triggered.
		/// </summary>
		IShapeF Area { get; }
	}
}
