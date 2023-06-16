using Melia.Shared.Tos.Const;

namespace Melia.Zone.Skills.Combat
{
	/// <summary>
	/// Contains information about a hit and the damage it caused.
	/// </summary>
	public class HitInfo
	{
		/// <summary>
		/// Returns the damage dealt.
		/// </summary>
		public float Damage { get; }

		/// <summary>
		/// Returns the target's current HP after the hit.
		/// </summary>
		public float Hp { get; }

		/// <summary>
		/// Returns the HP priority of the current HP value after the hit.
		/// </summary>
		public int HpPriority { get; }

		/// <summary>
		/// Returns the result type of the hit, affecting the hit effect.
		/// </summary>
		public HitResultType ResultType { get; }

		/// <summary>
		/// Creates new hit.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="hp"></param>
		/// <param name="hpPriority"></param>
		/// <param name="resultType"></param>
		public HitInfo(float damage, float hp, int hpPriority, HitResultType resultType)
		{
			this.Damage = damage;
			this.Hp = hp;
			this.HpPriority = hpPriority;
			this.ResultType = resultType;
		}
	}
}
