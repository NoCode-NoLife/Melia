using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Util;

namespace Melia.Zone.Scripting.Extensions.LivelyDialog
{
	public static class NpcExtensions
	{
		/// <summary>
		/// Amount of time for memory to reduce by one point.
		/// </summary>
		private readonly static TimeSpan MemoryReductionTick = TimeSpan.FromDays(1);

		/// <summary>
		/// Amount of time for favor to reduce by one point.
		/// </summary>
		private readonly static TimeSpan FavorReductionTick = TimeSpan.FromHours(1);

		/// <summary>
		/// Amount of time for stress to reduce by one point.
		/// </summary>
		private readonly static TimeSpan StressReductionTick = TimeSpan.FromMinutes(1);

		/// <summary>
		/// Returns a value between 0 and 100 that represents how well
		/// the NPC remembers the player character.
		/// </summary>
		/// <remarks>
		/// The minimum value of 0 means the NPC has never met the player,
		/// while the maximum value of 100 means the NPC knows the player
		/// very well. The value slowly decreases over time.
		/// </remarks>
		/// <param name="dialog"></param>
		/// <returns></returns>
		public static int GetMemory(this Dialog dialog)
			=> GetRelationValue(dialog.Npc, dialog.Player, "Memory", MemoryReductionTick);

		/// <summary>
		/// Returns a value between -100 and 100 that represents the NPC's
		/// current favor towards the player character.
		/// </summary>
		/// <remarks>
		/// A higher favor value means the NPC likes the player more, and
		/// that they might be more inclined to help them. A negative value
		/// on the other hand means the NPC is unlikely to support the player.
		/// The value moves towards a neutral value of 0 over time.
		/// </remarks>
		/// <param name="dialog"></param>
		/// <returns></returns>
		public static int GetFavor(this Dialog dialog)
			=> GetRelationValue(dialog.Npc, dialog.Player, "Favor", FavorReductionTick);

		/// <summary>
		/// Returns a value between 0 and 100 that represents the NPC's
		/// current stress level when dealing with the player character.
		/// </summary>
		/// <remarks>
		/// If a player causes an NPC stress, for example by repeatedly
		/// asking about the same topic, the NPC's stress value will
		/// increase and they might become less willing to keep the
		/// conversation going.
		/// </remarks>
		/// <param name="dialog"></param>
		/// <returns></returns>
		public static int GetStress(this Dialog dialog)
			=> GetRelationValue(dialog.Npc, dialog.Player, "Stress", StressReductionTick);

		/// <summary>
		/// Modifies the NPC's memory of the player character and returns
		/// the new value.
		/// </summary>
		/// <param name="dialog"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int ModifyMemory(this Dialog dialog, int value)
		{
			var currentValue = dialog.GetMemory();
			var newValue = Math2.Clamp(0, 255, currentValue + value);

			SetRelationValue(dialog.Npc, dialog.Player, "Memory", newValue);

			return newValue;
		}

		/// <summary>
		/// Modifies the NPC's favor towards the player character and
		/// returns the new value.
		/// </summary>
		/// <param name="dialog"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int ModifyFavor(this Dialog dialog, int value)
		{
			var currentValue = dialog.GetFavor();
			var newValue = Math2.Clamp(-127, 127, currentValue + value);

			SetRelationValue(dialog.Npc, dialog.Player, "Favor", newValue);

			return newValue;
		}

		/// <summary>
		/// Modifies the NPC's stress level when dealing with the player
		/// returns the new value.
		/// </summary>
		/// <param name="dialog"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int ModifyStress(this Dialog dialog, int value)
		{
			var currentValue = dialog.GetStress();
			var newValue = Math2.Clamp(0, 255, currentValue + value);

			SetRelationValue(dialog.Npc, dialog.Player, "Stress", newValue);

			return newValue;
		}

