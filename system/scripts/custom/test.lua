addnpc(57223, "Some Npc", "f_siauliai_west", -867, 322, 151, 135, "npc_test")

function npc_test()

	title("???")
	
	select("Well, hello there, {teamname}, how are you?", "Who are you?")
	msg("Who {b}I{/} am?{np}I am {s30}{#ffffff}{ol}THAT Npc{/}{s20}{#111111} of course, the one and only! Hah!")
	
	title("THAT Npc")
	
	select("The only NPC Melia will ever have or need!!", "Uhm...")
	if select("Wait, what? I'm not gonna be the only one? I'm just a... test?", "Yea...", "Cancel") == 2 then
		return
	end
	msg("I... I understand... I shouldn't have assumed...")
	msg("If you'll excuse me... *sniff*")
	msg("But...")
	msg("FIRST!!!")
	
end
