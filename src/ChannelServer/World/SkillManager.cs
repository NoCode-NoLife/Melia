using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Const;
using Melia.Shared.Data.Database;
using Melia.Shared.World;
using Melia.Shared.Util;
using Melia.Channel.Network;

namespace Melia.Channel.World
{
	public class SkillManager
	{
		public Actor owner;

		public Dictionary<Job, int> skillPoints;

		public Dictionary<int, Skill> skills;

		public SkillManager(Actor ownerActor)
		{
			this.owner = ownerActor;
			skillPoints = new Dictionary<Job, int>();
			skills = new Dictionary<int, Skill>();
		}

		public Skill GetSkill(int SkillId)
		{
			Skill skill;
			this.skills.TryGetValue(SkillId, out skill);
			return skill;
		}

		public bool LearnSkill(SkillTreeInfo skillTreeInfo, int levels) 
		{
			if (!(owner is Character))
				return false;

			var thisCharacter = (Character)owner;
			// Get max level for this skill for current Job Grade
			var maxAllowedLevel = Math2.Clamp(skillTreeInfo.LevelPerGrade, skillTreeInfo.MaxLevel, skillTreeInfo.LevelPerGrade * thisCharacter.jobs[(Job)skillTreeInfo.JobId]);

			var newLevel = levels;

			Skill skill;
			this.skills.TryGetValue(skillTreeInfo.SkillId, out skill);

			if (skill != null) 
				newLevel += skill.level;

			if (newLevel > maxAllowedLevel)
				return false;

			// Check if character has enough Skill Points to learn given amount of levels for this skill
			var skillData = ChannelServer.Instance.Data.SkillDb.Find(skillTreeInfo.SkillId);
			if (skillData == null)
				return false;

			if (this.skillPoints[(Job)skillTreeInfo.JobId] < levels)
				return false;


			List<short> skillProps = new List<short>();

			// Send ADDON MSG
			Send.ZC_ADDON_MSG((Character)owner, "RESET_SKL_UP", null);

			// If character doesn't have this skill, add it.
			if (skill == null)
			{
				this.SkillAdd(skillTreeInfo.SkillId, newLevel, out skill);
				skillProps.Add(ObjectProperty.Skill.CoolDown);
				skillProps.Add(ObjectProperty.Skill.SpendItemCount);
				skillProps.Add(ObjectProperty.Skill.SplAngle);
				skillProps.Add(ObjectProperty.Skill.SR);
				skillProps.Add(ObjectProperty.Skill.SplRange);
				skillProps.Add(ObjectProperty.Skill.MaxR);
				skillProps.Add(ObjectProperty.Skill.WaveLength);
				skillProps.Add(ObjectProperty.Skill.BackHitRange);
				skillProps.Add(ObjectProperty.Skill.UseOverHeat);
				skillProps.Add(ObjectProperty.Skill.SkillASPD);
				skillProps.Add(ObjectProperty.Skill.SkillSR);
				skillProps.Add(ObjectProperty.Skill.SklSpdRate);
				skillProps.Add(ObjectProperty.Skill.SpendPoison);
				skillProps.Add(ObjectProperty.Skill.SpendSta);
				skillProps.Add(ObjectProperty.Skill.Skill_Delay);
				skillProps.Add(ObjectProperty.Skill.ReadyTime);
				skillProps.Add(ObjectProperty.Skill.EnableShootMove);
				skillProps.Add(ObjectProperty.Skill.AbleShootRotate);
				skillProps.Add(ObjectProperty.Skill.SkillFactor);
			}

			// Set this skill new level.
			skill.SetLevel(newLevel);
			skillProps.Add(ObjectProperty.Skill.Level);
			skillProps.Add(ObjectProperty.Skill.LevelByDB);
			skillProps.Add(ObjectProperty.Skill.SpendSP);
			skillProps.Add(ObjectProperty.Skill.SkillAtkAdd);

			// Send skill new properties
			Send.ZC_OBJECT_PROPERTY(((Character)owner).Connection, skill, skillProps.ToArray());

			// Set new amount of points for this job
			SetSkillPoints((Job)skillTreeInfo.JobId, this.skillPoints[(Job)skillTreeInfo.JobId] - levels);


			return true;
		}

		public int GetSkillPoints(Job jobId)
		{
			int jobSkillPoints;
			if (!skillPoints.TryGetValue(jobId, out jobSkillPoints))
				return -1;
			return jobSkillPoints;
		}

		public void SetSkillPoints(Job jobId, int newPoints)
		{
			if (!skillPoints.ContainsKey(jobId))
				return;

			skillPoints[jobId] = newPoints;

			if (this.owner is Character) {
				this.SendJobSkillPoints(jobId);
			}
		}

		public void SendJobSkillPoints(Job jobId)
		{
			int jobSkillPoints;
			skillPoints.TryGetValue(jobId, out jobSkillPoints);
			Send.ZC_JOB_PTS((Character)owner, jobId, jobSkillPoints);
		}

		public bool SkillAddSilent(int skillId, int level, out Skill skill)
		{
			skill = new Skill(skillId, level);
			skill.owner = (IEntity) owner;
			this.skills.Add(skillId, skill);
			return true;
		}

		public bool SkillAdd(int skillId, int level, out Skill skill)
		{
			this.SkillAddSilent(skillId, level, out skill);
			Send.ZC_SKILL_ADD((Character)owner, skill, skill.Data.RegisterAsShortcut, skill.Data.IsFromSkillList, 0);
			//Send.ZC_SKILL_ADD((Character)owner, skill, true, skill.GetData().IsFromSkillList, 0); // TESTING PURPOSES 
			return true;
		}

		public void SendAllSkills()
		{
			if (owner is Character)
				foreach (var thisSkill in this.skills.Values)
					Send.ZC_SKILL_ADD((Character) owner, thisSkill, thisSkill.GetData().RegisterAsShortcut, thisSkill.GetData().IsFromSkillList, 0);
		}

		public List<Skill> GetAllSkillsFromSkillList()
		{
			var skillList = this.skills.Values.Where(a => a.GetData().IsFromSkillList.Equals(true)).ToList();
			return skillList;
		}

	}
}
