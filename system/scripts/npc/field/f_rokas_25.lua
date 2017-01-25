----- Sanctum's First Seal ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_SWITCH1 -----
----- Enter | Dialog -----
----- QuestIDs: ROKAS25_REXIPHER1_SEAL1 | ROKAS25_REXIPHER1_SEAL1 -----
addnpc(47102, "ETC_20150317_005281", "f_rokas_25", -1941, 511, 912, 8, "npc_dummy")

----- 1st Disciple of Gustas ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_REXIPHER2 -----
----- Dialog -----
----- QuestIDs: ROKAS25_REXIPHER1 -----
addnpc(20118, "ETC_20150317_009445", "f_rokas_25", -2300, 268, -421, 8, "ETC_20150317_009445_Call")
function ETC_20150317_009445_Call()
msg("ROKAS25_REXIPHER2_select1")
msg("ROKAS_24_REXIPHER_basic1")
msg("ROKAS_24_REXIPHER_basic2")
end

----- 2nd Disciple of Gustas ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_REXIPHER3 -----
----- Dialog -----
----- QuestIDs: ROKAS25_REXIPHER4 | ROKAS25_REXIPHER1 -----
addnpc(20139, "ETC_20150317_009446", "f_rokas_25", 441.63, 267.94, 241.4, 8, "ETC_20150317_009446_Call")
function ETC_20150317_009446_Call()
msg("ROKAS_24_REXIPHER3_basic1")
msg("ROKAS_24_REXIPHER3_basic2")
end

----- Sanctum's Second Seal ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_SWITCH3 -----
----- Enter | Dialog -----
----- QuestIDs: ROKAS25_REXIPHER4_SEAL1 | ROKAS25_REXIPHER4_SEAL1 -----
addnpc(47102, "ETC_20150317_005283", "f_rokas_25", 1080, 164, -200, 8, "npc_dummy")

----- Mercenary Toby ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_SUB1 -----
----- Dialog -----
----- QuestIDs: ROKAS25_EX1 | ROKAS25_EX2 -----
addnpc(20117, "ETC_20150317_005290", "f_rokas_25", -1964, 268, -469, -45, "ETC_20150317_005290_Call")
function ETC_20150317_005290_Call()
msg("ROKAS25_SUB1_basic1")
msg("ROKAS25_SUB1_after1")
end

----- Device ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_SWITCH4 -----
----- Enter | Dialog -----
addnpc(47102, "ETC_20150317_009447", "f_rokas_25", 2096, 189, 393, 8, "npc_dummy")

----- Sanctum's Third Seal ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_SWITCH5 -----
----- Dialog -----
----- QuestIDs: ROKAS25_REXIPHER6_SEAL1 -----
addnpc(47102, "ETC_20150317_005285", "f_rokas_25", 1612, 71, -1072, 8, "npc_dummy")

----- Device ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_SWITCH6 -----
----- Dialog -----
addnpc(47102, "ETC_20150317_009447", "f_rokas_25", 2513, 71, -1065, 8, "npc_dummy")

----- Molding Pot ----- 
addnpc(40064, "ETC_20150317_005289", "f_rokas_25", 205, 267.94, 805, -66, "npc_dummy")

----- Kevin ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_KEBIN -----
----- Dialog -----
----- QuestIDs: ROKAS25_SQ_01 | ROKAS25_SQ_02 -----
addnpc(20150, "QUEST_LV_0100_20150317_001270", "f_rokas_25", -1017, 268, 418, 45, "QUEST_LV_0100_20150317_001270_Call")
function QUEST_LV_0100_20150317_001270_Call()
msg("ROKAS25_KEBIN_BASIC01")
end

----- Vincent ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_BINSENT -----
----- Dialog -----
----- QuestIDs: ROKAS25_SQ_04 | ROKAS25_SQ_BRIDGE2 -----
addnpc(20138, "QUEST_LV_0100_20150317_001756", "f_rokas_25", 190.83, 267.94, 762.95, 45, "QUEST_LV_0100_20150317_001756_Call")
function QUEST_LV_0100_20150317_001756_Call()
msg("ROKAS25_BINSENT_BASIC_01")
msg("ROKAS25_BINSENT_BASIC_02")
end

----- Sculptor Hilda ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_HILDA1 -----
----- Dialog -----
----- QuestIDs: ROKAS25_SQ_06 -----
addnpc(20139, "QUEST_LV_0100_20150317_001272", "f_rokas_25", -1828, 268, -567, -39, "QUEST_LV_0100_20150317_001272_Call")
function QUEST_LV_0100_20150317_001272_Call()
msg("ROKAS25_HILDA1_BASIC01")
end

----- Sculptor Hilda ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_HILDA2 -----
----- Dialog -----
----- QuestIDs: ROKAS25_SQ_07 -----
addnpc(20139, "QUEST_LV_0100_20150317_001272", "f_rokas_25", -805.3795, 267.9441, 836.4071, 45, "QUEST_LV_0100_20150317_001272_Call")
function QUEST_LV_0100_20150317_001272_Call()
msg("ROKAS25_HILDA2_BASIC01")
end