		/// <summary>
		/// Sets the NPC's memory of the player character to the given
		/// value.
		/// </summary>
		/// <param name="dialog"></param>
		/// <param name="value"></param>
		public static void SetMemory(this Dialog dialog, int value)
			=> SetRelationValue(dialog.Npc, dialog.Player, "Memory", value);

		/// <summary>
		/// Sets the NPC's favor towards the player character to the given
		/// value.
		/// </summary>
		/// <param name="dialog"></param>
		/// <param name="value"></param>
		public static void SetFavor(this Dialog dialog, int value)
			=> SetRelationValue(dialog.Npc, dialog.Player, "Favor", value);

		/// <summary>
		/// Sets the NPC's stress level when dealing with the player
		/// to the given value.
		/// </summary>
		/// <param name="dialog"></param>
		/// <param name="value"></param>
		public static void SetStress(this Dialog dialog, int value)
			=> SetRelationValue(dialog.Npc, dialog.Player, "Stress", value);

		/// <summary>
		/// Modifies the NPC's memory, favor, and stress values at once.
		/// </summary>
		/// <param name="dialog"></param>
		/// <param name="memory"></param>
		/// <param name="favor"></param>
		/// <param name="stress"></param>
		public static void ModifyRelation(this Dialog dialog, int memory, int favor, int stress)
		{
			if (memory != 0) ModifyMemory(dialog, memory);
			if (favor != 0) ModifyFavor(dialog, favor);
			if (stress != 0) ModifyStress(dialog, stress);
		}

		/// <summary>
		/// Returns the current relationship status between the NPC and
		/// the player.
		/// </summary>
		/// <param name="dialog"></param>
		/// <returns></returns>
		public static RelationshipStatus GetRelationshipStatus(this Dialog dialog)
			=> new(dialog);

		/// <summary>
		/// Applies standard update to relation values. Intended to be used
		/// after the NPC greets the player character.
		/// </summary>
		/// <param name="dialog"></param>
		public static void UpdateRelation(this Dialog dialog)
		{
			var memory = dialog.GetMemory();
			var stress = dialog.GetStress();

			if (memory == 0)
			{
				dialog.ModifyMemory(1);
			}
			else if (memory == 1)
			{
			}
			else if (memory > 1 && memory <= 6 && stress == 0)
			{
				dialog.ModifyMemory(1);
				dialog.ModifyStress(5);
			}
			else if (stress == 0)
			{
				dialog.ModifyMemory(1);
				dialog.ModifyStress(10);
			}
		}

		/// <summary>
		/// Displays a dialog message the shows the NPC's current relation
		/// values and gives options to change them.
		/// </summary>
		/// <param name="dialog"></param>
		/// <returns></returns>
		public static async Task DebugRelation(this Dialog dialog)
		{
			var selection = await dialog.Select($"(Debug - Memory: {dialog.GetMemory()}, Favor: {dialog.GetFavor()}, Stress: {dialog.GetStress()})",
				new DialogOption("Continue", "continue"),
				new DialogOption("Clear All", "clear_all")
			);

			if (selection == "clear_all")
			{
				dialog.SetMemory(0);
				dialog.SetFavor(0);
				dialog.SetStress(0);

				await dialog.Msg($"(Debug - All values cleared. Memory: {dialog.GetMemory()}, Favor: {dialog.GetFavor()}, Stress: {dialog.GetStress()})");
			}
		}

