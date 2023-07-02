using System.Collections.Generic;
using Melia.Shared.Tos.Const;
using Melia.Zone.World.Actors;

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

			foreach (var target in targets)
			{
				var sdr = target.Properties.GetFloat(PropertyName.SDR);
				yield return target;

				sr -= sdr;
				if (sr <= 0)
					break;
			}
		}
	}
}
