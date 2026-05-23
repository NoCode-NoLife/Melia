using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Scripting;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.World.Quests;
using Melia.Zone.World.Quests.Modifiers;
using Melia.Zone.World.Quests.Objectives;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// A character's quest manager.
	/// </summary>
	/// <remarks>
	/// Our current quest system is custom-made, as the system the game
	/// comes with is not very flexible. Using our own allows us to freely
	/// create custom quests, add features that wouldn't be available
	/// otherwise, and generally be independent of the game's ideas of
	/// quests. The downside is that our system might require some
	/// rethinking when trying to replicate the game's quests.
	/// </remarks>
	public class QuestComponent : CharacterComponent, IUpdateable
	{
		private readonly static TimeSpan AutoReceiveDelay = TimeSpan.FromMinutes(1);

		private readonly object _syncLock = new();
		private readonly List<Quest> _quests = new();
		private readonly List<long> _disabledQuests = new();

		private TimeSpan _autoReceiveDelay = AutoReceiveDelay;

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		public QuestComponent(Character character)
			: base(character)
		{
		}

		/// <summary>
		/// Notes the given quest db id as disabled.
		/// </summary>
		/// <remarks>
		/// Used to remember quests to keep around that are not currently
		/// loaded by the server, but should still be available to the
		/// character once they are. See quest loading and saving.
		/// </remarks>
		/// <param name="questDbId"></param>
		internal void AddDisabledQuest(long questDbId)
		{
			lock (_syncLock)
				_disabledQuests.Add(questDbId);
		}

		/// <summary>
		/// Returns a list of all disabled quests.
		/// </summary>
		/// <returns></returns>
		internal IList<long> GetDisabledQuests()
		{
			lock (_syncLock)
				return _disabledQuests.ToArray();
		}

		/// <summary>
		/// Returns true if the quest with the given database id is
		/// disabled.
		/// </summary>
		/// <param name="questDbId"></param>
		/// <returns></returns>
		internal bool IsDisabled(long questDbId)
		{
			lock (_syncLock)
				return _disabledQuests.Contains(questDbId);
		}

		/// <summary>
		/// Adds quest without informing the client.
		/// </summary>
		/// <remarks>
		/// This is primarily used while the character and its quests are
		/// loaded from the database.
		/// </remarks>
		/// <param name="quest"></param>
		public void AddSilent(Quest quest)
		{
			lock (_syncLock)
				_quests.Add(quest);
		}

		/// <summary>
		/// Gets quest by id and returns it via out, returns false if the
		/// quest didn't exist.
		/// </summary>
		/// <param name="questObjectId"></param>
		/// <param name="quest"></param>
		/// <returns></returns>
		public bool TryGet(long questObjectId, out Quest quest)
		{
			lock (_syncLock)
			{
				quest = _quests.FirstOrDefault(a => a.ObjectId == questObjectId);
				return quest != null;
			}
		}

		/// <summary>
		/// Gets quest by id and returns it via out, returns false if the
		/// quest didn't exist.
		/// </summary>
		/// <param name="questId"></param>
		/// <param name="quest"></param>
		/// <returns></returns>
		public bool TryGetById(QuestId questId, out Quest quest)
		{
			lock (_syncLock)
			{
				quest = _quests.FirstOrDefault(a => a.Data.Id == questId);
				return quest != null;
			}
		}

		/// <summary>
		/// Returns a list of all active quests.
		/// </summary>
		/// <returns></returns>
		public Quest[] GetInProgress()
		{
			lock (_syncLock)
				return _quests.Where(a => a.InProgress).ToArray();
		}

		/// <summary>
		/// Returns a list with all of the character's quests.
		/// </summary>
		/// <returns></returns>
		public Quest[] GetList()
		{
			lock (_syncLock)
				return _quests.ToArray();
		}

		/// <summary>
		/// Calls OnStart on the quest's objectives to go through the
		/// potential initial checks for whether the objective was
		/// possibly already completed.
		/// </summary>
		/// <param name="quest"></param>
		private void InitialChecks(Quest quest)
		{
			var checkedTypes = new HashSet<Type>();

			foreach (var objective in quest.Data.Objectives)
			{
				// Check every objective type only once, as they're designed
				// to check all of the quest's objectives at once.
				var type = objective.GetType();
				if (checkedTypes.Contains(type))
					continue;

				objective.OnStart(this.Character, quest);
				checkedTypes.Add(type);
			}
		}

		/// <summary>
		/// Iterates over the quests' objectives, runs the given function
		/// over all objectives with the given type, and updates the quest
		/// if any progresses changed.
		/// </summary>
		/// <typeparam name="TObjective"></typeparam>
		/// <param name="updater"></param>
		public void UpdateObjectives<TObjective>(QuestObjectivesUpdateFunc<TObjective> updater) where TObjective : QuestObjective
		{
			lock (_syncLock)
			{
				foreach (var quest in _quests)
				{
					if (quest.Status != QuestStatus.InProgress)
						continue;

					quest.UpdateObjectives(updater);

					if (quest.ChangesOnLastUpdate)
					{
						quest.UpdateUnlock();
						this.UpdateClient_UpdateQuest(quest);
					}
				}
			}
		}

		/// <summary>
		/// Iterates over the quests' modifiers, runs the given function
		/// over all modifiers with the given type, and updates the quest
		/// if any progresses changed.
		/// </summary>
		/// <typeparam name="TModifier"></typeparam>
		/// <param name="updater"></param>
		public void UpdateModifiers<TModifier>(QuestModifiersUpdateFunc<TModifier> updater) where TModifier : QuestModifier
		{
			lock (_syncLock)
			{
				foreach (var quest in _quests)
				{
					if (quest.Status != QuestStatus.InProgress)
						continue;

					quest.UpdateModifiers(updater);

					if (quest.ChangesOnLastUpdate)
					{
						quest.UpdateUnlock();
					}
				}
			}
		}

		/// <summary>
		/// Starts quest for the character, returns false if the quest
		/// couldn't be started.
		/// </summary>
		/// <param name="questId"></param>
		/// <returns></returns>
		public void Start(QuestId questId)
			=> this.Start(questId, TimeSpan.Zero);

		/// <summary>
		/// Adds quest and starts it after the given delay.
		/// </summary>
		/// <param name="questId"></param>
		/// <param name="delay"></param>
		/// <returns></returns>
		public void Start(QuestId questId, TimeSpan delay)
		{
			delay = Math2.Max(TimeSpan.Zero, delay);

			var quest = Quest.Create(questId);

			if (delay == TimeSpan.Zero)
			{
				this.Start(quest);
				this.AddSilent(quest);
			}
			else
			{
				quest.StartTime = DateTime.Now.Add(delay);
				this.AddSilent(quest);
			}
		}

		/// <summary>
		/// Starts the given quest, adding it to the character's quest log.
		/// </summary>
		/// <param name="quest"></param>
		/// <returns></returns>
		private void Start(Quest quest)
		{
			this.InitialChecks(quest);

			quest.Status = QuestStatus.InProgress;
			quest.UpdateUnlock();

			if (quest.StartTime == DateTime.MinValue)
				quest.StartTime = DateTime.Now;

			if (QuestScript.TryGet(quest.Data.Id, out var questScript))
				questScript.OnStart(this.Character, quest);

			this.UpdateClient_AddQuest(quest);
		}

		/// <summary>
		/// Returns true if a quest with the given id is currently in
		/// progress and the objective with the given identifier is
		/// unlocked, but hasn't been completed yet.
		/// </summary>
		/// <param name="questId"></param>
		/// <param name="objectiveIdent"></param>
		/// <returns></returns>
		public bool IsActive(QuestId questId, string objectiveIdent)
		{
			lock (_syncLock)
			{
				foreach (var quest in _quests)
				{
					if (!quest.InProgress || quest.Data.Id != questId)
						continue;

					if (!quest.TryGetProgress(objectiveIdent, out var progress))
						continue;

					if (progress.Unlocked && !progress.Done)
						return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Returns true if a quest with the given id is currently active,
		/// meaning that it was started, but not completed yet, even if
		/// all objectives were completed already.
		/// </summary>
		/// <param name="questId"></param>
		/// <returns></returns>
		public bool IsActive(QuestId questId)
		{
			lock (_syncLock)
			{
				foreach (var quest in _quests)
				{
					if (quest.InProgress && quest.Data.Id == questId)
						return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Returns true if the character has the quest, is slated to
		/// receive it soon, or has completed it in the past.
		/// </summary>
		/// <param name="questId"></param>
		/// <returns></returns>
		public bool Has(QuestId questId)
		{
			lock (_syncLock)
			{
				foreach (var quest in _quests)
				{
					if (quest.Data.Id != questId)
						continue;

					if (quest.Status < QuestStatus.Canceled)
						return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Returns true if the character meets the prerequisites to start the
		/// given quest.
		/// </summary>
		/// <param name="questNamespace"></param>
		/// <param name="id"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if no quest with the given id was found.
		/// </exception>
		public bool MeetsPrerequisites(string questNamespace, long id)
			=> this.MeetsPrerequisites(new QuestId(questNamespace, id));

		/// <summary>
		/// Returns true if the character meets the prerequisites to start the
		/// given quest.
		/// </summary>
		/// <param name="questId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if no quest with the given id was found.
		/// </exception>
		public bool MeetsPrerequisites(QuestId questId)
		{
			if (!QuestScript.TryGet(questId, out var questScript))
				throw new ArgumentException($"Quest '{questId}' not found.");

			return this.MeetsPrerequisites(questScript);
		}

		/// <summary>
		/// Returns true if the character meets the prerequisites to start the
		/// given quest.
		/// </summary>
		/// <param name="questScript"></param>
		/// <returns></returns>
		internal bool MeetsPrerequisites(QuestScript questScript)
		{
			foreach (var prerequisite in questScript.Data.Prerequisites)
			{
				if (!prerequisite.Met(this.Character))
					return false;
			}

			return true;
		}

		/// <summary>
		/// Returns true if the character has ever completed the quest
		/// before.
		/// </summary>
		/// <param name="questId"></param>
		/// <returns></returns>
		public bool HasCompleted(QuestId questId)
		{
			lock (_syncLock)
			{
				foreach (var quest in _quests)
				{
					if (quest.Data.Id != questId)
						continue;

					if (quest.Status == QuestStatus.Completed)
						return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Completes the objective on all quests with the given id.
		/// </summary>
		/// <param name="questId"></param>
		/// <param name="objectiveIdent"></param>
		public void Complete(QuestId questId, string objectiveIdent)
		{
			lock (_syncLock)
			{
				foreach (var quest in _quests)
				{
					if (!quest.InProgress || quest.Data.Id != questId)
						continue;

					if (!quest.TryGetProgress(objectiveIdent, out var progress))
						continue;

					if (!progress.Done)
					{
						progress.SetDone();
						quest.UpdateUnlock();
						this.UpdateClient_UpdateQuest(quest);
						continue;
					}
				}
			}
		}

		/// <summary>
		/// Completes the objective on all quests with the given id.
		/// </summary>
		/// <param name="questId"></param>
		/// <param name="objectiveIdent"></param>
		public void CompleteObjective(QuestId questId, string objectiveIdent)
			=> this.Complete(questId, objectiveIdent);

		/// <summary>
		/// Completes all quests with the given id and gives the rewards
		/// to the character.
		/// </summary>
		/// <param name="questId"></param>
		public void Complete(QuestId questId)
		{
			lock (_syncLock)
			{
				foreach (var quest in _quests)
				{
					if (!quest.InProgress || quest.Data.Id != questId)
						continue;

					this.Complete(quest);
				}
			}
		}

		/// <summary>
		/// Completes quest and gives rewards to character.
		/// </summary>
		/// <param name="quest"></param>
		public void Complete(Quest quest)
		{
			quest.Status = QuestStatus.Completed;
			quest.CompleteTime = DateTime.Now;
			quest.CompleteObjectives();

			if (QuestScript.TryGet(quest.Data.Id, out var questScript))
				questScript.OnComplete(this.Character, quest);

			this.GiveRewards(quest);

			this.UpdateClient_RemoveQuest(quest);
		}

		/// <summary>
		/// Removes quest from quest log.
		/// </summary>
		/// <param name="quest"></param>
		public void Cancel(Quest quest)
		{
			quest.Status = QuestStatus.Canceled;

			if (QuestScript.TryGet(quest.Data.Id, out var questScript))
				questScript.OnCancel(this.Character, quest);

			this.UpdateClient_RemoveQuest(quest);
		}

		/// <summary>
		/// Gives quest's rewards to character.
		/// </summary>
		/// <param name="quest"></param>
		private void GiveRewards(Quest quest)
		{
			foreach (var reward in quest.Data.Rewards)
				reward.Give(this.Character);

			this.UpdateClient_CompleteQuest(quest);
		}

		/// <summary>
		/// Updates the quests that weren't started yet, starting them
		/// once their start time was reached.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			var now = DateTime.Now;

			lock (_syncLock)
			{
				foreach (var quest in _quests)
				{
					if (quest.Status != QuestStatus.NotStarted)
						continue;

					if (quest.StartTime < now)
						this.Start(quest);
				}
			}

			// Check and start auto receive quests in regular intervals
			_autoReceiveDelay = Math2.Max(TimeSpan.Zero, _autoReceiveDelay - elapsed);
			if (_autoReceiveDelay == TimeSpan.Zero)
			{
				QuestScript.StartAutoReceiveQuests(this.Character);
				_autoReceiveDelay = AutoReceiveDelay;
			}
		}

		/// <summary>
		/// Sends a list of all quests to the client to update it.
		/// </summary>
		public void UpdateClient()
		{
			var quests = this.GetList();
			foreach (var quest in quests.Where(a => a.Status == QuestStatus.InProgress))
			{
				var questTable = this.QuestToTable(quest);

				var lua = "Melia.Quests.Restore(" + questTable.Serialize() + ")";
				Send.ZC_EXEC_CLIENT_SCP(this.Character.Connection, lua);
			}
		}

		/// <summary>
		/// Adds the quest to the client's quest log.
		/// </summary>
		/// <param name="quest"></param>
		private void UpdateClient_AddQuest(Quest quest)
		{
			var questTable = this.QuestToTable(quest);

			var table = new LuaTable();
			table.Insert("Op", "QuestAdd");
			table.Insert("Data", questTable);

			var lua = "Melia.Quests.Add(" + questTable.Serialize() + ")";
			Send.ZC_EXEC_CLIENT_SCP(this.Character.Connection, lua);

			//Log.Debug(lua);
		}

		/// <summary>
		/// Updates the quest objectives on the client.
		/// </summary>
		/// <param name="quest"></param>
		private void UpdateClient_UpdateQuest(Quest quest)
		{
			var objectivesTable = this.ObjectivesToTable(quest);

			var questTable = new LuaTable();
			questTable.Insert("ObjectId", "0x" + quest.ObjectId.ToString("X16"));
			questTable.Insert("Status", quest.Status.ToString());
			questTable.Insert("Done", quest.ObjectivesCompleted);
			questTable.Insert("Objectives", objectivesTable);

			var lua = "Melia.Quests.Update(" + questTable.Serialize() + ")";
			Send.ZC_EXEC_CLIENT_SCP(this.Character.Connection, lua);

			//Log.Debug(lua);
		}

		/// <summary>
		/// Removes the quest from the client's quest log.
		/// </summary>
		/// <param name="quest"></param>
		private void UpdateClient_RemoveQuest(Quest quest)
		{
			var lua = $"Melia.Quests.Remove('{quest.ObjectIdStr}')";
			Send.ZC_EXEC_CLIENT_SCP(this.Character.Connection, lua);
		}

		/// <summary>
		/// Notifies the client that the quest was completed.
		/// </summary>
		/// <param name="quest"></param>
		private void UpdateClient_CompleteQuest(Quest quest)
		{
			var lua = $"Melia.Quests.Remove('{quest.ObjectIdStr}')";
			Send.ZC_EXEC_CLIENT_SCP(this.Character.Connection, lua);
		}

		/// <summary>
		/// Returns all information about the quest as a Lua table.
		/// </summary>
		/// <param name="quest"></param>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		private LuaTable QuestToTable(Quest quest)
		{
			/// Quest
			/// {
			///		string ObjectId
			///		string ClassId
			///		string Name
			///		string Description
			///		string Type
			///		int Level
			///		string Status
			///		bool Done
			///		bool Cancelable
			///		
			///		Objectives[]
			///		{
			///			string Text
			///			bool Unlocked
			///			bool Done
			///			int Count
			///			int TargetCount
			///		}
			///		
			///		Rewards[]
			///		{
			///			string Text
			///			string Icon
			///		}
			/// }

			var objectivesTable = this.ObjectivesToTable(quest);

			var rewardsTable = new LuaTable();
			foreach (var reward in quest.Data.Rewards)
			{
				var rewardTable = new LuaTable();
				rewardTable.Insert("Text", reward.ToString());
				rewardTable.Insert("Icon", reward.Icon);

				rewardsTable.Insert(rewardTable);
			}

			var questTable = new LuaTable();

			// Convert map class name(s) to display name(s)
			string locationName = null;
			if (!string.IsNullOrEmpty(quest.Data.Location))
			{
				var mapClassNames = quest.Data.Location.Split(',');
				var mapNames = new List<string>();

				foreach (var mapClassName in mapClassNames)
				{
					var trimmedClassName = mapClassName.Trim();
					if (ZoneServer.Instance.World.TryGetMap(trimmedClassName, out var map))
						mapNames.Add(map.Data.Name);
					else
						mapNames.Add(trimmedClassName);
				}

				locationName = string.Join(", ", mapNames);
			}

			// Convert quest giver map class name to display name
			string questGiverLocationName = null;
			if (!string.IsNullOrEmpty(quest.Data.QuestGiverLocation))
			{
				if (ZoneServer.Instance.World.TryGetMap(quest.Data.QuestGiverLocation, out var map))
					questGiverLocationName = map.Data.Name;
				else
					questGiverLocationName = quest.Data.QuestGiverLocation;
			}

			questTable.Insert("ObjectId", "0x" + quest.ObjectId.ToString("X16"));
			questTable.Insert("ClassId", "0x" + quest.Data.Id.Value.ToString("X16"));
			questTable.Insert("Name", quest.Data.Name);
			questTable.Insert("Description", quest.Data.Description);
			questTable.Insert("Location", locationName);
			questTable.Insert("Type", quest.Data.Type.ToString());
			questTable.Insert("Level", quest.Data.Level);
			questTable.Insert("Status", quest.Status.ToString());
			questTable.Insert("Done", quest.ObjectivesCompleted);
			questTable.Insert("Cancelable", quest.Data.Cancelable);
			questTable.Insert("Tracked", quest.Tracked);
			questTable.Insert("Objectives", objectivesTable);
			questTable.Insert("Rewards", rewardsTable);

			// Add quest giver information if available
			if (!string.IsNullOrEmpty(quest.Data.StartNpcUniqueName))
				questTable.Insert("QuestGiver", quest.Data.StartNpcUniqueName);

			// Add quest giver location if available
			if (!string.IsNullOrEmpty(questGiverLocationName))
				questTable.Insert("QuestGiverLocation", questGiverLocationName);

			return questTable;
		}

		/// <summary>
		/// Returns information about the quests objectives and their
		/// progress as a Lua table.
		/// </summary>
		/// <returns></returns>
		/// <exception cref="InvalidOperationException"></exception>
		private LuaTable ObjectivesToTable(Quest quest)
		{
			var objectivesTable = new LuaTable();
			foreach (var objective in quest.Data.Objectives)
			{
				if (!quest.TryGetProgress(objective.Ident, out var progress))
					throw new InvalidOperationException($"Missing progress for objective '{objective.Ident}'.");

				var objectiveTable = new LuaTable();
				objectiveTable.Insert("Text", objective.Text);
				objectiveTable.Insert("Unlocked", progress.Unlocked);
				objectiveTable.Insert("Done", progress.Done);
				objectiveTable.Insert("Count", progress.Count);
				objectiveTable.Insert("TargetCount", objective.TargetCount);

				// Add monster names for collection objectives with drop modifiers
				if (objective is CollectItemObjective collectObjective)
				{
					var monsterNames = new List<string>();
					foreach (var modifier in quest.Data.Modifiers)
					{
						if (modifier is ItemDropModifier dropModifier && dropModifier.ItemId == collectObjective.ItemId)
						{
							foreach (var monsterId in dropModifier.MonsterIds)
							{
								if (ZoneServer.Instance.Data.MonsterDb.TryFind(monsterId, out var monsterData))
									monsterNames.Add(monsterData.Name);
							}
						}
					}

					if (monsterNames.Count > 0)
					{
						var monstersTable = new LuaTable();
						foreach (var monsterName in monsterNames)
							monstersTable.Insert(monsterName);
						objectiveTable.Insert("Monsters", monstersTable);
					}
				}

				objectivesTable.Insert(objectiveTable);
			}

			return objectivesTable;
		}
	}
}
