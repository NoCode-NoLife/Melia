
addnpc(57223, "Some Npc", "f_siauliai_west", -867, 322, 151, "testnpc")

function testnpc()
	local name = "???*@*"
	local name2 = "THAT Npc*@*"
	
	select(name.."Well, hello there, {pcname}, how are you?", "Who are you?")
	close()
	msg(name.."Who {b}I{/} am?{np}I am {s30}{#ffffff}{ol}THAT Npc{/}{s20}{#111111} of course, the one and only! Hah!")
	select(name2.."The only NPC Melia will ever have or need!!", "Uhm...")
	close()
	if select(name2.."Wait, what? I'm not gonna be the only one? I'm just a... test?", "Yea...", "Cancel") == 2 then
		close()
		return
	end

	close()
	msg(name2.."I... I understand... I shouldn't have assumed...")
	msg(name2.."If you'll excuse me... *sniff*")
	msg(name2.."But...")
	msg(name2.."FIRST!!!")
end
