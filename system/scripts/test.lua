
addnpc(57223, 'Test', 'f_siauliai_west', -867, 322, 151, 'testnpc')

function testnpc()
	msg('Test*@*Well, hello there. I\'m proud to be the first NPC in Melia.{np}Suspendisse pharetra diam aliquam auctor faucibus!')
	if select('Test*@*How are you?', 'Good', 'Bad') == 1 then
		msg('Test*@*Glad to hear that.')
	else
		msg('Test*@*Aww :(')
	end
	msg('Test*@*Bye then.')
end
