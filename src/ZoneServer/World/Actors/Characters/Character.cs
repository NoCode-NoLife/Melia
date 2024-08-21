using System;
using System.Linq;
using Melia.Shared.Database;
using Melia.Shared.L10N;
using Melia.Shared.Network.Helpers;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Scripting;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting.AI;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Storage;
using Yggdrasil.Composition;
using Yggdrasil.Logging;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;
using Melia.Zone.Buffs;
using Melia.Zone.Buffs.Handlers.Common;

namespace Melia.Zone.World.Actors.Characters
{
	/// <summary>
	/// Represents a player character.
	/// </summary>
	public class Character : Actor, IActor, ICombatEntity, ICommander, IPropertyObject, IUpdateable
	{
		private bool _warping;
		private int _destinationChannelId;

		private readonly object _lookAroundLock = new();
		private readonly object _hpLock = new();
		private IMonster[] _visibleMonsters = [];
		private Character[] _visibleCharacters = [];

		private readonly static TimeSpan ResurrectDialogDelay = TimeSpan.FromSeconds(2);
		private TimeSpan _resurrectDialogTimer = ResurrectDialogDelay;

		/// <summary>
		/// Returns true if the character was just saved before a warp.
		/// </summary>
		internal bool SavedForWarp { get; private set; }

		/// <summary>
		/// Connection this character uses.
		/// </summary>
		public IZoneConnection Connection { get; set; }

		/// <summary>
		/// Returns the name of the character's account.
		/// </summary>
		public string Username => this.Connection.Account.Name;

		/// <summary>
		/// Gets or sets the character's unique database id.
		/// </summary>
		public long DbId { get; set; }

		/// <summary>
		/// Returns the character's globally unique id.
		/// </summary>
		public long ObjectId => ObjectIdRanges.Characters + this.DbId;

		/// <summary>
		/// Returns the character's globally unique id on the social server.
		/// </summary>
		/// <remarks>
		/// This id might not actually be the social user id, or at least not
		/// solely, seeing how it's used as the id of the etc property object.
		/// </remarks>
		public long SocialUserId => ObjectIdRanges.SocialUser + this.DbId;

		/// <summary>
		/// Id of the character's account.
		/// </summary>
		public long AccountId { get; set; }

		/// <summary>
		/// Returns the character's faction.
		/// </summary>
		public FactionType Faction => FactionType.Law;

		/// <summary>
		/// Returns the character's race.
		/// </summary>
		public RaceType Race => RaceType.None;

		/// <summary>
		/// Returns the character's element/attribute.
		/// </summary>
		public AttributeType Attribute => (AttributeType)(int)this.Properties.GetFloat(PropertyName.Attribute, (int)AttributeType.None);

		/// <summary>
		/// Returns the character's mode of movement.
		/// </summary>
		public MoveType MoveType => MoveType.Normal;

		/// <summary>
		/// Character's name.
		/// </summary>
		public override string Name { get; set; }

		/// <summary>
		/// Character's team name.
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// Gets or sets the character's current job id.
		/// </summary>
		/// <remarks>
		/// This should essentially and presumably alwas be the id of the
		/// last job the character changed to.
		/// </remarks>
		public JobId JobId { get; set; }

		/// <summary>
		/// Returns the class of the character's current job.
		/// </summary>
		public JobClass JobClass => this.JobId.ToClass();

		/// <summary>
		/// Returns the character's current job.
		/// </summary>
		public Job Job => this.Jobs.Get(this.JobId);

		/// <summary>
		/// Returns a reference to the character's job list.
		/// </summary>
		/// <remarks>
		/// A character has one main job which determines, for example,
		/// what items they can equip, but they can have various jobs,
		/// that all come with their own skills and abilities.
		/// </remarks>
		public JobComponent Jobs { get; }

		/// <summary>
		/// Character's gender.
		/// </summary>
		public Gender Gender { get; set; }

		/// <summary>
		/// Character's hair style.
		/// </summary>
		public int Hair { get; set; }

		/// <summary>
		/// Gets or sets the character's skin color.
		/// </summary>
		public uint SkinColor { get; set; }

		/// <summary>
		/// Returns stance, based on job and other factors.
		/// </summary>
		public int Stance { get; protected set; }

		/// <summary>
		/// The map the character is in.
		/// </summary>
		public int MapId { get; set; }

		/// <summary>
		/// Character's head's direction.
		/// </summary>
		public Direction HeadDirection { get; set; }

		/// <summary>
		/// Gets or sets whether the character is sitting.
		/// </summary>
		public bool IsSitting { get; set; }

		/// <summary>
		/// Returns the character's personal storage.
		/// </summary>
		public PersonalStorage PersonalStorage { get; }

		/// <summary>
		/// Returns the character's account's team storage.
		/// </summary>
		public PersonalStorage TeamStorage { get; }

