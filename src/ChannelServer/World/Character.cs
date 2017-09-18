﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Linq;
using Melia.Channel.Network;
using Melia.Channel.Scripting;
using Melia.Shared.Const;
using Melia.Shared.Network.Helpers;
using Melia.Shared.Util;
using Melia.Shared.World;
using Melia.Shared.World.ObjectProperties;

namespace Melia.Channel.World
{
	public class Character : IEntity, ICommander, IPropertyObject
	{
		private bool _warping;

		private object _lookAroundLock = new object();
		
		private Monster[] _visibleMonsters = new Monster[0];
		private Character[] _visibleCharacters = new Character[0];

		/// <summary>
		/// Connection this character uses.
		/// </summary>
		public ChannelConnection Connection { get; set; }

		/// <summary>
		/// Character's unique id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Character's globally unique id.
		/// </summary>
		/// <remarks>
		/// This is basically the same as Id... but until we're entirely
		/// sure this object business works the way we think it does,
		/// I'll leave it as a reference. At least it seems like the
		/// id doesn't change across play sessions.
		/// </remarks>
		public long ObjectId => this.Id;

		/// <summary>
		/// Id of the character's account.
		/// </summary>
		public long AccountId { get; set; }

		/// <summary>
		/// Index in world collection?
		/// </summary>
		public int Handle { get; private set; }

		/// <summary>
		/// Character's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Character's team name.
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// Character's base job.
		/// </summary>
		public JobId Job { get; set; }

		/// <summary>
		/// Character's jobs.
		/// </summary>
		/// <remarks>
		/// A character has one base job which determines, for example,
		/// what items they can equip, but they can have various jobs,
		/// that all come with their own skills and abilities.
		/// </remarks>
		public Jobs Jobs { get; }

		/// <summary>
		/// Character's gender.
		/// </summary>
		public Gender Gender { get; set; }

		/// <summary>
		/// Character's hair style.
		/// </summary>
		public byte Hair { get; set; }

		/// <summary>
		/// Returns stance, based on job and other factors.
		/// </summary>
		/// <remarks>
		/// The stance is affected by the equipped items and other factors.
		/// For the official conditions see stancecondition.ies.
		/// </remarks>
		public int Stance
		{
			get
			{
				switch (this.Job.ToClass())
				{
					default:
					case Class.Swordsman: return 10000;
					case Class.Wizard: return 10006;
					case Class.Archer: return 10008;
					case Class.Cleric:
					case Class.GM: return 10004;
				}
			}
		}

		/// <summary>
		/// The map the character is in.
		/// </summary>
		public int MapId { get; set; }

		/// <summary>
		/// The map the character is currently on.
		/// </summary>
		/// <remarks>
		/// Since every map change includes a reconnect, the map reference
		/// will only ever be set once, upon connection.
		/// </remarks>
		public Map Map { get { return _map; } set { _map = value ?? Map.Limbo; } }
		private Map _map = Map.Limbo;

		/// <summary>
		/// Character's current position.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// Character's direction.
		/// </summary>
		public Direction Direction { get; set; }

		/// <summary>
		/// Character's head's direction.
		/// </summary>
		public Direction HeadDirection { get; set; }

		/// <summary>
		/// Gets or sets whether the character is moving.
		/// </summary>
		public bool IsMoving { get; set; }

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
		/// Stat points acquired by leveling.
		/// </summary>
		public float StatByLevel
		{
			get { return _statByLevel; }
			set { _statByLevel = Math2.Clamp(0, short.MaxValue, value); }
		}
		private float _statByLevel;

		/// <summary>
		/// Stat points acquired by other means than leveling.
		/// </summary>
		public float StatByBonus
		{
			get { return _statByBonus; }
			set { _statByBonus = Math2.Clamp(0, short.MaxValue, value); }
		}
		private float _statByBonus;

		/// <summary>
		/// Amount of stat points spent.
		/// </summary>
		/// <remarks>
		/// Clamped between 0 and total amount of character's stat points.
		/// </remarks>
		public float UsedStat
		{
			get { return _usedStat; }
			set { _usedStat = Math2.Clamp(0, this.StatByLevel + this.StatByBonus, value); }
		}
		private float _usedStat;

		/// <summary>
		/// Returns maximum weight the character can carry.
		/// </summary>
		/// <remarks>
		/// At release: Base 5000, plus 5 for each Str/Con.
		/// Now: Base 8000 plus bonuses?
		/// </remarks>
		public float MaxWeight { get { return (8000); } }

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

		/// <summary>
		/// Specifies which hats are visible on the character.
		/// </summary>
		/// <remarks>
		/// TODO: Handle toggling and save/load with character.
		/// </remarks>
		public HatVisibleStates VisibleHats { get { return HatVisibleStates.Hat1 | HatVisibleStates.Hat2 | HatVisibleStates.Hat3; } }

		/// <summary>
		/// Character's level.
		/// </summary>
		public int Level { get; set; }

		/// <summary>
		/// Current experience points.
		/// </summary>
		public int Exp { get; set; }

		/// <summary>
		/// Current maximum experience points.
		/// </summary>
		public int MaxExp { get; set; }

		/// <summary>
		/// Gets or sets character's strength (STR).
		/// </summary>
		public float Str { get; set; }

		/// <summary>
		/// Gets or sets character's vitality (CON).
		/// </summary>
		public float Con { get; set; }

		/// <summary>
		/// Gets or sets character's intelligence (INT).
		/// </summary>
		public float Int { get; set; }

		/// <summary>
		/// Gets or sets character's spirit (SPR/MNA).
		/// </summary>
		public float Spr { get; set; }

