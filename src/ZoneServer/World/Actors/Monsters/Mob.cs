using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
using Melia.Shared.World;
using Melia.Zone.Buffs.Handlers.Common;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
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
		/// Returns the monster's element/attribute.
		/// </summary>
		public AttributeType Attribute => (AttributeType)(int)this.Properties.GetFloat(PropertyName.Attribute, (int)AttributeType.None);

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
		public int Level => (int)this.Properties.GetFloat(PropertyName.Level);

		/// <summary>
		/// Gets or sets the mob's AoE Defense Ratio.
		/// </summary>
		public float SDR => this.Properties.GetFloat(PropertyName.SDR);

		/// <summary>
		/// Returns the mob's current HP.
		/// </summary>
		public int Hp => (int)this.Properties.GetFloat(PropertyName.HP);

		/// <summary>
		/// Returns the mob's maximum HP.
		/// </summary>
		public int MaxHp => (int)this.Properties.GetFloat(PropertyName.MHP);

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
		/// Returns a list of fixed items the monster drops as is when it dies.
		/// </summary>
		public ConcurrentBag<Item> StaticDrops { get; } = new ConcurrentBag<Item>();

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

			if (this.IsBuffActive(BuffId.Skill_NoDamage_Buff) || this.IsBuffActive(BuffId.BackSlide_MomentaryEvasion_Buff))
				return false;

			this.Properties.Modify(PropertyName.HP, -damage);
			this.HpChangeCounter++;

			// Register hits before potentially killing the monster,
			// so the damage can be factored into finding the top
			// attacker.
			this.Components.Get<CombatComponent>()?.RegisterHit(attacker, damage);

			if (this.Hp == 0)
				this.Kill(attacker);

			this.Map.AlertAis(this, new HitEventAlert(this, attacker, damage));

			return this.IsDead;
		}

		/// <summary>
		/// Kills monster.
		/// </summary>
		/// <param name="killer"></param>
		public void Kill(ICombatEntity killer)
		{
			this.Properties.SetFloat(PropertyName.HP, 0);
			this.Components.Get<MovementComponent>()?.Stop();
			this.DisappearTime = DateTime.Now.AddSeconds(2);

			var beneficiary = this.GetKillBeneficiary(killer);

			if (this.MonsterType == MonsterType.Mob && beneficiary != null)
			{
				this.GetExpToGive(out var exp, out var jobExp);

				this.DropItems(beneficiary);
				beneficiary?.GiveExp(exp, jobExp, this);
			}

			this.Died?.Invoke(this, killer);
			ZoneServer.Instance.ServerEvents.OnEntityKilled(this, killer);

			Send.ZC_DEAD(this);
		}

		/// <summary>
		/// Returns the character that benefits from the kill of the mob
		/// in form of EXP and drops.
		/// </summary>
		/// <param name="killer"></param>
		/// <returns></returns>
		private Character GetKillBeneficiary(ICombatEntity killer)
		{
			var beneficiary = killer;

			var topAttacker = this.Components.Get<CombatComponent>()?.GetTopAttackerByDamage();
			if (topAttacker != null)
				beneficiary = topAttacker;

			if (beneficiary.Components.Get<AiComponent>()?.Script.GetMaster() is Character master)
				beneficiary = master;

			return beneficiary as Character;
		}

		/// <summary>
		/// Returns the EXP to give to the beneficiary of killing the mob
		/// via out.
		/// </summary>
		/// <param name="exp"></param>
		/// <param name="jobExp"></param>
		private void GetExpToGive(out long exp, out long jobExp)
		{
			var worldConf = ZoneServer.Instance.Conf.World;

			var expRate = worldConf.ExpRate / 100.0;
			var jobExpRate = worldConf.JobExpRate / 100.0;

			if (this.IsBuffActive(BuffId.SuperExp))
			{
				expRate *= worldConf.BlueJackpotExpRate / 100.0;
				jobExpRate *= worldConf.BlueJackpotExpRate / 100.0;
			}
			if (this.IsBuffActive(BuffId.EliteMonsterBuff))
			{
				expRate *= worldConf.EliteExpRate / 100.0;
				jobExpRate *= worldConf.EliteExpRate / 100.0;
			}

			exp = 0L;
			jobExp = 0L;

			if (this.Data.Exp > 0)
				exp = (long)Math.Max(1, this.Data.Exp * expRate);
			if (this.Data.JobExp > 0)
				jobExp = (long)Math.Max(1, this.Data.JobExp * jobExpRate);
		}

		/// <summary>
		/// Calculates the drop chance rate for the given item based
		/// on its own property, the server's configuration, as well
		/// as other factors.
		/// </summary>
		/// <param name="dropEntry">The drop data to get the adjusted drop rate for.</param>
		/// <returns></returns>
		public static float GetAdjustedDropRate(DropData dropEntry)
		{
			var itemData = ZoneServer.Instance.Data.ItemDb.Find(dropEntry.ItemId);

			// Don't drop items that don't exist in the database
			if (itemData == null)
				return -1;

			var worldConf = ZoneServer.Instance.Conf.World;
			var dropChance = dropEntry.DropChance;

			if (itemData.Id == ItemId.Silver || itemData.Id == ItemId.Gold)
			{
				dropChance *= worldConf.SilverDropRate / 100f;
			}
			else if (itemData.Type == ItemType.Equip || itemData.Type == ItemType.PetArmor || itemData.Type == ItemType.PetWeapon)
			{
				dropChance *= worldConf.EquipmentDropRate / 100f;
			}
			else if (itemData.ClassName.StartsWith("BlueOrb_"))
			{
				dropChance *= worldConf.BlueOrbDropRate / 100f;
			}
			else if (itemData.ClassName.StartsWith("RedOrb_"))
			{
				dropChance *= worldConf.RedOrbDropRate / 100f;
			}
			else if (itemData.Group == ItemGroup.Gem)
			{
				dropChance *= worldConf.GemDropRate / 100f;
			}
			else
			{
				dropChance *= worldConf.GeneralDropRate / 100f;
			}

			return dropChance;
		}

		/// <summary>
		/// Drops random items from the monster's drop table.
		/// </summary>
		/// <param name="killer"></param>
		private void DropItems(Character killer)
		{
			if (this.Data.Drops != null)
			{
				var dropStacks = this.GenerateDropStacks(killer);
				this.DropStacks(killer, dropStacks);
			}

			this.DropStatic(killer);
		}

		/// <summary>
		/// Generates a list of random items to drop from the monster's
		/// drop table.
		/// </summary>
		/// <param name="killer"></param>
		/// <returns></returns>
		private List<DropStack> GenerateDropStacks(Character killer)
		{
			var result = new List<DropStack>();

			var rnd = RandomProvider.Get();
			var autolootChance = killer?.Variables.Temp.Get("Autoloot", 0) ?? 0;
			var worldConf = ZoneServer.Instance.Conf.World;

			foreach (var dropItemData in this.Data.Drops)
			{
				if (!ZoneServer.Instance.Data.ItemDb.TryFind(dropItemData.ItemId, out var itemData))
				{
					Log.Warning("Monster.DropItems: Drop item '{0}' not found.", dropItemData.ItemId);
					continue;
				}

				var originalDropChance = dropItemData.DropChance;
				var adjustedDropChance = GetAdjustedDropRate(dropItemData);

				// Each point of looting chance increases drop rate by 0.1%,
				// so 500 looting chance = 1.5x drop rate.
				var lootingChance = killer.Properties.GetFloat(PropertyName.LootingChance);
				var lootingRate = 1f + lootingChance * 0.001f;
				adjustedDropChance *= lootingRate;

				// Calculate Enhanced drops for super mobs
				var isSuperMob = this.TryGetSuperMob(out var superMobType);
				var superMobRerolls = 0;
				var superMobGuaranteedItemDrop = false;
				var superMobIncreaseMoney = 0;
				var superMobMoneyStacks = 0;
				if (isSuperMob)
				{
					switch (superMobType)
					{
						case SuperMobType.Silver:
							superMobRerolls = worldConf.SilverJackpotRolls;
							superMobGuaranteedItemDrop = originalDropChance > worldConf.SilverJackpotGuaranteedItemThreshold;
							superMobIncreaseMoney = worldConf.SilverJackpotRolls;
							superMobMoneyStacks = rnd.Next(40, 50);
							break;

						case SuperMobType.Gold:
							superMobRerolls = worldConf.GoldJackpotRolls;
							superMobGuaranteedItemDrop = originalDropChance > worldConf.GoldJackpotGuaranteedItemThreshold;
							superMobIncreaseMoney = worldConf.SilverJackpotRolls * 4;
							superMobMoneyStacks = rnd.Next(40, 50);
							break;

						case SuperMobType.Elite:
							superMobRerolls = worldConf.EliteRolls;
							superMobGuaranteedItemDrop = originalDropChance > worldConf.EliteGuaranteedItemThreshold;
							superMobIncreaseMoney = worldConf.EliteRolls;
							superMobMoneyStacks = rnd.Next(40, 50);
							break;
					}
				}

				var isMoney = itemData.Id == ItemId.Silver || itemData.Id == ItemId.Gold;
				var minAmount = dropItemData.MinAmount;
				var maxAmount = dropItemData.MaxAmount;
				var stackCount = 1;

				if (isMoney)
				{
					minAmount = Math.Max(1, (int)(minAmount * (ZoneServer.Instance.Conf.World.SilverDropAmount / 100f)));
					maxAmount = Math.Max(minAmount, (int)(maxAmount * (ZoneServer.Instance.Conf.World.SilverDropAmount / 100f)));

					// Increased number of stacks and items per stack for
					// super mobs
					if (isSuperMob)
					{
						minAmount *= superMobIncreaseMoney;
						maxAmount *= superMobIncreaseMoney;
						stackCount += superMobMoneyStacks;
					}
				}

				var itemId = dropItemData.ItemId;
				var amount = rnd.Next(minAmount, maxAmount + 1);
				var rerolls = superMobRerolls;
				var guaranteed = superMobGuaranteedItemDrop;
				do
				{
					rerolls--;

					// Items above the given threshold will
					// always drop at least once for super mobs.
					var dropSuccess = rnd.NextDouble() < adjustedDropChance / 100f;
					if (!dropSuccess && !guaranteed)
						continue;

					for (var i = 0; i < stackCount; ++i)
					{
						var dropStack = new DropStack(itemId, amount, originalDropChance, adjustedDropChance);
						result.Add(dropStack);
					}

					guaranteed = false;
				}
				while (rerolls > 0 && !isMoney);
			}

			return result;
		}

		/// <summary>
		/// Checks if the given entity is a super mob
		/// </summary>
		/// <remarks>
		/// The super drop level affects the drop chance and drop rate
		/// of items. Level 1 increases the chance and even elevates
		/// some items to 100%, while level 2 increases the chance
		/// even more.
		/// </remarks>
		/// <returns></returns>
		private bool TryGetSuperMob(out SuperMobType superMobType)
		{
			superMobType = (SuperMobType)(-1);

			// Note: The client cannot handle SuperDrop and EliteMonsterBuff
			// together.
			if (this.Buffs.Has(BuffId.EliteMonsterBuff))
			{
				superMobType = SuperMobType.Elite;
				return true;
			}
			else if (this.Buffs.TryGet(BuffId.SuperDrop, out var buff))
			{
				if (buff.NumArg2 == 0)
				{
					superMobType = SuperMobType.Silver;
					return true;
				}
				else if (buff.NumArg2 == 1)
				{
					superMobType = SuperMobType.Gold;
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Creates items from the given stacks and drops them.
		/// </summary>
		/// <param name="killer"></param>
		/// <param name="dropStacks"></param>
		private void DropStacks(Character killer, List<DropStack> dropStacks)
		{
			var rnd = RandomProvider.Get();

			foreach (var stack in dropStacks)
			{
				var dropItem = new Item(stack.ItemId, stack.Amount);

				var autolootThreshold = killer?.Variables.Temp.Get("Autoloot", 0);
				var autoloot = stack.DropChance <= autolootThreshold;

				if (autoloot)
				{
					killer.Inventory.Add(dropItem, InventoryAddType.PickUp);
					continue;
				}

				var direction = new Direction(rnd.Next(0, 360));
				var dropRadius = ZoneServer.Instance.Conf.World.DropRadius;
				var distance = rnd.Next(dropRadius / 2, dropRadius + 1);

				dropItem.SetLootProtection(killer, TimeSpan.FromSeconds(ZoneServer.Instance.Conf.World.LootPrectionSeconds));
				dropItem.Drop(this.Map, this.Position, direction, distance);
			}
		}

		/// <summary>
		/// Drops the monster's static drops if any were added.
		/// </summary>
		/// <param name="killer"></param>
		private void DropStatic(Character killer)
		{
			var rnd = RandomProvider.Get();

			while (this.StaticDrops.TryTake(out var dropItem))
			{
				var autolootThreshold = killer?.Variables.Temp.Get("Autoloot", 0);
				var autoloot = autolootThreshold > 0;

				if (autoloot)
				{
					killer.Inventory.Add(dropItem, InventoryAddType.PickUp);
					continue;
				}

				var direction = new Direction(rnd.Next(0, 360));
				var dropRadius = ZoneServer.Instance.Conf.World.DropRadius;
				var distance = rnd.Next(dropRadius / 2, dropRadius + 1);

				dropItem.SetLootProtection(killer, TimeSpan.FromSeconds(ZoneServer.Instance.Conf.World.LootPrectionSeconds));
				dropItem.Drop(this.Map, this.Position, direction, distance);
			}
		}

		/// <summary>
		/// Randomly assigns rare monster buffs based on given rates.
		/// </summary>
		/// <param name="jackpotRate">
		/// Rate modifier for chance to receive a jackpot buff. The default,
		/// 100%, represents the default chance as per the configuration.
		/// </param>
		/// <param name="eliteRate">
		/// Rate modifier for chance to receive an elite buff. The default,
		/// 100%, represents the default chance as per the configuration.
		/// </param>
		/// <returns></returns>
		public void PossiblyBecomeRare(float jackpotRate = 100, float eliteRate = 100)
		{
			var rnd = RandomProvider.Get();

			var worldConf = ZoneServer.Instance.Conf.World;

			var silverChance = worldConf.SilverJackpotSpawnChance * jackpotRate / 100f;
			if (rnd.NextDouble() * 100 < silverChance)
			{
				this.StartBuff(BuffId.SuperDrop, 100, 0, TimeSpan.Zero, this);
				return;
			}

			var goldChance = worldConf.GoldJackpotSpawnChance * jackpotRate / 100f;
			if (rnd.NextDouble() * 100 < goldChance)
			{
				this.StartBuff(BuffId.SuperDrop, 1000, 1, TimeSpan.Zero, this);
				return;
			}

			// The default chance for SuperExp is 1:12000, based on the
			// monster property "SuperExpRegenRatio".
			var blueChance = worldConf.BlueJackpotSpawnChance * jackpotRate / 100f;
			if (rnd.NextDouble() * 100 < blueChance)
			{
				this.StartBuff(BuffId.SuperExp, 1, 0, TimeSpan.Zero, this);
				return;
			}

			var canBecomeElite = (this.Map.Data.Level < worldConf.EliteMinLevel);
			if (canBecomeElite)
				return;

			var eliteChance = worldConf.EliteSpawnChance * eliteRate / 100f;
			if (rnd.NextDouble() * 100 < eliteChance)
			{
				this.StartBuff(BuffId.EliteMonsterBuff, 1, 0, TimeSpan.Zero, this);

				var propertyOverrides = new PropertyOverrides();
				propertyOverrides.Add(PropertyName.MHP, this.Properties.GetFloat(PropertyName.MHP) * worldConf.EliteHPSPRate / 100f);
				propertyOverrides.Add(PropertyName.MSP, this.Properties.GetFloat(PropertyName.MSP) * worldConf.EliteHPSPRate / 100f);
				propertyOverrides.Add(PropertyName.MINPATK, this.Properties.GetFloat(PropertyName.MINPATK) * worldConf.EliteStatRate / 100f);
				propertyOverrides.Add(PropertyName.MAXPATK, this.Properties.GetFloat(PropertyName.MAXPATK) * worldConf.EliteStatRate / 100f);
				propertyOverrides.Add(PropertyName.MINMATK, this.Properties.GetFloat(PropertyName.MINMATK) * worldConf.EliteStatRate / 100f);
				propertyOverrides.Add(PropertyName.MAXMATK, this.Properties.GetFloat(PropertyName.MAXMATK) * worldConf.EliteStatRate / 100f);
				propertyOverrides.Add(PropertyName.DEF, this.Properties.GetFloat(PropertyName.DEF) * worldConf.EliteStatRate / 100f);
				propertyOverrides.Add(PropertyName.MDEF, this.Properties.GetFloat(PropertyName.MDEF) * worldConf.EliteStatRate / 100f);

				this.ApplyOverrides(propertyOverrides);

				if (worldConf.EliteAlwaysAggressive)
					this.Tendency = TendencyType.Aggressive;

				// TODO: Add summoning and special attacks.
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
		/// Heals the monster's HP and SP by the given amounts. Applies potential
		/// (de)buffs that affect healing.
		/// </summary>
		/// <param name="hpAmount"></param>
		/// <param name="spAmount"></param>
		public void Heal(float hpAmount, float spAmount)
		{
			float healingReduction = 0;

			// TODO: Move this somewhere else, perhaps with a hook/event?
			DecreaseHeal_Debuff.TryApply(this, ref hpAmount);

			var healingModifier = Math.Max(0, 1 - healingReduction);

			this.Properties.Modify(PropertyName.HP, hpAmount * healingModifier);
			this.Properties.Modify(PropertyName.SP, spAmount);

			this.HpChangeCounter++;

			Send.ZC_UPDATE_ALL_STATUS(this, this.HpChangeCounter);
		}

		/// <summary>
		/// Overrides the monster's properties with the given values.
		/// </summary>
		/// <param name="overrides"></param>
		public void ApplyOverrides(PropertyOverrides overrides)
		{
			foreach (var propertyOverride in overrides)
			{
				var propertyName = propertyOverride.Key;

				// Since calculated properties can't be overridden directly,
				// we swap to the override properties that the calculation
				// functions use for each property as necessary.
				var properties = this.Properties as Properties;

				var canSet = !properties.TryGet(propertyName, out var property) || (property is not CFloatProperty && property is not RFloatProperty);
				if (!canSet)
					properties = this.Properties.Overrides;

				switch (propertyOverride.Value)
				{
					case int intValue:
						properties.SetFloat(propertyName, intValue);
						break;

					case float floatValue:
						properties.SetFloat(propertyName, floatValue);
						break;

					case string stringValue:
						properties.SetString(propertyName, stringValue);
						break;
				}
			}

			this.Properties.InvalidateAll();

			this.Properties.SetFloat(PropertyName.HP, this.Properties.GetFloat(PropertyName.MHP));
			this.Properties.SetFloat(PropertyName.SP, this.Properties.GetFloat(PropertyName.MSP));
		}
	}
}
