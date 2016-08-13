----- Statue of Goddess Vakarine ----- 
----- npcselectdialog.ies | ClassName: STOUP_CAMP -----
----- Enter | Dialog -----
----- QuestIDs: JOB_KRIVI4_3 -----
addnpc(40120, "QUEST_20150317_000002", "p_catacomb_1", 63.74635, 260.2255, 8.646395, -15, "npc_dummy")

----- Warning ----- 
----- npcselectdialog.ies | ClassName:  -----
----- Dialog -----
addnpc(40070, "QUEST_20150317_000566", "p_catacomb_1", -3.177528, 267.5362, 1062.539, 45, "QUEST_20150317_000566_Call")
function QUEST_20150317_000566_Call()
msg("UPPER_WARNING_P_CATACOMB_1")
end

----- [Necromancer Master]{nl}Loretta Nimbus ----- 
----- npcselectdialog.ies | ClassName: JOB_NECRO4_NPC -----
----- Dialog -----
----- QuestIDs: JOB_NECROMANCER5_1 | JOB_NECROMANCER_6_1 -----
addnpc(147446, "ETC_20150729_014031", "p_catacomb_1", 193.1828, 260.2255, 82.64813, -45, "ETC_20150729_014031_Call")
function ETC_20150729_014031_Call()
msg("JOB_NECRO4_NPC_basic01")
msg("JOB_NECRO4_NPCbasic02")
end

