using System.Collections;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.Scripting.AI;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Yggdrasil.Logging;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Monsters;
using System.Linq;
using Yggdrasil.Util;

[Ai("BasicMonster")]
public class BasicMonsterAiScript : AiScript
{
	private const int MaxChaseDistance = 300;
	private const int MaxMasterDistance = 200;

	ICombatEntity target;

	protected override void Setup()
	{
		During("Idle", CheckEnemies);
		During("Attack", CheckTarget);
		During("Attack", CheckMaster);
	}

	protected override void Root()
	{
		StartRoutine("Idle", Idle());
	}

	protected IEnumerable Idle()
	{
		ResetMoveSpeed();

		var master = GetMaster();
		if (master != null)
		{
			yield return Follow(master);
			yield break;
		}

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
		ExecuteOnce(Emoticon("I_emo_exclamation"));
		ExecuteOnce(TurnTowards(target));

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

	private void CheckMaster()
	{
		if (target == null)
			return;

		if (!TryGetMaster(out var master))
			return;

		// Reset aggro if the master left
		if (EntityGone(master) || !InRangeOf(master, MaxMasterDistance))
		{
			target = null;
			RemoveAllHate();
			StartRoutine("StopAndIdle", StopAndIdle());
		}
	}


	/// <summary>
	/// Returns a random skill the entity can use
	/// </summary>
	/// <param name="skill"></param>
	/// <returns></returns>
	protected override bool TryGetRandomSkill(out Skill skill)
	{
		skill = null;

		if (!(this.Entity is Mob mob))
			return false;

		if (!mob.Data.Skills.Any())
			return false;

		var hasExtraSkill = mob.Vars.Has("Melia.Mob.ExtraSkill");

		if (hasExtraSkill && RandomProvider.Get().Next(100) <= mob.Vars.GetInt("Melia.Mob.ExtraSkillUseRate"))
		{
			skill = new Skill(mob, (SkillId)mob.Vars.GetInt("Melia.Mob.ExtraSkill"), mob.Vars.GetInt("Melia.Mob.ExtraSkillLevel"));
		}
		else
		{
			var rndSkillId = mob.Data.Skills.First().SkillId;

			// Should we give monsters a skill manager? We might not
			// actually need it, though we should probably at least
			// cache the skills if we create them on demand.
			skill = new Skill(this.Entity, rndSkillId, 1);
		}

		return true;
	}


	/// <summary>
	/// Makes entity use the given skill on the target.
	/// </summary>
	/// <param name="skill"></param>
	/// <param name="target"></param>
	/// <returns></returns>
	protected override IEnumerable UseSkill(Skill skill, ICombatEntity target)
	{
		this.Entity.TurnTowards(target);
		switch (skill.Data.UseType)
		{
			case SkillUseType.MeleeGround:
			{
				if (!ZoneServer.Instance.SkillHandlers.TryGetHandler<IGroundSkillHandler>(skill.Id, out var handler))
				{
					Log.Warning($"AiScript: No handler found for skill '{skill.Id}'.");
					yield return this.Wait(2000);
					yield break;
				}
				var skillTarget = target;

				if (skill.Id == SkillId.Cleric_Heal)
				{
					if (GetMaster() != null)
						skillTarget = GetMaster();
					else
						skillTarget = this.Entity;
				}				

				skill.Vars.Set("Melia.ToolGroundPos", skillTarget.Position);

				handler.Handle(skill, this.Entity, this.Entity.Position, skillTarget.Position, skillTarget);

				if (this.Entity is Mob mob)
					Send.ZC_SKILL_MELEE_GROUND(this.Entity, new Skill(mob, mob.Data.Skills.First().SkillId, 1), skillTarget.Position, null);
				break;
			}
			default:
			{
				if (!ZoneServer.Instance.SkillHandlers.TryGetHandler<ITargetSkillHandler>(skill.Id, out var handler))
				{
					Log.Warning($"AiScript: No handler found for skill '{skill.Id}'.");
					yield return this.Wait(2000);
					yield break;
				}
				handler.Handle(skill, this.Entity, target);

				break;
			}
		}

		var useTime = skill.Properties.ShootTime;
		yield return this.Wait(useTime);
	}
}
