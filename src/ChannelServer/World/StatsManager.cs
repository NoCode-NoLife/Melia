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
		}

		public float RecalculateStat(Stat stat)
		{
			float newValue;
			short propertyId;

			switch (stat)
			{
				case Stat.MovSpeed:
					newValue = this.baseStats[(int)stat] * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					propertyId = 6893;
					break;
				case Stat.Evasion:
					newValue = this.baseStats[(int)stat] * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					propertyId = 7024;
					break;
				case Stat.DR_BM:
					newValue = this.baseStats[(int)stat] * CalculateMultiplierModifiers(stat) + CalculateAdditiveModifiers(stat);
					propertyId = 7011;
					break;
				default:
					newValue = 0.0f;
					propertyId = 0;
					break;
			}
			if (newValue != this.stats[(int)stat])
			{
				this.stats[(int)stat] = newValue;
				short[] properties = new short[1];
				properties[0] = propertyId;
				Send.ZC_OBJECT_PROPERTY((Character)owner, properties);
			}
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
