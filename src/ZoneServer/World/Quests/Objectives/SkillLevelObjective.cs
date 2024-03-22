using Melia.Shared.Game.Const;
using Melia.Zone.Events;

namespace Melia.Zone.World.Quests.Objectives
{
	/// <summary>
	/// An objective to reach a certain level on a skill.
	/// </summary>
	public class SkillLevelObjective : QuestObjective
	{
		/// <summary>
		/// Returns the id of the skill which this objective is about.
		/// </summary>
		public SkillId SkillId { get; }

		/// <summary>
		/// Returns the level that needs to be reached.
		/// </summary>
		public int Level { get; }

		/// <summary>
		/// Creates a quest objective to reach a certain level on the
		/// given skill.
		/// </summary>
		/// <param name="skillId"></param>
		/// <param name="level"></param>
		public SkillLevelObjective(SkillId skillId, int level)
		{
			this.SkillId = skillId;
			this.Level = level;
		}

		/// <summary>
		/// Sets up event subscriptions.
		/// </summary>
		public override void Load()
		{
			ZoneServer.Instance.ServerEvents.PlayerSkillLevelChanged += this.OnPlayerSkillLevelChanged;
		}

		/// <summary>
		/// Cleans up even subscriptions.
		/// </summary>
		public override void Unload()
		{
			ZoneServer.Instance.ServerEvents.PlayerSkillLevelChanged -= this.OnPlayerSkillLevelChanged;
		}

		/// <summary>
		/// Called when the level of a character's skill changes.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnPlayerSkillLevelChanged(object sender, PlayerSkillLevelChangedEventArgs args)
		{
			var character = args.Character;
			var skill = args.Skill;

			character.Quests.UpdateObjectives<SkillLevelObjective>((quest, objective, progress) =>
			{
				if (objective.SkillId != skill.Id || progress.Done)
					return;

				if (character.Skills.GetLevel(objective.SkillId) >= objective.Level)
				{
					progress.Count = 1;
					progress.Done = true;
				}
			});
		}
	}
}
