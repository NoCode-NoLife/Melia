----- Orsha Bulletin Board -----
addnpc(40070, "QUEST_20151224_003161", "c_orsha", -1077.49, 500.61, 332.74, -17, "QUEST_20151224_003161_Call")
function QUEST_20151224_003161_Call()
end
-----

----- [Blacksmith]{nl}   Ilanai -----
addnpc(20066, "ETC_20151224_019890", "c_orsha", -133.44, 175.98, -285.69, 28, "ETC_20151224_019890_Call")
function ETC_20151224_019890_Call()
----- Enter -----
----- Dialog -----
----- npcselectdialog.ies | ClassName: ORSHA_BLACKSMITH -----
----- QuestIDs: PILGRIM_49_SQ_013PILGRIM_49_SQ_017 | JOB_2_DIEVDIRBYS3_1 | JOB_2_DIEVDIRBYS3_2 | JOB_2_DIEVDIRBYS3_3 |  -----
msg("TUTO_REPAIR_NPC")
msg("ORSHA_BLACKSMITH_basic01")
msg("ORSHA_BLACKSMITH_basic02")
end
-----

----- [Equipment Merchant]{nl}      Jura -----
addnpc(20056, "ETC_20151224_019891", "c_orsha", 21, 176, 154, 78.07, "ETC_20151224_019891_Call")
function ETC_20151224_019891_Call()
----- Enter -----
----- npcselectdialog.ies | ClassName: ADDHELP_NPCSHOP -----
----- Dialog -----
----- npcselectdialog.ies | ClassName: ORSHA_EQUIPMENT_DEALER -----
----- QuestIDs: PILGRIM_49_SQ_017 -----
msg("ORSHA_EQUIPMENT_DEALER_basic01")
msg("ORSHA_EQUIPMENT_DEALER_basic02")
	local selection,i = nselect("ORSHA_EQUIPMENT_DEALER_basic01", "weapon:@dicID_^*$ETC_20150317_004443$*^", "armor:@dicID_^*$ETC_20150317_004444$*^", "!@#$Auto_JongLyo#@!")

	if selection == "weapon" then
		openshop("Klapeda_Weapon")
	elseif selection == "armor" then
		openshop("Klapeda_Armor")
	end
end
end
-----

----- Orsha Resident -----
addnpc(20063, "QUEST_20151224_003163", "c_orsha", 384.97, 175.85, 231.72, -105, "QUEST_20151224_003163_Call")
function QUEST_20151224_003163_Call()
end
-----

-----   [Lord of Orsha]{nl}    Inesa Hamondale -----
addnpc(20065, "ETC_20151224_019892", "c_orsha", 86.99, 176.27, 713.25, -35, "ETC_20151224_019892_Call")
function ETC_20151224_019892_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: C_ORSHA_HAMONDAIL -----
----- QuestIDs: SIAU16_MQ_07ORSHA_MQ1_01 | ORSHA_MQ1_02 | ORSHA_MQ1_04 | ORSHA_MQ2_01 | ORSHA_MQ2_02 | PRISON623_MQ_07 | ORSHA_MQ3_01 |  -----
msg("C_ORSHA_HAMONDAIL_basic_01")
msg("C_ORSHA_HAMONDAIL_after_01")
end
-----

----- Lord's Guard -----
addnpc(20060, "QUEST_20151102_002969", "c_orsha", 140.98, 176.28, 712.85, -65, "QUEST_20151102_002969_Call")
function QUEST_20151102_002969_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: C_ORSHA_SOLDIER_02 -----
msg("C_ORSHA_SOLDIER_02_basic_01")
end
-----

----- [Orsha Bishop]{nl}        Urbonas -----
addnpc(154057, "ETC_20151224_019893", "c_orsha", 895.18, 176.37, 702.91, -45, "ETC_20151224_019893_Call")
function ETC_20151224_019893_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: C_ORSHA_URBONAS -----
----- QuestIDs: ORSHA_MQ3_01 -----
msg("C_ORSHA_URBONAS_basic_01")
msg("C_ORSHA_URBONAS_basic_02")
end
-----

----- [Item Merchant]{nl}        Alf -----
addnpc(20055, "ETC_20151224_019894", "c_orsha", 231, 175, 166, 75, "ETC_20151224_019894_Call")
function ETC_20151224_019894_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: ORSHA_TOOL_NPC -----
----- QuestIDs: ORSHA_MQ1_02ORSHA_MQ1_03 | ORSHA_MQ2_02 |  -----
msg("ORSHA_TOOL_NPC_basic01")
msg("ORSHA_TOOL_NPC_basic02")
openshop("Orsha_Misc")
end
-----

