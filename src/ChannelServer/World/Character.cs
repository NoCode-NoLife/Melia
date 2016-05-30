// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network;
using Melia.Channel.Scripting;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Util;
using Melia.Shared.World;
using Melia.Shared.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World.Shapes;

namespace Melia.Channel.World
{
	public class Character : Shared.World.BaseCharacter, ICommander, IEntity, IVisitor
	{
		private bool _warping;

		private object _lookAroundLock = new object();
		private Monster[] _visibleMonsters = new Monster[0];
		private Character[] _visibleCharacters = new Character[0];

		public Dictionary<Job, int> jobs;
		public Dictionary<Job, int> jobPoints;
		public int jobLevel;

		public SkillManager skillManager { get; set; }
		public StatsManager statsManager { get; set; }
		public BuffManager buffManager { get; set; }

		/// <summary>
		/// Connection this character uses.
		/// </summary>
		public ChannelConnection Connection { get; set; }


		private Map _map = Map.Limbo;
		/// <summary>
		/// The map the character is currently on.
		/// </summary>
		/// <remarks>
		/// Since every map change includes a reconnect, the map reference
		/// will only ever be set once, upon connection.
		/// </remarks>
		public Map Map { get { return _map; } set { _map = value ?? Map.Limbo; } }

		/// <summary>
		/// Gets or sets whether the character is moving.
		/// </summary>
		public bool IsMoving { get; set; }
		private bool IsMoveStop { get; set; }
		private float LastMoveTimestamp { get; set; }

		public bool IsAttacking { get; set; }

		private Position _destination { get; set; }

		// Regeneration ticks
		private DateTime lastHpRegenTime;
		private DateTime lastSpRegenTime;

		/// <summary>
		/// Gets or sets whether the character is sitting.
		/// </summary>
		public bool IsSitting { get; set; }

		/// <summary>
		/// Gets or sets whether the character is standing on the ground.
		/// </summary>
		public bool IsGrounded { get; set; }

		/// <summary>
		/// The character's inventory.
		/// </summary>
		public Inventory Inventory { get; protected set; }

		/// <summary>
		/// Returns combined weight of all items the character is currently carrying.
		/// </summary>
		public float NowWeight { get { return this.Inventory.GetNowWeight(); } }

		/// <summary>
		/// Stat points.
		/// </summary>
		public float StatPoints { get { return (this.StatByLevel + this.StatByBonus - this.UsedStat); } }

		/// <summary>
		/// Stat points acquired by leveling?
		/// </summary>
		public float StatByLevel { get; set; }

		/// <summary>
		/// Bonus stat points?
		/// </summary>
		public float StatByBonus { get; set; }

		/// <summary>
		/// Amount of stat points spent.
		/// </summary>
		public float UsedStat { get; set; }

		/// <summary>
		/// Returns maximum weight the character can carry.
		/// </summary>
		/// <remarks>
		/// Base 5000, plus 5 for each Str/Con.
		/// </remarks>
		public float MaxWeight { get { return (5000 + this.Str * 5 + this.Con * 5); } }

		/// <summary>
		/// Returns ratio between NowWeight and MaxWeight.
		/// </summary>
		public float WeightRatio { get { return 100f / this.MaxWeight * this.NowWeight; } }

		/// <summary>
		/// Character's current speed.
		/// </summary>
		public float Speed { get; set; }

		/// <summary>
		/// Specifies whether the character currently updates the visible
		/// entities around the character.
		/// </summary>
		public bool EyesOpen { get; private set; }

		/// <summary>
		/// Character's scripting variables.
		/// </summary>
		public Variables Variables { get; private set; }

		public bool IsDead { get; set; }

		/// <summary>
		/// Creates new character.
		/// </summary>
		public Character()
		{
			this.Level = 1;
			this.Str = 1;
			this.Con = 1;
			this.Int = 1;
			this.Spr = 1;
			this.Dex = 1;
			this.Handle = ChannelServer.Instance.World.CreateHandle();
			this.Inventory = new Inventory(this);
			this.Variables = new Variables();
			this.Speed = 30;
			this.jobs = new Dictionary<Job, int>();
			this.skillManager = new SkillManager(this);
			this.statsManager = new StatsManager(this);
			this.statsManager.baseStats[(int)Stat.MovSpeed] = 20.0f; /// TODO: check where is the best place to set this value
			this.buffManager = new BuffManager(this);

			this.CollisionShape = new Circle(10.0f);
			this.LastMoveTimestamp = 0f;

			this.lastHpRegenTime = DateTime.Now;
			this.lastSpRegenTime = DateTime.Now;
		}

