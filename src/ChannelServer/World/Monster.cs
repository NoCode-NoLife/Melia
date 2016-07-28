// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;
using Melia.Shared.World;
using Melia.Shared.World.Shapes;
using System;
using Melia.Channel.World.SkillEffects;
using System.Collections.Generic;
using Melia.Channel.World.AI;

namespace Melia.Channel.World
{
	public class Monster : Entity, IVisitor
	{

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
		/// AoE Defense Ratio
		/// </summary>
		public int SDR { get; set; }

		/// <summary>
		/// At this time the monster will be removed from the map.
		/// </summary>
		public DateTime DisappearTime { get; set; }

		/// <summary>
		/// Data entry for this monster.
		/// </summary>
		public MonsterData Data { get; private set; }

		public IEntity target;
		private Dictionary<IEntity, AggroInfo> _aggroList;

		public bool isMoving = false;

		public SpawnZone spawnZone;
		public Position spawnPosition;


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
			this.DisappearTime = DateTime.MaxValue;

			this.LoadData();

			this.Hp = this.MaxHp = this.Data.Hp > 0 ? this.Data.Hp : 1;
			this.Radius = this.Data.CollisionRadious > 0 ? this.Data.CollisionRadious : 10;
			this.CollisionShape = new Circle(this.Radius);

			this.walkSpeed = this.Data.WalkSpeed;
			this.runSpeed = this.Data.RunSpeed;
			this.SetWalking();

			this.statsManager = new StatsManager(this);
			float[] baseStats = new float[(int)Stat.Stat_MAX];
			
			baseStats[(int)Stat.MovSpeed] = this.GetSpeed();
			this.statsManager.SetBaseStats(baseStats);
			this.skillEffectsManager = new SkillEffectsManager(this);
			this.skillEffects = new List<SkillEffect>();

			this.mainAttackSkill = new Skill(50045, 1);
			this.mainAttackSkill.owner = this;

			_aggroList = new Dictionary<IEntity, AggroInfo>();
		}

		/// <summary>
		/// Loads data from data files.
		/// </summary>
		private void LoadData()
		{
			if (this.Id == 0)
				throw new InvalidOperationException("Id wasn't set before calling LoadData.");

			this.Data = ChannelServer.Instance.Data.MonsterDb.Find((int)this.Id);
			if (this.Data == null)
				throw new NullReferenceException("No data found for '" + this.Id + "'.");
		}

		/// <summary>
		/// Makes monster take damage and kills it if the HP reach 0.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="from"></param>
		public override int TakeDamage(int damage, IEntity from)
		{

			if (this.IsDead)
				return 0;

			this.Hp -= damage;

			if (this.Hp <= 0)
				this.Kill(from);
			else if (this.AI != null)
				this.AI.notifyEvent(AIEventTypes.AI_EVENT_ATTACKED, from);

			return damage;
		}

		/// <summary>
		/// Kills monster.
		/// </summary>
		/// <param name="killer"></param>
		public override void Kill(IEntity killer)
		{
			var expRate = ChannelServer.Instance.Conf.World.ExpRate / 100;
			var classExpRate = ChannelServer.Instance.Conf.World.ClassExpRate / 100;

			var exp = (int)(this.Data.Exp * expRate);
			var classExp = (int)(this.Data.ClassExp * classExpRate);

			this.DisappearTime = DateTime.Now.AddSeconds(2);
			if (killer is Character) ((Character)killer).GiveExp(exp, classExp, this);

			this.IsDead = true;

			if (this.spawnZone != null)
			{
				this.spawnZone.NotifyEntityDeath(this.Handle);
			}

			base.Kill(killer);

			Send.ZC_DEAD(this);

		}

		public bool OnVisit(Actor actor)
		{
			return true;
		}

		public bool IntersectWith(Actor actor)
		{
			return this.CollisionShape.IntersectWith(actor.CollisionShape);
		}

		public void Process()
		{

		}

		public override void SetAttackState(bool isAttacking)
		{
			this.IsAttacking = true;
			Send.ZC_PC_ATKSTATE(this, isAttacking);
		}

		public override int Heal(int amount, bool isPercent)
		{
			return base.Heal(amount, isPercent);

		}

		public void UseMainAttack(IEntity attackTarget)
		{
			this.mainAttackSkill.Activate();
		}

		override public TargetType GetTargetType(IEntity entity)
		{
			if (entity == this)
			{
				return TargetType.SELF;
			}

			if (entity is Character) /// TODO , correct this, is for testing purposes
			{
				return TargetType.ENEMY;
			}

			return TargetType.NONE;
		}

		public Dictionary<IEntity, AggroInfo> getAggroList()
		{
			return _aggroList;
		}

		public void AddDamageHate(IEntity attacker, int damage, int aggro)
		{
			if (attacker == null)
				return;

			AggroInfo aggroInfo;
			if (!_aggroList.TryGetValue(attacker, out aggroInfo)) {
				aggroInfo = new AggroInfo(attacker);
				aggroInfo.hate = 0;
				aggroInfo.damage = 0;
				lock (_aggroList)
				{
					_aggroList.Add(attacker, aggroInfo);
				}
			}

			// If damage == 0, means this is an "add new attacker" operation
			if (damage == 0)
			{
				aggroInfo.hate += aggro;
			} else
			{
				aggroInfo.hate += aggro;
			}
			aggroInfo.damage += damage;

			// Set intention of this Monster to AI_INTENTION_ACTIVE if IDLE
			if (this.AI != null && aggro > 0 && this.AI.GetIntention() == IntentionTypes.AI_INTENTION_IDLE)
				this.AI.SetIntention(IntentionTypes.AI_INTENTION_ACTIVE);

			if (damage > 0)
			{
				// Notify Monster about this attack
				if (this.AI != null)
					this.AI.notifyEvent(AIEventTypes.AI_EVENT_ATTACKED);
			}
		}

		public void StopHating(IEntity entity)
		{
			if (entity == null)
				return;

			lock (_aggroList)
			{
				AggroInfo aggroInfo;
				if (_aggroList.TryGetValue(entity, out aggroInfo))
				{
					aggroInfo.hate = 0;
				}
			}
		}

		public IEntity GetMostHated()
		{
			if (_aggroList == null || _aggroList.Count == 0)
				return null;

			IEntity mostHated = null;
			int maxHate = 0;

			lock (_aggroList)
			{
				foreach (var aggroInfo in _aggroList.Values)
				{
					if (aggroInfo == null)
						continue;

					if (aggroInfo.hate > maxHate)
					{
						mostHated = aggroInfo.attacker;
						maxHate = aggroInfo.hate;
					}
				}
			}

			return mostHated;
		}

		public int GetHating(IEntity entity)
		{
			if (entity == null)
				return 0;

			AggroInfo aggroInfo;
			if (_aggroList.TryGetValue(entity, out aggroInfo)) {
				return aggroInfo.hate;
			}

			return 0;
		}

		public void ClearAggroList()
		{
			_aggroList.Clear();
		}

	}

	public class AggroInfo
	{
		public IEntity attacker;
		public int hate;
		public int damage;

		public AggroInfo(IEntity entity)
		{
			this.attacker = entity;
		}

		public override int GetHashCode()
		{
			return attacker.Handle;
		}
	}
}
