//--- Melia Script ----------------------------------------------------------
// Character Initialization
//--- Description -----------------------------------------------------------
// Grants default items, skills, and abilities to newly created characters.
//---------------------------------------------------------------------------

using Melia.Shared.Scripting;
using Melia.Shared.Game.Const;
using Melia.Zone;
using Melia.Zone.Events;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

public class CharacterInitializationScript : GeneralScript
{
	[On("PlayerLoggedIn")]
	public void OnPlayerLoggedIn(object sender, PlayerEventArgs args)
	{
		var vars = args.Character.Variables;
		var everLoggedIn = vars.Perm.GetBool("Melia.EverLoggedIn", false);

		if (!everLoggedIn)
		{
			InitCharacter(args.Character);
			vars.Perm.SetBool("Melia.EverLoggedIn", true);
		}

		UpdateCharacter(args.Character);
	}

	private static void InitCharacter(Character character)
	{
		InitCommon(character);

		switch (character.JobId)
		{
			case JobId.Swordsman: InitSwordsman(character); break;
			case JobId.Wizard: InitWizard(character); break;
			case JobId.Archer: InitArcher(character); break;
			case JobId.Cleric: InitCleric(character); break;
			case JobId.Scout: InitScout(character); break;
		}
	}

	private void UpdateCharacter(Character character)
	{
		if (character.JobClass == JobClass.Cleric)
		{
			// Based on the client data, Warrior Guard is not officialy part of
			// a cleric's skillset, but they get it on the latest version of the
			// game and are able to use it. In older logs there was no sign of
			// clerics getting Guard, however, so we'll make it optional.

			if (Feature.IsEnabled("GuardingClerics"))
				LearnSkill(character, SkillId.Warrior_Guard);
			else
				UnlearnSkill(character, SkillId.Warrior_Guard);
		}
	}

	private static void InitCommon(Character character)
	{
		LearnSkill(character, SkillId.Default);
		LearnSkill(character, SkillId.Common_shovel);
		LearnSkill(character, SkillId.Common_otlflag);
		LearnSkill(character, SkillId.Common_dumbbell);
		LearnSkill(character, SkillId.Common_vuvuzela);
		LearnSkill(character, SkillId.Common_snowspray);
		LearnSkill(character, SkillId.Common_balloonpipe);

		LearnAbility(character, AbilityId.Cloth);
		LearnAbility(character, AbilityId.Leather);
		LearnAbility(character, AbilityId.Iron);
		LearnAbility(character, AbilityId.SwapWeapon);

		GiveItem(character, ItemId.Drug_HP1_Q, 20);
		GiveItem(character, ItemId.Drug_SP1_Q, 20);
		GiveItem(character, ItemId.Drug_STA1_Q, 20);
		GiveItem(character, ItemId.Escape_Orb, 1);
		GiveItem(character, ItemId.EscapeStone_Klaipeda, 1);

		if (!Feature.IsEnabled("GrowthEquipOnStart"))
		{
			EquipItem(character, EquipSlot.Top, ItemId.TOP01_101);
			EquipItem(character, EquipSlot.Pants, ItemId.LEG01_101);
		}
		else
		{
			EquipItem(character, EquipSlot.Top, ItemId.GROWTH_REINFORCE_TIER1_LEATHER_TOP);
			EquipItem(character, EquipSlot.Pants, ItemId.GROWTH_REINFORCE_TIER1_LEATHER_LEG);
			EquipItem(character, EquipSlot.Shoes, ItemId.GROWTH_REINFORCE_TIER1_LEATHER_FOOT);
			EquipItem(character, EquipSlot.Gloves, ItemId.GROWTH_REINFORCE_TIER1_LEATHER_HAND);
		}
	}

	private static void InitSwordsman(Character character)
	{
		LearnSkill(character, SkillId.Normal_Attack);
		LearnSkill(character, SkillId.Normal_Attack_TH);
		LearnSkill(character, SkillId.Warrior_Guard);
		LearnSkill(character, SkillId.Pistol_Attack);
		LearnSkill(character, SkillId.Common_DaggerAries);

		LearnAbility(character, AbilityId.Sword);
		LearnAbility(character, AbilityId.Staff);
		LearnAbility(character, AbilityId.Mace);

		if (!Feature.IsEnabled("GrowthEquipOnStart"))
		{
			EquipItem(character, EquipSlot.RightHand, ItemId.SWD01_101);
		}
		else
		{
			GiveItem(character, ItemId.Select_Growth_Sword_Weapon, 4);
			GiveItem(character, ItemId.Select_Growth_Sword_SubWeapon, 4);
		}
	}

