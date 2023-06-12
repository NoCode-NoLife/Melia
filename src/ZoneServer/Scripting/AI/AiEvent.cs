namespace Melia.Zone.Scripting.AI
{
	/// <summary>
	/// An alert about an event that happend to or around an AI's entity.
	/// </summary>
	public interface IAiEventAlert
	{
	}

	/// <summary>
	/// Information for the AI that the entity was hit.
	/// </summary>
	public class HitEventAlert : IAiEventAlert
	{
		/// <summary>
		/// Returns the handle of the target.
		/// </summary>
		public int TargetHandle { get; }

		/// <summary>
		/// Returns the handle of the attacker.
		/// </summary>
		public int AttackerHandle { get; }

		/// <summary>
		/// Returns the damage dealt.
		/// </summary>
		public float Damage { get; }

		/// <summary>
		/// Creates new event.
		/// </summary>
		/// <param name="targetHandle"></param>
		/// <param name="attackerHandler"></param>
		/// <param name="damage"></param>
		public HitEventAlert(int targetHandle, int attackerHandler, float damage)
		{
			this.TargetHandle = targetHandle;
			this.AttackerHandle = attackerHandler;
			this.Damage = damage;
		}
	}
}