		/// <summary>
		/// Returns a reference to the character's current storage.
		/// </summary>
		/// <remarks>
		/// The result of this method depends on the character's variables,
		/// to support the dynamic opening of arbitrary storages. If no
		/// special storage was set, it defaults to the personal storage.
		/// </remarks>
		public PersonalStorage CurrentStorage
		{
			get => this.Variables.Temp.Get<PersonalStorage>("Melia.Storage") ?? this.PersonalStorage;
			set => this.Variables.Temp.Set("Melia.Storage", value);
		}

		/// <summary>
		/// The character's inventory.
		/// </summary>
		public InventoryComponent Inventory { get; }

		/// <summary>
		/// Gets or set the character's greeting message.
		/// </summary>
		public string GreetingMessage { get; set; }

		/// <summary>
		/// Holds the order of successive changes in character HP.
		/// A higher value indicates the latest HP amount.
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
		public VariablesContainer Variables { get; } = new VariablesContainer();

		/// <summary>
		/// Specifies which hats are visible on the character.
		/// </summary>
		public VisibleEquip VisibleEquip { get; set; } = VisibleEquip.All;

		/// <summary>
		/// Current experience points.
		/// </summary>
		public long Exp { get; set; }

		/// <summary>
		/// Current maximum experience points.
		/// </summary>
		public long MaxExp { get; set; }

		/// <summary>
		/// Total number of accumulated experience points.
		/// </summary>
		public long TotalExp { get; set; }

		/// <summary>
		/// Returns the character's current job level.
		/// </summary>
		public int JobLevel
		{
			get
			{
				var job = this.Jobs.Get(this.JobId);
				return job.Level;
			}
		}

		/// <summary>
		/// Returns the character's current level.
		/// </summary>
		public int Level => (int)this.Properties.GetFloat(PropertyName.Lv);

		/// <summary>
		/// Returns the character's current HP.
		/// </summary>
		public int Hp => (int)this.Properties.GetFloat(PropertyName.HP);

		/// <summary>
		/// Returns the character's max HP.
		/// </summary>
		public int MaxHp => (int)this.Properties.GetFloat(PropertyName.MHP);

		/// <summary>
		/// Returns the character's current SP.
		/// </summary>
		public int Sp => (int)this.Properties.GetFloat(PropertyName.SP);

		/// <summary>
		/// Returns the character's max SP.
		/// </summary>
		public int MaxSp => (int)this.Properties.GetFloat(PropertyName.MSP);

		/// <summary>
		/// Returns the character's current stamina.
		/// </summary>
		public int Stamina => this.Properties.Stamina;

		/// <summary>
		/// Returns the character's max stamina.
		/// </summary>
		public int MaxStamina => this.Properties.MaxStamina;

		/// <summary>
		/// Returns true if the character has run out of HP and died.
		/// </summary>
		public bool IsDead => (this.Hp == 0);

		/// <summary>
		/// Returns the character's game permission level, based on the
		/// account's authority.
		/// </summary>
		public PermissionLevel PermissionLevel => this.Connection?.Account?.PermissionLevel ?? PermissionLevel.User;

		/// <summary>
		/// Returns the character's component collection.
		/// </summary>
		public ComponentCollection Components { get; } = new ComponentCollection();

		/// <summary>
		/// Character's session objects.
		/// </summary>
		public SessionObjects SessionObjects { get; } = new SessionObjects();

		/// <summary>
		/// Character's skills.
		/// </summary>
		public SkillComponent Skills { get; }

		/// <summary>
		/// Character's abilities.
		/// </summary>
		public AbilityComponent Abilities { get; }

		/// <summary>
		/// Character's buffs.
		/// </summary>
		public BuffComponent Buffs { get; }

		/// <summary>
		/// Returns the character's quests manager.
		/// </summary>
		public QuestComponent Quests { get; }

		/// <summary>
		/// Returns the character's collection manager.
		/// </summary>
		public CollectionComponent Collections { get; }

		/// <summary>
		/// Returns the character's movement component.
		/// </summary>
		public MovementComponent Movement { get; }

		/// <summary>
		/// Character's properties.
		/// </summary>
		/// <remarks>
		/// Beware, some of these are reference properties that can't be
		/// set directly. Use this object's actual properties whenever
		/// possible.
		/// </remarks>
		public CharacterProperties Properties { get; }

		/// <summary>
		/// Returns a reference to the character's properties.
		/// </summary>
		Properties IPropertyHolder.Properties => this.Properties;

		/// <summary>
		/// Returns the character's PCEtc properties.
		/// </summary>
		public PCEtc Etc { get; }

		/// <summary>
		/// Gets or sets the player's localizer.
		/// </summary>
		public Localizer Localizer
		{
			get => _localizer ?? ZoneServer.Instance.MultiLocalization.GetDefault();
			private set => _localizer = value;
		}
		private Localizer _localizer;

		/// <summary>
		/// Raised when the characters sits down or stands up.
		/// </summary>
		public event Action<Character> SitStatusChanged;

