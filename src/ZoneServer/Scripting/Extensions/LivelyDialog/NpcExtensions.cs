using System;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Extensions;
using Yggdrasil.Util;

namespace Melia.Zone.Scripting.Extensions.LivelyDialog
{
	public static class NpcExtensions
	{
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
			=> GetRelationValue(dialog.Npc, dialog.Player, "Memory", TimeSpan.FromDays(1));

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
		=> GetRelationValue(dialog.Npc, dialog.Player, "Favor", TimeSpan.FromHours(1));

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
			=> GetRelationValue(dialog.Npc, dialog.Player, "Stress", TimeSpan.FromMinutes(1));

		/// <summary>
		/// Modifies the NPC's memory of the player character and returns
		/// the new value.
		/// </summary>
		/// <param name="dialog"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int ModifyMemory(this Dialog dialog, int value)
			=> ModifyRelationValue(dialog.Npc, dialog.Player, "Memory", value, 0, 100);

		/// <summary>
		/// Modifies the NPC's favor towards the player character and
		/// returns the new value.
		/// </summary>
		/// <param name="dialog"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int ModifyFavor(this Dialog dialog, int value)
			=> ModifyRelationValue(dialog.Npc, dialog.Player, "Favor", value, -100, 100);

		/// <summary>
		/// Modifies the NPC's stress level when dealing with the player
		/// returns the new value.
		/// </summary>
		/// <param name="dialog"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		public static int ModifyStress(this Dialog dialog, int value)
			=> ModifyRelationValue(dialog.Npc, dialog.Player, "Stress", value, 0, 100);

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
		/// Applies standard update to relation values. Intended to be used
		/// after the NPC greets the player character.
		/// </summary>
		/// <param name="dialog"></param>
		public static async Task UpdateRelation(this Dialog dialog)
		{
			var memory = dialog.GetMemory();
			var favor = dialog.GetFavor();
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

			await dialog.Msg($"(Debug - Memory: {dialog.GetMemory()}, Favor: {dialog.GetFavor()}, Stress: {dialog.GetStress()})");
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

		/// <summary>
		/// Modifies the current value for the given relation value and
		/// returns the new value.
		/// </summary>
		/// <param name="npc"></param>
		/// <param name="character"></param>
		/// <param name="valueName"></param>
		/// <param name="value"></param>
		/// <param name="minValue"></param>
		/// <param name="maxValue"></param>
		/// <returns></returns>
		private static int ModifyRelationValue(Npc npc, Character character, string valueName, int value, int minValue, int maxValue)
		{
			var varPrefix = GetRelationVarPrefix(npc, valueName);

			var currentValue = character.Variables.Perm.GetInt(varPrefix + ".Value", 0);
			var newValue = Math2.Clamp(minValue, maxValue, currentValue + value);

			SetRelationValue(npc, character, valueName, newValue);

			return newValue;
		}
	}
}
