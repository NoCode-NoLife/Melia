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

namespace Melia.Channel.World
{
	public class Map
	{
		private Dictionary<int, Character> _characters;
		private Dictionary<int, Monster> _monsters;

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
		/// Creates new map.
		/// </summary>
		public Map(int id, string name)
		{
			_characters = new Dictionary<int, Character>();
			_monsters = new Dictionary<int, Monster>();

			this.Id = id;
			this.Name = name;
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

			Send.ZC_ENTER_MONSTER(monster);

			lock (_monsters)
				_monsters[monster.Handle] = monster;
		}

		/// <summary>
		/// Removes monster from map.
		/// </summary>
		/// <param name="monster"></param>
		public void RemoveMonster(Monster monster)
		{
			lock (_monsters)
				_monsters.Remove(monster.Handle);

			Send.ZC_LEAVE(monster);

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
				return _monsters.Values.FirstOrDefault(a => a.IsWarp && a.Position.InRange(pos, 35));
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