		/// <summary>
		/// Creates new character.
		/// </summary>
		public Character() : base()
		{
			this.Components.Add(this.Inventory = new InventoryComponent(this));
			this.Components.Add(this.Jobs = new JobComponent(this));
			this.Components.Add(this.Skills = new SkillComponent(this));
			this.Components.Add(this.Abilities = new AbilityComponent(this));
			this.Components.Add(this.Buffs = new BuffComponent(this));
			this.Components.Add(new RecoveryComponent(this));
			this.Components.Add(new CombatComponent(this));
			this.Components.Add(new CooldownComponent(this));
			this.Components.Add(new TimeActionComponent(this));
			this.Components.Add(this.Quests = new QuestComponent(this));
			this.Components.Add(this.Collections = new CollectionComponent(this));
			this.Components.Add(this.Movement = new MovementComponent(this));

			this.Properties = new CharacterProperties(this);
			this.Etc = new PCEtc(this);

			// Init storage after etc, since it uses etc properties
			this.PersonalStorage = new PersonalStorage(this);
			this.TeamStorage = new PersonalStorage(this);

			this.AddSessionObjects();
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
			// 
			// Update: Disabling this for now so we can take a fresh
			//   look at session objects. Curiously, I don't get the
			//   aformentioned tooltip anymore right now, even if this
			//   object is missing.
			//this.SessionObjects.Add(new SessionObject(SessionObjectId.Jansori));
		}

		/// <summary>
		/// Gives character its initial properties if they're missing,
		/// such as on a newly created character.
		/// </summary>
		public void InitProperties()
		{
			if (this.Job == null)
				throw new InvalidOperationException("Character's jobs need to be loaded before initializing the properties.");

			// We need something to check whether the properties were
			// already initialized. Let's just use a variable for that.
			if (!this.Variables.Perm.Has("Melia.PropertiesInitialized"))
			{
				this.Exp = 0;
				this.TotalExp = 0;
				this.MaxExp = ZoneServer.Instance.Data.ExpDb.GetNextExp(1);

				// Invalidate max properties so we get the correct values
				// when using them here
				this.Properties.Invalidate(PropertyName.MHP, PropertyName.MSP, PropertyName.MaxSta);

				// Set HP, SP and stamina to max
				this.Properties.SetFloat(PropertyName.HP, this.Properties.GetFloat(PropertyName.MHP));
				this.Properties.SetFloat(PropertyName.SP, this.Properties.GetFloat(PropertyName.MSP));
				this.Properties.Stamina = (int)this.Properties.GetFloat(PropertyName.MaxSta);

				// Only do this once, as we will have saved property values
				// next time we come here
				this.Variables.Perm.SetBool("Melia.PropertiesInitialized", true);
			}

			// Invalidate all properties so they get updated and then set
			// up the auto-updates
			this.Properties.InvalidateAll();
			this.Properties.InitAutoUpdates();
		}

		/// <summary>
		/// Updates character and its components.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			this.Components.Update(elapsed);
			this.UpdateResurrection(elapsed);
		}

