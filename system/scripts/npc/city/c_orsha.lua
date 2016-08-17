----- Orsha Bulletin Board ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20151224_003161", "c_orsha", -1077.49, 500.61, 332.74, -17, "QUEST_20151224_003161_Call")
function QUEST_20151224_003161_Call()
msg("ORSHA_KEDORLA_BOARD01_BASIC01")
end

----- [Blacksmith] Ilanai ----- 
----- npcselectdialog.ies | ClassName: ORSHA_BLACKSMITH -----
----- Enter | Dialog -----
----- QuestIDs: PILGRIM_49_SQ_013 | PILGRIM_49_SQ_017 | JOB_2_DIEVDIRBYS3_1 | JOB_2_DIEVDIRBYS3_2 | JOB_2_DIEVDIRBYS3_3 -----
addnpc(20066, "ETC_20151224_019890", "c_orsha", -133.44, 175.98, -285.69, 28, "ETC_20151224_019890_Call")
function ETC_20151224_019890_Call()
msg("TUTO_REPAIR_NPC")
msg("PILGRIM_49_SQ_013_COMP")
msg("PILGRIM_49_SQ_017_ST")
msg("PILGRIM_49_SQ_017_AC")
msg("PILGRIM_49_SQ_017_PRST")
msg("PILGRIM_49_SQ_017_COMPST")
msg("ORSHA_BLACKSMITH_basic02")
msg("ORSHA_BLACKSMITH_basic01")
msg("JOB_2_DIEVDIRBYS3_2_1")
msg("JOB_2_DIEVDIRBYS3_2_2")
msg("JOB_2_DIEVDIRBYS3_2_3")
msg("JOB_2_DIEVDIRBYS3_3_1")
msg("JOB_2_DIEVDIRBYS3_3_2")
msg("JOB_2_DIEVDIRBYS3_3_3")
end

----- [Equipment Merchant]Jura ----- 
----- npcselectdialog.ies | ClassName: ORSHA_EQUIPMENT_DEALER -----
----- Enter | Dialog -----
----- QuestIDs: PILGRIM_49_SQ_017 -----
addnpc(20056, "ETC_20151224_019891", "c_orsha", 21, 176, 154, 78.07, "ETC_20151224_019891_Call")
function ETC_20151224_019891_Call()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("PILGRIM_49_SQ_017_PR")
msg("PILGRIM_49_SQ_017_COMPPG")
msg("ORSHA_EQUIPMENT_DEALER_basic01")
msg("ORSHA_EQUIPMENT_DEALER_basic02")
end

----- Orsha Resident ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(20063, "QUEST_20151224_003163", "c_orsha", 384.97, 175.85, 231.72, -105, "QUEST_20151224_003163_Call")
function QUEST_20151224_003163_Call()
msg("ORSHA_KEDORLA_MEMBER01_BASIC01")
end

----- [Lord of Orsha]Inesa Hamondale ----- 
----- npcselectdialog.ies | ClassName: C_ORSHA_HAMONDAIL -----
----- Dialog -----
----- QuestIDs: SIAU16_MQ_07 | ORSHA_MQ1_01 | ORSHA_MQ1_02 | ORSHA_MQ1_04 | ORSHA_MQ2_01 | ORSHA_MQ2_02 | PRISON623_MQ_07 | ORSHA_MQ3_01 -----
addnpc(20065, "ETC_20151224_019892", "c_orsha", 86.99, 176.27, 713.25, -35, "ETC_20151224_019892_Call")
function ETC_20151224_019892_Call()
msg("SIAU16_MQ_07_03")
msg("ORSHA_MQ1_01_01")
msg("ORSHA_MQ1_01_01_1")
msg("ORSHA_MQ1_01_02")
msg("C_ORSHA_HAMONDAIL_after_01")
msg("ORSHA_MQ1_01_03")
msg("ORSHA_MQ1_02_01")
msg("ORSHA_MQ1_02_01_01")
msg("C_ORSHA_HAMONDAIL_basic_01")
msg("ORSHA_MQ1_02_02")
msg("ORSHA_MQ1_04_01")
msg("ORSHA_MQ1_04_02")
msg("ORSHA_MQ2_01_03")
msg("ORSHA_MQ2_02_01")
msg("ORSHA_MQ2_02_01_01")
msg("ORSHA_MQ2_02_02")
msg("PRISON623_MQ_07_03")
msg("ORSHA_MQ3_01_01")
msg("ORSHA_MQ3_01_02")
end

----- Lord's Guard ----- 
----- npcselectdialog.ies | ClassName: C_ORSHA_SOLDIER_02 -----
----- Dialog -----
addnpc(20060, "QUEST_20151102_002969", "c_orsha", 140.98, 176.28, 712.85, -65, "QUEST_20151102_002969_Call")
function QUEST_20151102_002969_Call()
msg("C_ORSHA_SOLDIER_02_Chaplain_1")
msg("C_ORSHA_SOLDIER_02_Chaplain_2")
msg("C_ORSHA_SOLDIER_02_basic_01")
msg("C_ORSHA_SOLDIER_01_basic_01")
end

----- [Orsha Bishop]Urbonas ----- 
----- npcselectdialog.ies | ClassName: C_ORSHA_URBONAS -----
----- Dialog -----
----- QuestIDs: ORSHA_MQ3_01 -----
addnpc(154057, "ETC_20151224_019893", "c_orsha", 895.18, 176.37, 702.91, -45, "ETC_20151224_019893_Call")
function ETC_20151224_019893_Call()
msg("C_ORSHA_URBONAS_basic_02")
msg("PRISON621_URBONAS_basic_02")
msg("PRISON621_URBONAS_basic_01")
msg("C_ORSHA_URBONAS_basic_01")
msg("PRISON621_MQ_05_03")
msg("PRISON621_MQ_06_01")
msg("PRISON621_MQ_06_02")
msg("PRISON621_MQ_06_03")
msg("PRISON621_MQ_07_01")
msg("PRISON621_MQ_07_01_AG")
msg("PRISON621_MQ_07_02")
msg("PRISON623_MQ_06_03")
msg("PRISON623_MQ_07_01")
msg("PRISON623_MQ_07_AG")
msg("ORSHA_MQ3_01_03")
msg("PRISON621_MQ_06_TRACK_DLG_1")
end

