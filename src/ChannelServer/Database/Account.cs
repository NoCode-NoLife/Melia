// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.Scripting;
using Melia.Channel.World;
using Melia.Shared.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.Database
{
	/// <summary>
	/// A player's account.
	/// </summary>
	public class Account
	{
		/// <summary>
		/// List of chat macros associated with the account.
		/// </summary>
		private IList<ChatMacro> _chatMacros;

		/// <summary>
		/// List of the revealed maps the user has explored.
		/// </summary>
		private Dictionary<int, RevealedMap> _revealedMaps;

		/// <summary>
		/// Account id
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Account name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Account's team name
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// The account's authority level, used to determine if a character
		/// can use a specific GM command.
		/// </summary>
		public int Authority { get; set; }

		/// <summary>
		/// The account's settings.
		/// </summary>
		public AccountSettings Settings { get; private set; }

		/// <summary>
		/// Account's scripting variables.
		/// </summary>
		public Variables Variables { get; private set; }

		/// <summary>
		/// Creates new account.
		/// </summary>
		public Account()
		{
			this.Settings = new AccountSettings();
			this.Variables = new Variables();
			_chatMacros = new List<ChatMacro>();
			_revealedMaps = new Dictionary<int, RevealedMap>();
		}

		/// <summary>
		/// Adds a chat macro to the account.
		/// </summary>
		/// <param name="character"></param>
		public void AddChatMacro(ChatMacro macro)
		{
			lock (_chatMacros)
			{
				var oldMacro = _chatMacros.FirstOrDefault(x => x.Index == macro.Index);
				if (oldMacro == null)
					_chatMacros.Add(macro);
				else
					oldMacro.Update(macro.Message, macro.Pose);
			}
		}

		/// <summary>
		/// Returns an array of chat macros.
		/// </summary>
		/// <returns></returns>
		public ChatMacro[] GetChatMacros()
		{
			lock (_chatMacros)
				return _chatMacros.ToArray();
		}

		/// <summary>
		/// Adds a revealed map to the account.
		/// </summary>
		/// <param name="map"></param>
		public void AddRevealedMap(RevealedMap revealedMap)
		{
			lock (_revealedMaps)
			{
				RevealedMap map;
				if (_revealedMaps.TryGetValue(revealedMap.MapId, out map))
					map.Update(revealedMap.Explored, revealedMap.Percentage);
				else
					_revealedMaps[revealedMap.MapId] = revealedMap;
			}
		}

		/// <summary>
		/// Returns an array of revealed maps.
		/// </summary>
		/// <returns></returns>
		public RevealedMap[] GetRevealedMaps()
		{
			lock (_revealedMaps)
				return _revealedMaps.Values.ToArray();
		}

		/// <summary>
		/// Loads account with given name from database and returns it.
		/// </summary>
		/// <param name="accountName"></param>
		/// <returns></returns>
		public static Account LoadFromDb(string accountName)
		{
			return ChannelServer.Instance.Database.GetAccount(accountName);
		}

		/// <summary>
		/// Saves account database.
		/// </summary>
		public void Save()
		{
			ChannelServer.Instance.Database.SaveAccount(this);
		}
	}
}
