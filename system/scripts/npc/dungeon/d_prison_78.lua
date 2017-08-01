----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "d_prison_78", 1242, 742, -770, -45, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_D_PRISON_78")
end

----- noshadow_npc ----- 
----- npcselectdialog.ies | ClassName: PRISON_78_OBJ_1 -----
----- Dialog -----
----- QuestIDs: PRISON_78_MQ_1 | PRISON_78_MQ_2 | PRISON_78_MQ_6 | PRISON_78_MQ_7 | PRISON_78_MQ_8 | PRISON_79_MQ_1 | PRISON_80_MQ_4 | PRISON_80_MQ_7 | PRISON_80_MQ_10 | PRISON_81_MQ_4 | PRISON_82_MQ_3 | PRISON_82_MQ_4 | PRISON_82_MQ_6 | PRISON_82_MQ_8 -----
addnpc(147469, "ETC_20160811_024104", "d_prison_78", 1145, 742, -938, 45, "npc_ETC_20160811_024104")
function npc_ETC_20160811_024104()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_zanas ----- 
----- npcselectdialog.ies | ClassName: PRISON_78_NPC_1 -----
----- Dialog -----
----- QuestIDs: PRISON_78_MQ_1 | PRISON_78_MQ_2 | PRISON_78_MQ_3 | PRISON_78_MQ_4 | PRISON_78_MQ_5 -----
addnpc(151107, "ETC_20160723_022699", "d_prison_78", 412, 619, -1282, -45, "npc_ETC_20160723_022699")
function npc_ETC_20160723_022699()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- noshadow_npc ----- 
----- Enter -----
----- QuestIDs: PRISON_78_MQ_9 -----
addnpc(147469, "ETC_20150317_009354", "d_prison_78", -166, 620, 2156, 45, "npc_ETC_20150317_009354")
function npc_ETC_20150317_009354()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