----- [Item Merchant]Alf ----- 
----- npcselectdialog.ies | ClassName: ORSHA_TOOL_NPC -----
----- Dialog -----
----- QuestIDs: ORSHA_MQ1_02 | ORSHA_MQ1_03 | ORSHA_MQ2_02 -----
addnpc(20055, "ETC_20151224_019894", "c_orsha", 231, 175, 166, 75, "ETC_20151224_019894_Call")
function ETC_20151224_019894_Call()
msg("ORSHA_TOOL_NPC_basic02")
msg("ORSHA_TOOL_NPC_basic01")
msg("ORSHA_MQ1_02_03")
msg("ORSHA_MQ1_03_01")
msg("ORSHA_MQ1_03_02")
msg("ORSHA_MQ2_02_03")
end

----- [Accessory Merchant]Jurus ----- 
----- npcselectdialog.ies | ClassName: ORSHA_ACCESSARY_NPC -----
----- Dialog -----
----- QuestIDs: ORSHA_MQ1_03 | KATYN_12_SQ_01 -----
addnpc(20057, "ETC_20151224_019895", "c_orsha", 462.1917, 175.9214, -29.93526, -56, "ETC_20151224_019895_Call")
function ETC_20151224_019895_Call()
msg("KATYN_12_SQ_01_succ")
msg("ORSHA_ACCESSARY_NPC_basic01")
msg("ORSHA_ACCESSARY_NPC_basic02")
msg("ORSHA_MQ1_03_03")
end

----- [Peltasta Submaster]Nirin Dameoff ----- 
----- npcselectdialog.ies | ClassName: JOB_2_PELTASTA_NPC -----
----- Dialog -----
----- QuestIDs: JOB_2_PELTASTA2 | JOB_2_PELTASTA3 | JOB_2_PELTASTA4 -----
addnpc(155063, "ETC_20151022_016441", "c_orsha", -887.55, 500.6, -85.23, 55, "ETC_20151022_016441_Call")
function ETC_20151022_016441_Call()
msg("JOB_2_PELTASTA_basic01")
msg("JOB_2_PELTASTA_basic02")
msg("JOB_2_PELTASTA2_1_1")
msg("JOB_2_PELTASTA2_1_2")
msg("JOB_2_PELTASTA2_1_3")
msg("JOB_2_PELTASTA2_1_4")
msg("JOB_2_PELTASTA3_1_1")
msg("JOB_2_PELTASTA3_1_2")
msg("JOB_2_PELTASTA3_1_3")
msg("JOB_2_PELTASTA3_1_4")
msg("JOB_2_PELTASTA4_1_1")
msg("JOB_2_PELTASTA4_1_2")
msg("JOB_2_PELTASTA4_1_3")
msg("JOB_2_PELTASTA4_1_4")
end

----- [Hoplite Master]Aidas Valor ----- 
----- npcselectdialog.ies | ClassName: JOB_2_HOPLITE_NPC -----
----- Dialog -----
----- QuestIDs: JOB_2_HOPLITE3 | JOB_2_HOPLITE4 | JOB_2_HOPLITE5 -----
addnpc(147325, "ETC_20151224_019896", "c_orsha", -1070.18, 500.61, 229.96, 43, "ETC_20151224_019896_Call")
function ETC_20151224_019896_Call()
msg("JOB_HOPLITE5_1_select")
msg("JOB_HOPLITE5_1_prog")
msg("JOB_HOPLITE5_1_succ")
msg("JOB_2_HOPLITE_basic01")
msg("JOB_2_HOPLITE_basic02")
msg("JOB_2_HOPLITE3_1_1")
msg("JOB_2_HOPLITE3_1_2")
msg("JOB_2_HOPLITE3_1_3")
msg("JOB_2_HOPLITE3_1_4")
msg("JOB_2_HOPLITE4_1_1")
msg("JOB_2_HOPLITE4_1_2")
msg("JOB_2_HOPLITE4_1_3")
msg("JOB_2_HOPLITE4_1_4")
msg("JOB_2_HOPLITE5_1_1")
msg("JOB_2_HOPLITE5_1_2")
msg("JOB_2_HOPLITE5_1_3")
msg("JOB_2_HOPLITE5_1_4")
end

----- [Cleric Submaster] Tamara Easton ----- 
----- npcselectdialog.ies | ClassName: JOB_2_CLERIC_NPC -----
----- Dialog -----
----- QuestIDs: JOB_2_CLERIC2 | JOB_2_CLERIC3 | TUTO_2_CLERIC_TECH | BRACKEN_63_1_SQ040 | BRACKEN_63_1_SQ050 -----
addnpc(155083, "ETC_20151022_016442", "c_orsha", -269.96, 175.98, -378.04, 35, "ETC_20151022_016442_Call")
function ETC_20151022_016442_Call()
msg("TUTO_2_CLERIC_TECH_select")
msg("TUTO_2_CLERIC_TECH_succ")
msg("BRACKEN_63_1_SQ040_succ01")
msg("BRACKEN_63_1_SQ050_startnpc01")
msg("BRACKEN_63_1_SQ050_PG")
msg("JOB_2_CLERIC_basic01")
msg("JOB_2_CLERIC_basic02")
msg("JOB_2_CLERIC2_1_1")
msg("JOB_2_CLERIC2_1_2")
msg("JOB_2_CLERIC2_1_3")
msg("JOB_2_CLERIC2_1_4")
msg("JOB_2_PRIEST2_1_5")
msg("JOB_2_PRIEST2_1_8")
msg("JOB_2_CLERIC3_1_1")
msg("JOB_2_CLERIC3_1_2")
msg("JOB_2_CLERIC3_1_3")
msg("JOB_2_CLERIC3_1_4")
end