		/// <summary>
		/// Gets or sets character's agility (DEX).
		/// </summary>
		public float Dex { get; set; }
		
		/// <summary>
		/// Returns the HP base stat.
		/// TODO: This is only to satisfy the entity interface requirements.
		/// If entities also include base stats, then that interface should be updated, and this property should be removed.
		/// </summary>
		public int Hp { get { return this.BaseStat.Hp; } }

		/// <summary>
		/// Character's session objects.
		/// </summary>
		public SessionObjects SessionObjects { get; } = new SessionObjects();

		/// <summary>
		/// Character's properties.
		/// </summary>
		/// <remarks>
		/// Beware, some of these are reference properties, that can't be
		/// set directly. Use this object's actual properties whenever
		/// possible.
		/// </remarks>
		public Properties Properties { get; } = new Properties();

		public IBaseStat BaseStat { get; }

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
			this.Jobs = new Jobs(this);
			this.Variables = new Variables();
			this.BaseStat = new BaseStat(this);
			this.Speed = 30;

			this.AddSessionObjects();
			this.AddReferenceProperties();
		}

		/// <summary>
		/// Adds default session objects.
		/// </summary>
		private void AddSessionObjects()
		{
			// The exact purpose of those objects is unknown right now,
			// but apparently they hold some properties of importance.
			// For now we'll add only one, to be able to get rid of the
			// message "You can buy items from a shop", which has been
			// bugging me. I know I can buy items! I coded that!
			this.SessionObjects.Add(new SessionObject(SessionObjectId.Jansori));
		}

		/// <summary>
		/// Adds default reference properties.
		/// </summary>
		private void AddReferenceProperties()
		{
			// Beautiful. No duplication of any data, and we can use our
			// normal C# properties. XXX: We could technically use reflection
			// to add these automatically.

			this.Properties.Add(new RefFloatProperty(PropertyId.PC.HP, () => this.BaseStat.Hp));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.MHP, () => this.BaseStat.MaxHp));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.SP, () => this.BaseStat.Sp));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.MSP, () => this.BaseStat.MaxSp));

			this.Properties.Add(new RefFloatProperty(PropertyId.PC.STR, () => this.Str));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.CON, () => this.Con));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.INT, () => this.Int));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.MNA, () => this.Spr));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.DEX, () => this.Dex));

			this.Properties.Add(new RefFloatProperty(PropertyId.PC.NowWeight, () => this.NowWeight));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.MaxWeight, () => this.MaxWeight));

			this.Properties.Add(new RefFloatProperty(PropertyId.PC.StatByLevel, () => this.StatByLevel));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.StatByBonus, () => this.StatByBonus));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.UsedStat, () => this.UsedStat));
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
		/// Sets character's position.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		public void SetPosition(float x, float y, float z)
		{
			this.Position = new Position(x, y, z);
		}

		/// <summary>
		/// Sets character's direction.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public void SetDirection(float x, float y)
		{
			this.Direction = new Direction(x, y);
		}

		/// <summary>
		/// Sets character's direction.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		public void SetHeadDirection(float x, float y)
		{
			this.HeadDirection = new Direction(x, y);
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
			this.SetPosition(x, y, z);
			this.SetDirection(dx, dy);
			this.IsMoving = true;

			Send.ZC_MOVE_DIR(this, x, y, z, dx, dy, unkFloat);
		}

		/// <summary>
		/// Stops movement.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="dx"></param>
		/// <param name="dy"></param>
		public void StopMove(float x, float y, float z, float dx, float dy)
		{
			this.SetPosition(x, y, z);
			this.SetDirection(dx, dy);
			this.IsMoving = false;

			// Sending ZC_MOVE_STOP works as well, but it doesn't have
			// a direction, so the character stops and looks north
			// on other's screens.
			Send.ZC_PC_MOVE_STOP(this, this.Position, this.Direction);
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
			Send.ZC_OBJECT_PROPERTY(this, PropertyId.PC.StatByLevel);
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
				{
					Send.ZC_ENTER_MONSTER(this.Connection, monster);
					Send.ZC_FACTION(this.Connection, monster, FactionType.Npc);
				}

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

		/// <summary>
		/// Returns the character's current location.
		/// </summary>
		/// <returns></returns>
		public Location GetLocation()
		{
			return new Location(this.MapId, this.Position);
		}

		/// <summary>
		/// Sends server message to character.
		/// </summary>
		/// <remarks>
		/// Abuses a certain system message that takes two parameters,
		/// which are then output, separated by a colon. Since there's
		/// no customizable server message packet I know of, this will
		/// serve as the next best thing for now, and is certainly an
		/// improvement over using ZC_CHAT.
		/// </remarks>
		/// <param name="format"></param>
		/// <param name="args"></param>
		public void ServerMessage(string format)
		{
			Send.ZC_SYSTEM_MSG(this, 21254, new MsgParameter("Hour", "Server "), new MsgParameter("Min", " " + format));
		}

		/// <summary>
		/// Sends server message to character.
		/// </summary>
		/// <param name="format"></param>
		/// <param name="args"></param>
		public void ServerMessage(string format, params object[] args)
		{
			this.ServerMessage(string.Format(format, args));
		}

		/// <summary>
		/// Adds amount to character's stat points and updates the client.
		/// </summary>
		/// <param name="modifier"></param>
		public void AddStatPoints(int amount)
		{
			if (amount < 1)
				throw new ArgumentException("Amount can't be negative.");

			this.StatByBonus += amount;

			Send.ZC_OBJECT_PROPERTY(this, PropertyId.PC.StatByBonus);
		}
	}
}
