----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "p_cathedral_1", 430, 0, -447, 225, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_P_CATHEDRAL_1")
end

----- Board1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000566", "p_cathedral_1", 10, 0, 295, 45, "npc_QUEST_20150317_000566")
function npc_QUEST_20150317_000566()
msg("UPPER_WARNING_P_CATHEDRAL_1")
end

----- npc_MIKO_master ----- 
----- npcselectdialog.ies | ClassName: MIKO_MASTER -----
----- Dialog -----
----- QuestIDs: JOB_MIKO_6_1 | CATHEDRAL1_HQ1 -----
addnpc(153173, "ETC_20161005_025536", "p_cathedral_1", 581, 0, -320, -45, "npc_ETC_20161005_025536")
function npc_ETC_20161005_025536()
msg("HIDDEN_MIKO_MASTER_dlg1")
msg("MIKO_MASTER_Miko_YES")
msg("MIKO_MASTER_Miko_NO_1")
msg("MIKO_MASTER_Miko_NO_2")
msg("MIKO_MASTER_basic1")
msg("MIKO_MASTER_basic2")
msg("JOB_MIKO_6_1_select")
msg("JOB_MIKO_6_1_agree")
msg("JOB_MIKO_6_1_prog_start")
msg("JOB_MIKO_6_1_succ")
msg("HIDDEN_MIKO_MASTER_dlg2")
msg("CATHEDRAL1_HIDDEN_NPC_DLG4")
msg("CATHEDRAL1_HIDDEN_NPC_DLG5")
msg("CATHEDRAL1_HQ1_start1")
msg("CATHEDRAL1_HQ1_agree1")
msg("CATHEDRAL1_HQ1_agree2")
msg("CATHEDRAL1_HQ1_prog1")
msg("CATHEDRAL1_HQ1_succ1")
end

----- noshadow_npc_8 ----- 
----- npcselectdialog.ies | ClassName: MIKO_SOUL_SPIRIT -----
----- Dialog -----
addnpc(151018, "QUEST_20161005_004420", "p_cathedral_1", 542, 0, -321, 45, "npc_QUEST_20161005_004420")
function npc_QUEST_20161005_004420()
msg("HIDDEN_MIKO_VPRISON_WEEK_dlg1")
msg("HIDDEN_MIKO_VPRISON_WEEK_dlg2")
msg("HIDDEN_MIKO_CMINE_6_dlg1")
msg("MIKO_SPIRIT_dlg1")
msg("MIKO_SPIRIT_dlg2")
end