----- [Krivis Submaster] Mellinda Dicherin ----- 
----- npcselectdialog.ies | ClassName: JOB_2_KRIVIS_NPC -----
----- Dialog -----
----- QuestIDs: JOB_2_KRIVIS2 | JOB_2_KRIVIS3 | JOB_2_KRIVIS4 -----
addnpc(155084, "ETC_20151022_016443", "c_orsha", -612.21, 368.42, 608.86, 29, "ETC_20151022_016443_Call")
function ETC_20151022_016443_Call()
msg("JOB_2_KRIVIS_basic01")
msg("JOB_2_KRIVIS_basic02")
msg("JOB_2_KRIVIS2_1_1")
msg("JOB_2_KRIVIS2_1_2")
msg("JOB_2_KRIVIS2_1_3")
msg("JOB_2_KRIVIS2_1_4")
msg("JOB_2_PRIEST2_1_6")
msg("JOB_2_PRIEST2_1_9")
msg("JOB_2_KRIVIS3_1_1")
msg("JOB_2_KRIVIS3_1_2")
msg("JOB_2_KRIVIS3_1_3")
msg("JOB_2_KRIVIS3_1_4")
msg("JOB_2_KRIVIS4_1_1")
msg("JOB_2_KRIVIS4_1_2")
msg("JOB_2_KRIVIS4_1_3")
msg("JOB_2_KRIVIS4_1_4")
end

----- [Priest Submaster]Boira ----- 
----- npcselectdialog.ies | ClassName: JOB_2_PRIEST_NPC -----
----- Dialog -----
----- QuestIDs: JOB_2_PRIEST2 | JOB_2_PRIEST3 | JOB_2_PRIEST4 -----
addnpc(155085, "ETC_20151022_016444", "c_orsha", 723.44, 176.38, 642.36, -30, "ETC_20151022_016444_Call")
function ETC_20151022_016444_Call()
msg("JOB_2_PRIEST_basic01")
msg("JOB_2_PRIEST_basic02")
msg("JOB_2_PRIEST2_1_1")
msg("JOB_2_PRIEST2_1_2")
msg("JOB_2_PRIEST2_1_3")
msg("JOB_2_PRIEST2_1_4")
msg("JOB_2_PRIEST3_1_1")
msg("JOB_2_PRIEST3_1_2")
msg("JOB_2_PRIEST3_1_3")
msg("JOB_2_PRIEST3_1_4")
msg("JOB_2_PRIEST4_1_1")
msg("JOB_2_PRIEST4_1_2")
msg("JOB_2_PRIEST4_1_3")
msg("JOB_2_PRIEST4_1_4")
end

----- [Bokor Submaster]Bobo Icelin ----- 
----- npcselectdialog.ies | ClassName: JOB_2_BOKOR_NPC -----
----- Dialog -----
----- QuestIDs: JOB_2_BOKOR4 | JOB_2_BOKOR5 | JOB_2_BOKOR3 -----
addnpc(155086, "ETC_20151022_016445", "c_orsha", 462.4, 176.4, 608.87, -45, "ETC_20151022_016445_Call")
function ETC_20151022_016445_Call()
msg("JOB_2_PRIEST2_1_7")
msg("JOB_2_PRIEST2_1_10")
msg("JOB_2_BOKOR_basic01")
msg("JOB_2_BOKOR_basic02")
msg("JOB_2_BOKOR3_1_1")
msg("JOB_2_BOKOR3_1_2")
msg("JOB_2_BOKOR3_1_3")
msg("JOB_2_BOKOR3_1_4")
msg("JOB_2_BOKOR4_1_1")
msg("JOB_2_BOKOR4_1_2")
msg("JOB_2_BOKOR4_1_3")
msg("JOB_2_BOKOR4_1_4")
msg("JOB_2_BOKOR5_1_1")
msg("JOB_2_BOKOR5_1_2")
msg("JOB_2_BOKOR5_1_3")
msg("JOB_2_BOKOR5_1_4")
end

----- [Rodelero Master] Kamiya ----- 
----- npcselectdialog.ies | ClassName: JOB_2_RODELERO_NPC -----
----- Dialog -----
----- QuestIDs: JOB_2_RODELERO4 | JOB_2_RODELERO5 | JOB_2_RODELERO6 -----
addnpc(57235, "ETC_20150317_009175", "c_orsha", -464.48, 280.14, 371.74, -20, "ETC_20150317_009175_Call")
function ETC_20150317_009175_Call()
msg("JOB_ARCHER3_1_succ1")
msg("JOB_ARCHER3_2_select1")
msg("JOB_ARCHER3_2_prog1")
msg("JOB_ARCHER3_2_succ1")
msg("JOB_2_RODELERO_basic01")
msg("JOB_2_RODELERO_basic02")
msg("JOB_2_RODELERO4_1_1")
msg("JOB_2_RODELERO4_1_2")
msg("JOB_2_RODELERO4_1_3")
msg("JOB_2_RODELERO5_1_1")
msg("JOB_2_RODELERO5_1_2")
msg("JOB_2_RODELERO5_1_3")
msg("JOB_2_RODELERO5_1_4")
msg("JOB_2_RODELERO6_1_1")
msg("JOB_2_RODELERO6_1_2")
msg("JOB_2_RODELERO6_1_3")
msg("JOB_2_RODELERO6_1_4")
end

----- [Cataphract Master]Memet Culag ----- 
----- npcselectdialog.ies | ClassName: JOB_2_CATAPHRACT_NPC -----
----- Dialog -----
----- QuestIDs: JOB_2_CATAPHRACT4 | JOB_2_CATAPHRACT5 | JOB_2_CATAPHRACT6 -----
addnpc(147327, "ETC_20150317_009423", "c_orsha", 934.65, 73.98, 146.95, 26, "ETC_20150317_009423_Call")
function ETC_20150317_009423_Call()
msg("JOB_CATAPHRACT4_1_select")
msg("JOB_CATAPHRACT4_1_agree")
msg("JOB_CATAPHRACT4_1_succ")
msg("JOB_2_CATAPHRACT_basic01")
msg("JOB_2_CATAPHRACT_basic02")
msg("JOB_2_CATAPHRACT4_1_1")
msg("JOB_2_CATAPHRACT4_1_2")
msg("JOB_2_CATAPHRACT4_1_3")
msg("JOB_2_CATAPHRACT4_1_4")
msg("JOB_2_CATAPHRACT5_1_1")
msg("JOB_2_CATAPHRACT5_1_2")
msg("JOB_2_CATAPHRACT5_1_3")
msg("JOB_2_CATAPHRACT5_1_4")
msg("JOB_2_CATAPHRACT6_1_1")
msg("JOB_2_CATAPHRACT6_1_2")
msg("JOB_2_CATAPHRACT6_1_3")
end

