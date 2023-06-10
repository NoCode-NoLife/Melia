using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using Melia.Shared.Tos.Const;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Ai.Enumerable;
using Yggdrasil.Logging;
using Yggdrasil.Scheduling;
using Yggdrasil.Scripting;

namespace Melia.Zone.Scripting.AI
{
	/// <summary>
	/// A script that sets up and controls a character or monster.
	/// </summary>
	public abstract partial class AiScript : EnumerableAi, IScript, IUpdateable
	{
		private bool _setupDone;

		private TendencyType _tendency;
		private float _hateRange = 100;
		private float _hatePerSecond = 20;
		private float _overHateRate = 1 / 20f;
		private float _minAggroHateLevel = 100;
		private readonly HashSet<int> _hateLevelsToRemove = new HashSet<int>();
		private readonly Dictionary<int, float> _hateLevels = new Dictionary<int, float>();
		private readonly HashSet<FactionType> _hatedFactions = new HashSet<FactionType>();

		private readonly Dictionary<string, List<Action>> _duringActions = new Dictionary<string, List<Action>>();

		/// <summary>
		/// Returns the entity that this script is controlling.
		/// </summary>
		public ICombatEntity Entity { get; private set; }

		/// <summary>
		/// Returns the name of the currently running routine if it
		/// was named.
		/// </summary>
		public string CurrentRoutine { get; private set; }

		/// <summary>
		/// Initializes AI for the given entity, setting the initial
		/// hostility and tendency.
		/// </summary>
		/// <param name="combatEntity"></param>
		internal void InitFor(ICombatEntity combatEntity)
		{
			this.Entity = combatEntity;

			if (combatEntity is Mob mob)
				this.SetTendency(mob.Tendency);

			if (ZoneServer.Instance.Data.FactionDb.TryFind(this.Entity.Faction, out var factionData))
				this.HatesFaction(factionData.Hostile);
		}

		/// <summary>
		/// Executes the AI, furthering the current routine.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			if (!_setupDone)
			{
				this.Setup();
				_setupDone = true;
			}

			if (this.Entity.IsDead)
				return;

			this.UpdateHate(elapsed);
			this.ExecuteDuringActions();
			this.Heartbeat();
		}

		/// <summary>
		/// Updates hate levels for potentialy nearby enemies.
		/// </summary>
		/// <param name="elapsed"></param>
		private void UpdateHate(TimeSpan elapsed)
		{
			var potentialEnemies = this.Entity.Map.GetAttackableEntitiesInRange(this.Entity, this.Entity.Position, _hateRange);

			this.RemoveNonNearbyHate(elapsed, potentialEnemies);
			this.IncreaseNearbyHate(elapsed, potentialEnemies);
		}

		/// <summary>
		/// Removes hate levels of enemies that are no longer nearby.
		/// </summary>
		/// <param name="elapsed"></param>
		/// <param name="potentialEnemies"></param>
		private void RemoveNonNearbyHate(TimeSpan elapsed, List<ICombatEntity> potentialEnemies)
		{
			_hateLevelsToRemove.Clear();

			foreach (var entry in _hateLevels)
			{
				var handle = entry.Key;

				if (!potentialEnemies.Exists(a => a.Handle == handle))
					_hateLevelsToRemove.Add(handle);
			}

			foreach (var handle in _hateLevelsToRemove)
				_hateLevels.Remove(handle);
		}

		/// <summary>
		/// Increase hate levels of enemies that are nearby.
		/// </summary>
		/// <param name="elapsed"></param>
		/// <param name="potentialEnemies"></param>
		private void IncreaseNearbyHate(TimeSpan elapsed, List<ICombatEntity> potentialEnemies)
		{
			// Only increase hate for nearby enemies if the AI has
			// aggressive tendencies
			if (_tendency == TendencyType.Peaceful)
				return;

			// Increase hate for enemies that the entity is hostile towards
			foreach (var potentialEnemy in potentialEnemies)
			{
				if (!this.IsHostileTowards(potentialEnemy))
					continue;

				var handle = potentialEnemy.Handle;

				if (!_hateLevels.ContainsKey(handle))
					_hateLevels[handle] = 0;

				// Increase the hate level at the normal rate up to the
				// min aggro level. Once we reach that point we lower
				// the hate increase so it will still accumulate for
				// an enemy, but not at such a rate that other enemies
				// couldn't potentially keep up. In theory this should
				// make it possible to steal aggro, but not too easily.

				var hatePerSecond = _hatePerSecond;
				if (_hateLevels[handle] >= _minAggroHateLevel)
					hatePerSecond = _hatePerSecond * _overHateRate;

				_hateLevels[handle] += (float)(hatePerSecond * elapsed.TotalSeconds);

				//Log.Debug("Hating {0}: {1}", potentialEnemy.Name, _hateLevels[handle]);
			}
		}

