// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Channel.Network;
using Melia.Shared.Const;

namespace Melia.Channel.World
{
	/// <summary>
	/// Character skills.
	/// </summary>
	public class Skills
	{
		private Dictionary<int, Skill> _skills = new Dictionary<int, Skill>();

		/// <summary>
		/// The owner of this object.
		/// </summary>
		public Character Character { get; }

		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		public Skills(Character character)
		{
			this.Character = character ?? throw new ArgumentNullException(nameof(character));
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
		public bool RemoveSilent(int skillId)
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
		public bool Remove(int skillId)
		{
			if (!this.RemoveSilent(skillId))
				return false;

			// Update client...

			return true;
		}

		/// <summary>
		/// Returns skill with given id, or null if it didn't
		/// exist.
		/// </summary>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public Skill Get(int skillId)
		{
			lock (_skills)
			{
				_skills.TryGetValue(skillId, out var result);
				return result;
			}
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
		/// Returns true if the skill exists.
		/// </summary>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public bool Has(int skillId)
		{
			lock (_skills)
				return _skills.ContainsKey(skillId);
		}
	}
}
