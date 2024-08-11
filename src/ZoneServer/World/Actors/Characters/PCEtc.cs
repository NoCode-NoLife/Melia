using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
using Melia.Zone.World.Storage;

namespace Melia.Zone.World.Actors.Characters
{
	/// <summary>
	/// Represents the character's etc property manager.
	/// </summary>
	public class PCEtc : IPropertyObject
	{
		private readonly Character _character;

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

			// Set up some default etc properties
			this.Properties.Create(new StringProperty(PropertyName.SkintoneName, "skintone2"));
			this.Properties.Create(new StringProperty(PropertyName.StartHairName, "UnbalancedShortcut"));
			this.Properties.Create(new RFloatProperty(PropertyName.LobbyMapID, () => _character.MapId));
			this.Properties.Create(new RStringProperty(PropertyName.RepresentationClassID, () => _character.JobId.ToString()));
			this.Properties.Create(new FloatProperty(PropertyName.LastPlayDate, 20210728));
			this.Properties.Create(new FloatProperty(PropertyName.CTRLTYPE_RESET_EXCEPT, 1));
			this.Properties.Create(new FloatProperty(PropertyName.MaxWarehouseCount, PersonalStorage.DefaultSize));

		}
	}
}
