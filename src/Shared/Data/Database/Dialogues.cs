using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class DialogData
	{
		public int ClassId { get; set; }
		public string ClassName { get; set; }
		public string Image { get; set; }
	}

	/// <summary>
	/// Dialog database.
	/// </summary>
	public class DialogDb : DatabaseJsonIndexed<string, DialogData>
	{
		private readonly Dictionary<string, string> _img2cls = new Dictionary<string, string>();

		/// <summary>
		/// Returns a class name for the given image name via out if one
		/// exists. Returns false if no valid entry was found.
		/// </summary>
		/// <param name="imageName"></param>
		/// <param name="className"></param>
		/// <returns></returns>
		public bool TryGetClass(string imageName, out string className)
			=> _img2cls.TryGetValue(imageName, out className);

		/// <summary>
		/// Reads given entry and adds it to the database.
		/// </summary>
		/// <param name="entry"></param>
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("classId", "className");

			var data = new DialogData();

			data.ClassId = entry.ReadInt("classId");
			data.ClassName = entry.ReadString("className");
			data.Image = entry.ReadString("image", null);

			this.Add(data.ClassName, data);

			if (data.Image != null && !_img2cls.ContainsKey(data.Image))
				_img2cls.Add(data.Image, data.ClassName);
		}
	}
}
