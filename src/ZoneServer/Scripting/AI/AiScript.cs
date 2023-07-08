using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Ai.Enumerable;
using Yggdrasil.Scheduling;
using Yggdrasil.Scripting;

namespace Melia.Zone.Scripting.AI
{
	/// <summary>
	/// A script that sets up and controls a character or monster.
	/// </summary>
	public abstract partial class AiScript : EnumerableAi, IScript, IUpdateable
	{
		private bool _initiated;

		private TendencyType _tendency;
		private float _visibleRange = 300;
		private float _hateRange = 100;
		private float _hatePerSecond = 20;
		private readonly float _hatePerHit = 100;
		private float _overHateRate = 1 / 20f;
		private float _minAggroHateLevel = 100;
		private readonly HashSet<int> _hateLevelsToRemove = new HashSet<int>();
		private readonly Dictionary<int, float> _hateLevels = new Dictionary<int, float>();

		private readonly HashSet<FactionType> _hatedFactions = new HashSet<FactionType>();
		private readonly HashSet<int> _hatedMonsters = new HashSet<int>();

		private readonly Dictionary<string, List<Action>> _duringActions = new Dictionary<string, List<Action>>();

		private readonly Queue<IAiEventAlert> _eventAlerts = new Queue<IAiEventAlert>();

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

			this.Setup();

			_initiated = true;
		}

		/// <summary>
		/// Executes the AI, furthering the current routine.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			if (!_initiated)
				throw new InvalidOperationException("AI has not been initiated.");

			if (this.Entity.IsDead || this.Entity.Map.CharacterCount == 0)
				return;

			this.UpdateHate(elapsed);
			this.HandleEventAlerts();
			this.ExecuteDuringActions();
			this.Heartbeat();
		}

		/// <summary>
		/// Updates hate levels for potentialy nearby enemies.
		/// </summary>
		/// <param name="elapsed"></param>
		private void UpdateHate(TimeSpan elapsed)
		{
			var potentialEnemies = this.Entity.Map.GetAttackableEntitiesInRange(this.Entity, this.Entity.Position, _visibleRange);

			this.RemoveNonNearbyHate(elapsed, potentialEnemies);
			this.IncreaseNearbyHate(elapsed, potentialEnemies);
		}

		/// <summary>
		/// Removes hate levels of enemies that are no longer nearby.
		/// </summary>
		/// <param name="elapsed"></param>
		/// <param name="potentialEnemies"></param>
		private void RemoveNonNearbyHate(TimeSpan elapsed, IEnumerable<ICombatEntity> potentialEnemies)
		{
			_hateLevelsToRemove.Clear();

			foreach (var entry in _hateLevels)
			{
				var handle = entry.Key;

				if (!potentialEnemies.Any(a => a.Handle == handle))
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
		private void IncreaseNearbyHate(TimeSpan elapsed, IEnumerable<ICombatEntity> potentialEnemies)
		{
			// Only increase hate for nearby enemies if the AI has
			// aggressive tendencies
			if (_tendency == TendencyType.Peaceful)
				return;

			// Increase hate for enemies that the entity is hostile towards
			var potentialEnemiesInRange = potentialEnemies.Where(a => a.Position.InRange2D(this.Entity.Position, _hateRange));

			foreach (var potentialEnemy in potentialEnemiesInRange)
			{
				if (!this.IsHostileTowards(potentialEnemy))
					continue;

				if (potentialEnemy.Components.Get<BuffComponent>().Has(BuffId.Cloaking_Buff))
					continue;

				var handle = potentialEnemy.Handle;
				var amount = (float)(_hatePerSecond * elapsed.TotalSeconds);

				this.IncreaseHate(potentialEnemy, amount);
			}
		}

		/// <summary>
		/// Increases hate towards the entity with the given entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="amount"></param>
		protected void IncreaseHate(ICombatEntity entity, float amount)
		{
			var handle = entity.Handle;

			// Increase the hate level at the normal rate up to the
			// min aggro level. Once we reach that point we lower
			// the hate increase so it will still accumulate for
			// an enemy, but not at such a rate that other enemies
			// couldn't potentially keep up. In theory this should
			// make it possible to steal aggro, but not too easily.

			if (!_hateLevels.ContainsKey(handle))
				_hateLevels[handle] = 0;

			if (_hateLevels[handle] >= _minAggroHateLevel)
				amount *= _overHateRate;

			// Hate increases 500% faster if entity has the Liberate buff.
			// This means instant aggro from aggressive monsters and a
			// higher chance to keep it.
			if (entity.Components.Get<BuffComponent>().Has(BuffId.Liberate_Buff))
				amount *= 5;

			_hateLevels[handle] += amount;

			//Log.Debug("Monster {0} hate level for {1} is now {2}.", this.Entity, handle, _hateLevels[handle]);
		}

		/// <summary>
		/// Returns true if the AI's entity is hostile towards the given
		/// entity based on the factions they belong to.
		/// </summary>
		/// <param name="otherEntity"></param>
		/// <returns></returns>
		public virtual bool IsHostileTowards(ICombatEntity otherEntity)
		{
			if (_hatedFactions.Contains(otherEntity.Faction))
				return true;

			if (otherEntity is Mob mob && _hatedMonsters.Contains(mob.Id))
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
		/// Makes AI hostile towards the given monsters.
		/// </summary>
		/// <param name="monsterIds"></param>
		protected void HatesMonster(params int[] monsterIds)
		{
			_hatedMonsters.UnionWith(monsterIds);
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
		/// Returns true if the hate towards the given entity is above
		/// the aggro threshold.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		protected bool IsHating(ICombatEntity entity)
		{
			if (!_hateLevels.TryGetValue(entity.Handle, out var hate))
				return false;

			return (hate >= _minAggroHateLevel);
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
		/// Handles events that happened since the last tick.
		/// </summary>
		private void HandleEventAlerts()
		{
			lock (_eventAlerts)
			{
				while (_eventAlerts.Count > 0)
				{
					var eventAlert = _eventAlerts.Dequeue();

					switch (eventAlert)
					{
						case HitEventAlert hitEventAlert:
						{
							if (hitEventAlert.Target.Handle == this.Entity.Handle)
								this.IncreaseHate(hitEventAlert.Attacker, _hatePerHit);
							break;
						}

						case HateResetAlert hateResetAlert:
						{
							var targetHandle = hateResetAlert.Target.Handle;
							_hateLevels.Remove(targetHandle);
							break;
						}
					}
				}
			}
		}

		/// <summary>
		/// Queues up an alert about something that happened for the AI to
		/// potentially react to.
		/// </summary>
		/// <param name="eventAlert"></param>
		public void QueueEventAlert(IAiEventAlert eventAlert)
		{
			lock (_eventAlerts)
				_eventAlerts.Enqueue(eventAlert);
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

		/// <summary>
		/// Sets whether the entity is running, which potentially affects
		/// its movement speed.
		/// </summary>
		/// <param name="running"></param>
		protected void SetRunning(bool running)
		{
			var moveSpeedType = running ? MoveSpeedType.Run : MoveSpeedType.Walk;
			this.Entity.Components.Get<MovementComponent>().SetMoveSpeedType(moveSpeedType);
		}
	}
}
