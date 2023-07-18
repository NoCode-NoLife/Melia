using System;
using System.Drawing;
using System.IO;
using System.Linq;
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
		/// <param name="edgePoints"></param>
		/// <param name="rangePreview"></param>
		public static void ShowShape(Map map, IShapeF shape, TimeSpan? duration = null, bool edgePoints = true, bool rangePreview = true)
		{
			if (duration == null)
				duration = TimeSpan.FromSeconds(5);

			if (edgePoints)
			{
				foreach (var point in shape.GetEdgePoints())
				{
					var pos = new Position(point.X, 0, point.Y);
					var height = map.Ground.GetHeightAt(pos);
					pos.Y = height;

					var monster = new Mob(41094, MonsterType.NPC);
					monster.Position = pos;
					monster.DisappearTime = DateTime.Now.Add((TimeSpan)duration);
					map.AddMonster(monster);
				}
			}

			if (rangePreview)
			{
				if (shape is ISplashArea splashArea)
					Send.ZC_START_RANGE_PREVIEW(map, 0, null, (TimeSpan)duration, splashArea);
			}
		}

		/// <summary>
		/// Temporarily places a monster at the given position.
		/// </summary>
		/// <param name="map"></param>
		/// <param name="pos"></param>
		/// <param name="duration"></param>
		public static void ShowPosition(Map map, Position pos, TimeSpan? duration = null)
		{
			if (duration == null)
				duration = TimeSpan.FromSeconds(5);

			var monster = new Mob(10005, MonsterType.Friendly);
			monster.Position = pos;
			monster.DisappearTime = DateTime.Now.Add((TimeSpan)duration);
			map.AddMonster(monster);
		}

		/// <summary>
		/// Creates an image of the map's ground and saves it to the given
		/// file path to help visualize potential problems.
		/// </summary>
		/// <param name="filePath"></param>
		/// <param name="map"></param>
		public static void DrawMap(string filePath, Map map)
		{
			var drawBorderBoxes = false;
			var drawCellsColored = false;
			var drawTriangles = false;
			var drawSpawners = true;

			var borderBoxColorOffset = 0x30;
			var imageMarginSize = 100;

			var mapClassName = map.Data.ClassName;
			var groundData = ZoneServer.Instance.Data.GroundDb.Find(mapClassName);

			var vertices = groundData.Vertices;
			var triangles = groundData.Triangles;
			var polygons = groundData.Cells;

			var left = (int)vertices.Min(a => a.X);
			var right = (int)vertices.Max(a => a.X);
			var bottom = (int)vertices.Min(a => a.Y);
			var top = (int)vertices.Max(a => a.Y);

			var width = right - left + imageMarginSize * 2;
			var height = top - bottom + imageMarginSize * 2;
			var offsetX = -left + imageMarginSize;
			var offsetY = -bottom + imageMarginSize;

			var bmp = new Bitmap(width, height);
			var rnd = new Random(123456);
			var font16 = new Font("Arial", 16);
			var font24 = new Font("Arial", 24);

			using (var gfx = Graphics.FromImage(bmp))
			{
				gfx.FillRectangle(Brushes.White, 0, 0, bmp.Width, bmp.Height);
				gfx.DrawString(mapClassName, font24, Brushes.Black, 20, 20);
				gfx.DrawString(string.Format("{0}/{1}", width, height), font24, Brushes.Black, 20, 20 + font24.Height);

				foreach (var polygon in polygons)
				{
					var r = rnd.Next(0x77, 0xDD);
					var g = rnd.Next(0x77, 0xDD);
					var b = rnd.Next(0x77, 0xDD);
					var brush = new SolidBrush(Color.FromArgb(255, r, g, b));

					if (!drawCellsColored)
						brush = new SolidBrush(Color.FromArgb(255, 207, 181, 118));

					var points = polygon.Vertices.Select(a => new PointF(a.X + offsetX, bmp.Height - (offsetY + a.Y))).ToArray();
					gfx.FillPolygon(brush, points);

					if (drawBorderBoxes)
					{
						var minX = points.Min(a => a.X);
						var maxX = points.Max(a => a.X);
						var minY = points.Min(a => a.Y);
						var maxY = points.Max(a => a.Y);

						gfx.DrawRectangle(new Pen(Color.FromArgb(255, r - borderBoxColorOffset, g - borderBoxColorOffset, b - borderBoxColorOffset)), minX, minY, maxX - minX, maxY - minY);
					}
				}

				if (drawTriangles)
				{
					foreach (var triangle in triangles)
					{
						var points = triangle.Vertices.Select(a => new PointF(a.X + offsetX, bmp.Height - (offsetY + a.Y))).ToArray();
						gfx.DrawPolygon(Pens.Black, points);

					}
				}

				if (drawSpawners)
				{
					var brush = new SolidBrush(Color.FromArgb(128, 255, 0, 0));
					var pen = new Pen(Color.FromArgb(255, 255, 0, 0));

					var spawnAreasList = ZoneServer.Instance.World.GetSpawnAreas();
					var collectionsInMap = spawnAreasList.Where(a => a.GetAllOnMap(map).Any()).ToList();

					foreach (var collection in collectionsInMap)
					{
						var spawnAreas = collection.GetAllOnMap(map);
						foreach (var spawnArea in spawnAreas)
						{
							var points = spawnArea.Area.GetEdgePoints().Select(a => new PointF(a.X + offsetX, bmp.Height - (offsetY + a.Y))).ToArray();
							gfx.FillPolygon(brush, points);
							gfx.DrawPolygon(pen, points);

						}
					}
				}

				var folderPath = Path.GetDirectoryName(filePath);
				if (!Directory.Exists(folderPath))
					Directory.CreateDirectory(folderPath);

				bmp.Save(filePath);
			}
		}
	}
}
