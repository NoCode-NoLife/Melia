using System;
using Melia.Shared.Game.Const;
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
		/// Returns the verticle angle used in the packets based on the skill
		/// data.
		/// </summary>
		public int VAngle { get; }

		/// <summary>
		/// Duration of the knock back.
		/// </summary>
		/// <remarks>
		/// Affects knock downs in particular, where the target bounces
		/// off the ground a few times. If the time is not long enough,
		/// the target stops in mid-air.
		/// </remarks>
		public TimeSpan Time { get; }

		/// <summary>
		/// Creates new knock back info.
		/// </summary>
		/// <param name="attackerPosition"></param>
		/// <param name="targetPosition"></param>
		/// <param name="skill"></param>
		public KnockBackInfo(Position attackerPosition, Position targetPosition, Skill skill)
			: this(attackerPosition, targetPosition, skill.Data.KnockDownHitType, skill.Data.KnockDownVelocity, skill.Data.KnockDownVAngle)
		{
		}

		/// <summary>
		/// Creates new knock back info.
		/// </summary>
		/// <param name="attackerPosition"></param>
		/// <param name="targetPosition"></param>
		/// <param name="knockDownHitType"></param>
		/// <param name="velocity"></param>
		/// <param name="vAngle"></param>
		public KnockBackInfo(Position attackerPosition, Position targetPosition, HitType knockDownHitType, int velocity, int vAngle)
		{
			this.Direction = attackerPosition.GetDirection(targetPosition);
			this.HitType = knockDownHitType;
			this.Velocity = velocity;
			this.HAngle = (int)this.Direction.NormalDegreeAngle;
			this.VAngle = vAngle;

			this.AttackerPosition = attackerPosition;
			this.FromPosition = targetPosition;
			//this.ToPosition = this.GetNewPosition();
			//this.Time = this.GetTime();

			// Hacks until we have a working formula
			if (this.Velocity == 55 && this.VAngle == -210)
			{
				var distance = 2.594f;

				this.VAngle = 10;
				this.Time = TimeSpan.FromMilliseconds(82);
				this.ToPosition = this.FromPosition.GetRelative(this.Direction, distance);
			}
			else if (this.Velocity == 400 && this.VAngle == 86)
			{
				var distance = 93.570992087511f;

				this.Time = TimeSpan.FromMilliseconds(6747);
				this.ToPosition = this.FromPosition.GetRelative(this.Direction, distance);
			}
			else if (this.Velocity == 300 && this.VAngle == 89)
			{
				var distance = 15.57f;

				this.Time = TimeSpan.FromMilliseconds(4206);
				this.ToPosition = this.FromPosition.GetRelative(this.Direction, distance);
			}
			else if (this.Velocity == 250 && this.VAngle == 85) // Wagon Wheel
			{
				var distance = 30.570992087511f;

				this.Time = TimeSpan.FromMilliseconds(6747);
				this.ToPosition = this.FromPosition.GetRelative(this.Direction, distance);
			}
			else if (this.Velocity == 250 && this.VAngle == 10) // Rim Blow
			{
				// TODO: Double check this distance. In the PR it was a for loop
				//   over the hit count (4)?
				var distance = 22f * 4;

				this.Time = TimeSpan.FromMilliseconds(180);
				this.ToPosition = this.FromPosition.GetRelative(this.Direction, distance);
			}
			else if (this.Velocity == 150 && this.VAngle == 10) // Taglio
			{
				var distance = 10;

				this.Time = TimeSpan.FromMilliseconds(180);
				this.ToPosition = this.FromPosition.GetRelative(this.Direction, distance);
			}
			else if (this.Velocity == 100 && this.VAngle == 85) // Granata
			{
				var distance = 1;

				this.Time = TimeSpan.FromMilliseconds(180);
				this.ToPosition = this.FromPosition.GetRelative(this.Direction, distance);
			}
			else
			{
				var distance = 17.700299992446f;

				this.Velocity = 150;
				this.VAngle = 10;
				this.Time = TimeSpan.FromMilliseconds(180);
				this.ToPosition = this.FromPosition.GetRelative(this.Direction, distance);
			}
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
			// too much for now.
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
			// 
			// Update: After some more research there appears to be another
			// factor involved in the calculation. The VAngle determines
			// how far the monsters flies up into the air, which affects
			// the distance it travels. That means the formula is even
			// more wrong than I initially thought, because it will
			// basically only work on simple push backs. The VAngle
			// used for the above examples was 10.

			var pos = this.FromPosition;
			var dir = this.Direction;
			var velocity = this.Velocity;
			var unitsPerSecond = velocity;

			// The distance increases with increased velocity, so the
			// formula is presumably based on that value somehow. During
			// testing it seemed like a time of 0.12 seconds worked for
			// a velocity of 150, and since 150 / 1000 * 0.8 = 0.12, we
			// end up with this formula.
			var seconds = velocity / 1000f * 0.8f;

			var distance = unitsPerSecond * seconds;

			Log.Debug("Velocity: {0}, Seconds: {1}, Distance: {2}", velocity, seconds, distance);

			return pos.GetRelative(dir, distance);
		}
	}
}
