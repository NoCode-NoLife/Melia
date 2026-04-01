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

			var pos2 = pos1.GetRelative2D(new Direction(0), 50);
			Assert.Equal(100, pos2.X);
			Assert.Equal(50, pos2.Z);

			pos2 = pos1.GetRelative2D(new Direction(90), 50);
			Assert.Equal(150, pos2.X);
			Assert.Equal(100, pos2.Z);

			pos2 = pos1.GetRelative2D(new Direction(180), 50);
			Assert.Equal(100, pos2.X);
			Assert.Equal(150, pos2.Z);

			pos2 = pos1.GetRelative2D(new Direction(270), 50);
			Assert.Equal(50, pos2.X);
			Assert.Equal(100, pos2.Z);

			pos2 = pos1.GetRelative2D(new Direction(360), 50);
			Assert.Equal(100, pos2.X);
			Assert.Equal(50, pos2.Z);
		}

		[Fact]
		public void GetRelative2D()
		{
			var pos1 = new Position(100, 0, 100);

			var pos3 = pos1.GetRelative2D(new Position(100, 0, 50), 100);
			Assert.Equal(100, pos3.X);
			Assert.Equal(-50, pos3.Z);

			pos3 = pos1.GetRelative2D(new Position(150, 0, 100), 100);
			Assert.Equal(250, pos3.X);
			Assert.Equal(100, pos3.Z);

			pos3 = pos1.GetRelative2D(new Position(100, 0, 150), 100);
			Assert.Equal(100, pos3.X);
			Assert.Equal(250, pos3.Z);

			pos3 = pos1.GetRelative2D(new Position(50, 0, 100), 100);
			Assert.Equal(-50, pos3.X);
			Assert.Equal(100, pos3.Z);

			pos3 = pos1.GetRelative2D(new Position(100, 0, 50), 100);
			Assert.Equal(100, pos3.X);
			Assert.Equal(-50, pos3.Z);
		}

		[Fact]
		public void GetRelative3D()
		{
			var pos1 = new Position(100, 0, 100);

			var pos3 = pos1.GetRelative3D(new Position(100, 0, 50), 100);
			Assert.Equal(100, pos3.X);
			Assert.Equal(-50, pos3.Z);

			pos3 = pos1.GetRelative3D(new Position(150, 0, 100), 100);
			Assert.Equal(250, pos3.X);
			Assert.Equal(100, pos3.Z);

			pos3 = pos1.GetRelative3D(new Position(100, 0, 150), 100);
			Assert.Equal(100, pos3.X);
			Assert.Equal(250, pos3.Z);

			pos3 = pos1.GetRelative3D(new Position(50, 0, 100), 100);
			Assert.Equal(-50, pos3.X);
			Assert.Equal(100, pos3.Z);

			pos3 = pos1.GetRelative3D(new Position(100, 0, 50), 100);
			Assert.Equal(100, pos3.X);
			Assert.Equal(-50, pos3.Z);

			var pos4 = new Position(0, 0, 0);
			var pos5 = new Position(20, 30, 60);

			var pos6 = pos4.GetRelative3D(pos5, 0);
			Assert.Equal(20, pos6.X, 0.001);
			Assert.Equal(30, pos6.Y, 0.001);
			Assert.Equal(60, pos6.Z, 0.001);

			var pos7 = pos4.GetRelative3D(pos5, 70);
			Assert.Equal(40, pos7.X, 0.001);
			Assert.Equal(60, pos7.Y, 0.001);
			Assert.Equal(120, pos7.Z, 0.001);

			var pos8 = pos4.GetRelative3D(pos5, 140);
			Assert.Equal(60, pos8.X, 0.001);
			Assert.Equal(90, pos8.Y, 0.001);
			Assert.Equal(180, pos8.Z, 0.001);
		}

		[Fact]
		public void GetDirection()
		{
			var pos1 = new Position(100, 0, 100);

			var dir = pos1.GetDirection(new Position(100, 0, 50));
			Assert.Equal(0, dir.DegreeAngle);
			Assert.Equal(270, dir.NormalDegreeAngle, 0.001);

			dir = pos1.GetDirection(new Position(150, 0, 100));
			Assert.Equal(90, dir.DegreeAngle);
			Assert.Equal(0, dir.NormalDegreeAngle, 0.001);

			dir = pos1.GetDirection(new Position(100, 0, 150));
			Assert.Equal(180, dir.DegreeAngle);
			Assert.Equal(90, dir.NormalDegreeAngle, 0.001);

			dir = pos1.GetDirection(new Position(50, 0, 100));
			Assert.Equal(270, dir.DegreeAngle);
			Assert.Equal(180, dir.NormalDegreeAngle, 0.001);

			dir = pos1.GetDirection(new Position(100, 0, 50));
			Assert.Equal(0, dir.DegreeAngle);
			Assert.Equal(270, dir.NormalDegreeAngle, 0.001);
		}
	}
}
