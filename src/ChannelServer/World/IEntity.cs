// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.World;
using System.Collections.Generic;
using Melia.Channel.World.SkillEffects;
using Melia.Shared.Const;

namespace Melia.Channel.World
{
	public interface IEntity
	{
		int Handle { get; }
		int Hp { get; }
		int MaxHp { get; set; }
		Map Map { get; }
		Position Position { get; }
		bool IsDead { get; set; }

		bool IsFade { get; set; }

		List<SkillEffect> skillEffects { get; set; }

		/// <summary>
		/// Character's level.
		/// </summary>
		int Level { get; set; }

		bool IncreaseSkillLevel { get; set; }

		void SetAttackState(bool isAttacking);

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
		void TakeDamage(int damage, IEntity from);

		void SetOneHitInmunity(bool activate);

		void CastSkill(Skill skill);

		int Heal(int amount, bool isPercent);

		TargetType GetTargetType(IEntity entity);


	}
}