		/// <summary>
		/// Returns a message that describes the NPC's current mood to
		/// the player.
		/// </summary>
		/// <param name="dialog"></param>
		/// <returns></returns>
		public static string GetMoodMessage(this Dialog dialog)
		{
			var memory = dialog.GetMemory();
			var favor = dialog.GetFavor();
			var stress = dialog.GetStress();

			// TODO: Add "tagless" names?
			var npcName = dialog.Npc.Name;
			var index = npcName.IndexOf(']');
			if (index != -1)
				npcName = npcName.Substring(index + 1).Replace("{nl}", "").Trim();

			if (stress > 12)
				return string.Format(Localization.Get("({0} is giving you an impression as if you're interruping something.)"), npcName);

			if (stress > 8)
				return string.Format(Localization.Get("({0} is giving you a look as if it may be better to stop this conversation.)"), npcName);

			if (favor > 40)
				return string.Format(Localization.Get("({0} is giving you a welcome look.)"), npcName);

			if (favor > 30)
				return string.Format(Localization.Get("({0} is giving you a friendly smile.)"), npcName);

			if (favor > 10)
				return string.Format(Localization.Get("({0} is looking at you with great interest.)"), npcName);

			if (favor < -20)
				return string.Format(Localization.Get("({0} is looking at you like they don't want to see you.)"), npcName);

			if (favor < -10)
				return string.Format(Localization.Get("({0} is looking at you with obvious disgust.)"), npcName);

			if (favor < -5)
				return string.Format(Localization.Get("({0} looks like your presence is somewhat unpleasent.)"), npcName);

			if (memory > 15)
				return string.Format(Localization.Get("({0} is smiling at me as if we've known each other for years.)"), npcName);

			if (memory > 5)
				return string.Format(Localization.Get("({0} is really giving me a friendly vibe.)"), npcName);

			var rnd = RandomProvider.Get();
			switch (rnd.Next(4))
			{
				default:
				case 0: return string.Format(Localization.Get("({0} is looking at you.)"), npcName);
				case 1: return string.Format(Localization.Get("({0} is looking in your direction.)"), npcName);
				case 2: return string.Format(Localization.Get("({0} is waiting for you to say something.)"), npcName);
				case 3: return string.Format(Localization.Get("({0} is paying attention to you.)"), npcName);
			}
		}

		/// <summary>
		/// Returns the variable prefix for the given NPC and value.
		/// </summary>
		/// <param name="npc"></param>
		/// <param name="valueName"></param>
		/// <returns></returns>
		private static string GetRelationVarPrefix(Npc npc, string valueName)
			=> $"Ashen.Npcs.{npc.UniqueName}.Relation.{valueName}";

		/// <summary>
		/// Returns the current value for the given relation value.
		/// </summary>
		/// <remarks>
		/// The returned value is reduced automatically, based on the
		/// time passed since it was last changed and the given reduction
		/// timeout. For example, if the value is 10, the timeout 1 hour,
		/// and 2 hours have passed since the value was last changed, the
		/// returned value is 8.
		/// </remarks>
		/// <param name="npc"></param>
		/// <param name="character"></param>
		/// <param name="valueName"></param>
		/// <param name="reductionTimeout"></param>
		/// <returns></returns>
		private static int GetRelationValue(Npc npc, Character character, string valueName, TimeSpan reductionTimeout)
		{
			var varPrefix = GetRelationVarPrefix(npc, valueName);

			var value = character.Variables.Perm.GetInt(varPrefix + ".Value", 0);
			var lastChange = character.Variables.Perm.GetLong(varPrefix + ".LastChange", -1);

			if (lastChange != -1 && value != 0)
			{
				var now = DateTime.Now;
				var lastChangeDate = new DateTime(lastChange);
				var roundsPassed = (int)Math.Floor((now - lastChangeDate).TotalSeconds / reductionTimeout.TotalSeconds);

				if (value > 0)
					value = Math.Max(0, value - roundsPassed);
				else
					value = Math.Min(0, value + roundsPassed);
			}

			return value;
		}

		/// <summary>
		/// Sets the current value for the given relation value.
		/// </summary>
		/// <param name="npc"></param>
		/// <param name="character"></param>
		/// <param name="valueName"></param>
		/// <param name="value"></param>
		private static void SetRelationValue(Npc npc, Character character, string valueName, int value)
		{
			var varPrefix = GetRelationVarPrefix(npc, valueName);

			character.Variables.Perm.SetInt(varPrefix + ".Value", value);
			character.Variables.Perm.SetLong(varPrefix + ".LastChange", DateTime.Now.Ticks);
		}
	}
}
