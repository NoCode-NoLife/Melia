//--- Melia Script ----------------------------------------------------------
// Character Advancement
//--- Description -----------------------------------------------------------
// Grants default items, skills, and abilities to characters after job
// advancements.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Shared.Game.Const;
using Melia.Zone;
using Melia.Zone.Events;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

public class CharacterAdvancementScript : GeneralScript
{
	[On("PlayerAdvancedJob")]
	public void PlayerAdvancedJob(object sender, PlayerEventArgs args)
	{
		var character = args.Character;
		var newJobId = args.Character.JobId;

		// Grant defaults if the player chose the class for the first time
		if (character.Job.Circle == JobCircle.First)
			GrantDefaults(character, newJobId);
	}

	private static void GrantDefaults(Character character, JobId jobId)
	{
		switch (character.JobId)
		{
			// Swordsman
			//---------------------------------------------------------------
			case JobId.Swordsman:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.Pistol_Attack);

				LearnAbility(character, AbilityId.Sword);
				LearnAbility(character, AbilityId.Staff);
				LearnAbility(character, AbilityId.Mace);
				break;
			}
			case JobId.Highlander:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.THSword);

				GiveItem(character, ItemId.Costume_Char1_2, 1);
				break;
			}
			case JobId.Peltasta:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.Peltasta6);

				GiveItem(character, ItemId.Costume_Char1_3, 1);
				GiveItem(character, ItemId.ChangeJob_SHD100_101, 1);
				break;
			}
			case JobId.Hoplite:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.Spear);

				GiveItem(character, ItemId.Costume_Char1_4, 1);
				GiveItem(character, ItemId.ChangeJob_SPR01_119, 1);
				break;
			}
			case JobId.Centurion:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.Centurion_SummonCart);

				LearnAbility(character, AbilityId.THSpear);

				GiveItem(character, ItemId.Costume_Char1_5, 1);
				break;
			}
			case JobId.Barbarian:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.THSword);

				GiveItem(character, ItemId.Costume_Char1_6, 1);
				break;
			}
			case JobId.Cataphract:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.Spear);
				LearnAbility(character, AbilityId.THSpear);
				LearnAbility(character, AbilityId.CompanionRide);

				GiveItem(character, ItemId.Costume_Char1_7, 1);
				GiveItem(character, ItemId.ChangeJob_TSP01_111, 1);
				break;
			}
			case JobId.Doppelsoeldner:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.THSword);

				GiveItem(character, ItemId.Costume_Char1_9, 1);
				GiveItem(character, ItemId.ChangeJob_TSW01_129, 1);
				break;
			}
			case JobId.Rodelero:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.Peltasta6);

				GiveItem(character, ItemId.Costume_Char1_10, 1);
				GiveItem(character, ItemId.ChangeJob_SHD100_101, 1);
				break;
			}
			case JobId.Murmillo:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.Peltasta6);

				GiveItem(character, ItemId.Costume_Char1_12, 1);
				GiveItem(character, ItemId.ChangeJob_SHD100_101, 1);
				break;
			}
			case JobId.Fencer:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.Rapier);

				GiveItem(character, ItemId.Costume_Char1_14, 1);
				GiveItem(character, ItemId.ChangeJob_RAP01_103, 1);
				break;
			}
			case JobId.Dragoon:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.Spear);
				LearnAbility(character, AbilityId.THSpear);

				GiveItem(character, ItemId.Costume_Char1_15, 1);
				GiveItem(character, ItemId.ChangeJob_TSP01_111, 1);
				break;
			}
			case JobId.Templar:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.CompanionRide);

				GiveItem(character, ItemId.Costume_Char1_16, 1);
				break;
			}
			case JobId.Lancer:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.Spear);
				LearnAbility(character, AbilityId.THSpear);
				LearnAbility(character, AbilityId.CompanionRide);

				GiveItem(character, ItemId.Costume_Char1_17, 1);
				GiveItem(character, ItemId.ChangeJob_TSP01_111, 1);
				break;
			}
			case JobId.Matador:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.Muleta_Attack);

				LearnAbility(character, AbilityId.Rapier);

				GiveItem(character, ItemId.Costume_Char1_19, 1);
				GiveItem(character, ItemId.ChangeJob_RAP01_103, 1);
				break;
			}
			case JobId.NakMuay:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				GiveItem(character, ItemId.Costume_Char1_20, 1);
				break;
			}
			case JobId.Retiarius:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.Spear);

				GiveItem(character, ItemId.Costume_Char1_18_1, 1);
				GiveItem(character, ItemId.ChangeJob_SPR01_119, 1);
				break;
			}
			case JobId.Hackapell:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.CompanionRide);

				GiveItem(character, ItemId.Costume_Char3_7, 1);
				break;
			}
			case JobId.BlossomBlader:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.THSword);

				GiveItem(character, ItemId.Costume_Char1_22_1, 1);
				break;
			}
			case JobId.Luchador:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				GiveItem(character, ItemId.Costume_Char1_23_1, 1);
				break;
			}
			case JobId.Shenji:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.SpearMaster_Attack);
				LearnSkill(character, SkillId.SpearMaster_Attack_TH);
				LearnSkill(character, SkillId.SpearMaster_StanceChange);

				LearnAbility(character, AbilityId.Spear);
				LearnAbility(character, AbilityId.THSpear);

				GiveItem(character, ItemId.Costume_Char1_24, 1);
				GiveItem(character, ItemId.ChangeJob_TSP01_111, 1);
				break;
			}
			case JobId.WingedHussar:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.Spear);
				LearnAbility(character, AbilityId.THSpear);
				LearnAbility(character, AbilityId.CompanionRide);
				LearnAbility(character, AbilityId.WingedHussars0);

				GiveItem(character, ItemId.Costume_Char1_25, 1);
				GiveItem(character, ItemId.ChangeJob_TSP01_111, 1);
				break;
			}
			case JobId.Vanquisher:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.THSword);
				LearnAbility(character, AbilityId.Vanquisher0);

				GiveItem(character, ItemId.Costume_Char1_26, 1);
				GiveItem(character, ItemId.ChangeJob_TSW01_129, 1);
				break;
			}
			// Wizard
			//---------------------------------------------------------------
			case JobId.Wizard:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);
				LearnSkill(character, SkillId.Common_DaggerAries);
				LearnSkill(character, SkillId.Common_StaffAttack);

				LearnAbility(character, AbilityId.Sword);
				LearnAbility(character, AbilityId.Staff);
				LearnAbility(character, AbilityId.Mace);
				LearnAbility(character, AbilityId.THStaff);
				break;
			}
			case JobId.Pyromancer:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_2, 1);
				break;
			}
			case JobId.Cryomancer:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_3, 1);
				break;
			}
			case JobId.Psychokino:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_4, 1);
				break;
			}
			case JobId.Alchemist:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_5, 1);
				break;
			}
			case JobId.Sorcerer:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);
				LearnSkill(character, SkillId.Common_ForcedAttack);
				LearnSkill(character, SkillId.Common_ForcedAttackCancel);
				LearnSkill(character, SkillId.Common_SummonRemove);

				GiveItem(character, ItemId.Costume_Char2_6, 1);
				break;
			}
			case JobId.Chronomancer:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_8, 1);
				break;
			}
			case JobId.Necromancer:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);
				LearnSkill(character, SkillId.Common_ForcedAttack);
				LearnSkill(character, SkillId.Common_ForcedAttackCancel);
				LearnSkill(character, SkillId.Common_SummonRemove);

				GiveItem(character, ItemId.Costume_Char2_9, 1);
				break;
			}
			case JobId.Elementalist:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_11, 1);
				break;
			}
			case JobId.Mimic:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_12, 1);
				break;
			}
			case JobId.Sage:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_14, 1);
				break;
			}
			case JobId.Warlock:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_15, 1);
				break;
			}
			case JobId.Featherfoot:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);
				LearnSkill(character, SkillId.Featherfoot_Curseofblood);
				LearnSkill(character, SkillId.Featherfoot_Bloodtransfusion);

				GiveItem(character, ItemId.Costume_Char2_16, 1);
				break;
			}
			case JobId.RuneCaster:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_17, 1);
				break;
			}
			case JobId.Shadowmancer:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_19, 1);
				break;
			}
			case JobId.Onmyoji:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_20_01, 1);
				break;
			}
			case JobId.Taoist:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_17, 1);
				break;
			}
			case JobId.Bokor:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);
				LearnSkill(character, SkillId.Common_ForcedAttack);
				LearnSkill(character, SkillId.Common_ForcedAttackCancel);
				LearnSkill(character, SkillId.Common_SummonRemove);

				GiveItem(character, ItemId.Costume_Char4_4, 1);
				break;
			}
			case JobId.Terramancer:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);

				GiveItem(character, ItemId.Costume_Char2_23_01, 1);
				break;
			}
			case JobId.Keraunos:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);
				LearnSkill(character, SkillId.Keraunos_ElectricCurrent);

				GiveItem(character, ItemId.Costume_Char2_24, 1);
				break;
			}
			case JobId.Illusionist:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);
				LearnSkill(character, SkillId.Illusionist_Decoy);

				LearnAbility(character, AbilityId.Illusionist33);

				GiveItem(character, ItemId.Costume_Char2_25_1, 1);
				break;
			}
			case JobId.VultureW:
			{
				LearnSkill(character, SkillId.Magic_Attack);
				LearnSkill(character, SkillId.Magic_Attack_TH);
				LearnSkill(character, SkillId.Vulture_Attack_Wizard);

				GiveItem(character, ItemId.Costume_Char2_26, 1);
				break;
			}
			// Archer
			//---------------------------------------------------------------
			case JobId.Archer:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Cannon_Normal_Attack);

				LearnAbility(character, AbilityId.THBow);
				LearnAbility(character, AbilityId.Bow);
				break;
			}
			case JobId.Hunter:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Hunter_PetComeBack);

				GiveItem(character, ItemId.Costume_Char3_2, 1);
				break;
			}
			case JobId.QuarrelShooter:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);

				GiveItem(character, ItemId.Costume_Char3_3, 1);
				GiveItem(character, ItemId.ChangeJob_BOW01_130, 1);
				break;
			}
			case JobId.Ranger:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);

				GiveItem(character, ItemId.Costume_Char3_4, 1);
				break;
			}
			case JobId.Sapper:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Sapper_DetonateTraps);

				GiveItem(character, ItemId.Costume_Char3_5, 1);
				break;
			}
			case JobId.Wugushi:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);

				GiveItem(character, ItemId.Costume_Char3_6, 1);
				break;
			}
			case JobId.Fletcher:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);

				GiveItem(character, ItemId.Costume_Char3_11, 1);
				break;
			}
			case JobId.PiedPiper:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);

				GiveItem(character, ItemId.Costume_Char3_12_01, 1);
				break;
			}
			case JobId.Appraiser:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);

				GiveItem(character, ItemId.Costume_Char3_13, 1);
				break;
			}
			case JobId.Falconer:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);

				GiveItem(character, ItemId.Costume_Char3_14, 1);
				break;
			}
			case JobId.Cannoneer:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Cannon_Normal_Attack);

				GiveItem(character, ItemId.Costume_Char3_15, 1);
				GiveItem(character, ItemId.ChangeJob_CAN100_101, 1);
				break;
			}
			case JobId.Musketeer:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Common_MusketAttack);

				GiveItem(character, ItemId.Costume_Char3_16, 1);
				GiveItem(character, ItemId.ChangeJob_MUS100_101, 1);
				break;
			}
			case JobId.Mergen:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Sword_Attack);

				GiveItem(character, ItemId.Costume_Char3_17, 1);
				break;
			}
			case JobId.Matross:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Cannon_Normal_Attack);

				GiveItem(character, ItemId.Costume_Char3_18_MAT_01, 1);
				GiveItem(character, ItemId.ChangeJob_CAN100_101, 1);
				break;
			}
			case JobId.TigerHunter:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Common_MusketAttack);

				GiveItem(character, ItemId.Costume_Char3_19_01, 1);
				GiveItem(character, ItemId.ChangeJob_MUS100_101, 1);
				break;
			}
			case JobId.Arbalester:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);

				GiveItem(character, ItemId.Costume_Char3_20_01, 1);
				GiveItem(character, ItemId.ChangeJob_BOW01_130, 1);
				break;
			}
			case JobId.Arquebusier:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Cannon_Normal_Attack);
				LearnSkill(character, SkillId.Common_MusketAttack);
				LearnSkill(character, SkillId.Arquebusier_ArquebusierWeapon);

				GiveItem(character, ItemId.Costume_Char3_21_01, 1);
				GiveItem(character, ItemId.ChangeJob_MUS100_101, 1);
				GiveItem(character, ItemId.ChangeJob_CAN100_101, 1);
				break;
			}
			case JobId.Hwarang:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Sword_Attack);

				GiveItem(character, ItemId.Costume_Char3_22_01, 1);
				break;
			}
			case JobId.Engineer:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Cannon_Normal_Attack);
				LearnSkill(character, SkillId.Common_MusketAttack);

				GiveItem(character, ItemId.Costume_Char3_23_01, 1);
				break;
			}
			case JobId.Godeye:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Sword_Attack);

				LearnAbility(character, AbilityId.BowMaster0);

				GiveItem(character, ItemId.Costume_Char3_24, 1);
				break;
			}
			case JobId.VultureA:
			{
				LearnSkill(character, SkillId.Bow_Attack);
				LearnSkill(character, SkillId.CrossBow_Attack);
				LearnSkill(character, SkillId.Musket_Attack);
				LearnSkill(character, SkillId.Sword_Attack);
				LearnSkill(character, SkillId.Vulture_Attack_Archer);

				GiveItem(character, ItemId.Costume_Char3_25, 1);
				break;
			}
			// Cleric
			//---------------------------------------------------------------
			case JobId.Cleric:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);
				LearnSkill(character, SkillId.Common_DaggerAries);

				LearnAbility(character, AbilityId.Sword);
				LearnAbility(character, AbilityId.Staff);
				LearnAbility(character, AbilityId.Mace);
				LearnAbility(character, AbilityId.THMace);
				LearnAbility(character, AbilityId.Cleric36);
				break;
			}
			case JobId.Priest:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_2, 1);
				break;
			}
			case JobId.Krivis:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_3, 1);
				break;
			}
			case JobId.Druid:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);
				LearnSkill(character, SkillId.Lycan_Half_Attack);

				GiveItem(character, ItemId.Costume_Char4_5, 1);
				break;
			}
			case JobId.Sadhu:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_6, 1);
				break;
			}
			case JobId.Dievdirbys:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_7, 1);
				break;
			}
			case JobId.Oracle:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_8, 1);
				break;
			}
			case JobId.Monk:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);
				LearnSkill(character, SkillId.Monk_1InchPunch_DOT);

				LearnAbility(character, AbilityId.THMace);

				GiveItem(character, ItemId.Costume_Char4_9, 1);
				break;
			}
			case JobId.Pardoner:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_10, 1);
				break;
			}
			case JobId.Paladin:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);

				LearnAbility(character, AbilityId.THMace);
				LearnAbility(character, AbilityId.Peltasta6);

				GiveItem(character, ItemId.Costume_Char4_11, 1);
				break;
			}
			case JobId.Chaplain:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);
				LearnSkill(character, SkillId.Binatio_Attack);

				GiveItem(character, ItemId.Costume_Char4_12, 1);
				break;
			}
			case JobId.Shepherd:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_13, 1);
				break;
			}
			case JobId.PlagueDoctor:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_14, 1);
				break;
			}
			case JobId.Kabbalist:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_15, 1);
				break;
			}
			case JobId.Inquisitor:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_16, 1);
				break;
			}
			case JobId.Miko:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_18, 1);
				break;
			}
			case JobId.Zealot:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_20, 1);
				break;
			}
			case JobId.Exorcist:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Exorcist01, 1);
				break;
			}
			case JobId.Crusader:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				LearnAbility(character, AbilityId.THMace);

				GiveItem(character, ItemId.Costume_Char4_21_01, 1);
				break;
			}
			case JobId.Lama:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);
				LearnSkill(character, SkillId.Lama_Avoid);
				LearnSkill(character, SkillId.Lama_Relax);
				LearnSkill(character, SkillId.Lama_Lamadash);
				LearnSkill(character, SkillId.Lama_Fist);
				LearnSkill(character, SkillId.Lama_Kick);

				LearnAbility(character, AbilityId.THMace);

				GiveItem(character, ItemId.Costume_Char4_22, 1);
				break;
			}
			case JobId.Pontifex:
			{
				LearnSkill(character, SkillId.Hammer_Attack);
				LearnSkill(character, SkillId.Hammer_Attack_TH);

				GiveItem(character, ItemId.Costume_Char4_230, 1);
				break;
			}
			// Scout
			//---------------------------------------------------------------
			case JobId.Scout:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				LearnAbility(character, AbilityId.Sword);
				break;
			}
			case JobId.Assassin:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Sct_009, 1);
				GiveItem(character, ItemId.ChangeJob_DAG100_101, 1);
				break;
			}
			case JobId.Outlaw:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Sct_001, 1);
				break;
			}
			case JobId.Squire:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char1_11, 1);
				break;
			}
			case JobId.Corsair:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char1_8, 1);
				break;
			}
			case JobId.Shinobi:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char1_13, 1);
				break;
			}
			case JobId.Thaumaturge:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char2_10, 1);
				break;
			}
			case JobId.Enchanter:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char2_18, 1);
				break;
			}
			case JobId.Linker:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char2_7, 1);
				break;
			}
			case JobId.Rogue:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char3_9, 1);
				GiveItem(character, ItemId.ChangeJob_DAG100_101, 1);
				break;
			}
			case JobId.SchwarzerReiter:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.DoubleBullet_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				LearnAbility(character, AbilityId.CompanionRide);

				GiveItem(character, ItemId.Costume_Char3_10, 1);
				GiveItem(character, ItemId.ChangeJob_PST100_101, 1);
				break;
			}
			case JobId.BulletMarker:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.DoubleGun_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char3_18, 1);
				GiveItem(character, ItemId.ChangeJob_PST100_101, 1);
				break;
			}
			case JobId.Ardito:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char5_13_01, 1);
				break;
			}
			case JobId.Sheriff:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				LearnAbility(character, AbilityId.CompanionRide);

				GiveItem(character, ItemId.Costume_Char5_14_01, 1);
				GiveItem(character, ItemId.ChangeJob_PST100_101, 1);
				break;
			}
			case JobId.Rangda:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char5_15_01, 1);
				break;
			}
			case JobId.Clown:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char5_16_01, 1);
				break;
			}
			case JobId.Hakkapeliter:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				LearnAbility(character, AbilityId.CompanionRide);

				GiveItem(character, ItemId.Costume_Char5_17, 1);
				break;
			}
			case JobId.Jaguar:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char5_18, 1);
				break;
			}
			case JobId.Desperado:
			{
				LearnSkill(character, SkillId.Normal_Attack);
				LearnSkill(character, SkillId.Normal_Attack_TH);
				LearnSkill(character, SkillId.Warrior_Guard);
				LearnSkill(character, SkillId.War_JustFrameAttack);
				LearnSkill(character, SkillId.War_JustFrameDagger);
				LearnSkill(character, SkillId.War_JustFramePistol);
				LearnSkill(character, SkillId.Pistol_Attack);
				LearnSkill(character, SkillId.Common_DaggerAries);

				GiveItem(character, ItemId.Costume_Char5_19, 1);
				break;
			}
		}
	}

	private static void GiveItem(Character character, int itemId, int amount)
	{
		if (character.Inventory.HasItem(itemId))
			return;

		character.Inventory.Add(itemId, amount);
	}

	private static void LearnSkill(Character character, SkillId skillId)
	{
		if (character.Skills.Has(skillId))
			return;

		var skill = new Skill(character, skillId, 1);
		character.Skills.Add(skill);
	}

	private static void LearnAbility(Character character, AbilityId abilityId)
	{
		if (character.Abilities.Has(abilityId))
			return;

		var ability = new Ability(abilityId, 1);
		character.Abilities.Add(ability);
	}
}
