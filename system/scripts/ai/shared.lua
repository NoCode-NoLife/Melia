--- Simulates a switch-case that operates on chances.
-- @example
-- switchrandom()
-- if case(50) then -- 50% chance
--     say("Here we go!")
-- elseif case(15) then -- 15% chance
--     say("On the road, on the road~")
-- else -- 35% chance
--     say("Foobar!")
-- end
function switchrandom()
	switchRandomN = random(100)
	switchRandomM = 0
end

--- Case part of switchrandom.
-- @param  int  chance  Chance for this case to be entered.
-- @result Returns true if the case should be entered, otherwise false.
function case(chance)
	switchRandomM = switchRandomM + chance
	return switchRandomN < switchRandomM and true or false
end
