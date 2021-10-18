function init()
	on("idle", "hit", "on_hit")
end

function idle()
	if not HAS_MASTER then
		for i=1,5 do
			wait(1000)
			counting = true
			say(i)
		end
		counting = false
		
		wander(20, 40)
		wait(5000)
	else
		follow(50)
		
		if random(100) < 5 then
			say("Hm~hmhm~hm~")
		end
	end
end

function aggro()
	turnto()
	follow(50)
	
	if random(100) < 10 then
		say("I hate you!")
		--wait(3000)
	end
end

function on_hit(attacker)
	if not counting then
		return
	end
	
	say("(Attacked by "..attacker..")")
	wait(1000)
	
	say("Ouchie!")
	wait(1000)
	say("... now I lost count qq")
	wait(3000)
end
