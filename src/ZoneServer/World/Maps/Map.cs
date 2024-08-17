using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Data.Database;
using Melia.Shared.Network;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Scripting;
using Melia.Zone.Scripting.AI;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Geometry;
using Yggdrasil.Scheduling;
using Melia.Zone.World.Actors.Pads;
using Melia.Zone.World.Actors.Components;
using Melia.Zone.World.Maps.Pathfinding;

namespace Melia.Zone.World.Maps
{
	public class Map : IUpdateable
	{
		/// <summary>
		/// Range a character can see.
		/// </summary>
		public const int VisibleRange = 500;

		/// <summary>
		/// Collection of combat entities, which can be both characters
		/// and monsters.
		/// <para>Key: <see cref="ICombatEntity.Handle"/></para>
		/// <para>Value: <see cref="ICombatEntity"/></para>
		/// </summary>
		private readonly Dictionary<int, ICombatEntity> _combatEntities = new();

		/// <summary>
		/// Collection of characters.
		/// <para>Key: <see cref="Character.Handle"/></para>
		/// <para>Value: <see cref="Character"/></para>
		/// </summary>
		private readonly Dictionary<int, Character> _characters = new();

		/// <summary>
		/// Collection of monsters.
		/// <para>Key: <see cref="IMonster.Handle"/></para>
		/// <para>Value: <see cref="IMonster"/></para>
		/// </summary>
		private readonly Dictionary<int, IMonster> _monsters = new();

		/// <summary>
		/// Collection of trigger areas on the map.
		/// </summary>
		private readonly Dictionary<int, ITriggerableArea> _triggerableAreas = new();

		/// <summary>
		/// Collection of pads on the map.
		/// <para>Key: <see cref="Pad.Handle"/></para>
		/// <para>Value: <see cref="Pad"/></para>
		/// </summary>
		private readonly Dictionary<int, Pad> _pads = new();

		/// <summary>
		/// Monsters to add to the map on the next update.
		/// </summary>
		private readonly Queue<IMonster> _addMonsters = new();

		/// <summary>
		/// List for entities during entity update.
		/// </summary>
		private readonly List<IUpdateable> _updateEntities = new();

		/// <summary>
		/// List for characters during visibility update.
		/// </summary>
		private readonly List<Character> _updateVisibleCharacters = new();

		/// <summary>
		/// List of property overrides for monsters spawned on this map.
		/// </summary>
		private readonly Dictionary<int, PropertyOverrides> _monsterPropertyOverrides = new();

		/// <summary>
		/// Returns the map's unique class name.
		/// </summary>
		public string ClassName { get; protected set; }

		/// <summary>
		/// Returns the map's class id.
		/// </summary>
		public int Id { get; protected set; }

		/// <summary>
		/// Returns a reference to the map's data.
		/// </summary>
		public MapData Data { get; protected set; }

		/// <summary>
		/// Returns the map's ground.
		/// </summary>
		public Ground Ground { get; } = new Ground();

		/// <summary>
		/// Returns the map's pathfinder.
		/// </summary>
		public IPathfinder Pathfinder { get; private set; }

		/// <summary>
		/// Returns the number of characters on the map.
		/// </summary>
		public int CharacterCount { get { lock (_characters) return _characters.Count; } }

		/// <summary>
		/// Returns the number of monsters on the map. This includes props
		/// and item drops.
		/// </summary>
		public int MonsterCount { get { lock (_monsters) return _monsters.Count; } }

		/// <summary>
		/// Default dummy region.
		/// </summary>
		public static Map Limbo { get; } = new Limbo();

		/// <summary>
		/// Creates new map.
		/// </summary>
		public Map(int id, string name)
		{
			this.Id = id;
			this.ClassName = name;

			this.Load();
		}

		/// <summary>
		/// Loads the map's data.
		/// </summary>
		private void Load()
		{
			this.Data = ZoneServer.Instance.Data.MapDb.Find(this.Id);

			// A few maps don't seem to have any ground data.
			if (ZoneServer.Instance.Data.GroundDb.TryFind(this.ClassName, out var groundData))
				this.Ground.Load(groundData);

			// Load pathfinder regardless of whether there's ground data,
			// so it's not null
			if (ZoneServer.Instance.Conf.World.MonstersUsePathfinding)
				this.Pathfinder = new DynamicGridPathfinder(this);
			else
				this.Pathfinder = new NonePathfinder();
		}

