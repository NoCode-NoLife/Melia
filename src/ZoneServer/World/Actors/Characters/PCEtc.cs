using Melia.Shared.ObjectProperties;

namespace Melia.Zone.World.Actors.Characters
{
	/// <summary>
	/// Represents the character's etc property manager.
	/// </summary>
	public class PCEtc : IPropertyObject
	{
		/// <summary>
		/// Returns the property object's unique id.
		/// </summary>
		public long ObjectId { get; }

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
			this.ObjectId = character.SocialUserId;
		}
	}
}
