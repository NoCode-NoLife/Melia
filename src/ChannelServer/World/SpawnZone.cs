using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.World
{
	public struct SpawnData
	{
		public string SpawnName { get; set; }
		public string MapName { get; set; }
		public string MonsterName { get; set; }
		public int Count { get; set; }
		public int CountVariation { get; set; }
		public bool IsFixedLocation { get; set; }
		public Position Position { get; set; }
		public Direction Direction { get; set; }
		public int RespawnTime { get; set; }
		public int XMin { get; set; }
		public int XMax { get; set; }
		public int ZMin { get; set; }
		public int ZMax { get; set; }
	}

	public class SpawnZone
	{
		private readonly Map _map;
		private readonly Dictionary<int, Monster> _spawnEntities = new Dictionary<int, Monster>();
		private int _calculatedTotalEntities;
		private int _countEntities;
		private int _countDeaths;
		private bool _isInitialized;
		private bool _respawnEnabled;
		private readonly Random _rnd = RandomProvider.Get();

		public int Id { get; set; }
		public SpawnData Data { get; set; }
		public MonsterData MonsterData { get; set; }

		public SpawnZone(SpawnData spawnData)
		{
			this.Data = spawnData;
			this.MonsterData = ChannelServer.Instance.Data.MonsterDb.Find(this.Data.MonsterName);

			if (this.MonsterData == null)
			{
				Log.Error("Error initializing Spawn Zone {1} {2}. Monster not found. {0}", this.Data.MonsterName, this.Id, this.Data.SpawnName);
				return;
			}

			_map = ChannelServer.Instance.World.GetMap(this.Data.MapName);
			if (_map == null)
			{
				Log.Error("Error initializing Spawn Zone {1} {2}. Map not found. {0}", this.Data.MapName, this.Id, this.Data.SpawnName);
				return;
			}

			//Log.Debug("map {0}", _map.Name);
		}

		public void StartRespawn()
		{
			if (!_isInitialized)
			{
				Log.Warning("Spawn {0} {1} can't start respawn because its not initialized.", this.Id, this.Data.SpawnName);
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
			_calculatedTotalEntities = this.Data.Count + _rnd.Next(this.Data.CountVariation);
			_countEntities = 0;

			_isInitialized = true;
			_respawnEnabled = true;

			for (var i = 0; i < _calculatedTotalEntities; i++)
				this.DoSpawn();
		}

		public void DoSpawn(object obj = null)
		{
			if (!_isInitialized && !_respawnEnabled)
				return;

			var monster = new Monster(this.MonsterData.Id, Shared.Const.NpcType.Monster);
			monster = this.InitializeMonster(monster);

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
			monster.Died += this.OnMonsterDied;

			//monster.AI = new AIMonster(monster);
			//monster.AI.SetIntention(IntentionTypes.AI_INTENTION_ACTIVE);

			return monster;
		}

		private void OnMonsterDied(object sender, EntityEventArgs entity)
		{
			lock (_spawnEntities)
			{
				_spawnEntities.Remove(entity.Handle);
				_countEntities = _spawnEntities.Count;
			}

			_countDeaths++;

			if (this.Data.RespawnTime > 0 && _countEntities < _calculatedTotalEntities)
			{
				//Log.Debug("Respawning scheduled in time {0}", this.Data.RespawnTime * 1000);
				Task.Delay(this.Data.RespawnTime * 1000).ContinueWith(this.DoSpawn);
			}
		}
	}
}
