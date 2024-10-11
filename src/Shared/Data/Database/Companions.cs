using System.Linq;
using Melia.Shared.Game.Const;
using Newtonsoft.Json.Linq;
using Yggdrasil.Data.JSON;

namespace Melia.Shared.Data.Database
{
	public class CompanionData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public float RideMSPD { get; set; }
		public bool IsPremium { get; set; }
		public bool CanPet { get; set; }
		public bool CanRide { get; set; }
		public bool EndRideOnHit { get; set; }
		public int FoodGroup { get; set; }
		public BuffId Buff { get; internal set; }
		public int Price { get; set; }
		public string FeedAnimation { get; set; }
		public int FeedSleep { get; set; }
		public bool IsRideOnly { get; set; }
	}
	public class CompanionDb : DatabaseJsonIndexed<int, CompanionData>
	{
		public bool TryFindByClassName(string className, out CompanionData data)
		{
			data = this.Entries.Values.FirstOrDefault(a => a.ClassName == className);
			return data != null;
		}

		protected override void ReadEntry(JObject entry)
		{
			// Values: id, className, name, rideMSPD, premium, pet, ride, endRideOnHit, [foodGroup], [buff]
			entry.AssertNotMissing("id", "className");

			var data = new CompanionData();

			data.Id = entry.ReadInt("id");
			data.ClassName = entry.ReadString("className");
			data.Name = entry.ReadString("name");
			if (entry.ContainsKey("price"))
				data.Price = entry.ReadInt("price");
			data.RideMSPD = entry.ReadFloat("rideMSPD");
			data.IsPremium = entry.ReadBool("premium");
			data.CanPet = entry.ReadBool("pet");
			data.CanRide = entry.ReadBool("ride");
			data.EndRideOnHit = entry.ReadBool("endRideOnHit");
			data.FoodGroup = entry.ReadInt("foodGroup", -1);
			if (entry.ContainsKey("buff") && !string.IsNullOrEmpty(data.Name))
				data.Buff = entry.ReadEnum<BuffId>("buff");
			data.FeedAnimation = entry.ReadInt("feedAnimation").ToString();
			data.FeedSleep = entry.ReadInt("feedSleep");

			this.Entries[data.Id] = data;
		}
	}
}
