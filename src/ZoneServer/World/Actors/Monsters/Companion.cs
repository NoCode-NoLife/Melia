using System;
using Melia.Shared.Data.Database;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Game.Const;
using Melia.Shared.Util;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Scheduling;
using System.Threading;

namespace Melia.Zone.World.Actors.Monsters
{
	public class Companion : Mob, IPropertyObject
	{
		/// <summary>
		/// Companion's unique id.
		/// </summary>
		public long DbId { get; set; }

		/// <summary>
		/// Companion's globally unique id.
		/// </summary>
		public long ObjectId => ObjectIdRanges.Companions + this.DbId;

		/// <summary>
		/// A reference to the character which owns this companion.
		/// </summary>
		public Character Owner { get; private set; }

		/// <summary>
		/// Companion is activated (Visible)
		/// </summary>
		public bool IsActivated
		{
			get
			{
				return this.Properties.GetFloat(PropertyName.IsActivated) == 1;
			}
			set
			{
				this.Properties.SetFloat(PropertyName.IsActivated, value ? 1 : 0);
			}
		}

		/// <summary>
		/// Current stamina.
		/// </summary>
		public int Stamina { get; set; }
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
		/// Adopt Time
		/// </summary>
		public DateTime AdoptTime { get; set; }

		/// <summary>
		/// Return if the companion is being ride on or not.
		/// </summary>
		public bool IsRiding { get; set; } = false;

		public CompanionData CompanionData { get; private set; }

		public Companion(Character owner, int id) : base(id, MonsterType.Friendly)
		{
			this.Owner = owner;

			if (!ZoneServer.Instance.Data.CompanionDb.TryFindByClassName(this.Data.ClassName, out var companionData))
				throw new NullReferenceException("No companion data found for '" + this.Data.ClassName + "'.");
			this.CompanionData = companionData;

			this.InitProperties();
		}

		/// <summary>
		/// Initializes companion's properties.
		/// </summary>
		private void InitProperties()
		{
			this.CreateProperty(PropertyName.STR, "SCR_Get_Companion_STR");
			this.CreateProperty(PropertyName.DEX, "SCR_Get_Companion_DEX");
			this.CreateProperty(PropertyName.CON, "SCR_Get_Companion_CON");
			this.CreateProperty(PropertyName.INT, "SCR_Get_Companion_INT");
			this.CreateProperty(PropertyName.MNA, "SCR_Get_Companion_MNA");
			this.CreateProperty(PropertyName.DEF, "SCR_Get_Companion_DEF");
			this.CreateProperty(PropertyName.MDEF, "SCR_Get_Companion_MDEF");
			this.CreateProperty(PropertyName.MHP, "SCR_Get_Companion_MHP");

			this.CreateProperty(PropertyName.MAXPATK, "SCR_Get_Companion_MAXPATK");
			this.CreateProperty(PropertyName.MINPATK, "SCR_Get_Companion_MINPATK");
			this.CreateProperty(PropertyName.MAXMATK, "SCR_Get_Companion_MAXMATK");
			this.CreateProperty(PropertyName.MINMATK, "SCR_Get_Companion_MINMATK");
			this.CreateProperty(PropertyName.ATK, "SCR_Get_Companion_ATK");

			this.CreateProperty(PropertyName.MountDEF, "SCR_Get_Companion_MOUNTDEF");
			this.CreateProperty(PropertyName.MountDR, "SCR_Get_Companion_MOUNTDR");
			this.CreateProperty(PropertyName.MountMHP, "SCR_Get_Companion_MOUNTMHP");

			this.Properties.InitAutoUpdates();
			this.Properties.AutoUpdate(PropertyName.MHP, [PropertyName.Lv, PropertyName.Level, PropertyName.MHP_BM]);
			this.Properties.AutoUpdate(PropertyName.MINPATK, [PropertyName.Lv, PropertyName.Level, PropertyName.PATK_BM]);
			this.Properties.AutoUpdate(PropertyName.MAXPATK, [PropertyName.Lv, PropertyName.Level, PropertyName.PATK_BM]);
			this.Properties.AutoUpdate(PropertyName.MINMATK, [PropertyName.Lv, PropertyName.Level, PropertyName.MATK_BM]);
			this.Properties.AutoUpdate(PropertyName.MAXMATK, [PropertyName.Lv, PropertyName.Level, PropertyName.MATK_BM]);
			this.Properties.AutoUpdate(PropertyName.ATK, [PropertyName.Lv, PropertyName.Level]);
			this.Properties.AutoUpdate(PropertyName.DEF, [PropertyName.Lv, PropertyName.Level, PropertyName.DEF_BM]);
			this.Properties.AutoUpdate(PropertyName.MDEF, [PropertyName.Lv, PropertyName.Level, PropertyName.MDEF_BM]);

			this.Properties.InvalidateAll();

			this.Properties.SetFloat(PropertyName.HP, this.Properties.GetFloat(PropertyName.MHP));
			this.Properties.SetFloat(PropertyName.SP, this.Properties.GetFloat(PropertyName.MSP));
		}

