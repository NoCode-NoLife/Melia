function idle()
	wait(5000)
	
	if random(100) < 25 then
		for i=1,3 do
			say(tostring(i) .. "...")
			wait(1000)
		end
	
		say("Here we go!")
	end
	
	wander(50, 100)
end
