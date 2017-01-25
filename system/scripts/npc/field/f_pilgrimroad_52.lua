----- Great Merchant Gilliam ----- 
addnpc(20154, "QUEST_20150317_001050", "f_pilgrimroad_52", 205, 214, 553, 70, "npc_dummy")

----- Pilgrim Theophilis ----- 
----- npcselectdialog.ies | ClassName: PILGRIM52_NPC01 -----
----- Dialog -----
----- QuestIDs: PILGRIM52_SQ_010 | PILGRIM52_SQ_011 | PILGRIM52_SQ_020 | PILGRIM52_SQ_030 | PILGRIM52_SQ_040 | PILGRIM52_SQ_091 -----
addnpc(155037, "QUEST_LV_0200_20150317_000601", "f_pilgrimroad_52", -993.1726, 139.4656, -2016.412, 45, "QUEST_LV_0200_20150317_000601_Call")
function QUEST_LV_0200_20150317_000601_Call()
msg("PILGRIM52_NPC01_BASIC01")
msg("PILGRIM52_NPC01_BASIC02")
msg("PILGRIM52_NPC01_BASIC03")
msg("PILGRIM52_NPC01_BASIC05")
msg("PILGRIM52_NPC01_BASIC06")
end

----- Pilgrim Witas ----- 
----- npcselectdialog.ies | ClassName: PILGRIM52_NPC02 -----
----- Dialog -----
----- QuestIDs: PILGRIM52_SQ_040 | PILGRIM52_SQ_050 | PILGRIM52_SQ_051 -----
addnpc(155038, "QUEST_LV_0200_20150317_000634", "f_pilgrimroad_52", -481.6351, 215.1778, 392.3651, 50, "QUEST_LV_0200_20150317_000634_Call")
function QUEST_LV_0200_20150317_000634_Call()
msg("PILGRIM52_NPC02_BASIC01")
msg("PILGRIM52_NPC02_BASIC02")
end

----- Tombstone ----- 
----- npcselectdialog.ies | ClassName: PILGRIM52_TOMB01 -----
----- Dialog -----
----- QuestIDs: PILGRIM52_SQ_060 -----
addnpc(152009, "ETC_20150317_005254", "f_pilgrimroad_52", -1336.022, 156.583, -22.18338, -33, "npc_dummy")

----- Tombstone ----- 
addnpc(152009, "ETC_20150317_005254", "f_pilgrimroad_52", -738.9567, 245.719, 1115.345, -33, "npc_dummy")

----- Pond of Silence ----- 
----- npcselectdialog.ies | ClassName: PILGRIM52_SPRING -----
----- Dialog -----
----- QuestIDs: PILGRIM52_SQ_080 | PILGRIM52_SQ_081 -----
addnpc(147469, "QUEST_LV_0200_20150323_003312", "f_pilgrimroad_52", 1129.753, 219.5423, 2197.095, 45, "npc_dummy")

----- Tree of Faith ----- 
----- Enter -----
addnpc(152012, "QUEST_20150323_001474", "f_pilgrimroad_52", 1041.164, 233.8956, 2276.617, -64, "QUEST_20150323_001474_Call")
function QUEST_20150323_001474_Call()
msg("PILGRIM52_TRUTHTREE")
end

----- Pot Settling Area ----- 
addnpc(147469, "ETC_20150317_009416", "f_pilgrimroad_52", 418.0235, 215.1778, 881.3796, 45, "npc_dummy")

----- Pot Settling Area ----- 
addnpc(147469, "ETC_20150317_009416", "f_pilgrimroad_52", 44.73014, 215.1778, 635.6563, 45, "npc_dummy")

----- Pot Settling Area ----- 
addnpc(147469, "ETC_20150317_009416", "f_pilgrimroad_52", 561.8187, 139.8698, -137.3844, 45, "npc_dummy")

----- Warning ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000566", "f_pilgrimroad_52", -555.4303, 245.719, 1933.056, 45, "QUEST_20150317_000566_Call")
function QUEST_20150317_000566_Call()
msg("UPPER_WARNING_F_PILGRIMROAD_52")
end

----- Witas' Grave ----- 
----- Enter -----
addnpc(152009, "ETC_20150317_009417", "f_pilgrimroad_52", -453.0049, 215.1778, 391.303, -55, "ETC_20150317_009417_Call")
function ETC_20150317_009417_Call()
msg("PILGRIM52_NPC_TOMB")
end

----- Tree of Faith ----- 
----- Enter -----
addnpc(152013, "QUEST_20150323_001474", "f_pilgrimroad_52", 1041.164, 233.8956, 2276.617, -39, "QUEST_20150323_001474_Call")
function QUEST_20150323_001474_Call()
msg("PILGRIM52_TRUTHTREE_REAL")
end

----- Tree of Faith Notice ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(152007, "ETC_20150323_010401", "f_pilgrimroad_52", 1146.558, 233.8956, 2065.662, 0, "ETC_20150323_010401_Call")
function ETC_20150323_010401_Call()
msg("PILGRIM52_BOARD01_BASIC01")
end

----- Tree of Brothers Notice ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150323_001477", "f_pilgrimroad_52", 502.5437, 215.1778, 880.9619, -40, "QUEST_20150323_001477_Call")
function QUEST_20150323_001477_Call()
msg("PILGRIM52_BOARD02_BASIC01")
end

----- Tree of Brothers Notice ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150323_001477", "f_pilgrimroad_52", 108.3882, 215.1778, 641.5708, -25, "QUEST_20150323_001477_Call")
function QUEST_20150323_001477_Call()
msg("PILGRIM52_BOARD03_BASIC01")
end

----- Tree of Brothers Notice ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150323_001477", "f_pilgrimroad_52", 545.9645, 139.8698, -81.5094, 45, "QUEST_20150323_001477_Call")
function QUEST_20150323_001477_Call()
msg("PILGRIM52_BOARD04_BASIC01")
end

----- Hidden Treasure Chest ----- 
----- npcselectdialog.ies | ClassName: PILGRIM52_BOX -----
----- Dialog -----
----- QuestIDs: PILGRIM52_SQ_110 -----
addnpc(40030, "ETC_20150428_011591", "f_pilgrimroad_52", 2652.372, 156.583, -374.2712, 45, "npc_dummy")

----- Lv1 Treasure Chest ----- 
addnpc(147392, "ETC_20150317_009100", "f_pilgrimroad_52", 991.91, 234, 1860.75, 45, "npc_dummy")

