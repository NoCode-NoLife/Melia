using Melia.Shared.World;

namespace Melia.Zone.Skills.Combat
{
	/// <summary>
	/// Information about a knockback.
	/// </summary>
	public class KnockBackInfo
	{
		/// <summary>
		/// Returns the position of the attacker.
		/// </summary>
		public Position AttackerPosition { get; }

		/// <summary>
		/// Returns the position of the target before the knock back.
		/// </summary>
		public Position FromPosition { get; }

		/// <summary>
		/// Returns the position of the target after the knock back.
		/// </summary>
		public Position ToPosition { get; }

		/// <summary>
		/// Returns the direction in which the target was knocked back.
		/// </summary>
		public Direction Direction { get; }

		/// <summary>
		/// Returns the velocity by which the target moves back.
		/// </summary>
		public int Velocity { get; }

		/// <summary>
		/// Creates new knock back info.
		/// </summary>
		/// <param name="attackerPosition"></param>
		/// <param name="targetPosition"></param>
		/// <param name="velocity"></param>
		public KnockBackInfo(Position attackerPosition, Position targetPosition, int velocity)
		{
			this.AttackerPosition = attackerPosition;
			this.FromPosition = targetPosition;
			this.Velocity = velocity;

			this.Direction = attackerPosition.GetDirection(targetPosition);

			// Unfortunately we can't just set the new position, the
			// client wants a velocity instead. We'll have to figure
			// out the distance formula.
			// 
			// Velocity=Distance
			// 150=18, 175=22, 200=34, 225=42, 250=54
			this.Velocity = 150;
			this.ToPosition = targetPosition.GetRelative(this.Direction, 18);
		}
	}
}
