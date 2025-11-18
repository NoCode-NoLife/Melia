//--- Melia Script ----------------------------------------------------------
// Klaipeda Quest NPCs
//--- Description -----------------------------------------------------------
// Quest NPCs in Klaipeda for post-demon war storyline.
//---------------------------------------------------------------------------

using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.World.Quests;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Quests.Objectives;
using Melia.Zone.World.Quests.Prerequisites;
using Melia.Zone.World.Quests.Rewards;
using static Melia.Zone.Scripting.Shortcuts;


public class KlaipeQuestNpcsScript : GeneralScript
{
	protected override void Load()
	{
		// Withered Branch Collection Helper
		//-------------------------------------------------------------------------
		void AddWitheredBranchNpc(int sampleNumber, int x, int y, int direction)
		{
			AddNpc(152080, "Withered Branch", "c_Klaipe", x, y, direction, async dialog =>
			{
				var character = dialog.Player;
				var questId = new QuestId("Klaipeda", 1002);

				if (!character.Quests.IsActive(questId))
				{
					await dialog.Msg("A dying and burnt branch with blackened, withering leaves. The corruption has taken hold of the vegetation.");
					return;
				}

				var variableKey = $"Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample{sampleNumber}";
				var collected = character.Variables.Perm.GetBool(variableKey, false);

				if (collected)
				{
					await dialog.Msg("You've already collected a branch from this location.");
					return;
				}

				var result = await character.TimeActions.StartAsync("Collecting branch...", "Cancel", "SITGROPE", TimeSpan.FromSeconds(3));

				if (result == TimeActionResult.Completed)
				{
					character.Inventory.Add(650427, 1, InventoryAddType.PickUp);
					character.Variables.Perm.Set(variableKey, true);

					var currentCount = character.Inventory.CountItem(650427);
					character.ServerMessage($"Branches collected: {currentCount}/5");

					if (currentCount >= 5)
					{
						character.ServerMessage("All branches collected! Return to Elara.");
					}
				}
				else
				{
					character.ServerMessage("Collection cancelled.");
				}
			});
		}

		// Caravan Master Marcus
		//-------------------------------------------------------------------------
		AddNpc(20165, "[Caravan Master] Marcus", "c_Klaipe", -230, -1025, 90, async dialog =>
		{
			var character = dialog.Player;
			var questId = new QuestId("Klaipeda", 1001);

			dialog.SetTitle("Marcus");

			if (!character.Quests.Has(questId))
			{
				await dialog.Msg("Ah, traveler! Welcome to Klaipeda. We're working hard to rebuild after the war, but it's been... challenging.");
				await dialog.Msg("The roads are no longer safe. Monsters roam freely, and our supply caravans can't get through without proper protection.");

				if (await dialog.YesNo("Would you be willing to help escort a supply caravan? The pay is modest, but you'd be helping our city recover."))
				{
					character.Quests.Start(questId);
					await dialog.Msg("Excellent! Head to the western road and clear out the monsters. We need at least 5 of each of them gone before the caravan can safely pass.");
					await dialog.Msg("Be careful out there. These aren't ordinary beasts - some say they're tainted by lingering demon magic from the war.");
				}
				else
				{
					await dialog.Msg("I understand. It's dangerous work. If you change your mind, I'll be here organizing our supply efforts.");
				}
			}
			else if (character.Quests.IsActive(questId))
			{
				if (!character.Quests.TryGetById(questId, out var quest)) return;

				if (!quest.ObjectivesCompleted)
				{
					// Get progress for each objective
					quest.TryGetProgress("killHanaming", out var progressHanaming);
					quest.TryGetProgress("killOnion", out var progressOnion);
					quest.TryGetProgress("killLeafDiving", out var progressLeafDiving);
					quest.TryGetProgress("killInfrorocktor", out var progressInfrorocktor);

					await dialog.Msg("Keep up the good work! The western road is particularly dangerous near the forest edge. Watch your back out there.");
				}
				else
				{
					await dialog.Msg("Fantastic work! The road is clear, and our caravan just reported safe passage!");
					await dialog.Msg("You've earned this reward, and more importantly, you've helped dozens of families who depend on these supplies.");

					character.Quests.Complete(questId);
				}
			}
			else if (character.Quests.HasCompleted(questId))
			{
				await dialog.Msg("Thanks to you, our supply lines are much safer. You're always welcome in Klaipeda, friend.");
				await dialog.Msg("If you're looking for more work, you might check with Elara near the river. She's been dealing with some... unusual problems.");
			}
		});

		// River Warden Elara
		//-------------------------------------------------------------------------
		AddNpc(147473, "[River Warden] Elara", "c_Klaipe", -452, 910, 180, async dialog =>
		{
			var character = dialog.Player;
			var questId = new QuestId("Klaipeda", 1002);

			dialog.SetTitle("Elara");

			if (!character.Quests.Has(questId))
			{
				await dialog.Msg("This river is the main water source for the residents of Klaipeda. Without it, the city cannot survive.");

				var response = await dialog.Select("What brings you to the riverside?",
					Option("Can I help?", "help"),
					Option("Tell me more about the river", "info"),
					Option("Just passing through", "leave")
				);

				switch (response)
				{
					case "help":
						await dialog.Msg("You would help? Thank the goddesses! The corruption is spreading and we need to act quickly.");

						if (await dialog.YesNo("Can you help me by removing corrupted tree branches from the river? They're scattered along the riverbanks and need to be cleared."))
						{
							character.Quests.Start(questId);
							await dialog.Msg("Thank you so much! Please remove 5 Withered Branches from different locations along the river.");
						}
						break;

					case "info":
						await dialog.Msg("The river used to flow crystal clear, providing fresh water for drinking, cooking, and daily life.");
						await dialog.Msg("But corruption from the forest upstream has been falling into the river. Corrupted tree branches and debris are poisoning our water supply.");
						break;

					case "leave":
						await dialog.Msg("Safe travels. Try not to drink the river water until we've cleaned it...");
						break;
				}
			}
			else if (character.Quests.IsActive(questId))
			{
				var burntBranchCount = character.Inventory.CountItem(650427);

				if (burntBranchCount < 5)
				{
					await dialog.Msg($"Have you collected the branches? You have {burntBranchCount} out of 5 so far.");
					await dialog.Msg("Check the riverbanks for withered bushes and corrupted vegetation. They're the source of the contamination.");
				}
				else
				{
					await dialog.Msg("You've collected all the branches! The river is already flowing clearer!");
					await dialog.Msg("{#666666}*She inspects the water, a relieved smile crossing her face*{/}");
					await dialog.Msg("The water quality is improving already. The residents will be able to use the river safely again.");
					await dialog.Msg("You've saved countless lives today. Here - take this as thanks for your help.");

					character.Inventory.Remove(650427, 5, InventoryItemRemoveMsg.Given);
					character.Quests.Complete(questId);
				}
			}
			else if (character.Quests.HasCompleted(questId))
			{
				await dialog.Msg("The river is flowing much clearer now. The residents are grateful to have clean water again.");
				await dialog.Msg("Your help was invaluable. Without removing those corrupted branches, the water would have become completely unusable.");
			}
		});

		// Withered Branch Collection Points
		//-------------------------------------------------------------------------
		AddWitheredBranchNpc(1, -542, 987, 0);
		AddWitheredBranchNpc(2, -744, 770, 0);
		AddWitheredBranchNpc(3, -940, 668, 0);
		AddWitheredBranchNpc(4, -1067, 373, 0);
		AddWitheredBranchNpc(5, -988, 29, 0);
		AddWitheredBranchNpc(6, -259, 960, 0);

		// Reconstruction Coordinator Viktor
		//-------------------------------------------------------------------------
		AddNpc(20113, "[Reconstruction Coordinator] Viktor", "c_Klaipe", 814, -339, 90, async dialog =>
			{
				var character = dialog.Player;
				var questId = new QuestId("Klaipeda", 1003);

				dialog.SetTitle("Viktor");

				if (!character.Quests.Has(questId))
				{
					await dialog.Msg("Every day we rebuild, and every night I count the buildings still in ruins. This city was once magnificent, you know.");
					await dialog.Msg("The demon war left scars on more than just the land. Entire districts were destroyed. But we'll rebuild - we must.");

					var response = await dialog.Select("Would you like to help us rebuilding our homes?",
						Option("I'd like to help", "help"),
						Option("What do you need most?", "needs"),
						Option("Good luck with that", "leave")
					);

					switch (response)
					{

						case "help":
							await dialog.Msg("A volunteer! We desperately need building materials - wood planks specifically.");

							if (await dialog.YesNo("The forests outside the city have salvageable materials, but they're monster-infested. Can you gather 20 Dry Wood for us?"))
							{
								character.Quests.Start(questId);
								await dialog.Msg("Wonderful! You'll find wood to the west and east of the city. Salvage what you can and bring back to me.");
								await dialog.Msg("Watch out for scavenger monsters - they've made homes in the forests and don't take kindly to visitors.");
							}
							break;

						case "needs":
							await dialog.Msg("Wood - the basic material of construction. But they're hard to come by now.");
							await dialog.Msg("The old quarries and lumber camps were overrun during the war. We'd need someone to venture out and reclaim them.");
							break;

						case "leave":
							await dialog.Msg("We rebuild with or without help. It's what we do.");
							break;
					}
				}
				else if (character.Quests.IsActive(questId))
				{
					var woodCount = character.Inventory.CountItem(667203);

					if (woodCount >= 20)
					{
						await dialog.Msg("You've brought everything we need! Excellent work!");
						await dialog.Msg("With these materials, we can repair at least three houses. That's three more families with roofs over their heads.");
						await dialog.Msg("You have my gratitude, and the gratitude of everyone in those homes.");

						character.Inventory.Remove(667203, 20, InventoryItemRemoveMsg.Given);
						character.Quests.Complete(questId);
					}
					else
					{
						await dialog.Msg($"Thank you for gathering materials! We need 20 wood planks from Dry Woods (you have {woodCount}).");
						await dialog.Msg("The forests are dangerous, but the materials there are essential for our recovery.");
					}
				}
				else if (character.Quests.HasCompleted(questId))
				{
					await dialog.Msg("The houses you helped rebuild are occupied now. I see children playing in those yards every day.");
					await dialog.Msg("That's what reconstruction is really about - giving people their lives back.");
				}
			});

		// Cursed Refugee Aldric
		//-------------------------------------------------------------------------
		AddNpc(147382, "[Cursed Refugee] Aldric", "c_voodoo", -62, -16, 90, async dialog =>
		{
			var character = dialog.Player;
			var questId = new QuestId("Klaipeda", 1005);

			dialog.SetTitle("Aldric");

			if (!character.Quests.Has(questId))
			{
				await dialog.Msg("{#666666}*The man is wrapped in heavy chains, his eyes haunted*{/}");
				await dialog.Msg("Stay back... I'm dangerous. The curse... it makes me lose control when the sun sets.");

				var response = await dialog.Select("Stay back... I'm dangerous. The curse... it makes me lose control when the sun sets.",
					Option("How can I help?", "help"),
					Option("Tell me about your curse", "curse"),
					Option("Leave him be", "leave")
				);

				switch (response)
				{
					case "curse":
						await dialog.Msg("A demon lord marked my village during the war. Those who survived... we carry his curse.");
						await dialog.Msg("At night, we become violent, mindless. These chains are the only thing keeping the citizens safe from me.");
						break;

					case "help":
						await dialog.Msg("You would help someone like me? I... thank you.");

						if (await dialog.YesNo("There might be a way to break the curse. In my village ruins, there's an ancient chest with a broken amulet. If you could retrieve it..."))
						{
							character.Quests.Start(questId);
							await dialog.Msg("The broken amulet absorbs dark energies - it might be able to draw out the curse from my body.");
							await dialog.Msg("The cursed villagers still wander the ruins. They were my neighbors once. My friends. Now they're just... shells.");
							await dialog.Msg("Head east from the Miner's Village. You'll find the ruins there, and the chest with the amulet. Please... hurry.");
						}
						break;

					case "leave":
						await dialog.Msg("{#666666}*He nods silently, chains rattling*{/}");
						break;
				}
			}
			else if (character.Quests.IsActive(questId))
			{
				var hasAmulet = character.Inventory.HasItem(668038);

				if (hasAmulet)
				{
					await dialog.Msg("{#FFFF00}*His eyes widen as he sees the broken amulet*{/}");
					await dialog.Msg("You found it! You actually found it! Please, place it against my chest - carefully, the curse fights back...");
					await dialog.Msg("{#FF0000}*As the amulet touches him, it begins to glow. Dark smoke pours from his body into the amulet. He screams in pain, then... silence*{/}");
					await dialog.Msg("It's... it's gone. The curse is broken! The amulet absorbed all the dark energy!");
					await dialog.Msg("Thank you, stranger. You've given me my life back. Here - this was my father's. He'd want you to have it.");

					character.Inventory.Remove(668038, 1, InventoryItemRemoveMsg.Given);
					character.Quests.Complete(questId);
				}
				else
				{
					await dialog.Msg("The broken amulet should be in an ancient chest somewhere in the village ruins. Please, hurry. Every night the curse grows stronger.");
					await dialog.Msg("Eastwood Village is east from the Miner's Village. Look for the ruins.");
				}
			}
			else if (character.Quests.HasCompleted(questId))
			{
				await dialog.Msg("I'm free of the curse, but my village is still lost. Perhaps one day I'll return and help cleanse it.");
				await dialog.Msg("Until then, I owe you a debt I can never repay. You've given me hope when I had none.");
			}
		});
	}
}

