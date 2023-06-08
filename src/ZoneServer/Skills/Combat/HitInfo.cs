using Melia.Shared.Tos.Const;

namespace Melia.Zone.Skills.Combat
{
	public class HitInfo
	{
		public float Damage { get; }
		public float Hp { get; }
		public int UnkCountUp { get; }
		public HitResultType ResultType { get; }

		public HitInfo(float damage, float hp, int countUp, HitResultType resultType)
		{
			this.Damage = damage;
			this.Hp = hp;
			this.UnkCountUp = countUp;
			this.ResultType = resultType;
		}
	}
}