		/// <summary>
		/// Called regularly to update the map and its entities.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			this.Disappearances();
			this.UpdateVisibility();
			this.UpdateEntities(elapsed);
		}

		/// <summary>
		/// Updates the map's entites.
		/// </summary>
		/// <param name="elapsed"></param>
		private void UpdateEntities(TimeSpan elapsed)
		{
			// Should performance of iterating over all entities on
			// all maps ever become a problem, we could multi-thread
			// the entity updates.
			// If locked access to the collections ever becomes a
			// bottle-neck, switch to ReaderWriterLockSlim.

			lock (_addMonsters)
			{
				while (_addMonsters.Count > 0)
					this.AddMonster(_addMonsters.Dequeue());
			}

			// Create a list of updatables instead of locking and then
			// updating monsters and characters separately, so that
			// actions taken by components that get updated don't
			// affect Map. For example, adding and removing monsters
			// would modify the collections, and broadcasts could
			// cause deadlocks under certain circumstances.
			lock (_updateEntities)
			{
				lock (_monsters)
					_updateEntities.AddRange(_monsters.Values.OfType<IUpdateable>());

				lock (_characters)
					_updateEntities.AddRange(_characters.Values);

				lock (_pads)
					_updateEntities.AddRange(_pads.Values);

				foreach (var entity in _updateEntities)
					entity.Update(elapsed);

				_updateEntities.Clear();
			}
		}

		/// <summary>
		/// Auto-removes entities according to their DisappearTime.
		/// </summary>
		private void Disappearances()
		{
			var now = DateTime.Now;

			List<IMonster> toDisappear;
			lock (_monsters)
				toDisappear = _monsters.Values.Where(a => a.DisappearTime < now).ToList();

			foreach (var monster in toDisappear)
			{
				ZoneServer.Instance.ServerEvents.OnMonsterDisappears(monster);
				this.RemoveMonster(monster);
			}
		}

		/// <summary>
		/// Runs visibility updates for all characters on this map.
		/// </summary>
		private void UpdateVisibility()
		{
			// TODO: Someone remind me why we're doing this here...
			//   Why is this not inside Character.Update?

			// Same challenge as in UpdateEntities, LookAround queries
			// the visible characters while locking them to iterate
			// them, which can cause a deadlock if another thread
			// tries something similar. Wouldn't be an issue with
			// ReaderWriterLockSlim, but I'm curious about just
			// using lock.
			lock (_updateVisibleCharacters)
			{
				lock (_characters)
					_updateVisibleCharacters.AddRange(_characters.Values);

				foreach (var character in _updateVisibleCharacters)
					character.LookAround();

				_updateVisibleCharacters.Clear();
			}
		}

		/// <summary>
		/// Adds character to map.
		/// </summary>
		/// <param name="character"></param>
		public void AddCharacter(Character character)
		{
			character.Map = this;

			lock (_characters)
				_characters[character.Handle] = character;

			if (character is ICombatEntity)
			{
				lock (_combatEntities)
					_combatEntities[character.Handle] = character;
			}

			ZoneServer.Instance.UpdateServerInfo();
		}

		/// <summary>
		/// Removes character from map.
		/// </summary>
		/// <param name="character"></param>
		public void RemoveCharacter(Character character)
		{
			lock (_characters)
				_characters.Remove(character.Handle);

			lock (_combatEntities)
				_combatEntities.Remove(character.Handle);

			character.Map = null;

			ZoneServer.Instance.UpdateServerInfo();
		}

		/// <summary>
		/// Returns character by handle, or null if it doesn't exist.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public Character GetCharacter(int handle)
		{
			Character result;
			lock (_characters)
				_characters.TryGetValue(handle, out result);
			return result;
		}

		/// <summary>
		/// Returns a character on this map that match the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public Character GetCharacter(Func<Character, bool> predicate)
		{
			lock (_characters)
				return _characters.Values.FirstOrDefault(predicate);
		}

		/// <summary>
		/// Returns first character found by team name, or null if none exist.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public Character GetCharacterByTeamName(string teamName)
		{
			lock (_characters)
				return _characters.Values.FirstOrDefault(a => a.TeamName == teamName);
		}

		/// <summary>
		/// Returns all characters on this map.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public Character[] GetCharacters()
		{
			lock (_characters)
				return _characters.Values.ToArray();
		}

