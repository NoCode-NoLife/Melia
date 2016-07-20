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
		public Dictionary<int, AggroTarget> possibleTargets;


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

			this.LoadData();

			this.CollisionShape = new Circle(10.0f);

			this.statsManager = new StatsManager(this);
			float[] baseStats = new float[(int)Stat.Stat_MAX];
			baseStats[(int)Stat.MovSpeed] = 20.0f;
			this.statsManager.SetBaseStats(baseStats);
			this.skillEffectsManager = new SkillEffectsManager(this);
			this.skillEffects = new List<SkillEffect>();

			this.possibleTargets = new Dictionary<int, AggroTarget>();
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
		public override void TakeDamage(int damage, IEntity from)
		{

			if (this.IsDead)
				return;

			Log.Debug("{0} Received damage", this.Handle);

			lock (possibleTargets)
			{
				if (!this.possibleTargets.ContainsKey(from.Handle))
				{
					Log.Debug("Add attacker {0} to AggroList", from.Handle);
					AggroTarget aggroT = new AggroTarget();
					aggroT.entity = from;
					aggroT.aggro = damage;
					this.possibleTargets.Add(from.Handle, aggroT);
				}
			}

			this.Hp -= damage;

			// In earlier clients ZC_HIT_INFO was used, newer ones seem to
			// use SKILL, and this doesn't create a double hit effect like
			// the other.
			//Send.ZC_SKILL_HIT_INFO(from, this, damage);

			Log.Debug("remaining HP after TakeDamage {0}", this.Hp);
			if (this.Hp <= 0)
				this.Kill(from);
		}

		/// <summary>
		/// Kills monster.
		/// </summary>
		/// <param name="killer"></param>
		public void Kill(IEntity killer)
		{
			var expRate = ChannelServer.Instance.Conf.World.ExpRate / 100;
			var classExpRate = ChannelServer.Instance.Conf.World.ClassExpRate / 100;

			var exp = (int)(this.Data.Exp * expRate);
			var classExp = (int)(this.Data.ClassExp * classExpRate);

			this.DisappearTime = DateTime.Now.AddSeconds(2);
			if (killer is Character) ((Character)killer).GiveExp(exp, classExp, this);

			this.IsDead = true;

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
			// Process skill effects
			this.skillEffectsManager.RemoveExpiredEffects();
			this.skillEffectsManager.ProcessEffects();
			this.SelectTarget();
		}

		public void SelectTarget()
		{
			IEntity tempTarget = null;
			int highestAggro = 0;
			lock (this.possibleTargets)
			{
				// Remove invalid targets
				List<int> keysToRemove = new List<int>();
				foreach (var aggroT in this.possibleTargets)
				{
					this.RecalculateAggro(aggroT.Value);
					if (aggroT.Value.aggro == 0)
					{
						keysToRemove.Add(aggroT.Key);
					}
				}

				foreach (var key in keysToRemove)
				{
					Log.Debug("Remove target as possible target");
					this.possibleTargets.Remove(key);
					if (this.target != null && key == this.target.Handle)
					{
						this.target = null;
					}
				}

				// Select new target
				foreach (var aggroT in this.possibleTargets)
				{
					if (aggroT.Value.aggro > highestAggro)
					{
						tempTarget = aggroT.Value.entity;
						highestAggro = aggroT.Value.aggro;
					}
				}
				if (tempTarget != null && tempTarget != this.target)
				{
					this.target = tempTarget;
					Log.Debug("Monster {0}: new target is {1}", this.Handle, this.target.Handle);
				}
					
			}
		}

		public void RecalculateAggro(AggroTarget aggroT)
		{
			if (aggroT.entity.IsFade)
			{
				Log.Debug("Target is Fade, reset Aggro");
				aggroT.aggro = 0;
				return;
			}
		}

		public override int Heal(int amount, bool isPercent)
		{
			return base.Heal(amount, isPercent);

		}

	}

	public class AggroTarget
	{
		public IEntity entity;
		public int aggro;
	}
}