//-----------------------------------------------------------------------------
// Quests
//-----------------------------------------------------------------------------

// Quest 1001: Caravan Escort
//-----------------------------------------------------------------------------
public class KlaipeCaravanEscortQuest : QuestScript
{
	protected override void Load()
	{
		SetId("Klaipeda", 1001);
		SetName("Caravan Escort");
		SetDescription("Clear the western road of monsters so supply caravans can safely reach Klaipeda.");
		SetLocation("f_siauliai_west");
		SetAutoTracked(true);

		SetReceive(QuestReceiveType.Manual);
		SetCancelable(true);
		SetUnlock(QuestUnlockType.AllAtOnce);
		AddQuestGiver("[Caravan Master] Marcus", "c_Klaipe");

		// Kill 15 monsters on the western road (using common monsters as placeholder)
		AddObjective("killHanaming", "Kill Hanamings", new KillObjective(5, new[] { MonsterId.Hanaming }));
		AddObjective("killOnion", "Kill Kepas", new KillObjective(5, new[] { MonsterId.Onion }));
		AddObjective("killLeafDiving", "Kill Leaf Diving", new KillObjective(5, new[] { MonsterId.Leaf_Diving }));
		AddObjective("killInfrorocktor", "Kill Infrorocktor", new KillObjective(5, new[] { MonsterId.InfroRocktor }));

		// Rewards
		AddReward(new ExpReward(300, 200));
		AddReward(new SilverReward(3000));
		AddReward(new ItemReward(640002, 15)); // HP potions
		AddReward(new ItemReward(640005, 15)); // SP potions
		AddReward(new ItemReward(640080, 2)); // Lv1 EXP Cards
	}
}

