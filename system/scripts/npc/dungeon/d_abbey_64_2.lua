----- Traveling Merchant Rose ----- 
----- npcselectdialog.ies | ClassName: ABBEY642_ROZE01 -----
----- Dialog -----
----- QuestIDs: ABBAY_64_2_MQ010 -----
addnpc(153119, "QUEST_20151224_003205", "d_abbey_64_2", 920.0567, 399.358, -114.0447, 144, "npc_dummy")

----- Edmundas ----- 
----- npcselectdialog.ies | ClassName: ABBEY642_EDMONDAS -----
----- Enter | Dialog -----
----- QuestIDs: ABBAY_64_2_MQ030 | ABBAY_64_2_MQ040 -----
addnpc(153110, "ETC_20151102_016545", "d_abbey_64_2", -11.69911, 981.4951, -1335.252, 121, "ETC_20151102_016545_Call")
function ETC_20151102_016545_Call()
msg("ABBEY642_EDMONDA_CHECK")
end

----- Traveling Merchant Rose ----- 
----- npcselectdialog.ies | ClassName: ABBEY642_ROZE02 -----
----- Dialog -----
----- QuestIDs: ABBAY_64_2_MQ020 | ABBAY_64_2_MQ030 -----
addnpc(153119, "QUEST_20151224_003205", "d_abbey_64_2", 11, 982.54, -1272, -49, "npc_dummy")

----- Experiment Victim Hilbeth ----- 
----- npcselectdialog.ies | ClassName: ABBEY642_PEAPLE01 -----
----- Dialog -----
----- QuestIDs: ABBAY_64_2_SQ010 | ABBAY_64_2_SQ020 | ABBAY_64_2_SQ030 -----
addnpc(20063, "QUEST_LV_0100_20151224_011836", "d_abbey_64_2", 28.79301, 299.358, 1562.411, 10, "QUEST_LV_0100_20151224_011836_Call")
function QUEST_LV_0100_20151224_011836_Call()
msg("ABBEY642_PEAPLE01_basic3")
msg("ABBEY642_PEAPLE01_basic1")
msg("ABBEY642_PEAPLE01_basic2")
msg("ABBEY642_PEAPLE01_basic4")
end

----- Demons' Experimental Tools ----- 
addnpc(153063, "ETC_20151102_017413", "d_abbey_64_2", -1135.509, 400, 669.5549, -73, "npc_dummy")

----- Demons' Experimental Tools ----- 
addnpc(153065, "ETC_20151102_017413", "d_abbey_64_2", -1262.597, 399.4869, 867.3038, 45, "npc_dummy")

----- Demons' Experimental Tools ----- 
addnpc(153065, "ETC_20151102_017413", "d_abbey_64_2", -848.9944, 400, 634.3934, -112, "npc_dummy")

----- Demons' Experimental Tools ----- 
addnpc(153063, "ETC_20151102_017413", "d_abbey_64_2", -921.9781, 400, 863.6972, -46, "npc_dummy")

----- Demons' Experimental Tools ----- 
addnpc(153065, "ETC_20151102_017413", "d_abbey_64_2", -1276.678, 399.4869, 460.811, -59, "npc_dummy")

----- Demons' Experimental Tools ----- 
addnpc(153065, "ETC_20151102_017413", "d_abbey_64_2", -970.2206, 399.4869, 466.1358, 128, "npc_dummy")

----- Novaha Relic ----- 
----- Enter -----
addnpc(153026, "ETC_20151224_019917", "d_abbey_64_2", 45.02862, 300, 987.8319, 0, "ETC_20151224_019917_Call")
function ETC_20151224_019917_Call()
msg("ABBEY642_ORB_SET01")
end

----- Novaha Relic ----- 
----- Enter -----
addnpc(153026, "ETC_20151224_019917", "d_abbey_64_2", -926.4878, 0, 2107.158, -3, "ETC_20151224_019917_Call")
function ETC_20151224_019917_Call()
msg("ABBEY642_ORB_SET02")
end

----- Novaha Relic ----- 
----- Enter -----
addnpc(153026, "ETC_20151224_019917", "d_abbey_64_2", -586.4133, 299.6631, 248.9912, -16, "ETC_20151224_019917_Call")
function ETC_20151224_019917_Call()
msg("ABBEY642_ORB_SET03")
end

----- Monk Abels ----- 
----- npcselectdialog.ies | ClassName: ABBEY642_MONK01 -----
----- Dialog -----
----- QuestIDs: ABBAY_64_2_SQ040 | ABBAY_64_2_SQ050 -----
addnpc(155044, "QUEST_LV_0100_20151224_011895", "d_abbey_64_2", 610.3942, 178.1192, 884.1901, -45, "QUEST_LV_0100_20151224_011895_Call")
function QUEST_LV_0100_20151224_011895_Call()
msg("ABBEY642_MONK01_basic1")
msg("ABBEY642_MONK01_basic2")
msg("ABBAY_64_2_SQ050_succ01")
msg("ABBAY_64_2_SQ050_startnpc_prog01")
end

----- Lv1 Treasure Chest ----- 
addnpc(147392, "ETC_20150317_009100", "d_abbey_64_2", 97, 981, -1895, 0, "npc_dummy")

