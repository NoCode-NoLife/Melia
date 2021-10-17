function init()
	on("idle", "hit", "on_hit")
end

function idle()
	for i=1,5 do
		wait(1000)
		counting = true
		say(i)
	end
	counting = false
	
	wander(20, 40)
	wait(5000)
end

function aggro()
	say("I hate you!")
	wait(3000)
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
