using System;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Maps;
using Yggdrasil.Geometry;

namespace Melia.Zone
{
	public static class Debug
	{
		/// <summary>
		/// Temporarily visualizes the shape on the map using friendly
		/// monsters and range previews.
		/// </summary>
		/// <param name="map"></param>
		/// <param name="shape"></param>
		/// <param name="duration"></param>
		public static void ShowShape(Map map, IShapeF shape, TimeSpan? duration = null)
		{
			if (duration == null)
				duration = TimeSpan.FromSeconds(5);

			foreach (var point in shape.GetEdgePoints())
			{
				var pos = new Position(point.X, 0, point.Y);
				var height = map.Ground.GetHeightAt(pos);
				pos.Y = height;

				var monster = new Mob(10005, MonsterType.Friendly);
				monster.Position = pos;
				monster.DisappearTime = DateTime.Now.Add((TimeSpan)duration);
				map.AddMonster(monster);
			}

			if (shape is ISplashArea splashArea)
				Send.ZC_START_RANGE_PREVIEW(map, 0, null, (TimeSpan)duration, splashArea);
		}
	}
}
