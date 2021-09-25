using System;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class AnimationIdData
	{
		public string Name { get; set; }
		public int Id { get; set; }
	}

	/// <summary>
	/// Animation id database, for lookup of animation ids based on
	/// their name.
	/// </summary>
	public class AnimationIdDb : DatabaseJsonIndexed<string, AnimationIdData>
	{
		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("name", "id");

			var data = new AnimationIdData();

			data.Name = entry.ReadString("name");
			data.Id = entry.ReadInt("id");

			this.Entries[data.Name] = data;
		}
	}
}
