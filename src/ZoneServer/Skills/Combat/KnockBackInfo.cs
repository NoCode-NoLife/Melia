using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Yggdrasil.Logging;

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
		/// Returns the hit type of the knock back.
		/// </summary>
		public HitType HitType { get; }

		/// <summary>
		/// Returns the velocity by which the target moves back.
		/// </summary>
		public int Velocity { get; }

		/// <summary>
		/// Returns the angle at which the target was knocked back based
		/// on the direction.
		/// </summary>
		public int HAngle { get; }

		/// <summary>
		/// Returns an unknown angle used in the packets based on the skill
		/// data.
		/// </summary>
		public int VAngle { get; }

		/// <summary>
		/// Creates new knock back info.
		/// </summary>
		/// <param name="attackerPosition"></param>
		/// <param name="targetPosition"></param>
		/// <param name="skill"></param>
		public KnockBackInfo(Position attackerPosition, Position targetPosition, Skill skill)
		{
			this.Direction = attackerPosition.GetDirection(targetPosition);
			this.HitType = skill.Data.KnockDownHitType;
			this.Velocity = skill.Data.KnockDownVelocity;
			this.HAngle = (int)this.Direction.NormalDegreeAngle;
			this.VAngle = skill.Data.KnockDownVAngle;

			this.AttackerPosition = attackerPosition;
			this.FromPosition = targetPosition;
			this.ToPosition = this.GetNewPosition();
		}

		/// <summary>
		/// Returns the position a target would be knocked back to,
		/// given the direction and velocity.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="dir"></param>
		/// <param name="velocity"></param>
		/// <returns></returns>
		public Position GetNewPosition()
		{
			// Unfortunately we can't just decide the new position,
			// because the client expects a velocity to calculate
			// it itself. The following formula for calculating
			// the knockback distance is *not* correct, but it's close
			// enough that we'll hopefully not notice the descrepancy
			// for now.
			// 
			// Here are some examples. The expected values were gathered
			// by having the client calculate the distance of a knocked
			// back monster based on the positions before and after the
			// knock back.
			// 
			// Velocity: 100, Expected: 8.5835532351144, Formula:  8.00
			// Velocity: 125, Expected: 13.360553023927, Formula:  12.5
			// Velocity: 150, Expected: 17.700299992446, Formula:  18.0
			// Velocity: 175, Expected: 26.186134491803, Formula:  24.5
			// Velocity: 200, Expected: 34.202182950439, Formula:  32.0
			// Velocity: 225, Expected: 41.300142972251, Formula:  40.5
			// Velocity: 250, Expected: 52.128298346989, Formula:  50.0
			// Velocity: 300, Expected: 70.325086038326, Formula:  72.0
			// Velocity: 400, Expected: 106.24073509195, Formula: 128.0

			var pos = this.FromPosition;
			var dir = this.Direction;
			var velocity = this.Velocity;
			var unitsPerSecond = velocity;

			// The distance increases with increased velocity, so the
			// formula is presumably based on that value somehow. During
			// testing it seemed like a time of 0.12 seconds worked for
			// a velocity of 150, and since 150 / 1000 * 0.8 = 0.12, we
			// end up with this formula. And now we wait for the inevitable
			// bug report that this doesn't work in some cases.
			var seconds = velocity / 1000f * 0.8f;

			var distance = unitsPerSecond * seconds;

			//Log.Debug("Velocity: {0}, Seconds: {1}, Distance: {2}", velocity, seconds, distance);

			return pos.GetRelative(dir, distance);
		}
	}
}
