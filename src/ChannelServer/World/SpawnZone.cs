using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;
using Melia.Channel.World.AI;
using System.Threading;
using Melia.Channel.Scripting;
using Melia.Channel.Network;
using MeluaLib;

namespace Melia.Channel.World
{

	public struct SpawnData
	{
		public string spawnName;
		public string spawnMakerName;
		public string mapName;
		public string monsterName;
		public int count;
		public int countVariation;
		public bool isFixedLocation;
		public Position Position { get; set; }
		public Direction Direction { get; set; }
		public int respawnTime;
		public int randomRespawnTime;
		public int xMin, xMax, zMin, zMax;
	}

	public struct SpawnTerritoryData
	{
		public string territoryName;
		public int xMin, xMax, zMin, zMax;
	}

	public class SpawnMaker
	{
		public string makerName;
		public string makerType;
		private List<SpawnTerritoryData> _territories;
		private List<SpawnZone> _spawns;
		public LuaThread LuaThread { get; set; }
		public ChannelConnection conn;

		private Map _map;
		private Random _rndGenerator;

		/// <summary>
		/// Flag indicating this spawn will spawn when OnStart is called
		/// </summary>
		public bool onStartSpawn;
		/// <summary>
		/// Max amount of entities to spwawn in this spawn
		/// </summary>
		public int maxEntities;

		/// <summary>
		/// Count of current entities in this spawn
		/// </summary>
		public int countEntities;

		public SpawnMaker(string name, string mapName, List<string> territoryNames, string makerType, int maxNpcs)
		{
			_territories = new List<SpawnTerritoryData>();
			_spawns = new List<SpawnZone>();
			this.conn = new ChannelConnection();
			this.conn.ScriptState.SpawnMaker = this;

			this.makerName = name;
			this.maxEntities = maxNpcs;
			this.makerType = makerType;
			
			_map = ChannelServer.Instance.World.GetMap(mapName);
			if (_map == null)
			{
				Log.Error("Error initializing Spawn Maker {1} {2}. Map not found. {0}", mapName, this.makerName);
				return;
			}

			foreach (var territoryName in territoryNames)
			{
				SpawnTerritoryData territory;
				if (!_map.TryGetTerritory(territoryName, out territory)) {
					Log.Warning("Spawn Maker {1}. Territory not found. {0}", territoryName, this.makerName);
					continue;
				}

				_territories.Add(territory);
			}

			_rndGenerator = new Random();

			this.onStartSpawn = true;
		}

		public void AddSpawn(SpawnData spawn)
		{
			SpawnZone spawnZone = new SpawnZone(spawn);
			_spawns.Add(spawnZone);
			spawnZone.spawnMaker = this;

		}

		public int GetSpawnsCount()
		{
			return _spawns.Count;
		}

		public SpawnZone GetSpawn(int index)
		{
			if (index > _spawns.Count)
				return null;

			return _spawns[index];
		}

		public int IncreaseTotal(int amount)
		{
			this.countEntities += amount;
			return this.countEntities;
		}

		public int GetSpawnIndex(SpawnZone spawn)
		{
			return _spawns.FindIndex(x => x == spawn);
		}

		public void Spawn(int index, int amount, int respawnTime, int randomRespawnTime)
		{
			if (index > _spawns.Count)
				return;

			_spawns[index].Spawn(amount, respawnTime, randomRespawnTime);
		}

		public void OnStart()
		{
			this.CallLua(this.makerType + "_onstart", null);
		}

		public void OnEnd()
		{
			this.CallLua(this.makerType + "_onend", null);
		}

		public void OnEntityDeleted(SpawnZone spawn)
		{
			this.countEntities--;
			this.CallLua(this.makerType + "_onentitydeleted", spawn.LuaParams_OnEntityDeleted);
		}

		public void CallLua(string functionName, ScriptManager.LuaParamsDelegate LuaParamsFunc)
		{
			var state = new ScriptState(null);
			state.SpawnMaker = this;
			ChannelServer.Instance.ScriptManager.Call2(state, functionName, LuaParamsFunc);
		}

		public Position GetSpawnPosition(SpawnData spawn)
		{
			// Position
			if (spawn.isFixedLocation)
			{
				return new Position(spawn.Position.X, spawn.Position.Y, spawn.Position.Z);
			}
			else
			{
				// Get territory

				int territoryIndex = _rndGenerator.Next(0, _territories.Count - 1);
				SpawnTerritoryData territory = _territories[territoryIndex];

				// Search a random location inside the polygon
				Position rndPosition;
				if (!this.GetRandomPosition(territory, out rndPosition))
				{
					Log.Warning("There was not possible to find a random position in polygon in Spawn {1}", this.makerName);
					return new Position(0, 0, 0);
				}

				return rndPosition;
			}
		}

		public Map GetMap()
		{
			return _map;
		}