		/// <summary>
		/// Returns character's current speed.
		/// </summary>
		/// <returns></returns>
		public float GetSpeed()
		{
			return this.Speed;
		}

		/// <summary>
		/// Returns character's current jump strength.
		/// </summary>
		/// <returns></returns>
		public float GetJumpStrength()
		{
			return 300;
		}

		/// <summary>
		/// Returns character's jump type.
		/// </summary>
		/// <returns></returns>
		public int GetJumpType()
		{
			return 1;
		}

		/// <summary>
		/// Starts movement.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="dx"></param>
		/// <param name="dy"></param>
		public void Move(float x, float y, float z, float dx, float dy, float unkFloat)
		{
			// Check if is valid destionation
			/// TODO
			/// 
			this.IsMoveStop = false;
			if (this.LastMoveTimestamp > unkFloat)
			{
				return; // Old packet
			}



			//this.LastMoveTimestamp = unkFloat;

			// Set destination based on: SPEED + CLIENT GIVEN POSITION + DIRECTION
			// This function assumes that destination will be at 1 HeartBeatTime of distance
			// Destination should be larger, it should be sync-ed with current client "MOVE PACKETS" per second, or using some sort of acceleration.
			// The problem is seen when you hit any "move" key to any direction (in client) to move "little steps". If you set destination too far from client point, other players
			// will see your character moving forward and backwards to adjust its position).
			//this.SetDestination(new Position(this.GetSpeed() / (1000 / WorldManager.HeartbeatTime) * dx + x, y, this.GetSpeed() / 1000 / (WorldManager.HeartbeatTime) * dy + z));
			this.SetDestination(new Position(x, y, z));

			//Log.Debug("DESTINATION: {0},{1},{2} DIR: {3},{4}", _destination.X, _destination.Y, _destination.Z, dx.ToString("0.0000"), dy.ToString("0.0000"));


			// We re-calculate direction to destination, since our current position can be different than client's position.
			// By recalculating direction, we make sure we will end in the same point the client is. Even when we could get some packets delayed.
			// We don't keep a "queue" of movements, so based on delay we can be moving the Actor differently than client's actor.
			// In that case, we could "re-adjust" client's coordinates from time to time if we a great difference.
			// Note: unkFloat funtion'parameter is a DateTime (or something like that), probably to keep sync with server position.

			// Calculate direction to destination
			float vX = this._destination.X - this.Position.X;
			float vZ = this._destination.Z - this.Position.Z;
			float distDestination = (float)Math.Sqrt(vX * vX + vZ * vZ); /// TODO: We could try to avoid using Math.Sqrt() somehow.
			var cos = vX / distDestination; // Adjacent / Hipotenuse
			var sin = vZ / distDestination; // Oposit / Hipotenuse
			this.SetDirection(dx, dy);

			// Set flag indicating that this character is moving
			this.IsMoving = true;

			// Broadcast this movement
			Send.ZC_MOVE_DIR(this, x, y, z, dx, dy, unkFloat);
			
		}

		/// <summary>
		/// Process character
		/// </summary>
		public void Process()
		{
			if (this.IsMoving)
				ProcessMove();

			// Process buffs
			this.buffManager.RemoveExpiredBuffs();

			// Regeneration
			this.HPRegen();
			this.SPRegen();
			this.UpdateState();
		}

