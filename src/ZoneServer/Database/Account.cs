using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game;
using Melia.Shared.Game.Const;
using Melia.Shared.Network.Helpers;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Scripting;
using Melia.Zone.World;
using Melia.Zone.World.Maps;

namespace Melia.Zone.Database
{
	/// <summary>
	/// A player's account.
	/// </summary>
	public class Account : IAccount
	{
		/// <summary>
		/// List of chat macros associated with the account.
		/// </summary>
		private readonly IList<ChatMacro> _chatMacros = new List<ChatMacro>();

		/// <summary>
		/// List of the revealed maps the user has explored.
		/// </summary>
		private readonly Dictionary<int, RevealedMap> _revealedMaps = new();

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
		/// Returns the game permission level, based on the account's
		/// authority.
		/// </summary>
		public PermissionLevel PermissionLevel
		{
			get
			{
				//var auth = this.Authority;

				//if (auth >= 99)
				//	return PermissionLevel.Operator;
				//else if (auth >= 50)
				//	return PermissionLevel.GM;
				//else
				//	return PermissionLevel.User;

				// We'll return User for now, as running around with GM
				// permissions changes the game's behavior and UI to a
				// degree. We'll need to implement a way to choose the
				// permission we want to use at run-time.

				return PermissionLevel.User;
			}
		}

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
		/// Barrack Layer
		/// </summary>
		public int SelectedBarrackLayer { get; set; }

		/// <summary>
		/// The account's settings.
		/// </summary>
		public AccountSettings Settings { get; } = new AccountSettings();

		/// <summary>
		/// Account's scripting variables.
		/// </summary>
		public VariablesContainer Variables { get; } = new VariablesContainer();

		/// <summary>
		/// Returns a reference to the account's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties("Account");

		/// <summary>
		/// Returns the account's premium status manager.
		/// </summary>
		public PremiumStatus Premium { get; } = new();

		/// <summary>
		/// Creates new account.
		/// </summary>
		public Account()
		{
			// TODO: Remove the selected barrack once those are saved to the database.
			this.SelectedBarrack = 11;

			this.LoadDefaultChatMacros();
		}

		/// <summary>
		/// Loads default chat macros from data.
		/// </summary>
		private void LoadDefaultChatMacros()
		{
			// Get all and add a maximum of 10
			var macroData = ZoneServer.Instance.Data.ChatMacroDb.Entries.Values.OrderBy(x => x.Id);

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
			return ZoneServer.Instance.Database.GetAccount(accountName);
		}

		/// <summary>
		/// Saves account database.
		/// </summary>
		public void Save()
		{
			ZoneServer.Instance.Database.SaveAccount(this);
		}
	}
}
