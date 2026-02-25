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

[Ai("SadhuDummy")]
public class SadhuDummyAiScript : AiScript
{
	private const int MaxChaseDistance = 100;
	private const int MaxMasterDistance = 120;
	private const int AttackRange = 15;

	ICombatEntity target;

	protected override void Setup()
	{
		SetViewDistance(350);

		SetTendency(TendencyType.Aggressive);
		HatesFaction(FactionType.Peaceful);
		HatesFaction(FactionType.Pet);
		HatesFaction(FactionType.Monster);
		HatesFaction(FactionType.Neutral);
		HatesFaction(FactionType.Summon);

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
		var movement = this.Entity.Components.Get<MovementComponent>();

		movement.SetMoveSpeedType(MoveSpeedType.Run);
		
		if (this.Entity is Character entityCharacter && this.Entity is DummyCharacter dummyCharacter)
		{
			SetFixedMoveSpeed(85);
			Send.ZC_MSPD(entityCharacter);
		}
		
		var master = GetMaster();
		if (master != null && !InRangeOf(master, MaxMasterDistance))
		{
			yield return Follow(master, 25, true, false);
			yield break;
		}

		yield return Wait(250, 500);
	}

	protected IEnumerable Attack()
	{
		// Remove the dummy character if the master is gone
		if (TryGetMaster(out var master) && EntityGone(master) && this.Entity is DummyCharacter dummyCharacter)
		{
			dummyCharacter.Despawn();
			yield break;
		}

		while (!target.IsDead)
		{
			if (!CanUseAutoAttackSkill(SkillId.Normal_Attack, out var skill))
			{
				if (CanUseAutoAttackSkill(SkillId.Hammer_Attack, out var skillHammer))
				{
					skill = skillHammer;
				} else
				{
					yield return Wait(3000);
					continue;
				}
			}

			yield return StopMove();

			yield return UseAutoAttackSkill(skill, target);
			yield return Wait(100, 200);
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

	protected IEnumerable MoveToTarget()
	{
		ExecuteOnce(TurnTowards(target));
		yield return MoveTo(target.Position.GetRelative2D(this.Entity.Position, AttackRange - 5), wait: false);

		if (InRangeOf(this.Entity, AttackRange))
		{
			StartRoutine("StopAndAttack", StopAndAttack());
		}
	}

	private IEnumerable UseAutoAttackSkill(Skill skill, ICombatEntity target)
	{
		this.Entity.TurnTowards(target);

		if (!ZoneServer.Instance.SkillHandlers.TryGetHandler<IMeleeGroundSkillHandler>(skill.Id, out var handler))
		{
			yield return this.Wait(3000);
			yield break;
		}

		var targets = new List<ICombatEntity>();
		targets.Add(target);

		handler.Handle(skill, this.Entity, this.Entity.Position, this.Entity.Position, targets);

		var useTime = skill.Properties.ShootTime;
		yield return this.Wait(useTime);
	}

	private bool CanUseAutoAttackSkill(SkillId skillId, out Skill skill)
	{
		skill = null;
		return this.Entity.Components.Get<SkillComponent>()?.TryGet(skillId, out skill) ?? false;
	}

	private void CheckEnemies()
	{
		if (target != null && !target.IsDead)
		{
			return;
		}

		var attackableEntities = this.Entity.Map.GetAttackableEntitiesInRange(this.Entity, Entity.Position, MaxChaseDistance);

		if (attackableEntities != null && attackableEntities.Count > 0)
		{
			var closestEnemy = attackableEntities[0];

			foreach (var enemy in attackableEntities)
			{
				if (enemy.Position.Get2DDistance(this.Entity.Position)  < closestEnemy.Position.Get2DDistance(this.Entity.Position))
				{
					closestEnemy = enemy;
				}
			}

			target = closestEnemy;
			StartRoutine("MoveToTarget", MoveToTarget());
		}
	}

	private void CheckTarget()
	{
		// Transition to idle if the target has vanished or is out of range
		if (EntityGone(target) || !InRangeOf(target, MaxChaseDistance))
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

		// Reset aggro if the master is out of range
		if (!InRangeOf(master, MaxMasterDistance))
		{
			target = null;
			StartRoutine("StopAndIdle", StopAndIdle());
		}
	}
}
