// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Network;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Shared.Util;
using Melia.Shared.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.World.SectorActors;
using Melia.Channel.World.SkillEffects;
using System.Diagnostics;
using System.Threading;

namespace Melia.Channel.World
{
	public class Map
	{
		/// <summary>
		/// Range a character can see.
		/// </summary>
		public const int VisibleRange = 500;

		private Dictionary<int, Character> _characters;
		private Dictionary<int, Monster> _monsters;
		private Dictionary<int, GroundSkill> _skills;
		private List<SpawnZone> _spawns;

		/// <summary>
		/// Map name.
		/// </summary>
		public string Name { get; protected set; }

		/// <summary>
		/// Map id.
		/// </summary>
		public int Id { get; protected set; }

		/// <summary>
		/// Default dummy region.
		/// </summary>
		public static Map Limbo = new Limbo();

		/// <summary>
		/// Sector Manager
		/// </summary>
		public SectorManager SectorManager;

		/// <summary>
		/// Creates new map.
		/// </summary>
		public Map(int id, string name)
		{
			_characters = new Dictionary<int, Character>();
			_monsters = new Dictionary<int, Monster>();
			_skills = new Dictionary<int, GroundSkill>();
			_spawns = new List<SpawnZone>();

			this.Id = id;
			this.Name = name;

			SectorManager = new SectorManager();
			SectorManager.Init(this, 10000, 10000, -5000, -5000);
		}

		/// <summary>
		/// Updates all entities, e.g. removes dead monsters.
		/// </summary>
		public void UpdateEntities()
		{
			this.Disappearances();
			this.UpdateVisibility();
			this.ProcessCharacters();
			this.ProcessMonsters();
			this.ProcessSkills();
		}

		/// <summary>
		/// Auto-removes entities according to their DisappearTime.
		/// </summary>
		private void Disappearances()
		{
			var now = DateTime.Now;

			List<Monster> toDisappear;
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
			lock (_characters)
			{
				foreach (var character in _characters.Values)
					character.LookAround();
			}
		}

		private void ProcessCharacters()
		{
			foreach (var character in _characters.Values)
				character.Process();
		}

		private void ProcessMonsters()
		{
			foreach (var monster in _monsters.Values)
				monster.Process();
		}

		private void ProcessSkills()
		{
			List<GroundSkill> skillsToDelete = new List<GroundSkill>();
			lock (_skills)
			{
				foreach (var skill in _skills.Values)
				{
					try
					{
						if (skill.ToDestroy)
						{
							skillsToDelete.Add(skill);
							continue;
						}
						//skill.Process();
					}
					catch { }
				}
			}

			foreach (var skill in skillsToDelete)
			{
				RemoveSkill(skill);
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

			if (!SectorManager.Add(character, character.Position))
			{
				Log.Error("Error adding character placeable entity into SectorManager at: {0} {1} {2}", character.Position.X, character.Position.Y, character.Position.Z);
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

			character.Map = null;

			SectorManager.Remove(character);
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
		/// Adds monster to map.
		/// </summary>
		/// <param name="monster"></param>
		public void AddMonster(Monster monster)
		{
			monster.Map = this;

			lock (_monsters)
				_monsters[monster.Handle] = monster;

			if (!SectorManager.Add(monster, monster.Position))
			{
				Log.Error("Error adding monster placeable entity into SectorManager at: {0} {1} {2}", monster.Position.X, monster.Position.Y, monster.Position.Z);
			}
		}

		/// <summary>
		/// Removes monster from map.
		/// </summary>
		/// <param name="monster"></param>
		public void RemoveMonster(Monster monster)
		{
			lock (_monsters)
				_monsters.Remove(monster.Handle);

			SectorManager.Remove(monster);

			monster.Map = null;
		}

		/// <summary>
		/// Returns monster by handle, or null if it doesn't exist.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public Monster GetMonster(int handle)
		{
			Monster result;
			lock (_monsters)
				_monsters.TryGetValue(handle, out result);
			return result;
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
		/// Returns all characters in visible range of character.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public Character[] GetVisibleCharacters(Character character)
		{
			lock (_characters)
				return _characters.Values.Where(a => a != character && character.Position.InRange2D(a.Position, VisibleRange)).ToArray();
		}

		/// <summary>
		/// Returns all monsters on this map.
		/// </summary>
		/// <param name="handle"></param>
		/// <returns></returns>
		public Monster[] GetMonsters()
		{
			lock (_monsters)
				return _monsters.Values.ToArray();
		}

		/// <summary>
		/// Returns all monsters in visible range of character.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public Monster[] GetVisibleMonsters(Character character)
		{
			lock (_monsters)
				return _monsters.Values.Where(a => character.Position.InRange2D(a.Position, VisibleRange)).ToArray();
		}

		/// <summary>
		/// Removes all scripted entities, like NPCs.
		/// </summary>
		public void RemoveScriptedEntities()
		{
			var toRemove = new List<Monster>();
			lock (_monsters)
				toRemove.AddRange(_monsters.Values.Where(a => a.NpcType == NpcType.NPC));

			foreach (var monster in toRemove)
				this.RemoveMonster(monster);
		}

		/// <summary>
		/// Returns warp NPC that should be used when at given position.
		/// </summary>
		/// <param name="character"></param>
		public Monster GetNearbyWarp(Position pos)
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
		/// <param name="packet">Packet to send.</param>
		/// <param name="source">Reference entity for visible range to send in.</param>
		/// <param name="includeSource">Send to source as well?</param>
		public virtual void Broadcast(Packet packet, IEntity source, bool includeSource = true)
		{
			lock (_characters)
			{
				foreach (var character in _characters.Values.Where(a => (includeSource || a != source) && a.Position.InRange2D(source.Position, VisibleRange)))
					character.Connection.Send(packet);
			}
		}

		public void AddSkill(GroundSkill skill)
		{
			lock (_skills)
				_skills[skill.Handle] = skill;

			skill.Map = this;

			if (!SectorManager.Add(skill, skill.Position))
			{
				Log.Error("Error adding skill placeable entity into SectorManager at: {0} {1} {2}", skill.Position.X, skill.Position.Y, skill.Position.Z);
			}
		}

		public void RemoveSkill(GroundSkill skill)
		{
			lock (_skills)
				_skills.Remove(skill.Handle);

			SectorManager.Remove(skill);
		}

		public Actor GetActor(int handle)
		{
			Character character;
			lock (_characters)
				if (_characters.TryGetValue(handle, out character)) 
					return character;

			Monster monster;
			lock (_monsters)
				if (_monsters.TryGetValue(handle, out monster))
					return monster;

			return null;
		}

		public void AddSpawnZone(SpawnData sData)
		{
			SpawnZone spawnZone = new SpawnZone(sData);
			if (spawnZone == null)
				return;

			lock (_spawns)
			{
				spawnZone.Id = _spawns.Count;
				_spawns.Add(spawnZone);
				
			}
			spawnZone.Init();
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
			Log.Warning("Broadcast in Limbo.");
		}
	}
}
