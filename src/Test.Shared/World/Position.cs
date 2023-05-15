using Melia.Shared.World;
using Xunit;

namespace Melia.Test.Shared.World
{
	public class PositionTests
	{
		[Fact]
		public void GetRelative_Direction()
		{
			var pos1 = new Position(100, 0, 100);

			var pos2 = pos1.GetRelative(new Direction(0), 50);
			Assert.Equal(100, pos2.X);
			Assert.Equal(50, pos2.Z);

			pos2 = pos1.GetRelative(new Direction(90), 50);
			Assert.Equal(150, pos2.X);
			Assert.Equal(100, pos2.Z);

			pos2 = pos1.GetRelative(new Direction(180), 50);
			Assert.Equal(100, pos2.X);
			Assert.Equal(150, pos2.Z);

			pos2 = pos1.GetRelative(new Direction(270), 50);
			Assert.Equal(50, pos2.X);
			Assert.Equal(100, pos2.Z);

			pos2 = pos1.GetRelative(new Direction(360), 50);
			Assert.Equal(100, pos2.X);
			Assert.Equal(50, pos2.Z);
		}

		[Fact]
		public void GetRelative_Position()
		{
			var pos1 = new Position(100, 0, 100);

			var pos3 = pos1.GetRelative(new Position(100, 0, 50), 100);
			Assert.Equal(100, pos3.X);
			Assert.Equal(-50, pos3.Z);

			pos3 = pos1.GetRelative(new Position(150, 0, 100), 100);
			Assert.Equal(250, pos3.X);
			Assert.Equal(100, pos3.Z);

			pos3 = pos1.GetRelative(new Position(100, 0, 150), 100);
			Assert.Equal(100, pos3.X);
			Assert.Equal(250, pos3.Z);

			pos3 = pos1.GetRelative(new Position(50, 0, 100), 100);
			Assert.Equal(-50, pos3.X);
			Assert.Equal(100, pos3.Z);

			pos3 = pos1.GetRelative(new Position(100, 0, 50), 100);
			Assert.Equal(100, pos3.X);
			Assert.Equal(-50, pos3.Z);
		}

		[Fact]
		public void GetDirection()
		{
			var pos1 = new Position(100, 0, 100);

			var dir = pos1.GetDirection(new Position(100, 0, 50));
			Assert.Equal(0, dir.DegreeAngle);
			Assert.Equal(270, dir.NormalDegreeAngle);

			dir = pos1.GetDirection(new Position(150, 0, 100));
			Assert.Equal(90, dir.DegreeAngle);
			Assert.Equal(0, dir.NormalDegreeAngle);

			dir = pos1.GetDirection(new Position(100, 0, 150));
			Assert.Equal(180, dir.DegreeAngle);
			Assert.Equal(90, dir.NormalDegreeAngle);

			dir = pos1.GetDirection(new Position(50, 0, 100));
			Assert.Equal(270, dir.DegreeAngle);
			Assert.Equal(180, dir.NormalDegreeAngle);

			dir = pos1.GetDirection(new Position(100, 0, 50));
			Assert.Equal(0, dir.DegreeAngle);
			Assert.Equal(270, dir.NormalDegreeAngle);
		}
	}
}
