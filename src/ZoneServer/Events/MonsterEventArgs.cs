using System;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Events
{
	/// <summary>
	/// Arguments for events related to a monster.
	/// </summary>
	public class MonsterEventArgs : EventArgs
	{
		/// <summary>
		/// Returns the monster associated with the event.
		/// </summary>
		public IMonster Monster { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="monster"></param>
		public MonsterEventArgs(IMonster monster)
		{
			this.Monster = monster;
		}
	}
}
