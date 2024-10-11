using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Network.Helpers;
using Melia.Shared.ObjectProperties;
using Melia.Shared.Game.Const;

namespace Melia.Barracks.Database
{
	/// <summary>
	/// Represents a player's account.
	/// </summary>
	public class Account : IAccount
	{
		private readonly object _moneyLock = new();
		private readonly List<Character> _characters = new();
		private readonly List<Companion> _companions = new List<Companion>();

		/// <summary>
		/// Gets or sets account's id.
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Gets or sets account's name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets account's password.
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
		/// The account's authority level, used to determine if a character
		/// can use a specific GM command.
		/// </summary>
		public int Authority { get; set; }

		/// <summary>
		/// Amount of Free TP.
		/// </summary>
		public int Medals { get; set; } = 500;

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
		public int SelectedBarrack { get; set; } = 11;

		/// <summary>
		/// The layer that is currently selected as being viewed.
		/// </summary>
		public int SelectedBarrackLayer { get; set; } = 1;

		/// <summary>
		/// Gets or sets the slot number of the character that was last
		/// selected. Controls which character is selected upon login.
		/// </summary>
		public int SelectedCharacterSlot { get; set; }

		/// <summary>
		/// Returns a list of themas available to the account.
		/// </summary>
		public HashSet<int> Themas { get; } = new HashSet<int>() { 11 };

		/// <summary>
		/// Returns the number of characters the account has.
		/// </summary>
		public int CharacterCount { get { lock (_characters) return _characters.Count; } }

		/// <summary>
		/// Gets or sets the number of additional character slots the account
		/// can use, on top of the default amount defined in the barrack data.
		/// </summary>
		public int AdditionalSlotCount { get; set; }

		/// <summary>
		/// Gets or sets the accounts team EXP, which can be collected
		/// across all characters.
		/// </summary>
		public int TeamExp { get; set; }

		/// <summary>
		/// Gets or sets the account's mail box.
		/// </summary>
		public Mailbox Mailbox { get; } = new Mailbox();

		/// <summary>
		/// Returns a reference to the account's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties("Account");

		/// <summary>
		/// Initializes account and its properties.
		/// </summary>
		public Account()
		{
			this.Properties.Create(new RFloatProperty(PropertyName.SelectedBarrack, () => this.SelectedBarrack));
			this.Properties.Create(new RFloatProperty(PropertyName.Medal, () => this.Medals));
			this.Properties.Create(new RFloatProperty(PropertyName.GiftMedal, () => this.GiftMedals));
			this.Properties.Create(new RFloatProperty(PropertyName.PremiumMedal, () => this.PremiumMedals));
			this.Properties.Create(new StringProperty(PropertyName.Medal_Get_Date, "202107321185720"));
			this.Properties.Create(new StringProperty(PropertyName.CTT_TempProperty_AC_Str_1, "x64_OS"));
			this.Properties.Create(new StringProperty(PropertyName.CTT_TempProperty_AC_Str_2, "x86_Client"));
			this.Properties.Create(new StringProperty(PropertyName.CTT_TempProperty_AC_Str_3, "x64_Client"));
		}

		/// <summary>
		/// Returns list of all characters on account.
		/// </summary>
		/// <returns></returns>
		public Character[] GetCharacters()
		{
			lock (_characters)
				return _characters.ToArray();
		}

		/// <summary>
		/// Returns character by index, or null if it doesn't exist.
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public Character GetCharacterByIndex(int index)
		{
			lock (_characters)
				return _characters.FirstOrDefault(a => a.Index == index);
		}

		/// <summary>
		/// Returns character by character id, or null if it doesn't exist.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Character GetCharacterById(long id)
		{
			lock (_characters)
				return _characters.FirstOrDefault(a => a.ObjectId == id);
		}

		/// <summary>
		/// Adds character to account object and assigns index and team name.
		/// </summary>
		/// <param name="character"></param>
		private void AddCharacter(Character character)
		{
			lock (_characters)
			{
				for (byte i = 1; i <= byte.MaxValue; ++i)
				{
					if (!_characters.Any(a => a.Index == i))
					{
						character.Index = i;
						break;
					}
				}

				character.TeamName = this.TeamName;

				_characters.Add(character);
			}
		}

		/// <summary>
		/// Removes character from account object.
		/// </summary>
		/// <param name="character"></param>
		private void RemoveCharacter(Character character)
		{
			lock (_characters)
				_characters.Remove(character);
		}

