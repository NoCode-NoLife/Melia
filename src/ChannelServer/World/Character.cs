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
using Melia.Channel.World.SkillEffects;
using Melia.Channel.World.AI;

namespace Melia.Channel.World
{
	public class Character : Entity, ICommander, IEntity, IVisitor
	{
		public int test;
		/// <summary>
		/// Id of the character's account.
		/// </summary>
		public long AccountId { get; set; }

		/// <summary>
		/// Character's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Character's team name.
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// Character's job.
		/// </summary>
		public Job Job { get; set; }

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
		public int Stance
		{
			get
			{
				var cls = this.Job.ToClass();

				// The stance is affected by the equipped items, we might
				// have to move this to a place where we have proper access
				// to the character's items, and we need item types.
				// Maybe we can use ItemData on Login, so we don't need
				// another Item class.
				// For the official conditions see stancecondition.ies.

				switch (cls)
				{
					default:
					case Class.Swordsman:
						return 10000;

					case Class.Wizard:
						return 10006;

					case Class.Archer:
						return 10008;

					case Class.Cleric:
					case Class.GM:
						return 10004;
				}
			}
		}



		private bool _warping;

		private object _lookAroundLock = new object();
		private Monster[] _visibleMonsters = new Monster[0];
		private Character[] _visibleCharacters = new Character[0];

		public Dictionary<Job, int> jobs;
		public Dictionary<Job, int> jobPoints;
		public int jobLevel;

		/// <summary>
		/// Connection this character uses.
		/// </summary>
		public ChannelConnection Connection { get; set; }


		private Map _map = Map.Limbo;

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
		/// Specifies whether the character currently updates the visible
		/// entities around the character.
		/// </summary>
		public bool EyesOpen { get; private set; }

		/// <summary>
		/// Character's scripting variables.
		/// </summary>
		public Variables Variables { get; private set; }

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
			ChannelServer.Instance.World.RegisterToEvents(this.Handle);
			this.Inventory = new Inventory(this);
			this.Variables = new Variables();
			this.walkSpeed = 30;
			this.runSpeed = 30; // Characters seems not to have Running speed
			this.SetWalking();
			this.jobs = new Dictionary<Job, int>();
			this.skillManager = new SkillManager(this);
			this.statsManager = new StatsManager(this);
			this.statsManager.baseStats[(int)Stat.MovSpeed] = GetSpeed();
			this.skillEffectsManager = new SkillEffectsManager(this);
			this.skillEffects = new List<SkillEffect>();

			this.Radius = 10;
			this.CollisionShape = new Circle(this.Radius);

			this.lastHpRegenTime = DateTime.Now;
			this.lastSpRegenTime = DateTime.Now;

			this.AI = new AIPlayer(this);

		}

		/// <summary>
		/// Returns character's current speed.
		/// </summary>
		/// <returns></returns>
		public override float GetSpeed()
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
			this.AI.SetIntention(IntentionTypes.AI_INTENTION_MOVETO, new Position(x, y, z));
			return;			
		}

		/// <summary>
		/// Process character
		/// </summary>
		public void Process()
		{
			/*
			if (this.IsMoving)
				ProcessMove();
			*/

			// Regeneration
			this.HPRegen();
			this.SPRegen();
			this.UpdateState();
		}

		private void HPRegen()
		{
			TimeSpan diff = DateTime.Now - this.lastHpRegenTime;
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

		public override void SetAttackState(bool isAttacking)
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

		public override int Heal(int amount, bool isPercent)
		{
			int healedAmount = base.Heal(amount, isPercent);

			Send.ZC_HEAL_INFO(this, healedAmount, this.Hp);
			Send.ZC_UPDATE_ALL_STATUS(this, this.Hp, this.MaxHp, (short)this.Sp, (short)this.MaxSp);

			return healedAmount;

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
						this.CastSkill(skill);
						//skill.Activate();
				}
			}
			
				
		}

		public new float AdjustInfringedDamage(float damage)
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
		public new float AdjustReceivedDamage(float damage)
		{
			base.AdjustReceivedDamage(damage);
			return damage;
		}

		/// <summary>
		/// Makes entity take damage and kills it if the HP reach 0.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="from"></param>
		public new void TakeDamage(int damage, IEntity from)
		{
			base.TakeDamage(damage, from);
		}

	}
}
