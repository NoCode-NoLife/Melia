// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.World;
using System.Collections.Generic;
using Melia.Channel.World.SkillEffects;

namespace Melia.Channel.World
{
	public interface IEntity
	{
		int Handle { get; }
		int Hp { get; }
		Map Map { get; }
		Position Position { get; }
		bool IsDead { get; set; }

		List<SkillEffect> skillEffects { get; set; }

		/// <summary>
		/// Character's level.
		/// </summary>
		int Level { get; set; }

		void SetAttackState(bool isAttacking);

		StatsManager statsManager { get; set; }
		SkillManager skillManager { get; set; }
		SkillEffectsManager skillEffectsManager { get; set; }

		float AdjustInfringedDamage(float damage);
		float AdjustReceivedDamage(float damage);
		void StopSkillEffects(Skill skill);
	}
}