----- [Paladin Submaster]Silvia Naimon ----- 
----- npcselectdialog.ies | ClassName: JOB_2_PALADIN_NPC -----
----- Dialog -----
----- QuestIDs: JOB_2_PALADIN4 | JOB_2_PALADIN5 | JOB_2_PALADIN6 -----
addnpc(155088, "ETC_20151224_019897", "c_orsha", 942.27, 73.98, 475.77, 50, "ETC_20151224_019897_Call")
function ETC_20151224_019897_Call()
msg("JOB_2_PALADIN_basic01")
msg("JOB_2_PALADIN_basic02")
msg("JOB_2_PALADIN4_1_1")
msg("JOB_2_PALADIN4_1_2")
msg("JOB_2_PALADIN4_1_3")
msg("JOB_2_PALADIN4_1_4")
msg("JOB_2_PALADIN5_1_1")
msg("JOB_2_PALADIN5_1_2")
msg("JOB_2_PALADIN5_1_3")
msg("JOB_2_PALADIN5_1_4")
msg("JOB_2_PALADIN6_1_1")
msg("JOB_2_PALADIN6_1_2")
msg("JOB_2_PALADIN6_1_3")
msg("JOB_2_PALADIN6_1_4")
end

----- Priest Pranas ----- 
----- npcselectdialog.ies | ClassName: C_ORSHA_PRANAS -----
----- Dialog -----
----- QuestIDs: SIAU11RE_MQ_06 | ORSHA_MQ2_01 | ORSHA_MQ2_03 -----
addnpc(155044, "ETC_20151001_015227", "c_orsha", 915.74, 176.36, 708.51, -24, "ETC_20151001_015227_Call")
function ETC_20151001_015227_Call()
msg("PRISON622_PRANAS_basic_03")
msg("PRISON622_PRANAS_basic_04")
msg("PRISON622_PRANAS_basic_02")
msg("SIAU11RE_MQ_05_03")
msg("SIAU11RE_MQ_06_01")
msg("SIAU11RE_MQ_06_01_01")
msg("SIAU11RE_MQ_06_03")
msg("ORSHA_MQ2_01_01")
msg("ORSHA_MQ2_01_01_01")
msg("ORSHA_MQ2_01_02")
msg("ORSHA_MQ2_03_01")
msg("ORSHA_MQ2_03_01_1")
msg("ORSHA_MQ2_03_03")
msg("PRISON621_MQ_01_01")
msg("PRISON621_MQ_01_01_01")
msg("PRISON621_MQ_01_03")
msg("PRISON621_MQ_02_01")
msg("PRISON621_MQ_02_02")
msg("PRISON621_MQ_03_01")
msg("PRISON621_MQ_03_01_01")
msg("PRISON621_PRANAS_basic_01")
msg("PRISON622_PRANAS_basic_01")
msg("PRISON621_MQ_03_02")
msg("PRISON621_MQ_05_02")
msg("PRISON621_MQ_03_02_AG")
msg("PRISON621_MQ_07_03")
msg("PRISON621_MQ_04_03")
msg("PRISON622_MQ_01_01")
msg("PRISON622_MQ_01_03")
msg("PRISON622_MQ_03_01")
msg("PRISON622_MQ_03_02")
msg("PRISON622_SQ_01_add")
end

----- Lord's Guard ----- 
----- npcselectdialog.ies | ClassName: C_ORSHA_SOLDIER_01 -----
----- Dialog -----
addnpc(20059, "QUEST_20151102_002969", "c_orsha", 40.71, 176.27, 713.98, -31, "QUEST_20151102_002969_Call")
function QUEST_20151102_002969_Call()
msg("C_ORSHA_SOLDIER_02_Chaplain_1")
msg("C_ORSHA_SOLDIER_02_Chaplain_2")
msg("C_ORSHA_SOLDIER_02_basic_01")
msg("C_ORSHA_SOLDIER_01_basic_01")
end

----- [Sadhu Master]Agota Hanska ----- 
----- npcselectdialog.ies | ClassName: JOB_2_SADHU_NPC -----
----- Dialog -----
----- QuestIDs: JOB_2_SADHU4 | JOB_2_SADHU5 | JOB_2_SADHU6 -----
addnpc(57226, "ETC_20151022_016446", "c_orsha", 1130.38, 21.82, 361.98, 48, "ETC_20151022_016446_Call")
function ETC_20151022_016446_Call()
msg("JOB_SADU3_1_NPC_BASIC03")
msg("JOB_RANGER3_1_pgor1")
msg("JOB_RANGER3_1_succ_progtnpc")
msg("JOB_SADU3_1_select1")
msg("JOB_SADU3_1_agree1")
msg("JOB_SADU3_1_succ1")
msg("JOB_SADU4_1_ST")
msg("JOB_SADU4_1_AC")
msg("JOB_SADU4_1_COMP")
msg("FEDIMIAN_HQ_02_ST")
msg("FEDIMIAN_HQ_02_AC")
msg("FEDIMIAN_HQ_02_COMP")
msg("JOB_SADU3_1_NPC_BASIC01")
msg("JOB_SADU3_1_NPC_BASIC02")
msg("JOB_SADU5_1_01")
msg("JOB_SADU5_1_02")
msg("JOB_SADU5_1_03")
msg("JOB_2_SADHU_basic01")
msg("JOB_2_SADHU_basic02")
msg("JOB_2_SADHU4_1_1")
msg("JOB_2_SADHU4_1_2")
msg("JOB_2_SADHU4_1_3")
msg("JOB_2_SADHU4_1_4")
msg("JOB_2_SADHU5_1_1")
msg("JOB_2_SADHU5_1_2")
msg("JOB_2_SADHU5_1_3")
msg("JOB_2_SADHU6_1_1")
msg("JOB_2_SADHU6_1_2")
msg("JOB_2_SADHU6_1_3")
end

