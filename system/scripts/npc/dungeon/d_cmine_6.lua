----- Crystal Wall of the Closed Area ----- 
----- npcselectdialog.ies | ClassName: CMINE3_BOSSROOM_OPEN -----
----- Dialog -----
----- QuestIDs: ACT4_MINE3_ENTER -----
addnpc(151014, "QUEST_LV_0100_20150317_002501", "d_cmine_6", 129.08, 183.64, -112.43, -41, "npc_dummy")

----- Miner ----- 
----- npcselectdialog.ies | ClassName: MINE_3_RESIENT1_BIND -----
----- Dialog -----
----- QuestIDs: MINE_3_RESQUE1 -----
addnpc(151009, "QUEST_LV_0100_20150317_000366", "d_cmine_6", -1187.67, 303.49, 104.16, -17, "npc_dummy")

----- Girl ----- 
addnpc(151012, "QUEST_LV_0100_20150317_000851", "d_cmine_6", -1206.57, 303.49, 87.32, 27, "npc_dummy")

----- Village Aunt ----- 
----- npcselectdialog.ies | ClassName: D_CMINE_NPC01_BIND -----
----- Dialog -----
addnpc(151010, "QUEST_LV_0100_20150317_000206", "d_cmine_6", -1183.55, 303.49, 111.4, 32, "QUEST_LV_0100_20150317_000206_Call")
function QUEST_LV_0100_20150317_000206_Call()
msg("D_CMINE_NPC01_BIND_basic01")
msg("D_CMINE_NPC01_BIND_basic02")
end

----- Village Girl ----- 
----- npcselectdialog.ies | ClassName: D_CMINE_NPC02_BIND -----
----- Dialog -----
addnpc(151011, "QUEST_LV_0100_20150317_000209", "d_cmine_6", -1200.25, 303.49, 98.06, -40, "QUEST_LV_0100_20150317_000209_Call")
function QUEST_LV_0100_20150317_000209_Call()
msg("D_CMINE_NPC02_BIND_basic01")
msg("D_CMINE_NPC02_BIND_basic02")
end

----- Statue of Goddess Vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "d_cmine_6", -2175.529, 360.2849, -1773.89, 45, "npc_dummy")

----- Lv1 Treasure Chest ----- 
addnpc(147392, "ETC_20150317_009100", "d_cmine_6", -1145.18, 303.59, 103.15, -45, "npc_dummy")

----- Miner ----- 
----- npcselectdialog.ies | ClassName: MINE_3_RESIENT1 -----
----- Dialog -----
----- QuestIDs: MINE_3_RESQUE1 -----
addnpc(20150, "QUEST_LV_0100_20150317_000366", "d_cmine_6", -1187.67, 303.49, 104.16, -17, "QUEST_LV_0100_20150317_000366_Call")
function QUEST_LV_0100_20150317_000366_Call()
msg("MINE_3_RESIENT1_BASIC01")
msg("MINE_3_RESIENT1_BASIC02")
end

----- Girl ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(47236, "QUEST_LV_0100_20150317_000851", "d_cmine_6", -1206.57, 303.49, 87.32, 27, "QUEST_LV_0100_20150317_000851_Call")
function QUEST_LV_0100_20150317_000851_Call()
msg("MINE_3_GIRL1")
end

----- Village Aunt ----- 
----- npcselectdialog.ies | ClassName: D_CMINE_NPC01 -----
----- Dialog -----
addnpc(20114, "QUEST_LV_0100_20150317_000206", "d_cmine_6", -1183.55, 303.49, 111.4, 32, "QUEST_LV_0100_20150317_000206_Call")
function QUEST_LV_0100_20150317_000206_Call()
msg("D_CMINE_NPC01_BIND_basic01")
msg("D_CMINE_NPC01_basic01")
msg("D_CMINE_NPC01_basic02")
end

----- Village Girl ----- 
----- npcselectdialog.ies | ClassName: D_CMINE_NPC02 -----
----- Dialog -----
addnpc(147473, "QUEST_LV_0100_20150317_000209", "d_cmine_6", -1200.25, 303.49, 98.06, -40, "QUEST_LV_0100_20150317_000209_Call")
function QUEST_LV_0100_20150317_000209_Call()
msg("D_CMINE_NPC02_BIND_basic01")
msg("D_CMINE_NPC02_basic01")
msg("D_CMINE_NPC02_basic02")
end