// Quest 1002: River Corruption Investigation
//-----------------------------------------------------------------------------
public class KlaipeRiverCorruptionQuest : QuestScript
{
	protected override void Load()
	{
		SetId("Klaipeda", 1002);
		SetName("Cleansing the River");
		SetDescription("Help River Warden Elara by removing corrupted tree branches that are polluting Klaipeda's main water source.");
		SetLocation("c_Klaipe");
		SetAutoTracked(true);

		SetReceive(QuestReceiveType.Manual);
		SetCancelable(true);
		SetUnlock(QuestUnlockType.AllAtOnce);
		AddQuestGiver("[River Warden] Elara", "c_Klaipe");

		// Collect 5 burnt branches from withered branches
		AddObjective("collectBranches", "Collect Withered Burnt Branches",
			new CollectItemObjective(650427, 5));

		// Rewards
		AddReward(new ExpReward(200, 150));
		AddReward(new SilverReward(2500));
		AddReward(new ItemReward(640002, 5)); // HP potions
		AddReward(new ItemReward(640005, 5)); // SP potions
		AddReward(new ItemReward(640097, 5)); // Stamina Potions
		AddReward(new ItemReward(640073, 5)); // Klaipeda Warp Scroll
		AddReward(new ItemReward(640080, 2)); // Lv1 EXP Cards
	}

