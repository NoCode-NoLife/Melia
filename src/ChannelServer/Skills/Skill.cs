// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Channel.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.Skills
{
	public class Skill
	{
		private Character _creature;

		/// <summary>
		/// Information about the skill, serialized to packets.
		/// </summary>
		public SkillInfo Info;

		/// <summary>
		/// Data about the skill, loaded from the db.
		/// </summary>
		public SkillData Data { get; protected set; }

		/// <summary>
		/// The skills current state.
		/// </summary>
		public SkillState State { get; set; }

		/// <summary>
		/// Holds time at which the skill is fully loaded.
		/// </summary>
		public DateTime CastEnd { get; set; }

		/// <summary>
		/// New Skill.
		/// </summary>
		/// <param name="creature"></param>
		/// <param name="id"></param>
		/// <param name="rank"></param>
		/// <param name="race"></param>
		public Skill(Character creature, SkillId id, int level)
		{
			_creature = creature;

		}

		/// <summary>
		/// Returns cast time of skill, specific for its creature.
		/// </summary>
		/// <returns></returns>
		public int GetCastTime()
		{
			return 1;
		}
	}

	/// <summary>
	/// Current state of a skill.
	/// </summary>
	public enum SkillState
	{
		None,
		Prepared,
		Ready,
		Used,
		Completed,
		Canceled,
	}

	/// <summary>
	/// Skill ids
	/// </summary>
	public enum SkillId : ushort
	{
		None = 0,

		// Life
		Heal = 40001,
	}

	/// <summary>
	/// Information about a skill
	/// </summary>
	public struct SkillInfo
	{
		public SkillId Id;
		public int Level;
	}

	/// <summary>
	/// DBData about a skill
	/// </summary>
	public struct SkillData
	{
		public SkillId Id;
		public string Name;
	}
}