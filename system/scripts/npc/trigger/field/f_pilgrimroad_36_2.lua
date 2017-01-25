----- PILGRIM_36_2_SQ_010To start quest ----- 
----- npcselectdialog.ies | ClassName: PILGRIM_36_2_SQ_010_TRIGGER -----
----- Enter | Dialog -----
----- QuestIDs: PILGRIM_36_2_SQ_010 -----
addnpc(20026, "ETC_20151001_015265", "f_pilgrimroad_36_2", 1420.525, 119.5623, -286.3961, 45, "npc_dummy")

----- PILGRIM_36_2_SQ_020To complete quest ----- 
----- npcselectdialog.ies | ClassName: PILGRIM_36_2_SQ_020_TRIGGER -----
----- Enter | Dialog -----
----- QuestIDs: PILGRIM_36_2_SQ_020 -----
addnpc(20026, "ETC_20151001_015266", "f_pilgrimroad_36_2", -250.1871, 225.3776, -607.5973, 45, "npc_dummy")

----- PILGRIM_36_2_SQ_050To complete quest ----- 
----- npcselectdialog.ies | ClassName: PILGRIM_36_2_SQ_050_TRIGGER -----
----- Enter | Dialog -----
----- QuestIDs: PILGRIM_36_2_SQ_050 -----
addnpc(20026, "ETC_20151001_015267", "f_pilgrimroad_36_2", 1408.766, 119.5623, -220.6874, 45, "npc_dummy")

----- PILGRIM_36_2_SQ_150To start quest ----- 
----- npcselectdialog.ies | ClassName: PILGRIM_36_2_SQ_150_TRIGGER -----
----- Enter | Dialog -----
----- QuestIDs: PILGRIM_36_2_SQ_150 -----
addnpc(20026, "ETC_20151001_015268", "f_pilgrimroad_36_2", 1253.899, 119.5623, -407.2492, 45, "npc_dummy")

----- For effects of flame bombs ----- 
----- Enter -----
addnpc(20026, "ETC_20151016_015915", "f_pilgrimroad_36_2", 803.1058, 130.9243, 244.1496, 45, "ETC_20151016_015915_Call")
function ETC_20151016_015915_Call()
msg("PILGRIM_36_2_FIRE")
end

