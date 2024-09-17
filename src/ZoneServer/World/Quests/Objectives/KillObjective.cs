using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Zone.Events;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.World.Quests.Objectives
{
	/// <summary>
	/// Objective to kill certain monsters.
	/// </summary>
	public class KillObjective : QuestObjective
	{
		/// <summary>
		/// Returns the tags which monsters must match to qualify for this
		/// objective.
		/// </summary>
		public HashSet<int> MonsterIds { get; }

		/// <summary>
		/// Creates an objective to kill a certain amount of one of the
		/// given types of monsters.
		/// </summary>
		/// <param name="monsterIds"></param>
		/// <param name="amount"></param>
		public KillObjective(int amount, params int[] monsterIds)
		{
			if (monsterIds == null || monsterIds.Length == 0)
				throw new ArgumentException("Must specify at least one monster id.");

			this.TargetCount = amount;
			this.MonsterIds = new HashSet<int>(monsterIds);
		}

		/// <summary>
		/// Sets up event subscriptions.
		/// </summary>
		public override void Load()
		{
			ZoneServer.Instance.ServerEvents.EntityKilled += this.OnEntityKilled;
		}

		/// <summary>
		/// Cleans up event subscriptions.
		/// </summary>
		public override void Unload()
		{
			ZoneServer.Instance.ServerEvents.EntityKilled -= this.OnEntityKilled;
		}

		/// <summary>
		/// Called when a character dies.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnEntityKilled(object sender, CombatEventArgs args)
		{
			if (args.Target is not IMonster monster)
				return;

			if (args.Attacker is not Character character)
				return;

			character.Quests.UpdateObjectives<KillObjective>((quest, objective, progress) =>
			{
				if (objective.IsTarget(monster))
				{
					progress.Count = Math.Min(objective.TargetCount, progress.Count + 1);
					progress.Done = progress.Count >= objective.TargetCount;
				}
			});
		}

		/// <summary>
		/// Returns true if the given monster is a target for this objective.
		/// </summary>
		/// <param name="monster"></param>
		/// <returns></returns>
		private bool IsTarget(IMonster monster)
		{
			return this.MonsterIds.Contains(monster.Id);
		}
	}
}
