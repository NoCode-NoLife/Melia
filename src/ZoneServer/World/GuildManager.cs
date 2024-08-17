using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Shared.Util;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Groups;

namespace Melia.Zone.World
{
	public class GuildManager
	{
		private readonly object _syncLock = new object();
		private Dictionary<long, Guild> _guilds = new Dictionary<long, Guild>();

		public Guild Create(Character character, string name)
		{
			var guild = new Guild()
			{
				LeaderDbId = character.DbId,
				Name = name,
			};

			ZoneServer.Instance.Database.CreateGuild(guild);

			var account = character.Connection.Account;
			var properties = account.Properties;

			properties.SetFloat(PropertyName.EVENT_IS_JOINED_GUILD, 1);
			Send.ZC_NORMAL.AccountPropertyUpdate(character.Connection, properties.GetSelect(PropertyName.EVENT_IS_JOINED_GUILD));
			guild.AddMember(character);
			guild.Properties.SetString(PropertyName.CreateTime, guild.DateCreated.ToSPropertyDateTime().ToString());
			Send.ZC_NORMAL.PartyPropertyUpdate(guild, guild.Properties.GetSelect(PropertyName.CreateTime));
			this.Add(guild);
			return guild;
		}

		/// <summary>
		/// Adds guild to the manager.
		/// </summary>
		/// <param name="guild"></param>
		/// <exception cref="ArgumentException">
		/// Thrown if a guild with the same id as the given one
		/// already exists.
		/// </exception>
		public void Add(Guild guild)
		{
			lock (_syncLock)
			{
				if (_guilds.ContainsKey(guild.ObjectId))
					throw new ArgumentException($"Guild id {guild.ObjectId} already exists.");

				_guilds.Add(guild.ObjectId, guild);
			}
		}

		/// <summary>
		/// Removes the guild with given id from the manager.
		/// </summary>
		/// <param name="guildId"></param>
		/// <exception cref="ArgumentException">
		/// Thrown if no guild with the given id exists.
		/// </exception>
		public void Remove(long guildId)
		{
			lock (_syncLock)
			{
				if (!_guilds.ContainsKey(guildId))
					throw new ArgumentException($"Guild {guildId} doesn't exist.");

				_guilds.Remove(guildId);
			}
		}

		/// <summary>
		/// Checks if a guild exists with given id in the manager.
		/// </summary>
		/// <param name="guildId"></param>
		/// <returns>True if the guild exists</returns>
		public bool Exists(long guildId)
		{
			lock (_syncLock)
			{
				return _guilds.ContainsKey(guildId);
			}
		}

		/// <summary>
		/// Find guild by id or null if it doesn't exist
		/// </summary>
		/// <param name="guildId"></param>
		/// <returns></returns>
		public Guild GetGuild(long guildId)
		{
			lock (_syncLock)
			{
				if (_guilds.ContainsKey(guildId))
					return _guilds[guildId];
			}
			return null;
		}
	}
}