		public bool GetRandomPosition(SpawnTerritoryData territory, out Position rndPosition)
		{
			int xPos, zPos;
			for (int i = 0; i < 100; i++)
			{
				xPos = _rndGenerator.Next(territory.xMin, territory.xMax);
				zPos = _rndGenerator.Next(territory.zMin, territory.zMax);

				if (IsInPolygon(xPos, zPos))
				{
					rndPosition = new Position(xPos, 260, zPos);
					return true;
				}

				if (i == 50)
				{
					Log.Warning("Polyon seems complicated in spawn territory {0}", territory.territoryName);
				}
			}

			rndPosition = new Position();
			return false;
		}

		public bool IsInPolygon(int x, int z)
		{
			/// TODO
			/// 
			return true;
		}

	}

	public class SpawnZone
	{
		public SpawnData Data { get; set; }
		public MonsterData MonsterData { get; set; }
		public SpawnMaker spawnMaker;
		public Dictionary<int, Monster> spawnEntities;
		public int calculatedTotalEntities;
		private int _countDeaths;
		private Random rndGenerator;

		public int Id;

		public SpawnZone(SpawnData spawnData)
		{
			this.Data = spawnData;

			this.MonsterData = ChannelServer.Instance.Data.MonsterDb.FindByClassName(this.Data.monsterName);
			if (this.MonsterData == null)
			{
				Log.Error("Error initializing Spawn Zone {1}. Monster not found. {0}", this.Data.monsterName, this.Id);
				return;
			}

			_countDeaths = 0;

			Random rnd = new Random();
			this.calculatedTotalEntities = this.Data.count + rnd.Next(this.Data.countVariation);

			spawnEntities = new Dictionary<int, Monster>();
			rndGenerator = new Random();
		}

		public void DoSpawn(Object obj)
		{

			Monster monster = new Monster(this.MonsterData.Id, Shared.Const.NpcType.Monster);
			if (monster == null)
				return;

			monster = InitializeMonster(monster);
			if (monster == null)
				return;

			Log.Debug("Spawning entitiy : x {0} y {1} z {2}", monster.Position.X, monster.Position.Y, monster.Position.Z);

			lock (spawnEntities)
			{
				spawnEntities.Add(monster.Handle, monster);
			}

			if (spawnMaker != null)
				spawnMaker.GetMap().AddMonster(monster);

		}

		/// <summary>
		/// Spawns a monster from this Spawn
		/// </summary>
		/// <param name="amountToSpawn">Amount of monsters to spawn</param>
		/// <param name="respawnTime">Fixed seconds to wait before spawn</param>
		/// <param name="randomRespawnTime">Random seconds to wait before spawn</param>
		public bool Spawn(int amountToSpawn, int respawnTime, int randomRespawnTime)
		{
			Log.Debug("Spawn() called: amountToSpawn {0} respawnTime {1} randomRespawnTime {2}", amountToSpawn, respawnTime, randomRespawnTime);
			if (respawnTime > 0)
			{
				int timeToRespawn = respawnTime + rndGenerator.Next(randomRespawnTime);
				if (timeToRespawn == 0) timeToRespawn = 1;
				for (int i = 0; i < amountToSpawn; i++)
					Log.Debug("respawnTime: {0} ", timeToRespawn);
					TasksPoolManager.Instance.AddGeneralTask(DoSpawn, null, timeToRespawn * 1000);
			} else
			{
				for (int i = 0; i < amountToSpawn; i++)
					this.DoSpawn(null);
			}
			return true;
		}

		/// <summary>
		/// Despawn all monsters for this spawn
		/// </summary>
		public bool Despawn()
		{
			lock (spawnEntities)
			{
				foreach (var entity in spawnEntities.Values)
				{
					entity.DisappearTime = DateTime.Now;
				}
			}
			return true;
		}
		

		public Monster InitializeMonster(Monster monster)
		{
			if (monster == null)
				return null;

			// Position
			if (spawnMaker == null)
				return null;

			monster.Position = spawnMaker.GetSpawnPosition(this.Data);

			monster.AI = new AIMonster(monster);
			monster.AI.SetIntention(IntentionTypes.AI_INTENTION_ACTIVE);

			// Make a reference to this spawn zone in the monster.
			monster.spawnZone = this;
			monster.spawnPosition = new Position(monster.Position);

			return monster;
		}

		public void NotifyEntityDeath(int entityHandle)
		{
			Log.Debug("NotifyEntityDeath called");
			lock (spawnEntities)
			{
				spawnEntities.Remove(entityHandle);
			}

			_countDeaths++;

			this.spawnMaker.OnEntityDeleted(this);

		}

		public int LuaParams_OnEntityDeleted(IntPtr L)
		{
			Melua.lua_newtable(L);

			Melua.lua_pushstring(L, "idx");
			Melua.lua_pushinteger(L, this.spawnMaker.GetSpawnIndex(this));
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "respawn_time");
			Melua.lua_pushinteger(L, this.Data.respawnTime);
			Melua.lua_settable(L, -3);

			Melua.lua_pushstring(L, "random_respawn_time");
			Melua.lua_pushinteger(L, this.Data.randomRespawnTime);
			Melua.lua_settable(L, -3);

			return 1;
		}


	}
}
