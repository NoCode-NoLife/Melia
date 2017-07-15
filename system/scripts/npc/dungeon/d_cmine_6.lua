----- mine_crystal ----- 
----- npcselectdialog.ies | ClassName: CMINE3_BOSSROOM_OPEN -----
----- Dialog -----
----- QuestIDs: ACT4_MINE3_ENTER -----
addnpc(151014, "QUEST_LV_0100_20150317_002501", "d_cmine_6", 129, 184, -112, -41, "npc_QUEST_LV_0100_20150317_002501")
function npc_QUEST_LV_0100_20150317_002501()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_mining_alchemist ----- 
----- npcselectdialog.ies | ClassName: MINE_3_ALCHEMIST -----
----- Dialog -----
----- QuestIDs: MINE_3_RESQUE1 -----
addnpc(20110, "ETC_20150317_009246", "d_cmine_6", -2181, 360, -1677, 45, "npc_ETC_20150317_009246")
function npc_ETC_20150317_009246()
msg("MINE_1_ALCHEMIST_select1")
msg("MINE_1_ALCHEMIST_AG")
msg("MINE_1_ALCHEMIST_PG")
msg("MINE_3_RESQUE1_dlg1")
msg("MINE_3_RESQUE1_dlg2")
msg("MINE_3_RESQUE1_R")
msg("SIAULIAIOUT_ALCHE_A_basic01")
msg("SIAULIAIOUT_ALCHE_A_basic02")
msg("MINE_3_ALCHEMIST_basic1")
msg("MINE_3_ALCHEMIST_basic2")
msg("SOUT_Q_16_1_AC")
msg("SIAULIAIOUT_ALCHE_BASIC01")
msg("SIAULIAIOUT_ALCHE_basic03")
msg("JOB_ALCHEMIST5_1_ST")
msg("JOB_ALCHEMIST5_1_AC")
msg("JOB_ALCHEMIST5_1_PG")
msg("JOB_ALCHEMIST5_1_COMP")
msg("SIAULIAIOUT_ALCHE_A_basic03")
msg("SOUT_Q_14_3")
msg("SOUT_Q_16_1")
msg("SOUT_Q_16_2")
msg("SIAULIAIOUT_ALCHE_basic")
msg("NoneMINE_1_ALCHEMIST_basic")
msg("JOB_ALCHEMIST_6_1_select")
msg("JOB_ALCHEMIST_6_1_agree")
msg("JOB_ALCHEMIST_6_1_succ")
msg("JOB_ALCHEMIST_6_2_select")
msg("JOB_ALCHEMIST_6_2_agree")
msg("JOB_ALCHEMIST_6_2_succ")
msg("JOB_ALCHEMIST7_1_START1")
msg("JOB_ALCHEMIST7_1_AGREE1")
msg("JOB_ALCHEMIST7_1_PROG1")
msg("JOB_ALCHEMIST7_1_SUCC1")
msg("CHAR313_MSTEP7_1_DLG1")
msg("CHAR313_MSTEP9_1_DLG1")
msg("CHAR313_MSTEP9_1_DLG2")
msg("CHAR313_MSTEP9_1_DLG3")
msg("PARTY_Q_010_startnpc01")
msg("PARTY_Q_010_AG")
msg("PARTY_Q_010_prog_startnpc01")
msg("PARTY_Q_010_succ01")
msg("PARTY_Q_011_startnpc01")
msg("PARTY_Q_011_startnpc_prog01")
msg("PARTY_Q_011_succ01")
end

----- mine_miner ----- 
----- npcselectdialog.ies | ClassName: MINE_3_RESIENT1_BIND -----
----- Dialog -----
----- QuestIDs: MINE_3_RESQUE1 -----
addnpc(151009, "QUEST_LV_0100_20150317_000366", "d_cmine_6", -1188, 303, 104, -17, "npc_QUEST_LV_0100_20150317_000366")
function npc_QUEST_LV_0100_20150317_000366()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- mine_Laima ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(151012, "QUEST_LV_0100_20150317_000851", "d_cmine_6", -1207, 303, 87, 27, "npc_QUEST_LV_0100_20150317_000851")
function npc_QUEST_LV_0100_20150317_000851()
msg("MINE_3_GIRL_BIND")
end

