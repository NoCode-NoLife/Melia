using System;
using Melia.Shared.Data.Database;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting.AI;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Items;
using Yggdrasil.Composition;
using Yggdrasil.Logging;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors.Monsters
{
	/// <summary>
	/// An actual monster.
	/// </summary>
	public class Mob : Actor, IMonster, ICombatEntity, IUpdateable
	{
		/// <summary>
		/// Gets or sets the monster's faction.
		/// </summary>
		public FactionType Faction { get; set; } = FactionType.Peaceful;

		/// <summary>
		/// Returns the monster's race.
		/// </summary>
		public RaceType Race => this.Data.Race;

		/// <summary>
		/// Returns the monster's element.
		/// </summary>
		public ElementType Element => this.Data.Element;

		/// <summary>
		/// Returns the monster's mode of movement.
		/// </summary>
		public MoveType MoveType => this.Data.MoveType;

		/// <summary>
		/// Gets or sets the monster's tendency
		/// </summary>
		public TendencyType Tendency { get; set; } = TendencyType.Peaceful;

		/// <summary>
		/// Monster ID in database.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// ?
		/// </summary>
		/// <remarks>
		/// Used by the anchors in the client files, with multiple anchors
		/// being able to use the same "gen type". This is also used to
		/// identify NPCs however, like in ZC_SET_NPC_STATE.
		/// </remarks>
		public int GenType { get; set; }
			// The client files set the gen type manually, but that seems
			// bothersome. For now, we'll generate them automatically and
			// see for what purpose we would need them to be the same for
			// multiple monsters.
			= ZoneServer.Instance.World.CreateGenType();

		/// <summary>
		/// Gets or sets what kind of "monster" the mob is.
		/// </summary>
		public MonsterType MonsterType { get; set; }

		/// <summary>
		/// Gets or sets monster's name, leave empty for default.
		/// </summary>
		public override string Name { get; set; }

		/// <summary>
		/// Gets or sets monster's unique name.
		/// </summary>
		/// <remarks>
		/// Purpose currently unknown.
		/// </remarks>
		public string UniqueName { get; set; }

		/// <summary>
		/// Gets or sets the function to call when the monster is clicked.
		/// </summary>
		/// <remarks>
		/// Not actively used in Melia, but important to the client,
		/// as it's used to determine whether the monster is clickable
		/// and should display an HP bar.
		/// </remarks>
		public string DialogName { get; set; }

		/// <summary>
		/// Gets or sets the name of the function to call when the monster's
		/// trigger area is entered.
		/// </summary>
		/// <remarks>
		/// Not actively used in Melia, but potentially importat to the
		/// client.
		/// </remarks>
		public string EnterName { get; set; }

		/// <summary>
		/// Gets or sets the name of the function to call when the monster's
		/// trigger area is left.
		/// </summary>
		/// <remarks>
		/// Not actively used in Melia, but potentially importat to the
		/// client.
		/// </remarks>
		public string LeaveName { get; set; }

		/// <summary>
		/// Gets or sets the mob's level.
		/// </summary>
		public int Level { get; set; } = 1;

		/// <summary>
		/// Gets or sets the mob's AoE Defense Ratio.
		/// </summary>
		public float SDR { get; set; } = 1;

		/// <summary>
		/// Returns the mob's current HP.
		/// </summary>
		public int Hp => (int)this.Properties.GetFloat(PropertyName.HP);

		/// <summary>
		/// Returns the mob's maximum HP.
		/// </summary>
		public int MaxHp => (int)this.Properties.GetFloat(PropertyName.MHP);

		/// <summary>
		/// Physical defense.
		/// </summary>
		public int Defense
		{
			get { return _defense; }
			private set { _defense = Math.Max(0, value); }
		}
		private int _defense;

		/// <summary>
		/// Raised when the monster died.
		/// </summary>
		public event Action<Mob, ICombatEntity> Died;

		/// <summary>
		/// At this time the monster will be removed from the map.
		/// </summary>
		public DateTime DisappearTime { get; set; } = DateTime.MaxValue;

		/// <summary>
		/// Data entry for this monster.
		/// </summary>
		public MonsterData Data { get; private set; }

		/// <summary>
		/// Returns whether the monster is dead.
		/// </summary>
		public bool IsDead => this.Hp == 0;

		/// <summary>
		/// Gets or sets whether the monster appears from inside the ground.
		/// </summary>
		/// <remarks>
		/// If this property is true, the monster will dig itself out of the
		/// ground when it appears. 
		/// </remarks>
		public bool FromGround { get; set; }

		/// <summary>
		/// Holds the order of successive changes in character HP.
		/// A higher value indicates the latest HP amount.
		/// </summary>
		public int HpChangeCounter { get; private set; }

		/// <summary>
		/// Returns the monster's property collection.
		/// </summary>
		public MonsterProperties Properties { get; protected set; }

		/// <summary>
		/// Returns the monster's property collection.
		/// </summary>
		Properties IPropertyHolder.Properties => this.Properties;

		/// <summary>
		/// Returns the monster's property collection.
		/// </summary>
		Properties IMonsterBase.Properties => this.Properties;

		/// <summary>
		/// Returns the monster's component collection.
		/// </summary>
		public ComponentCollection Components { get; } = new ComponentCollection();

		/// <summary>
		/// Monster's buffs.
		/// </summary>
		public BuffComponent Buffs { get; }

		/// <summary>
		/// Return the monster's temporary variables.
		/// </summary>
		public Variables Vars { get; } = new Variables();

		/// <summary>
		/// Creates new NPC.
		/// </summary>
		public Mob(int id, MonsterType type) : base()
		{
			this.Id = id;
			this.MonsterType = type;

			this.Components.Add(this.Buffs = new BuffComponent(this));
			this.Components.Add(new CombatComponent(this));

			this.LoadData();
		}

		/// <summary>
		/// Loads data from data files.
		/// </summary>
		protected virtual void LoadData()
		{
			if (this.Id == 0)
				throw new InvalidOperationException("Id wasn't set before calling LoadData.");

			this.Data = ZoneServer.Instance.Data.MonsterDb.Find(this.Id);
			if (this.Data == null)
				throw new NullReferenceException("No data found for '" + this.Id + "'.");

			this.Defense = this.Data.PhysicalDefense;
			this.Faction = this.Data.Faction;

			this.InitProperties();
		}

		/// <summary>
		/// Initializes monster's properties.
		/// </summary>
		private void InitProperties()
		{
			this.Properties = new MonsterProperties(this);

			this.Properties.InitAutoUpdates();
			this.Properties.InvalidateAll();

			this.Properties.SetFloat(PropertyName.HP, this.Properties.GetFloat(PropertyName.MHP));
			this.Properties.SetFloat(PropertyName.SP, this.Properties.GetFloat(PropertyName.MSP));
		}

		/// <summary>
		/// Makes monster take damage and kills it if the HP reach 0.
		/// Returns true if the monster is dead.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="attacker"></param>
		/// <returns></returns>
		public bool TakeDamage(float damage, ICombatEntity attacker)
		{
			// Don't hit an already dead monster
			if (this.IsDead)
				return true;

			this.Properties.Modify(PropertyName.HP, -damage);
			this.HpChangeCounter++;

			// Kill monster if it reached 0 HP.
			if (this.Hp == 0)
			{
				this.Kill(attacker);
				return true;
			}

			if (this.Components.TryGet<AiComponent>(out var ai))
				ai.Script.QueueEventAlert(new HitEventAlert(this, attacker, damage));

			return false;
		}

		/// <summary>
		/// Kills monster.
		/// </summary>
		/// <param name="killer"></param>
		public void Kill(ICombatEntity killer)
		{
			this.Properties.SetFloat(PropertyName.HP, 0);
			this.Components.Get<MovementComponent>()?.Stop();

			var expRate = ZoneServer.Instance.Conf.World.ExpRate / 100.0;
			var classExpRate = ZoneServer.Instance.Conf.World.ClassExpRate / 100.0;

			var exp = 0L;
			var classExp = 0L;

			if (this.Data.Exp > 0)
				exp = (long)Math.Max(1, this.Data.Exp * expRate);
			if (this.Data.ClassExp > 0)
				classExp = (long)Math.Max(1, this.Data.ClassExp * classExpRate);

			this.DisappearTime = DateTime.Now.AddSeconds(2);

			if (killer is Character characterKiller)
			{
				this.DropItems(characterKiller);
				characterKiller?.GiveExp(exp, classExp, this);
			}

			this.Died?.Invoke(this, killer);
			ZoneServer.Instance.ServerEvents.OnEntityKilled(this, killer);

			Send.ZC_DEAD(this);
		}

		/// <summary>
		/// Drops random items from the monster's drop table.
		/// </summary>
		/// <param name="killer"></param>
		private void DropItems(Character killer)
		{
			if (this.Data.Drops == null)
				return;

			var rnd = RandomProvider.Get();
			var autoloot = killer?.Variables.Temp.Get("Autoloot", 0) ?? 0;

			foreach (var dropItemData in this.Data.Drops)
			{
				var dropChance = dropItemData.DropChance;
				dropChance *= ZoneServer.Instance.Conf.World.DropRate / 100f;

				var dropSuccess = rnd.NextDouble() < dropChance / 100f;
				if (!dropSuccess)
					continue;

				if (!ZoneServer.Instance.Data.ItemDb.TryFind(dropItemData.ItemId, out var itemData))
				{
					Log.Warning("Monster.Kill: Drop item '{0}' not found.", dropItemData.ItemId);
					continue;
				}

				var dropItem = new Item(itemData.Id);
				dropItem.Amount = rnd.Next(dropItemData.MinAmount, dropItemData.MaxAmount + 1);

				if (killer == null || dropChance > autoloot)
				{
					var direction = new Direction(rnd.Next(0, 360));
					var dropRadius = ZoneServer.Instance.Conf.World.DropRadius;
					var distance = rnd.Next(dropRadius / 2, dropRadius + 1);

					dropItem.SetLootProtection(killer, TimeSpan.FromSeconds(ZoneServer.Instance.Conf.World.LootPrectionSeconds));
					dropItem.Drop(this.Map, this.Position, direction, distance);
				}
				else
				{
					killer.Inventory.Add(dropItem, InventoryAddType.PickUp);
				}
			}
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
		/// Returns true if the monster can attack the entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		public bool CanAttack(ICombatEntity entity)
		{
			if (entity == this)
				return false;

			if (entity.IsDead)
				return false;

			// For now, let's specify that mobs can attack any combat
			// entities, since we want them them to be able to attack
			// both characters and other mobs.
			//return (entity is ICombatEntity);

			// New plan. Let's say that mobs can attack those entities
			// they're hostile towards. That allows AoEs to ignore
			// friendly entities. If the mob doesn't have an AI,
			// it shouldn't need to be able to attack anything,
			// so we return false in that case.
			if (!this.Components.TryGet<AiComponent>(out var ai))
				return false;

			return ai.Script.IsHostileTowards(entity);
		}

		/// <summary>
		/// Updates monster and its components.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			this.Components.Update(elapsed);
		}

		/// <summary>
		/// Heals the monster's HP and SP by the given amounts.
		/// </summary>
		/// <param name="hpAmount"></param>
		/// <param name="spAmount"></param>
		public void Heal(float hpAmount, float spAmount)
		{
			this.Properties.Modify(PropertyName.HP, hpAmount);
			this.Properties.Modify(PropertyName.SP, spAmount);

			this.HpChangeCounter++;

			Send.ZC_UPDATE_ALL_STATUS(this, this.HpChangeCounter);
		}
	}
}
