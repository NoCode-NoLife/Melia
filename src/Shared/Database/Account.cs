using Melia.Shared.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Database
{
	public class Account
	{
		private List<Character> _characters { get; set; }

		public long Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
		public string TeamName { get; set; }

		public Account()
		{
			_characters = new List<Character>();
		}

		public Character[] GetCharacters()
		{
			lock (_characters)
				return _characters.ToArray();
		}

		public Character GetCharacterByIndex(byte index)
		{
			lock (_characters)
				return _characters.FirstOrDefault(a => a.Index == index);
		}

		public Character GetCharacterById(long id)
		{
			lock (_characters)
				return _characters.FirstOrDefault(a => a.Id == id);
		}

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

		public void RemoveCharacter(Character character)
		{
			lock (_characters)
				_characters.Remove(character);
		}
	}
}
