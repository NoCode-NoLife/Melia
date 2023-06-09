using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Geometry;
using Yggdrasil.Geometry.Shapes;
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
		public static Npc AddNpc(int monsterId, string name, string map, double x, double z, double direction, DialogFunc dialog = null)
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

			var location = new Location(mapObj.Id, pos);
			var dir = new Direction(direction);

			var monster = new Npc(monsterId, name, location, dir, dialog);
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
		public static WarpMonster AddWarp(string warpName, double direction, Location from, Location to)
		{
			if (!ZoneServer.Instance.World.TryGetMap(from.MapId, out var fromMap))
				throw new ArgumentException($"Map '{from.MapId}' not found.");

			if (!ZoneServer.Instance.World.TryGetMap(to.MapId, out var toMap))
				throw new ArgumentException($"Map '{to.MapId}' not found.");

			// Get name, preferably a localization key
			var targetLocationName = toMap.Name;
			if (toMap.Data.LocalKey != "?")
				targetLocationName = Dialog.WrapLocalizationKey(toMap.Data.LocalKey);

			// Create a "warp monster"...
			var monster = new WarpMonster(warpName, targetLocationName, from, to, new Direction(direction));
			fromMap.AddMonster(monster);

			return monster;
		}

		/// <summary>
		/// Adds monster spawner to the world.
		/// </summary>
		/// <param name="monsterClassName"></param>
		/// <param name="amount"></param>
		/// <param name="respawn"></param>
		/// <param name="map"></param>
		/// <param name="area"></param>
		/// <param name="propertyOverrides"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		//public static MonsterSpawner AddSpawner(string monsterClassName, int amount, TimeSpan respawn, string map, IShape area, PropertyOverrides propertyOverrides = null)
		//{
		//	if (!ZoneServer.Instance.Data.MonsterDb.TryFind(a => a.ClassName == monsterClassName, out var monsterData))
		//		throw new ArgumentException($"Monster '{monsterClassName}' not found.");

		//	return AddSpawner(monsterData.Id, amount, respawn, map, area, tendency, propertyOverrides);
		//}

		/// <summary>
		/// Adds monster spawner to the world.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="amount"></param>
		/// <param name="respawn"></param>
		/// <param name="map"></param>
		/// <param name="area"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static MonsterSpawner AddSpawner(int monsterClassId, int amount, TimeSpan respawn, string map, IShape area)
			=> AddSpawner(monsterClassId, amount, respawn, map, area, TendencyType.Peaceful, null);

		/// <summary>
		/// Adds monster spawner to the world.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="amount"></param>
		/// <param name="respawn"></param>
		/// <param name="map"></param>
		/// <param name="area"></param>
		/// <param name="tendency"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static MonsterSpawner AddSpawner(int monsterClassId, int amount, TimeSpan respawn, string map, IShape area, TendencyType tendency)
			=> AddSpawner(monsterClassId, amount, respawn, map, area, tendency, null);

		/// <summary>
		/// Adds monster spawner to the world.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="amount"></param>
		/// <param name="respawn"></param>
		/// <param name="map"></param>
		/// <param name="area"></param>
		/// <param name="propertyOverrides"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static MonsterSpawner AddSpawner(int monsterClassId, int amount, TimeSpan respawn, string map, IShape area, PropertyOverrides propertyOverrides)
			=> AddSpawner(monsterClassId, amount, respawn, map, area, TendencyType.Peaceful, propertyOverrides);

		/// <summary>
		/// Adds monster spawner to the world.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="amount"></param>
		/// <param name="respawn"></param>
		/// <param name="map"></param>
		/// <param name="area"></param>
		/// <param name="tendency"></param>
		/// <param name="propertyOverrides"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static MonsterSpawner AddSpawner(int monsterClassId, int amount, TimeSpan respawn, string map, IShape area, TendencyType tendency, PropertyOverrides propertyOverrides)
		{
			if (!ZoneServer.Instance.World.TryGetMap(map, out var mapObj))
				throw new ArgumentException($"Map '{map}' not found.");

			var initialSpawnDelay = TimeSpan.Zero;
			var minRespawnDelay = respawn;
			var maxRespawnDelay = respawn.Add(TimeSpan.FromMilliseconds(2000));

			var spawner = new MonsterSpawner(monsterClassId, amount, map, area, initialSpawnDelay, minRespawnDelay, maxRespawnDelay, tendency, propertyOverrides);
			mapObj.AddSpawner(spawner);

			return spawner;
		}

		/// <summary>
		/// Returns a polygonal shape made up of the given coordinates.
		/// </summary>
		/// <param name="coordinates">Evenly numbered list of at least 3 X and Y coordinates.</param>
		/// <returns></returns>
		/// <example>
		/// Area(0, 0, 0, 10, 10, 10, 10, 0) // 10x10 square
		/// </example>
		public static IShape Area(params double[] coordinates)
		{
			if (coordinates.Length == 0 || coordinates.Length % 2 != 0)
				throw new ArgumentException("Expected an even amount of coordinates for area.");

			if (coordinates.Length < 3)
				throw new ArgumentException("Needs at least 3 points (6 X/Y coordinates).");

			var points = new List<Vector2>();
			for (var i = 0; i < coordinates.Length;)
			{
				var point = new Vector2((int)coordinates[i++], (int)coordinates[i++]);
				points.Add(point);
			}

			return new Polygon(points);
		}

		/// <summary>
		/// Returns a circular shape with the given coordinates and radius.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="radius"></param>
		/// <returns></returns>
		public static IShape Spot(double x, double y, double radius = 0)
		{
			var center = new Vector2((int)x, (int)y);
			return new Yggdrasil.Geometry.Shapes.Circle(center, (int)radius);
		}

		/// <summary>
		/// Returns a rectangular shape with the given coordinates and radius.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <returns></returns>
		public static IShape Rectangle(double x, double y, double width, double height = 0)
		{
			var center = new Vector2((int)x, (int)y);
			var size = new Vector2((int)width, (int)(height != 0 ? height : width));
			return Yggdrasil.Geometry.Shapes.Rectangle.Centered(center, size);
		}

		/// <summary>
		/// Returns a list of named properties based on a list of key/value
		/// pairs.
		/// </summary>
		/// <example>
		/// Properties("MHP", 1000, "EXP", 5) // { "MHP": 1000, "EXP": 5 }
		/// </example>
		/// <param name="properties"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public static PropertyOverrides Properties(params object[] properties)
		{
			var result = new PropertyOverrides();

			if (properties.Length % 2 != 0)
				throw new ArgumentException("Expected an even amount of arguments for key/value pairs.");

			for (var i = 0; i < properties.Length; i += 2)
			{
				var propertyNameObj = properties[i];
				var propertyValueObj = properties[i + 1];

				if (!(propertyNameObj is string propertyName))
					throw new ArgumentException($"Expected a string for key, got '{propertyValueObj.GetType().Name}'.");

				switch (propertyValueObj)
				{
					case int _:
					case float _:
					case string _:
						result[propertyName] = propertyValueObj;
						break;

					default:
						throw new ArgumentException($"Expected an int, float or string for value, got '{propertyValueObj.GetType().Name}'.");
				}
			}

			return result;
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
		public static async Task OpenChest(Character character, Npc npc)
		{
			//if (character.Help.NotSeen(34))
			//	Send.ZC_HELP_ADD(character, 34, 1);

			// Play animations for character to kick open the chest
			Send.ZC_PLAY_ANI(character, AnimationName.KickBox);
			Send.ZC_PLAY_ANI(npc, AnimationName.Opened, true);

			// Wait a second, so the animations can play
			await Task.Delay(1000);

			// Make chest disappear
			Send.ZC_NORMAL.FadeOut(npc, TimeSpan.FromSeconds(4));
			npc.SetState(NpcState.Invisible);

			// Make chest reappear after a certain amount of time
			// TODO: Add timer component, to set up and associate timers
			//   and intervals with entities.
			_ = Task.Delay(TimeSpan.FromMinutes(1)).ContinueWith(_ => npc.SetState(NpcState.Normal));
		}
	}

	/// <summary>
	/// A list of properties that can be used to override default values
	/// for spawned monsters.
	/// </summary>
	public class PropertyOverrides : Dictionary<string, object>
	{
	}
}
