// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.World;
using System.Collections.Generic;
using Melia.Channel.World.SkillEffects;
using Melia.Shared.Const;
using Melia.Channel.World.SkillHandlers;
using Melia.Channel.World.AI;
using System.Threading;

namespace Melia.Channel.World
{
	public interface IEntity
	{
		int Handle { get; }
		int Hp { get; }
		int MaxHp { get; set; }
		Map Map { get; }
		Position Position { get; }
		Direction Direction { get; }
		bool IsDead { get; set; }

		/// <summary>
		/// Character's current speed.
		/// </summary>
		float Speed { get; set; }

		bool IsFade { get; set; }

		int PreparingSkillId { get; set; }

		List<SkillEffect> skillEffects { get; set; }

		SkillDataComponent SkillComp { get; set; }

		/// <summary>
		/// Character's level.
		/// </summary>
		int Level { get; set; }

		bool IncreaseSkillLevel { get; set; }

		bool IsAttacking { get; set; }
		void SetAttackState(bool isAttacking);

		Shape CollisionShape { get; set; }

		StatsManager statsManager { get; set; }
		SkillManager skillManager { get; set; }
		SkillEffectsManager skillEffectsManager { get; set; }

		float AdjustInfringedDamage(float damage);
		float AdjustReceivedDamage(float damage);
		void StopSkillEffects(Skill skill);

		/// <summary>
		/// Makes entity take damage and kills it if the HP reach 0.
		/// </summary>
		/// <param name="damage"></param>
		/// <param name="from"></param>
		int TakeDamage(int damage, IEntity from);

		void SetOneHitInmunity(bool activate);

		void CastSkill(Skill skill, IEntity target = null);

		int Heal(int amount, bool isPercent);

		TargetType GetTargetType(IEntity entity);

		float GetSpeed();

		void MoveTo(Position pos, int distance);
		bool UpdatePosition(int gameTicks);
		void MoveStop();
		bool IsMoving();

		AIBase AI { get; set; }

		Timer ShootTime { get; set; }
		bool CanShoot();

		void SetWalking();
		void SetRunning();
		bool IsRunning();

	}
}