----- Sculptor Hilda ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_HILDA3 -----
----- Dialog -----
----- QuestIDs: ROKAS25_SQ_08 -----
addnpc(20139, "QUEST_LV_0100_20150317_001272", "f_rokas_25", 32.68515, 267.9441, 382.9095, 45, "QUEST_LV_0100_20150317_001272_Call")
function QUEST_LV_0100_20150317_001272_Call()
msg("ROKAS25_HILDA3_BASIC01")
end

----- Molding Pot ----- 
addnpc(40064, "ETC_20150317_005289", "f_rokas_25", 249.27, 267.94, 799.52, -35, "npc_dummy")

----- Abandoned Graverobbing Equipment ----- 
addnpc(47160, "ETC_20150317_009448", "f_rokas_25", -1966, 268, -1105, 45, "npc_dummy")

----- Abandoned Graverobbing Equipment ----- 
addnpc(47160, "ETC_20150317_009448", "f_rokas_25", -2161, 268, -1273, 45, "npc_dummy")

----- Abandoned Graverobbing Equipment ----- 
addnpc(47160, "ETC_20150317_009448", "f_rokas_25", -1939, 268, -712, 45, "npc_dummy")

----- Abandoned Graverobbing Equipment ----- 
addnpc(47160, "ETC_20150317_009448", "f_rokas_25", -2404, 268, -1053, 45, "npc_dummy")

----- Abandoned Graverobbing Equipment ----- 
addnpc(47160, "ETC_20150317_009448", "f_rokas_25", -2469, 268, -676, 45, "npc_dummy")

----- Abandoned Graverobbing Equipment ----- 
addnpc(47160, "ETC_20150317_009448", "f_rokas_25", -2320, 268, -876, 45, "npc_dummy")

----- Abandoned Graverobbing Equipment ----- 
addnpc(47160, "ETC_20150317_009448", "f_rokas_25", -1622, 268, -905, 45, "npc_dummy")

----- Abandoned Graverobbing Equipment ----- 
addnpc(47160, "ETC_20150317_009448", "f_rokas_25", -1747, 268, -1257, 45, "npc_dummy")

----- Ancient Pillars ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_HILDA_STRUCTURE -----
----- Dialog -----
addnpc(47106, "ETC_20150317_005286", "f_rokas_25", -803, 267, 856, 132, "npc_dummy")

----- Gustas Jonas ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_REXIPHER5 -----
----- Dialog -----
----- QuestIDs: ROKAS25_TO_26_ZACHA01 | ROKAS25_REXIPHER6 | ROKAS25_REXIPHER4 -----
addnpc(147390, "QUEST_LV_0100_20150317_000068", "f_rokas_25", 1985, 167, -328, 45, "QUEST_LV_0100_20150317_000068_Call")
function QUEST_LV_0100_20150317_000068_Call()
msg("ROKAS25_REXIPHER5_BASIC01")
msg("ROKAS25_REXIPHER5_BASIC02")
end

----- Ancient Pillars ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_HILDA_STRUCTURE -----
----- Dialog -----
addnpc(47106, "ETC_20150317_005286", "f_rokas_25", -722, 267, 428, 45, "npc_dummy")

----- Ancient Pillars ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_HILDA_STRUCTURE -----
----- Dialog -----
addnpc(47106, "ETC_20150317_005286", "f_rokas_25", -1155.105, 267.9453, 782.3403, 45, "npc_dummy")

----- Ancient Pillars ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_HILDA_STRUCTURE -----
----- Dialog -----
addnpc(47106, "ETC_20150317_005286", "f_rokas_25", -489, 268, 735, 45, "npc_dummy")

----- Ancient Pillars ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_HILDA_STRUCTURE -----
----- Dialog -----
addnpc(47106, "ETC_20150317_005286", "f_rokas_25", -916.8253, 267.9441, 343.9211, 45, "npc_dummy")

----- Ancient Pillars ----- 
----- npcselectdialog.ies | ClassName: ROKAS25_HILDA_STRUCTURE -----
----- Dialog -----
addnpc(47106, "ETC_20150317_005286", "f_rokas_25", -1399.118, 267.9465, 702.1993, 45, "npc_dummy")

----- Ancient Pillars ----- 
addnpc(47106, "ETC_20150317_005286", "f_rokas_25", -1054.135, 269.6201, 823.9144, 45, "npc_dummy")

----- Ancient Pillars ----- 
addnpc(47106, "ETC_20150317_005286", "f_rokas_25", -527.148, 267.9441, 413.0995, 45, "npc_dummy")

----- Ancient Pillars ----- 
addnpc(47106, "ETC_20150317_005286", "f_rokas_25", -50.87834, 267.9441, 661.1926, 45, "npc_dummy")

----- 1 sheet of Magic Research Reference  ----- 
addnpc(147312, "ETC_20150317_007626", "f_rokas_25", -1908.255, 359.1663, 572.5779, 45, "npc_dummy")

----- 2 sheet of Magic Research Reference  ----- 
addnpc(147312, "ETC_20150317_007627", "f_rokas_25", -2061.47, 359.1663, 574.3754, 45, "npc_dummy")

----- 3 sheet of Magic Research Reference  ----- 
addnpc(147312, "ETC_20150317_007628", "f_rokas_25", -2128.05, 359.1663, 637.8066, 45, "npc_dummy")

----- Lv1 Treasure Chest ----- 
addnpc(147392, "ETC_20150317_009100", "f_rokas_25", -2482.46, 268.73, -913.39, 45, "npc_dummy")

