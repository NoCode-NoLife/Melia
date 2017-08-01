----- npc_zanas ----- 
----- npcselectdialog.ies | ClassName: PRISON_80_NPC_1 -----
----- Dialog -----
----- QuestIDs: PRISON_80_MQ_1 | PRISON_80_MQ_2 | PRISON_80_MQ_3 | PRISON_80_MQ_4 | PRISON_80_MQ_5 -----
addnpc(151107, "ETC_20160723_022699", "d_prison_80", 959, 334, -907, -45, "npc_ETC_20160723_022699")
function npc_ETC_20160723_022699()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- npc_zanas ----- 
----- npcselectdialog.ies | ClassName: PRISON_80_NPC_2 -----
----- Dialog -----
----- QuestIDs: PRISON_80_MQ_7 | PRISON_80_MQ_8 | PRISON_80_MQ_9 -----
addnpc(151107, "ETC_20160723_022699", "d_prison_80", -225, 290, 430, 0, "npc_ETC_20160723_022699")
function npc_ETC_20160723_022699()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- noshadow_npc ----- 
----- npcselectdialog.ies | ClassName: PRISON_80_MQ_10_TRIGGER -----
----- Enter | Dialog -----
----- QuestIDs: PRISON_80_MQ_10 | PRISON_80_MQ_10 -----
addnpc(147469, "ETC_20150317_009354", "d_prison_80", -863, 156, -330, 45, "npc_ETC_20150317_009354")
function npc_ETC_20150317_009354()
msg("GM_NPC_HIDE_UNHIDE")
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
end

----- boxes_02 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(151030, "ETC_20160811_024108", "d_prison_80", -666, 290, 65, 0, "npc_ETC_20160811_024108")
function npc_ETC_20160811_024108()
msg("PRISON_80_SQ_OBJ_2")
end

