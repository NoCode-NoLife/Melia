using System;

namespace Melia.Shared.Game.Const
{
	public enum JobId : short
	{
		// Swordsman
		Swordsman = 1001,
		Highlander = 1002,
		Peltasta = 1003,
		Hoplite = 1004,
		Centurion = 1005,
		Barbarian = 1006,
		Cataphract = 1007,
		Doppelsoeldner = 1009,
		Rodelero = 1010,
		Murmillo = 1012,
		Fencer = 1014,
		Dragoon = 1015,
		Templar = 1016,
		Lancer = 1017,
		Matador = 1018,
		NakMuay = 1019,
		Retiarius = 1020,
		Hackapell = 1021,
		BlossomBlader = 1022,
		Luchador = 1023,
		Shenji = 1024,
		WingedHussar = 1025,
		Vanquisher = 1026,
		SledgerS = 1027,
		BonemancerS = 1028,
		GrimmarkS = 1029,

		// Wizard
		Wizard = 2001,
		Pyromancer = 2002,
		Cryomancer = 2003,
		Psychokino = 2004,
		Alchemist = 2005,
		Sorcerer = 2006,
		Chronomancer = 2008,
		Necromancer = 2009,
		Elementalist = 2011,
		Mimic = 2012,
		Sage = 2014,
		Warlock = 2015,
		Featherfoot = 2016,
		RuneCaster = 2017,
		Shadowmancer = 2019,
		Onmyoji = 2020,
		Taoist = 2021,
		Bokor = 2022,
		Terramancer = 2023,
		Keraunos = 2024,
		Illusionist = 2025,
		VultureW = 2026,
		BonemancerW = 2027,
		AetherBladerW = 2028,
		HermitW = 2029,

		// Archer
		Archer = 3001,
		Hunter = 3002,
		QuarrelShooter = 3003,
		Ranger = 3004,
		Sapper = 3005,
		Wugushi = 3006,
		Fletcher = 3011,
		PiedPiper = 3012,
		Appraiser = 3013,
		Falconer = 3014,
		Cannoneer = 3015,
		Musketeer = 3016,
		Mergen = 3017,
		Matross = 3101,
		TigerHunter = 3102,
		Arbalester = 3103,
		Arquebusier = 3104,
		Hwarang = 3105,
		Engineer = 3106,
		Godeye = 3107,
		VultureA = 3108,
		BonemancerA = 3109,
		BlitzHunterA = 3110,
		HermitA = 3111,

		// Cleric
		Cleric = 4001,
		Priest = 4002,
		Krivis = 4003,
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
		Inquisitor = 4016,
		Miko = 4018,
		Zealot = 4019,
		Exorcist = 4020,
		Crusader = 4021,
		Lama = 4022,
		Pontifex = 4023,
		SledgerC = 4024,
		BonemancerC = 4025,
		AetherBladerC = 4026,
		HermitC = 4027,

		// Scout
		Scout = 5001,
		Assassin = 5002,
		Outlaw = 5003,
		Squire = 5004,
		Corsair = 5005,
		Shinobi = 5006,
		Thaumaturge = 5007,
		Enchanter = 5008,
		Linker = 5009,
		Rogue = 5010,
		SchwarzerReiter = 5011,
		BulletMarker = 5012,
		Ardito = 5013,
		Sheriff = 5014,
		Rangda = 5015,
		Clown = 5016,
		Hakkapeliter = 5017,
		Jaguar = 5018,
		Desperado = 5019,
		VultureT = 5020,
		BlitzHunterT = 5021,
		AetherBladerT = 5022,
		GrimmarkT = 5023,

		// GM
		GM = 9001,
	}

	public enum JobClass
	{
		Swordsman = 1,
		Wizard = 2,
		Archer = 3,
		Cleric = 4,
		Scout = 5,
		GM = 9,
	}

	public enum JobCircle : short
	{
		None,
		First,
		Second,
		Third,
	}

	public static class JobExtension
	{
		public static JobClass ToClass(this JobId job)
		{
			var result = (JobClass)((int)job / 1000);

			if (result < JobClass.Swordsman || (result > JobClass.Scout && result != JobClass.GM))
				throw new Exception("Unknown job class.");

			return result;
		}
	}
}
