﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using Melia.Shared.Data.Database;

namespace Melia.Shared.Data
{
	/// <summary>
	/// Wrapper for all file databases.
	/// </summary>
	public class MeliaData
	{
		public BarrackDb BarrackDb = new BarrackDb();
		public ItemDb ItemDb = new ItemDb();
		public JobDb JobDb = new JobDb();
		public MapDb MapDb = new MapDb();
		public MonsterDb MonsterDb = new MonsterDb();
		public ServerDb ServerDb = new ServerDb();
		public SkillDb SkillDb = new SkillDb();
	}
}