		/// <summary>
		/// Creates a new calculated float property that uses the given
		/// function.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="calcFuncName"></param>
		private void CreateProperty(string propertyName, string calcFuncName)
		{
			this.Properties.Create(new CFloatProperty(propertyName, () => this.CalculateProperty(calcFuncName)));
		}

		/// <summary>
		/// Calls the calculation function with the given name and returns
		/// the result.
		/// </summary>
		/// <param name="calcFuncName"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if the function doesn't exist.
		/// </exception>
		private float CalculateProperty(string calcFuncName)
		{
			if (!ScriptableFunctions.Companion.TryGet(calcFuncName, out var func))
				throw new ArgumentException($"Scriptable character function '{calcFuncName}' not found.");

			return func(this);
		}

		public void SetCompanionState(bool isActive)
		{
			this.IsActivated = isActive;
			Send.ZC_OBJECT_PROPERTY(this.Owner.Connection, this, PropertyName.IsActivated);
			if (isActive)
			{
				this.Map = this.Owner.Map;
				this.OwnerHandle = this.Owner.Handle;
				this.Position = this.Owner.Position.GetRandomInRange2D(15, new Random());
				this.Components.Add(new MovementComponent(this));
				this.Components.Add(new AiComponent(this, "BasicMonster"));
				this.Components.Get<AiComponent>()?.Script.SetMaster(this.Owner);
				Send.ZC_NORMAL.PetIsInactive(this.Owner.Connection, this);
				this.Map.AddMonster(this);
				//Send.ZC_NORMAL.PetPlayAnimation(this.Owner.Connection, this);
			}
			else
			{
				this.Components.Remove<AiComponent>();
				this.Components.Remove<MovementComponent>();
				this.Position = Position.Zero;
				this.OwnerHandle = 0;
				// Clear Buffs
				Send.ZC_LEAVE(this.Owner, 4);
				this.Map.RemoveMonster(this);
			}
		}

		/// <summary>
		/// Grants exp to companion.
		/// </summary>
		/// <param name="exp"></param>
		/// <param name="monster"></param>
		public void GiveExp(long exp, IMonsterBase monster)
		{
			// Base EXP
			this.Exp += exp;
			this.TotalExp += exp;

			Send.ZC_NORMAL.PetExpUpdate(this.Owner, this);

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
		}

		/// <summary>
		/// Increases companion's level by the given amount.
		/// </summary>
		/// <param name="amount"></param>
		public void LevelUp(int amount = 1)
		{
			if (amount < 1)
				throw new ArgumentException("Amount can't be lower than 1.");

			var newLevel = this.Properties.Modify(PropertyName.Lv, amount);

			this.MaxExp = ZoneServer.Instance.Data.ExpDb.GetNextExp((int)newLevel);
			this.Heal(this.MaxHp, 0);

			Send.ZC_NORMAL.PlayEffect(this, "F_companion_level_up", 3);
		}
	}
}
