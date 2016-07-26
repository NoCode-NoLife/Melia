// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using Melia.Shared.Const;
using Melia.Shared.Network;
using Melia.Channel.World;
using Melia.Shared.Util;

namespace Melia.Channel.Network.Helpers
{
	public static class SkillHelper
	{
		public static void AddSkill(this Packet packet, Skill skill)
		{
			Log.Debug("AddSkill called. SkillID {0}, SWorldId {1}", skill.Id, skill.WorldId);
			packet.PutLong(skill.WorldId); // skill object id (can be used to change skill properties with ZC_OBJECT_PROPERTY)
			packet.PutInt(skill.Id);
			packet.PutShort(6 * 22); // properties size
			packet.PutEmptyBin(2); // alignment
			packet.PutInt(0); // ?
			packet.PutShort(0); // ?
			packet.PutEmptyBin(2); // alignment
			// Properties
			packet.PutShort(ObjectProperty.Skill.Level);
			packet.PutFloat((float)skill.level);
			packet.PutShort(ObjectProperty.Skill.CoolDown);
			packet.PutFloat((float)skill.Data.CoolDown);
			packet.PutShort(ObjectProperty.Skill.SpendItemCount);
			packet.PutFloat(0.0f);
			packet.PutShort(ObjectProperty.Skill.SplRange);
			packet.PutFloat((float)skill.Data.SplashRange);
			packet.PutShort(ObjectProperty.Skill.MaxR);
			packet.PutFloat(140.0f);
			packet.PutShort(ObjectProperty.Skill.SplAngle);
			packet.PutFloat((float)skill.Data.SplashAngle);
			packet.PutShort(ObjectProperty.Skill.SklSpdRate);
			packet.PutFloat(1.0f);
			packet.PutShort(ObjectProperty.Skill.SpendSta);
			packet.PutFloat(0.0f);
			packet.PutShort(ObjectProperty.Skill.Skill_Delay);
			packet.PutFloat(0.0f);
			packet.PutShort(ObjectProperty.Skill.SkillSR);
			packet.PutFloat(3.0f);
			packet.PutShort(ObjectProperty.Skill.ReadyTime);
			packet.PutFloat(0.0f);
			packet.PutShort(ObjectProperty.Skill.EnableShootMove);
			packet.PutFloat(skill.Data.EnableShootMove ? 1f : 0f);
			packet.PutShort(ObjectProperty.Skill.AbleShootRotate);
			packet.PutFloat(skill.Data.EnableShootRotate ? 1f : 0f);
			packet.PutShort(ObjectProperty.Skill.SpendPoison);
			packet.PutFloat(0.0f);
			packet.PutShort(ObjectProperty.Skill.SpendSP);
			packet.PutFloat((float)skill.Data.SpendSP);  // packet.PutFloat(skill.Data.SpendSP);
			packet.PutShort(ObjectProperty.Skill.SkillFactor);
			packet.PutFloat((float)skill.Data.SkillFactor);
			packet.PutShort(ObjectProperty.Skill.SR);
			packet.PutFloat(0.0f);
			packet.PutShort(ObjectProperty.Skill.WaveLength);
			packet.PutFloat(0.0f);
			packet.PutShort(ObjectProperty.Skill.BackHitRange);
			packet.PutFloat(0.0f);
			packet.PutShort(ObjectProperty.Skill.SkillAtkAdd);
			packet.PutFloat((float)skill.Data.AttackAdd);
			packet.PutShort(ObjectProperty.Skill.SkillASPD);
			packet.PutFloat(1.0f);
			packet.PutShort(ObjectProperty.Skill.UseOverHeat);
			packet.PutFloat(0.0f);
			
			
			
			
			
			
			
			
			
			
			
			

		}

	}
}
