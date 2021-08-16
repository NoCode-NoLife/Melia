// Copyright (c) Aura development team - Licensed under GNU GPL
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
		private object _hpLock = new object();
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
		/// Character's base job's id.
		/// </summary>
		public JobId JobId { get; set; }

		/// <summary>
		/// Character's base job's class.
		/// </summary>
		public JobClass JobClass => this.JobId.ToClass();

		/// <summary>
		/// Returns reference to character's base job, based on JobId.
		/// </summary>
		public Job Job => this.Jobs.Get(this.JobId);

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
		public int Stance { get; protected set; }

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
		public int StatPoints { get { return (this.StatByLevel + this.StatByBonus - this.UsedStat); } }

		/// <summary>
		/// Stat points acquired by leveling.
		/// </summary>
		public int StatByLevel
		{
			get { return _statByLevel; }
			set { _statByLevel = Math2.Clamp(0, short.MaxValue, value); }
		}
		private int _statByLevel;

		/// <summary>
		/// Stat points acquired by other means than leveling.
		/// </summary>
		public int StatByBonus
		{
			get { return _statByBonus; }
			set { _statByBonus = Math2.Clamp(0, short.MaxValue, value); }
		}
		private int _statByBonus;

		/// <summary>
		/// Amount of stat points spent.
		/// </summary>
		/// <remarks>
		/// Clamped between 0 and total amount of character's stat points.
		/// </remarks>
		public int UsedStat
		{
			get { return _usedStat; }
			set { _usedStat = Math2.Clamp(0, this.StatByLevel + this.StatByBonus, value); }
		}
		private int _usedStat;

		/// <summary>
		/// Gets or set the character's ability points.
		/// </summary>
		/// <remarks>
		/// Clamped between 0 and short.Max.
		/// </remarks>
		public int AbilityPoints
		{
			get { return _abilityPoints; }
			set { _abilityPoints = Math2.Clamp(0, short.MaxValue, value); }
		}
		private int _abilityPoints;

		/// <summary>
		/// Gets or set the character's greeting message.
		/// </summary>
		/// <remarks>
		/// None yet
		/// </remarks>
		public string GreetingMessage { get; set;}

		/// <summary>
		/// Returns maximum weight the character can carry.
		/// </summary>
		/// <remarks>
		/// At release: Base 5000, plus 5 for each Str/Con.
		/// Now: Base 8000 plus bonuses?
		/// </remarks>
		public int MaxWeight { get { return (8000); } }

		/// <summary>
		/// Returns ratio between NowWeight and MaxWeight.
		/// </summary>
		public float WeightRatio { get { return 100f / this.MaxWeight * this.NowWeight; } }

		/// <summary>
		/// Character's current speed.
		/// </summary>
		public float Speed { get; set; }

		/// <summary>
		/// Character's current casting speed.
		/// </summary>
		public float CastingSpeed { get; set; }

		/// <summary>
		/// Holds the order of successive changes in character HP.
		/// A higher value indicates the latest damage taken.
		/// </summary>
		/// TODO: I'm not sure when this gets rolled over;
		///   More investigation is needed.
		public int HpChangeCounter { get; private set; }

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
		/// Character's class level.
		/// </summary>
		public int ClassLevel
		{
			get
			{
				// TODO: This should be improved, but I'll be lazy
				//   for the moment, in case all this doesn't work out the
				//   way I expect it to.

				var jobId = this.JobId;
				var rank = this.Jobs.GetCurrentRank();
				var totalExp = this.Jobs.Get(jobId).TotalExp;
				var max = 15; // TODO: Const? Conf? Determine based on exp db?

				// Search for the first level which's requirement we can't
				// fulfill, as that will be the level we're on.
				for (var i = 1; i < max; ++i)
				{
					var needed = ChannelServer.Instance.Data.ExpDb.GetNextTotalClassExp(rank, i);
					if (totalExp < needed)
						return i;
				}

				// Found none? It's the max then.
				return max;
			}
		}

		/// <summary>
		/// Current experience points.
		/// </summary>
		public int Exp { get; set; }

		/// <summary>
		/// Current maximum experience points.
		/// </summary>
		public int MaxExp { get; set; }

		/// <summary>
		/// Total number of accumulated experience points.
		/// </summary>
		public int TotalExp { get; set; }

		/// <summary>
		/// Gets or set HP, clamped between 0 and MaxHp.
		/// </summary>
		public int Hp
		{
			get { return _hp; }
			set { _hp = Math2.Clamp(0, this.MaxHp, value); }
		}
		private int _hp;

		/// <summary>
		/// Maximum HP.
		/// </summary>
		public int MaxHp { get; set; }

		/// <summary>
		/// Gets or sets SP, clamped between 0 and MaxSp.
		/// </summary>
		public int Sp
		{
			get { return _sp; }
			set { _sp = Math2.Clamp(0, this.MaxSp, value); }
		}
		private int _sp;

		/// <summary>
		/// Maximum SP.
		/// </summary>
		public int MaxSp { get; set; }

		/// <summary>
		/// Gets or set Stamina, clamped between 0 and MaxStamina.
		/// </summary>
		public int Stamina
		{
			get { return _stamina; }
			set { _stamina = Math2.Clamp(0, this.MaxStamina, value); }
		}
		private int _stamina;

		/// <summary>
		/// Maximum stamina.
		/// </summary>
		public int MaxStamina { get; set; }

		/// <summary>
		/// Gets or sets character's strength (STR).
		/// </summary>
		public int Str { get; set; }

		/// <summary>
		/// Gets or sets character's vitality (CON).
		/// </summary>
		public int Con { get; set; }

		/// <summary>
		/// Gets or sets character's intelligence (INT).
		/// </summary>
		public int Int { get; set; }

		/// <summary>
		/// Gets or sets character's spirit (SPR/MNA).
		/// </summary>
		public int Spr { get; set; }

		/// <summary>
		/// Gets or sets character's agility (DEX).
		/// </summary>
		public int Dex { get; set; }

		/// <summary>
		/// Character's session objects.
		/// </summary>
		public SessionObjects SessionObjects { get; } = new SessionObjects();

		/// <summary>
		/// Character's skills.
		/// </summary>
		public Skills Skills { get; }

		/// <summary>
		/// Character's abilities.
		/// </summary>
		public Abilities Abilities { get; }

		/// <summary>
		/// Character's properties.
		/// </summary>
		/// <remarks>
		/// Beware, some of these are reference properties, that can't be
		/// set directly. Use this object's actual properties whenever
		/// possible.
		/// </remarks>
		public Properties Properties { get; } = new Properties();

		/// <summary>
		/// The character's splash rate?
		/// </summary>
		/// <remarks>
		/// Used together with skill's splash rates.
		/// TODO: Figure out where it comes from (official name: SR).
		/// TODO: Check if it changes with jobs, items, stances, etc.
		/// </remarks>
		public float SplashRate { get; } = 4;

		/// <summary>
		/// Returns minimum physical ATK.
		/// </summary>
		public int MinPAtk
		{
			get
			{
				var baseValue = 20;
				var level = this.Level;
				var stat = this.Str;

				var byLevel = level / 2f;
				var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * 5f);
				var byItem = 0; // TODO: Cached MinPAtk for inventory/equip ("MINATK", "PATK", "ADD_MINATK")

				var value = baseValue + byLevel + byStat + byItem;

				// Reducation for shields and stuff?
				//value -= leftHand.MinAtk;
				//if(hasBuff("Warrior_RH_VisibleObject"))
				//    value -= rightHand.MinAtk

				// Buffs: "PATK_BM", "MINPATK_BM"
				var byBuffs = 0;

				// Rate buffs: "PATK_RATE_BM", "MINPATK_RATE_BM"
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs + byRateBuffs;

				var maxPatk = this.MaxPAtk;
				if (value > maxPatk)
					return maxPatk;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns maximum physical ATK.
		/// </summary>
		public int MaxPAtk
		{
			get
			{
				var baseValue = 20;
				var level = this.Level;
				var stat = this.Str;

				var byLevel = level / 2f;
				var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * 5f);
				var byItem = 0; // TODO: Cached MinPAtk for inventory/equip ("MAXATK", "PATK", "ADD_MAXATK")

				var value = baseValue + byLevel + byStat + byItem;

				// Reducation for shields and stuff?
				//value -= leftHand.MaxAtk;
				//if(hasBuff("Warrior_RH_VisibleObject"))
				//    value -= rightHand.MaxAtk;

				// Buffs: "PATK_BM", "MAXPATK_BM"
				var byBuffs = 0;

				// Rate buffs: "PATK_RATE_BM", "MAXPATK_RATE_BM"
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs + byRateBuffs;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns minimum magic ATK.
		/// </summary>
		public int MinMAtk
		{
			get
			{
				var baseValue = 20;
				var level = this.Level;
				var stat = this.Int;

				var byLevel = level / 2f;
				var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * 5f);
				var byItem = 0; // TODO: Cached MinPAtk for inventory/equip ("MATK", "ADD_MATK", "ADD_MINATK")

				var value = baseValue + byLevel + byStat + byItem;

				//if(hasBuff("Warrior_RH_VisibleObject"))
				//    value -= rightHand.MAtk

				// Buffs: "MATK_BM", "MINMATK_BM"
				var byBuffs = 0;

				// Rate buffs: "MATK_RATE_BM", "MINMATK_RATE_BM"
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs + byRateBuffs;

				var max = this.MaxMAtk;
				if (value > max)
					return max;

				return (int)value;
			}
		}

		/// <summary>
		/// Returns maximum magic ATK.
		/// </summary>
		public int MaxMAtk
		{
			get
			{
				var baseValue = 20;
				var level = this.Level;
				var stat = this.Int;

				var byLevel = level / 2f;
				var byStat = (stat * 2f) + ((float)Math.Floor(stat / 10f) * 5f);
				var byItem = 0; // TODO: Cached MinPAtk for inventory/equip ("MATK", "ADD_MATK", "ADD_MAXATK")

				var value = baseValue + byLevel + byStat + byItem;

				//if(hasBuff("Warrior_RH_VisibleObject"))
				//    value -= rightHand.MAtk

				// Buffs: "MATK_BM", "MAXMATK_BM"
				var byBuffs = 0;

				// Rate buffs: "MATK_RATE_BM", "MAXMATK_RATE_BM"
				var rate = 0;
				var byRateBuffs = (float)Math.Floor(value * rate);

				value += byBuffs + byRateBuffs;

				return (int)value;
			}
		}

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
			this.Skills = new Skills(this);
			this.Abilities = new Abilities(this);
			this.Variables = new Variables();
			this.Speed = 30;
			this.CastingSpeed = 100;

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

			this.Properties.Add(new RefFloatProperty(PropertyId.PC.Lv, () => this.Level));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.BeforeLv, () => this.Level));

			this.Properties.Add(new RefFloatProperty(PropertyId.PC.HP, () => this.Hp));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.MHP, () => this.MaxHp));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.SP, () => this.Sp));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.MSP, () => this.MaxSp));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.MaxSta, () => this.MaxStamina));

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
			this.Properties.Add(new RefStringProperty(PropertyId.PC.AbilityPoint, () => this.AbilityPoints.ToString()));

			this.Properties.Add(new RefFloatProperty(PropertyId.PC.SR, () => this.SplashRate));

			this.Properties.Add(new RefFloatProperty(PropertyId.PC.MINPATK, () => this.MinPAtk));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.MAXPATK, () => this.MaxPAtk));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.MINMATK, () => this.MinMAtk));
			this.Properties.Add(new RefFloatProperty(PropertyId.PC.MAXMATK, () => this.MaxMAtk));
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
		/// Returns character's current speed.
		/// </summary>
		/// <returns></returns>
		public float GetCastingSpeed()
		{
			return this.CastingSpeed;
		}

		/// <summary>
		/// Returns character's current jump strength.
		/// </summary>
		/// <returns></returns>
		public float GetJumpStrength()
		{
			return 350;
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
		public void Jump(float x, float y, float z, float dx, float dy, float unkFloat, byte unkByte)
		{
			this.SetPosition(x, y, z);
			this.SetDirection(dx, dy);
			this.IsMoving = true;

			Send.ZC_JUMP(this, x, y, z, dx, dy, unkFloat, unkByte);
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
		/// Increases character's level by the given amount.
		/// </summary>
		/// <param name="amount"></param>
		public void LevelUp(int amount = 1)
		{
			if (amount < 1)
				throw new ArgumentException("Amount can't be lower than 1.");

			this.Level += amount;
			this.StatByLevel += amount;
			this.MaxExp = ChannelServer.Instance.Data.ExpDb.GetNextExp(this.Level);

			Send.ZC_MAX_EXP_CHANGED(this, 0);
			Send.ZC_PC_LEVELUP(this);
			Send.ZC_OBJECT_PROPERTY(this);
			Send.ZC_ADDON_MSG(this, 3, "NOTICE_Dm_levelup_base", "!@#$Auto_KaeLigTeo_LeBeli_SangSeungHayeossSeupNiDa#@!");
			Send.ZC_NORMAL_LevelUp(this);
		}

		/// <summary>
		/// Gives skill points to the current job and updates client.
		/// </summary>
		/// <param name="amount"></param>
		private void ClassLevelUp(int amount = 1)
		{
			if (amount < 1)
				throw new ArgumentException("Amount can't be lower than 1.");

			this.Jobs.ModifySkillPoints(this.JobId, amount);

			Send.ZC_OBJECT_PROPERTY(this);
			Send.ZC_ADDON_MSG(this, 3, "NOTICE_Dm_levelup_skill", "!@#$Auto_KeulLeSeu_LeBeli_SangSeungHayeossSeupNiDa#@!");
			Send.ZC_NORMAL_ClassLevelUp(this);
		}

		/// <summary>
		/// Modifies character's HP by the given amount and updates the
		/// client with ZC_ADD_HP.
		/// </summary>
		/// <param name="amount"></param>
		public void ModifyHp(int amount)
		{
			int hp, priority;
			var negative = (amount < 0);

			// Make sure it's not possible for two calls to interfere
			// with each other, so that the correct amount makes it to
			// the client, with the correct priority.
			lock (_hpLock)
			{
				hp = (this.Hp += amount);
				priority = (this.HpChangeCounter += 1);
			}

			Send.ZC_ADD_HP(this, amount, negative, hp, priority);
		}

		/// <summary>
		/// Modifies the character's ability points by the given amount
		/// and updates the respective property on the client.
		/// </summary>
		/// <param name="amount"></param>
		public void ModifyAbilityPoints(int amount)
		{
			this.AbilityPoints += amount;
			Send.ZC_OBJECT_PROPERTY(this, PropertyId.PC.AbilityPoint);
		}

		/// <summary>
		/// Grants exp to character and handles level ups.
		/// </summary>
		/// <param name="exp"></param>
		/// <param name="classExp"></param>
		/// <param name="monster"></param>
		public void GiveExp(int exp, int classExp, Monster monster)
		{
			// Base EXP
			this.Exp += exp;
			this.TotalExp += exp;

			Send.ZC_EXP_UP_BY_MONSTER(this, exp, classExp, monster);
			Send.ZC_EXP_UP(this, exp, classExp); // Not always sent? Might be quest related?

			while (this.Exp >= this.MaxExp)
			{
				this.Exp -= this.MaxExp;
				this.LevelUp();
			}

			// Class EXP
			var classLevel = this.ClassLevel;
			var rank = this.Jobs.GetCurrentRank();
			var job = this.Job;
			var maxTotalExp = ChannelServer.Instance.Data.ExpDb.GetNextTotalClassExp(rank, 15);

			// Limit EXP to the total max, otherwise the client will
			// display level 1 with 0%.
			job.TotalExp = (int)Math.Min(maxTotalExp, ((long)job.TotalExp + classExp));

			var newClassLevel = this.ClassLevel;
			var diff = (newClassLevel - classLevel);

			Send.ZC_JOB_EXP_UP(this, classExp);

			if (diff > 0)
				this.ClassLevelUp(diff);
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

		public void CastSkill(int skillId, float dx, float dy)
		{
			// Check skill
			var skill = Skills.Get(skillId);
			if (skill == null)
			{
				Log.Warning("CZ_SKILL_TARGET_ANI: User '{0}' tried to use skill '{1}', which the character doesn't have.", this.Connection.Account.Name, skillId);
				Send.ZC_SKILL_CAST_CANCEL(this);
				//Log.Debug(packet.ToString());
				return;
			} else
			{
				Send.ZC_OVERHEAT_CHANGED(this, skill);
				Send.ZC_COOLDOWN_CHANGED(this, skill);
				Send.ZC_SKILL_FORCE_TARGET(this, null, skillId);
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
			if (this.Direction.Cos != d1 || this.Direction.Sin != d2)
			{
				this.SetDirection(d1, d2);
				Send.ZC_ROTATE(this);
			} else
			{
				Log.Debug("Direction hasn't changed, so ignoring packet");
			}
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

		/// <summary>
		/// Sets and returns the currently correct stance, based on this
		/// character's properties. Does not update client.
		/// </summary>
		public int UpdateStance()
		{
			var jobId = this.JobId;
			var riding = false;
			var rightHand = this.Inventory.GetItem(EquipSlot.RightHand).Data.EquipType1;
			var leftHand = this.Inventory.GetItem(EquipSlot.LeftHand).Data.EquipType1;

			this.Stance = ChannelServer.Instance.Data.StanceConditionDb.FindStanceId(jobId, riding, rightHand, leftHand);

			return this.Stance;
		}

		/// <summary>
		/// Returns a random physical ATK value between MinPAtk and MaxPAtk.
		/// </summary>
		/// <returns></returns>
		public int GetRandomPAtk()
		{
			var rnd = RandomProvider.Get();
			var min = this.MinPAtk;
			var max = this.MaxPAtk + 100;

			return rnd.Next(min, max + 1);
		}

		public void SendPCEtcProperties()
		{
			var pcEtcProps = new Properties();
			pcEtcProps.Set(PropertyId.PCEtc.SkintoneName, "skintone2");
			pcEtcProps.Set(PropertyId.PCEtc.Hide_2833, 1.000000f);
			pcEtcProps.Set(PropertyId.PCEtc.StartHairName, "UnbalancedShortcut");
			pcEtcProps.Set(PropertyId.PCEtc.LobbyMapID, 1021.000000f);
			pcEtcProps.Set(PropertyId.PCEtc.RepresentationClassID, JobId.ToString());
			pcEtcProps.Set(PropertyId.PCEtc.LastPlayDate, 20210728.000000f);
			pcEtcProps.Set(PropertyId.PCEtc.CTRLTYPE_RESET_EXCEPT, 1.000000f);
			pcEtcProps.Set(PropertyId.PCEtc.IsHaveWarpStone_Klaipeda, 1.000000f);
			Send.ZC_OBJECT_PROPERTY(this.Connection, this, pcEtcProps);
			foreach(var property in pcEtcProps.GetAll())
			{
				Properties.Add(property);
			}
		}

		public void SendPCProperties()
		{
			var pcProps = new Properties();
			pcProps.Set(PropertyId.PC.MSPD, 30.000000f);
			pcProps.Set(PropertyId.PC.MaxWeight, 8000.000000f);
			pcProps.Set(PropertyId.PC.NowWeight, 355.000000f);
			pcProps.Set(PropertyId.PC.Sta_Run, 0.000000f);
			pcProps.Set(PropertyId.PC.MovingShotable, 0.000000f);
			pcProps.Set(PropertyId.PC.CastingSpeed, 100.000000f);
			pcProps.Set(PropertyId.PC.ALLSTAT_ADD, 0.000000f);
			pcProps.Set(PropertyId.PC.Magic_Melee_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.Magic_Soul_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.ALLSTAT, 0.000000f);
			pcProps.Set(PropertyId.PC.HateRate, 0.000000f);
			pcProps.Set(PropertyId.PC.Leather_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantPVPDamageRate, 0.000000f);
			pcProps.Set(PropertyId.PC.SDR, 1.000000f);
			pcProps.Set(PropertyId.PC.JobName, "Char2_1");
			pcProps.Set(PropertyId.PC.FireAtkFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.BLK, 0.000000f);
			pcProps.Set(PropertyId.PC.ADD_Cooldown, 1.000000f);
			pcProps.Set(PropertyId.PC.BLK_BREAK, 1.000000f);
			pcProps.Set(PropertyId.PC.FireDefFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.Magic_Holy_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.DefAries, 0.000000f);
			pcProps.Set(PropertyId.PC.MiddleSize_Def, 0.000000f);
			pcProps.Set(PropertyId.PC.DefSlash, 0.000000f);
			pcProps.Set(PropertyId.PC.AriesAtkFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.ResEarth, 0.000000f);
			pcProps.Set(PropertyId.PC.ResIce, 0.000000f);
			pcProps.Set(PropertyId.PC.MINMATK, 76.000000f);
			pcProps.Set(PropertyId.PC.SkillWidthRange, 0.000000f);
			pcProps.Set(PropertyId.PC.MAXPATK_SUB, 25.000000f);
			pcProps.Set(PropertyId.PC.MissileDefFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.LootingChance, 0.000000f);
			pcProps.Set(PropertyId.PC.StrikeDefFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.Cannon_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.STR_ADD, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantDodgeRate, 0.000000f);
			pcProps.Set(PropertyId.PC.PlayTime, 131.220001f);
			pcProps.Set(PropertyId.PC.Holy_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.MissileAtkFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.Const, 1.909859f);
			pcProps.Set(PropertyId.PC.Magic_Dark_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.Gun_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.HR, 1.000000f);
			pcProps.Set(PropertyId.PC.EnchantSubWeaponDamageRate, 0.000000f);
			pcProps.Set(PropertyId.PC.Sta_RunStart, 0.000000f);
			pcProps.Set(PropertyId.PC.ResHoly, 0.000000f);
			pcProps.Set(PropertyId.PC.NormalASPD, 0.000000f);
			pcProps.Set(PropertyId.PC.Sta_Step, 2500.000000f);
			pcProps.Set(PropertyId.PC.LargeSize_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.Cloth_Def, 0.000000f);
			pcProps.Set(PropertyId.PC.Sta_Recover, 500.000000f);
			pcProps.Set(PropertyId.PC.HolyAtkFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.Lightning_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.BLKABLE, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantCriticalHitRate, 0.000000f);
			pcProps.Set(PropertyId.PC.BOSS_ATK, 0.000000f);
			pcProps.Set(PropertyId.PC.Velnias_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.RSP, 6.000000f);
			pcProps.Set(PropertyId.PC.EnchantBlockBreakRate, 0.000000f);
			pcProps.Set(PropertyId.PC.Leather_Def, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantBlockRate, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantMagicReducedRate, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantPVPReducedRate, 0.000000f);
			pcProps.Set(PropertyId.PC.MDEF, 72.000000f);
			pcProps.Set(PropertyId.PC.DarkDefFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.SkillASPD, 0.000000f);
			pcProps.Set(PropertyId.PC.MAXPATK, 25.000000f);
			pcProps.Set(PropertyId.PC.ResLightning, 0.000000f);
			pcProps.Set(PropertyId.PC.CON_ADD, 0.000000f);
			pcProps.Set(PropertyId.PC.Dark_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.Soul_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.Fire_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.SlashAtkFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.Guardable, 0.000000f);
			pcProps.Set(PropertyId.PC.Magic_Earth_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.MiddleSize_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.MINPATK_SUB, 25.000000f);
			pcProps.Set(PropertyId.PC.SoulAtkFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.CAST, 1.000000f);
			pcProps.Set(PropertyId.PC.ArmorMaterial_ID, 2.000000f);
			pcProps.Set(PropertyId.PC.RHP, 3.000000f);
			pcProps.Set(PropertyId.PC.CRTATK, 7.000000f);
			pcProps.Set(PropertyId.PC.Magic_Poison_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.Magic_Fire_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.ResAdd_Damage, 0.000000f);
			pcProps.Set(PropertyId.PC.Chain_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.MAXMATK, 76.000000f);
			pcProps.Set(PropertyId.PC.LUCK, 1.000000f);
			pcProps.Set(PropertyId.PC.Revive, 0.000000f);
			pcProps.Set(PropertyId.PC.PostDelay, 0.000000f);
			pcProps.Set(PropertyId.PC.RHPTIME, 20000.000000f);
			pcProps.Set(PropertyId.PC.CON, 3.000000f);
			pcProps.Set(PropertyId.PC.PoisonAtkFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.Aries_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantSR, 0.000000f);
			pcProps.Set(PropertyId.PC.HolyDefFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.Forester_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.SlashDefFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.INT_ADD, 0.000000f);
			pcProps.Set(PropertyId.PC.CRTDR, 1.000000f);
			pcProps.Set(PropertyId.PC.HitCount, 0.000000f);
			pcProps.Set(PropertyId.PC.HPDrain, 2.000000f);
			pcProps.Set(PropertyId.PC.StunRate, 0.000000f);
			pcProps.Set(PropertyId.PC.ResFire, 0.000000f);
			pcProps.Set(PropertyId.PC.STR, 2.000000f);
			pcProps.Set(PropertyId.PC.MNA, 8.000000f);
			pcProps.Set(PropertyId.PC.DEX, 3.000000f);
			pcProps.Set(PropertyId.PC.LightningAtkFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.Lv, 1.000000f);
			pcProps.Set(PropertyId.PC.Ghost_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.DEX_ADD, 0.000000f);
			pcProps.Set(PropertyId.PC.MNA_ADD, 0.000000f);
			pcProps.Set(PropertyId.PC.Earth_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.AddFever, 0.000000f);
			pcProps.Set(PropertyId.PC.Permission, 3.000000f);
			pcProps.Set(PropertyId.PC.MaxSta, 25000.000000f);
			pcProps.Set(PropertyId.PC.AriesDefFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.Slash_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.Sta_Jump, 1000.000000f);
			pcProps.Set(PropertyId.PC.Magic_Ice_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.EarthAtkFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.SoulDefFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantBossDamageRate, 0.000000f);
			pcProps.Set(PropertyId.PC.MHP, 343.000000f);
			pcProps.Set(PropertyId.PC.MINPATK, 25.000000f);
			pcProps.Set(PropertyId.PC.Widling_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.Poison_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantHitRate, 0.000000f);
			pcProps.Set(PropertyId.PC.KnockDownHit, 0.000000f);
			pcProps.Set(PropertyId.PC.Add_Damage_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.ResSoul, 0.000000f);
			pcProps.Set(PropertyId.PC.MHR, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantCriticalDodgeRate, 0.000000f);
			pcProps.Set(PropertyId.PC.KDBonusDamage, 130.000000f);
			pcProps.Set(PropertyId.PC.Cloth_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.SkillPower, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantMainWeaponDamageRate, 0.000000f);
			pcProps.Set(PropertyId.PC.Paramune_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantMeleeReducedRate, 0.000000f);
			pcProps.Set(PropertyId.PC.JumpPower, 350.000000f);
			pcProps.Set(PropertyId.PC.MGP, 500.000000f);
			pcProps.Set(PropertyId.PC.Iron_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantMSPD, 0.000000f);
			pcProps.Set(PropertyId.PC.KDBonusDefence, 40.000000f);
			pcProps.Set(PropertyId.PC.IceDefFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.EnchantCriticalDamage_Rate, 0.000000f);
			pcProps.Set(PropertyId.PC.Sta_Runable, 0.000000f);
			pcProps.Set(PropertyId.PC.SkillRange, 0.000000f);
			pcProps.Set(PropertyId.PC.Sta_R_Delay, 1000.000000f);
			pcProps.Set(PropertyId.PC.IceAtkFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.ResDark, 0.000000f);
			pcProps.Set(PropertyId.PC.DEF, 65.000000f);
			pcProps.Set(PropertyId.PC.ResPoison, 0.000000f);
			pcProps.Set(PropertyId.PC.StrikeAtkFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.DR, 1.000000f);
			pcProps.Set(PropertyId.PC.PoisonDefFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.ADD_OverHeat, 0.000000f);
			pcProps.Set(PropertyId.PC.SkillAngle, 8.000000f);
			pcProps.Set(PropertyId.PC.HEAL_PWR, 29.000000f);
			pcProps.Set(PropertyId.PC.CRTMATK, 17.000000f);
			pcProps.Set(PropertyId.PC.DarkAtkFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.EarthDefFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.LUCK_ADD, 0.000000f);
			pcProps.Set(PropertyId.PC.SR, 3.000000f);
			pcProps.Set(PropertyId.PC.HPDrain_ADD, 0.000000f);
			pcProps.Set(PropertyId.PC.BOOST, 1.000000f);
			pcProps.Set(PropertyId.PC.DefStrike, 0.000000f);
			pcProps.Set(PropertyId.PC.Magic_Lightning_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.Iron_Def, 0.000000f);
			pcProps.Set(PropertyId.PC.MSP, 200.000000f);
			pcProps.Set(PropertyId.PC.CRTHR, 1.000000f);
			pcProps.Set(PropertyId.PC.Arrow_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.Klaida_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.Ice_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.SmallSize_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.CRTDEF, 0.000000f);
			pcProps.Set(PropertyId.PC.LightningDefFactor_PC, 0.000000f);
			pcProps.Set(PropertyId.PC.Strike_Atk, 0.000000f);
			pcProps.Set(PropertyId.PC.INT, 9.000000f);
			Send.ZC_OBJECT_PROPERTY(this.Connection, this, pcProps);
			foreach (var property in pcProps.GetAll())
			{
				Properties.Add(property);
			}
		}

		public void SetGreetingMessage(int type, string message)
		{
			this.GreetingMessage = message;
			Send.ZC_NORMAL_SetGreetingMessage(this);
		}

		public void SetProperty(int propertyId, float value)
		{
			Properties.Set(propertyId, value);
			Send.ZC_OBJECT_PROPERTY(this, propertyId);
		}

		public void SetState(int type)
		{
			switch (type) {
				case 0:
					Speed = 40f;
					SetProperty(PropertyId.PC.MSPD, 40);
					SetProperty(PropertyId.PC.Sta_Run, 1250);
					Send.ZC_MOVE_SPEED(this);
					break;
			}
		}
	}
}
