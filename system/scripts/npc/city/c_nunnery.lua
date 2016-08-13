----- Statue of Goddess Vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "c_nunnery", 105, -75, 4, 360, "npc_dummy")

----- Sister Aiste ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(153142, "QUEST_20160224_003616", "c_nunnery", 9, -56, -114, 360, "QUEST_20160224_003616_Call")
function QUEST_20160224_003616_Call()
msg("REQUEST_MISSION_ABBEY_CANCLE1")
end

----- Sister Lhasa ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(153143, "QUEST_20160224_003620", "c_nunnery", 201, -75, 37, 360, "QUEST_20160224_003620_Call")
function QUEST_20160224_003620_Call()
msg("C_NUNNERY_NPC1_DLG1")
end

