using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;
using Melia.Channel.World.SkillEffects;
using Melia.Shared.Const;

namespace Melia.Channel.World
{
	public class Entity : Actor, IEntity
	{
		public int Hp { get; set; }
		public bool IsDead { get; set; }

		private Map _map = Map.Limbo;
		/// <summary>
		/// The map the monster is currently on.
		/// </summary>
		public Map Map { get { return _map; } set { _map = value ?? Map.Limbo; } }

		/// <summary>
		/// Character's id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// The map the character is in.
		/// </summary>
		public int MapId { get; set; }

		/// <summary>
		/// Current experience points.
		/// </summary>
		public int Exp { get; set; }

		/// <summary>
		/// Current maximum experience points.
		/// </summary>
		public int MaxExp { get; set; }

		/// <summary>
		/// Character's head's direction.
		/// </summary>
		public Direction HeadDirection { get; set; }

		/// <summary>
		/// Maximum health points.
		/// </summary>
		public int MaxHp { get; set; }

		/// <summary>
		/// Spell points.
		/// </summary>
		public int Sp { get; set; }

		/// <summary>
		/// Maximum spell points.
		/// </summary>
		public int MaxSp { get; set; }

		/// <summary>
		/// Stamina points.
		/// </summary>
		public int Stamina { get; set; }

		/// <summary>
		/// Maximum stamina points.
		/// </summary>
		public int MaxStamina { get; set; }

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

		public List<SkillEffect> skillEffects { get; set; }

		/// <summary>
		/// Character's level.
		/// </summary>
		public int Level { get; set; }

		public void SetAttackState(bool isAttacking) { }


		public StatsManager statsManager { get; set; }
		public SkillManager skillManager { get; set; }
		public SkillEffectsManager skillEffectsManager { get; set; }

		virtual public float AdjustInfringedDamage(float damage)
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
		virtual public float AdjustReceivedDamage(float damage)
		{
			EventData evData = new EventData();
			evData.entity = this;
			evData.damage = damage;

			ChannelServer.Instance.World.SendEvent(WorldManager.EventTypes.ADJUST_DAMAGE_MODIFIER, evData, this.Handle);
			return damage;
		}

		public void StopSkillEffects(Skill skill)
		{
			this.skillEffectsManager.RemoveEffectsBySkill(skill);
		}

		public Entity()
		{
			statsManager = new StatsManager(this);
			skillManager = new SkillManager(this);
			skillEffectsManager = new SkillEffectsManager(this);
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
		/// Makes entity take damage and kills it if the HP reach 0.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="from"></param>
		public void TakeDamage(int damage, IEntity from)
		{

		}
	}
}
