using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Const;

namespace Melia.Shared.World.ObjectProperties
{
	public class Properties
	{
		private readonly Dictionary<int, IProperty> _properties = new Dictionary<int, IProperty>();

		/// <summary>
		/// Returns the byte size of all properties, as they would take
		/// in a packet.
		/// </summary>
		/// XXX: Could be cached if performance is a problem.
		public int Size { get { lock (_properties) return _properties.Values.Sum(a => a.Size); } }

		/// <summary>
		/// Returns the property with the given property id,
		/// or null if it doesn't exist.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <returns></returns>
		public IProperty Get(int propertyId)
		{
			lock (_properties)
			{
				if (!_properties.TryGetValue(propertyId, out var property))
					return null;

				return property;
			}
		}

		/// <summary>
		/// Returns list of all set properties.
		/// </summary>
		/// <returns></returns>
		public IProperty[] GetAll()
		{
			lock (_properties)
				return _properties.Values.ToArray();
		}

		/// <summary>
		/// Returns list of all set properties.
		/// </summary>
		/// <returns></returns>
		public IProperty[] GetAll(params int[] propertyIds)
		{
			lock (_properties)
				return _properties.Values.Where(a => propertyIds.Contains(a.Id)).ToArray();
		}

		/// <summary>
		/// Sets the given propery's value.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="value"></param>
		public void Set(int propertyId, float value)
		{
			if (GetPropertyType(propertyId) != PropertyType.Float)
				throw new ArgumentException($"Property '{propertyId}' is not supposed to be a float, or is missing from the property type switch.");

			lock (_properties)
			{
				if (!_properties.TryGetValue(propertyId, out var property))
					_properties[propertyId] = new FloatProperty(propertyId, value);
				else
					(property as FloatProperty).Value = value;
			}
		}

		/// <summary>
		/// Sets the given propery's value.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="value"></param>
		public void Set(int propertyId, string value)
		{
			if (GetPropertyType(propertyId) != PropertyType.String)
				throw new ArgumentException($"Property '{propertyId}' is not supposed to be a string, or is missing from the property type switch.");

			lock (_properties)
			{
				if (!_properties.TryGetValue(propertyId, out var property))
					_properties[propertyId] = new StringProperty(propertyId, value);
				else
					(property as StringProperty).Value = value;
			}
		}

		/// <summary>
		/// Adds the given property
		/// </summary>
		/// <param name="propertyId"></param>
		/// <param name="value"></param>
		public void Add(IProperty property)
		{
			if (!Enum.IsDefined(typeof(PropertyType), property.Type))
				throw new ArgumentException($"Invalid property type '{property.Type}'.");

			lock (_properties)
				_properties[property.Id] = property;
		}

		/// <summary>
		/// Removes given property, returns false if the property didn't
		/// exist.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <returns></returns>
		public bool Remove(int propertyId)
		{
			lock (_properties)
				return _properties.Remove(propertyId);
		}