		private void HPRegen()
		{
			TimeSpan diff = DateTime.Now - this.lastHpRegenTime;
			//Log.Debug("{0} {1} {2} {3}", DateTime.Now.ToString(), this.lastHpRegenTime.ToString(), (int)diff.TotalMilliseconds, this.statsManager.stats[(int)Stat.RecoveryHP]);
			// Calculate current HP regen tick for this character
			int regenRate = 20000;
			if (this.IsSitting) regenRate = 10000;

			if ((int)diff.TotalMilliseconds < regenRate)
				return;

			this.lastHpRegenTime = DateTime.Now;

			if (this.Hp >= this.MaxHp)
				return;

			// Get amount to recover
			var HpRecoveryAmount = this.statsManager.stats[(int)Stat.RecoveryHP];

			Send.ZC_NORMAL_Unkown_3a(this, "I_SYS_heal2", HpRecoveryAmount.ToString());
			this.SetCurrentHp((int)(this.Hp + HpRecoveryAmount));

		}

		private void SPRegen()
		{
			TimeSpan diff = DateTime.Now - this.lastSpRegenTime;
			// Calculate current HP regen tick for this character
			int regenRate = 20000;
			if (this.IsSitting) regenRate = 10000;

			if ((int)diff.TotalMilliseconds < regenRate)
				return;

			this.lastSpRegenTime = DateTime.Now;

			if (this.Sp >= this.MaxSp)
				return;

			// Get amount to recover
			var SpRecoveryAmount = this.statsManager.stats[(int)Stat.RecoverySP];

			this.SetCurrentSp((int)(this.Sp + SpRecoveryAmount));
		}

		public void UpdateState()
		{

		}

		/// <summary>
		/// Process Character's movement
		/// </summary>
		public void ProcessMove()
		{
			if (!this.IsMoving)
				return;

			// Calculate distance to destination
			float vX = this._destination.X - this.Position.X;
			float vZ = this._destination.Z - this.Position.Z;
			float distDestination = (float)Math.Sqrt(vX * vX + vZ * vZ);

			// Set next position 
			// If destination can be reached in this Heartbeat, we go for it. Otherwise, we calculate the next position in the path.
			Position nextPosition;
			if (distDestination <= this.Speed)
			{
				// Get destination position as next position
				nextPosition = this._destination;
			} else
			{
				// Calculate next position in path to destination
				nextPosition = new Position((this.GetSpeed() / 5) * this.Direction.Cos + this.Position.X, this.Position.Y, (this.GetSpeed()/5) * this.Direction.Sin + this.Position.Z);
			}
			
			// Moves the actor
			if (this.Map.SectorManager.Move(this, nextPosition))
			{
				// Actor was sucessfully moved. Set new position
				this.SetPosition(nextPosition.X, nextPosition.Y, nextPosition.Z);

				// If character reached destination
				if (nextPosition == this._destination)
				{
					// Set moving flag to false.
					// Broadcast that this character stop moving.
					if (this.IsMoveStop)
					{
						this.IsMoving = false;
						Send.ZC_PC_MOVE_STOP(this, this.Position, this.Direction);
						//Send.ZC_ROTATE(this);
					}
				}
			} else
			{
				// Wasn't possible to move the actor. Abort movement.
				Log.Debug("Wasn't able to place the entity at position: {0},{1},{2}", nextPosition.X, nextPosition.Y, nextPosition.Z);
				this.IsMoving = false;
				this.IsMoveStop = true;
				Send.ZC_PC_MOVE_STOP(this, this.Position, this.Direction);
				//Send.ZC_ROTATE(this);
			}
				
		}

		/// <summary>
		/// Set character's destination position
		/// </summary>
		public void SetDestination(Position pos)
		{
			this._destination = pos;	
		}

		/// <summary>
		/// Stops movement.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="dx"></param>
		/// <param name="dy"></param>
		public void StopMove(float x, float y, float z, float dx, float dy, float unkFloat)
		{
			/*
			this.SetPosition(x, y, z);
			this.SetDirection(dx, dy);
			this.IsMoving = false;
			*/
			if (this.LastMoveTimestamp > unkFloat)
			{
				return; // Old packet
			}

			this.SetDestination(new Position(x, y, z));
			this.IsMoveStop = true;
			
			this.LastMoveTimestamp = unkFloat;
			// Sending ZC_MOVE_STOP works as well, but it doesn't have
			// a direction, so the character stops and looks north
			// on other's screens.
			//Send.ZC_PC_MOVE_STOP(this, this.Position, this.Direction);
		}

