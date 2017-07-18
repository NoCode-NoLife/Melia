----- magicsquare_1 ----- 
addnpc(47121, "ETC_20151224_019929", "d_underfortress_68_1", -839, 137, 922, 45, "npc_dummy")

----- magicsquare_1 ----- 
addnpc(47121, "ETC_20151224_019930", "d_underfortress_68_1", -809, 489, -895, 45, "npc_dummy")

----- Huevillage_Altar ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147417, "ETC_20151224_019932", "d_underfortress_68_1", 1071, 489, -1117, 43, "npc_ETC_20151224_019932")
function npc_ETC_20151224_019932()
msg("UNDERFORTRESS_68_1_ALTER")
end

----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "d_underfortress_68_1", -1379, 227, 224, -45, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_D_UNDERFORTRESS_68_1")
end

----- treasure_box4 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147394, "ETC_20151224_019931", "d_underfortress_68_1", 1002, 342, 1728, 3, "npc_ETC_20151224_019931")
function npc_ETC_20151224_019931()
msg("UNDERFORTRESS_68_1_DAILY_BOX")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "d_underfortress_68_1", -519, 168, 720, 225, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

