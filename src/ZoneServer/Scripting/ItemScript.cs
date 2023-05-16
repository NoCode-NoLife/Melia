using System;
using System.Collections.Generic;
using Melia.Zone.World.Entities;
using Yggdrasil.Logging;
using Yggdrasil.Scripting;
using Yggdrasil.Util;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// An item script handler.
	/// </summary>
	public class ItemScript : IScript
	{
		private static readonly Dictionary<int, ItemScript> Scripts = new Dictionary<int, ItemScript>();
		private static readonly Random Rnd = new Random(RandomProvider.GetSeed());

		/// <summary>
		/// Returns the script for the given item class id via out,
		/// returns false if no script was defined.
		/// </summary>
		/// <param name="classId"></param>
		/// <param name="script"></param>
		/// <returns></returns>
		public static bool TryGetScript(int classId, out ItemScript script)
		{
			lock (Scripts)
				return Scripts.TryGetValue(classId, out script);
		}

		/// <summary>
		/// Initializes script, adding itself to the list of available
		/// scripts.
		/// </summary>
		/// <returns></returns>
		public bool Init()
		{
			// get class ids from attribute ItemScriptAttribute and add this
			// script to the Dictionary Scripts for all class ids
			var attributes = this.GetType().GetCustomAttributes(typeof(ItemScriptAttribute), false);
			if (attributes.Length == 0)
			{
				Log.Warning("Item script '{0}' is missing an ItemScript attribute.", this.GetType().Name);
				return false;
			}

			lock (Scripts)
			{
				foreach (ItemScriptAttribute attr in attributes)
				{
					foreach (var classId in attr.ClassIds)
						Scripts[classId] = this;
				}
			}

			return true;
		}

		/// <summary>
		/// Called when the player uses the item, returns whether the
		/// usage was successful and the item should be decremented.
		/// </summary>
		/// <param name="player"></param>
		/// <param name="item"></param>
		/// <returns></returns>
		public virtual ItemUseResult OnUse(Character player, Item item)
		{
			return ItemUseResult.Okay;
		}

		/// <summary>
		/// Returns a random number between min and max (inclusive).
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static int Random(int min, int max)
		{
			lock (Rnd)
				return Rnd.Next(min, max + 1);
		}
	}

	/// <summary>
	/// Used to specify information about an item script.
	/// </summary>
	public class ItemScriptAttribute : Attribute
	{
		/// <summary>
		/// Returns the class ids of the items the script should
		/// handle.
		/// </summary>
		public int[] ClassIds { get; }

		/// <summary>
		/// Creates new attribute.
		/// </summary>
		/// <param name="classIds"></param>
		public ItemScriptAttribute(params int[] classIds)
		{
			this.ClassIds = classIds;
		}
	}

	/// <summary>
	/// Specifies the result of using an item.
	/// </summary>
	public enum ItemUseResult
	{
		/// <summary>
		/// The item was used successfully and should be decremented.
		/// </summary>
		Okay,

		/// <summary>
		/// The usage failed and the item should not be decremented.
		/// </summary>
		Fail,
	}
}
