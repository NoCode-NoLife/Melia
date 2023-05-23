using Melia.Shared.World;

namespace Melia.Zone.World.Actors.Monsters
{
	public class WarpMonster : MonsterInName
	{
		public const int WarpMonsterClassId = 40001;

		public string WarpName { get; }

		public Location SourceLocation { get; }
		public Location WarpLocation { get; }

		public WarpMonster(string warpName, string targetLocationName, Location sourceLocation, Location targetLocation, Direction direction)
			: base(WarpMonsterClassId)
		{
			this.WarpName = warpName;
			this.Name = targetLocationName;
			this.Position = sourceLocation.Position;
			this.Direction = direction;
			this.SourceLocation = sourceLocation;
			this.WarpLocation = targetLocation;
		}
	}
}
