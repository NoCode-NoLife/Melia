using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Const
{
	public enum MsgType : byte
	{
		Text = 0,
		UsernameOrPasswordIncorrect1 = 1, // Username?
		UsernameOrPasswordIncorrect2 = 2, // Password?
		DoubleLogin = 3, // Disconnects gracefully
		WrongVerificationCode = 4,
		ServerVersionDoesNotMatch = 5,
		NameAlreadyExists = 6,
		CannotCreateCharacter = 7,
		CharacterNameTooShort = 8, // "The character name must be at least %s characters.
		// 9
		CannotDeleteCharacter1 = 10,
		CreateCharFail = 11,
		CharacterNameTooLong = 12, // "The character name must be less than %s characters.
		CannotDeleteCharacter2 = 13,
		TeamDoesNotExist = 14,
		CharacterDoesNotExist = 15,
		CannotStartGame = 16,
		NewJobAdded = 17,
		// 18
		TeamMemberCapExceeded = 19,
		InsufficientCharacterPoints = 20,
		AccountBlocked1 = 21,
		AccountBlocked2 = 22,

		NotCBTUser = 26,

		// ...
	}
}
