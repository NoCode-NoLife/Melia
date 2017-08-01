----- npc_cathedral_device_02 ----- 
addnpc(153018, "ETC_20151224_019919", "d_castle_67_1", 397, 234, -1035, 0, "npc_dummy")

----- npc_cathedral_device_02 ----- 
addnpc(153018, "ETC_20151224_019919", "d_castle_67_1", 441, 235, 55, 0, "npc_dummy")

----- npc_cathedral_device_02 ----- 
addnpc(153018, "ETC_20151224_019919", "d_castle_67_1", 1441, 235, -1036, 0, "npc_dummy")

----- npc_cathedral_device_02 ----- 
addnpc(153018, "ETC_20151224_019919", "d_castle_67_1", 1432, 232, 43, 0, "npc_dummy")

----- npc_zacharial_desk2 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(151052, "ETC_20151224_019920", "d_castle_67_1", -978, 143, 535, 45, "npc_ETC_20151224_019920")
function npc_ETC_20151224_019920()
msg("FD_CASTLE671_BOOK")
end

----- npc_zacharial_desk2 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(151052, "ETC_20151224_019920", "d_castle_67_1", -840, 143, 666, -45, "npc_ETC_20151224_019920")
function npc_ETC_20151224_019920()
msg("FD_CASTLE671_BOOK")
end

----- npc_zacharial_desk2 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(151052, "ETC_20151224_019920", "d_castle_67_1", -844, 143, 396, 135, "npc_ETC_20151224_019920")
function npc_ETC_20151224_019920()
msg("FD_CASTLE671_BOOK")
end

----- npc_zacharial_desk2 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(151052, "ETC_20151224_019920", "d_castle_67_1", -704, 143, 543, 225, "npc_ETC_20151224_019920")
function npc_ETC_20151224_019920()
msg("FD_CASTLE671_BOOK")
end

----- statue_vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "d_castle_67_1", -1654, 0, -1192, 0, "npc_QUEST_20150317_000002")
function npc_QUEST_20150317_000002()
msg("GM_QUEST_MODIFY_PC_SEL")
msg("GM_NPC_HIDE_UNHIDE")
msg("WARP_D_CASTLE_67_1")
end

----- treasure_box1 ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147392, "ETC_20150317_009100", "d_castle_67_1", -1387, 56, -270, 45, "npc_ETC_20150317_009100")
function npc_ETC_20150317_009100()
msg("TREASUREBOX_LV")
end