----- [Swordsman Submaster]Codill ----- 
----- npcselectdialog.ies | ClassName: JOB_2_SWORDMAN_NPC -----
----- Dialog -----
----- QuestIDs: JOB_2_SWORDMAN2 | JOB_2_SWORDMAN3 | TUTO_2_SWORDMAN_TECH -----
addnpc(155062, "ETC_20151022_016440", "c_orsha", 236.57, 176.41, 648.6, -44, "ETC_20151022_016440_Call")
function ETC_20151022_016440_Call()
msg("TUTO_2_SWORDMAN_TECH_select")
msg("TUTO_2_SWORDMAN_TECH_succ")
msg("JOB_2_SWORDMAN_basic01")
msg("JOB_2_SWORDMAN_basic02")
msg("JOB_2_SWORDMAN2_1_1")
msg("JOB_2_SWORDMAN2_1_2")
msg("JOB_2_SWORDMAN2_1_3")
msg("JOB_2_SWORDMAN2_1_4")
msg("JOB_2_SWORDMAN3_1_1")
msg("JOB_2_SWORDMAN3_1_2")
msg("JOB_2_SWORDMAN3_1_3")
msg("JOB_2_SWORDMAN3_1_4")
end

----- Flameholder ----- 
addnpc(47242, "ETC_20151022_016448", "c_orsha", -603.11, 368.12, 641.37, 33, "npc_dummy")

----- Statue of Goddess Ausrine ----- 
----- npcselectdialog.ies | ClassName: WARP_C_ORSHA -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 | ORSHA_MQ1_02 -----
addnpc(154063, "ETC_20150317_007031", "c_orsha", 103.14, 176.14, 322.95, -91, "ETC_20150317_007031_Call")
function ETC_20150317_007031_Call()
msg("GM_QUEST_MODIFY_PC_SEL")
end

----- [Wizard Submaster]Dejamis ----- 
----- npcselectdialog.ies | ClassName: JOB_2_WIZARD_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_WIZARD_2_1 | JOB_2_WIZARD_3_1 | TUTO_2_WIZARD_TECH | ABBAY_64_3_SQ020 | ABBAY_64_3_SQ030 | ABBAY_64_3_SQ040 -----
addnpc(155069, "ETC_20151224_019898", "c_orsha", -274.29, 177.5, -758.49, 45, "ETC_20151224_019898_Call")
function ETC_20151224_019898_Call()
msg("JOB_2_WIZARD_2_1_select")
msg("JOB_2_WIZARD_2_1_agree")
msg("JOB_2_WIZARD_2_1_progstart")
msg("JOB_2_WIZARD_2_1_succ")
msg("JOB_2_WIZARD_3_1_select")
msg("JOB_2_WIZARD_3_1_agree")
msg("JOB_2_WIZARD_3_1_progstart")
msg("JOB_2_WIZARD_3_1_succ")
msg("JOB_2_WIZARD_MASTER_basic1")
msg("JOB_2_WIZARD_MASTER_basic2")
msg("TUTO_2_WIZARD_TECH_select")
msg("TUTO_2_WIZARD_TECH_succ")
end

----- [Pyromancer Submaster]Cathy Naimos ----- 
----- npcselectdialog.ies | ClassName: JOB_2_PYROMANCER_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_PYROMANCER_2_1 | JOB_2_PYROMANCER_3_1 | JOB_2_PYROMANCER_4_1 -----
addnpc(155070, "ETC_20151224_019899", "c_orsha", -198.66, 177.43, -899.4, 45, "ETC_20151224_019899_Call")
function ETC_20151224_019899_Call()
msg("JOB_2_PYROMANCER_2_1_select")
msg("JOB_2_PYROMANCER_2_1_agree")
msg("JOB_2_PYROMANCER_2_1_progstart")
msg("JOB_2_PYROMANCER_2_1_succ")
msg("JOB_2_PYROMANCER_3_1_select")
msg("JOB_2_PYROMANCER_3_1_agree")
msg("JOB_2_PYROMANCER_3_1_progstart")
msg("JOB_2_PYROMANCER_3_1_succ")
msg("JOB_2_PYROMANCER_4_1_select")
msg("JOB_2_PYROMANCER_4_1_agree")
msg("JOB_2_PYROMANCER_4_1_progstart")
msg("JOB_2_PYROMANCER_4_1_succ")
msg("JOB_2_WIZARD_3_1_PYROMANCER_dlg")
msg("JOB_2_PYROMANCER_MASTER_basic1")
msg("JOB_2_PYROMANCER_MASTER_basic2")
end

----- [Cryomancer Submaster] Octavia Ifflyn ----- 
----- npcselectdialog.ies | ClassName: JOB_2_CRYOMANCER_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_CRYOMANCER_2_1 | JOB_2_CRYOMANCER_3_1 | JOB_2_CRYOMANCER_4_1 -----
addnpc(155071, "ETC_20151224_019900", "c_orsha", 1035.62, 73.98, 79.04, -45, "ETC_20151224_019900_Call")
function ETC_20151224_019900_Call()
msg("JOB_2_CRYOMANCER_2_1_select")
msg("JOB_2_CRYOMANCER_2_1_agree")
msg("JOB_2_CRYOMANCER_2_1_progstart")
msg("JOB_2_CRYOMANCER_2_1_succ")
msg("JOB_2_CRYOMANCER_3_1_select")
msg("JOB_2_CRYOMANCER_3_1_agree")
msg("JOB_2_CRYOMANCER_3_1_progstart")
msg("JOB_2_CRYOMANCER_3_1_succ")
msg("JOB_2_CRYOMANCER_4_1_select")
msg("JOB_2_CRYOMANCER_4_1_agree")
msg("JOB_2_CRYOMANCER_4_1_progstart")
msg("JOB_2_CRYOMANCER_4_1_succ")
msg("JOB_2_WIZARD_3_1_CRYOMANCER_dlg")
msg("JOB_2_CRYOMANCER_MASTER_basic1")
msg("JOB_2_CRYOMANCER_MASTER_basic2")
end

