using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.Skills;
using Melia.Channel.Util;
using Melia.Channel.World.Entities;

namespace Melia.Channel.World
{
	/// <summary>
	/// Holds public events.
	/// </summary>
	public class EventManager
	{
		//-------------------------------------------------------------------
		//  Time Events
		//-------------------------------------------------------------------

		/// <summary>
		/// Raised every second in real time.
		/// </summary>
		public event Action<TimeSpan> SecondsTimeTick;
		public void OnSecondsTimeTick(TimeSpan now) => SecondsTimeTick?.Invoke(now);

		/// <summary>
		/// Raised every minute in real time.
		/// </summary>
		public event Action<TimeSpan> MinutesTimeTick;
		public void OnMinutesTimeTick(TimeSpan now) => MinutesTimeTick?.Invoke(now);

		/// <summary>
		/// Raised every hour in real time.
		/// </summary>
		public event Action<TimeSpan> HoursTimeTick;
		public void OnHoursTimeTick(TimeSpan now) => HoursTimeTick?.Invoke(now);

		//-------------------------------------------------------------------
		//  Player Events
		//-------------------------------------------------------------------

		/// <summary>
		/// For sending any packets that need to be sent
		/// to each and every character on login
		/// </summary>
		/// <remarks>
		/// Examples: Enabling/disabling client features
		/// </remarks>
		public event Action<IEntity> EntityConnecting;
		public void OnEntityConnecting(IEntity entity) => EntityConnecting?.Invoke(entity);

		/// <summary>
		/// For sending packets that need to be sent
		/// to specific characters on login
		/// </summary>
		/// <remarks>
		/// Examples: Initial values for enabled features
		/// </remarks>
		public event Action<IEntity> EntityConnected;
		public void OnEntityConnected(IEntity entity) => EntityConnected?.Invoke(entity);

		/// <summary>
		/// Raised a few seconds after player logged in.
		/// </summary>
		public event Action<IEntity> PlayerLoggedIn;
		public void OnPlayerLoggedIn(IEntity entity) => PlayerLoggedIn?.Invoke(entity);

		/// <summary>
		/// Raised when a player disconnects from server.
		/// </summary>
		public event Action<IEntity> PlayerDisconnect;
		public void OnPlayerDisconnect(IEntity entity) => PlayerDisconnect?.Invoke(entity);

		/// <summary>
		/// Raised when player enters a region.
		/// </summary>
		public event Action<IEntity> PlayerEntersMap;
		public void OnPlayerEntersMap(IEntity entity) => PlayerEntersMap?.Invoke(entity);

		/// <summary>
		/// Raised when player leaves a region.
		/// </summary>
		public event Action<IEntity> PlayerLeavesMap;
		public void OnPlayerLeavesMap(IEntity entity) => PlayerLeavesMap?.Invoke(entity);

		/// <summary>
		/// Raised when player drops, destroys, sells,
		/// uses (decrements), etcs an item.
		/// </summary>
		public event Action<IEntity, int, int> PlayerRemovesItem;
		public void OnPlayerRemovesItem(IEntity entity, int itemId, int amount) => PlayerRemovesItem?.Invoke(entity, itemId, amount);

		/// <summary>
		/// Raised when player receives an item in any way.
		/// </summary>
		public event Action<IEntity, int, int> PlayerReceivesItem;
		public void OnPlayerReceivesItem(IEntity entity, int itemId, int amount) => PlayerReceivesItem?.Invoke(entity, itemId, amount);

		/// <summary>
		/// Raised when player uses an item.
		/// </summary>
		public event Action<IEntity, Item> PlayerUsesItem;
		public void OnPlayerUsesItem(IEntity entity, Item item) => PlayerUsesItem?.Invoke(entity, item);

		/// <summary>
		/// Raised when player equips an item.
		/// </summary>
		public event Action<IEntity, Item> PlayerEquipsItem;
		public void OnPlayerEquipsItem(IEntity entity, Item item) => PlayerEquipsItem?.Invoke(entity, item);

		/// <summary>
		/// Raised when player unequips an item.
		/// </summary>
		public event Action<IEntity, Item> PlayerUnequipsItem;
		public void OnPlayerUnequipsItem(IEntity entity, Item item) => PlayerUnequipsItem?.Invoke(entity, item);

		/// <summary>
		/// Raised when player completes a quest.
		/// </summary>
		public event Action<IEntity, int> PlayerCompletesQuest;
		public void OnPlayerCompletesQuest(IEntity entity, int questId) => PlayerCompletesQuest?.Invoke(entity, questId);

		/// <summary>
		/// Raised when skill rank changes.
		/// </summary>
		public event Action<IEntity, Skill> SkillRankChanged;
		public void OnSkillRankChanged(IEntity entity, Skill skill) => SkillRankChanged?.Invoke(entity, skill);

		/// <summary>
		/// Raised when player used skill.
		/// </summary>
		public event Action<IEntity, Skill> PlayerUsedSkill;
		public void OnPlayerUsedSkill(IEntity entity, Skill skill) => PlayerUsedSkill?.Invoke(entity, skill);

		// ------------------------------------------------------------------

		/// <summary>
		/// Raised when an entity is killed by something, regardless of
		/// whether it's already finished as well.
		/// </summary>
		public event Action<IEntity, IEntity> EntityKilled;
		public void OnEntityKilled(IEntity entity, IEntity killer) => EntityKilled?.Invoke(entity, killer);

		/// <summary>
		/// Raised when an entity is killed by a player, regardless of
		/// whether it's already finished as well.
		/// </summary>
		public event Action<IEntity, IEntity> EntityKilledByPlayer;
		public void OnEntityKilledByPlayer(IEntity entity, IEntity killer) => EntityKilledByPlayer?.Invoke(entity, killer);

		/// <summary>
		/// Raised when an entity is finished by something. It's called if
		/// no finishing happens as well, when going straight to being
		/// completely dead.
		/// </summary>
		public event Action<IEntity, IEntity> EntityFinished;
		public void OnEntityFinished(IEntity entity, IEntity killer) => EntityFinished?.Invoke(entity, killer);

		/// <summary>
		/// Raised when an entity is finished by a player. It's called if
		/// no finishing happens as well, when going straight to being
		/// completely dead.
		/// </summary>
		public event Action<IEntity, IEntity> EntityFinishedByPlayer;
		public void OnEntityFinishedByPlayer(IEntity entity, IEntity killer) => EntityFinishedByPlayer?.Invoke(entity, killer);
	}
}
