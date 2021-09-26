using System.IO;

namespace Melia.Shared.Data.Database
{
	public class GroundData
	{
		public string MapName { get; set; }
		public VertexData[] Vertices { get; set; }
		public VertexListData[] Triangles { get; set; }
		public VertexListData[] Cells { get; set; }
	}

	public class VertexData
	{
		public float X { get; set; }
		public float Y { get; set; }
		public float Z { get; set; }
	}

	public class VertexListData
	{
		public VertexData[] Vertices { get; set; }
	}

	public class GroundDb : DatabaseDatIndexed<string, GroundData>
	{
		protected override void Read(BinaryReader br)
		{
			var version = br.ReadInt32();

			var mapCount = br.ReadInt32();
			for (var i = 0; i < mapCount; ++i)
			{
				var data = new GroundData();
				data.MapName = br.ReadString();

				var vCount = br.ReadInt32();
				data.Vertices = new VertexData[vCount];

				for (var j = 0; j < vCount; ++j)
				{
					data.Vertices[j] = new VertexData
					{
						X = br.ReadSingle(),
						Y = br.ReadSingle(),
						Z = br.ReadSingle(),
					};
				}

				var tCount = br.ReadInt32();
				data.Triangles = new VertexListData[tCount];

				for (var j = 0; j < tCount; ++j)
				{
					data.Triangles[j] = new VertexListData();
					data.Triangles[j].Vertices = new VertexData[3];

					for (var k = 0; k < 3; ++k)
						data.Triangles[j].Vertices[k] = data.Vertices[br.ReadInt32()];
				}

				var cCount = br.ReadInt32();
				data.Cells = new VertexListData[cCount];

				for (var j = 0; j < cCount; ++j)
				{
					var count = br.ReadInt32();

					data.Cells[j] = new VertexListData();
					data.Cells[j].Vertices = new VertexData[count];

					for (var k = 0; k < count; ++k)
						data.Cells[j].Vertices[k] = data.Vertices[br.ReadInt32()];
				}

				Entries[data.MapName] = data;
			}
		}
	}
}