----- [Accessory Merchant]{nl}        Jurus -----
addnpc(20057, "ETC_20151224_019895", "c_orsha", 462.1917, 175.9214, -29.93526, -56, "ETC_20151224_019895_Call")
function ETC_20151224_019895_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: ORSHA_ACCESSARY_NPC -----
----- QuestIDs: ORSHA_MQ1_03KATYN_12_SQ_01 |  -----
msg("ORSHA_ACCESSARY_NPC_basic01")
msg("ORSHA_ACCESSARY_NPC_basic02")
openshop("Klapeda_Accessory")
end
-----

----- [Peltasta Submaster]{nl}      Nirin Dameoff -----
addnpc(155063, "ETC_20151022_016441", "c_orsha", -887.55, 500.6, -85.23, 55, "ETC_20151022_016441_Call")
function ETC_20151022_016441_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_PELTASTA_NPC -----
----- QuestIDs: JOB_2_PELTASTA2JOB_2_PELTASTA3 | JOB_2_PELTASTA4 |  -----
msg("JOB_2_PELTASTA_basic01")
msg("JOB_2_PELTASTA_basic02")
end
-----

----- [Hoplite Master]{nl}        Aidas Valor -----
addnpc(147325, "ETC_20151224_019896", "c_orsha", -1070.18, 500.61, 229.96, 43, "ETC_20151224_019896_Call")
function ETC_20151224_019896_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_HOPLITE_NPC -----
----- QuestIDs: JOB_2_HOPLITE3JOB_2_HOPLITE4 | JOB_2_HOPLITE5 |  -----
msg("JOB_2_HOPLITE_basic01")
msg("JOB_2_HOPLITE_basic02")
end
-----

----- [Cleric Submaster]{nl}     Tamara Easton -----
addnpc(155083, "ETC_20151022_016442", "c_orsha", -269.96, 175.98, -378.04, 35, "ETC_20151022_016442_Call")
function ETC_20151022_016442_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_CLERIC_NPC -----
----- QuestIDs: JOB_2_CLERIC2JOB_2_CLERIC3 | TUTO_2_CLERIC_TECH | BRACKEN_63_1_SQ040 | BRACKEN_63_1_SQ050 |  -----
msg("JOB_2_CLERIC_basic01")
msg("JOB_2_CLERIC_basic02")
end
-----

----- [Krivis Submaster]{nl}     Mellinda Dicherin -----
addnpc(155084, "ETC_20151022_016443", "c_orsha", -612.21, 368.42, 608.86, 29, "ETC_20151022_016443_Call")
function ETC_20151022_016443_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_KRIVIS_NPC -----
----- QuestIDs: JOB_2_KRIVIS2JOB_2_KRIVIS3 | JOB_2_KRIVIS4 |  -----
msg("JOB_2_KRIVIS_basic01")
msg("JOB_2_KRIVIS_basic02")
end
-----

----- [Priest Submaster]{nl}              Boira -----
addnpc(155085, "ETC_20151022_016444", "c_orsha", 723.44, 176.38, 642.36, -30, "ETC_20151022_016444_Call")
function ETC_20151022_016444_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_PRIEST_NPC -----
----- QuestIDs: JOB_2_PRIEST2JOB_2_PRIEST3 | JOB_2_PRIEST4 |  -----
msg("JOB_2_PRIEST_basic01")
msg("JOB_2_PRIEST_basic02")
end
-----

----- [Bokor Submaster]{nl}      Bobo Icelin -----
addnpc(155086, "ETC_20151022_016445", "c_orsha", 462.4, 176.4, 608.87, -45, "ETC_20151022_016445_Call")
function ETC_20151022_016445_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_BOKOR_NPC -----
----- QuestIDs: JOB_2_BOKOR4JOB_2_BOKOR5 | JOB_2_BOKOR3 |  -----
msg("JOB_2_BOKOR_basic01")
msg("JOB_2_BOKOR_basic02")
end
-----