		/// <summary>
		/// Warps character to given location.
		/// </summary>
		/// <param name="mapId"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <exception cref="ArgumentException">Thrown if map doesn't exist in data.</exception>
		public void Warp(string mapName, float x, float y, float z)
		{
			var map = ChannelServer.Instance.Data.MapDb.Find(mapName);
			if (map == null)
				throw new ArgumentException("Map '" + mapName + "' not found in data.");

			this.Warp(map.Id, x, y, z);
		}

		/// <summary>
		/// Warps character to given location.
		/// </summary>
		/// <param name="loc"></param>
		public void Warp(Location loc)
		{
			this.Warp(loc.MapId, loc.X, loc.Y, loc.Z);
		}

		/// <summary>
		/// Warps character to given location.
		/// </summary>
		/// <param name="mapId"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <exception cref="ArgumentException">Thrown if map doesn't exist in world.</exception>
		public void Warp(int mapId, float x, float y, float z)
		{
			var map = ChannelServer.Instance.World.GetMap(mapId);
			if (map == null)
				throw new ArgumentException("Map with id '" + mapId + "' doesn't exist in world.");

			this.Position = new Position(x, y, z);

			if (this.MapId == mapId)
			{
				Send.ZC_SET_POS(this);
			}
			else
			{
				this.MapId = mapId;
				_warping = true;

				Send.ZC_MOVE_ZONE(this.Connection);
			}
		}

		/// <summary>
		/// Finalizes warp, after client announced readiness.
		/// </summary>
		public void FinalizeWarp()
		{
			// Check permission
			if (!_warping)
			{
				Log.Warning("Character.FinalizeWarp: Player '{0}' tried to warp without permission.", this.AccountId);
				return;
			}

			_warping = false;

			ChannelServer.Instance.Database.SaveCharacter(this);

			// Get channel
			var channelId = 1;
			var channelServer = ChannelServer.Instance.Data.ServerDb.FindChannel(channelId);
			if (channelServer == null)
			{
				Log.Error("Channel with id '{0}' not found.", channelId);
				return;
			}

			Send.ZC_MOVE_ZONE_OK(this.Connection, channelServer.Ip, channelServer.Port, this.MapId);
		}

		/// <summary>
		/// Increases character's level by the given amount of levels.
		/// </summary>
		public void LevelUp(int amount)
		{
			this.Level += amount;
			this.StatByLevel += amount;
			this.MaxExp = ChannelServer.Instance.Data.ExpDb.GetExp(this.Level);

			// packet = new Packet(Op.ZC_OBJECT_PROPERTY);
			//packet.PutLong(target.Id);
			//packet.PutBinFromHex("8E 10 00 00 00 40 98 10 00 00 40 41 33 11 00 00 E4 42 29 11 00 80 83 43 36 11 00 00 A0 40 37 11 00 00 A0 40 59 11 00 00 00 41 70 11 00 00 10 41 2F 11 00 00 A0 40 6B 11 00 00 10 41 D5 11 00 00 E0 40 CD 11 00 00 E0 40 CF 11 00 00 50 41 D2 11 00 00 40 41 E0 11 00 00 48 42 D7 11 00 00 0C 43 DE 10 53 9A 0E 40");
			//conn.Send(packet);

			//packet = new Packet(Op.ZC_NORMAL);
			//packet.PutBinFromHex("1C 00 00 00 ");
			//packet.PutInt(target.Handle);
			//packet.PutBinFromHex("00 75 77 78 04 00 00 00 00 9A E7 8A C4 74 76 82 43 39 0C 09 C4 F2 04 35 BF F4 04 35 BF 00 00 00 00 00 00 00 00 00 00 00 00");
			//conn.Send(packet);

			//packet = new Packet(Op.ZC_UPDATE_ALL_STATUS);
			//packet.PutInt(target.Handle);
			//packet.PutBinFromHex("07 01 00 00 07 01 00 00 72 00 72 00 09 00 00 00");
			//conn.Send(packet);

			Send.ZC_MAX_EXP_CHANGED(this, 0);
			Send.ZC_PC_LEVELUP(this);
			Send.ZC_OBJECT_PROPERTY(this, ObjectProperty.PC.StatByLevel);
			Send.ZC_NORMAL_LevelUp(this);

			//packet = new Packet(Op.ZC_PC_PROP_UPDATE);
			//packet.PutBinFromHex("DA 10 00");
			//conn.Send(packet);

			//packet = new Packet(Op.ZC_PC_PROP_UPDATE);
			//packet.PutBinFromHex("0F 11 00");
			//conn.Send(packet);
		}

