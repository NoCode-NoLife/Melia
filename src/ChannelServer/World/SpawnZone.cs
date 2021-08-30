using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.World
{


	public struct SpawnData
	{
		public string spawnName;
		public string mapName;
		public string monsterName;
		public int count;
		public int countVariation;
		public bool isFixedLocation;
		public Position Position { get; set; }
		public Direction Direction { get; set; }
		public int respawnTime;
		public int xMin, xMax, zMin, zMax;
	}

	public class SpawnZone
	{

		public int Id;
		public SpawnData Data { get; set; }
		public MonsterData MonsterData { get; set; }
		private Map _map;
		private Dictionary<int, Monster> _spawnEntities;
		private int _calculatedTotalEntities;
		private int _countEntities;
		private int _countDeaths;
		private bool _isInitialized;
		private bool _respawnEnabled;
		private Random rndGenerator;

		public SpawnZone(SpawnData spawnData)
		{
			this.Data = spawnData;
			this.MonsterData = ChannelServer.Instance.Data.MonsterDb.Find(this.Data.monsterName);

			if (this.MonsterData == null)
			{
				Log.Error("Error initializing Spawn Zone {1} {2}. Monster not found. {0}", this.Data.monsterName, this.Id, this.Data.spawnName);
				return;
			}

			_map = ChannelServer.Instance.World.GetMap(this.Data.mapName);
			if (_map == null)
			{
				Log.Error("Error initializing Spawn Zone {1} {2}. Map not found. {0}", this.Data.mapName, this.Id, this.Data.spawnName);
				return;
			}
			Log.Debug("map {0}", _map.Name);

			_isInitialized = false;
			_countDeaths = 0;

			_spawnEntities = new Dictionary<int, Monster>();
			rndGenerator = new Random();
		}

		public void StartRespawn()
		{
			if (!_isInitialized)
			{
				Log.Warning("Spawn {0} {1} can't start respawn because its not initialized.", this.Id, this.Data.spawnName);
				return;
			}

			_respawnEnabled = true;
		}

		public void StopRespawn()
		{
			_respawnEnabled = false;
		}

		public void Init()
		{
			if (_map == null || this.MonsterData == null)
				return;

			// Calculate count of spawn entities
			Random rnd = new Random();
			_calculatedTotalEntities = this.Data.count + rnd.Next(this.Data.countVariation);
			_countEntities = 0;

			_isInitialized = true;
			_respawnEnabled = true;

			for (int i = 0; i < _calculatedTotalEntities; i++)
			{
				DoSpawn();
			}

		}

		public void DoSpawn(Object obj = null)
		{
			if (!_isInitialized && !_respawnEnabled)
				return;

			Monster monster = new Monster(this.MonsterData.Id, Shared.Const.NpcType.Monster);

			monster = InitializeMonster(monster);

			lock (_spawnEntities)
			{
				_spawnEntities.Add(monster.Handle, monster);
				_countEntities = _spawnEntities.Count;
			}

			_map.AddMonster(monster);

		}

		public Monster InitializeMonster(Monster monster)
		{
			if (monster == null)
				return null;
			
			monster.Position = new Position(this.Data.Position.X, this.Data.Position.Y, this.Data.Position.Z);

			//monster.AI = new AIMonster(monster);
			//monster.AI.SetIntention(IntentionTypes.AI_INTENTION_ACTIVE);
			monster.Died += onMonsterDied;

			return monster;
		}

		public bool GetRandomPosition(out Position rndPosition)
		{
			rndPosition = new Position();
			return false;
		}

		private void onMonsterDied(object sender, OnEntityEventArgs entity)
		{
			lock (_spawnEntities)
			{
				_spawnEntities.Remove(entity.Handle);
				_countEntities = _spawnEntities.Count;
			}

			_countDeaths++;


			if (this.Data.respawnTime > 0)
			{
				if (_countEntities < _calculatedTotalEntities)
				{
					Log.Debug("Respawning scheduled in time {0}", this.Data.respawnTime * 1000);
					Task.Delay(this.Data.respawnTime * 1000).ContinueWith(this.DoSpawn);
				}
			}
		}

	}
}
