using Melia.Shared.ObjectProperties;

namespace Melia.Zone.World.Actors.Characters
{
	/// <summary>
	/// Represents the character's etc property manager.
	/// </summary>
	public class PCEtc : IPropertyObject
	{
		private Character _character;

		/// <summary>
		/// Returns the property object's unique id.
		/// </summary>
		public long ObjectId => _character.SocialUserId;

		/// <summary>
		/// Returns the object's properties.
		/// </summary>
		public Properties Properties { get; } = new Properties("PCEtc");

		/// <summary>
		/// Creates new instance for the given character.
		/// </summary>
		/// <param name="character"></param>
		public PCEtc(Character character)
		{
			// Since the db id is not set at time of creation of this object,
			// we save the character and reference the id dynamically.
			_character = character;
		}
	}
}
