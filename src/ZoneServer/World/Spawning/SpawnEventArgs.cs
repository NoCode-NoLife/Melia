using System;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.World.Spawning
{
	public class SpawnEventArgs : EventArgs
	{
		/// <summary>
		/// Returns the spawner that is spawning the monster.
		/// </summary>
		public MonsterSpawner Spawner { get; }

		/// <summary>
		/// Returns the monster that is being spawned.
		/// </summary>
		public Mob Monster { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="spawner"></param>
		/// <param name="monster"></param>
		public SpawnEventArgs(MonsterSpawner spawner, Mob monster)
		{
			this.Monster = monster;
		}
	}
}
