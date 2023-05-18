using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World.Entities;
using Yggdrasil.Util;

namespace Melia.Zone.Scripting
{
	public static class Shortcuts
	{
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
			=> new DialogOption(text, key);

		/// <summary>
		/// Returns a localized version of the given string.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public static string L(string key)
			=> Localization.Get(key);

		/// <summary>
		/// Returns a localized version of the given string, formatted
		/// with the optional arguments.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		public static string LF(string key, params object[] args)
			=> string.Format(Localization.Get(key), args);

		/// <summary>
		/// Returns a localized plural version of the given string.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="keyPlural"></param>
		/// <param name="n"></param>
		/// <returns></returns>
		public static string LN(string key, string keyPlural, int n)
			=> Localization.GetPlural(key, keyPlural, n);

		/// <summary>
		/// Returns a localized plural version of the given string,
		/// formatted with the optional arguments.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="keyPlural"></param>
		/// <param name="n"></param>
		/// <param name="args"></param>
		/// <returns></returns>
		public static string LNF(string key, string keyPlural, int n, params object[] args)
			=> string.Format(Localization.GetPlural(key, keyPlural, n), args);

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
		public static Monster AddNpc(int monsterId, string name, string map, double x, double z, double direction, DialogFunc dialog = null)
		{
			if (!ZoneServer.Instance.World.TryGetMap(map, out var mapObj))
				throw new ArgumentException($"Map '{map}' not found.");

			var pos = new Position((float)x, 0, (float)z);
			if (mapObj.Ground.TryGetHeightAt(pos, out var height))
				pos.Y = height;

			// Wrap name in localization code if applicable
			if (Dialog.IsLocalizationKey(name))
			{
				name = Dialog.WrapLocalizationKey(name);
			}
			// Insert line breaks in tagged NPC names that don't have one
			else if (name.StartsWith("[") && !name.Contains("{nl}"))
			{
				var endIndex = name.LastIndexOf("] ");
				if (endIndex != -1)
				{
					// Remove space and insert new line instead.
					name = name.Remove(endIndex + 1, 1);
					name = name.Insert(endIndex + 1, "{nl}");
				}
			}

			var monster = new Monster(monsterId, NpcType.NPC);
			monster.Name = name;
			monster.DialogName = dialog != null ? "DYNAMIC" : null;
			monster.DialogFunc = dialog;
			monster.Position = pos;
			monster.Direction = new Direction(direction);
			monster.Faction = FactionType.Peaceful;

			mapObj.AddMonster(monster);

			return monster;
		}

		/// <summary>
		/// Creates a warp.
		/// </summary>
		/// <param name="warpName"></param>
		/// <param name="direction"></param>
		/// <param name="from"></param>
		/// <param name="to"></param>
		/// <returns></returns>
		public static Monster AddWarp(string warpName, double direction, Location from, Location to)
		{
			if (!ZoneServer.Instance.World.TryGetMap(from.MapId, out var fromMap))
				throw new ArgumentException($"Map '{from.MapId}' not found.");

			if (!ZoneServer.Instance.World.TryGetMap(to.MapId, out var toMap))
				throw new ArgumentException($"Map '{to.MapId}' not found.");

			// Get name, preferably a localization key
			var name = toMap.Name;
			if (toMap.Data.LocalKey != "?")
				name = Dialog.WrapLocalizationKey(toMap.Data.LocalKey);

			// Create a "warp monster"...
			var monster = new Monster(40001, NpcType.NPC);
			monster.Name = name;
			monster.WarpName = warpName;
			monster.Position = from.Position;
			monster.Direction = new Direction(direction);
			monster.WarpLocation = to;
			monster.Faction = FactionType.Peaceful;

			fromMap.AddMonster(monster);

			return monster;
		}

		/// <summary>
		/// Returns a full location object from the given map and coordinates.
		/// </summary>
		/// <param name="map"></param>
		/// <param name="x"></param>
		/// <param name="z"></param>
		/// <returns></returns>
		public static Location From(string map, double x, double z)
			=> GetLocation(map, x, z);

		/// <summary>
		/// Returns a full location object from the given map and coordinates.
		/// </summary>
		/// <param name="map"></param>
		/// <param name="x"></param>
		/// <param name="z"></param>
		/// <returns></returns>
		public static Location To(string map, double x, double z)
			=> GetLocation(map, x, z);

		/// <summary>
		/// Returns a full location object from the given map and coordinates.
		/// </summary>
		/// <param name="map"></param>
		/// <param name="x"></param>
		/// <param name="z"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		private static Location GetLocation(string map, double x, double z)
		{
			if (!ZoneServer.Instance.World.TryGetMap(map, out var mapObj))
				throw new ArgumentException($"Map '{map}' not found.");

			var pos = new Position((float)x, 0, (float)z);
			if (mapObj.Ground.TryGetHeightAt(pos, out var height))
				pos.Y = height;

			return new Location(mapObj.Id, pos);
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
		/// Returns a random number between 0 and max - 1.
		/// </summary>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int Random(int max)
		{
			return RandomProvider.Next(max);
		}

		/// <summary>
		/// Returns a random number between min and max - 1.
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int Random(int min, int max)
		{
			return RandomProvider.Next(min, max);
		}

		/// <summary>
		/// Plays chest opening animations and makes the chest disappear.
		/// Returns after the animation played and the chest's contents
		/// can be distributed.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="npc"></param>
		/// <returns></returns>
		public static async Task OpenChest(Character character, Monster npc)
		{
			// Play animations for character to kick open the chest
			Send.ZC_PLAY_ANI(character, AnimationName.KickBox);
			Send.ZC_PLAY_ANI(npc, AnimationName.Opened, true);

			// Wait a second, so the animations can play
			await Task.Delay(1000);

			// Make chest disappear
			Send.ZC_NORMAL_FadeOut(npc, TimeSpan.FromSeconds(4));
			npc.SetState(MonsterState.Invisible);

			// Make chest reappear after a certain amount of time
			// TODO: Add timer component, to set up and associate timers
			//   and intervals with entities.
			_ = Task.Delay(TimeSpan.FromMinutes(1)).ContinueWith(_ => npc.SetState(MonsterState.Normal));
		}
	}
}
