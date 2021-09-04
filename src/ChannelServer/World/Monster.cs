// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Channel.Network;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.World
{
	public class Monster : IEntity, IEntityEvent
	{
		/// <summary>
		/// Index in world collection?
		/// </summary>
		public int Handle { get; private set; }

		private Map _map = Map.Limbo;
		/// <summary>
		/// The map the monster is currently on.
		/// </summary>
		public Map Map { get { return _map; } set { _map = value ?? Map.Limbo; } }

		/// <summary>
		/// Monster ID in database.
		/// </summary>
		public int Id { get; set; }

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
		/// Level.
		/// </summary>
		public int Level { get; set; }

		/// <summary>
		/// Monster's position.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// Monster's direction.
		/// </summary>
		public Direction Direction { get; set; }

		/// <summary>
		/// AoE Defense Ratio
		/// </summary>
		public int SDR { get; set; }

		/// <summary>
		/// Health points.
		/// </summary>
		public int Hp
		{
			get { return _hp; }
			private set { _hp = Math2.Clamp(0, this.MaxHp, value); }
		}
		private int _hp;

		/// <summary>
		/// Maximum health points.
		/// </summary>
		public int MaxHp { get; private set; }

		/// <summary>
		/// Physical defense.
		/// </summary>
		public int Defense
		{
			get { return _defense; }
			private set { _defense = Math.Max(0, value); }
		}
		private int _defense;

		public event EventHandler<EntityEventArgs> Died;

		/// <summary>
		/// At this time the monster will be removed from the map.
		/// </summary>
		public DateTime DisappearTime { get; set; }

		/// <summary>
		/// Data entry for this monster.
		/// </summary>
		public MonsterData Data { get; private set; }

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
		}

		/// <summary>
		/// Loads data from data files.
		/// </summary>
		private void LoadData()
		{
			if (this.Id == 0)
				throw new InvalidOperationException("Id wasn't set before calling LoadData.");

			this.Data = ChannelServer.Instance.Data.MonsterDb.Find(this.Id);
			if (this.Data == null)
				throw new NullReferenceException("No data found for '" + this.Id + "'.");

			this.Hp = this.MaxHp = this.Data.Hp;
			this.Defense = this.Data.PhysicalDefense;
		}

		/// <summary>
		/// Makes monster take damage and kills it if the HP reach 0.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="from"></param>
		/// <returns>If damage is fatal</returns>
		public bool TakeDamage(int damage, Character from, Skill skill = null)
		{
			this.Hp -= damage;

			// In earlier clients ZC_HIT_INFO was used, newer ones seem to
			// use SKILL, and this doesn't create a double hit effect like
			// the other.
			if (skill == null)
			{
				Send.ZC_SKILL_HIT_INFO(from, this, null, damage);
			}
			else
			{
				switch (skill.Data.SplashType)
				{
					case SplashType.Circle:
						Send.ZC_SKILL_RANGE_CIRCLE(from, this, skill, this.Position);
						break;
				}
				switch (skill.Data.UseType)
				{
					case SkillUseType.FORCE:
						Send.ZC_SKILL_FORCE_TARGET(from, this, skill, damage);
						break;
					case SkillUseType.MELEE_GROUND:
						if (skill.Data.OverHeat != 0)
							Send.ZC_OVERHEAT_CHANGED(from, skill);
						if (skill.Data.CoolDown != 0)
							Send.ZC_COOLDOWN_CHANGED(from, skill);
						Send.ZC_SKILL_READY(from, skill, from.Position, this.Position);
						Send.ZC_NORMAL_Skill_4E(from, skill.Id, 1);
						Send.ZC_NORMAL_Skill(from, skill, this.Position, from.Direction, true);
						Send.ZC_NORMAL_Unknown_06(from, this.Position);
						Send.ZC_SYNC_START(from, 1234, 1);
						Send.ZC_SYNC_END(from, 1234, 0);
						Send.ZC_SYNC_EXEC_BY_SKILL_TIME(from, 1234, skill.Data.HitDelay);
						Send.ZC_SKILL_MELEE_GROUND(from, skill, this.Position.X, this.Position.Y, this.Position.Z, this, damage);
						for (var i = 1; i < 10; i++)
						{
							Send.ZC_SYNC_START(from, 1234, 1);
							Send.ZC_SYNC_END(from, 1234, 0);
							Send.ZC_SYNC_EXEC_BY_SKILL_TIME(from, 1234, skill.Data.HitDelay);
						}
						Send.ZC_SYNC_EXEC(from, 1234);
						// Skill Cast Duration? Cancel's Visible Animation Otherwise you stay in casting animation
						Send.ZC_SKILL_DELAY(from);
						break;
				}
			}

			if (this.Hp == 0)
            {
				this.Kill(from);
				return true;
			}
			return false;
		}

		/// <summary>
		/// Kills monster.
		/// </summary>
		/// <param name="killer"></param>
		public void Kill(Character killer)
		{
			var expRate = ChannelServer.Instance.Conf.World.ExpRate / 100;
			var classExpRate = ChannelServer.Instance.Conf.World.ClassExpRate / 100;

			var exp = 0;
			var classExp = 0;

			if (this.Data.Exp > 0)
				exp = (int)Math.Max(1, this.Data.Exp * expRate);
			if (this.Data.ClassExp > 0)
				classExp = (int)Math.Max(1, this.Data.ClassExp * classExpRate);

			this.DisappearTime = DateTime.Now.AddSeconds(2);

			if (this.Data.Drops != null)
			{
				var rnd = RandomProvider.Get();

				foreach (var dropItemData in this.Data.Drops)
				{
					if (rnd.NextDouble() > (dropItemData.DropChance / 100f))
						continue;

					if (!ChannelServer.Instance.Data.ItemDb.TryFind(dropItemData.ItemId, out var itemData))
					{
						Log.Warning("Monster.Kill: Drop item '{0}' not found.", dropItemData.ItemId);
						continue;
					}

					var dropItem = new Item(itemData.Id);
					if (dropItemData.MinAmount > 1)
						dropItem.Amount = rnd.Next(dropItemData.MinAmount, dropItemData.MaxAmount + 1);

					killer.Inventory.Add(dropItem, InventoryAddType.PickUp);
					//Send.ZC_ITEM_ADD(killer, new Item(drops.ItemId), 0, 1, InventoryAddType.PickUp);
				}
			}

			killer.GiveExp(exp, classExp, this);
			this.Died?.Invoke(this, new EntityEventArgs(this.Handle));

			Send.ZC_DEAD(this);
		}
	}
}