	private static void InitWizard(Character character)
	{
		LearnSkill(character, SkillId.Magic_Attack);
		LearnSkill(character, SkillId.Magic_Attack_TH);
		LearnSkill(character, SkillId.Common_DaggerAries);
		LearnSkill(character, SkillId.Common_StaffAttack);

		LearnAbility(character, AbilityId.Sword);
		LearnAbility(character, AbilityId.Staff);
		LearnAbility(character, AbilityId.Mace);
		LearnAbility(character, AbilityId.THStaff);

		if (!Feature.IsEnabled("GrowthEquipOnStart"))
		{
			EquipItem(character, EquipSlot.RightHand, ItemId.STF01_101);
		}
		else
		{
			GiveItem(character, ItemId.Select_Growth_Wizard_Weapon, 4);
			GiveItem(character, ItemId.Select_Growth_Wizard_SubWeapon, 4);
		}
	}

	private static void InitArcher(Character character)
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

		if (!Feature.IsEnabled("GrowthEquipOnStart"))
		{
			EquipItem(character, EquipSlot.RightHand, ItemId.TBW01_101);
		}
		else
		{
			GiveItem(character, ItemId.Select_Growth_Archer_Weapon, 4);
			GiveItem(character, ItemId.Select_Growth_Archer_SubWeapon, 4);
		}
	}

	private static void InitCleric(Character character)
	{
		LearnSkill(character, SkillId.Hammer_Attack);
		LearnSkill(character, SkillId.Hammer_Attack_TH);
		LearnSkill(character, SkillId.Common_DaggerAries);

		LearnAbility(character, AbilityId.Sword);
		LearnAbility(character, AbilityId.Staff);
		LearnAbility(character, AbilityId.Mace);
		LearnAbility(character, AbilityId.THMace);
		LearnAbility(character, AbilityId.Cleric36);

		if (!Feature.IsEnabled("GrowthEquipOnStart"))
		{
			EquipItem(character, EquipSlot.RightHand, ItemId.MAC01_101);
		}
		else
		{
			GiveItem(character, ItemId.Select_Growth_Cleric_Weapon, 4);
			GiveItem(character, ItemId.Select_Growth_Cleric_SubWeapon, 4);
		}
	}

	private static void InitScout(Character character)
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

		if (!Feature.IsEnabled("GrowthEquipOnStart"))
		{
			// It's difficult to find information on what kind of
			// equipment Scout got by default before growth items,
			// but the data mentions "Practice Pistol" and "Training
			// Kris Dagger", so we'll equip the dagger and give the
			// pistol for now.

			EquipItem(character, EquipSlot.RightHand, ItemId.DAG01_113);
			GiveItem(character, ItemId.PST01_111, 1);
		}
		else
		{
			GiveItem(character, ItemId.Select_Growth_Scout_Weapon, 4);
			GiveItem(character, ItemId.Select_Growth_Scout_SubWeapon, 4);
		}
	}

	// Use silent adders in these functions, so no data is sent to the
	// client right after the first login. That could work as well, but
	// there's no reason to start with spam, and the player doesn't
	// need to see a wall of information about what kinds of items were
	// just added to the inventory.

	private static void GiveItem(Character character, int itemId, int amount)
	{
		if (character.Inventory.HasItem(itemId))
			return;

		var item = new Item(itemId, amount);
		character.Inventory.AddSilent(item);
	}

	private static void EquipItem(Character character, EquipSlot slot, int itemId)
	{
		if (character.Inventory.HasItem(itemId))
			return;

		var item = new Item(itemId, 1);
		character.Inventory.SetEquipSilent(slot, item);
	}

	private static void LearnSkill(Character character, SkillId skillId)
	{
		if (character.Skills.Has(skillId))
			return;

		var skill = new Skill(character, skillId, 1);
		character.Skills.AddSilent(skill);
	}

	private static void UnlearnSkill(Character character, SkillId skillId)
	{
		character.Skills.RemoveSilent(skillId);
	}

	private static void LearnAbility(Character character, AbilityId abilityId)
	{
		if (character.Abilities.Has(abilityId))
			return;

		var ability = new Ability(abilityId, 1);
		character.Abilities.AddSilent(ability);
	}
}
