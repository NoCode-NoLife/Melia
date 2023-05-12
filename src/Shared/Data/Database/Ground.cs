using System.IO;
using System.IO.Compression;
using Yggdrasil.Data.Binary;

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
		public int[] Indices { get; set; }
		public VertexData[] Vertices { get; set; }
	}

	public class GroundDb : DatabaseBinaryIndexed<string, GroundData>
	{
		protected override void Read(FileStream fs)
		{
			using (var brfs = new BinaryReader(fs))
			{
				var header = brfs.ReadBytes(4);
				var version = brfs.ReadInt32();
				var compressed = brfs.ReadBoolean();
				var mapCount = brfs.ReadInt32();

				this.ReadMaps(brfs, compressed, mapCount);
			}
		}

		private void ReadMaps(BinaryReader brfs, bool compressed, int mapCount)
		{
			for (var i = 0; i < mapCount; ++i)
			{
				var length = brfs.ReadInt32();
				var bytes = brfs.ReadBytes(length);

				if (compressed)
				{
					using (var msCompressed = new MemoryStream(bytes))
					using (var msUncompressed = new MemoryStream())
					using (var ds = new DeflateStream(msCompressed, CompressionMode.Decompress, true))
					{
						ds.CopyTo(msUncompressed);
						bytes = msUncompressed.ToArray();
					}
				}

				using (var ms = new MemoryStream(bytes))
				using (var brms = new BinaryReader(ms))
					this.ReadMap(brms);
			}
		}

		private void ReadMap(BinaryReader brms)
		{
			var data = new GroundData();

			data.MapName = brms.ReadString();

			var vertexCount = brms.ReadInt32();
			data.Vertices = new VertexData[vertexCount];

			for (var j = 0; j < vertexCount; ++j)
			{
				data.Vertices[j] = new VertexData
				{
					X = brms.ReadSingle(),
					Y = brms.ReadSingle(),
					Z = brms.ReadSingle(),
				};
			}

			var triangleCount = brms.ReadInt32();
			data.Triangles = new VertexListData[triangleCount];

			for (var j = 0; j < triangleCount; ++j)
			{
				data.Triangles[j] = new VertexListData();
				data.Triangles[j].Indices = new int[3];
				data.Triangles[j].Vertices = new VertexData[3];

				for (var k = 0; k < 3; ++k)
				{
					var index = brms.ReadInt32();
					data.Triangles[j].Indices[k] = index;
					data.Triangles[j].Vertices[k] = data.Vertices[index];
				}
			}

			var cellsCount = brms.ReadInt32();
			data.Cells = new VertexListData[cellsCount];

			for (var j = 0; j < cellsCount; ++j)
			{
				var count = brms.ReadInt32();

				data.Cells[j] = new VertexListData();
				data.Cells[j].Indices = new int[count];
				data.Cells[j].Vertices = new VertexData[count];

				for (var k = 0; k < count; ++k)
				{
					var index = brms.ReadInt32();
					data.Cells[j].Indices[k] = index;
					data.Cells[j].Vertices[k] = data.Vertices[index];
				}
			}

			this.AddOrReplace(data.MapName, data);
		}
	}
}
