using Melia.Shared.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Database
{
	/// <summary>
	/// A player's account.
	/// </summary>
	public class Account
	{
		private List<Character> _characters { get; set; }

		/// <summary>
		/// Account id
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Account name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Account password (MD5 hash)
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Account's team name
		/// </summary>
		public string TeamName { get; set; }

		/// <summary>
		/// Creates new account.
		/// </summary>
		public Account()
		{
			_characters = new List<Character>();
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
		public Character GetCharacterByIndex(byte index)
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
				return _characters.FirstOrDefault(a => a.Id == id);
		}

		/// <summary>
		/// Adds character to account object and assigns it an index.
		/// </summary>
		/// <param name="character"></param>
		public void AddCharacter(Character character)
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

				_characters.Add(character);
			}
		}

		/// <summary>
		/// Removes character from account object.
		/// </summary>
		/// <param name="character"></param>
		public void RemoveCharacter(Character character)
		{
			lock (_characters)
				_characters.Remove(character);
		}
	}
}