----- [Psychokino Master] Ili Terid ----- 
----- npcselectdialog.ies | ClassName: JOB_2_PSYCHOKINO_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_PSYCHOKINO_3_1 | JOB_2_PSYCHOKINO_4_1 | JOB_2_PSYCHOKINO_5_1 -----
addnpc(147328, "ETC_20151224_019901", "c_orsha", -859.85, 500.61, 586.16, -45, "ETC_20151224_019901_Call")
function ETC_20151224_019901_Call()
msg("JOB_PSYCHOKINESIST5_1_ST")
msg("JOB_PSYCHOKINESIST5_1_AC")
msg("JOB_PSYCHOKINESIST5_1_PG")
msg("JOB_PSYCHOKINESIST5_1_COMP")
msg("JOB_2_PSYCHOKINO_3_1_select")
msg("JOB_2_PSYCHOKINO_3_1_agree")
msg("JOB_2_PSYCHOKINO_3_1_progstart")
msg("JOB_2_PSYCHOKINO_3_1_succ")
msg("JOB_2_PSYCHOKINO_4_1_select")
msg("JOB_2_PSYCHOKINO_4_1_agree")
msg("JOB_2_PSYCHOKINO_4_1_progstart")
msg("JOB_2_PSYCHOKINO_4_1_succ")
msg("JOB_2_PSYCHOKINO_5_1_select")
msg("JOB_2_PSYCHOKINO_5_1_agree")
msg("JOB_2_PSYCHOKINO_5_1_progstart")
msg("JOB_2_PSYCHOKINO_5_1_succ")
msg("JOB_2_WIZARD_3_1_PSYCHOKINO_dlg")
msg("JOB_2_PSYCHOKINO_MASTER_basic1")
msg("JOB_2_PSYCHOKINO_MASTER_basic2")
end

----- [Linker Master]Winona Ende ----- 
----- npcselectdialog.ies | ClassName: JOB_2_LINKER_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_LINKER_3_1 | JOB_2_LINKER_4_1 | JOB_2_LINKER_5_1 -----
addnpc(57230, "ETC_20151224_019902", "c_orsha", 609.44, 148.11, 341.2, 45, "ETC_20151224_019902_Call")
function ETC_20151224_019902_Call()
msg("JOB_LINKER5_1_ST")
msg("JOB_LINKER5_1_AC")
msg("JOB_LINKER5_1_COMP")
msg("JOB_2_LINKER_3_1_select")
msg("JOB_2_LINKER_3_1_agree")
msg("JOB_2_LINKER_3_1_progstart")
msg("JOB_2_LINKER_3_1_succ")
msg("JOB_2_LINKER_4_1_select")
msg("JOB_2_LINKER_4_1_agree")
msg("JOB_2_LINKER_4_1_progstart")
msg("JOB_2_LINKER_4_1_succ")
msg("JOB_2_LINKER_5_1_select")
msg("JOB_2_LINKER_5_1_agree")
msg("JOB_2_LINKER_5_1_progstart")
msg("JOB_2_LINKER_5_1_succ")
msg("JOB_2_WIZARD_3_1_LINKER_MASTER_dlg")
msg("JOB_2_LINKER_MASTER_basic1")
msg("JOB_2_LINKER_MASTER_basic2")
end

----- [Thaumaturge Submaster]Diemer Fallon ----- 
----- npcselectdialog.ies | ClassName: JOB_2_THAUMATURGE_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_THAUMATURGE_4_1 | JOB_2_THAUMATURGE_5_1 | JOB_2_THAUMATURGE_6_1 -----
addnpc(155074, "ETC_20151224_019903", "c_orsha", 235.47, 176.68, -827.3, -45, "ETC_20151224_019903_Call")
function ETC_20151224_019903_Call()
msg("JOB_2_THAUMATURGE_4_1_select")
msg("JOB_2_THAUMATURGE_4_1_agree")
msg("JOB_2_THAUMATURGE_4_1_progstart")
msg("JOB_2_THAUMATURGE_4_1_succ")
msg("JOB_2_THAUMATURGE_5_1_select")
msg("JOB_2_THAUMATURGE_5_1_agree")
msg("JOB_2_THAUMATURGE_5_1_progstart")
msg("JOB_2_THAUMATURGE_5_1_succ")
msg("JOB_2_THAUMATURGE_6_1_select")
msg("JOB_2_THAUMATURGE_6_1_agree")
msg("JOB_2_THAUMATURGE_6_1_progstart")
msg("JOB_2_THAUMATURGE_6_1_succ")
msg("JOB_2_THAUMATURGE_MASTER_basic1")
msg("JOB_2_THAUMATURGE_MASTER_basic2")
end

----- [Elementalist Master] Wican Celestic ----- 
----- npcselectdialog.ies | ClassName: JOB_2_ELEMENTALIST_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_ELEMENTALIST_4_1 | JOB_2_ELEMENTALIST_5_1 | JOB_2_ELEMENTALIST_6_1 -----
addnpc(147442, "ETC_20151224_019904", "c_orsha", -647.75, 317.8, 289.48, 0, "ETC_20151224_019904_Call")
function ETC_20151224_019904_Call()
msg("JOB_RANGER3_1_succ1")
msg("JOB_RANGER3_2_select1")
msg("JOB_RANGER3_2_prog1")
msg("JOB_RANGER3_2_succ_startnpc")
msg("JOB_2_ELEMENTALIST_4_1_select")
msg("JOB_2_ELEMENTALIST_4_1_agree")
msg("JOB_2_ELEMENTALIST_4_1_progstart")
msg("JOB_2_ELEMENTALIST_4_1_succ")
msg("JOB_2_ELEMENTALIST_5_1_select")
msg("JOB_2_ELEMENTALIST_5_1_agree")
msg("JOB_2_ELEMENTALIST_5_1_progstart")
msg("JOB_2_ELEMENTALIST_5_1_succ")
msg("JOB_2_ELEMENTALIST_6_1_select")
msg("JOB_2_ELEMENTALIST_6_1_agree")
msg("JOB_2_ELEMENTALIST_6_1_progstart")
msg("JOB_2_ELEMENTALIST_6_1_succ")
msg("JOB_2_ELEMENTALIST_MASTER_basic1")
msg("JOB_2_ELEMENTALIST_MASTER_basic2")
end

