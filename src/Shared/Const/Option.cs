// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

namespace Melia.Shared.Const
{
	// TODO: config.ies has all values, incl. defaults. Make a db as well?
	public enum Option
	{
		ShowExpAquired = 3,
		ShowCharacterName = 15,
		ShowTeamNameOnly = 20,
		ShowOtherPlayersNames = 42,
		UiMode = 43, // 1=joypad, 2=keyboard, 3=mouse
		JoypadVibration = 46,
		ApplyVignette = 22,
		ApplyBloom = 23,
		ApplyFxaa = 24,
		ApplyGlow = 25,
		ApplyDepth = 26,
		ApplySoftParticles = 33,
		ApplyHighTexture = 45,
		ShowOtherCharactersEffects = 48,
		ChatWidth = 50,
		ChatHeight = 51,
		UseCameraVibration1 = 52,
		UseCameraVibration2 = 53, // Sometimes sent as 52, sometimes as 53... bug? 52 should be "EnableNaturalEffect".
		ApplyDeadParts = 54,
		ApplyCharacterSilhouettes = 55,
		MinimapSize = 44,
	}
}