		/// <summary>
		/// Sends the resurrection dialog as nexessary.
		/// </summary>
		/// <param name="elapsed"></param>
		private void UpdateResurrection(TimeSpan elapsed)
		{
			// Why are we sending the resurrection dialog over and over on
			// the update? Well, because certain packets sent to the client,
			// such as hits, can cause it to close this dialog, which then
			// leaves players with having to relog to get it again to be
			// able to resurrect. Spamming isn't a great hotfix, but it is
			// an effective one, as it will ensure that the dialog is always
			// there when it should be. And of course, as you would expect,
			// it appears that this is normal, based on the packet logs.
			if (this.IsDead)
			{
				_resurrectDialogTimer -= elapsed;
				if (_resurrectDialogTimer <= TimeSpan.Zero)
				{
					// TODO: Get a list of the appropriate resurrection
					//   options and save them, to sanity check the coming
					//   resurrection request.

					Send.ZC_RESURRECT_DIALOG(this, ResurrectOptions.NearestRevivalPoint);
					_resurrectDialogTimer = ResurrectDialogDelay;
				}
			}
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
			=> this.SetPosition(new Position(x, y, z));

		/// <summary>
		/// Sets character's position.
		/// </summary>
		/// <param name="pos"></param>
		public void SetPosition(Position pos)
		{
			this.Position = pos;
		}

		/// <summary>
		/// Sets character's direction.
		/// </summary>
		/// <param name="cos"></param>
		/// <param name="sin"></param>
		public void SetDirection(float cos, float sin)
			=> this.SetDirection(new Direction(cos, sin));

		/// <summary>
		/// Sets character's direction.
		/// </summary>
		/// <param name="dir"></param>
		public void SetDirection(Direction dir)
		{
			this.Direction = dir;
		}

		/// <summary>
		/// Sets character's direction.
		/// </summary>
		/// <param name="cos"></param>
		/// <param name="sin"></param>
		public void SetHeadDirection(float cos, float sin)
			=> this.SetHeadDirection(new Direction(cos, sin));

		/// <summary>
		/// Sets character's direction.
		/// </summary>
		/// <param name="dir"></param>
		public void SetHeadDirection(Direction dir)
		{
			this.HeadDirection = dir;
		}

		/// <summary>
		/// Warps character to given location.
		/// </summary>
		/// <param name="location"></param>
		public void Warp(Location location)
			=> this.Warp(location.MapId, location.Position);

		/// <summary>
		/// Warps character to given location.
		/// </summary>
		/// <param name="mapName"></param>
		/// <param name="pos"></param>
		/// <exception cref="ArgumentException">Thrown if map doesn't exist in data.</exception>
		public void Warp(string mapName, Position pos)
		{
			if (!ZoneServer.Instance.Data.MapDb.TryFind(mapName, out var map))
				throw new ArgumentException("Map '" + mapName + "' not found in data.");

			this.Warp(map.Id, pos);
		}

		/// <summary>
		/// Warps character to given location.
		/// </summary>
		/// <param name="mapId"></param>
		/// <param name="pos"></param>
		/// <exception cref="ArgumentException">Thrown if map doesn't exist in data.</exception>
		public void Warp(int mapId, Position pos)
		{
			if (!ZoneServer.Instance.Data.MapDb.TryFind(mapId, out var map))
				throw new ArgumentException("Map '" + mapId + "' not found in data.");

			this.Position = pos;

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
		/// Makes character warp to the same map on another, previously
		/// selected channel.
		/// </summary>
		internal void WarpChannel(int channelId)
		{
			_warping = true;
			_destinationChannelId = channelId;

			Send.ZC_SAVE_INFO(this.Connection);
			Send.ZC_MOVE_ZONE(this.Connection);
		}

		/// <summary>
		/// Finalizes warp, after client announced readiness.
		/// </summary>
		internal void FinalizeWarp()
		{
			// Check permission
			if (!_warping)
			{
				Log.Warning("Character.FinalizeWarp: Player '{0}' tried to warp without permission.", this.AccountId);
				return;
			}

			// Find an available zone server for the target map
			var availableZones = ZoneServer.Instance.ServerList.GetZoneServers(this.MapId);
			if (availableZones.Length == 0)
				throw new Exception($"No suitable zone server found for map '{this.MapId}'");

			var channelId = Math2.Clamp(0, availableZones.Length, _destinationChannelId);
			var serverInfo = availableZones[channelId];

			this.Connection.SaveAccountAndCharacter();
			this.SavedForWarp = true;

			// Instruct client to initiate warp
			Send.ZC_MOVE_ZONE_OK(this, channelId, serverInfo.Ip, serverInfo.Port, this.MapId);

			_warping = false;
		}

		/// <summary>
		/// Increases character's level by the given amount.
		/// </summary>
		/// <param name="amount"></param>
		public void LevelUp(int amount = 1)
		{
			if (amount < 1)
				throw new ArgumentException("Amount can't be lower than 1.");

			var newLevel = this.Properties.Modify(PropertyName.Lv, amount);
			this.Properties.Modify(PropertyName.StatByLevel, amount);

			this.MaxExp = ZoneServer.Instance.Data.ExpDb.GetNextExp((int)newLevel);
			this.FullHeal();

			Send.ZC_MAX_EXP_CHANGED(this, 0);
			Send.ZC_PC_LEVELUP(this);
			Send.ZC_OBJECT_PROPERTY(this);
			Send.ZC_ADDON_MSG(this, "NOTICE_Dm_levelup_base", 3, "!@#$Auto_KaeLigTeo_LeBeli_SangSeungHayeossSeupNiDa#@!");
			Send.ZC_NORMAL.PlayEffect(this, "F_pc_level_up", 3);
		}

		/// <summary>
		/// Increases character's job level by the given amount. Returns the amount
		/// of levels actually gained.
		/// </summary>
		/// <param name="amount"></param>
		/// <returns></returns>
		public int JobLevelUp(int amount)
		{
			// TODO: Should the whole job leveling up perhaps take place in
			//   the job, instead of the character? That would seem to make
			//   more sense, given that we exclusively operate on job props
			//   in here.

			if (amount < 1)
				throw new ArgumentException("Amount can't be lower than 1.");

			if (this.Job.Level == this.Job.MaxLevel)
				return 0;

			if (this.Job.Level + amount > this.Job.MaxLevel)
				amount = this.Job.MaxLevel - this.Job.Level;

			var prevLevel = this.Job.Level;
			var prevExp = this.Job.TotalExp;

			this.Job.TotalExp = ZoneServer.Instance.Data.ExpDb.GetNextTotalJobExp(this.Jobs.GetCurrentRank(), prevLevel + amount - 1);

			var expGained = (this.Job.TotalExp - prevExp);
			var levelsGained = (this.Job.Level - prevLevel);

			Send.ZC_JOB_EXP_UP(this, expGained);

			if (levelsGained > 0)
				this.FinishJobLevelUp(levelsGained);

			return levelsGained;
		}

		/// <summary>
		/// Gives skill points to job, heals character, and notifies client
		/// about the job level up.
		/// </summary>
		/// <param name="amount"></param>
		private void FinishJobLevelUp(int amount)
		{
			if (amount < 1)
				throw new ArgumentException("Amount can't be lower than 1.");

			this.Jobs.ModifySkillPoints(this.JobId, amount);
			this.FullHeal();

			Send.ZC_OBJECT_PROPERTY(this);
			Send.ZC_ADDON_MSG(this, "NOTICE_Dm_levelup_skill", 3, "!@#$Auto_KeulLeSeu_LeBeli_SangSeungHayeossSeupNiDa#@!");
			Send.ZC_NORMAL.PlayEffect(this, "F_pc_joblevel_up", 3);
		}

		/// <summary>
		/// Heals character's HP, SP, and Stamina fully and updates
		/// the client.
		/// </summary>
		public void FullHeal()
		{
			// Use the modifiers, so we actually get a full heal, unaffected by
			// potential (de)buffs in Heal.
			this.ModifyHp(this.MaxHp);
			this.ModifySp(this.MaxSp);
		}

		/// <summary>
		/// Heals character's HP and SP by the given amounts and updates
		/// the client. Applies potential (de)buffs that affect healing.
		/// </summary>
		/// <remarks>
		/// For healing unaffected by (de)buffs, use FullHeal or ModifyHp/Sp.
		/// </remarks>
		/// <param name="hpAmount"></param>
		/// <param name="spAmount"></param>
		public void Heal(float hpAmount, float spAmount)
		{
			if (hpAmount == 0 && spAmount == 0)
				return;

			// TODO: Move this somewhere else, perhaps with a hook/event?
			DecreaseHeal_Debuff.TryApply(this, ref hpAmount);

			this.ModifyHpSafe(hpAmount, out var hp, out var priority);
			this.Properties.Modify(PropertyName.SP, spAmount);

			Send.ZC_UPDATE_ALL_STATUS(this, priority);
		}

		/// <summary>
		/// Modifies character's HP by the given amount without updating
		/// the client. Returns the new HP value and the priority number
		/// of this modification.
		/// </summary>
		/// <remarks>
		/// There are several packets in this game that require the HP
		/// to be set synchronized, to ensure that it's only set from
		/// one source and to identify the latest amount based on the
		/// "priority".
		/// </remarks>
		/// <param name="amount"></param>
		public void ModifyHpSafe(float amount, out float newHp, out int priority)
		{
			// Make sure it's not possible for two calls to interfere
			// with each other, so that the correct amount makes it to
			// the client, with the correct priority.
			lock (_hpLock)
			{
				newHp = (int)this.Properties.Modify(PropertyName.HP, amount);
				priority = (this.HpChangeCounter += 1);
			}
		}

		/// <summary>
		/// Modifies character's HP by the given amount and updates the
		/// client with ZC_ADD_HP.
		/// </summary>
		/// <param name="amount"></param>
		public void ModifyHp(float amount)
		{
			this.ModifyHpSafe(amount, out var hp, out var priority);
			Send.ZC_ADD_HP(this, amount, hp, priority);
		}

		/// <summary>
		/// Modifies character's SP by the given amount and updates the
		/// client with ZC_UPDATE_SP.
		/// </summary>
		/// <param name="amount"></param>
		public void ModifySp(float amount)
		{
			var sp = this.Properties.Modify(PropertyName.SP, amount);
			Send.ZC_UPDATE_SP(this, sp, true);
		}

		/// <summary>
		/// Modifies character's current stamina and updates the client.
		/// </summary>
		/// <param name="amount"></param>
		public void ModifyStamina(int amount)
		{
			this.Properties.Stamina += amount;
			Send.ZC_STAMINA(this, this.Properties.Stamina);
		}

		/// <summary>
		/// Modifies the character's ability points by the given amount
		/// and updates the respective property on the client.
		/// </summary>
		/// <param name="amount"></param>
		public void ModifyAbilityPoints(int amount)
		{
			var abilityPoints = int.Parse(this.Properties.GetString(PropertyName.AbilityPoint));
			abilityPoints += amount;
			this.Properties.SetString(PropertyName.AbilityPoint, abilityPoints.ToString());

			// For some reason the client no longer reads the ability
			// point property when updating the amount. Instead there's
			// the commander info now.

			//Send.ZC_OBJECT_PROPERTY(this, PropertyName.AbilityPoint);
			Send.ZC_CUSTOM_COMMANDER_INFO(this, CommanderInfoType.AbilityPoints, abilityPoints);
		}

		/// <summary>
		/// Grants exp to character and handles level ups.
		/// </summary>
		/// <param name="exp"></param>
		/// <param name="jobExp"></param>
		/// <param name="monster"></param>
		public void GiveExp(long exp, long jobExp, IMonster monster)
		{
			// Base EXP
			this.Exp += exp;
			this.TotalExp += exp;

			Send.ZC_EXP_UP_BY_MONSTER(this, exp, jobExp, monster);
			Send.ZC_EXP_UP(this, exp, jobExp); // Not always sent? Might be quest related?

			var level = this.Level;
			var levelUps = 0;
			var maxExp = this.MaxExp;
			var maxLevel = ZoneServer.Instance.Data.ExpDb.GetMaxLevel();

			// Consume EXP as many times as possible to reach new levels
			while (this.Exp >= maxExp && level < maxLevel)
			{
				this.Exp -= maxExp;

				level++;
				levelUps++;
				maxExp = ZoneServer.Instance.Data.ExpDb.GetNextExp(level);
			}

			// Execute level up only once to avoid client lag on multiple
			// level ups. Leveling up a thousand times in a loop is not
			// fun for the client =D"
			if (levelUps > 0)
				this.LevelUp(levelUps);

			// Job EXP
			// Increase the total EXP and check whether the job level,
			// which is calculcated from that value, has changed.
			var jobLevel = this.JobLevel;
			var rank = this.Jobs.GetCurrentRank();
			var job = this.Job;

			// Limit EXP to the total max, otherwise the client will
			// display level 1 with 0%.
			job.TotalExp = Math.Min(job.TotalMaxExp, (job.TotalExp + jobExp));

			var newJobLevel = this.JobLevel;
			var jobLevelsGained = (newJobLevel - jobLevel);

			Send.ZC_JOB_EXP_UP(this, jobExp);

			if (jobLevelsGained > 0)
				this.FinishJobLevelUp(jobLevelsGained);
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

					if (!monster.AttachableEffects.IsEmpty)
					{
						foreach (var effect in monster.AttachableEffects)
							Send.ZC_NORMAL.AttachEffect(this.Connection, monster, effect.PacketString, effect.Scale);
					}

					if (monster is ICombatEntity entity)
					{
						Send.ZC_FACTION(this.Connection, monster, entity.Faction);

						if (entity.Components.Get<BuffComponent>()?.Count != 0)
							Send.ZC_BUFF_LIST(this.Connection, entity);

						// Send a movement update to the client if the monster
						// is currently moving, otherwise it will just stand
						// there until the next movement starts.
						// This could be done prettier, but it's a start
						if (entity.Components.TryGet<MovementComponent>(out var movement))
						{
							if (movement.IsMoving && movement.MoveTarget == MoveTargetType.Position)
							{
								var fromCellPos = entity.Map.Ground.GetCellPosition(entity.Position);
								var toCellPos = entity.Map.Ground.GetCellPosition(movement.Destination);
								var speed = entity.Properties.GetFloat(PropertyName.MSPD);

								Send.ZC_MOVE_PATH(this, entity, fromCellPos, toCellPos, speed);
							}
						}
					}
				}

				foreach (var monster in disappearMonsters)
					Send.ZC_LEAVE(this.Connection, monster);

				// Characters
				foreach (var character in appearCharacters)
				{
					Send.ZC_ENTER_PC(this.Connection, character);

					Send.ZC_SEND_APPLY_HUD_SKIN_OTHER(this.Connection, character);
					//Send.ZC_SEND_MODE_HUD_SKIN(this.Connection, character);

					if (!character.AttachableEffects.IsEmpty)
					{
						foreach (var effect in character.AttachableEffects)
							Send.ZC_NORMAL.AttachEffect(this.Connection, character, effect.PacketString, effect.Scale);
					}

					if (character.Components.Get<BuffComponent>()?.Count != 0)
						Send.ZC_BUFF_LIST(this.Connection, character);
				}

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

				_visibleMonsters = [];
				_visibleCharacters = [];
			}
		}

