using System;
using System.Collections.Generic;
using Melia.Zone.Scripting.Hooking;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Quests;
using Melia.Zone.World.Quests.Prerequisites;
using Yggdrasil.Scripting;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// A script that sets up and manages quests.
	/// </summary>
	public abstract class QuestScript : IScript, IDisposable
	{
		private readonly static object ScriptsSyncLock = new object();
		private readonly static Dictionary<int, QuestScript> Scripts = new Dictionary<int, QuestScript>();
		private readonly static Dictionary<Type, QuestObjective> Objectives = new Dictionary<Type, QuestObjective>();
		private readonly static List<QuestScript> AutoReceiveQuests = new List<QuestScript>();

		/// <summary>
		/// Returns this script's quest data.
		/// </summary>
		public QuestData Data { get; } = new QuestData();

		/// <summary>
		/// Returns the id of the quest this script created.
		/// </summary>
		public int QuestId => this.Data.Id;

		/// <summary>
		/// Initializes script, creating the quest and saving it for
		/// later use.
		/// </summary>
		/// <returns></returns>
		public bool Init()
		{
			this.Load();

			if (this.Data.Id == 0)
				throw new MissingFieldException($"Quest '{this.GetType().Name}' has no id defined.");
			if (this.Data.Name == null)
				throw new MissingFieldException($"Quest '{this.GetType().Name}' has no name defined.");
			if (this.Data.Description == null)
				throw new MissingFieldException($"Quest '{this.GetType().Name}' has no description defined.");
			if (this.Data.Objectives.Count == 0)
				throw new MissingFieldException($"Quest '{this.GetType().Name}' has no objectives defined.");

			lock (ScriptsSyncLock)
			{
				Scripts[this.Data.Id] = this;

				foreach (var objective in this.Data.Objectives)
				{
					var type = objective.GetType();
					if (!Objectives.ContainsKey(type))
					{
						Objectives[type] = objective;
						objective.Load();
					}
				}

				if (this.Data.ReceiveType == QuestReceiveType.Auto)
					AutoReceiveQuests.Add(this);
			}

			return true;
		}

		/// <summary>
		/// Returns the quest script with the given id via out, returns
		/// false if no script was found.
		/// </summary>
		/// <param name="questId"></param>
		/// <param name="questScript"></param>
		/// <returns></returns>
		public static bool TryGet(int questId, out QuestScript questScript)
		{
			lock (ScriptsSyncLock)
				return Scripts.TryGetValue(questId, out questScript);
		}

		/// <summary>
		/// Starts auto receive quests for the character that they meet
		/// all prerequisites for.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public static void StartAutoReceiveQuests(Character character)
		{
			lock (ScriptsSyncLock)
			{
				if (AutoReceiveQuests.Count == 0)
					return;

				for (var i = 0; i < AutoReceiveQuests.Count; ++i)
				{
					var questScript = AutoReceiveQuests[i];

					// Skip if character already has the quest
					if (character.Quests.Has(questScript.Data.Id))
						continue;

					// Check if all prerequisites are met
					var allMet = true;
					for (var j = 0; j < questScript.Data.Prerequisites.Count; ++j)
					{
						var prerequisite = questScript.Data.Prerequisites[j];
						if (!prerequisite.Met(character))
							allMet = false;
					}

					if (!allMet)
						continue;

					// Start the quest
					character.Quests.Start(questScript.Data.Id, questScript.Data.StartDelay);
				}
			}
		}

		/// <summary>
		/// Cleans up saved quests and objectives.
		/// </summary>
		public void Dispose()
		{
			// Unload and remove all objectives that were saved for checking
			// whether they were done when even one quest script is disposed.
			// The only way quest scripts are gonna be disposed is if we
			// reload all of them, so it doesn't matter if we remove them
			// all at once, and this way we don't have to worry about
			// managing which script should unload which objective.

			lock (ScriptsSyncLock)
			{
				if (Objectives.Count == 0)
					return;

				foreach (var objective in Objectives.Values)
					objective.Unload();

				Objectives.Clear();
			}
		}

		/// <summary>
		/// Called during initialization to set the quest's values.
		/// </summary>
		protected abstract void Load();

		/// <summary>
		/// Sets the quest's id.
		/// </summary>
		/// <param name="id"></param>
		protected void SetId(int id)
			=> this.Data.Id = id;

		/// <summary>
		/// Sets the quest's name.
		/// </summary>
		/// <param name="name"></param>
		protected void SetName(string name)
			=> this.Data.Name = name;

		/// <summary>
		/// Sets the quest's description.
		/// </summary>
		/// <param name="description"></param>
		protected void SetDescription(string description)
			=> this.Data.Description = description;

		/// <summary>
		/// Sets how the quest handles objective unlocking.
		/// </summary>
		/// <param name="unlockType"></param>
		protected void SetUnlock(QuestUnlockType unlockType)
			=> this.Data.UnlockType = unlockType;

		/// <summary>
		/// Sets whether the quest can be cancelled.
		/// </summary>
		/// <param name="cancelable"></param>
		protected void SetCancelable(bool cancelable)
			=> this.Data.Cancelable = cancelable;

		/// <summary>
		/// Sets how the quest is given to players.
		/// </summary>
		/// <param name="receiveType"></param>
		protected void SetReceive(QuestReceiveType receiveType)
			=> this.Data.ReceiveType = receiveType;

		/// <summary>
		/// Sets the delay for automatically received quests, between
		/// meeting the prerequisites and the start of the quest.
		/// </summary>
		/// <param name="startDelay"></param>
		protected void SetDelay(TimeSpan startDelay)
			=> this.Data.StartDelay = startDelay;

		/// <summary>
		/// Adds objective to quest, that needs to be completed to finish
		/// the quest.
		/// </summary>
		/// <param name="ident"></param>
		/// <param name="description"></param>
		/// <param name="objective"></param>
		protected void AddObjective(string ident, string description, QuestObjective objective)
		{
			objective.Ident = ident;
			objective.Text = description;

			this.AddObjective(objective);
		}

		/// <summary>
		/// Adds objective to quest, that needs to be completed to finish
		/// the quest.
		/// </summary>
		/// <param name="objective"></param>
		private void AddObjective(QuestObjective objective)
		{
			if (this.Data.Objectives.Exists(a => a.Ident == objective.Ident))
				throw new ArgumentException($"Duplicate objective ident '{objective.Ident}' in '{this.GetType().Name}'.");

			this.Data.Objectives.Add(objective);
		}

		/// <summary>
		/// Adds reward to quest, that is given out when the quest was
		/// completed.
		/// </summary>
		/// <param name="reward"></param>
		protected void AddReward(QuestReward reward)
		{
			this.Data.Rewards.Add(reward);
		}

		/// <summary>
		/// Adds prerequisite to the quest.
		/// </summary>
		/// <param name="prerequisite"></param>
		protected void AddPrerequisite(QuestPrerequisite prerequisite)
		{
			this.Data.Prerequisites.Add(prerequisite);
		}

		/// <summary>
		/// Returns an Or prerequisite, which is met if one of the given
		/// prerequisites is met.
		/// </summary>
		/// <param name="prerequisites"></param>
		/// <returns></returns>
		protected OrPrerequisite Or(params QuestPrerequisite[] prerequisites)
			=> new OrPrerequisite(prerequisites);

		/// <summary>
		/// Registers a hook for a dialog.
		/// </summary>
		/// <param name="owner"></param>
		/// <param name="name"></param>
		/// <param name="func"></param>
		protected void AddDialogHook(string owner, string name, DialogHook.DialogHookFunc func)
		{
			var hook = new DialogHook(owner, name, func);
			ScriptHooks.Register(hook);
		}

		/// <summary>
		/// Called when a character receives this quest.
		/// </summary>
		/// <remarks>
		/// Called before the quest is added to the quest log, allowing
		/// for changes of its initial progress.
		/// </remarks>
		public virtual void OnStart(Character character, Quest quest)
		{
		}

		/// <summary>
		/// Called when a character completes this quest successfully.
		/// </summary>
		/// <remarks>
		/// Called after the quest was marked as completed, but before
		/// it's removed from the quest log and the rewards were given.
		/// </remarks>
		public virtual void OnComplete(Character character, Quest quest)
		{
		}

		/// <summary>
		/// Called when a character gives up this quest.
		/// </summary>
		/// <remarks>
		/// Called after the quest was marked as completed, but before
		/// it's removed from the quest log.
		/// </remarks>
		public virtual void OnCancel(Character character, Quest quest)
		{
		}
	}

	/// <summary>
	/// Used to define which quest scripts handle which quests, based on
	/// a quest id.
	/// </summary>
	public class QuestScriptAttribute : Attribute
	{
		/// <summary>
		/// Returns the quest id of quest script.
		/// </summary>
		public int QuestId { get; }

		/// <summary>
		/// Returns the priority of this attribute.
		/// </summary>
		public int Priority { get; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="questId"></param>
		/// <param name="priority"></param>
		public QuestScriptAttribute(int questId, int priority = 0)
		{
			this.QuestId = questId;
			this.Priority = priority;
		}
	}
}
