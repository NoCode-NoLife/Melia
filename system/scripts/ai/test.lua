function idle()
	wait(5000, 10000)
	
	if random(100) < 25 then
		for i=1,3 do
			say(tostring(i) .. "...")
			wait(1000)
		end
	
		switchrandom()
		if case(50) then -- 50% chance
			say("Here we go!")
		elseif case(15) then -- 15% chance
			say("On the road, on the road~")
		else -- 35% chance
			say("Foobar!")
		end
	end
	
	wander(20, 80)
end