		/// <summary>
		/// Increases character's level by one.
		/// </summary>
		public void LevelUp()
		{
			this.LevelUp(1);
		}

		/// <summary>
		/// Grants exp to character and handles level ups.
		/// </summary>
		/// <param name="exp"></param>
		public void GiveExp(int exp, int jobExp, Monster monster)
		{
			this.Exp += exp;
			// TODO: jobExp

			Send.ZC_EXP_UP_BY_MONSTER(this, exp, 0, monster);
			Send.ZC_EXP_UP(this, exp, 0);

			while (this.Exp >= this.MaxExp)
			{
				this.Exp -= this.MaxExp;
				this.LevelUp();
			}
		}

		/// <summary>
		/// Returns ids of equipped items.
		/// </summary>
		/// <returns></returns>
		public int[] GetEquipIds()
		{
			return this.Inventory.GetEquipIds();
		}

		/// <summary>
		/// Updates visible entities around character.
		/// </summary>
		public void LookAround()
		{
			if (!this.EyesOpen)
				return;

			lock (_lookAroundLock)
			{
				// Get lists
				var currentlyVisibleMonsters = this.Map.GetVisibleMonsters(this);
				var currentlyVisibleCharacters = this.Map.GetVisibleCharacters(this);

				// Appears
				var appearMonsters = currentlyVisibleMonsters.Except(_visibleMonsters);
				var appearCharacters = currentlyVisibleCharacters.Except(_visibleCharacters);

				// Disappears
				var disappearMonsters = _visibleMonsters.Except(currentlyVisibleMonsters);
				var disappearCharacters = _visibleCharacters.Except(currentlyVisibleCharacters);

				// Monsters
				foreach (var monster in appearMonsters)
					Send.ZC_ENTER_MONSTER(this.Connection, monster);

				foreach (var monster in disappearMonsters)
					Send.ZC_LEAVE(this.Connection, monster);

				// Characters
				foreach (var character in appearCharacters)
					Send.ZC_ENTER_PC(this.Connection, character);

				foreach (var character in disappearCharacters)
					Send.ZC_LEAVE(this.Connection, character);

				// Save lists for next run
				_visibleMonsters = currentlyVisibleMonsters;
				_visibleCharacters = currentlyVisibleCharacters;
			}
		}

		/// <summary>
		/// Starts auto-updates of visible entities.
		/// </summary>
		public void OpenEyes()
		{
			this.EyesOpen = true;
			this.LookAround();
		}

		/// <summary>
		/// Stops auto-updates of visible entities.
		/// </summary>
		public void CloseEyes()
		{
			this.EyesOpen = false;

			lock (_lookAroundLock)
			{
				foreach (var monster in _visibleMonsters)
					Send.ZC_LEAVE(this.Connection, monster);

				foreach (var character in _visibleCharacters)
					Send.ZC_LEAVE(this.Connection, character);

				_visibleMonsters = new Monster[0];
				_visibleCharacters = new Character[0];
			}
		}

		/// <summary>
		/// Sets direction and updates clients.
		/// </summary>
		/// <param name="d1"></param>
		/// <param name="d2"></param>
		public void Rotate(float d1, float d2)
		{
			this.SetDirection(d1, d2);
			Send.ZC_ROTATE(this);
		}

		/// <summary>
		/// Sets direction and updates clients.
		/// </summary>
		/// <param name="d1"></param>
		/// <param name="d2"></param>
		public void RotateHead(float d1, float d2)
		{
			this.SetHeadDirection(d1, d2);
			Send.ZC_HEAD_ROTATE(this);
		}

		public bool OnVisit(Actor actor)
		{
			return true;
		}

