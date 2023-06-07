using System.Collections;
using Melia.Zone.Scripting;
using Melia.Zone.Scripting.AI;
using Melia.Zone.World.Actors;

[Ai("BasicMonster")]
public class BasicMonsterAiScript : AiScript
{
	ICombatEntity target;

	protected int MaxChaseDistance = 200;
	protected int MinAttackDistance = 30;

	protected override void Setup()
	{
		During("Idle", CheckEnemies);
		During("Chase", CheckTarget);
		During("Attack", CheckTarget);
		During("Attack", CheckTargetDistance);
	}

	protected override void Root()
	{
		StartRoutine("Idle", Idle());
	}

	protected IEnumerable Idle()
	{
		yield return StopMove();
		yield return Wait(1000, 5000);
		yield return MoveRandom();
	}

	protected IEnumerable Chase()
	{
		while (!InRangeOf(target, MinAttackDistance))
			yield return MoveTo(target.Position, wait: false);

		yield return StopMove();

		StartRoutine("Attack", Attack());
	}

	protected IEnumerable Attack()
	{
		yield return Wait(500);

		while (!target.IsDead)
		{
			switch (Random(4))
			{
				case 0: yield return Say("Die!"); break;
				case 1: yield return Say("Attack!"); break;
				case 2: yield return Say("Whabam!"); break;
				case 3: yield return Say("You're dooomed!"); break;
			}

			yield return Wait(1000, 2000);
		}

		yield break;
	}

	private void CheckEnemies()
	{
		var mostHated = GetMostHated();
		if (mostHated != null)
		{
			target = mostHated;
			StartRoutine("Chase", Chase());
		}
	}

	private void CheckTarget()
	{
		if (EntityGone(target) || !InRangeOf(target, MaxChaseDistance))
		{
			target = null;
			StartRoutine("Idle", Idle());
		}
	}

	private void CheckTargetDistance()
	{
		if (!InRangeOf(target, MinAttackDistance))
			StartRoutine("Chase", Chase());
	}
}
