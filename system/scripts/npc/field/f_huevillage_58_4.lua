----- Master Altar Barrier ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_4_MQ01_NPC01 -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_4_MQ02 -----
addnpc(147469, "ETC_20150317_009353", "f_huevillage_58_4", 43, 33, -343, 45, "npc_dummy")

----- Goddess Saule ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_4_SAULE_BEFORE -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_4_MQ02 | HUEVILLAGE_58_4_MQ05 | HUEVILLAGE_58_4_MQ06 | HUEVILLAGE_58_4_MQ07 | HUEVILLAGE_58_4_MQ08 | HUEVILLAGE_58_4_MQ01 -----
addnpc(147385, "QUEST_LV_0100_20150317_000586", "f_huevillage_58_4", 21.42, 34.2, -186.01, -45, "QUEST_LV_0100_20150317_000586_Call")
function QUEST_LV_0100_20150317_000586_Call()
msg("HUEVILLAGE_58_4_SAULE_BEFORE_basic01")
msg("HUEVILLAGE_58_4_SAULE_BEFORE_basic02")
end

----- Goddess Saule ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_4_SAULE_AFTER -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_4_MQ08 | HUEVILLAGE_58_4_MQ11 | HUEVILLAGE_58_4_MQ09 | PARTY_Q_060 | PARTY_Q_061 -----
addnpc(147385, "QUEST_LV_0100_20150317_000586", "f_huevillage_58_4", 21.42, 34.2, -186.01, -45, "QUEST_LV_0100_20150317_000586_Call")
function QUEST_LV_0100_20150317_000586_Call()
msg("HUEVILLAGE_58_4_SAULE_AFTER_basic01")
msg("HUEVILLAGE_58_4_SAULE_AFTER_basic02")
msg("HUEVILLAGE_58_4_SAULE_AFTER_basic03")
msg("HUEVILLAGE_58_4_SAULE_AFTER_basic06")
end

----- Binding Magic Circle ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_4_MQ03_NPC01 -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_4_MQ03 -----
addnpc(147417, "ETC_20150317_005169", "f_huevillage_58_4", -879, 107, -737, 46, "npc_dummy")

----- Binding Magic Circle ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_4_MQ04_NPC01 -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_4_MQ04 -----
addnpc(147417, "ETC_20150317_005169", "f_huevillage_58_4", 426, -6, 705, 45, "npc_dummy")

----- Demon Barrier ----- 
----- npcselectdialog.ies | ClassName: HUEVILLAGE_58_4_MQ07_NPC01 -----
----- Dialog -----
----- QuestIDs: HUEVILLAGE_58_4_MQ07 -----
addnpc(147372, "ETC_20150317_009354", "f_huevillage_58_4", 1296, -22, -245, 45, "npc_dummy")

----- Portal ----- 
addnpc(147469, "ETC_20150317_005172", "f_huevillage_58_4", 28, 34, -189, 45, "npc_dummy")

----- Statue ----- 
----- Enter -----
addnpc(147388, "ETC_20150317_007035", "f_huevillage_58_4", 107.03, 34.2, -203.09, -133, "ETC_20150317_007035_Call")
function ETC_20150317_007035_Call()
msg("HUEVILLAGE_58_4_MQ01_STONE_STATUE01")
end

----- Statue ----- 
----- Enter -----
addnpc(147387, "ETC_20150317_007035", "f_huevillage_58_4", -53.26, 34.2, -201.09, 53, "ETC_20150317_007035_Call")
function ETC_20150317_007035_Call()
msg("HUEVILLAGE_58_4_MQ01_STONE_STATUE02")
end

----- Thorny Bushes ----- 
----- Enter -----
addnpc(153058, "ETC_20150714_013167", "f_huevillage_58_4", 892.6094, -23.269, 748.9606, 45, "ETC_20150714_013167_Call")
function ETC_20150714_013167_Call()
msg("PARTY_Q06_THORN02")
end

----- Thorny Bushes ----- 
----- Enter -----
addnpc(153039, "ETC_20150714_013167", "f_huevillage_58_4", 1062.716, -23.269, 721.4708, 45, "ETC_20150714_013167_Call")
function ETC_20150714_013167_Call()
msg("PARTY_Q06_THORN02")
end

----- Thorny Bushes ----- 
----- Enter -----
addnpc(153039, "ETC_20150714_013167", "f_huevillage_58_4", 1012.862, -23.269, 925.1455, 45, "ETC_20150714_013167_Call")
function ETC_20150714_013167_Call()
msg("PARTY_Q06_THORN02")
end

----- Thorny Bushes ----- 
----- Enter -----
addnpc(153039, "ETC_20150714_013167", "f_huevillage_58_4", 891.3076, -23.269, 868.3448, 45, "ETC_20150714_013167_Call")
function ETC_20150714_013167_Call()
msg("PARTY_Q06_THORN02")
end

----- Thorny Bushes ----- 
----- Enter -----
addnpc(153058, "ETC_20150714_013167", "f_huevillage_58_4", 1104.504, -23.269, 846.5443, 45, "ETC_20150714_013167_Call")
function ETC_20150714_013167_Call()
msg("PARTY_Q06_THORN02")
end

----- Statue of Goddess Vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "f_huevillage_58_4", 20.74365, -8.675209, -837.3439, 45, "npc_dummy")

----- Lv1 Treasure Chest ----- 
addnpc(147392, "ETC_20150317_009100", "f_huevillage_58_4", 240, -8.58, -735, 225, "npc_dummy")

