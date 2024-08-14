using Melia.Shared.Game.Const;

namespace Melia.Zone.Skills.Combat
{
	/// <summary>
	/// Contains information about a hit from a skill.
	/// </summary>
	public class SkillHitResult
	{
		/// <summary>
		/// Gets or sets the amount of damage that should be dealt.
		/// </summary>
		public float Damage { get; set; }

		/// <summary>
		/// Gets or sets the hit result type, which affects how the
		/// damage is displayed.
		/// </summary>
		public HitResultType Result { get; set; } = HitResultType.Hit;

		/// <summary>
		/// Gets or sets the hit effect displayed on the target.
		/// </summary>
		public HitEffect Effect { get; set; } = HitEffect.Impact;

		/// <summary>
		/// Gets or sets the number of hits that are displayed. The damage
		/// will be split evenly between the hits.
		/// </summary>
		public int HitCount { get; set; } = 1;
	}
}
