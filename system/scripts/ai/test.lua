function idle()
	wait(5000)
	
	if random(100) < 25 then
		say("Here we go!")
	end
	
	wander(50, 100)
end
