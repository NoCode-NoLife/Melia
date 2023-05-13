using Melia.Zone.Skills;
using Melia.Shared.Network2;
using Melia.Shared.Network2.Helpers;

namespace Melia.Zone.Network.Helpers
{
	public static class SkillHelper
	{
		/// <summary>
		/// Adds skill data to packet.
		/// </summary>
		/// <param name="packet"></param>
		/// <param name="skill"></param>
		public static void AddSkill(this Packet packet, Skill skill)
		{
			var properties = skill.Properties.GetAll();
			var propertiesSize = skill.Properties.Size;

			packet.PutLong(skill.ObjectId);
			packet.PutInt((int)skill.Id);
			packet.PutShort(propertiesSize);
			packet.PutEmptyBin(2); // alignment
			packet.PutInt(0);
			packet.PutShort(0);
			packet.PutEmptyBin(2); // alignment
			packet.AddProperties(properties);
		}
	}
}
