----- npc_wife_1 ----- 
----- npcselectdialog.ies | ClassName: FARM47_JOANA -----
----- Dialog -----
----- QuestIDs: FARM47_2_SQ_010 | FARM47_2_SQ_020 | FARM47_2_SQ_040 | FARM47_2_SQ_050 | FARM47_2_SQ_060 | FARM47_2_SQ_080 | FARM47_2_SQ_045 -----
addnpc(152001, "QUEST_LV_0200_20150323_003457", "f_farm_47_2", -90, 40, 150, 45, "npc_QUEST_LV_0200_20150323_003457")
function npc_QUEST_LV_0200_20150323_003457()
msg("FARM47_JOANA_BASIC02")
msg("FARM47_JOANA_BASIC03")
msg("FARM47_2_SQ_050_ST")
msg("FARM47_2_SQ_050_ADD")
msg("FARM47_2_SQ_050_AC")
msg("FARM47_2_SQ_050_PRST")
msg("FARM47_2_SQ_050_COMP")
msg("FARM47_2_SQ_060_ADD")
msg("FARM47_2_SQ_060_AC")
msg("FARM47_2_SQ_060_PRST")
msg("FARM47_2_SQ_060_COMP")
msg("FARM47_2_SQ_080_PR")
msg("FARM47_2_SQ_080_COMP")
msg("FARM47_2_SQ_060_ST")
msg("FARM47_JOANA_BASIC01")
msg("FARM47_2_SQ_045_ST")
msg("FARM47_2_SQ_045_COMP")
end

----- npc_husband_1 ----- 
----- npcselectdialog.ies | ClassName: FARM47_JONARIS -----
----- Dialog -----
----- QuestIDs: FARM47_2_SQ_080 | FARM47_2_SQ_070 | FARM47_2_SQ_081 -----
addnpc(152000, "QUEST_LV_0200_20150406_006264", "f_farm_47_2", 39, 1, 1244, 45, "npc_QUEST_LV_0200_20150406_006264")
function npc_QUEST_LV_0200_20150406_006264()
msg("FARM47_JONARIS_BASIC02")
msg("FARM47_2_SQ_070_ST")
msg("FARM47_2_SQ_070_ADD")
msg("FARM47_2_SQ_070_AC")
msg("FARM47_2_SQ_070_PRST")
msg("FARM47_2_SQ_070_COMP")
msg("FARM47_2_SQ_080_ST")
msg("FARM47_2_SQ_080_ADD")
msg("FARM47_2_SQ_080_AC")
msg("FARM47_2_SQ_080_PR_PRST")
msg("FARM47_2_SQ_081_COMP")
msg("FARM47_2_SQ_080_STN")
msg("FARM47_JONARIS_BASIC01")
end

----- npc_village_uncle_1 ----- 
----- npcselectdialog.ies | ClassName: FARM47_DZIUGAS -----
----- Dialog -----
----- QuestIDs: FARM47_2_SQ_090 -----
addnpc(20117, "QUEST_LV_0200_20150323_003565", "f_farm_47_2", 1409, 1, 1970, -47, "npc_QUEST_LV_0200_20150323_003565")
function npc_QUEST_LV_0200_20150323_003565()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- farm47_goddess_head_01 ----- 
----- npcselectdialog.ies | ClassName: FARM47_HEAD_D -----
----- Enter | Dialog -----
----- QuestIDs: FARM47_2_SQ_010 -----
addnpc(153050, "ETC_20150414_010968", "f_farm_47_2", 2102, 222, -1035, 45, "npc_ETC_20150414_010968")
function npc_ETC_20150414_010968()
msg("FARM47_HEAD_E")
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- farm47_wing_01 ----- 
----- npcselectdialog.ies | ClassName: FARM47_WING_D -----
----- Enter | Dialog -----
----- QuestIDs: FARM47_2_SQ_040 -----
addnpc(153049, "ETC_20150414_010967", "f_farm_47_2", -58, -92, -1763, 45, "npc_ETC_20150414_010967")
function npc_ETC_20150414_010967()
msg("FARM47_WING_E")
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- farm47_circle_02 ----- 
addnpc(153048, "ETC_20150414_011208", "f_farm_47_2", -14, -72, -487, 45, "npc_dummy")

----- dialog_warp_npc_1 ----- 
----- npcselectdialog.ies | ClassName: FARM_47_2_TO_VELNIASP511 -----
----- Dialog -----
----- QuestIDs: CATHEDRAL_TO_VELNIASPRISON -----
addnpc(154069, "ETC_20150323_009630", "f_farm_47_2", -1616, 0, -1192, 45, "npc_ETC_20150323_009630")
function npc_ETC_20150323_009630()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_velniasp_mage ----- 
----- npcselectdialog.ies | ClassName: VELNIASP511_PORTAL_MAGE -----
----- Dialog -----
----- QuestIDs: VPRISON511_MQ_PRE_01 -----
addnpc(154002, "ETC_20150323_010369", "f_farm_47_2", -1581, 1, -1259, 150, "npc_ETC_20150323_010369")
function npc_ETC_20150323_010369()
msg("VPRISON511_MQ_PRE_01_01")
msg("VELNIASP511_PORTAL_MAGE_basic_1")
msg("VELNIASP511_PORTAL_MAGE_01")
end

----- npc_hauberk ----- 
----- npcselectdialog.ies | ClassName: VELNIASP511_PORTAL_HAUBERK -----
----- Dialog -----
----- QuestIDs: VPRISON511_MQ_PRE_01 | VPRISON511_MQ_PRE_02 -----
addnpc(57840, "QUEST_20150323_001573", "f_farm_47_2", -1581, 1, -1259, 90, "npc_QUEST_20150323_001573")
function npc_QUEST_20150323_001573()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- BOOK_01 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147311, "QUEST_LV_0200_20150414_006606", "f_farm_47_2", -1141, 0, -1268, 45, "npc_QUEST_LV_0200_20150414_006606")
function npc_QUEST_LV_0200_20150414_006606()
msg("FARM47_2_DIARY")
end

----- LOST_PAPER ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147312, "QUEST_20150428_001968", "f_farm_47_2", -1351, 0, -1162, 45, "npc_QUEST_20150428_001968")
function npc_QUEST_20150428_001968()
msg("VPRISON_PAPER02")
end

----- magicsquare_1 ----- 
----- npcselectdialog.ies | ClassName: PARTY_Q9_TRIGGER -----
----- Dialog -----
----- QuestIDs: PARTY_Q_090 -----
addnpc(47121, "QUEST_LV_0100_20150317_003179", "f_farm_47_2", 191, -92, -1888, -87, "npc_QUEST_LV_0100_20150317_003179")
function npc_QUEST_LV_0100_20150317_003179()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "f_farm_47_2", 1364, -116, -57, 45, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

