namespace Melia.Zone.Skills.Combat
{
	public class HitInfo
	{
		public float Damage { get; }
		public float Hp { get; }
		public int UnkCountUp { get; }
		public short ResultType { get; }

		public HitInfo(float damage, float hp, int countUp, short resultType)
		{
			this.Damage = damage;
			this.Hp = hp;
			this.UnkCountUp = countUp;
			this.ResultType = resultType;
		}
	}
}
