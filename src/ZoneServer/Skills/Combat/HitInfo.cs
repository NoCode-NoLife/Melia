namespace Melia.Zone.Skills.Combat
{
	public class HitInfo
	{
		public float Damage { get; }
		public float Hp { get; }
		public short ResultType { get; }

		public HitInfo(float damage, float hp, short resultType)
		{
			this.Damage = damage;
			this.Hp = hp;
			this.ResultType = resultType;
		}
	}
}
