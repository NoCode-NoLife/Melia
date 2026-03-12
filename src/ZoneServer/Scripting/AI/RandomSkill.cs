using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;

namespace Melia.Zone.Scripting.AI
{
	/// <summary>
	/// Represents a skill with an associated probability for random
	/// selection.
	/// </summary>
	public class RandomSkill
	{
		/// <summary>
		/// Returns the skill id of this random skill.
		/// </summary>
		public SkillId SkillId { get; }

		/// <summary>
		/// Returns the probability of this skill being selected.
		/// </summary>
		/// <remarks>
		/// The probability is a chance relative to the total probability
		/// of all options. For example, if there are three skills with
		/// the probabilities 300, 200, and 100, for a total of 600, the
		/// chances for selecting them would be 300/600 (50%), 200/600
		/// (33.3%), and 100/600 (16.7%) respectively.
		/// </remarks>
		public float Probability { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="skillId"></param>
		/// <param name="probability"></param>
		public RandomSkill(SkillId skillId, float probability)
		{
			this.SkillId = skillId;
			this.Probability = probability;
		}
	}

	/// <summary>
	/// Extensions related to RandomSkill.
	/// </summary>
	public static class RandomSkillExtensions
	{
		/// <summary>
		/// Returns a random element based on the defined probabilities.
		/// </summary>
		/// <param name="skills"></param>
		/// <returns></returns>
		public static RandomSkill GetRandom(this IEnumerable<RandomSkill> skills)
		{
			var totalProbability = 0f;

			foreach (var skill in skills)
				totalProbability += skill.Probability;

			var randomValue = Random.Shared.NextSingle() * totalProbability;

			foreach (var skill in skills)
			{
				if (randomValue < skill.Probability)
					return skill;

				randomValue -= skill.Probability;
			}

			// Should never happen if probabilities are set correctly, but
			// return the first element as a fallback.
			return skills.FirstOrDefault();
		}
	}
}
