using System.Collections;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Zone;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.Scripting.AI;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Logging;

[Ai("SadhuDummy")]
public class SadhuDummyAiScript : AiScript
{
	private const int MaxChaseDistance = 75;
	private const int MaxMasterDistance = 75;

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
		Log.Info("[Root] Idle Routine Started.");
	}

	protected IEnumerable Idle()
	{
		var movement = this.Entity.Components.Get<MovementComponent>();

		movement.SetMoveSpeedType(MoveSpeedType.Run);
		movement.SetFixedMoveSpeed(45);

		Log.Info("Setting the MoveType to run - Speed: {0}", 45);

		var master = GetMaster();
		if (master != null)
		{
			yield return Follow(master, 25, true, false);
			yield break;
		}

		yield return Wait(1000, 2000);

		SwitchRandom();

		if (Case(80))
		{
			yield return MoveRandom();
		}
	}

	protected IEnumerable Attack()
	{		
		ExecuteOnce(Emoticon("I_emo_damagerank1_crown"));
		Log.Info("IEnumerable Attack()");

		// Remove the dummy character if the master is gone
		if (TryGetMaster(out var master) && EntityGone(master) && this.Entity is Character dummyCharacter)
		{
			if (dummyCharacter.Owner is Character ownerCharacter)
				Send.ZC_OWNER(ownerCharacter, dummyCharacter, 0);

			Send.ZC_LEAVE(dummyCharacter);

			dummyCharacter.Map.RemoveDummyCharacter(dummyCharacter);
			yield break;
		}

		SetRunning(true);

		while (!target.IsDead)
		{
			if (!TryGetAutoAttackSkill(SkillId.Normal_Attack, out var skill))
			{
				Log.Info("skill is null");
				if (TryGetAutoAttackSkill(SkillId.Hammer_Attack, out var skillHammer))
				{
					skill = skillHammer;
					Log.Info("skillHammer is NOT null");
				} else
				{
					yield return Wait(3000);
					continue;
				}
			}

			Log.Info("skill.GetAttackRange(): {0}", skill.GetAttackRange());
			Log.Info("InAttackRange: {0}", InRangeOf(target, 15));

			while (!InRangeOf(target, 15))
				yield return MoveTo(target.Position, wait: false);

			yield return StopMove();

			yield return UseAutoAttackSkill(skill, target);
			yield return Wait(skill.Properties.Delay);
		}

		yield break;
	}

	protected IEnumerable StopAndIdle()
	{
		yield return StopMove();
		StartRoutine("Idle", Idle());
		Log.Info("[StopAndIdle] Idle Routine Started.");
	}

	protected IEnumerable StopAndAttack()
	{
		// TODO: remove this emote
		ExecuteOnce(Emoticon("I_emo_exclamation"));
		ExecuteOnce(TurnTowards(target));

		Log.Info("[StopAndAttack] target.Name: {0}", target.Name);

		yield return StopMove();
		StartRoutine("Attack", Attack());
		Log.Info("[StopAndAttack] Attack() Routine Started");
	}

	/// <summary>
	/// Execute an auto attack towards the target
	/// </summary>
	private IEnumerable UseAutoAttackSkill(Skill skill, ICombatEntity target)
	{
		this.Entity.TurnTowards(target);

		if (!ZoneServer.Instance.SkillHandlers.TryGetHandler<IMeleeGroundSkillHandler>(skill.Id, out var handler))
		{
			Log.Warning($"AiScript: No handler found for skill '{skill.Id}'.");
			yield return this.Wait(3000);
			yield break;
		}

		var targets = new List<ICombatEntity>();
		targets.Add(target);

		handler.Handle(skill, this.Entity, this.Entity.Position, this.Entity.Position, targets);

		var useTime = skill.Properties.ShootTime;
		yield return this.Wait(useTime);
	}

	/// <summary>
	/// Gets the Auto Attack Skill for the dummy
	/// </summary>
	private bool TryGetAutoAttackSkill(SkillId skillId, out Skill skill)
	{
		skill = null;
		return this.Entity.Components.Get<SkillComponent>()?.TryGet(skillId, out skill) ?? false;
	}

	private void CheckEnemies()
	{
		var attackableEntities = this.Entity.Map.GetAttackableEntitiesInRange(this.Entity, Entity.Position, 75);

		if (attackableEntities != null && attackableEntities.Count > 0)
		{
			target = attackableEntities[0];
			StartRoutine("StopAndAttack", StopAndAttack());
			Log.Info("[CheckEnemies] StopAndAttack Routine Started.");
		}
	}

	private void CheckTarget()
	{
		// Transition to idle if the target has vanished or is out of range
		if (EntityGone(target) || !InRangeOf(target, MaxChaseDistance))
		{
			target = null;
			StartRoutine("StopAndIdle", StopAndIdle());
			Log.Info("[CheckTarget] StopAndIdle Routine Started.");
		}
	}

	private void CheckMaster()
	{
		if (target == null)
			return;

		if (!TryGetMaster(out var master))
			return;

		// Reset aggro if the master is out of range
		if (!InRangeOf(master, MaxMasterDistance))
		{
			target = null;
			StartRoutine("StopAndIdle", StopAndIdle());
			Log.Info("[CheckMaster] StopAndIdle Routine Started.");
		}
	}
}
