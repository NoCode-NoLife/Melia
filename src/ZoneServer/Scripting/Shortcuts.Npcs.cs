using System;
using System.Threading;
using Melia.Shared.World;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Scripting
{
	public static partial class Shortcuts
	{
		private static long UniqueNpcNameId = 0;

		/// <summary>
		/// A function that initializes a shop.
		/// </summary>
		/// <param name="shop"></param>
		public delegate void ShopCreationFunc(ShopBuilder shop);

		/// <summary>
		/// Returns an option element, to be used with the Menu function.
		/// </summary>
		/// <param name="text">Text to display in the menu.</param>
		/// <param name="key">Key to return if the option was selected.</param>
		/// <returns></returns>
		public static DialogOption Option(string text, string key)
			=> new(text, key);

		/// <summary>
		/// Adds new NPC to the world.
		/// </summary>
		/// <param name="monsterId"></param>
		/// <param name="name"></param>
		/// <param name="map"></param>
		/// <param name="x"></param>
		/// <param name="z"></param>
		/// <param name="direction"></param>
		/// <param name="dialog"></param>
		/// <exception cref="ArgumentException"></exception>
		public static Npc AddNpc(int monsterId, string name, string map, double x, double z, double direction, DialogFunc dialog = null)
		{
			var uniqueId = Interlocked.Increment(ref UniqueNpcNameId);
			var uniqueName = $"__NPC{uniqueId}__";

			return AddNpc(monsterId, name, uniqueName, map, x, z, direction, dialog);
		}

		/// <summary>
		/// Adds new NPC to the world.
		/// </summary>
		/// <param name="monsterId"></param>
		/// <param name="name"></param>
		/// <param name="uniqueName"></param>
		/// <param name="map"></param>
		/// <param name="x"></param>
		/// <param name="z"></param>
		/// <param name="direction"></param>
		/// <param name="dialog"></param>
		/// <exception cref="ArgumentException"></exception>
		public static Npc AddNpc(int monsterId, string name, string uniqueName, string map, double x, double z, double direction, DialogFunc dialog = null)
		{
			if (!ZoneServer.Instance.World.TryGetMap(map, out var mapObj))
				throw new ArgumentException($"Map '{map}' not found.");

			if (ZoneServer.Instance.World.TryGetMonster(a => a.UniqueName == uniqueName, out _))
				throw new ArgumentException($"An NPC with the unique name '{uniqueName}' already exists.");

			var pos = new Position((float)x, 0, (float)z);
			if (mapObj.Ground.TryGetHeightAt(pos, out var height))
				pos.Y = height;

			// Wrap name in localization code if applicable
			if (Dialog.IsLocalizationKey(name))
			{
				name = Dialog.WrapLocalizationKey(name);
			}
			// Insert line breaks in tagged NPC names that don't have one
			else if (name.StartsWith('[') && !name.Contains("{nl}"))
			{
				var endIndex = name.LastIndexOf("] ");
				if (endIndex != -1)
				{
					// Remove space and insert new line instead.
					name = name.Remove(endIndex + 1, 1);
					name = name.Insert(endIndex + 1, "{nl}");
				}
			}

			var location = new Location(mapObj.Id, pos);
			var dir = new Direction(direction);

			var monster = new Npc(monsterId, name, location, dir);
			monster.UniqueName = uniqueName;

			if (dialog != null)
				monster.SetClickTrigger("DYNAMIC_DIALOG", dialog);

			mapObj.AddMonster(monster);

			return monster;
		}

		/// <summary>
		/// Creates a custom shop.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="creationFunc"></param>
		public static void CreateShop(string name, ShopCreationFunc creationFunc)
		{
			var shopBuilder = new ShopBuilder(name);
			creationFunc(shopBuilder);

			// TODO: Not a big fan of dynamically modifying the data.
			//   Perhaps we should create shop objects based on the
			//   data and add to that, where we could also do more
			//   things without poluting the data classes.

			var shopData = shopBuilder.Build();
			ZoneServer.Instance.Data.ShopDb.AddOrReplace(shopData.Name, shopData);
		}

		/// <summary>
		/// A function that initializes a companion shop.
		/// </summary>
		/// <param name="shop"></param>
		public delegate void CompanionShopCreationFunc(CompanionShopBuilder shop);

		/// <summary>
		/// Creates a custom companion shop.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="creationFunc"></param>
		public static void CreateCompanionShop(string name, CompanionShopCreationFunc creationFunc)
		{
			var shopBuilder = new CompanionShopBuilder(name);
			creationFunc(shopBuilder);

			var shopData = shopBuilder.Build();
			ZoneServer.Instance.Data.CompanionShopDb.AddOrReplace(shopData.Name, shopData);
		}
	}
}
