using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Tos.Const;
using Melia.Zone.World.Actors;
using Yggdrasil.Util;

namespace Melia.Zone.Skills.Combat
{
	/// <summary>
	/// Extensions that help with handling skills.
	/// </summary>
	public static class SkillHelperExtensions
	{
		/// <summary>
		/// Iterates over targets and returns them until the skill's SR
		/// limit is reached.
		/// </summary>
		/// <param name="targets"></param>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		public static IEnumerable<ICombatEntity> LimitBySDR(this IEnumerable<ICombatEntity> targets, ICombatEntity caster, Skill skill)
		{
			var sr = skill.Properties.GetFloat(PropertyName.SkillSR);

			// Crank up SR if SDR is disabled, so we can effectively
			// hit all the targets
			if (ZoneServer.Instance.Conf.World.DisableSDR)
				sr = int.MaxValue;

			// Executes and returns a target at least once and then
			// keeps subtracting SDR from the skill's SR until it
			// reaches 0. Once it does, no more targets can be hit
			// and we return.
			// The targets are ordered by their SDR, so the ones with
			// the highest SDR are hit first and are able to potentially
			// tank the hit before it can hit other targets.

			targets = targets.OrderByDescending(a => a.Properties.GetFloat(PropertyName.SDR));

			foreach (var target in targets)
			{
				var sdr = target.Properties.GetFloat(PropertyName.SDR);
				yield return target;

				sr -= sdr;
				if (sr <= 0)
					break;
			}
		}

		/// <summary>
		/// Iterates over targets in a random order and returns them up
		/// to the the max amount.
		/// </summary>
		/// <param name="targets"></param>
		/// <param name="maxAmount"></param>
		/// <returns></returns>
		public static IEnumerable<ICombatEntity> LimitRandom(this IEnumerable<ICombatEntity> targets, int maxAmount)
		{
			var rnd = RandomProvider.Get();
			targets = targets.OrderBy(a => rnd.Next());

			var i = 0;
			foreach (var target in targets)
			{
				yield return target;

				if (++i >= maxAmount)
					break;
			}
		}
	}
}
