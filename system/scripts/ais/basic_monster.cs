using System.Collections;
using Melia.Zone.Scripting;
using Melia.Zone.Scripting.AI;
using Melia.Zone.World.Actors;

[Ai("BasicMonster")]
public class BasicMonsterAiScript : AiScript
{
	ICombatEntity target;

	protected int MaxChaseDistance = 300;

	protected override void Setup()
	{
		During("Idle", CheckEnemies);
		During("Attack", CheckTarget);
	}

	protected override void Root()
	{
		StartRoutine("Idle", Idle());
	}

	protected IEnumerable Idle()
	{
		SetRunning(false);

		yield return Wait(4000, 8000);

		SwitchRandom();
		if (Case(80))
		{
			yield return MoveRandom();
		}
		else
		{
			yield return Animation("IDLE");
		}
	}

	protected IEnumerable Attack()
	{
		SetRunning(true);

		while (!target.IsDead)
		{
			if (!TryGetRandomSkill(out var skill))
			{
				yield return Wait(2000);
				continue;
			}

			while (!InRangeOf(target, skill.GetAttackRange()))
				yield return MoveTo(target.Position, wait: false);

			yield return StopMove();

			yield return UseSkill(skill, target);
			yield return Wait(skill.Properties.Delay);
		}

		yield break;
	}

	protected IEnumerable StopAndIdle()
	{
		yield return StopMove();
		StartRoutine("Idle", Idle());
	}

	protected IEnumerable StopAndAttack()
	{
		yield return StopMove();
		StartRoutine("Attack", Attack());
	}

	private void CheckEnemies()
	{
		var mostHated = GetMostHated();
		if (mostHated != null)
		{
			target = mostHated;
			StartRoutine("StopAndAttack", StopAndAttack());
		}
	}

	private void CheckTarget()
	{
		// Transition to idle if the target has vanished or is out of range
		if (EntityGone(target) || !InRangeOf(target, MaxChaseDistance) || !IsHating(target))
		{
			target = null;
			StartRoutine("StopAndIdle", StopAndIdle());
		}
	}
}
