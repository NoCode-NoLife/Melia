using System;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World.Entities;

namespace Melia.Zone.Scripting
{
	public static class Shortcuts
	{
		//private static long AnonymousShopCounter = 1;

		/// <summary>
		/// A function that initializes a shop.
		/// </summary>
		/// <param name="shop"></param>
		//public delegate void ShopCreationFunc(NpcShop shop);

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
	}
}
