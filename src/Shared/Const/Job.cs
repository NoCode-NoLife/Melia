// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Const
{
	public enum Job : short
	{
		Swordsman = 1001,
		Highlander = 1002,
		Peltasta = 1003,
		Hoplite = 1004,
		Centurion = 1005,
		Barbarian = 1006,
		Cataphract = 1007,
		Corsair = 1008,
		Doppelsoeldner = 1009,
		Rodelero = 1010,
		Squire = 1011,
		Murmillo = 1012,
		Shinobi = 1013,
		Fencer = 1014,
		Dragoon = 1015,
		Templar = 1016,

		Wizard = 2001,
		FireMage = 2002,
		FrostMage = 2003,
		Psychokino = 2004,
		Alchemist = 2005,
		Sorcerer = 2006,
		Linker = 2007,
		Chronomancer = 2008,
		Necromancer = 2009,
		Thaumaturge = 2010,
		Warlock1 = 2011,
		Mimic = 2012,
		Daoshi = 2013,
		Sage = 2014,
		Warlock2 = 2015,
		Featherfoot = 2016,

		Archer = 3001,
		Hunter = 3002,
		QuarrelShooter = 3003,
		Ranger = 3004,
		Sapper = 3005,
		Wugushi = 3006,
		Hackapell = 3007,
		Scout = 3008,
		Rogue = 3009,
		SchwarzeReiter = 3010,
		Fletcher = 3011,
		PiedPiper = 3012,
		Appraiser = 3013,
		Falconer = 3014,
		Cannoneer = 3015,
		Musketeer = 3016,

		Cleric = 4001,
		Priest = 4002,
		Krivi = 4003,
		Bokor = 4004,
		Druid = 4005,
		Sadhu = 4006,
		Dievdirbys = 4007,
		Oracle = 4008,
		Monk = 4009,
		Pardoner = 4010,
		Paladin = 4011,
		Chaplain = 4012,
		Shepherd = 4013,
		PlagueDoctor = 4014,
		Kabbalist = 4015,

		GM = 9001,
	}

	public enum Class
	{
		Swordsman = 1,
		Wizard = 2,
		Archer = 3,
		Cleric = 4,
		GM = 9,
	}

	public static class JobExtension
	{
		public static Class ToClass(this Job job)
		{
			var result = (Class)((int)job / 1000);

			if (result < Class.Swordsman || (result > Class.Cleric && result != Class.GM))
				throw new Exception("Unknown job class.");

			return result;
		}
	}
}
