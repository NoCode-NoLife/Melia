using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;
using Melia.Channel.Network;
using Melia.Shared.Util;
using Melia.Shared.Const;
using Melia.Channel.World.SkillEffects;

namespace Melia.Channel.World
{
	 
	public class StatsManager
	{
		public Actor owner;

		private object _listLock = new object();
		private Dictionary<int, Buff> buffList;
		private Dictionary<Stat, Dictionary<int, StatModifier>> statMods;

		public float[] baseStats;
		public float[] stats;

		public StatsManager(Actor ownerActor)
		{
			// Set owner
			owner = ownerActor;

			// Initialize vars
			buffList = new Dictionary<int, Buff>();
			stats = new float[(int)Stat.Stat_MAX];
			baseStats = new float[(int)Stat.Stat_MAX];

			this.statMods = new Dictionary<Stat, Dictionary<int, StatModifier>>();
			Dictionary<int, StatModifier> statModListItem;
			for (int i = 0; i < (int)Stat.Stat_MAX; i++)
			{
				statModListItem = new Dictionary<int, StatModifier>();
				statMods.Add((Stat)i, statModListItem);
			}

		}

		public void AddStatMod(int handler, StatModifier modifier)
		{
			statMods[modifier.stat][handler] = modifier;
			this.RecalculateStat(modifier.stat);
		}

		public void RemoveStatMods(int handler)
		{
			foreach (var modItem in statMods)
			{
				if (modItem.Value.ContainsKey(handler))
				{
					modItem.Value.Remove(handler);
					this.RecalculateStat(modItem.Key);
				}
			}
		}	

		public void SetBaseStats(float[] stats)
		{
			baseStats = stats;
			this.InitializeStats();
		}

		public void InitializeStats()
		{
			// Calculate base stats first
			for (Stat i = 0; i < Stat.Stat_MAX; i++)
			{
				if (this.baseStats[(int)i] != 0f)
					RecalculateStatSilent(i);
			}
			// Calculate the "secondary" stats
			for (Stat i = 0; i < Stat.Stat_MAX; i++)
			{
				if (this.stats[(int)i] == 0f)
					RecalculateStatSilent(i);
			}
		}

		// This function could be avoided if found a way to send all modified variables in the same tick, to be sent together.
		public void SendInitialStats()
		{

			List<short> propertiesList = new List<short>();
			for (Stat i = 0; i < Stat.Stat_MAX; i++)
			{
				if (this.stats[(int)i] != 0f)
				{
					propertiesList.Add(this.GetPropertyId(i));
				}
			}

			Send.ZC_OBJECT_PROPERTY((Character)this.owner, propertiesList.ToArray());
		}

		public short GetPropertyId(Stat stat)
		{
			short propertyId;
			switch (stat)
			{
				case Stat.MovSpeed:
					propertyId = ObjectProperty.PC.MSPD;
					break;
				case Stat.Evasion:
					propertyId = ObjectProperty.PC.DR;
					break;
				case Stat.DR_BM:
					propertyId = ObjectProperty.PC.DR_BM;
					break;
				case Stat.RecoveryHP:
					propertyId = ObjectProperty.PC.RHP;
					break;
				case Stat.RecoverySP:
					propertyId = ObjectProperty.PC.RSP;
					break;
				case Stat.STR:
					propertyId = ObjectProperty.PC.STR;
					break;
				case Stat.INT:
					propertyId = ObjectProperty.PC.INT;
					break;
				case Stat.CON:
					propertyId = ObjectProperty.PC.CON;
					break;
				case Stat.SPR:
					propertyId = ObjectProperty.PC.MNA;
					break;
				case Stat.DEX:
					propertyId = ObjectProperty.PC.DEX;
					break;
				default:
					propertyId = 0;
					break;
			}

			return propertyId;
		}

		public float RecalculateStatSilent(Stat stat)
		{
			float newValue;
			//Log.Debug("Recaluclate silent {0}", stat);

			var ownerEntity = (IEntity)this.owner;

			switch (stat)
			{
				case Stat.STR:
					newValue = this.baseStats[(int)stat] * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					break;
				case Stat.INT:
					newValue = this.baseStats[(int)stat] * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					break;
				case Stat.SPR:
					newValue = this.baseStats[(int)stat] * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					break;
				case Stat.CON:
					newValue = this.baseStats[(int)stat] * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					break;
				case Stat.DEX:
					newValue = this.baseStats[(int)stat] * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					break;
				case Stat.MovSpeed:
					newValue = this.baseStats[(int)stat] * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					break;
				case Stat.Evasion:
					newValue = this.baseStats[(int)stat] * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					break;
				case Stat.DR_BM:
					newValue = this.baseStats[(int)stat] * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					break;
				case Stat.RecoveryHP:
					newValue = (this.stats[(int)Stat.CON] + ownerEntity.Level / 2) * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					break;
				case Stat.RecoverySP:
					float clericClassBonus = 0.0f;
					newValue = (this.stats[(int)Stat.SPR] + ownerEntity.Level / 2 + clericClassBonus) * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					break;
				default:
					newValue = 0.0f;
					break;
			}

			this.stats[(int)stat] = newValue;

			return newValue;
		}

		public float RecalculateStat(Stat stat)
		{
			var newValue = this.RecalculateStatSilent(stat);
			short[] properties = new short[1];
			properties[0] = this.GetPropertyId(stat);
			Send.ZC_OBJECT_PROPERTY((Character)owner, properties);
			return newValue;
		}

		public float CalculateMultiplierModifiers(Stat stat)
		{
			float value = 1.0f;

			foreach (var modifier in this.statMods[stat].Values)
			{
				if (modifier.modifierType == StatModifierType.Multiplier)
				{
					value = value * modifier.modifierValue;
				}
			}

			return value;
		}

		public float CalculateAdditiveModifiers(Stat stat)
		{
			float value = 0.0f;

			foreach (var modifier in this.statMods[stat].Values)
			{
				if (modifier.modifierType == StatModifierType.Addition)
				{
					value = value + modifier.modifierValue;
				}
			}

			return value;
		}
	}
}
