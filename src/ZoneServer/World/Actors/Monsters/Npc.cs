using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting.Dialogues;

namespace Melia.Zone.World.Actors.Monsters
{
	/// <summary>
	/// A non-player character that supports dialogues.
	/// </summary>
	public class Npc : MonsterInName
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
		/// Returns the function to call when the NPC is interacted with.
		/// </summary>
		public DialogFunc DialogFunc { get; set; }

		/// <summary>
		/// Creates new NPC.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="name"></param>
		/// <param name="location"></param>
		/// <param name="direction"></param>
		/// <param name="dialogFunc"></param>
		public Npc(int monsterClassId, string name, Location location, Direction direction, DialogFunc dialogFunc = null)
			: base(monsterClassId)
		{
			this.Name = name;
			this.Position = location.Position;
			this.Direction = direction;
			this.DialogFunc = dialogFunc;

			if (this.DialogFunc != null)
				this.DialogName = "DYNAMIC";
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
	}
}
