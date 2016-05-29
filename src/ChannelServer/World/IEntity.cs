// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.World;
namespace Melia.Channel.World
{
	public interface IEntity
	{
		int Handle { get; }
		int Hp { get; }
		Map Map { get; }
		Position Position { get; }
		bool IsDead { get; set; }

		/// <summary>
		/// Character's level.
		/// </summary>
		int Level { get; set; }

		void SetAttackState(bool isAttacking);

		StatsManager statsManager { get; set; }
		BuffManager buffManager { get; set; }
	}
}
