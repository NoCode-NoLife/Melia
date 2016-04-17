----- Melia Script ----------------------------------------------------------
-- One Liner
----- Description -----------------------------------------------------------
-- If a localization key or the name of a client-side dialog are passed to
-- `addnpc` (e.g. ETC_20150317_009196, MASTER_ICEMAGE_basic1), instead of
-- the name of a function, this function is called, to send that one key to
-- the client.
-----------------------------------------------------------------------------

function npc_oneliner()
	local npc = getnpc()
	msg(npc.dialogName)
end
