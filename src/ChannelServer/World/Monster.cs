using Melia.Channel.Network;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Util;
using Melia.Shared.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Melia.Channel.World
{
	public class Monster : IEntity
	{
		/// <summary>
		/// Index in world collection?
		/// </summary>
		public int Handle { get; private set; }

		private Map _map = Map.Limbo;
		/// <summary>
		/// The map the monster is currently on.
		/// </summary>
		public Map Map { get { return _map; } set { _map = value ?? Map.Limbo; } }

		/// <summary>
		/// Monster ID in database.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// What kind of NPC the monster is.
		/// </summary>
		public NpcType NpcType { get; set; }

		/// <summary>
		/// Monster's name, leave empty for default.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Name of dialog function to call on trigger,
		/// leave empty for no dialog hotkey display.
		/// </summary>
		public string DialogName { get; set; }

		/// <summary>
		/// Warp identifier?
		/// </summary>
		/// <remarks>
		/// Purpose unknown, doesn't seem to affect anything.
		/// Examples: WS_KLAPEDA_HIGHLANDER, WS_SIAULST1_KLAPEDA
		/// </remarks>
		public string WarpName { get; set; }

		/// <summary>
		/// Returns true if WarpName is not empty.
		/// </summary>
		public bool IsWarp { get { return !string.IsNullOrWhiteSpace(this.WarpName); } }

		/// <summary>
		/// Location to warp to.
		/// </summary>
		public Location WarpLocation { get; set; }

		/// <summary>
		/// Level.
		/// </summary>
		public int Level { get; set; }

		/// <summary>
		/// Monster's position.
		/// </summary>
		public Position Position { get; set; }

        /// <summary>
        /// Set monster's position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        private void SetPosition(float x, float y, float z)
        {
            this.Position = new Position(x, y, z);
        }

        /// <summary>
        /// Set monster's position
        /// </summary>
        /// <param name="position"></param>
        private void SetPosition(Position position)
        {
            this.Position = new Position(position);
        }

        /// <summary>
        /// Set monster's direction
        /// </summary>
        public Direction Direction { get; set; }

        /// <summary>
        /// Set monster's direction
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        private void SetDirection(float d1, float d2)
        {
            this.Direction = new Direction(d1, d2);
        }

        /// <summary>
        /// Monster's direction.
        /// </summary>
        public void SetDirection(Direction direction)
	    {
	        this.Direction = direction;
	    }

        /// <summary>
        /// AoE Defense Ratio
        /// </summary>
        public int SDR { get; set; }

	    public IEntity Target { get; set; }

		/// <summary>
		/// Health points.
		/// </summary>
		public int Hp
		{
			get { return _hp; }
			set { _hp = Math2.Clamp(0, this.MaxHp, value); }
		}
		private int _hp;

        /// <summary>
        /// Maximum health points.
        /// </summary>
        public int MaxHp { get; set; }

		/// <summary>
		/// At this time the monster will be removed from the map.
		/// </summary>
		public DateTime DisappearTime { get; set; }

        /// <summary>
        /// Monster walking speed
        /// </summary>
        public float Speed { get; set; }

        /// <summary>
        /// Is monster moving at that moment?
        /// </summary>
        private bool IsMoving { get; set; }

        /// <summary>
        /// Creates new NPC.
        /// </summary>
        public Monster(int id, NpcType type)
		{
			this.Handle = ChannelServer.Instance.World.CreateHandle();

			this.Id = id;
			this.NpcType = type;
			this.Level = 1;
			this.SDR = 1;
			this.Hp = this.MaxHp = 100;
			this.DisappearTime = DateTime.MaxValue;
            this.Speed = 30;
		}

		/// <summary>
		/// Makes monster take damage and kills it if the HP reach 0.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="from"></param>
		public void TakeDamage(int damage, Character from)
		{
		    this.Target = from;
			this.Hp -= damage;

			// In earlier clients ZC_HIT_INFO was used, newer ones seem to
			// use SKILL, and this doesn't create a double hit effect like
			// the other.
			Send.ZC_SKILL_HIT_INFO(from, this, damage);

			if (this.Hp == 0)
				this.Kill(from);
		}

		/// <summary>
		/// Kills monster.
		/// </summary>
		/// <param name="killer"></param>
		public void Kill(Character killer)
		{
			this.DisappearTime = DateTime.Now.AddSeconds(2);
			killer.GiveExp(500, 0, this);

			Send.ZC_DEAD(this);
		}

        /// <summary>
		/// Sets direction and updates clients.
		/// </summary>
		/// <param name="d1"></param>
		/// <param name="d2"></param>
		public void Rotate(float d1, float d2)
        {
            if (this.Hp <= 0) return;

            this.SetDirection(d1, d2);
            Send.ZC_ROTATE(this);
        }
        
        /// <summary>
        /// Sets direction toward target and updates clients.
        /// </summary>
        public void RotateTowardTarget()
        {
            if (this.Hp <= 0) return;

            if (this.Target == null) return;
            this.SetDirection(
                Shared.Util.Math2.AngleBetweenTwoEntity(
                    this.Position, this.Target.Position
                    ));
            Send.ZC_ROTATE(this);
        }

        /// <summary>
		/// Starts movement.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="dx"></param>
		/// <param name="dy"></param>
        // Cause float unkFloat is... unknown I gonna
        // pass zero, cause it seems to work fine.
        public void Move(float x, float y, float z, float dx, float dy)
        {
            if (this.Hp <= 0) return;

            this.SetPosition(x, y, z);
            this.SetDirection(dx, dy);
            this.IsMoving = true;

            Send.ZC_MOVE_DIR(this, x, y, z, dx, dy, 0);
        }

        /// <summary>
        /// Sets direction toward target and updates clients.
        /// </summary>
        public void MoveTowardTarget()
        {
            if (this.Target == null && this.Hp <= 0) return;

            this.SetPosition(this.Target.Position);
            this.SetDirection(
                Shared.Util.Math2.AngleBetweenTwoEntity(
                    this.Position, this.Target.Position
            ));
            Send.ZC_MOVE_DIR(
                this,
                this.Target.Position.X,
                this.Target.Position.Y,
                this.Target.Position.Z,
                this.Direction.Cos,
                this.Direction.Sin,
                0
            );
        }
    }
}
