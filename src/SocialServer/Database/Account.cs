using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Social.Database
{
	public class Account
	{
		private readonly List<Character> _characters = new List<Character>();

		/// <summary>
		/// Account id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Account name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Account password.
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Gets or sets account's team name and updates all characters.
		/// </summary>
		public string TeamName
		{
			get { return _teamName; }
			set
			{
				_teamName = value;

				lock (_characters)
					_characters.ForEach(a => a.TeamName = value);
			}
		}
		private string _teamName;

		/// <summary>
		/// Group of chats, indexed by their id.
		/// </summary>
		public Dictionary<long, ChatGroup> ChatGroups { get; } = new Dictionary<long, ChatGroup>();

		/// <summary>
		/// Loads account with given name from database
		/// and returns it.
		/// </summary>
		/// <param name="accountName"></param>
		/// <returns></returns>
		public static Account LoadFromDb(string accountName)
		{
			var account = SocialServer.Instance.Database.GetAccount(accountName);
			if (account == null)
				return null;

			return account;
		}
	}
}