----- [Archer Submaster] Gunnison ----- 
----- npcselectdialog.ies | ClassName: JOB_2_ARCHER_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_ARCHER_2_1 | JOB_2_ARCHER_3_1 | TUTO_2_ARCHER_TECH -----
addnpc(155076, "ETC_20151224_019905", "c_orsha", -182.95, 176.24, 658.06, -45, "ETC_20151224_019905_Call")
function ETC_20151224_019905_Call()
msg("JOB_2_ARCHER_2_1_select")
msg("JOB_2_ARCHER_2_1_agree")
msg("JOB_2_ARCHER_2_1_progstart")
msg("JOB_2_ARCHER_2_1_succ")
msg("JOB_2_ARCHER_3_1_select")
msg("JOB_2_ARCHER_3_1_agree")
msg("JOB_2_ARCHER_3_1_progstart")
msg("JOB_2_ARCHER_3_1_succ")
msg("JOB_2_ARCHER_MASTER_basic1")
msg("JOB_2_ARCHER_MASTER_basic2")
msg("TUTO_2_ARCHER_TECH_select")
msg("TUTO_2_ARCHER_TECH_succ")
end

----- [Ranger Submaster]Sheba ----- 
----- npcselectdialog.ies | ClassName: JOB_2_RANGER_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_RANGER_2_1 | JOB_2_RANGER_3_1 | JOB_2_RANGER_4_1 -----
addnpc(155077, "ETC_20151224_019906", "c_orsha", 691.07, 177.47, -197.58, 45, "ETC_20151224_019906_Call")
function ETC_20151224_019906_Call()
msg("JOB_2_RANGER_2_1_select")
msg("JOB_2_RANGER_2_1_agree")
msg("JOB_2_RANGER_2_1_progstart")
msg("JOB_2_RANGER_2_1_succ")
msg("JOB_2_RANGER_3_1_select")
msg("JOB_2_RANGER_3_1_agree")
msg("JOB_2_RANGER_3_1_progstart")
msg("JOB_2_RANGER_3_1_succ")
msg("JOB_2_RANGER_4_1_select")
msg("JOB_2_RANGER_4_1_agree")
msg("JOB_2_RANGER_4_1_progstart")
msg("JOB_2_RANGER_4_1_succ")
msg("JOB_2_RANGER_MASTER_basic1")
msg("JOB_2_RANGER_MASTER_basic2")
end

----- [Quarrel Shooter Submaster]Shorris ----- 
----- npcselectdialog.ies | ClassName: JOB_2_QUARRELSHOOTER_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_QUARRELSHOOTER_2_1 | JOB_2_QUARRELSHOOTER_3_1 | JOB_2_QUARRELSHOOTER_4_1 -----
addnpc(155078, "ETC_20151224_019907", "c_orsha", 584.31, 175.85, 138.14, 0, "ETC_20151224_019907_Call")
function ETC_20151224_019907_Call()
msg("JOB_2_QUARRELSHOOTER_2_1_select")
msg("JOB_2_QUARRELSHOOTER_2_1_agree")
msg("JOB_2_QUARRELSHOOTER_2_1_progstart")
msg("JOB_2_QUARRELSHOOTER_2_1_succ")
msg("JOB_2_QUARRELSHOOTER_3_1_select")
msg("JOB_2_QUARRELSHOOTER_3_1_agree")
msg("JOB_2_QUARRELSHOOTER_3_1_progstart")
msg("JOB_2_QUARRELSHOOTER_3_1_succ")
msg("JOB_2_QUARRELSHOOTER_4_1_select")
msg("JOB_2_QUARRELSHOOTER_4_1_agree")
msg("JOB_2_QUARRELSHOOTER_4_1_progstart")
msg("JOB_2_QUARRELSHOOTER_4_1_succ")
msg("JOB_2_QUARRELSHOOTER_MASTER_basic1")
msg("JOB_2_QUARRELSHOOTER_MASTER_basic2")
end

----- [Sapper Submaster] Zubin Katal ----- 
----- npcselectdialog.ies | ClassName: JOB_2_SAPPER_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_SAPPER_3_1 | JOB_2_SAPPER_4_1 | JOB_2_SAPPER_5_1 -----
addnpc(155079, "ETC_20151224_019908", "c_orsha", 50.1228, 175.9837, -332.2393, 45, "ETC_20151224_019908_Call")
function ETC_20151224_019908_Call()
msg("JOB_2_SAPPER_3_1_select")
msg("JOB_2_SAPPER_3_1_agree")
msg("JOB_2_SAPPER_3_1_progstart")
msg("JOB_2_SAPPER_3_1_succ")
msg("JOB_2_SAPPER_4_1_select")
msg("JOB_2_SAPPER_4_1_agree")
msg("JOB_2_SAPPER_4_1_progstart")
msg("JOB_2_SAPPER_4_1_succ")
msg("JOB_2_SAPPER_5_1_select")
msg("JOB_2_SAPPER_5_1_agree")
msg("JOB_2_SAPPER_5_1_progstart")
msg("JOB_2_SAPPER_5_1_succ")
msg("JOB_2_SAPPER_MASTER_basic1")
msg("JOB_2_SAPPER_MASTER_basic2")
end

----- [Hunter Submaster] Belkin Vellon ----- 
----- npcselectdialog.ies | ClassName: JOB_2_HUNTER_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_HUNTER_3_1 | JOB_2_HUNTER_4_1 | JOB_2_HUNTER_5_1 -----
addnpc(155080, "ETC_20151224_019909", "c_orsha", -1098.89, 177.96, -648.37, 45, "ETC_20151224_019909_Call")
function ETC_20151224_019909_Call()
msg("JOB_2_HUNTER_3_1_select")
msg("JOB_2_HUNTER_3_1_agree")
msg("JOB_2_HUNTER_3_1_progstart")
msg("JOB_2_HUNTER_3_1_succ")
msg("JOB_2_HUNTER_4_1_select")
msg("JOB_2_HUNTER_4_1_agree")
msg("JOB_2_HUNTER_4_1_progstart")
msg("JOB_2_HUNTER_4_1_succ")
msg("JOB_2_HUNTER_5_1_select")
msg("JOB_2_HUNTER_5_1_agree")
msg("JOB_2_HUNTER_5_1_progstart")
msg("JOB_2_HUNTER_5_1_succ")
msg("JOB_2_HUNTER_MASTER_basic1")
msg("JOB_2_HUNTER_MASTER_basic2")
end

