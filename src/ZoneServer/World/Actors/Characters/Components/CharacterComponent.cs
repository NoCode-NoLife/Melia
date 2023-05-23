using Yggdrasil.Composition;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// A component for a character.
	/// </summary>
	public abstract class CharacterComponent : IComponent
	{
		/// <summary>
		/// Returns the owner of this component.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Initializes component's properties.
		/// </summary>
		/// <param name="character"></param>
		public CharacterComponent(Character character)
		{
			this.Character = character;
		}
	}
}
