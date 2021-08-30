// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class ItemData
	{
		public int Id { get; set; }
		public string ClassName { get; set; }
		public string Name { get; set; }
		public InventoryCategory Category { get; set; }
		public ItemType Type { get; set; }
		public float Weight { get; set; }
		public int MaxStack { get; set; }
		public int Price { get; set; }
		public int SellPrice { get; set; }

		public EquipType EquipType1 { get; set; }
		public EquipType EquipType2 { get; set; }
		public int MinLevel { get; set; }
		public string Script { get; set; }
		public Dictionary<int, int> Properties = new Dictionary<int, int>();
		public ItemGroup Group { get; internal set; }

		public bool HasScript => !string.IsNullOrWhiteSpace(this.Script);
		public bool HasProperties => this.Properties.Count > 0;
	}

	/// <summary>
	/// Item database, indexed by item id.
	/// </summary>
	public class ItemDb : DatabaseJsonIndexed<int, ItemData>
	{
		/// <summary>
		/// Helper Function for Item Group as String to ItemGroup
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public ItemType GetItemType(string type)
		{
			// TODO: Use Enum.Parse, instead of manually mapping strings
			//   to enum valuues.

			switch (type)
			{
				case "Consume": return ItemType.Consume;
				case "Equip": return ItemType.Equip;
				case "Etc": return ItemType.Etc;
				case "Quest": return ItemType.Quest;
				case "Unused": return ItemType.Unused;
				default: return ItemType.Unknown;
			}
		}

		/// <summary>
		/// Helper Function for Item Group as String to ItemGroup
		/// </summary>
		/// <param name="group"></param>
		/// <returns></returns>
		public ItemGroup GetItemGroup(string group)
		{
			// TODO: Use Enum.Parse, instead of manually mapping strings
			//   to enum valuues.

			switch (group)
			{
				case "Premium": return ItemGroup.Premium;
				case "Quest": return ItemGroup.Quest;
				case "Arcane": return ItemGroup.Arcane;
				case "Drug": return ItemGroup.Drug;
				case "Material": return ItemGroup.Material;
				case "Event": return ItemGroup.Event;
				case "Misc": return ItemGroup.Misc;
				case "Ark": return ItemGroup.Ark;
				case "LegendMaterial": return ItemGroup.LegendMaterial;
				case "MagicAmulet": return ItemGroup.MagicAmulet;
				case "SpecialMaterial": return ItemGroup.SpecialMaterial;
				case "Icor": return ItemGroup.Icor;
				case "ExpOrb": return ItemGroup.ExpOrb;
				case "SubExpOrb": return ItemGroup.SubExpOrb;
				case "FishingRod": return ItemGroup.FishingRod;
				case "PasteBait": return ItemGroup.PasteBait;
				case "Unused": return ItemGroup.Unused;
				case "HiddenAbility": return ItemGroup.HiddenAbility;
				case "Entrance_Ticket": return ItemGroup.Entrance_Ticket;
				case "Consume": return ItemGroup.Consume;
				case "Armor": return ItemGroup.Armor;
				case "Helmet": return ItemGroup.Helmet;
				case "Weapon": return ItemGroup.Weapon;
				case "Armband": return ItemGroup.Armband;
				case "SubWeapon": return ItemGroup.SubWeapon;
				case "Seal": return ItemGroup.Seal;
				case "Relic": return ItemGroup.Relic;
				case "Gem": return ItemGroup.Gem;
				default: return ItemGroup.Unknown;
			}
		}

		public int GetProperty(string property)
		{
			// TODO: Use Enum.Parse, instead of manually mapping strings
			//   to enum valuues.

			switch (property)
			{
				case "Desc": return PropertyId.Item.Desc;
				case "Icon": return PropertyId.Item.Icon;
				case "RefreshScp": return PropertyId.Item.RefreshScp;
				case "Name": return PropertyId.Item.Name;
				case "Socket_Equip_1": return PropertyId.Item.Socket_Equip_1;
				case "UseTx": return PropertyId.Item.UseTx;
				case "SkillType": return PropertyId.Item.SkillType;
				case "Socket_2": return PropertyId.Item.Socket_2;
				case "SocketItemExp_4": return PropertyId.Item.SocketItemExp_4;
				case "MagicAmulet_2": return PropertyId.Item.MagicAmulet_2;
				case "BuffValue": return PropertyId.Item.BuffValue;
				case "DEX": return PropertyId.Item.DEX;
				case "RSPTIME": return PropertyId.Item.RSPTIME;
				case "BelongingCount": return PropertyId.Item.BelongingCount;
				case "StringArg": return PropertyId.Item.StringArg;
				case "Journal": return PropertyId.Item.Journal;
				case "FileName": return PropertyId.Item.FileName;
				case "SocketItemExp_0": return PropertyId.Item.SocketItemExp_0;
				case "Material": return PropertyId.Item.Material;
				case "STR": return PropertyId.Item.STR;
				case "Dur": return PropertyId.Item.Dur;
				case "UseLv": return PropertyId.Item.UseLv;
				case "ItemGrade": return PropertyId.Item.ItemGrade;
				case "GroupName": return PropertyId.Item.GroupName;
				case "Socket_0": return PropertyId.Item.Socket_0;
				case "SocketItemExp_2": return PropertyId.Item.SocketItemExp_2;
				case "MagicAmulet_0": return PropertyId.Item.MagicAmulet_0;
				case "Reinforce_2": return PropertyId.Item.Reinforce_2;
				case "BuffCount": return PropertyId.Item.BuffCount;
				case "INT": return PropertyId.Item.INT;
				case "EquipGroup": return PropertyId.Item.EquipGroup;
				case "Script": return PropertyId.Item.Script;
				case "ClientScp": return PropertyId.Item.ClientScp;
				case "Socket_JamLv_2": return PropertyId.Item.Socket_JamLv_2;
				case "Weight": return PropertyId.Item.Weight;
				case "Socket_4": return PropertyId.Item.Socket_4;
				case "MINATK_AC": return PropertyId.Item.MINATK_AC;
				case "PR": return PropertyId.Item.PR;
				case "Scale": return PropertyId.Item.Scale;
				case "CoolDown": return PropertyId.Item.CoolDown;
				case "Socket_Equip_2": return PropertyId.Item.Socket_Equip_2;
				case "SkillLevel": return PropertyId.Item.SkillLevel;
				case "Socket_JamLv_1": return PropertyId.Item.Socket_JamLv_1;
				case "ItemExp": return PropertyId.Item.ItemExp;
				case "Socket_Equip_0": return PropertyId.Item.Socket_Equip_0;
				case "ItemType": return PropertyId.Item.ItemType;
				case "PetSlot": return PropertyId.Item.PetSlot;
				case "IsAwaken": return PropertyId.Item.IsAwaken;
				case "SocketItemExp_1": return PropertyId.Item.SocketItemExp_1;
				case "BuffEndTime": return PropertyId.Item.BuffEndTime;
				case "CON": return PropertyId.Item.CON;
				case "MaxDur": return PropertyId.Item.MaxDur;
				case "ItemStar": return PropertyId.Item.ItemStar;
				case "CategoryType": return PropertyId.Item.CategoryType;
				case "Usable": return PropertyId.Item.Usable;
				case "Price": return PropertyId.Item.Price;
				case "StrikeDEF": return PropertyId.Item.StrikeDEF;
				case "ADD_SMALLSIZE": return PropertyId.Item.ADD_SMALLSIZE;
				case "ADD_VELIAS": return PropertyId.Item.ADD_VELIAS;
				case "UserTrade": return PropertyId.Item.UserTrade;
				case "DEF": return PropertyId.Item.DEF;
				case "ADD_LARGESIZE": return PropertyId.Item.ADD_LARGESIZE;
				case "ADD_FIRE": return PropertyId.Item.ADD_FIRE;
				case "SkillPower": return PropertyId.Item.SkillPower;
				case "ASPD": return PropertyId.Item.ASPD;
				case "SellPrice": return PropertyId.Item.SellPrice;
				case "MAXATK": return PropertyId.Item.MAXATK;
				case "SlashDEF": return PropertyId.Item.SlashDEF;
				case "ADD_WIDLING": return PropertyId.Item.ADD_WIDLING;
				case "SkillRange": return PropertyId.Item.SkillRange;
				case "ShopTrade": return PropertyId.Item.ShopTrade;
				case "MergeClass2": return PropertyId.Item.MergeClass2;
				case "DropStyle": return PropertyId.Item.DropStyle;
				case "ToolTipScp": return PropertyId.Item.ToolTipScp;
				case "RepairPriceRatio": return PropertyId.Item.RepairPriceRatio;
				case "NumberArg2": return PropertyId.Item.NumberArg2;
				case "TooltipImage": return PropertyId.Item.TooltipImage;
				case "Consumable": return PropertyId.Item.Consumable;
				case "PriceRatio": return PropertyId.Item.PriceRatio;
				case "ParticleName": return PropertyId.Item.ParticleName;
				case "ReqToolTip": return PropertyId.Item.ReqToolTip;
				case "MergeTable1": return PropertyId.Item.MergeTable1;
				case "CoolDownGroup": return PropertyId.Item.CoolDownGroup;
				case "DropSound": return PropertyId.Item.DropSound;
				case "MergeTable2": return PropertyId.Item.MergeTable2;
				case "LogoutSave": return PropertyId.Item.LogoutSave;
				case "DropSoundTime": return PropertyId.Item.DropSoundTime;
				case "Destroyable": return PropertyId.Item.Destroyable;
				case "InOutScp": return PropertyId.Item.InOutScp;
				case "MergeTable3": return PropertyId.Item.MergeTable3;
				case "DeadBreakRatio": return PropertyId.Item.DeadBreakRatio;
				case "MergeClass3": return PropertyId.Item.MergeClass3;
				case "PreCheckScp": return PropertyId.Item.PreCheckScp;
				case "MaterialPrice": return PropertyId.Item.MaterialPrice;
				case "UseAnim": return PropertyId.Item.UseAnim;
				case "MaxStack": return PropertyId.Item.MaxStack;
				case "EquipXpGroup": return PropertyId.Item.EquipXpGroup;
				case "ItemCoolDown": return PropertyId.Item.ItemCoolDown;
				case "TooltipValue": return PropertyId.Item.TooltipValue;
				case "EquipSound": return PropertyId.Item.EquipSound;
				case "NumberArg1": return PropertyId.Item.NumberArg1;
				case "MergeClass1": return PropertyId.Item.MergeClass1;
				case "NotExist": return PropertyId.Item.NotExist;
				case "Level": return PropertyId.Item.Level;
				case "ClassType": return PropertyId.Item.ClassType;
				case "Reinforce_Type": return PropertyId.Item.Reinforce_Type;
				case "BlowSoundType": return PropertyId.Item.BlowSoundType;
				case "FDMaxR": return PropertyId.Item.FDMaxR;
				case "ClassType2": return PropertyId.Item.ClassType2;
				case "RemainAmount": return PropertyId.Item.RemainAmount;
				case "AddSkillMaxR": return PropertyId.Item.AddSkillMaxR;
				case "Strike_Range": return PropertyId.Item.Strike_Range;
				case "ItemLv": return PropertyId.Item.ItemLv;
				case "CustomToolTip": return PropertyId.Item.CustomToolTip;
				case "ROp1": return PropertyId.Item.ROp1;
				case "IsPrivate": return PropertyId.Item.IsPrivate;
				case "GemRoastingLv": return PropertyId.Item.GemRoastingLv;
				case "Socket_Equip_4": return PropertyId.Item.Socket_Equip_4;
				case "MSPD": return PropertyId.Item.MSPD;
				case "Hardness": return PropertyId.Item.Hardness;
				case "Socket_3": return PropertyId.Item.Socket_3;
				case "LHandSkill": return PropertyId.Item.LHandSkill;
				case "Socket_1": return PropertyId.Item.Socket_1;
				case "SocketItemExp_3": return PropertyId.Item.SocketItemExp_3;
				case "MagicAmulet_1": return PropertyId.Item.MagicAmulet_1;
				case "BuffUseCount": return PropertyId.Item.BuffUseCount;
				case "MNA": return PropertyId.Item.MNA;
				case "Attribute": return PropertyId.Item.Attribute;
				case "BLK": return PropertyId.Item.BLK;
				case "ADD_EARTH": return PropertyId.Item.ADD_EARTH;
				case "ADD_CLOTH": return PropertyId.Item.ADD_CLOTH;
				case "RES_FIRE": return PropertyId.Item.RES_FIRE;
				case "Slash": return PropertyId.Item.Slash;
				case "SR": return PropertyId.Item.SR;
				case "MATK": return PropertyId.Item.MATK;
				case "ADD_POISON": return PropertyId.Item.ADD_POISON;
				case "UseJob": return PropertyId.Item.UseJob;
				case "CRTHR": return PropertyId.Item.CRTHR;
				case "DR": return PropertyId.Item.DR;
				case "ADD_IRON": return PropertyId.Item.ADD_IRON;
				case "RES_POISON": return PropertyId.Item.RES_POISON;
				case "Strike": return PropertyId.Item.Strike;
				case "WeaponTrailEffect": return PropertyId.Item.WeaponTrailEffect;
				case "ADD_MAXATK": return PropertyId.Item.ADD_MAXATK;
				case "ADD_DR": return PropertyId.Item.ADD_DR;
				case "ADD_HOLY": return PropertyId.Item.ADD_HOLY;
				case "Aries": return PropertyId.Item.Aries;
				case "MountMATK": return PropertyId.Item.MountMATK;
				case "MDEF": return PropertyId.Item.MDEF;
				case "MINATK": return PropertyId.Item.MINATK;
				case "ADD_MDEF": return PropertyId.Item.ADD_MDEF;
				case "RHP": return PropertyId.Item.RHP;
				case "RES_DARK": return PropertyId.Item.RES_DARK;
				case "CRTATK": return PropertyId.Item.CRTATK;
				case "MHP": return PropertyId.Item.MHP;
				case "MaxSocket": return PropertyId.Item.MaxSocket;
				case "ADD_DEF": return PropertyId.Item.ADD_DEF;
				case "AriesDEF": return PropertyId.Item.AriesDEF;
				case "KDPow": return PropertyId.Item.KDPow;
				case "ADD_FORESTER": return PropertyId.Item.ADD_FORESTER;
				case "MSP": return PropertyId.Item.MSP;
				case "MountPATK": return PropertyId.Item.MountPATK;
				case "ADD_MATK": return PropertyId.Item.ADD_MATK;
				case "ADD_LIGHTNING": return PropertyId.Item.ADD_LIGHTNING;
				case "MHR": return PropertyId.Item.MHR;
				case "RES_HOLY": return PropertyId.Item.RES_HOLY;
				case "SDR": return PropertyId.Item.SDR;
				case "ADD_GHOST": return PropertyId.Item.ADD_GHOST;
				case "RES_LIGHTNING": return PropertyId.Item.RES_LIGHTNING;
				case "CRTDR": return PropertyId.Item.CRTDR;
				case "ADD_MINATK": return PropertyId.Item.ADD_MINATK;
				case "ADD_HR": return PropertyId.Item.ADD_HR;
				case "HitCount": return PropertyId.Item.HitCount;
				case "MSTA": return PropertyId.Item.MSTA;
				case "PATK": return PropertyId.Item.PATK;
				case "ADD_ICE": return PropertyId.Item.ADD_ICE;
				case "BlockRate": return PropertyId.Item.BlockRate;
				case "RSP": return PropertyId.Item.RSP;
				case "ADD_KLAIDA": return PropertyId.Item.ADD_KLAIDA;
				case "BLK_BREAK": return PropertyId.Item.BLK_BREAK;
				case "ADD_DARK": return PropertyId.Item.ADD_DARK;
				case "BackHit": return PropertyId.Item.BackHit;
				case "ADD_MIDDLESIZE": return PropertyId.Item.ADD_MIDDLESIZE;
				case "ADD_PARAMUNE": return PropertyId.Item.ADD_PARAMUNE;
				case "SkillAngle": return PropertyId.Item.SkillAngle;
				case "HR": return PropertyId.Item.HR;
				case "RES_EARTH": return PropertyId.Item.RES_EARTH;
				case "ADD_LEATHER": return PropertyId.Item.ADD_LEATHER;
				case "RES_ICE": return PropertyId.Item.RES_ICE;
				case "Revive": return PropertyId.Item.Revive;
				case "BasicTooltipProp": return PropertyId.Item.BasicTooltipProp;
				case "ADD_CHAIN": return PropertyId.Item.ADD_CHAIN;
				case "FDMinR": return PropertyId.Item.FDMinR;
				case "OptDesc": return PropertyId.Item.OptDesc;
				case "AttackType": return PropertyId.Item.AttackType;
				case "RSTA": return PropertyId.Item.RSTA;
				case "MaxRDmg": return PropertyId.Item.MaxRDmg;
				case "HiddenPropValue": return PropertyId.Item.HiddenPropValue;
				case "AttachType": return PropertyId.Item.AttachType;
				case "Luck": return PropertyId.Item.Luck;
				case "MinRDmg": return PropertyId.Item.MinRDmg;
				case "HiddenProp": return PropertyId.Item.HiddenProp;
				case "ModelType": return PropertyId.Item.ModelType;
				case "EqpInOut": return PropertyId.Item.EqpInOut;
				case "ArrowCount": return PropertyId.Item.ArrowCount;
				case "NodeName": return PropertyId.Item.NodeName;
				case "BlkSoundType": return PropertyId.Item.BlkSoundType;
				case "TotalArrowCount": return PropertyId.Item.TotalArrowCount;
				case "UseCount": return PropertyId.Item.UseCount;
				case "DefSoundType": return PropertyId.Item.DefSoundType;
				case "repairPrice": return PropertyId.Item.repairPrice;
				case "MGP": return PropertyId.Item.MGP;
				case "Slash_Range": return PropertyId.Item.Slash_Range;
				case "DamageRange": return PropertyId.Item.DamageRange;
				case "DefaultEqpSlot": return PropertyId.Item.DefaultEqpSlot;
				case "Aries_Range": return PropertyId.Item.Aries_Range;
				case "EqpType": return PropertyId.Item.EqpType;
				case "MaxOption": return PropertyId.Item.MaxOption;
				case "DBLHand": return PropertyId.Item.DBLHand;
				case "MinOption": return PropertyId.Item.MinOption;
				case "UseGender": return PropertyId.Item.UseGender;
				case "OptionGroup": return PropertyId.Item.OptionGroup;
				case "MaxSocket_MA": return PropertyId.Item.MaxSocket_MA;
				case "BaseSocket_MA": return PropertyId.Item.BaseSocket_MA;
				case "BaseSocket": return PropertyId.Item.BaseSocket;
				case "ROp2": return PropertyId.Item.ROp2;
				case "Socket_JamLv_3": return PropertyId.Item.Socket_JamLv_3;
				case "Equiped": return PropertyId.Item.Equiped;
				case "Socket_JamLv_0": return PropertyId.Item.Socket_JamLv_0;
				case "Socket_Equip_3": return PropertyId.Item.Socket_Equip_3;
				case "OpMDur_2": return PropertyId.Item.OpMDur_2;
				case "History_9": return PropertyId.Item.History_9;
				case "Option_0": return PropertyId.Item.Option_0;
				case "AttachNode": return PropertyId.Item.AttachNode;
				case "GemType": return PropertyId.Item.GemType;
				case "OpDur_2": return PropertyId.Item.OpDur_2;
				case "History_8": return PropertyId.Item.History_8;
				case "Socket_JamLv_4": return PropertyId.Item.Socket_JamLv_4;
				case "ModelChange": return PropertyId.Item.ModelChange;
				case "OpMDur_1": return PropertyId.Item.OpMDur_1;
				case "History_7": return PropertyId.Item.History_7;
				case "Socket_Match": return PropertyId.Item.Socket_Match;
				case "MROp2": return PropertyId.Item.MROp2;
				case "BuffSkillType": return PropertyId.Item.BuffSkillType;
				case "NextGemLVExp": return PropertyId.Item.NextGemLVExp;
				case "MROp1": return PropertyId.Item.MROp1;
				case "BuffCaster": return PropertyId.Item.BuffCaster;
				case "OpMDur_4": return PropertyId.Item.OpMDur_4;
				case "LDDDD": return PropertyId.Item.LDDDD;
				case "OpDur_4": return PropertyId.Item.OpDur_4;
				case "VelniasDEF": return PropertyId.Item.VelniasDEF;
				case "OpMDur_3": return PropertyId.Item.OpMDur_3;
				case "TreasureMapNUM1": return PropertyId.Item.TreasureMapNUM1;
				case "OpDur_3": return PropertyId.Item.OpDur_3;
				case "His_Index": return PropertyId.Item.His_Index;
				case "OpDur_1": return PropertyId.Item.OpDur_1;
				case "History_6": return PropertyId.Item.History_6;
				case "OpMDur_0": return PropertyId.Item.OpMDur_0;
				case "History_5": return PropertyId.Item.History_5;
				case "OpDur_0": return PropertyId.Item.OpDur_0;
				case "History_4": return PropertyId.Item.History_4;
				case "Memo": return PropertyId.Item.Memo;
				case "Option_4": return PropertyId.Item.Option_4;
				case "History_3": return PropertyId.Item.History_3;
				case "CustomName": return PropertyId.Item.CustomName;
				case "Option_3": return PropertyId.Item.Option_3;
				case "History_2": return PropertyId.Item.History_2;
				case "Maker": return PropertyId.Item.Maker;
				case "Option_2": return PropertyId.Item.Option_2;
				case "History_1": return PropertyId.Item.History_1;
				case "MAXATK_AC": return PropertyId.Item.MAXATK_AC;
				case "Option_1": return PropertyId.Item.Option_1;
				case "FirstGet": return PropertyId.Item.FirstGet;
				case "UsePetEquipGroup": return PropertyId.Item.UsePetEquipGroup;
				case "EnableEquipParts": return PropertyId.Item.EnableEquipParts;
				case "ADD_MHR": return PropertyId.Item.ADD_MHR;
				case "KeyWord": return PropertyId.Item.KeyWord;
				case "UseAbility": return PropertyId.Item.UseAbility;
				case "KeyWord_2": return PropertyId.Item.KeyWord_2;
				case "KeyWord_3": return PropertyId.Item.KeyWord_3;
				case "AllowDuplicate": return PropertyId.Item.AllowDuplicate;
				case "HatPropName_1": return PropertyId.Item.HatPropName_1;
				case "HatPropValue_1": return PropertyId.Item.HatPropValue_1;
				case "HatPropName_2": return PropertyId.Item.HatPropName_2;
				case "HatPropValue_2": return PropertyId.Item.HatPropValue_2;
				case "HatPropName_3": return PropertyId.Item.HatPropName_3;
				case "HatPropValue_3": return PropertyId.Item.HatPropValue_3;
				case "PVP": return PropertyId.Item.PVP;
				case "PVPMap": return PropertyId.Item.PVPMap;
				case "LifeTime": return PropertyId.Item.LifeTime;
				case "MDefRatio": return PropertyId.Item.MDefRatio;
				case "DefRatio": return PropertyId.Item.DefRatio;
				case "ReinforceRatio": return PropertyId.Item.ReinforceRatio;
				case "HatVisible": return PropertyId.Item.HatVisible;
				case "ItemLifeTimeOver": return PropertyId.Item.ItemLifeTimeOver;
				case "ItemLifeTime": return PropertyId.Item.ItemLifeTime;
				case "Transcend": return PropertyId.Item.Transcend;
				case "MHPRatio": return PropertyId.Item.MHPRatio;
				case "Transcend_MatCount": return PropertyId.Item.Transcend_MatCount;
				case "PackageTradeCount": return PropertyId.Item.PackageTradeCount;
				case "PackageTradeAble": return PropertyId.Item.PackageTradeAble;
				case "Package": return PropertyId.Item.Package;
				case "JobGrade": return PropertyId.Item.JobGrade;
				case "ADD_SOUL": return PropertyId.Item.ADD_SOUL;
				case "RES_SOUL": return PropertyId.Item.RES_SOUL;
				case "EnchanterBuffEndTime": return PropertyId.Item.EnchanterBuffEndTime;
				case "EnchanterBuffValue": return PropertyId.Item.EnchanterBuffValue;
				case "BriquettingIndex": return PropertyId.Item.BriquettingIndex;
				case "CubeDuplicate": return PropertyId.Item.CubeDuplicate;
				case "PackTradeAble": return PropertyId.Item.PackTradeAble;
				case "JobOnly": return PropertyId.Item.JobOnly;
				case "RingGroup": return PropertyId.Item.RingGroup;
				case "Desc_Sub": return PropertyId.Item.Desc_Sub;
				case "NeedAppraisal": return PropertyId.Item.NeedAppraisal;
				case "AppraisalSoket": return PropertyId.Item.AppraisalSoket;
				case "Socket_7": return PropertyId.Item.Socket_7;
				case "Socket_9": return PropertyId.Item.Socket_9;
				case "Socket_Equip_5": return PropertyId.Item.Socket_Equip_5;
				case "Socket_Equip_6": return PropertyId.Item.Socket_Equip_6;
				case "MaxSocket_COUNT": return PropertyId.Item.MaxSocket_COUNT;
				case "Socket_Equip_7": return PropertyId.Item.Socket_Equip_7;
				case "Socket_Equip_8": return PropertyId.Item.Socket_Equip_8;
				case "Socket_JamLv_6": return PropertyId.Item.Socket_JamLv_6;
				case "Socket_JamLv_7": return PropertyId.Item.Socket_JamLv_7;
				case "Socket_JamLv_9": return PropertyId.Item.Socket_JamLv_9;
				case "Socket_Equip_9": return PropertyId.Item.Socket_Equip_9;
				case "Socket_5": return PropertyId.Item.Socket_5;
				case "Socket_8": return PropertyId.Item.Socket_8;
				case "Socket_6": return PropertyId.Item.Socket_6;
				case "Socket_JamLv_5": return PropertyId.Item.Socket_JamLv_5;
				case "Socket_JamLv_8": return PropertyId.Item.Socket_JamLv_8;
				case "MaxPR": return PropertyId.Item.MaxPR;
				case "SocketItemExp_5": return PropertyId.Item.SocketItemExp_5;
				case "SocketItemExp_6": return PropertyId.Item.SocketItemExp_6;
				case "SocketItemExp_7": return PropertyId.Item.SocketItemExp_7;
				case "SocketItemExp_8": return PropertyId.Item.SocketItemExp_8;
				case "SocketItemExp_9": return PropertyId.Item.SocketItemExp_9;
				case "GemLevel": return PropertyId.Item.GemLevel;
				case "CardLevel": return PropertyId.Item.CardLevel;
				case "LifeTime_Limitcheck": return PropertyId.Item.LifeTime_Limitcheck;
				case "Socket_GemBelongingCount_0": return PropertyId.Item.Socket_GemBelongingCount_0;
				case "Socket_GemBelongingCount_1": return PropertyId.Item.Socket_GemBelongingCount_1;
				case "Socket_GemBelongingCount_2": return PropertyId.Item.Socket_GemBelongingCount_2;
				case "Socket_GemBelongingCount_3": return PropertyId.Item.Socket_GemBelongingCount_3;
				case "Socket_GemBelongingCount_4": return PropertyId.Item.Socket_GemBelongingCount_4;
				case "Socket_GemBelongingCount_6": return PropertyId.Item.Socket_GemBelongingCount_6;
				case "Socket_GemBelongingCount_7": return PropertyId.Item.Socket_GemBelongingCount_7;
				case "Socket_GemBelongingCount_8": return PropertyId.Item.Socket_GemBelongingCount_8;
				case "Socket_GemBelongingCount_9": return PropertyId.Item.Socket_GemBelongingCount_9;
				case "Socket_GemBelongingCount_5": return PropertyId.Item.Socket_GemBelongingCount_5;
				case "TeamTrade": return PropertyId.Item.TeamTrade;
				case "MarketTrade": return PropertyId.Item.MarketTrade;
				case "AllowReopen": return PropertyId.Item.AllowReopen;
				case "Transcend_SucessCount": return PropertyId.Item.Transcend_SucessCount;
				case "CardGroupName": return PropertyId.Item.CardGroupName;
				case "NeedRandomOption": return PropertyId.Item.NeedRandomOption;
				case "DecomposeAble": return PropertyId.Item.DecomposeAble;
				case "RandomOptionGroup_2": return PropertyId.Item.RandomOptionGroup_2;
				case "RandomOption_2": return PropertyId.Item.RandomOption_2;
				case "RandomOptionGroup_6": return PropertyId.Item.RandomOptionGroup_6;
				case "RandomOption_6": return PropertyId.Item.RandomOption_6;
				case "RandomOption_4": return PropertyId.Item.RandomOption_4;
				case "RandomOption_5": return PropertyId.Item.RandomOption_5;
				case "RandomOptionGroup_4": return PropertyId.Item.RandomOptionGroup_4;
				case "RandomOptionValue_2": return PropertyId.Item.RandomOptionValue_2;
				case "RandomOptionValue_6": return PropertyId.Item.RandomOptionValue_6;
				case "RandomOptionValue_4": return PropertyId.Item.RandomOptionValue_4;
				case "LootingChance": return PropertyId.Item.LootingChance;
				case "RandomOption_1": return PropertyId.Item.RandomOption_1;
				case "RandomOptionGroup_1": return PropertyId.Item.RandomOptionGroup_1;
				case "RandomOption_3": return PropertyId.Item.RandomOption_3;
				case "RandomOptionGroup_5": return PropertyId.Item.RandomOptionGroup_5;
				case "RandomOptionGroup_3": return PropertyId.Item.RandomOptionGroup_3;
				case "RandomOptionValue_3": return PropertyId.Item.RandomOptionValue_3;
				case "RandomOptionValue_5": return PropertyId.Item.RandomOptionValue_5;
				case "RandomOptionValue_1": return PropertyId.Item.RandomOptionValue_1;
				case "ReopenDiscountRatio": return PropertyId.Item.ReopenDiscountRatio;
				case "Extractable": return PropertyId.Item.Extractable;
				case "LegendGroup": return PropertyId.Item.LegendGroup;
				case "InheritanceItemName": return PropertyId.Item.InheritanceItemName;
				case "LegendPrefix": return PropertyId.Item.LegendPrefix;
				case "ItemExpString": return PropertyId.Item.ItemExpString;
				case "IsAlwaysHatVisible": return PropertyId.Item.IsAlwaysHatVisible;
				case "DisableContents": return PropertyId.Item.DisableContents;
				case "SpineTooltipImage": return PropertyId.Item.SpineTooltipImage;
				case "Category": return PropertyId.Item.Category;
				case "RandomOptionRare": return PropertyId.Item.RandomOptionRare;
				case "RandomOptionRareValue": return PropertyId.Item.RandomOptionRareValue;
				case "RareOption_BlockBreakRate": return PropertyId.Item.RareOption_BlockBreakRate;
				case "RareOption_CriticalHitRate": return PropertyId.Item.RareOption_CriticalHitRate;
				case "RareOption_BossDamageRate": return PropertyId.Item.RareOption_BossDamageRate;
				case "RareOption_MagicReducedRate": return PropertyId.Item.RareOption_MagicReducedRate;
				case "RareOption_CriticalDamage_Rate": return PropertyId.Item.RareOption_CriticalDamage_Rate;
				case "RareOption_SubWeaponDamageRate": return PropertyId.Item.RareOption_SubWeaponDamageRate;
				case "RareOption_PVPDamageRate": return PropertyId.Item.RareOption_PVPDamageRate;
				case "RareOption_HitRate": return PropertyId.Item.RareOption_HitRate;
				case "RareOption_BlockRate": return PropertyId.Item.RareOption_BlockRate;
				case "RareOption_CriticalDodgeRate": return PropertyId.Item.RareOption_CriticalDodgeRate;
				case "RareOption_PVPReducedRate": return PropertyId.Item.RareOption_PVPReducedRate;
				case "RareOption_MainWeaponDamageRate": return PropertyId.Item.RareOption_MainWeaponDamageRate;
				case "RareOption_DodgeRate": return PropertyId.Item.RareOption_DodgeRate;
				case "RareOption_MeleeReducedRate": return PropertyId.Item.RareOption_MeleeReducedRate;
				case "BriquetingAble": return PropertyId.Item.BriquetingAble;
				case "MarketCategory": return PropertyId.Item.MarketCategory;
				case "RareOption_SR": return PropertyId.Item.RareOption_SR;
				case "RareOption_MSPD": return PropertyId.Item.RareOption_MSPD;
				case "TempUseItem": return PropertyId.Item.TempUseItem;
				case "SkillWidthRange": return PropertyId.Item.SkillWidthRange;
				case "DynamicLifeTime": return PropertyId.Item.DynamicLifeTime;
				case "DynamicCalcLifeTimeFunc": return PropertyId.Item.DynamicCalcLifeTimeFunc;
				case "ItemGuildCoolDown": return PropertyId.Item.ItemGuildCoolDown;
				case "GuildCoolDownGroup": return PropertyId.Item.GuildCoolDownGroup;
				case "CRTMATK": return PropertyId.Item.CRTMATK;
				case "Rebuildchangeitem": return PropertyId.Item.Rebuildchangeitem;
				case "InheritanceRandomItemName": return PropertyId.Item.InheritanceRandomItemName;
				case "EnableEquipMap": return PropertyId.Item.EnableEquipMap;
				case "AbilityIdspace": return PropertyId.Item.AbilityIdspace;
				case "Leather_Def": return PropertyId.Item.Leather_Def;
				case "MiddleSize_Def": return PropertyId.Item.MiddleSize_Def;
				case "Cloth_Def": return PropertyId.Item.Cloth_Def;
				case "Add_Damage_Atk": return PropertyId.Item.Add_Damage_Atk;
				case "ResAdd_Damage": return PropertyId.Item.ResAdd_Damage;
				case "Iron_Def": return PropertyId.Item.Iron_Def;
				case "ArkLevel": return PropertyId.Item.ArkLevel;
				case "ArkExp": return PropertyId.Item.ArkExp;
				case "ADD_BOSS_ATK": return PropertyId.Item.ADD_BOSS_ATK;
				case "ChangeBasicPropValue": return PropertyId.Item.ChangeBasicPropValue;
				case "DesigncutColor": return PropertyId.Item.DesigncutColor;
				case "Magic_Ice_Atk": return PropertyId.Item.Magic_Ice_Atk;
				case "Magic_Earth_Atk": return PropertyId.Item.Magic_Earth_Atk;
				case "ExpireDateTime": return PropertyId.Item.ExpireDateTime;
				case "ALLSTAT": return PropertyId.Item.ALLSTAT;
				case "ICOR_TRY_COUNT": return PropertyId.Item.ICOR_TRY_COUNT;
				case "Magic_Soul_Atk": return PropertyId.Item.Magic_Soul_Atk;
				case "StringArg2": return PropertyId.Item.StringArg2;
				case "SkillName": return PropertyId.Item.SkillName;
				case "EventEquip": return PropertyId.Item.EventEquip;
				case "Ev_SetOption": return PropertyId.Item.Ev_SetOption;
				case "ExchangeGroup": return PropertyId.Item.ExchangeGroup;
				case "UPGRADE_GODDESS_TRY_COUNT": return PropertyId.Item.UPGRADE_GODDESS_TRY_COUNT;
				case "AdditionalOption_2": return PropertyId.Item.AdditionalOption_2;
				case "AdditionalOption_1": return PropertyId.Item.AdditionalOption_1;
				case "Magic_Dark_Atk": return PropertyId.Item.Magic_Dark_Atk;
				case "AdditionalOption_3": return PropertyId.Item.AdditionalOption_3;
				case "UPGRADE_TRY_COUNT": return PropertyId.Item.UPGRADE_TRY_COUNT;
				case "AdditionalOption_4": return PropertyId.Item.AdditionalOption_4;
				case "EnableItem": return PropertyId.Item.EnableItem;
				case "DungeonEnterType": return PropertyId.Item.DungeonEnterType;
				case "TeamBelonging": return PropertyId.Item.TeamBelonging;
				case "Relic_EXP": return PropertyId.Item.Relic_EXP;
				case "Relic_LV": return PropertyId.Item.Relic_LV;
				case "Ev_EventType": return PropertyId.Item.Ev_EventType;
				case "PremiumEquip": return PropertyId.Item.PremiumEquip;
				case "Magic_Fire_Atk": return PropertyId.Item.Magic_Fire_Atk;
				case "Magic_Melee_Atk": return PropertyId.Item.Magic_Melee_Atk;
				case "Magic_Lightning_Atk": return PropertyId.Item.Magic_Lightning_Atk;
				case "EnableArkLvup": return PropertyId.Item.EnableArkLvup;
				case "MaxSocket_COUNT0": return PropertyId.Item.MaxSocket_COUNT0;
				case "ExtractProperty": return PropertyId.Item.ExtractProperty;
				case "TOSHeroEquipOption_1": return PropertyId.Item.TOSHeroEquipOption_1;
				case "TOSHeroEquipOption_2": return PropertyId.Item.TOSHeroEquipOption_2;
				case "Saved_PR": return PropertyId.Item.Saved_PR;
				case "Saved_Reinforce": return PropertyId.Item.Saved_Reinforce;
				case "CharacterBelonging": return PropertyId.Item.CharacterBelonging;
				case "Saved_Transcend": return PropertyId.Item.Saved_Transcend;
				case "NumberArg3": return PropertyId.Item.NumberArg3;
				case "AetherGemLevel": return PropertyId.Item.AetherGemLevel;
				case "TOSHeroEquipReinforce": return PropertyId.Item.TOSHeroEquipReinforce;
				case "EquipActionType": return PropertyId.Item.EquipActionType;
				case "EvolvedItemLv": return PropertyId.Item.EvolvedItemLv;
				case "Fail_Goddess_Reinforce_Revision": return PropertyId.Item.Fail_Goddess_Reinforce_Revision;
				default: return -1;
			}
		}

		public ItemData Find(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.Name.ToLower() == name).Value;
		}

		public ItemData FindByClass(string name)
		{
			name = name.ToLower();
			return this.Entries.FirstOrDefault(a => a.Value.ClassName.ToLower() == name).Value;
		}

		public List<ItemData> FindAll(string name)
		{
			name = name.ToLower();
			return this.Entries.FindAll(a => a.Value.Name.ToLower().Contains(name));
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("itemId", "className", "name", "type");

			var info = new ItemData();

			info.Id = entry.ReadInt("itemId");
			info.ClassName = entry.ReadString("className");
			info.Name = entry.ReadString("name");
			info.Type = this.GetItemType(entry.ReadString("type"));
			info.Group = this.GetItemGroup(entry.ReadString("group"));
			info.Category = this.GetItemCategory(info.Group);
			info.Weight = entry.ReadFloat("weight", 0f);
			info.Price = entry.ReadInt("price", 0);
			info.SellPrice = entry.ReadInt("sellPrice", 0);

			if (info.Id == 900011 || info.Id == 900012)
				info.MaxStack = int.MaxValue;
			else
				info.MaxStack = (int)entry.ReadInt("maxStack", 1);

			var equipType1 = entry.ReadString("equipType1", null);
			if (equipType1 != null && equipType1 != "False")
			{
				if (!Enum.TryParse<EquipType>(equipType1, out var type))
					throw new DatabaseErrorException($"Invalid equip type 1 '{equipType1}' for item '{info.Id}'.");
				info.EquipType1 = type;
			}

			var equipType2 = entry.ReadString("equipType2", null);
			if (equipType2 != null)
			{
				if (!Enum.TryParse<EquipType>(equipType2, out var type))
					throw new DatabaseErrorException($"Invalid equip type 2 '{equipType2}' for item '{info.Id}'.");
				info.EquipType2 = type;
			}

			var cooldown = entry.ReadFloat("coolDown", 0);
			info.Properties.Add(PropertyId.Item.CoolDown, (int)cooldown);

			if (entry.ContainsKey("properties"))
			{
				var properties = entry.ReadString("properties");
				foreach (var propString in properties.Replace("{", "").Replace("}", "").Split(','))
				{
					var prop = propString.Split(':');
					info.Properties.Add(this.GetProperty(prop[0].Trim()), int.Parse(prop[1].Trim()));
				}
			}

			info.MinLevel = entry.ReadInt("minLevel", 1);

			this.Entries[info.Id] = info;
		}

		private InventoryCategory GetItemCategory(ItemGroup group)
		{
			// TODO: Use Enum.Parse, instead of manually mapping strings
			//   to enum valuues.

			switch (group)
			{
				case ItemGroup.Premium: return InventoryCategory.Premium;
				case ItemGroup.Weapon: return InventoryCategory.Weapon;
				case ItemGroup.Armor: return InventoryCategory.Armor;
				//case ItemGroup.SubWeapon: return InventoryCategory.SubWeapon;
				//case ItemGroup.Costume: return InventoryCategory.Costume;
				case ItemGroup.Event: return InventoryCategory.Accessory;
				case ItemGroup.Consume: return InventoryCategory.Consumable;
				//case ItemGroup.Gem: return InventoryCategory.Gem;
				//case ItemGroup.RecipeWeapon: return InventoryCategory.RecipeWeapon;
				//case ItemGroup.Card: return InventoryCategory.Card;
				//case ItemGroup.Collection: return InventoryCategory.Collection;
				//case ItemGroup.Book: return InventoryCategory.Book;
				case ItemGroup.Quest: return InventoryCategory.Quest;
				//case ItemGroup.PetWeapon: return InventoryCategory.PetWeapon;
				//case "FishingRod": return InventoryCategory.PetArmor;
				case ItemGroup.Unused: return InventoryCategory.Money;
				case ItemGroup.Material: return InventoryCategory.Material;
				//case ItemGroup.Cube: return InventoryCategory.Cube;
				//case ItemGroup.RecipeArmor: return InventoryCategory.RecipeArmor;
				//case "Consume": return InventoryCategory.RecipeAccessory;
				//case "Armor": return InventoryCategory.RecipePremium;
				//case "Helmet": return InventoryCategory.RecipeOther;
				case ItemGroup.MagicAmulet: return InventoryCategory.Accessory;
				//case ItemGroup.Armband: return InventoryCategory.Necklace;
				default: return InventoryCategory.Premium;
			}
		}
	}

	public enum EquipType
	{
		None,
		Sword,
		THSword,
		Dagger,
		Staff,
		THStaff,
		Bow,
		THBow,
		Mace,
		THMace,
		Spear,
		THSpear,
		Rapier,
		Musket,
		Gun,
		Pistol,
		Cannon,
		Shield,
		Charm,
		Outer,
		Pants,
		Gloves,
		Boots,
		Shirt,
		Armband,
		Helmet,
		Hat,
		Premium,
		Neck,
		Ring,
		Hair,
		Lens,
		Wing,
		Artefact,
		SpecialCostume,
		EffectCostume,
		Seal,
		Trinket,
		Relic,
		Skin,
	}
}
