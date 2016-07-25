// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Const
{
	public enum TeamNameChangeResult : int
	{
		TeamNameAlreadyExist = -1,
		Okay = 0,
		TeamChangeFailed = 1,
	}

	public enum Stat
	{
		STR,
		CON,
		INT,
		SPR,
		DEX,
		RecoveryHP,
		RecoverySP,
		MINPATK,
		MAXPATK,
		MINPATK_SUB,
		MAXPATK_SUB,
		MINMATK,
		MAXMATK,
		SpellRatio, // SR
		SpellDefenseRatio,
		CritAtk,
		critRate,
		critResistance,
		Evasion,
		DR_BM, // Evasion BM?
		Accuracy,
		MagicAmplification,
		PDEF,
		MDEF,
		Block,
		BlockPenetration,
		STA,
		WeightLimit,
		MovSpeed,
		Provocation,
		BuffLimit,
		Stat_MAX
	}

	public enum StatModifierType
	{
		Addition,
		Multiplier,
	}

	public struct StatModifier
	{
		public Stat stat;
		public StatModifierType modifierType;
		public float modifierValue;
	}

	[Flags]
	public enum TargetType
	{
		NONE = 0,
		SELF = 1,
		FRIEND = 2,
		ENEMY = 4,
		MONSTER = 8,
		PARTY = 16,

	}
}
