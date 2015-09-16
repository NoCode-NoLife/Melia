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
		/// Monster's direction.
		/// </summary>
		public Direction Direction { get; set; }

		/// <summary>
		/// AoE Defense Ratio
		/// </summary>
		public int SDR { get; set; }

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
		}

		/// <summary>
		/// Makes monster take damage and kills it if the HP reach 0.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="from"></param>
		public void TakeDamage(int damage, Character from)
		{
			this.Hp -= damage;

			// Sending this to the attacker causes a double attack effect,
			// because the client plays the effect automatically as well.
			// TODO: Find out how officials update the monster's HP without
			//   this packet.
			Send.ZC_HIT_INFO(from, this, damage);

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

			Send.ZC_DEAD(this.Map, this);
		}
	}
}
