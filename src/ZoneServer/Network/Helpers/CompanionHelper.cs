using Melia.Shared.Network;
using Melia.Shared.Network.Helpers;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Network.Helpers
{
	public static class CompanionHelper
	{
		public static void AddCompanion(this Packet packet, Companion companion)
		{
			// Safety check
			if (companion == null)
				return;
			var properties = companion.Properties.GetAll();
			var propertiesSize = properties.GetByteCount();

			packet.PutInt(companion.Id);
			packet.PutLong(companion.ObjectId);
			packet.PutLong(companion.Owner.ObjectId);
			packet.PutLong(companion.Exp);
			packet.PutLpString(companion.Name);
			packet.PutByte(0);
			packet.PutPosition(companion.Position);
			packet.PutDirection(companion.Direction);
			packet.PutInt(companion.Handle);
			packet.PutShort(propertiesSize);
			packet.AddProperties(properties);
			packet.PutShort(0);
			packet.PutByte(1);
			packet.PutByte(1);
			packet.PutInt(0);
			packet.PutInt(1);
			packet.PutByte(0);
			packet.PutByte(1);
			packet.PutByte(1);
			packet.PutInt(0);
			packet.PutInt(companion.Stamina);
			packet.PutInt(0);
		}
	}
}
