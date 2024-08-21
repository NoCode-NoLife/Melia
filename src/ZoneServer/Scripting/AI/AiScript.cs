using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
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
		private bool _initiated;

		private int _masterHandle;

		private DateTime _lastPlayerSeenTime;
		private readonly TimeSpan _inactivityDelay = TimeSpan.FromSeconds(2);

		private TendencyType _tendency;
		private float _viewRange = 300;
		private float _hateRange = 100;
		private float _hatePerSecond = 20;
		private readonly float _hatePerHit = 100;
		private float _overHateRate = 1 / 20f;
		private float _minAggroHateLevel = 100;

		private readonly HashSet<int> _hateLevelsToRemove = new();
		private readonly Dictionary<int, float> _hateLevels = new();
		private readonly HashSet<FactionType> _hatedFactions = new();
		private readonly HashSet<int> _hatedMonsters = new();

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
		/// Switches the AI's faction and the associated hate.
		/// </summary>
		/// <param name="faction"></param>
		protected void SwitchFaction(FactionType faction)
		{
			if (this.Entity is Mob mob)
				mob.Faction = faction;

			this.ClearHate();

			if (ZoneServer.Instance.Data.FactionDb.TryFind(faction, out var factionData))
				this.HatesFaction(factionData.Hostile);
		}

		/// <summary>
		/// Executes the AI, furthering the current routine.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			if (!_initiated)
				throw new InvalidOperationException("AI has not been initiated.");

			if (this.Entity.IsDead)
				return;

			if (!this.CheckAnyPlayersOnMap())
				return;

			this.UpdateHate(elapsed);
			this.HandleEventAlerts();
			this.ExecuteDuringActions();
			this.Heartbeat();
		}

		/// <summary>
		/// Returns true if there are any players on the entity's map.
		/// </summary>
		/// <remarks>
		/// This method keeps returning true for a short time after the last
		/// player left the map so the AI can react to players leaving.
		/// </remarks>
		/// <returns></returns>
		private bool CheckAnyPlayersOnMap()
		{
			var playerCount = this.Entity.Map.CharacterCount;

			if (playerCount > 0)
			{
				_lastPlayerSeenTime = DateTime.Now;
				return true;
			}

			if (playerCount == 0)
			{
				var inactivityStart = _lastPlayerSeenTime + _inactivityDelay;
				if (DateTime.Now < inactivityStart)
					return true;
			}

			return false;
		}

		/// <summary>
		/// Updates hate levels for potentialy nearby enemies.
		/// </summary>
		/// <param name="elapsed"></param>
		private void UpdateHate(TimeSpan elapsed)
		{
			var potentialEnemies = this.Entity.Map.GetAttackableEntitiesInRange(this.Entity, this.Entity.Position, _viewRange);

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
		/// Clears all hate levels.
		/// </summary>
		protected void RemoveAllHate()
		{
			_hateLevels.Clear();
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

				if (!this.CanAccumulateHate(potentialEnemy))
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

			Log.Debug("Monster {0} hate level for {1} is now {2} (min: {3}).", this.Entity.Name, handle, _hateLevels[handle], _minAggroHateLevel);
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
		/// Returns true if the given entity can accumulate hate, based on its
		/// current state.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		protected bool CanAccumulateHate(ICombatEntity entity)
		{
			if (entity.IsBuffActive(BuffId.Cloaking_Buff))
				return false;

			// Provocation Immunity prevents hate from all except its caster
			// as long as the caster remains in range
			if (this.Entity.TryGetBuff(BuffId.ProvocationImmunity_Debuff, out var piDebuff))
			{
				var caster = piDebuff.Caster;

				if (entity != caster && !this.EntityGone(caster) && this.InRangeOf(caster, 300))
					return false;
			}

			return true;
		}

		/// <summary>
		/// Returns true if the given entity is a valid target to be hated and
		/// targetted, based on its current state.
		/// </summary>
		/// <param name="entity"></param>
		/// <returns></returns>
		protected bool CanBeHated(ICombatEntity entity)
		{
			if (entity.IsBuffActive(BuffId.Cloaking_Buff))
				return false;

			return true;
		}

		/// <summary>
		/// Returns the enemy with the highest hate level in range.
		/// </summary>
		/// <returns></returns>
		protected ICombatEntity GetMostHated()
		{
			// This buff overrides the most hated target as long as the caster
			// remains in range.
			if (this.Entity.TryGetBuff(BuffId.ProvocationImmunity_Debuff, out var piDebuff))
			{
				var caster = piDebuff.Caster;

				if (!this.EntityGone(caster) && this.InRangeOf(caster, 300))
					return caster;
			}

			var highestHate = 0f;
			ICombatEntity mostHated = null;

			foreach (var entry in _hateLevels)
			{
				var handle = entry.Key;
				var hate = entry.Value;

				if (hate <= highestHate)
					continue;

				var entity = this.Entity.Map.GetCombatEntity(handle);

				if (entity != null && !this.CanBeHated(entity))
					continue;

				highestHate = hate;
				mostHated = entity;
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
			// Always hating the person that casted this buff
			if (this.Entity.TryGetBuff(BuffId.ProvocationImmunity_Debuff, out var piDebuff))
			{
				if (entity == piDebuff.Caster)
					return true;
			}

			if (!_hateLevels.TryGetValue(entity.Handle, out var hate))
				return false;

			if (!this.CanBeHated(entity))
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
					this.ReactToAlert(eventAlert);
				}
			}
		}

		/// <summary>
		/// Makes AI react to the given alert.
		/// </summary>
		/// <param name="eventAlert"></param>
		private void ReactToAlert(IAiEventAlert eventAlert)
		{
			switch (eventAlert)
			{
				case HitEventAlert hitEventAlert:
				{
					var entityWasAttacked = (hitEventAlert.Target.Handle == this.Entity.Handle);
					var masterWasAttacked = (hitEventAlert.Target.Handle == _masterHandle);
					var masterDidAttack = (hitEventAlert.Attacker.Handle == _masterHandle);

					if (entityWasAttacked || masterWasAttacked)
						this.IncreaseHate(hitEventAlert.Attacker, _hatePerHit);
					else if (masterDidAttack)
						this.IncreaseHate(hitEventAlert.Target, _hatePerHit);

					break;
				}

				case HateResetAlert hateResetAlert:
				{
					var targetHandle = hateResetAlert.Target.Handle;
					_hateLevels.Remove(targetHandle);
					break;
				}

				case TauntEventAlert tauntEventAlert:
				{
					var entityWasAttacked = (tauntEventAlert.Target.Handle == this.Entity.Handle);
					var masterWasAttacked = (tauntEventAlert.Target.Handle == _masterHandle);
					var masterDidAttack = (tauntEventAlert.Attacker.Handle == _masterHandle);

					var highestHate = 0f;

					foreach (var entry in _hateLevels)
					{
						var hate = entry.Value;

						if (hate > highestHate)
							highestHate = hate;
					}

					if (entityWasAttacked || masterWasAttacked)
						this.IncreaseHate(tauntEventAlert.Attacker, highestHate + _hatePerHit);
					else if (masterDidAttack)
						this.IncreaseHate(tauntEventAlert.Target, highestHate + _hatePerHit);

					break;
				}
				case DecreaseHateEventAlert decreaseHateEventAlert:
				{
					var entityWasAttacked = (decreaseHateEventAlert.Target.Handle == this.Entity.Handle);
					var masterWasAttacked = (decreaseHateEventAlert.Target.Handle == _masterHandle);
					var masterDidAttack = (decreaseHateEventAlert.Attacker.Handle == _masterHandle);

					if (_hateLevels.Count <= 1)					
						return;
					
					if (entityWasAttacked || masterWasAttacked)
						this.IncreaseHate(decreaseHateEventAlert.Attacker, -_hatePerHit);
					else if (masterDidAttack)
						this.IncreaseHate(decreaseHateEventAlert.Target, -_hatePerHit);

					break;
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
		/// Sets the range in which the AI can see potential enemies.
		/// </summary>
		/// <param name="viewRange"></param>
		protected void SetViewDistance(float viewRange)
		{
			_viewRange = viewRange;
		}

		/// <summary>
		/// Sets the entity the AI follows around and supports.
		/// </summary>
		/// <param name="masterEntity"></param>
		public void SetMaster(ICombatEntity masterEntity)
		{
			_masterHandle = masterEntity.Handle;
			this.SwitchFaction(masterEntity.Faction);
		}

		/// <summary>
		/// Returns the AI's master, or null if it doesn't have one.
		/// </summary>
		/// <returns></returns>
		public ICombatEntity GetMaster()
		{
			if (_masterHandle == 0)
				return null;

			return this.Entity.Map.GetCombatEntity(_masterHandle);
		}

		/// <summary>
		/// Returns the entity's master via out. Returns false if the
		/// entity doesn't have a master.
		/// </summary>
		/// <param name="master"></param>
		/// <returns></returns>
		public bool TryGetMaster(out ICombatEntity master)
		{
			master = this.GetMaster();
			return (master != null);
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

		/// <summary>
		/// Sets the entity's movement speed to the given fixed value.
		/// </summary>
		/// <param name="mspd"></param>
		protected void SetFixedMoveSpeed(float mspd)
		{
			this.Entity.Components.Get<MovementComponent>().SetFixedMoveSpeed(mspd);
		}

		/// <summary>
		/// Resets any movement speed changes made.
		/// </summary>
		protected void ResetMoveSpeed()
		{
			var movement = this.Entity.Components.Get<MovementComponent>();

			movement.SetMoveSpeedType(MoveSpeedType.Walk);
			movement.SetFixedMoveSpeed(0);
		}

		/// <summary>
		/// Removes AI's entity from the world if it's a monster.
		/// </summary>
		protected void Despawn()
		{
			if (this.Entity is IMonster monster)
				monster.Map.RemoveMonster(monster);
		}
	}
}