		/// <summary>
		/// Returns all characters on this map that match the given predicate.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public Character[] GetCharacters(Func<Character, bool> predicate)
		{
			lock (_characters)
				return _characters.Values.Where(predicate).ToArray();
		}

		/// <summary>
		/// Returns all characters in visible range of character.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public Character[] GetVisibleCharacters(Character character)
			=> this.GetCharacters(a => a != character && character.Position.InRange2D(a.Position, VisibleRange));

		/// <summary>
		/// Adds monster to map.
		/// </summary>
		/// <param name="monster"></param>
		public void AddMonster(IMonster monster)
		{
			monster.Map = this;

			lock (_monsters)
				_monsters[monster.Handle] = monster;

			if (monster is ICombatEntity entity)
			{
				lock (_combatEntities)
					_combatEntities[monster.Handle] = entity;
			}

			if (monster is ITriggerableArea trigger)
			{
				lock (_triggerableAreas)
					_triggerableAreas[monster.Handle] = trigger;
			}

			// Update visibily after adding the monster, so it gets sent
			// to the clients right away, and then disable FromGround,
			// which is supposed to only be true once, when the monster
			// appears for the first time. This way, all players around
			// the monster get the animation at the time of spawning,
			// and afterwards they just appear.
			this.UpdateVisibility();
			monster.FromGround = false;
		}

		/// <summary>
		/// Removes monster from map.
		/// </summary>
		/// <param name="monster"></param>
		public void RemoveMonster(IMonster monster)
		{
			lock (_monsters)
				_monsters.Remove(monster.Handle);

			lock (_combatEntities)
				_combatEntities.Remove(monster.Handle);

			lock (_combatEntities)
				_triggerableAreas.Remove(monster.Handle);

			monster.Map = null;
			this.UpdateVisibility();
		}

		/// <summary>
		/// Returns all triggerable areas that overlap with the given
		/// position.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public ITriggerableArea[] GetTriggerableAreasAt(Position pos)
		{
			lock (_triggerableAreas)
				return _triggerableAreas.Values.Where(a => a.Area?.IsInside(pos) ?? false).ToArray();
		}

		/// <summary>
		/// Returns attackable monsters in the given radius around position.
		/// </summary>
		/// <param name="position"></param>
		/// <param name="radius"></param>
		/// <returns></returns>
		public List<ICombatEntity> GetAttackableEntitiesInRange(ICombatEntity attacker, Position position, float radius)
		{
			var result = new List<ICombatEntity>();

			lock (_combatEntities)
			{
				var entities = _combatEntities.Values.Where(a => a.Position.InRange2D(position, radius) && attacker.CanAttack(a));
				result.AddRange(entities);
			}

			return result;
		}

		/// <summary>
		/// Returns attackable monsters in the given radius around position.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="shape"></param>
		/// <returns></returns>
		public List<ICombatEntity> GetAttackableEntitiesIn(ICombatEntity attacker, IShapeF shape)
		{
			var result = new List<ICombatEntity>();

			lock (_combatEntities)
			{
				foreach (var entity in _combatEntities.Values)
				{
					if (!attacker.CanAttack(entity))
						continue;

					if (!shape.IsInside(entity.Position))
						continue;

					result.Add(entity);
				}
			}

			return result;
		}

		/// <summary>
		/// Returns all actors with the given type in the area.
		/// </summary>
		/// <typeparam name="TActor"></typeparam>
		/// <param name="area"></param>
		/// <returns></returns>
		public List<TActor> GetActorsIn<TActor>(IShapeF area) where TActor : IActor
		{
			// Searching through both characters and monsters isn't the
			// most efficient way to get actors of a specific type in an
			// area, but it is simple and convenient, and it doesn't require
			// us to create dozens of getters for various actor types.
			// We can optimize this later if necessary.

			var result = new List<TActor>();

			lock (_monsters)
			{
				foreach (var monster in _monsters.Values)
				{
					if (monster is TActor actor && area.IsInside(actor.Position))
						result.Add(actor);
				}
			}

			lock (_characters)
			{
				foreach (var character in _characters.Values)
				{
					if (character is TActor actor && area.IsInside(actor.Position))
						result.Add(actor);
				}
			}

			return result;
		}