		public bool LearnSkill(SkillTreeInfo skillTreeData, int levels)
		{
			// Check if received a valid skillTreeData
			if (skillTreeData == null)
				return false;

			// Check if this skill is among one of this character's jobs.
			if (!this.jobs.ContainsKey((Job)skillTreeData.JobId))
				return false;

			// Check if character has the right Job Grade to learn this skill
			if (skillTreeData.UnlockGrade > this.jobs[(Job)skillTreeData.JobId])
			{
				Log.Warning("User '{0}' tried to learn a skill locked for his job.", Connection.Account.Name);
				return false;
			}

			skillManager.LearnSkill(skillTreeData, levels);

			return true;
		}

		public void SetAttackState(bool isAttacking)
		{
			this.IsAttacking = true;
			Send.ZC_PC_ATKSTATE(this, isAttacking);
		}

		public void SetCurrentSp(int sp)
		{
			if (this.Sp == sp)
				return;

			this.Sp = Math2.Clamp(0, this.MaxSp, sp);
			Send.ZC_UPDATE_SP(this, (short)this.Sp);
		}

		public void SetCurrentHp(int newHp)
		{
			if (this.Hp == newHp)
				return;

			this.Hp = Math2.Clamp(0, this.MaxHp, newHp);
			Send.ZC_ADD_HP(this, this.Hp);
		}

		

		public bool IntersectWith(Actor actor)
		{
			return this.CollisionShape.IntersectWith(actor.CollisionShape);
		}

		public int Heal(int amount, bool isPercent)
		{
			Log.Debug("Heal function ----- ");
			if (this.Hp >= this.MaxHp)
				return 0;

			Log.Debug("Heal function {0} {1}", amount, isPercent);
			int amountToHeal;
			if (isPercent)
				amountToHeal = (amount * this.MaxHp / 100);
			else
				amountToHeal = amount;

			Log.Debug("PRE amountToHeal: {0}", amountToHeal);



			int HpRemaining = this.MaxHp - this.Hp;
			Log.Debug("HP {2} HPMAX {1} HpRemaining: {0}", HpRemaining, this.MaxHp, this.Hp);
			if (HpRemaining <= 0)
				return 0;

			if (HpRemaining < amountToHeal)
				amountToHeal = HpRemaining;

			Log.Debug("amountToHeal: {0}", amountToHeal);

			// Proceed to increase HP
			this.Hp = Math2.Clamp(0, this.MaxHp, this.Hp + amountToHeal);

			Log.Debug("new HP {0}", this.Hp);
			Log.Debug("------------------------");


			Send.ZC_HEAL_INFO(this, amountToHeal, this.Hp);
			Send.ZC_UPDATE_ALL_STATUS(this, this.Hp, this.MaxHp, (short)this.Sp, (short)this.MaxSp);

			return amountToHeal;

		}

		public void UseWeapon()
		{
			// Get equipped weapon
			Item weapon = this.Inventory.GetItem(EquipSlot.RightHand);
			if (weapon != null) {
				if (weapon is Weapon)
				{
					((Weapon)weapon).Fire();
				}
				else
				{
					// Dummy weapon
					/// Dummy weapon should be a valid weapon class.
					/// 
					Skill skill = this.skillManager.GetSkill(100);
					if (skill != null)
						skill.Activate();
				}
			}
			
				
		}

		public float AdjustInfringedDamage(float damage)
		{
			float finalDamage = damage;
			Random rnd = ChannelServer.Instance.rnd;
			int damageType = 0;
			switch (damageType)
			{
				case 0:
					int damagePAtk = rnd.Next((int)this.statsManager.stats[(int)Stat.MINPATK], (int)this.statsManager.stats[(int)Stat.MAXPATK]);
					finalDamage = damage + damagePAtk;
					break;
				case 1:
					int damageMAtk = rnd.Next((int)this.statsManager.stats[(int)Stat.MINMATK], (int)this.statsManager.stats[(int)Stat.MAXMATK]);
					finalDamage = damage + damageMAtk;
					break;
				default:
					break;
			}

			return finalDamage;
		}
		public float AdjustReceivedDamage(float damage)
		{
			return damage;
		}

	}
}