----- mine_matron ----- 
----- npcselectdialog.ies | ClassName: D_CMINE_NPC01_BIND -----
----- Dialog -----
addnpc(151010, "QUEST_LV_0100_20150317_000206", "d_cmine_6", -1170, 303, 120, 32, "npc_QUEST_LV_0100_20150317_000206")
function npc_QUEST_LV_0100_20150317_000206()
msg("D_CMINE_NPC01_BIND_basic01")
msg("D_CMINE_NPC01_BIND_basic02")
msg("F_SIAU_OUT_NPC01_basic01")
msg("F_SIAU_OUT_NPC01_basic02")
msg("F_SIAU_OUT_NPC01_basic03")
msg("D_CMINE_NPC01_basic01")
msg("D_CMINE_NPC01_basic02")
end

----- mine_village_female ----- 
----- npcselectdialog.ies | ClassName: D_CMINE_NPC02_BIND -----
----- Dialog -----
addnpc(151011, "QUEST_LV_0100_20150317_000209", "d_cmine_6", -1200, 303, 98, -40, "npc_QUEST_LV_0100_20150317_000209")
function npc_QUEST_LV_0100_20150317_000209()
msg("D_CMINE_NPC02_BIND_basic01")
msg("D_CMINE_NPC02_BIND_basic02")
msg("D_CMINE_NPC02_basic01")
msg("D_CMINE_NPC02_basic02")
msg("F_SIAU_OUT_NPC03_basic01")
msg("F_SIAU_OUT_NPC03_basic02")
msg("F_SIAU_OUT_NPC03_basic03")
end

----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "d_cmine_6", -2176, 360, -1774, 45, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_D_CMINE_6")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "d_cmine_6", -1145, 304, 103, -45, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

----- npc_miner2 ----- 
----- npcselectdialog.ies | ClassName: MINE_3_RESIENT1 -----
----- Dialog -----
----- QuestIDs: MINE_3_RESQUE1 -----
addnpc(20150, "QUEST_LV_0100_20150317_000366", "d_cmine_6", -1188, 303, 104, -17, "npc_QUEST_LV_0100_20150317_000366")
function npc_QUEST_LV_0100_20150317_000366()
msg("MINE_3_RESQUE1_succ")
msg("MINE_3_RESIENT1_BASIC01")
msg("MINE_3_RESIENT1_BASIC02")
msg("F_SIAU_OUT_NPC02_basic01")
msg("F_SIAU_OUT_NPC02_basic02")
end

----- npc_Laima_little ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47236, "QUEST_LV_0100_20150317_000851", "d_cmine_6", -1207, 303, 87, 27, "npc_QUEST_LV_0100_20150317_000851")
function npc_QUEST_LV_0100_20150317_000851()
msg("MINE_3_GIRL1")
end

----- npc_matron ----- 
----- npcselectdialog.ies | ClassName: D_CMINE_NPC01 -----
----- Dialog -----
addnpc(20114, "QUEST_LV_0100_20150317_000206", "d_cmine_6", -1170, 303, 120, 32, "npc_QUEST_LV_0100_20150317_000206")
function npc_QUEST_LV_0100_20150317_000206()
msg("D_CMINE_NPC01_BIND_basic01")
msg("D_CMINE_NPC01_BIND_basic02")
msg("F_SIAU_OUT_NPC01_basic01")
msg("F_SIAU_OUT_NPC01_basic02")
msg("F_SIAU_OUT_NPC01_basic03")
msg("D_CMINE_NPC01_basic01")
msg("D_CMINE_NPC01_basic02")
end

----- npc_village_female ----- 
----- npcselectdialog.ies | ClassName: D_CMINE_NPC02 -----
----- Dialog -----
addnpc(147473, "QUEST_LV_0100_20150317_000209", "d_cmine_6", -1200, 303, 98, -40, "npc_QUEST_LV_0100_20150317_000209")
function npc_QUEST_LV_0100_20150317_000209()
msg("D_CMINE_NPC02_BIND_basic01")
msg("D_CMINE_NPC02_BIND_basic02")
msg("D_CMINE_NPC02_basic01")
msg("D_CMINE_NPC02_basic02")
msg("F_SIAU_OUT_NPC03_basic01")
msg("F_SIAU_OUT_NPC03_basic02")
msg("F_SIAU_OUT_NPC03_basic03")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "d_cmine_6", -875, 184, -970, 45, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

----- mine_purify_01 ----- 
----- npcselectdialog.ies | ClassName: CMINE6_RP_1_NPC -----
----- Dialog -----
----- QuestIDs: CMINE6_RP_1 -----
addnpc(151006, "ETC_20160323_021383", "d_cmine_6", -79, 184, -990, 20, "npc_ETC_20160323_021383")
function npc_ETC_20160323_021383()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

