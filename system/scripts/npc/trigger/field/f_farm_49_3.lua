----- Boss Trigger ----- 
----- npcselectdialog.ies | ClassName: FARM493_SQ_04 -----
----- Enter | Dialog -----
----- QuestIDs: FARM49_3_SQ04 -----
addnpc(20026, "ETC_20150323_010391", "f_farm_49_3", -346.9366, 248.8447, 1778.264, 45, "npc_dummy")

----- Safety Zone Trigger ----- 
----- Enter -----
addnpc(20026, "ETC_20150323_010392", "f_farm_49_3", 814.0458, 293.2046, -72.04294, 45, "ETC_20150323_010392_Call")
function ETC_20150323_010392_Call()
msg("FARM493_SQ_06_1")
end

----- Gate Entrance x ----- 
addnpc(147366, "ETC_20150401_010678", "f_farm_49_3", 787.8402, 293.2046, -67.16559, 45, "npc_dummy")

----- Gate Entrance x ----- 
addnpc(147362, "ETC_20150401_010678", "f_farm_49_3", 829, 245, -882, 45, "npc_dummy")

----- Gate Entrance x ----- 
addnpc(147362, "ETC_20150401_010678", "f_farm_49_3", -1649, 285, 1674, 45, "npc_dummy")

