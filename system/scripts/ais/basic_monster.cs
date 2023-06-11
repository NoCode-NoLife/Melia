using System.Collections;
using Melia.Shared.Tos.Const;
using Melia.Zone.Scripting;
using Melia.Zone.Scripting.AI;
using Melia.Zone.World.Actors;

[Ai("BasicMonster")]
public class BasicMonsterAiScript : AiScript
{
	ICombatEntity target;

	protected int MaxChaseDistance = 200;
	protected int MinAttackDistance = 35;

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
		yield return Wait(1000, 5000);

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
			if (!TryGetRandomSkill(out var skill))
			{
				yield return Wait(2000);
				continue;

			}

			while (!InRangeOf(target, skill.Data.MaxRange))
				yield return MoveTo(target.Position, wait: false);

			yield return UseSkill(skill, target);
			yield return Wait(2000);
		}

		yield break;
	}

	protected IEnumerable StopAndIdle()
	{
		yield return StopMove();
		StartRoutine("Idle", Idle());
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
			StartRoutine("StopAndIdle", StopAndIdle());
		}
	}

	private void CheckTargetDistance()
	{
		if (!InRangeOf(target, MinAttackDistance))
			StartRoutine("Chase", Chase());
	}
}
