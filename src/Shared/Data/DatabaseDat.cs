using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace Melia.Shared.Data
{
	public abstract class DatabaseDatIndexed<TIndex, TInfo> : Database<Dictionary<TIndex, TInfo>, TInfo> where TInfo : class, new()
	{
		public override IEnumerator<TInfo> GetEnumerator()
		{
			return ((IEnumerable<TInfo>)this.Entries.Values).GetEnumerator();
		}

		public TInfo Find(TIndex key)
		{
			return this.Entries.GetValueOrDefault(key);
		}

		public bool TryFind(TIndex key, out TInfo result)
		{
			result = this.Entries.GetValueOrDefault(key);
			return result != null;
		}

		public override void Clear()
		{
			this.Entries.Clear();
		}

		public override int Load(string path, bool clear)
		{
			if (clear)
				this.Clear();

			var data = File.ReadAllBytes(path);

			using (var min = new MemoryStream(data))
			using (var mout = new MemoryStream())
			{
				using (var gzip = new GZipStream(min, CompressionMode.Decompress))
				{
					gzip.CopyTo(mout);
				}

				using (var br = new BinaryReader(mout))
				{
					br.BaseStream.Position = 0;
					while (br.BaseStream.Position < br.BaseStream.Length)
					{
						try
						{
							this.Read(br);
						}
						catch (DatabaseWarningException ex)
						{
							ex.Source = Path.GetFileName(path);
							this.Warnings.Add(ex);
							continue;
						}
					}
				}
			}

			return this.Count;
		}

		public override int Load(string[] files, string cache, bool clear)
		{
			if (files.Length > 0)
				this.Load(files[0], clear);

			return this.Count;
		}

		protected abstract void Read(BinaryReader br);
	}
}
