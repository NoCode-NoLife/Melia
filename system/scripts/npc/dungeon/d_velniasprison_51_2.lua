----- npc_kupole_6 ----- 
----- npcselectdialog.ies | ClassName: VPRISON512_MQ_NORGAILE -----
----- Dialog -----
----- QuestIDs: VPRISON512_MQ_01 | VPRISON512_MQ_02 | VPRISON512_MQ_03 | VPRISON512_MQ_04 | VPRISON512_MQ_05 | VPRISON512_SQ_01 | VPRISON512_SQ_02 -----
addnpc(154016, "QUEST_LV_0200_20150414_006634", "d_velniasprison_51_2", -93, 254, 554, -45, "npc_QUEST_LV_0200_20150414_006634")
function npc_QUEST_LV_0200_20150414_006634()
msg("VPRISON512_MQ_01_01")
msg("VPRISON512_MQ_01_AG")
msg("VPRISON512_MQ_01_02")
msg("VPRISON512_MQ_01_03")
msg("VPRISON512_MQ_02_01")
msg("VPRISON512_MQ_02_AG")
msg("VPRISON512_MQ_02_02")
msg("VPRISON512_MQ_02_03")
msg("VPRISON512_MQ_03_01")
msg("VPRISON512_MQ_03_AG")
msg("VPRISON512_MQ_03_02")
msg("VPRISON512_MQ_03_03")
msg("VPRISON512_MQ_04_01")
msg("VPRISON512_MQ_04_add")
msg("VPRISON512_MQ_04_02")
msg("VPRISON512_MQ_04_03")
msg("VPRISON512_SQ_01_01")
msg("VPRISON512_SQ_01_02")
msg("VPRISON512_SQ_01_03")
msg("VPRISON512_SQ_02_01")
msg("VPRISON512_SQ_02_AG")
msg("VPRISON512_SQ_02_02")
msg("VPRISON512_SQ_02_03")
msg("VPRISON512_MQ_05_01")
msg("VPRISON512_MQ_05_02")
msg("VPRISON512_MQ_05_03")
msg("VPRISON512_MQ_NORGAILE_basic_2")
msg("VPRISON512_MQ_NORGAILE_basic_4")
msg("VPRISON512_MQ_NORGAILE_basic_3")
msg("VPRISON512_MQ_NORGAILE_basic_1")
end

----- npc_kupole_4 ----- 
----- npcselectdialog.ies | ClassName: VPRISON512_MQ_ALDONA -----
----- Dialog -----
----- QuestIDs: VPRISON512_MQ_05 -----
addnpc(154014, "ETC_20150317_009293", "d_velniasprison_51_2", 990, 254, -58, 45, "npc_ETC_20150317_009293")
function npc_ETC_20150317_009293()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- velniasprison_warp ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(154000, "ETC_20150323_009630", "d_velniasprison_51_2", 1123, 297, 1884, 45, "npc_ETC_20150323_009630")
function npc_ETC_20150323_009630()
msg("VELNIASP512_TO_VELNIASP511")
end

----- velniasprison_warp ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(154000, "ETC_20150323_009633", "d_velniasprison_51_2", 1458, 183, 429, 45, "npc_ETC_20150323_009633")
function npc_ETC_20150323_009633()
msg("VELNIASP512_TO_VELNIASP513")
end

----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "d_velniasprison_51_2", 1042, 297, 1709, 15, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_D_VPRISON_51_2")
end

----- stontablet_down_2 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147464, "QUEST_20150414_001809", "d_velniasprison_51_2", 1046, 297, 1676, 45, "npc_QUEST_20150414_001809")
function npc_QUEST_20150414_001809()
msg("VPRISON512_STONE_01_DLG1")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "d_velniasprison_51_2", -972, 396, -460, 45, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

