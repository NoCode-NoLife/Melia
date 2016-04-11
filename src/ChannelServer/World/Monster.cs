// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;
using Melia.Shared.World;
using System;

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
		/// Original mob spawn position
		/// </summary>
		public Position OriginalPosition { get; set; }

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

		/// <summary>
		/// Targeted enemy that agro mob
		/// </summary>
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
		/// Attack damage
		/// </summary>
		public int AgroPeriod;

		/// <summary>
		/// Attack range of monster
		/// </summary>
		public int AttackRange;

		/// <summary>
		/// Attack damage
		/// </summary>
		public int Attack;

		/// <summary>
		/// At this time the monster will be removed from the map.
		/// </summary>
		public DateTime DisappearTime { get; set; }

		/// <summary>
		/// Data entry for this monster.
		/// </summary>
		public MonsterData Data { get; private set; }

		/// <summary>
		/// Monster walking speed
		/// </summary>
		public float Speed { get; set; }

		/// <summary>
		/// Get monster speed.
		/// </summary>
		public float GetSpeed()
		{
			return Speed;
		}

		/// <summary>
		/// Is monster in range of his attack
		/// </summary>
		public bool IsInRangeOfAttack { get; set; }

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
			this.AttackRange = 40;
			this.Attack = 20;
			this.LoadData();		}

		/// <summary>
		/// Loads data from data files.
		/// </summary>
		private void LoadData()
		{
			if (this.Id == 0)
				throw new InvalidOperationException("Id wasn't set before calling LoadData.");

			this.Data = ChannelServer.Instance.Data.MonsterDb.Find(this.Id);
			if (this.Data == null)
				throw new NullReferenceException("No data found for '" + this.Id + "'.");
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
			var expRate = ChannelServer.Instance.Conf.World.ExpRate / 100;
			var classExpRate = ChannelServer.Instance.Conf.World.ClassExpRate / 100;

			var exp = (int)(this.Data.Exp * expRate);
			var classExp = (int)(this.Data.ClassExp * classExpRate);

			this.DisappearTime = DateTime.Now.AddSeconds(2);
			killer.GiveExp(exp, classExp, this);

			Send.ZC_DEAD(this);
		}

		/// <summary>
		/// Attack target entity if monster is agred
		/// </summary>
		public bool IsTargetVisible()
		{
			if (this.Target.Position.InRange2D(this.Position, World.Map.VisibleRange))
				return true;
			else
			{
				this.Target = null;
				return false;
			}
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
			this.SetDirection(this.Direction.AngleBetweenTwoEntity(this.Position, this.Target.Position));
			Send.ZC_ROTATE(this);
		}

		/// <summary>
		/// Starts movement.
		/// </summary>
		/// <param name="position"></param>
		public void Move(Position position)
		{
			if (this.Hp <= 0) return;

			Send.ZC_MOVE_PATH(this, position);
			this.SetPosition(position);
		}

		/// <summary>
		/// Sets direction toward target and updates clients.
		/// </summary>
		public void MoveTowardTarget()
		{
			if (this.Target != null && this.Hp > 0)
			{
				//Is character in range of auto attack
				if (!this.Target.Position.InRange2D(this.Position, AttackRange))
				{
					this.IsInRangeOfAttack = false;

					Position nextPosition = this.Position.VectorTwoEntity(this.Target.Position, this.Speed, WorldManager.HeartbeatTime);

					Send.ZC_MOVE_PATH(this, this.Target.Position);

					this.SetPosition(this.Position.X + nextPosition.X, this.Position.Y + nextPosition.Y, this.Position.Z + nextPosition.Z);
				}
				else
					this.IsInRangeOfAttack = true;
			}
			else
				this.IsInRangeOfAttack = false;
		}

		/// <summary>
		/// Attack target entity if monster is agred
		/// </summary>
		public void AttackTarget()
		{
			if (this.Target != null && this.Hp > 0 && this.IsInRangeOfAttack)
			{
				//this.Target.Hp -= this.Attack;
				RotateTowardTarget();
				Send.ZC_SKILL_HIT_INFO(this, this.Target, Attack);
			}
		}

		public void UpdateStartAgro()
		{
			if (this.AgroPeriod > 0 && this.Target != null)
			{
				this.AgroPeriod -= WorldManager.HeartbeatTime;
				var nearCharacter = this.Map.GetVisibleCharacters(this);
				if (nearCharacter.Length != 0)
				{
					this.Target = nearCharacter[0];
					this.AgroPeriod = 0;
				}
			}
			if (this.Target != null)
			{
				//TODO need some constant for mob vision range
				if (!this.Target.Position.InRange2D(this.Position, 150))
				{
					this.Target = null;
					this.Move(this.OriginalPosition);
				}
				//How far mob can walk from original spawn point
				if (!this.OriginalPosition.InRange2D(this.Position, 300))
				{
					this.Target = null;
					this.Move(this.OriginalPosition);
				}
			}
		}

		/// <summary>
		/// Update monster behaviour
		/// </summary>
		public void UpdateMonsterBehaviour()
		{
			//Agro on spawn like in original ToS
			this.UpdateStartAgro();

			if (this.Target != null)
			{
				if (!this.IsTargetVisible()) return;
				this.MoveTowardTarget();
				this.AttackTarget();
			}
		}
	}
}
