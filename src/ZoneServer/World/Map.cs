using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Data.Database;
using Melia.Shared.Network;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.World.Entities;
using Yggdrasil.Geometry;
using Yggdrasil.Geometry.Shapes;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World
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
		private readonly Dictionary<int, ICombatEntity> _combatEntities = new Dictionary<int, ICombatEntity>();

		/// <summary>
		/// Collection of characters.
		/// <para>Key: <see cref="Character.Handle"/></para>
		/// <para>Value: <see cref="Character"/></para>
		/// </summary>
		private readonly Dictionary<int, Character> _characters = new Dictionary<int, Character>();

		/// <summary>
		/// Collection of monsters.
		/// <para>Key: <see cref="MonsterLegacy.Handle"/></para>
		/// <para>Value: <see cref="MonsterLegacy"/></para>
		/// </summary>
		private readonly Dictionary<int, MonsterLegacy> _monsters = new Dictionary<int, MonsterLegacy>();

		/// <summary>
		/// Collection of monster spawners.
		/// </summary>
		private readonly List<MonsterSpawner> _spawners = new List<MonsterSpawner>();

		/// <summary>
		/// Monsters to add to the map on the next update.
		/// </summary>
		private readonly Queue<MonsterLegacy> _addMonsters = new Queue<MonsterLegacy>();

		/// <summary>
		/// List for entities during entity update.
		/// </summary>
		private readonly List<IUpdateable> _updateEntities = new List<IUpdateable>();

		/// <summary>
		/// List for characters during visibility update.
		/// </summary>
		private readonly List<Character> _updateVisibleCharacters = new List<Character>();

		/// <summary>
		/// Map name.
		/// </summary>
		public string Name { get; protected set; }

		/// <summary>
		/// Map id.
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
			this.Name = name;

			this.Load();
		}

		/// <summary>
		/// Loads the map's data.
		/// </summary>
		private void Load()
		{
			this.Data = ZoneServer.Instance.Data.MapDb.Find(this.Id);

			// A few maps don't seem to have any ground data.
			if (ZoneServer.Instance.Data.GroundDb.TryFind(this.Name, out var groundData))
				this.Ground.Load(groundData);
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
					_updateEntities.AddRange(_monsters.Values);

				lock (_characters)
					_updateEntities.AddRange(_characters.Values);

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

			List<MonsterLegacy> toDisappear;
			lock (_monsters)
				toDisappear = _monsters.Values.Where(a => a.DisappearTime < now).ToList();

			foreach (var monster in toDisappear)
				this.RemoveMonster(monster);
		}

		/// <summary>
		/// Runs visibility updates for all characters on this map.
		/// </summary>
		private void UpdateVisibility()
		{
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
		/// Adds the spawner to the map.
		/// </summary>
		/// <param name="spawner"></param>
		public void AddSpawner(MonsterSpawner spawner)
		{
			lock (_spawners)
			{
				_spawners.Add(spawner);
				spawner.InitialSpawn();
			}
		}

		/// <summary>
		/// Removes all spawners from the map.
		/// </summary>
		public void RemoveSpawners()
		{
			lock (_spawners)
				_spawners.Clear();
		}

		/// <summary>
		/// Adds monster to map.
		/// </summary>
		/// <param name="monster"></param>
		public void AddMonster(MonsterLegacy monster)
		{
			monster.Map = this;

			lock (_monsters)
				_monsters[monster.Handle] = monster;

			if (monster is ICombatEntity)
			{
				lock (_combatEntities)
					_combatEntities[monster.Handle] = monster;
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
		public void RemoveMonster(MonsterLegacy monster)
		{
			lock (_monsters)
				_monsters.Remove(monster.Handle);

			lock (_combatEntities)
				_combatEntities.Remove(monster.Handle);

			monster.Map = null;
			this.UpdateVisibility();
		}

		/// <summary>
		/// Returns attackable monsters in the given radius around position.
		/// </summary>
		/// <param name="position"></param>
		/// <param name="radius"></param>
		/// <returns></returns>
		public List<ICombatEntity> GetAttackableEntitiesInRange(ICombatEntity attacker, Position position, int radius)
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
		public List<ICombatEntity> GetAttackableEntitiesIn(ICombatEntity attacker, IShape shape)
		{
			var result = new List<ICombatEntity>();

			// Debugging
			//foreach (var point in shape.GetEdgePoints())
			//{
			//	var monster = new MonsterLegacy(10005, MonsterType.Friendly);
			//	monster.Position = new Position(point.X, attacker.Position.Y, point.Y);
			//	monster.DisappearTime = DateTime.Now.AddSeconds(5);
			//	attacker.Map.AddMonster(monster);
			//}

			lock (_combatEntities)
			{
				foreach (var entity in _combatEntities.Values)
				{
					if (!attacker.CanAttack(entity))
						continue;

					if (!shape.IsInside(new Vector2((int)entity.Position.X, (int)entity.Position.Z)))
						continue;

					result.Add(entity);
				}
			}

			return result;
		}

		/// <summary>
		/// Returns monster by handle, or null if it doesn't exist.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public MonsterLegacy GetMonster(int handle)
		{
			MonsterLegacy result;
			lock (_monsters)
				_monsters.TryGetValue(handle, out result);

			return result;
		}

		/// <summary>
		/// Returns monster by handle via out. Returns false if the
		/// monster wasn't found.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public bool TryGetMonster(int handle, out MonsterLegacy monster)
		{
			lock (_monsters)
				return _monsters.TryGetValue(handle, out monster);
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
				if (_monsters.TryGetValue(handle, out var entity))
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
		/// Returns all monsters on this map.
		/// </summary>
		/// <returns></returns>
		public MonsterLegacy[] GetMonsters()
		{
			lock (_monsters)
				return _monsters.Values.ToArray();
		}

		/// <summary>
		/// Returns all monsters on this map that match the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public MonsterLegacy[] GetMonsters(Func<MonsterLegacy, bool> predicate)
		{
			lock (_monsters)
				return _monsters.Values.Where(predicate).ToArray();
		}

		/// <summary>
		/// Returns all monsters in visible range of character.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public MonsterLegacy[] GetVisibleMonsters(Character character)
			=> this.GetMonsters(a => a.State != MonsterState.Invisible && character.Position.InRange2D(a.Position, VisibleRange));

		/// <summary>
		/// Removes all scripted entities, like NPCs, monsters, and warps.
		/// </summary>
		public void RemoveScriptedEntities()
		{
			var toRemove = new List<MonsterLegacy>();
			lock (_monsters)
				toRemove.AddRange(_monsters.Values);

			foreach (var monster in toRemove)
				this.RemoveMonster(monster);

			this.RemoveSpawners();
		}

		/// <summary>
		/// Returns warp NPC that should be used when at given position.
		/// </summary>
		/// <param name="character"></param>
		public MonsterLegacy GetNearbyWarp(Position pos)
		{
			// TODO: Not very efficient with a lot of monsters, we might want
			//   to add more dedicated dictionaries and/or a quad tree.

			lock (_monsters)
				return _monsters.Values.FirstOrDefault(a => a.IsWarp && a.Position.InRange2D(pos, 35));
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