		/// <summary>
		/// Returns monster by handle, or null if it doesn't exist.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public IMonster GetMonster(int handle)
		{
			IMonster result;
			lock (_monsters)
				_monsters.TryGetValue(handle, out result);

			return result;
		}

		/// <summary>
		/// Returns the first monster that matches the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public IMonster GetMonster(Func<IMonster, bool> predicate)
		{
			lock (_monsters)
				return _monsters.Values.FirstOrDefault(predicate);
		}

		/// <summary>
		/// Returns monster by handle via out. Returns false if the
		/// monster wasn't found.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public bool TryGetMonster(int handle, out IMonster monster)
		{
			lock (_monsters)
				return _monsters.TryGetValue(handle, out monster);
		}

		/// <summary>
		/// Returns the first monster that matches the given predicate
		/// via out. Returns false if no monster was found.
		/// </summary>
		/// <param name="predicate"></param>
		/// <param name="monster"></param>
		/// <returns></returns>
		public bool TryGetMonster(Func<IMonster, bool> predicate, out IMonster monster)
		{
			lock (_monsters)
			{
				foreach (var m in _monsters.Values)
				{
					if (predicate(m))
					{
						monster = m;
						return true;
					}
				}
			}

			monster = null;
			return false;
		}

		/// <summary>
		/// Returns combat entity by handle, or null if it doesn't exist.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public ICombatEntity GetCombatEntity(int handle)
		{
			lock (_monsters)
			{
				if (_monsters.TryGetValue(handle, out var monster) && monster is ICombatEntity entity)
					return entity;
			}

			lock (_characters)
			{
				if (_characters.TryGetValue(handle, out var entity))
					return entity;
			}

			return null;
		}

		/// <summary>
		/// Returns combat entity by handle via out. Returns false if the
		/// handle wasn't found.
		/// </summary>
		/// <param name="handle"></param>
		/// <param name="entity"></param>
		/// <returns></returns>
		public bool TryGetCombatEntity(int handle, out ICombatEntity entity)
		{
			entity = this.GetCombatEntity(handle);
			return entity != null;
		}

		/// <summary>
		/// Returns the actor with the given handle via out. Returns false
		/// if not matching actor was found.
		/// </summary>
		/// <param name="handle"></param>
		/// <param name="actor"></param>
		/// <returns></returns>
		public bool TryGetActor(int handle, out IActor actor)
		{
			lock (_monsters)
			{
				if (_monsters.TryGetValue(handle, out var monster))
				{
					actor = monster;
					return true;
				}
			}

			lock (_characters)
			{
				if (_characters.TryGetValue(handle, out var character))
				{
					actor = character;
					return true;
				}
			}

			actor = null;
			return false;
		}

		/// <summary>
		/// Returns all monsters on this map.
		/// </summary>
		/// <returns></returns>
		public IMonster[] GetMonsters()
		{
			lock (_monsters)
				return _monsters.Values.ToArray();
		}

		/// <summary>
		/// Returns all monsters on this map that match the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public IMonster[] GetMonsters(Func<IMonster, bool> predicate)
		{
			lock (_monsters)
				return _monsters.Values.Where(predicate).ToArray();
		}

		/// <summary>
		/// Returns all monsters in visible range of character.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public IMonster[] GetVisibleMonsters(Character character)
			// TODO: Move responsibility about visibility to Character.
			=> this.GetMonsters(a => (a is not Npc npc || npc.State != NpcState.Invisible) && character.Position.InRange2D(a.Position, VisibleRange));

		/// <summary>
		/// Removes all scripted entities, like NPCs, monsters, and warps.
		/// </summary>
		public void RemoveScriptedEntities()
		{
			var toRemove = new List<IMonster>();
			lock (_monsters)
				toRemove.AddRange(_monsters.Values);

			foreach (var monster in toRemove)
				this.RemoveMonster(monster);
		}

		/// <summary>
		/// Returns warp NPC that should be used when at given position.
		/// </summary>
		/// <param name="character"></param>
		public WarpMonster GetNearbyWarp(Position pos)
		{
			// TODO: Not very efficient with a lot of monsters, we might want
			//   to add more dedicated dictionaries and/or a quad tree.

			lock (_monsters)
				return _monsters.Values.OfType<WarpMonster>().FirstOrDefault(a => a.Position.InRange2D(pos, 35));
		}