		/// <summary>
		/// Returns true if the AI's entity is hostile towards the given
		/// entity based on the factions they belong to.
		/// </summary>
		/// <param name="otherEntity"></param>
		/// <returns></returns>
		protected virtual bool IsHostileTowards(ICombatEntity otherEntity)
		{
			if (_hatedFactions.Contains(otherEntity.Faction))
				return true;

			return false;
		}

		/// <summary>
		/// Makes AI hostile towards the given factions.
		/// </summary>
		/// <param name="faction"></param>
		protected void HatesFaction(params FactionType[] factions)
			=> this.HatesFaction((IEnumerable<FactionType>)factions);

		/// <summary>
		/// Makes AI hostile towards the given factions.
		/// </summary>
		/// <param name="faction"></param>
		protected void HatesFaction(IEnumerable<FactionType> factions)
		{
			_hatedFactions.UnionWith(factions);
		}

		/// <summary>
		/// Removes all hate factors, such as hostility towards factions.
		/// </summary>
		protected void ClearHate()
		{
			_hatedFactions.Clear();
		}

		/// <summary>
		/// Returns the enemy with the highest hate level in range.
		/// </summary>
		/// <returns></returns>
		protected ICombatEntity GetMostHated()
		{
			var highestHate = 0f;
			ICombatEntity mostHated = null;

			foreach (var entry in _hateLevels)
			{
				var handle = entry.Key;
				var hate = entry.Value;

				if (hate > highestHate)
				{
					highestHate = hate;
					mostHated = this.Entity.Map.GetCombatEntity(handle);
				}
			}

			if (highestHate < _minAggroHateLevel)
				return null;

			return mostHated;
		}

		/// <summary>
		/// Executed once during the AI's first tick.
		/// </summary>
		protected virtual void Setup()
		{
		}

		/// <summary>
		/// Sets up the given action to execute on every tick while the
		/// routine is active.
		/// </summary>
		/// <param name="routineName"></param>
		/// <param name="action"></param>
		protected void During(string routineName, Action action)
		{
			if (!_duringActions.TryGetValue(routineName, out var list))
				_duringActions[routineName] = list = new List<Action>();

			if (!list.Contains(action))
				list.Add(action);
		}

		/// <summary>
		/// Sets the range in which the AI will detect enemies.
		/// </summary>
		/// <param name="range"></param>
		protected void SetHateRange(float range)
		{
			_hateRange = range;
		}

		/// <summary>
		/// Sets the amount of hate the AI accumulates per second for
		/// a potential enemy.
		/// </summary>
		/// <param name="hatePerSecond"></param>
		/// <param name="decreasedHatePerSecond"></param>
		protected void SetHatePerSecond(float hatePerSecond, float decreasedHatePerSecond)
		{
			_hatePerSecond = hatePerSecond;
		}

		/// <summary>
		/// Sets the rate at which which the AI accumulates hate for
		/// an enemy that is already past the minimum aggro level.
		/// </summary>
		/// <param name="overHateRate"></param>
		protected void SetOverHateRate(float overHateRate)
		{
			_overHateRate = overHateRate;
		}

		/// <summary>
		/// Sets the minimum hate level required for the AI to consider
		/// a potential enemy an actual enemy.
		/// </summary>
		/// <param name="minAggroHateLevel"></param>
		protected void SetMinHate(float minAggroHateLevel)
		{
			_minAggroHateLevel = minAggroHateLevel;
		}

		/// <summary>
		/// Sets the AI's tendency to attack.
		/// </summary>
		/// <param name="tendency"></param>
		protected void SetTendency(TendencyType tendency)
		{
			_tendency = tendency;
		}

		/// <summary>
		/// Executes the actions set up to occur while a specific routine
		/// is running.
		/// </summary>
		private void ExecuteDuringActions()
		{
			var currentRoutine = this.CurrentRoutine;
			if (currentRoutine == null)
				return;

			if (!_duringActions.TryGetValue(currentRoutine, out var actions))
				return;

			foreach (var action in actions)
			{
				action();

				// Stop if the action changed the current routine
				if (this.CurrentRoutine != currentRoutine)
					break;
			}
		}

		/// <summary>
		/// Called whenever the AI finishes a routine and doesn't
		/// know what to do next.
		/// </summary>
		protected override void Root()
		{
		}

		/// <summary>
		/// Starts executing the given routine and saves its name.
		/// </summary>
		/// <param name="routineName"></param>
		/// <param name="routine"></param>
		public void StartRoutine(string routineName, IEnumerable routine)
		{
			this.CurrentRoutine = routineName;
			this.StartRoutine(routine);
		}

		/// <summary>
		/// Returns true if the entity is dead or gone.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		protected bool EntityGone(ICombatEntity entity)
		{
			if (entity == null)
				return true;

			if (entity.IsDead)
				return true;

			if (this.Entity.Map.GetCombatEntity(entity.Handle) == null)
				return true;

			return false;
		}

		/// <summary>
		/// Returns true if the entity is in range of the given target.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="range"></param>
		/// <returns></returns>
		protected bool InRangeOf(ICombatEntity entity, float range)
		{
			return this.Entity.Position.InRange2D(entity.Position, (int)range);
		}
	}
}