----- [Cataphract Master]{nl}    Memet Culag -----
addnpc(147327, "ETC_20150317_009423", "c_orsha", 934.65, 73.98, 146.95, 26, "ETC_20150317_009423_Call")
function ETC_20150317_009423_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_CATAPHRACT_NPC -----
----- QuestIDs: JOB_2_CATAPHRACT4JOB_2_CATAPHRACT5 | JOB_2_CATAPHRACT6 |  -----
msg("JOB_2_CATAPHRACT_basic01")
msg("JOB_2_CATAPHRACT_basic02")
end
-----

----- [Paladin Submaster]{nl}        Silvia Naimon -----
addnpc(155088, "ETC_20151224_019897", "c_orsha", 942.27, 73.98, 475.77, 50, "ETC_20151224_019897_Call")
function ETC_20151224_019897_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_PALADIN_NPC -----
----- QuestIDs: JOB_2_PALADIN4JOB_2_PALADIN5 | JOB_2_PALADIN6 |  -----
msg("JOB_2_PALADIN_basic01")
msg("JOB_2_PALADIN_basic02")
end
-----

----- Priest Pranas -----
addnpc(155044, "ETC_20151001_015227", "c_orsha", 915.74, 176.36, 708.51, -24, "ETC_20151001_015227_Call")
function ETC_20151001_015227_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: C_ORSHA_PRANAS -----
----- QuestIDs: SIAU11RE_MQ_06ORSHA_MQ2_01 | ORSHA_MQ2_03 |  -----
msg("ORSHA_MQ2_01_02")
end
-----

----- Lord's Guard -----
addnpc(20059, "QUEST_20151102_002969", "c_orsha", 40.71, 176.27, 713.98, -31, "QUEST_20151102_002969_Call")
function QUEST_20151102_002969_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: C_ORSHA_SOLDIER_01 -----
msg("C_ORSHA_SOLDIER_01_basic_01")
end
-----

----- [Swordsman Submaster]{nl}              Codill -----
addnpc(155062, "ETC_20151022_016440", "c_orsha", 236.57, 176.41, 648.6, -44, "ETC_20151022_016440_Call")
function ETC_20151022_016440_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_SWORDMAN_NPC -----
----- QuestIDs: JOB_2_SWORDMAN2JOB_2_SWORDMAN3 | TUTO_2_SWORDMAN_TECH |  -----
msg("JOB_2_SWORDMAN_basic02")
msg("JOB_2_SWORDMAN_basic01")
end
-----

----- Flameholder -----
addnpc(47242, "ETC_20151022_016448", "c_orsha", -603.11, 368.12, 641.37, 33, "ETC_20151022_016448_Call")
function ETC_20151022_016448_Call()
end
-----

----- Statue of Goddess Ausrine -----
addnpc(154063, "ETC_20150317_007031", "c_orsha", 103.14, 176.14, 322.95, -91, "ETC_20150317_007031_Call")
function ETC_20150317_007031_Call()
----- Enter -----
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- QuestIDs: JOB_KRIVI4_3 -----
----- Dialog -----
----- npcselectdialog.ies | ClassName: WARP_C_ORSHA -----
----- QuestIDs: ORSHA_MQ1_02 -----
end
-----

----- [Wizard Submaster]{nl}          Dejamis -----
addnpc(155069, "ETC_20151224_019898", "c_orsha", -274.29, 177.5, -758.49, 45, "ETC_20151224_019898_Call")
function ETC_20151224_019898_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_WIZARD_MASTER -----
----- QuestIDs: JOB_2_WIZARD_2_1JOB_2_WIZARD_3_1 | TUTO_2_WIZARD_TECH | ABBAY_64_3_SQ020 | ABBAY_64_3_SQ030 | ABBAY_64_3_SQ040 |  -----
msg("JOB_2_WIZARD_MASTER_basic1")
msg("JOB_2_WIZARD_MASTER_basic2")
end
-----

----- [Pyromancer Submaster]{nl}        Cathy Naimos -----
addnpc(155070, "ETC_20151224_019899", "c_orsha", -198.66, 177.43, -899.4, 45, "ETC_20151224_019899_Call")
function ETC_20151224_019899_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_PYROMANCER_MASTER -----
----- QuestIDs: JOB_2_PYROMANCER_2_1JOB_2_PYROMANCER_3_1 | JOB_2_PYROMANCER_4_1 |  -----
msg("JOB_2_PYROMANCER_MASTER_basic1")
end
-----