	public override void OnComplete(Character character, Quest quest)
	{
		// Unlock follow-up quest about purification ritual (future content)
		character.Variables.Perm.Set("Melia.Quests.Klaipeda.Quest1002.KlaipeRiverQuestComplete", true);

		// Remove quest items
		character.Inventory.Remove(650427, character.Inventory.CountItem(650427),
			InventoryItemRemoveMsg.Destroyed);

		// Clear all collection flags so they can be reused if quest becomes repeatable
		character.Variables.Perm.Remove("Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample1");
		character.Variables.Perm.Remove("Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample2");
		character.Variables.Perm.Remove("Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample3");
		character.Variables.Perm.Remove("Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample4");
		character.Variables.Perm.Remove("Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample5");
		character.Variables.Perm.Remove("Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample6");
	}

	public override void OnCancel(Character character, Quest quest)
	{
		// Remove quest items
		character.Inventory.Remove(650427, character.Inventory.CountItem(650427),
			InventoryItemRemoveMsg.Destroyed);

		// Clear all collection flags so player can re-collect if they re-accept the quest
		character.Variables.Perm.Remove("Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample1");
		character.Variables.Perm.Remove("Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample2");
		character.Variables.Perm.Remove("Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample3");
		character.Variables.Perm.Remove("Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample4");
		character.Variables.Perm.Remove("Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample5");
		character.Variables.Perm.Remove("Melia.Quests.Klaipeda.Quest1002.KlaipePlantSample6");
	}
}

