using System;
using System.Collections.Generic;
using Melia.Zone.Scripting.Hooking;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Quests;
using Melia.Zone.World.Quests.Modifiers;
using Melia.Zone.World.Quests.Prerequisites;
using Yggdrasil.Scripting;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// A script that sets up and manages quests.
	/// </summary>
	public abstract class QuestScript : IScript, IDisposable
	{
		private readonly static object ScriptsSyncLock = new();
		private readonly static Dictionary<QuestId, QuestScript> Scripts = new();
		private readonly static Dictionary<Type, QuestObjective> Objectives = new();
		private readonly static Dictionary<Type, QuestModifier> Modifiers = new();
		private readonly static List<QuestScript> AutoReceiveQuests = new();

		/// <summary>
		/// Returns this script's quest data.
		/// </summary>
		public QuestData Data { get; } = new QuestData();

		/// <summary>
		/// Returns the id of the quest this script created.
		/// </summary>
		public QuestId QuestId => this.Data.Id;

		/// <summary>
		/// Initializes script, creating the quest and saving it for
		/// later use.
		/// </summary>
		/// <returns></returns>
		public bool Init()
		{
			this.Load();

			if (this.Data.Id == QuestId.Zero)
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

				foreach (var modifier in this.Data.Modifiers)
				{
					var type = modifier.GetType();
					if (!Modifiers.ContainsKey(type))
					{
						Modifiers[type] = modifier;
						modifier.Load();
					}
				}

				if (this.Data.ReceiveType == QuestReceiveType.Auto)
					AutoReceiveQuests.Add(this);
			}

			return true;
		}

		/// <summary>
		/// Returns true if a quest script with the given id exists.
		/// </summary>
		/// <param name="questId"></param>
		/// <returns></returns>
		public static bool Exists(QuestId questId)
		{
			lock (ScriptsSyncLock)
				return Scripts.ContainsKey(questId);
		}

		/// <summary>
		/// Returns the quest script with the given id via out, returns
		/// false if no script was found.
		/// </summary>
		/// <param name="questId"></param>
		/// <param name="questScript"></param>
		/// <returns></returns>
		public static bool TryGet(QuestId questId, out QuestScript questScript)
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

				foreach (var questScript in AutoReceiveQuests)
				{
					if (character.Quests.Has(questScript.Data.Id))
						continue;

					if (!character.Quests.MeetsPrerequisites(questScript))
						continue;

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
				if (Objectives.Count != 0)
				{
					foreach (var objective in Objectives.Values)
						objective.Unload();

					Objectives.Clear();
				}

				if (Modifiers.Count != 0)
				{
					foreach (var modifier in Modifiers.Values)
						modifier.Unload();

					Modifiers.Clear();
				}

				if (Scripts.Count != 0)
				{
					Scripts.Clear();
				}

				if (AutoReceiveQuests.Count != 0)
				{
					AutoReceiveQuests.Clear();
				}
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
		[Obsolete("Use SetId(string, int) instead.")]
		protected void SetId(long id)
			=> this.SetId(null, id);

		/// <summary>
		/// Sets the quest's namespace and id.
		/// </summary>
		/// <remarks>
		/// Quests should be grouped within certain namespaces to reduce the risk
		/// of collisions. These may be based on the creator of the quest, the
		/// name of a questline, or any number of other factors.
		/// </remarks>
		/// <param name="questNamespace">Namespace to place the quest in.</param>
		/// <param name="id">The id of the quest within the given namespace. Valid range: 1-65535</param>
		protected void SetId(string questNamespace, long id)
			=> this.Data.Id = new QuestId(questNamespace, id);

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
		/// Sets the quest's location (map class name).
		/// </summary>
		/// <param name="mapClassName"></param>
		protected void SetLocation(string mapClassName)
			=> this.Data.Location = mapClassName;

		/// <summary>
		/// Sets the quest's locations (multiple map class names).
		/// </summary>
		/// <param name="mapClassNames">Map class names separated by commas</param>
		protected void SetLocation(params string[] mapClassNames)
			=> this.Data.Location = string.Join(",", mapClassNames);

		/// <summary>
		/// Sets the quest giver NPC name and location.
		/// </summary>
		/// <param name="npcName">The name of the NPC that gives the quest</param>
		/// <param name="mapClassName">The map class name where the NPC is located</param>
		protected void AddQuestGiver(string npcName, string mapClassName)
		{
			this.Data.StartNpcUniqueName = npcName;
			this.Data.QuestGiverLocation = mapClassName;
			if (string.IsNullOrEmpty(this.Data.Location))
				this.Data.Location = mapClassName;
		}

		/// <summary>
		/// Sets the quest's type.
		/// </summary>
		/// <param name="type"></param>
		protected void SetType(QuestType type)
			=> this.Data.Type = type;

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
		/// Sets whether whether the quest is automatically added to the list
		/// of tracked quests.
		/// </summary>
		/// <param name="enabled"></param>
		protected void SetAutoTracked(bool enabled)
			=> this.Data.AutoTrack = enabled;

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
		/// Adds an item drop modifier using item ID and monster IDs directly.
		/// </summary>
		/// <param name="itemId">The ID of the item to drop</param>
		/// <param name="dropChance">Drop probability (0.0 to 1.0, where 0.5 = 50%)</param>
		/// <param name="monsterIds">Monster IDs that should drop this item</param>
		protected void AddDrop(int itemId, float dropChance, params int[] monsterIds)
		{
			this.Data.Modifiers.Add(new ItemDropModifier(itemId, dropChance, monsterIds));
		}

		/// <summary>
		/// Returns an Or prerequisite, which is met if one of the given
		/// prerequisites is met.
		/// </summary>
		/// <param name="prerequisites"></param>
		/// <returns></returns>
		protected OrPrerequisite Or(params QuestPrerequisite[] prerequisites)
			=> new(prerequisites);

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
	[AttributeUsage(AttributeTargets.Class)]
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