----- [Cryomancer Submaster]{nl}       Octavia Ifflyn -----
addnpc(155071, "ETC_20151224_019900", "c_orsha", 1035.62, 73.98, 79.04, -45, "ETC_20151224_019900_Call")
function ETC_20151224_019900_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_CRYOMANCER_MASTER -----
----- QuestIDs: JOB_2_CRYOMANCER_2_1JOB_2_CRYOMANCER_3_1 | JOB_2_CRYOMANCER_4_1 |  -----
msg("JOB_2_CRYOMANCER_MASTER_basic2")
msg("JOB_2_CRYOMANCER_MASTER_basic1")
end
-----

----- [Psychokino Master]{nl}       Ili Terid -----
addnpc(147328, "ETC_20151224_019901", "c_orsha", -859.85, 500.61, 586.16, -45, "ETC_20151224_019901_Call")
function ETC_20151224_019901_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_PSYCHOKINO_MASTER -----
----- QuestIDs: JOB_2_PSYCHOKINO_3_1JOB_2_PSYCHOKINO_4_1 | JOB_2_PSYCHOKINO_5_1 |  -----
msg("JOB_2_PSYCHOKINO_MASTER_basic2")
msg("JOB_2_PSYCHOKINO_MASTER_basic1")
end
-----

----- [Thaumaturge Submaster]{nl}          Diemer Fallon -----
addnpc(155074, "ETC_20151224_019903", "c_orsha", 235.47, 176.68, -827.3, -45, "ETC_20151224_019903_Call")
function ETC_20151224_019903_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_THAUMATURGE_MASTER -----
----- QuestIDs: JOB_2_THAUMATURGE_4_1JOB_2_THAUMATURGE_5_1 | JOB_2_THAUMATURGE_6_1 |  -----
msg("JOB_2_THAUMATURGE_MASTER_basic1")
msg("JOB_2_THAUMATURGE_MASTER_basic2")
end
-----

----- [Elementalist Master]{nl}         Wican Celestic -----
addnpc(147442, "ETC_20151224_019904", "c_orsha", -647.75, 317.8, 289.48, 0, "ETC_20151224_019904_Call")
function ETC_20151224_019904_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_ELEMENTALIST_MASTER -----
----- QuestIDs: JOB_2_ELEMENTALIST_4_1JOB_2_ELEMENTALIST_5_1 | JOB_2_ELEMENTALIST_6_1 |  -----
msg("JOB_2_ELEMENTALIST_MASTER_basic2")
msg("JOB_2_ELEMENTALIST_MASTER_basic1")
end
-----

----- [Archer Submaster]{nl}         Gunnison -----
addnpc(155076, "ETC_20151224_019905", "c_orsha", -182.95, 176.24, 658.06, -45, "ETC_20151224_019905_Call")
function ETC_20151224_019905_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_ARCHER_MASTER -----
----- QuestIDs: JOB_2_ARCHER_2_1JOB_2_ARCHER_3_1 | TUTO_2_ARCHER_TECH |  -----
msg("JOB_2_ARCHER_MASTER_basic1")
msg("JOB_2_ARCHER_MASTER_basic2")
end
-----

----- [Ranger Submaster]{nl}            Sheba -----
addnpc(155077, "ETC_20151224_019906", "c_orsha", 691.07, 177.47, -197.58, 45, "ETC_20151224_019906_Call")
function ETC_20151224_019906_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_RANGER_MASTER -----
----- QuestIDs: JOB_2_RANGER_2_1JOB_2_RANGER_3_1 | JOB_2_RANGER_4_1 |  -----
msg("JOB_2_RANGER_MASTER_basic1")
msg("JOB_2_RANGER_MASTER_basic2")
end
-----

----- [Quarrel Shooter Submaster]{nl}            Shorris -----
addnpc(155078, "ETC_20151224_019907", "c_orsha", 584.31, 175.85, 138.14, 0, "ETC_20151224_019907_Call")
function ETC_20151224_019907_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_QUARRELSHOOTER_MASTER -----
----- QuestIDs: JOB_2_QUARRELSHOOTER_2_1JOB_2_QUARRELSHOOTER_3_1 | JOB_2_QUARRELSHOOTER_4_1 |  -----
msg("JOB_2_QUARRELSHOOTER_MASTER_basic1")
msg("JOB_2_QUARRELSHOOTER_MASTER_basic2")
end
-----

