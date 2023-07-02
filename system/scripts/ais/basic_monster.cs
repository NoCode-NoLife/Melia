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
			yield return Wait(skill.Properties.Delay);
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
		// Transition to idle if the target has vanished or is out of range
		if (EntityGone(target) || !InRangeOf(target, MaxChaseDistance) || !IsHating(target))
		{
			target = null;
			StartRoutine("StopAndIdle", StopAndIdle());
		}
	}

	private void CheckTargetDistance()
	{
		// Don't give chase while waiting or we might cancel skill and
		// movement delays. Be patient, little monster.
		if (IsWaiting)
			return;

		// Chase after target if it's too far away
		if (!InRangeOf(target, MinAttackDistance))
			StartRoutine("Chase", Chase());
	}
}
