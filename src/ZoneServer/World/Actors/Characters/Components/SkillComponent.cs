using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// Character skills.
	/// </summary>
	public class SkillComponent : CharacterComponent, IUpdateable
	{
		private readonly Dictionary<SkillId, Skill> _skills = new();

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		public SkillComponent(Character character) : base(character)
		{
		}

		/// <summary>
		/// Returns the amount of skills in the collection.
		/// </summary>
		public int Count { get { lock (_skills) return _skills.Count; } }

		/// <summary>
		/// Adds given without updating the client. Replaces existing
		/// skills.
		/// </summary>
		/// <param name="skill"></param>
		public void AddSilent(Skill skill)
		{
			lock (_skills)
				_skills[skill.Id] = skill;
		}

		/// <summary>
		/// Adds given skill and updates the client. Replaces existing
		/// skills.
		/// </summary>
		/// <param name="skill"></param>
		public void Add(Skill skill)
		{
			this.AddSilent(skill);
			Send.ZC_SKILL_ADD(this.Character, skill);
		}

		/// <summary>
		/// Removes skill with given id, returns false if it
		/// didn't exist. Doesn't update the client.
		/// </summary>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public bool RemoveSilent(SkillId skillId)
		{
			lock (_skills)
				return _skills.Remove(skillId);
		}

		/// <summary>
		/// Removes skill with given id, returns false if it
		/// didn't exist. Updates the client on success.
		/// </summary>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public bool Remove(SkillId skillId)
		{
			if (!this.RemoveSilent(skillId))
				return false;

			Send.ZC_SKILL_REMOVE(this.Character, skillId);

			return true;
		}

		/// <summary>
		/// Returns skill with given id, or null if it didn't
		/// exist.
		/// </summary>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public Skill Get(SkillId skillId)
		{
			lock (_skills)
			{
				_skills.TryGetValue(skillId, out var result);
				return result;
			}
		}

		/// <summary>
		/// Returns skill with given id via out, returns false if the
		/// skill wasn't found.
		/// </summary>
		/// <param name="skillId"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		public bool TryGet(SkillId skillId, out Skill skill)
		{
			skill = this.Get(skillId);
			return skill != null;
		}

		/// <summary>
		/// Returns skill with given class name, or null if it didn't
		/// exist.
		/// </summary>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public Skill Get(string skillClassName)
		{
			lock (_skills)
				return _skills.Values.FirstOrDefault(a => a.Data.ClassName == skillClassName);
		}

		/// <summary>
		/// Returns a list with all skills.
		/// </summary>
		/// <returns></returns>
		public Skill[] GetList()
		{
			lock (_skills)
				return _skills.Values.ToArray();
		}

		/// <summary>
		/// Returna a list of all skills that match the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public Skill[] GetList(Func<Skill, bool> predicate)
		{
			lock (_skills)
				return _skills.Values.Where(predicate).ToArray();
		}

		/// <summary>
		/// Returns true if the skill exists.
		/// </summary>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public bool Has(SkillId skillId)
		{
			lock (_skills)
				return _skills.ContainsKey(skillId);
		}

		/// <summary>
		/// Returns current level of given skill, returns 0 if skill
		/// doesn't exist.
		/// </summary>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public int GetLevel(SkillId skillId)
		{
			var skill = this.Get(skillId);
			if (skill == null)
				return 0;

			return skill.Level;
		}

		/// <summary>
		/// Returns the max level the character can currently reach on the
		/// given skill.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public int GetMaxLevel(SkillId skillId)
		{
			// I don't like this, but I don't have a better idea for
			// handling it right now. A skill's max level could technically
			// be different for each job if a skill can be obtained on
			// more than one, so we have to go through all jobs to find the
			// "max max".

			var maxLevel = 0;

			foreach (var job in this.Character.Jobs.GetList())
			{
				var skillTreeDataList = ZoneServer.Instance.Data.SkillTreeDb.FindSkills(job.Id, job.Level).Where(a => a.SkillId == skillId);
				foreach (var data in skillTreeDataList)
				{
					var jobsMaxLevel = data.MaxLevel;
					if (jobsMaxLevel > maxLevel)
						maxLevel = jobsMaxLevel;
				}
			}

			return maxLevel;
		}

		/// <summary>
		/// Updates the skills and their overheats.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			lock (_skills)
			{
				foreach (var skill in _skills.Values)
					skill.Update(elapsed);
			}
		}
	}
}