----- [Sapper Submaster]{nl}     Zubin Katal -----
addnpc(155079, "ETC_20151224_019908", "c_orsha", 50.1228, 175.9837, -332.2393, 45, "ETC_20151224_019908_Call")
function ETC_20151224_019908_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_SAPPER_MASTER -----
----- QuestIDs: JOB_2_SAPPER_3_1JOB_2_SAPPER_4_1 | JOB_2_SAPPER_5_1 |  -----
msg("JOB_2_SAPPER_MASTER_basic1")
msg("JOB_2_SAPPER_MASTER_basic2")
end
-----

----- [Hunter Submaster]{nl}       Belkin Vellon -----
addnpc(155080, "ETC_20151224_019909", "c_orsha", -1098.89, 177.96, -648.37, 45, "ETC_20151224_019909_Call")
function ETC_20151224_019909_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_HUNTER_MASTER -----
----- QuestIDs: JOB_2_HUNTER_3_1JOB_2_HUNTER_4_1 | JOB_2_HUNTER_5_1 |  -----
msg("JOB_2_HUNTER_MASTER_basic1")
msg("JOB_2_HUNTER_MASTER_basic2")
end
-----

----- [Scout Submaster]{nl}          Suina -----
addnpc(155082, "ETC_20151224_019911", "c_orsha", -967.44, 177.67, -562.9, -45, "ETC_20151224_019911_Call")
function ETC_20151224_019911_Call()
----- Dialog -----
----- npcselectdialog.ies | ClassName: JOB_2_SCOUT_MASTER -----
----- QuestIDs: JOB_2_SCOUT_4_1JOB_2_SCOUT_5_1 | JOB_2_SCOUT_6_1 |  -----
msg("JOB_2_SCOUT_MASTER_basic2")
msg("JOB_2_SCOUT_MASTER_basic1")
end
-----

----- [Companion Trader]{nl}            Taurus -----
addnpc(20058, "ETC_20151224_019912", "c_orsha", -109.365, 176.2911, 362.765, 59, "ETC_20151224_019912_Call")
function ETC_20151224_019912_Call()
end
-----

----- [Market Manager]{nl}     Tilliana -----
addnpc(156008, "ETC_20151224_019913", "c_orsha", 213.9646, 175.8581, -12.91508, -41, "ETC_20151224_019913_Call")
function ETC_20151224_019913_Call()
----- Enter -----
msg("TUTO_MARKET_NPC")
end
-----

----- [Storage Keeper]{nl}      Aisa -----
addnpc(20067, "ETC_20151224_019914", "c_orsha", 320.2166, 175.8852, 69.16746, 45, "ETC_20151224_019914_Call")
function ETC_20151224_019914_Call()
----- Enter -----
msg("TUTO_STORAGE_NPC")
end
-----

----- [Orsha's Magic Association]{nl}           Florianna -----
addnpc(155102, "ETC_20151224_019915", "c_orsha", -985.9471, 500.6083, 415.8152, 45, "ETC_20151224_019915_Call")
function ETC_20151224_019915_Call()
end
-----

----- [Wings of Vibora]{nl}            Rosia -----
addnpc(155103, "ETC_20151224_019916", "c_orsha", -451.5142, 324.6042, -89.63361, 45, "ETC_20151224_019916_Call")
function ETC_20151224_019916_Call()
----- Enter -----
----- Dialog -----
----- npcselectdialog.ies | ClassName: ORSHA_JOURNEY_SHOP -----
msg("TUTO_JOURNAL_NPC")
msg("ORSHA_JOURNEY_SHOP_basic01")
end
-----

----- [TP Trader]{nl}   Leticia -----
addnpc(20068, "ETC_20151224_019887", "c_orsha", 41, 176, -14, 45, "ETC_20151224_019887_Call")
function ETC_20151224_019887_Call()
----- Enter -----
----- Dialog -----
----- npcselectdialog.ies | ClassName: TP_NPC -----
msg("TUTO_TPSHOP_NPC")
msg("TP_NPC_basic01")
msg("TP_NPC_basic02")
end
-----

----- Girl Settler -----
addnpc(20062, "QUEST_20151224_003174", "c_orsha", -42, 176, 207, 45, "QUEST_20151224_003174_Call")
function QUEST_20151224_003174_Call()
end
-----

----- Young Settler -----
addnpc(20064, "QUEST_20151224_003189", "c_orsha", -203, 176, 537, 45, "QUEST_20151224_003189_Call")
function QUEST_20151224_003189_Call()
end
-----