----- [Wugushi Master]Wor Pat ----- 
----- npcselectdialog.ies | ClassName: JOB_2_WUGUSHI_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_WUGUSHI_4_1 | JOB_2_WUGUSHI_5_1 | JOB_2_WUGUSHI_6_1 -----
addnpc(57233, "ETC_20151224_019910", "c_orsha", -89.38, 177.22, -755.54, -45, "ETC_20151224_019910_Call")
function ETC_20151224_019910_Call()
msg("JOB_2_WUGUSHI_4_1_select")
msg("JOB_2_WUGUSHI_4_1_agree")
msg("JOB_2_WUGUSHI_4_1_progstart")
msg("JOB_2_WUGUSHI_4_1_succ")
msg("JOB_2_WUGUSHI_5_1_select")
msg("JOB_2_WUGUSHI_5_1_agree")
msg("JOB_2_WUGUSHI_5_1_progstart")
msg("JOB_2_WUGUSHI_5_1_succ")
msg("JOB_2_WUGUSHI_6_1_select")
msg("JOB_2_WUGUSHI_6_1_agree")
msg("JOB_2_WUGUSHI_6_1_progstart")
msg("JOB_2_WUGUSHI_6_1_succ")
msg("JOB_2_WUGUSHI_MASTER_basic1")
msg("JOB_2_WUGUSHI_MASTER_basic2")
end

----- [Scout Submaster]Suina ----- 
----- npcselectdialog.ies | ClassName: JOB_2_SCOUT_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_2_SCOUT_4_1 | JOB_2_SCOUT_5_1 | JOB_2_SCOUT_6_1 -----
addnpc(155082, "ETC_20151224_019911", "c_orsha", -967.44, 177.67, -562.9, -45, "ETC_20151224_019911_Call")
function ETC_20151224_019911_Call()
msg("JOB_2_SCOUT_4_1_select")
msg("JOB_2_SCOUT_4_1_agree")
msg("JOB_2_SCOUT_4_1_progstart")
msg("JOB_2_SCOUT_4_1_succ")
msg("JOB_2_SCOUT_5_1_select")
msg("JOB_2_SCOUT_5_1_agree")
msg("JOB_2_SCOUT_5_1_progstart")
msg("JOB_2_SCOUT_5_1_succ")
msg("JOB_2_SCOUT_6_1_select")
msg("JOB_2_SCOUT_6_1_agree")
msg("JOB_2_SCOUT_6_1_progstart")
msg("JOB_2_SCOUT_6_1_succ")
msg("JOB_2_SCOUT_MASTER_basic1")
msg("JOB_2_SCOUT_MASTER_basic2")
end

----- [Companion Trader]Toras ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(20058, "ETC_20151224_019912", "c_orsha", -109.365, 176.2911, 362.765, 59, "ETC_20151224_019912_Call")
function ETC_20151224_019912_Call()
msg("ORSHA_PETSHOP")
end

----- Velheider ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47521, "ETC_20150317_007299", "c_orsha", -126.3985, 176.3578, 394.7018, 50, "ETC_20150317_007299_Call")
function ETC_20150317_007299_Call()
msg("PETSHOP_KLAIPE_PET")
end

----- [Market Manager] Tilliana ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Enter | Dialog -----
addnpc(156008, "ETC_20151224_019913", "c_orsha", 213.9646, 175.8581, -12.91508, -41, "ETC_20151224_019913_Call")
function ETC_20151224_019913_Call()
msg("TUTO_MARKET_NPC")
msg("ORSHA_MARKET_SEL")
end

----- [Storage Keeper]Aisa ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Enter | Dialog -----
addnpc(20067, "ETC_20151224_019914", "c_orsha", 320.2166, 175.8852, 69.16746, 45, "ETC_20151224_019914_Call")
function ETC_20151224_019914_Call()
msg("TUTO_STORAGE_NPC")
msg("ORSHA_WAREHOUSE_DLG")
end

----- [Orsha's Magic Association] Florianna ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(155102, "ETC_20151224_019915", "c_orsha", -985.9471, 500.6083, 415.8152, 45, "ETC_20151224_019915_Call")
function ETC_20151224_019915_Call()
msg("ORSHA_COLLECTION_SHOP_basic01")
end

----- [Wings of Vaivora]Rosia ----- 
----- npcselectdialog.ies | ClassName: ORSHA_JOURNEY_SHOP -----
----- Enter | Dialog -----
addnpc(155103, "ETC_20151224_019916", "c_orsha", -451.5142, 324.6042, -89.63361, 45, "ETC_20151224_019916_Call")
function ETC_20151224_019916_Call()
msg("TUTO_JOURNAL_NPC")
msg("ORSHA_JOURNEY_SHOP_NORMAL2_SELECT1")
msg("ORSHA_JOURNEY_SHOP_NORMAL2_NULL1")
msg("ORSHA_JOURNEY_SHOP_NORMAL3_SELECT1")
msg("ORSHA_JOURNEY_SHOP_NORMAL3_NULL1")
msg("ORSHA_JOURNEY_SHOP_basic01")
end

----- [TP Trader] Leticia ----- 
----- npcselectdialog.ies | ClassName: TP_NPC -----
----- Enter | Dialog -----
addnpc(20068, "ETC_20151224_019887", "c_orsha", 41, 176, -14, 45, "ETC_20151224_019887_Call")
function ETC_20151224_019887_Call()
msg("TUTO_TPSHOP_NPC")
msg("TP_NPC_basic01")
msg("TP_NPC_basic02")
end

----- Girl Settler ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(20062, "QUEST_20151224_003174", "c_orsha", -42, 176, 207, 45, "QUEST_20151224_003174_Call")
function QUEST_20151224_003174_Call()
msg("ORSHA_NPC01_basic01")
msg("ORSHA_NPC01_SEL02")
end

----- Young Settler ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(20064, "QUEST_20151224_003189", "c_orsha", -203, 176, 537, 45, "QUEST_20151224_003189_Call")
function QUEST_20151224_003189_Call()
msg("ORSHA_NPC02_basic01")
msg("ORSHA_NPC02_SEL02")
msg("ORSHA_NPC02_SEL01")
end