		/// <summary>
		/// Sets direction and updates clients.
		/// </summary>
		/// <param name="dir"></param>
		public void Rotate(Direction dir)
		{
			if (this.Direction != dir)
				this.SetDirection(dir);

			Send.ZC_ROTATE(this);
		}

		/// <summary>
		/// Sets direction and updates clients.
		/// </summary>
		/// <param name="d1"></param>
		/// <param name="d2"></param>
		public void RotateHead(Direction dir)
		{
			if (this.HeadDirection != dir)
				this.SetHeadDirection(dir);

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
		/// Displays server message in character's chat.
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
		public void ServerMessage(string format, params object[] args)
		{
			if (args.Length > 0)
				format = string.Format(format, args);

			// Since there doesn't seem to be a way to send custom system
			// messages, we're abusing clientmessage 21254, which has the
			// format "X:Y", where we replace X and Y with a prefix and
			// our custom message.
			this.SystemMessage("{Hour}:{Min}", new MsgParameter("Hour", "Server "), new MsgParameter("Min", " " + format));
		}

		/// <summary>
		/// Displays system message in character's chat.
		/// </summary>
		/// <remarks>
		/// Uses pre-defined, argument-supporting system messages found
		/// in the clientmessage.xml file. The class name corresponds to
		/// the class name in said XML, with arguments found inside those
		/// messages, wrapped in curly braces.
		/// </remarks>
		/// <example>
		/// ClassName="{Day}days"
		/// SystemMessage("{Day}days", new MsgParameter("Day", "5 "))
		/// -> "5 days"
		/// </example>
		/// <param name="className"></param>
		/// <param name="args"></param>
		public void SystemMessage(string className, params MsgParameter[] args)
		{
			if (!ZoneServer.Instance.Data.SystemMessageDb.TryFind(className, out var sysMsgData))
				throw new ArgumentException($"System message '{className}' not found.");

			Send.ZC_SYSTEM_MSG(this, sysMsgData.ClassId, args);
		}

		/// <summary>
		/// Sends server message to character.
		/// </summary>
		/// <param name="format"></param>
		/// <param name="args"></param>
		public void MsgBox(string format, params object[] args)
		{
			if (args.Length > 0)
				format = string.Format(format, args);

			if (format.Contains('\''))
				format = format.Replace("'", "\\'");

			Send.ZC_EXEC_CLIENT_SCP(this.Connection, "ui.MsgBox('" + format + "')");
		}

		/// <summary>
		/// Adds amount to character's stat points and updates the client.
		/// </summary>
		/// <param name="amount"></param>
		public void AddStatPoints(int amount)
		{
			if (amount < 1)
				throw new ArgumentException("Amount can't be negative.");

			this.Properties.Modify(PropertyName.StatByBonus, amount);
			Send.ZC_OBJECT_PROPERTY(this, PropertyName.StatByBonus);
		}

		/// <summary>
		/// Resets the character's stats.
		/// </summary>
		/// <remarks>
		/// Sets all stats to 1 (some level bonuses might still apply,
		/// raising the default value above 1) and gives back the points
		/// that were put into the stats. Also resets the points the
		/// character got from its job on creation.
		/// </remarks>
		public void ResetStats()
		{
			var character = this;

			// The three properties that control the stat points are
			// StatByLevel, StatByBonus, and UsedStat. The first two
			// get added together and UsedStat is subtracted to arrive
			// at the number of available stat points. To reset the
			// stat points that were used, all we have to do is reset
			// UsedStat and the *_STAT properties. For a full reset,
			// however, that allows for distributing the initial stats
			// from the chosen job, we need to give the player the points
			// that went into the *_JOB properties, which we'll just add
			// to StatByBonus.

			var jobStatPoints = character.Properties.Sum(PropertyName.STR_JOB, PropertyName.CON_JOB, PropertyName.INT_JOB, PropertyName.MNA_JOB, PropertyName.DEX_JOB) - 5;
			character.Properties.Modify(PropertyName.StatByBonus, jobStatPoints);

			character.Properties.SetFloat(PropertyName.UsedStat, 0);

			character.Properties.SetFloat(PropertyName.STR_STAT, 0);
			character.Properties.SetFloat(PropertyName.CON_STAT, 0);
			character.Properties.SetFloat(PropertyName.INT_STAT, 0);
			character.Properties.SetFloat(PropertyName.MNA_STAT, 0);
			character.Properties.SetFloat(PropertyName.DEX_STAT, 0);

			character.Properties.SetFloat(PropertyName.STR_JOB, 1);
			character.Properties.SetFloat(PropertyName.CON_JOB, 1);
			character.Properties.SetFloat(PropertyName.INT_JOB, 1);
			character.Properties.SetFloat(PropertyName.MNA_JOB, 1);
			character.Properties.SetFloat(PropertyName.DEX_JOB, 1);

			// TODO: Add semi-automatic updating of all properties that
			//   changed.
			//Send.ZC_OBJECT_PROPERTY(character,
			//	"STR", "STR_STAT", "STR_JOB", "CON", "CON_STAT", "CON_JOB",
			//	"INT", "INT_STAT", "INT_JOB", "MNA", "MNA_STAT", "MNA_JOB",
			//	"DEX", "DEX_STAT", "DEX_JOB",
			//	"UsedStat", "StatByLevel", "StatByBonus",
			//	"MINPATK", "MAXPATK", "MINMATK", "MAXMATK", "MINPATK_SUB", "MAXPATK_SUB",
			//	"CRTATK", "HR", "DR", "BLK_BREAK", "BLK", "RHP",
			//	"RSP", "MHP", "MSP"
			//);

			// I don't trust that we will always get the updated properties
			// right and creating semi-auto updating is difficult with this
			// game's property system, so we'll just update all of them
			// That might not actually be necessary in all cases, but it's
			// much simpler and safer. It's also not like we reset characters
			// all the time anyway.
			character.Properties.InvalidateAll();
			Send.ZC_OBJECT_PROPERTY(character);
		}

		/// <summary>
		/// Resets the character's skills.
		/// </summary>
		/// <remarks>
		/// Resets the levels of all skills the character has and returns
		/// the points that were put into them to the jobs.
		/// </remarks>
		public void ResetSkills()
		{
			// Remove all skills
			foreach (var skill in this.Skills.GetList())
				this.Skills.Remove(skill.Id);

			// Reset jobs' skill points, so they're equal to their level,
			// minus 1, because 1 is the default level.
			foreach (var job in this.Jobs.GetList())
				job.SetSkillPoints(job.Level - 1);
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

			this.Stance = ZoneServer.Instance.Data.StanceConditionDb.FindStanceId(jobId, riding, rightHand, leftHand);

			return this.Stance;
		}

		/// <summary>
		/// Makes character take damage and kills them if their HP reached 0.
		/// Returns true if the character is dead.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="attacker"></param>
		/// <returns></returns>
		public bool TakeDamage(float damage, ICombatEntity attacker)
		{
			// Don't hit an already dead monster
			if (this.IsDead)
				return true;

			if (this.IsBuffActive(BuffId.Skill_NoDamage_Buff) || this.IsBuffActive(BuffId.BackSlide_MomentaryEvasion_Buff))
				return false;

			this.Components.Get<CombatComponent>().SetAttackState(true);
			this.ModifyHpSafe(-damage, out _, out _);

			this.Components.Get<CombatComponent>()?.RegisterHit(attacker, damage);

			if (this.Hp == 0)
				this.Kill(attacker);

			this.Map.AlertAis(this, new HitEventAlert(this, attacker, damage));

			return this.IsDead;
		}

		/// <summary>
		/// Kills character.
		/// </summary>
		/// <param name="killer"></param>
		public void Kill(ICombatEntity killer)
		{
			this.Properties.SetFloat(PropertyName.HP, 0);

			//this.Died?.Invoke(this, killer);
			ZoneServer.Instance.ServerEvents.OnEntityKilled(this, killer);

			Send.ZC_DEAD(this);

			_resurrectDialogTimer = ResurrectDialogDelay;
		}

		/// <summary>
		/// Resurrects the character if its dead.
		/// </summary>
		/// <param name="option"></param>
		public void Resurrect(ResurrectOptions option)
		{
			var startHp = this.Properties.GetFloat(PropertyName.MHP) * 0.50f;
			this.Heal(startHp, 0);

			switch (option)
			{
				default:
				case ResurrectOptions.NearestRevivalPoint:
				{
					var safePos = this.Map.GetSafePositionNear(this.Position, true);
					this.Warp(this.MapId, safePos);
					break;
				}
			}

			Send.ZC_RESURRECT_SAVE_POINT_ACK(this);
			Send.ZC_RESURRECT(this);
		}

		/// <summary>
		/// Returns true if the character can attack others.
		/// </summary>
		/// <returns></returns>
		public bool CanFight()
		{
			if (this.IsDead)
				return false;

			return true;
		}

		/// <summary>
		/// Returns true if the character can attack the entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public bool CanAttack(ICombatEntity entity)
		{
			if (entity == this)
				return false;

			if (entity.IsDead)
				return false;

			// For now, let's specify that characters can attack actual
			// monsters.
			var isHostileMonster = (entity is IMonster monster && monster.MonsterType == MonsterType.Mob);
			if (!isHostileMonster)
				return false;

			return true;
		}

		/// <summary>
		/// Turns item monster into an item and adds it to the character's
		/// inventory.
		/// </summary>
		/// <param name="itemMonster"></param>
		public void PickUp(ItemMonster itemMonster)
		{
			itemMonster.PickedUp = true;
			itemMonster.Item.ClearProtections();

			// Play pickup animation. This is what actually makes the item
			// disappear, the client doesn't seem to react to ZC_LEAVE in
			// the case of items. Or at least not reliably? It's weird.
			Send.ZC_ITEM_GET(this, itemMonster);

			// Add the item to the inventory
			this.Inventory.Add(itemMonster.Item, InventoryAddType.PickUp);

			// Remove it from the map, so it can't be picked up again.
			this.Map.RemoveMonster(itemMonster);
		}

		/// <summary>
		/// Toggles whether the character is sitting or not.
		/// </summary>
		public void ToggleSitting()
		{
			this.IsSitting = !this.IsSitting;
			this.SitStatusChanged?.Invoke(this);

			Send.ZC_REST_SIT(this);
		}

		/// <summary>
		/// Plays effect for the character.
		/// </summary>
		/// <param name="packetString"></param>
		public void PlayEffect(string packetString)
		{
			Send.ZC_NORMAL.PlayEffect(this, packetString);
		}

		/// <summary>
		/// Changes the character's hair and updates nearby clients.
		/// </summary>
		/// <param name="hairTypeIndex"></param>
		public void ChangeHair(int hairTypeIndex)
		{
			this.Hair = hairTypeIndex;
			Send.ZC_UPDATED_PCAPPEARANCE(this);
		}
	}
}
