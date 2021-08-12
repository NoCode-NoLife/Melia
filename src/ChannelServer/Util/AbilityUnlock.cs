// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using System.Text.RegularExpressions;
using Melia.Channel.World;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;

namespace Melia.Channel.Util
{
	// These functions should not be changed, unless the respective
	// functions on the client are changed as well, as the client displays
	// and checks the requests based on its own data before sending it
	// to the server.

	public static class AbilityUnlock
	{
		private static readonly Regex UnlockCallRegex = new Regex(@"^\s*(?<funcName>[a-z0-9_]+)\s*\(""(?<strParam>[^""]*)""\s*,\s*(?<numParam>[0-9]+)\s*\)\s*$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

		/// <summary>
		/// Returns true if given ability is unlocked for character.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="abilityTreeData"></param>
		/// <returns></returns>
		public static bool IsUnlocked(Character character, AbilityData abilityData, AbilityTreeData abilityTreeData)
		{
			// This is all a little temporary. I don't know if we might want
			// to use Lua for this, or maybe something else entirely.
			// If we leave it as C#, we might not want to use reflection,
			// or at least cache the methods, but for now it will work fine.

			var call = abilityTreeData.Unlock;
			var match = UnlockCallRegex.Match(call);
			if (!match.Success)
			{
				Log.Warning("AbilityUnlock.IsUnlocked: Invalid unlock call '{0}'.", call);
				return false;
			}

			var funcName = match.Groups["funcName"].Value;
			var strParam = match.Groups["strParam"].Value;
			var numParam = Convert.ToInt32(match.Groups["numParam"].Value);

			var method = typeof(AbilityUnlock).GetMethod(funcName);
			if (method == null)
			{
				Log.Warning("AbilityUnlock.IsUnlocked: Unknown function '{0}'.", funcName);
				return false;
			}

			var parameters = method.GetParameters();
			if (
				method.ReturnType != typeof(bool) ||
				parameters.Length != 4 ||
				parameters[0].ParameterType != typeof(Character) ||
				parameters[1].ParameterType != typeof(string) ||
				parameters[2].ParameterType != typeof(int) ||
				parameters[3].ParameterType != typeof(AbilityData)
			)
			{
				Log.Warning("AbilityUnlock.IsUnlocked: Function '{0}' has an invalid signature.", funcName);
				return false;
			}

			var result = (bool)method.Invoke(null, new object[] { character, strParam, numParam, abilityData });

			return result;
		}

		/// <summary>
		/// Unlock at given circle.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="jobClassName"></param>
		/// <param name="minCircle"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public static bool UNLOCK_ABIL_CIRCLE(Character character, string jobClassName, int minCircle, AbilityData data)
		{
			var circle = character.Jobs.GetCircle(jobClassName);

			return ((int)circle >= minCircle);
		}

		/// <summary>
		/// Unlocks if skill is at least on the given level.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillClassName"></param>
		/// <param name="minLevel"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public static bool UNLOCK_ABIL_SKILL(Character character, string skillClassName, int minLevel, AbilityData data)
		{
			var skill = character.Skills.Get(skillClassName);

			return (skill != null && skill.Level >= minLevel);
		}

		/// <summary>
		/// Unlocks if character's level is high enough, based on given
		/// level and the ability tree data.
		/// </summary>
		/// <remarks>
		/// Not used on officials right now, included it just in case.
		/// </remarks>
		/// <param name="character"></param>
		/// <param name="skillClassName"></param>
		/// <param name="level"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public static bool UNLOCK_ABIL_LEVEL(Character character, string skillClassName, int level, AbilityData data)
		{
			var minLevel = level + data?.Level;

			return (character.Level >= minLevel);
		}

		/// <summary>
		/// Unlocks at given job rank.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="_"></param>
		/// <param name="minRank"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public static bool UNLOCK_ABIL_RANK(Character character, string _, int minRank, AbilityData data)
		{
			var rank = character.Jobs.GetCurrentRank();

			return (rank >= minRank);
		}

		/// <summary>
		/// Unlocks if given skill is at least at the minLevel and character
		/// has the Priest job with circle 2 or above.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillClassName"></param>
		/// <param name="minLevel"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public static bool UNLOCK_PRIEST21(Character character, string skillClassName, int minLevel, AbilityData data)
		{
			var circle = character.Jobs.GetCircle(JobId.Priest);
			var skill = character.Skills.Get(skillClassName);

			return (circle >= Circle.Second && skill != null && skill.Level >= minLevel);
		}

		/// <summary>
		/// Unlocks if the level of the skills BloodBath and BloodSucking are
		/// both above the minLevel.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="_"></param>
		/// <param name="minLevel"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public static bool UNLOCK_FEATHERFOOT_BLOOD(Character character, string _, int minLevel, AbilityData data)
		{
			var bloodBath = character.Skills.Get("Featherfoot_BloodBath");
			var bloodSucking = character.Skills.Get("Featherfoot_BloodBath");

			return (bloodBath != null && bloodSucking != null && bloodBath.Level >= minLevel && bloodSucking.Level >= minLevel);
		}

		/// <summary>
		/// Unlocks if given skill is at least at level 1 and character
		/// has the Musketeer job with circle 2 or above.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillClassName"></param>
		/// <param name="_"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public static bool UNLOCK_MUSKETEER15(Character character, string skillClassName, int _, AbilityData data)
		{
			var circle = character.Jobs.GetCircle(JobId.Musketeer);
			var skill = character.Skills.Get(skillClassName);

			return (circle >= Circle.Second && skill != null && skill.Level >= 1);
		}

		/// <summary>
		/// Unlocks if given skill is at least at level 10 and character
		/// has the Warlock1 job with circle 3 or above.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="_"></param>
		/// <param name="__"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public static bool UNLOCK_ELEMENTALIST25(Character character, string _, int __, AbilityData data)
		{
			var circle = character.Jobs.GetCircle(JobId.Elementalist);
			var skill = character.Skills.Get("Elementalist_Meteor");

			return (circle >= Circle.Third && skill != null && skill.Level >= 10);
		}
	}
}