		/// <summary>
		/// Returns the given property's type.
		/// </summary>
		/// <param name="propertyId"></param>
		/// <returns></returns>
		public static PropertyType GetPropertyType(int propertyId)
		{
			// This is a terrible way to handle this, but it's the only
			// one we got. Extend this switch case as we find new string
			// values, which IMC apparently use for anything that's not
			// fit to be a float, like coordinates or precise, large
			// numbers.

			switch (propertyId)
			{
				case PropertyId.Party.Note:
				case PropertyId.Party.ExpGainType:
				case PropertyId.Party.CreateTime:
				case PropertyId.Party.P_PARTY_Q_030_TicketLifeTime:
				case PropertyId.SessionObject.QSTARTZONETYPE:
				case PropertyId.SessionObject.DROPITEM_COLLECTINGQUEST_RR:
				case PropertyId.PCEtc.LastUIOpenPos:
				case PropertyId.PCEtc.Kill_boss_Velmosquy:
				case PropertyId.Account.Medal_Get_Date:
				case PropertyId.PC.JobName:
				case PropertyId.PC.AbilityPoint:
				case PropertyId.Item.BuffEndTime:
				case PropertyId.Item.Destroyable:
				case PropertyId.Item.HiddenProp:
				case PropertyId.Item.BuffCaster:
				case PropertyId.Item.Memo:
				case PropertyId.Item.CustomName:
				case PropertyId.Item.Maker:
				case PropertyId.Monster.AdoptTime:
				case PropertyId.PCEtc.StartHairName:
				case PropertyId.SessionObject.DROPITEM_REQUEST1_RR:
				case PropertyId.SessionObject.LastGenPosServer:
				case PropertyId.SessionObject.DROPITEM_REQUEST1_TRL:
				case PropertyId.Item.HatPropName_1:
				case PropertyId.Item.HatPropName_2:
				case PropertyId.Item.HatPropName_3:
				case PropertyId.Item.ItemLifeTime:
				case PropertyId.Account.PlayTimeEventPlayMin:
				case PropertyId.Account.DAYCHECK_EVENT_LAST_DATE:
				case PropertyId.Account.DAYCHECK_EVENT_REWARD_DATE:
				case PropertyId.PC.LastExp:
				case PropertyId.Item.EnchanterBuffEndTime:
				case PropertyId.Item.EnchanterBuffValue:
				case PropertyId.PCEtc.CompanionAutoAtk:
				case PropertyId.Account.LimitPaymentStateBySteam:
				case PropertyId.Item.RandomOptionGroup_2:
				case PropertyId.Item.RandomOption_2:
				case PropertyId.Item.RandomOptionGroup_6:
				case PropertyId.Item.RandomOption_6:
				case PropertyId.Item.RandomOption_4:
				case PropertyId.Item.RandomOption_5:
				case PropertyId.Item.RandomOptionGroup_4:
				case PropertyId.Item.RandomOptionValue_6:
				case PropertyId.Item.LootingChance:
				case PropertyId.Item.RandomOption_1:
				case PropertyId.Item.RandomOptionGroup_1:
				case PropertyId.Item.RandomOption_3:
				case PropertyId.Item.RandomOptionGroup_5:
				case PropertyId.Item.RandomOptionGroup_3:
				case PropertyId.Account.EVENT_MYMON01:
				case PropertyId.Account.EVENT_MYMON02:
				case PropertyId.Account.EV171114_STEAM_NRU_DAY_CHECK:
				case PropertyId.Account.JUNK_BUY_COUNT_RESET_DAY:
				case PropertyId.Account.EV180206_VALENTINE_MAP:
				case PropertyId.Item.InheritanceItemName:
				case PropertyId.Item.LegendPrefix:
				case PropertyId.Account.EVENT_BEAUTY_BUY_CHECK:
				case PropertyId.Item.RandomOptionRare:
				case PropertyId.PCEtc.RepresentationClassID:
				case PropertyId.SessionObject.CHARACTER_ATTENDANCE_CHECK:
				case PropertyId.Account.EVENT_1811_KUPOLE_ZONEENTER:
				case PropertyId.Account.EVENT_1811_KUPOLE_PLAYTIME_DATE:
				case PropertyId.Account.EVENT_1811_DAYCHECK_DATE:
				case PropertyId.Account.EVENT1902_FISHING_YOHA_ITEM_2:
				case PropertyId.Account.EVENT1902_FISHING_YOHA_ITEM_1:
				case PropertyId.Item.InheritanceRandomItemName:
				case PropertyId.PCEtc.SkintoneName:
				case PropertyId.Account.EVENT_RESET_DATE:
				case PropertyId.Account.EVENT_1910_HALLOWEEN_DATE:
				case PropertyId.Account.PersonalHousing_HasPlace_7000:
				case PropertyId.Account.EVENT1912_4TH_BUFF_1:
				case PropertyId.Account.EVENT1912_4TH_BUFF_2:
				case PropertyId.Account.EVENT1912_XMAS_WEEKEND_BONUS:
				case PropertyId.Account.CTT_TempProperty_AC_Str_1:
				case PropertyId.Account.CTT_TempProperty_AC_Str_2:
				case PropertyId.Account.CTT_TempProperty_AC_Str_3:
				case PropertyId.Account.STEAM190716_GACHA_HAIRACC_DATE:
				case PropertyId.Account.ASSISTORQUEST_01REWARD_CLASSNAME:
				case PropertyId.Account.MISC_PVP_MINE2:
				case PropertyId.Account.EVENT_YOUR_MASTER_TOTAL_VOTE_LIST:
				case PropertyId.Account.EVENT_YOUR_MASTER_VOTE_LIST:
				case PropertyId.Account.REPUTATION_QUEST_LIST:
				case PropertyId.Item.AdditionalOption_3:
				case PropertyId.Account.EVENT_LUCKYBREAK_REINFORCE_TIME:
				case PropertyId.Account.HOUSINGCRAFT_END_TIME:
				case PropertyId.Account.PVP_MINE_MISC_BOOST_END_DATETIME:
				case PropertyId.Account.EV170427_DAYCHECK_TYPE1_DATE:
				case PropertyId.Account.GabijaCertificate:
				case PropertyId.PCEtc.UnknownSantuary_CurCity:
				case PropertyId.PCEtc.RandomOptionGroupPreset_1_GLOVES:
				case PropertyId.PCEtc.RandomOptionValuePreset_1_SHIRT:
				case PropertyId.PCEtc.RandomOptionGroupPreset_1_LH:
				case PropertyId.PCEtc.RandomOptionValuePreset_1_BOOTS:
				case PropertyId.PCEtc.RandomOptionGroupPreset_1_BOOTS:
				case PropertyId.PCEtc.RandomOptionValuePreset_1_GLOVES:
				case PropertyId.PCEtc.RandomOptionPreset_1_PANTS:
				case PropertyId.PCEtc.RandomOptionPreset_1_BOOTS:
				case PropertyId.PCEtc.RandomOptionPreset_1_LH:
				case PropertyId.PCEtc.RandomOptionGroupPreset_1_PANTS:
				case PropertyId.PCEtc.RandomOptionPreset_1_GLOVES:
				case PropertyId.PCEtc.RandomOptionGroupPreset_1_RH:
				case PropertyId.PCEtc.RandomOptionGroupPreset_1_SHIRT:
				case PropertyId.PCEtc.RandomOptionValuePreset_1_RH:
				case PropertyId.PCEtc.RandomOptionPreset_1_RH:
				case PropertyId.PCEtc.RandomOptionPreset_1_SHIRT:
				case PropertyId.PCEtc.RandomOptionValuePreset_1_PANTS:
				case PropertyId.PCEtc.RandomOptionValuePreset_1_LH:
				case PropertyId.PCEtc.PrevEquipItem_GLOVES:
				case PropertyId.PCEtc.PrevEquipItem_HAT_L:
				case PropertyId.PCEtc.PrevEquipItem_RH:
				case PropertyId.PCEtc.PrevEquipItem_PANTS:
				case PropertyId.PCEtc.PrevEquipItem_RING2:
				case PropertyId.PCEtc.PrevEquipItem_RH_SUB:
				case PropertyId.PCEtc.PrevEquipItem_HAT_T:
				case PropertyId.PCEtc.PrevEquipItem_LH_SUB:
				case PropertyId.PCEtc.PrevEquipItem_RING1:
				case PropertyId.PCEtc.PrevEquipItem_BOOTS:
				case PropertyId.PCEtc.PrevEquipItem_RELIC:
				case PropertyId.PCEtc.PrevEquipItem_HAT:
				case PropertyId.PCEtc.PrevEquipItem_LH:
				case PropertyId.PCEtc.PrevEquipItem_NECK:
				case PropertyId.PCEtc.PrevEquipItem_SEAL:
				case PropertyId.PCEtc.PrevEquipItem_SHIRT:
				case PropertyId.PCEtc.PrevEquipItem_ARK:
					return PropertyType.String;
				default:
					return PropertyType.Float;
			}
		}
	}
}
