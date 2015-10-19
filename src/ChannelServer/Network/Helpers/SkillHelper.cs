// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Network;

namespace Melia.Channel.Network.Helpers
{
	public static class SkillHelper
	{
		public static void AddSkill(this Packet packet, int skillId)
		{
			packet.PutLong(0); // skill object id (can be used to change skill properties with ZC_OBJECT_PROPERTY)
			packet.PutInt(skillId);
			packet.PutShort(6 * 1); // properties size
			packet.PutEmptyBin(2); // alignment
			packet.PutInt(0); // ?
			packet.PutShort(0); // ?
			packet.PutEmptyBin(2); // alignment
			// Properties
			packet.PutShort(4031); // Level
			packet.PutFloat(1);
			/*
			packet.PutShort(4020); // 
			packet.PutFloat(0);
			packet.PutShort(4024); // 
			packet.PutFloat(0);
			packet.PutShort(4023); // 
			packet.PutFloat(100);
			packet.PutShort(4021); // 
			packet.PutFloat(40);
			packet.PutShort(4030); // 
			packet.PutFloat(24);
			packet.PutShort(4105); // 
			packet.PutFloat(0);
			packet.PutShort(4147); // 
			packet.PutFloat(0);
			packet.PutShort(4157); // 
			packet.PutFloat(3);
			packet.PutShort(4068); // 
			packet.PutFloat(0);
			packet.PutShort(4062); // 
			packet.PutFloat(1);
			packet.PutShort(4161); // 
			packet.PutFloat(0);
			packet.PutShort(4118); // 
			packet.PutFloat(0);
			packet.PutShort(4102); // 
			packet.PutFloat(100);
			packet.PutShort(4184); // 
			packet.PutFloat(0);
			packet.PutShort(4043); // 
			packet.PutFloat(25);
			packet.PutShort(4183); // 
			packet.PutFloat(0);
			packet.PutShort(4058); // 
			packet.PutFloat(0);
			packet.PutShort(4185); // 
			packet.PutFloat(0);
			packet.PutShort(4186); // 
			packet.PutFloat(1);
			 * */
		}

	}
}
