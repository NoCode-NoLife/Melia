----- Mercenary Post Manager Rota ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(151037, "ETC_20150317_009064", "c_request_1", -46, 0, -96, 45, "ETC_20150317_009064_Call")
function ETC_20150317_009064_Call()
msg("FEDIMIAN_ROTA_02_basic01")
end

----- Receptionist Brandon ----- 
addnpc(20117, "QUEST_20150414_001891", "c_request_1", -30.97364, 6.803148, -11.82858, -57, "npc_dummy")

----- Receptionist Liam ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(154054, "QUEST_20151001_002454", "c_request_1", -30.97364, 6.803148, -11.82858, -57, "QUEST_20151001_002454_Call")
function QUEST_20151001_002454_Call()
msg("PARTYQUEST_NPC_01_SELECT1")
end

----- Request Bulletin Board ----- 
addnpc(147372, "QUEST_20150317_001042", "c_request_1", -104, 4, -20, 45, "npc_dummy")

----- Receptionist Ramda ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(147484, "QUEST_20150414_001802", "c_request_1", 84.53972, 0.2498, -165.2381, 107, "QUEST_20150414_001802_Call")
function QUEST_20150414_001802_Call()
msg("MISSIONSHOP_NPC_01_CANCLE1")
end

----- Receptionist Donnes ----- 
----- npcselectdialog.ies | ClassName: DROPITEM_REQUEST1_NPC -----
----- Dialog -----
----- QuestIDs: DROPITEM_REQUEST1 -----
addnpc(151039, "QUEST_LV_0100_20151224_011238", "c_request_1", 106, 0, -15, -57, "QUEST_LV_0100_20151224_011238_Call")
function QUEST_LV_0100_20151224_011238_Call()
msg("DROPITEM_REQUEST1_NPC_basic1")
end

