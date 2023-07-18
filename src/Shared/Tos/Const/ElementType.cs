namespace Melia.Shared.Tos.Const
{
	public enum ElementType
	{
		// Order for consistency in the code base, values based on what
		// the client expects for monster elements/attributes. Values
		// outside of the defined ones display as Poison.

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
	}
}
