using Melia.Shared.World;
using Xunit;

namespace Melia.Test.Shared.World
{
	public class DirectionTests
	{
		[Fact]
		public void DegreeAngles()
		{
			Assert.Equal(0, new Direction(0).DegreeAngle);
			Assert.Equal(90, new Direction(90).DegreeAngle);
			Assert.Equal(180, new Direction(180).DegreeAngle);
			Assert.Equal(270, new Direction(270).DegreeAngle);
			Assert.Equal(0, new Direction(360).DegreeAngle);
		}

		[Fact]
		public void GetNormal()
		{
			Assert.Equal(270, new Direction(0).GetNormal().DegreeAngle);
			Assert.Equal(0, new Direction(90).GetNormal().DegreeAngle);
			Assert.Equal(90, new Direction(180).GetNormal().DegreeAngle);
			Assert.Equal(180, new Direction(270).GetNormal().DegreeAngle);
			Assert.Equal(270, new Direction(360).GetNormal().DegreeAngle);
		}
	}
}