		/// <summary>
		/// Loads account with given name from database, incl. characters,
		/// and returns it.
		/// </summary>
		/// <param name="accountName"></param>
		/// <returns></returns>
		public static Account LoadFromDb(string accountName)
		{
			var account = BarracksServer.Instance.Database.GetAccount(accountName);
			if (account == null)
				return null;

			var characters = BarracksServer.Instance.Database.GetCharacters(account.Id);
			foreach (var character in characters)
				account.AddCharacter(character);

			var companions = BarracksServer.Instance.Database.GetCompanions(account.Id);
			foreach (var companion in companions)
				account.AddCompanion(companion);

			BarracksServer.Instance.Database.LoadMailbox(account);

			return account;
		}

		/// <summary>
		/// Removes character from the account and the database.
		/// </summary>
		/// <param name="character"></param>
		/// <returns></returns>
		public bool DeleteCharacter(Character character)
		{
			lock (_characters)
			{
				if (!_characters.Contains(character))
					return false;
			}

			// If the deletion on the db fails, the character shouldn't
			// have been shown to begin with and should be removed.
			// If it doesn't fail, the removal is valid as well,
			// do this regardless of the query result.
			this.RemoveCharacter(character);

			return BarracksServer.Instance.Database.DeleteCharacter(character);
		}

		/// <summary>
		/// Adds character to the account and the database.
		/// </summary>
		/// <param name="character"></param>
		public void CreateCharacter(Character character)
		{
			BarracksServer.Instance.Database.CreateCharacter(this.Id, character);
			this.AddCharacter(character);
		}

		/// <summary>
		/// Sets the selected barrack layer.
		/// </summary>
		/// <param name="layer"></param>
		public void SetSelectedBarrackLayer(int layer)
		{
			this.SelectedBarrackLayer = layer;
		}

		/// <summary>
		/// Returns whether the account has enough combined medals to
		/// afford a purchase with the given cost.
		/// </summary>
		/// <param name="cost"></param>
		/// <returns></returns>
		public bool CanAffordPurchase(int cost)
		{
			lock (_moneyLock)
				return cost <= this.Medals + this.GiftMedals + this.PremiumMedals;
		}

		/// <summary>
		/// Processes a charge attempt on the account.
		/// </summary>
		/// <param name="cost">Amount of medals to remove.</param>
		/// <returns>Returns 'true' on a successful charge.</returns>
		/// <exception cref="ArgumentException">
		/// Thrown if cost is negative.
		/// </exception>
		public bool Charge(int cost)
		{
			if (cost < 0)
				throw new ArgumentException("Cost must be a positive value.");

			lock (_moneyLock)
			{
				var medals = this.Medals;
				var giftMedals = this.GiftMedals;
				var premiumMedals = this.PremiumMedals;

				// Take only medals if possible
				if (cost <= medals)
				{
					this.Medals -= cost;
					return true;
				}

				// Take only medals and gift medals if possible
				if (cost <= medals + giftMedals)
				{
					this.Medals = 0;
					this.GiftMedals -= (cost - medals);
					return true;
				}

				// Take it all
				if (cost <= medals + giftMedals + premiumMedals)
				{
					this.Medals = 0;
					this.GiftMedals = 0;
					this.PremiumMedals -= (cost - medals - giftMedals);
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Saves account and characters in database.
		/// </summary>
		public void Save()
		{
			BarracksServer.Instance.Database.SaveAccount(this);
			BarracksServer.Instance.Database.SaveMail(this);

			lock (_characters)
			{
				foreach (var character in _characters)
					BarracksServer.Instance.Database.SaveCharacter(character);
			}
		}

		/// <summary>
		/// Returns companion by companion id, or null if it doesn't exist.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Companion GetCompanionById(long id)
		{
			lock (_companions)
				return _companions.FirstOrDefault(a => a.ObjectId == id);
		}

		/// <summary>
		/// Returns list of all companions on account.
		/// </summary>
		/// <returns></returns>
		public Companion[] GetCompanions()
		{
			lock (_companions)
				return _companions.ToArray();
		}

		/// <summary>
		/// Adds companion to account object and assigns index.
		/// </summary>
		/// <param name="companion"></param>
		private void AddCompanion(Companion companion)
		{
			lock (_companions)
			{
				for (byte i = 1; i <= byte.MaxValue; ++i)
				{
					if (!_companions.Any(a => a.Index == i))
					{
						companion.Index = i;
						break;
					}
				}

				_companions.Add(companion);
			}
		}
	}
}