		/// <summary>
		/// Adds pad to map and executes its first update.
		/// </summary>
		/// <param name="pad"></param>
		public void AddPad(Pad pad)
		{
			pad.Map = this;

			lock (_pads)
				_pads[pad.Handle] = pad;

			// Notify the pad about its new map after adding it, so potential
			// events can reference the map.
			// It would be kinda nice if the pad could manage this by itself,
			// or all actors really, but we do have to tell the actor about
			// it somehow. Maybe a generic OnAddedToMap method in Actor? TBD.
			pad.Components.Get<TriggerComponent>()?.OnAddedToMap();
		}

		/// <summary>
		/// Removes pad from map.
		/// </summary>
		/// <param name="pad"></param>
		public void RemovePad(Pad pad)
		{
			// Notify the pad about its removal before actually removing it,
			// so any potential event handlers can still reference its map.
			pad.Components.Get<TriggerComponent>()?.OnRemovingFromMap();

			lock (_pads)
				_pads.Remove(pad.Handle);

			pad.Map = null;
		}

		/// <summary>
		/// Sets the property overrides for the given monster on this map.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="propertyOverrides"></param>
		public void AddPropertyOverrides(int monsterClassId, PropertyOverrides propertyOverrides)
		{
			lock (_monsterPropertyOverrides)
				_monsterPropertyOverrides[monsterClassId] = propertyOverrides;
		}

		/// <summary>
		/// Returns the property overrides for the given monster via out.
		/// Returns false if no overrides were defined.
		/// </summary>
		/// <param name="monsterClassId"></param>
		/// <param name="propertyOverrides"></param>
		/// <returns></returns>
		public bool TryGetPropertyOverrides(int monsterClassId, out PropertyOverrides propertyOverrides)
		{
			lock (_monsterPropertyOverrides)
				return _monsterPropertyOverrides.TryGetValue(monsterClassId, out propertyOverrides);
		}

		/// <summary>
		/// Returns the closest safe position near the given one. If
		/// resurrection points are favored and one exists, they will
		/// always be returned first over the map's default position.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="favorResurrectionPoints"></param>
		/// <returns></returns>
		public Position GetSafePositionNear(Position pos, bool favorResurrectionPoints)
		{
			var positions = ZoneServer.Instance.Data.ResurrectionPointDb.FindPositions(this.ClassName);

			if (positions.Count == 0)
				return this.Data.DefaultPosition;

			if (!favorResurrectionPoints)
				positions.Add(this.Data.DefaultPosition);

			var closestPos = positions.OrderBy(a => a.Get2DDistance(pos)).First();
			return closestPos;
		}

		/// <summary>
		/// Alerts all AIs in range of the source about the given event.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="alert"></param>
		public void AlertAis(IActor source, IAiEventAlert alert)
		{
			lock (_monsters)
			{
				foreach (var monster in _monsters.Values)
				{
					if (!monster.Position.InRange2D(source.Position, VisibleRange))
						continue;

					if (monster is not ICombatEntity combatEntity)
						continue;

					if (!combatEntity.Components.TryGet<AiComponent>(out var aiComponent))
						continue;

					aiComponent.Script.QueueEventAlert(alert);
				}
			}
		}

		/// <summary>
		/// Broadcasts packet to all characters on map.
		/// </summary>
		/// <param name="packet"></param>
		public virtual void Broadcast(Packet packet)
		{
			lock (_characters)
			{
				foreach (var character in _characters.Values)
					character.Connection.Send(packet);
			}
		}

		/// <summary>
		/// Broadcasts packet to all characters on map, that are within
		/// visible range of source.
		/// </summary>
		/// <param name="packet">Packet to broadcast.</param>
		/// <param name="source">Reference actor for visible range to broadcast in.</param>
		/// <param name="includeSource">Send to source as well?</param>
		public virtual void Broadcast(Packet packet, IActor source, bool includeSource = true)
		{
			lock (_characters)
			{
				foreach (var character in _characters.Values.Where(a => (includeSource || a != source) && a.Position.InRange2D(source.Position, VisibleRange)))
					character.Connection.Send(packet);
			}
		}
	}

	/// <summary>
	/// Dummy map every creature gets by default.
	/// </summary>
	public class Limbo : Map
	{
		public Limbo()
			: base(0, "__limbo__")
		{
		}

		public override void Broadcast(Packet packet)
		{
			//Log.Warning("Broadcast in Limbo.");
		}
	}
}
