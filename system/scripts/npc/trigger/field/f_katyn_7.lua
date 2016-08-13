----- Middle Boss Trigger ----- 
----- npcselectdialog.ies | ClassName: KATYN7_PREBOSS -----
----- Enter | Dialog -----
----- QuestIDs: KATYN_KEY_01 -----
addnpc(20026, "ETC_20150317_009380", "f_katyn_7", 976, 296, 187, -45, "npc_dummy")

----- Position Trigger of Commander Vacenin ----- 
----- npcselectdialog.ies | ClassName: KATYN7_KEYNPC_1_TRIGGER -----
----- Enter | Dialog -----
addnpc(20026, "ETC_20150317_009381", "f_katyn_7", 1026, 295, -3727, -45, "npc_dummy")

----- Trap Case ----- 
----- Enter -----
addnpc(20041, "ETC_20150317_009250", "f_katyn_7", -124, 247, 1592, 45, "ETC_20150317_009250_Call")
function ETC_20150317_009250_Call()
msg("REPEAT_MON_GEN_TRIGGER")
end

----- Trap Case ----- 
----- Enter -----
addnpc(20041, "ETC_20150317_009250", "f_katyn_7", 190, 418, -3513, 45, "ETC_20150317_009250_Call")
function ETC_20150317_009250_Call()
msg("REPEAT_MON_GEN_TRIGGER")
end

----- Trap Case ----- 
----- Enter -----
addnpc(20041, "ETC_20150317_009250", "f_katyn_7", 372, 295, -3562, 45, "ETC_20150317_009250_Call")
function ETC_20150317_009250_Call()
msg("REPEAT_MON_GEN_TRIGGER")
end

----- Trap Case ----- 
----- Enter -----
addnpc(20041, "ETC_20150317_009250", "f_katyn_7", 329, 295, -933, 45, "ETC_20150317_009250_Call")
function ETC_20150317_009250_Call()
msg("REPEAT_MON_GEN_TRIGGER")
end

----- Bait Install Place ----- 
----- npcselectdialog.ies | ClassName: KATYN7_MQ06_TRACK -----
----- Dialog -----
----- QuestIDs: KATYN71_MQ_06 -----
addnpc(20025, "ETC_20150317_009382", "f_katyn_7", -917.4514, 295.7024, 3306.635, 45, "npc_dummy")

----- Field Gen x ----- 
addnpc(147362, "ETC_20150729_014021", "f_katyn_7", 677.3121, 295.2072, -4389.714, 45, "npc_dummy")

----- Field Gen x ----- 
addnpc(147362, "ETC_20150729_014021", "f_katyn_7", -856.7756, 297.2703, 3829.618, 45, "npc_dummy")

