namespace Melia.Shared.Game.Const
{
	public enum AttributeType : int
	{
		// The values were ordered for consistency in the code base, while
		// their values are based on what the client expects for monster
		// elements/attributes. Values that are outside of the 0-9 range
		// are displayed as Poison in the client.

		None = 0,
		Fire = 1,
		Ice = 2,
		Lightning = 7,
		Earth = 4,
		Poison = 3,
		Holy = 8,
		Dark = 9,
		Soul = 6, // aka Psychokinesis?
		Melee = 5,

		// The following values appear to not be used or handled by the client
		// for monsters, but they can be found in other areas, such as the skill
		// data. They are included so we can use this enum everywhere, but they
		// should be considered somewhat custom.

		Magic = 999999,
	}
}
