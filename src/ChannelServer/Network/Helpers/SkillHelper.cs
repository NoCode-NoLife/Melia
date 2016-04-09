﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using Melia.Shared.Const;
using Melia.Shared.Network;

namespace Melia.Channel.Network.Helpers
{
	public static class SkillHelper
	{
		public static void AddSkill(this Packet packet, int skillId)
		{
			var skill = ChannelServer.Instance.Data.SkillDb.Find(skillId);
			if (skill == null)
				throw new NullReferenceException("Tried to add non-existing skill'" + skillId + "' ");
			packet.PutLong(0); // skill object id (can be used to change skill properties with ZC_OBJECT_PROPERTY)
			packet.PutInt(skillId);
			packet.PutShort(6 * 4); // properties size
			packet.PutEmptyBin(2); // alignment
			packet.PutInt(0); // ?
			packet.PutShort(0); // ?
			packet.PutEmptyBin(2); // alignment
			// Properties
			packet.PutShort(ObjectProperty.Skill.Level);
			packet.PutFloat(1);
			packet.PutShort(ObjectProperty.Skill.WaveLength);
			packet.PutFloat(skill.WaveLength);
			packet.PutShort(ObjectProperty.Skill.SplAngle);
			packet.PutFloat(skill.SplashAngle);
			packet.PutShort(ObjectProperty.Skill.SplRange);
			packet.PutFloat(skill.SplashRange);
		}

	}
}
