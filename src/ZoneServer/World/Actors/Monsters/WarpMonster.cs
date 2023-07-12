using Melia.Shared.World;

namespace Melia.Zone.World.Actors.Monsters
{
	/// <summary>
	/// A monster that represents a warp to another map.
	/// </summary>
	public class WarpMonster : MonsterInName
	{
		/// <summary>
		/// The monster class id of a green arrow representing a warp.
		/// </summary>
		public const int WarpMonsterClassId = 40001;

		/// <summary>
		/// Returns the warp's name that can be used to identify it.
		/// </summary>
		public string WarpName { get; }

		/// <summary>
		/// Returns the location of the warp.
		/// </summary>
		public Location SourceLocation { get; }

		/// <summary>
		/// Returns the destination of the warp.
		/// </summary>
		public Location WarpLocation { get; }

		/// <summary>
		/// Creates new warp monster.
		/// </summary>
		/// <param name="warpName"></param>
		/// <param name="targetLocationName"></param>
		/// <param name="sourceLocation"></param>
		/// <param name="targetLocation"></param>
		/// <param name="direction"></param>
		public WarpMonster(string warpName, string targetLocationName, Location sourceLocation, Location targetLocation, Direction direction)
			: base(WarpMonsterClassId)
		{
			this.WarpName = warpName;
			this.Name = targetLocationName;
			this.Position = sourceLocation.Position;
			this.Direction = direction;
			this.SourceLocation = sourceLocation;
			this.WarpLocation = targetLocation;

			// RO-esque Warp:
			// Monster id 20050, Effect F_cleric_zemina_buff_blue
		}
	}
}