// Quest 1003: Reconstruction Materials
//-----------------------------------------------------------------------------
public class KlaipeReconstructionQuest : QuestScript
{
	protected override void Load()
	{
		SetId("Klaipeda", 1003);
		SetName("Rebuilding Klaipeda");
		SetDescription("Gather wood planks from the forest monsters to help rebuild Klaipeda.");
		SetLocation("f_siauliai_west", "f_siauliai_out");
		SetAutoTracked(true);

		SetReceive(QuestReceiveType.Manual);
		SetCancelable(true);
		SetUnlock(QuestUnlockType.AllAtOnce);
		AddQuestGiver("[Reconstruction Coordinator] Viktor", "c_Klaipe");

		// Add quest item drops from specific monsters when quest is active
		// Wood planks drop from wood-type monsters
		AddDrop(667203, 0.3f, MonsterId.Hanaming);
		AddDrop(667203, 0.3f, MonsterId.Onion);
		AddDrop(667203, 0.3f, MonsterId.Leaf_Diving);
		AddDrop(667203, 0.3f, MonsterId.Onion_Red);
		AddDrop(667203, 0.3f, MonsterId.Jukopus);
		AddDrop(667203, 0.3f, MonsterId.Goblin_Spear);

		// Collect materials
		AddObjective("collectWood", "Collect Dry Wood",
			new CollectItemObjective(667203, 20));

		// Rewards
		AddReward(new ExpReward(400, 300));
		AddReward(new SilverReward(3000));
		AddReward(new ItemReward(640002, 15)); // HP potions
		AddReward(new ItemReward(640005, 15)); // SP potions
		AddReward(new ItemReward(640080, 3)); // Lv1 EXP Cards
	}

	public override void OnComplete(Character character, Quest quest)
	{
		// Remove quest items
		character.Inventory.Remove(667203, character.Inventory.CountItem(667203),
			InventoryItemRemoveMsg.Destroyed);
	}

	public override void OnCancel(Character character, Quest quest)
	{
		// Remove quest items
		character.Inventory.Remove(667203, character.Inventory.CountItem(667203),
			InventoryItemRemoveMsg.Destroyed);
	}
}

// Quest 1005: Cursed Refugee
//-----------------------------------------------------------------------------
public class KlaipeCursedRefugeeQuest : QuestScript
{
	protected override void Load()
	{
		SetId("Klaipeda", 1005);
		SetName("Breaking the Curse");
		SetDescription("Retrieve the broken amulet from Eastwood Village at east of Miner's Village to break Aldric's curse. The amulet absorbs dark energies and may be able to draw out the curse.");
		SetLocation("c_siauliai_out");
		SetAutoTracked(true);

		SetReceive(QuestReceiveType.Manual);
		SetCancelable(true);
		SetUnlock(QuestUnlockType.AllAtOnce);
		AddQuestGiver("[Cursed Refugee] Aldric", "c_voodoo");

		// Retrieve the broken amulet from the chest
		AddObjective("retrieveAmulet", "Retrieve the broken amulet",
			new CollectItemObjective(668038, 1));

		AddReward(new ExpReward(1500, 750));
		AddReward(new SilverReward(7000));
		AddReward(new ItemReward(640002, 10)); // HP potions
		AddReward(new ItemReward(640005, 10)); // SP potions
		AddReward(new ItemReward(111007, 1)); // Yorgis Knife
		AddReward(new ItemReward(640080, 4)); // Lv1 Exp Card
	}

	public override void OnComplete(Character character, Quest quest)
	{
		// Remove quest amulet if player still has it (shouldn't happen but just in case)
		character.Inventory.Remove(668038, character.Inventory.CountItem(668038),
			InventoryItemRemoveMsg.Destroyed);
	}

	public override void OnCancel(Character character, Quest quest)
	{
		// Remove quest amulet if player has it
		character.Inventory.Remove(668038, character.Inventory.CountItem(668038),
			InventoryItemRemoveMsg.Destroyed);
	}
}
