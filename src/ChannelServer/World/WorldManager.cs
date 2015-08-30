// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Melia.Channel.World
{
	public class WorldManager
	{
		private int _handles = 0;
		private Dictionary<int, Map> _maps;

		/// <summary>
		/// Returns the amount of maps in the world.
		/// </summary>
		public int Count { get { lock (_maps) return _maps.Count; } }

		/// <summary>
		/// Creates new world manager.
		/// </summary>
		public WorldManager()
		{
			_maps = new Dictionary<int, Map>();
		}

		/// <summary>
		/// Returns a new handle to be used for a character or monster.
		/// </summary>
		/// <returns></returns>
		public int CreateHandle()
		{
			// TODO: 2b are a lot, but if items use this as well... we might
			//   need a fallback, or a way to release handles of logged out
			//   characters or killed monsters.
			return Interlocked.Increment(ref _handles);
		}

		/// <summary>
		/// Loads maps from data.
		/// </summary>
		public void Initialize()
		{
			foreach (var entry in ChannelServer.Instance.Data.MapDb.Entries.Values)
			{
				_maps.Add(entry.Id, new Map(entry.Id));
			}
		}

		/// <summary>
		/// Returns map by id, or null if it doesn't exist.
		/// </summary>
		/// <param name="mapId"></param>
		public Map GetMap(int mapId)
		{
			Map result;
			lock (_maps)
				_maps.TryGetValue(mapId, out result);
			return result;
		}
	}
}
