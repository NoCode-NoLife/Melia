// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System.Collections.Generic;
using System.Linq;
using Melia.Channel.Scripting;
using Melia.Channel.World;
using Melia.Shared.Util;
using Melia.Shared.Network.Helpers;

namespace Melia.Channel.Database
{
	/// <summary>
	/// A player's account.
	/// </summary>
	public class Account : IAccount
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
		/// Amount of Free TP.
		/// </summary>
		public int Medals { get; set; }

		/// <summary>
		/// Amount of Event TP.
		/// </summary>
		public int GiftMedals { get; set; }

		/// <summary>
		/// Amount of TP.
		/// </summary>
		public int PremiumMedals { get; set; }

		/// <summary>
		/// Id of the barrack map.
		/// </summary>
		public int SelectedBarrack { get; set; }

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
			// TODO: Remove the selected barrack once those are saved to the database.
			this.SelectedBarrack = 11;
			this.Settings = new AccountSettings();
			this.Variables = new Variables();
			_chatMacros = new List<ChatMacro>();
			_revealedMaps = new Dictionary<int, RevealedMap>();

			this.LoadDefaultChatMacros();
		}

		/// <summary>
		/// Loads default chat macros from data.
		/// </summary>
		private void LoadDefaultChatMacros()
		{
			// Get all and add a maximum of 10
			var macroData = ChannelServer.Instance.Data.ChatMacroDb.OrderBy(x => x.Id);

			var i = 1;
			foreach (var data in macroData)
			{
				var macro = new ChatMacro(i, data.Text, data.Pose);
				this.AddChatMacro(macro);

				if (++i > 10)
					break;
			}
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
				if (_revealedMaps.TryGetValue(revealedMap.MapId, out var map))
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
