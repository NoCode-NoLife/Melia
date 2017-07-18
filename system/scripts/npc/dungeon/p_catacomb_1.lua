----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "p_catacomb_1", 64, 260, 9, -15, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_P_CATACOMB_1")
end

----- Board1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000566", "p_catacomb_1", -3, 268, 1063, 45, "npc_QUEST_20150317_000566")
function npc_QUEST_20150317_000566()
msg("UPPER_WARNING_P_CATACOMB_1")
end

----- npc_NEC_master ----- 
----- npcselectdialog.ies | ClassName: JOB_NECRO4_NPC -----
----- Dialog -----
----- QuestIDs: JOB_NECROMANCER5_1 | JOB_NECROMANCER_6_1 | JOB_NECROMANCER7_1 | LOWLV_MASTER_ENCY_SQ_50 -----
addnpc(147446, "ETC_20150729_014031", "p_catacomb_1", 193, 260, 83, -45, "npc_ETC_20150729_014031")
function npc_ETC_20150729_014031()
msg("JOB_NECROMANCER3_1_select1")
msg("JOB_NECROMANCER3_1_agree1")
msg("JOB_NECROMANCER3_1_succ1")
msg("JOB_NECROMANCER4_1_ST")
msg("JOB_NECROMANCER4_1_AG")
msg("JOB_NECROMANCER4_1_AC")
msg("JOB_NECROMANCER4_1_COMP")
msg("JOB_NECRO4_NPC_basic01")
msg("JOB_NECRO4_NPCbasic02")
msg("JOB_SORCERER_6_1_NECRO_dlg")
msg("JOB_NECROMANCER_6_1_select")
msg("JOB_NECROMANCER_6_1_agree")
msg("JOB_NECROMANCER_6_1_succ")
msg("JOB_NECROMANCER7_1_START1")
msg("JOB_NECROMANCER7_1_ADD")
msg("JOB_NECROMANCER7_1_PROG1")
msg("JOB_NECROMANCER7_1_SUCC1")
msg("JOB_NECROMANCER3_1_NPC_basic01")
msg("LOWLV_MASTER_ENCY_SQ_50_ST")
msg("LOWLV_MASTER_ENCY_SQ_50_AG")
msg("LOWLV_MASTER_ENCY_SQ_50_STD")
msg("LOWLV_MASTER_ENCY_SQ_50_SU")
msg("LOWLV_MASTER_ENCY_SQ_50_DIALOG")
end

