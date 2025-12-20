//--- Melia Script ----------------------------------------------------------
// Siauliai Out (Miner's Village) Quest NPCs
//--- Description -----------------------------------------------------------
// Quest NPCs in Miner's Village for post-demon war storyline.
// Also includes Eastwood Village Ruins (Quest: Klaipeda/1005)
//---------------------------------------------------------------------------

using System;
using System.Threading;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Maps;
using Melia.Zone.World.Quests;
using Melia.Zone.World.Quests.Objectives;
using Melia.Zone.World.Quests.Prerequisites;
using Melia.Zone.World.Quests.Rewards;
using Yggdrasil.Logging;
using Yggdrasil.Util;
using static Melia.Zone.Scripting.Shortcuts;


public class FSiauliaiOutQuestNpcsScript : GeneralScript
{
	protected override void Load()
	{
		// =====================================================================
		// MINER'S VILLAGE QUEST NPCs
		// =====================================================================

		// Mine Foreman Karolis
		//-------------------------------------------------------------------------
		AddNpc(20150, "[Mine Foreman] Karolis", "f_siauliai_out", 163, -986, 45, async dialog =>
		{
			var character = dialog.Player;
			var questId = new QuestId("f_siauliai_out", 1001);

			dialog.SetTitle("Karolis");

			if (!character.Quests.Has(questId))
			{
				await dialog.Msg("Welcome to Miner's Village, traveler. I'm the foreman of the Crystal Mine operations.");
				await dialog.Msg("{#666666}*He looks exhausted, dark circles under his eyes*{/}");

				var response = await dialog.Select("But our work has ground to a halt. The goblins from the eastern hills have been raiding our supply routes.",
					Option("How can I help?", "help"),
					Option("Why not hire guards?", "guards"),
					Option("I'm just passing through", "leave")
				);

				switch (response)
				{
					case "help":
						await dialog.Msg("A willing hand! The goddesses smile on us today!");

						if (await dialog.YesNo("The Vubbe goblins have been stealing our mining supplies and terrorizing workers. If you could clear them out near the village entrance, we could resume operations."))
						{
							character.Quests.Start(questId);
							await dialog.Msg("Excellent! Drive back those Vubbes and we'll make it worth your while.");
							await dialog.Msg("Be careful - they may look comical, but they're surprisingly organized and dangerous in groups.");
						}
						break;

					case "guards":
						await dialog.Msg("{#666666}*He laughs bitterly*{/} Guards? With what silver? The mine has barely produced since the demon war disrupted our operations.");
						await dialog.Msg("Most guards are busy protecting the main cities. Small mining villages like ours are on our own.");
						break;

					case "leave":
						await dialog.Msg("Safe travels. Watch yourself on the roads - it's not safe out here anymore.");
						break;
				}
			}
			else if (character.Quests.IsActive(questId))
			{
				if (!character.Quests.TryGetById(questId, out var quest)) return;

				if (!quest.ObjectivesCompleted)
				{
					await dialog.Msg("Keep pushing those Vubbes back! They've been making our lives miserable for weeks now.");
				}
				else
				{
					await dialog.Msg("You did it! I can already see the goblins retreating from the area!");
					await dialog.Msg("Our miners can finally work without fear. The village owes you a debt of gratitude.");
					await dialog.Msg("Here's your payment, and some supplies from our stores. Thank you, truly.");

					character.Quests.Complete(questId);
				}
			}
			else if (character.Quests.HasCompleted(questId))
			{
				await dialog.Msg("Thanks to you, our mining operations are back on schedule. The village is safer now.");
				await dialog.Msg("If you're looking for more work, you should speak with Elara near the old bridge. She mentioned needing help with something.");
			}
		});

		// Village Alchemist Elara
		//-------------------------------------------------------------------------
		AddNpc(147473, "[Village Alchemist] Elara", "f_siauliai_out", -910, -1861, 45, async dialog =>
		{
			var character = dialog.Player;
			var questId = new QuestId("f_siauliai_out", 1002);

			dialog.SetTitle("Elara");

			if (!character.Quests.Has(questId))
			{
				await dialog.Msg("{#666666}*A young woman carefully grinds herbs with a mortar and pestle*{/}");
				await dialog.Msg("Oh! A visitor! Welcome to my humble workshop. I'm Elara, the village alchemist.");

				var response = await dialog.Select("I'm working on a remedy for a mysterious illness affecting some of the miners, but I'm missing key ingredients.",
					Option("What ingredients do you need?", "help"),
					Option("What kind of illness?", "illness"),
					Option("Good luck with your research", "leave")
				);

				switch (response)
				{
					case "help":
						await dialog.Msg("You'd help me? Wonderful! I need samples from the local wildlife.");

						if (await dialog.YesNo("I need Red Kepa Skins and Jukopus Cores. The Red Kepas and Jukopus monsters should have them. Will you gather these for me?"))
						{
							character.Quests.Start(questId);
							await dialog.Msg("Perfect! I need 10 Red Kepa Skins and 8 Jukopus Cores. Both types of monsters can be found in the areas surrounding this village.");
							await dialog.Msg("The sooner I have these ingredients, the sooner I can help the afflicted miners!");
						}
						break;

					case "illness":
						await dialog.Msg("It's strange... miners who work deep in the Crystal Mine have been experiencing weakness and fever.");
						await dialog.Msg("I suspect it's related to prolonged exposure to the crystals. The demon war's magical residue may have contaminated them.");
						await dialog.Msg("If I can create the right remedy, I might be able to counteract the effects and protect our workers.");
						break;

					case "leave":
						await dialog.Msg("Thank you. Those miners are counting on me... I can't let them down.");
						break;
				}
			}
			else if (character.Quests.IsActive(questId))
			{
				var kepaCount = character.Inventory.CountItem(650463);
				var jukopusCount = character.Inventory.CountItem(650464);

				if (kepaCount >= 10 && jukopusCount >= 8)
				{
					await dialog.Msg("{#666666}*Her eyes light up as she examines the materials*{/}");
					await dialog.Msg("These are perfect specimens! The quality is excellent!");
					await dialog.Msg("{#666666}*She quickly begins mixing the ingredients in a glass vial*{/}");
					await dialog.Msg("Yes... yes! The mixture is turning the right color. This should work!");
					await dialog.Msg("I'll start treating the miners immediately. You've saved lives today. Please, accept this as thanks.");

					character.Inventory.Remove(650463, 10, InventoryItemRemoveMsg.Given);
					character.Inventory.Remove(650464, 8, InventoryItemRemoveMsg.Given);
					character.Quests.Complete(questId);
				}
				else
				{
					await dialog.Msg($"How's the gathering going? I need 10 Red Kepa Skins and 8 Jukopus Cores.");
					await dialog.Msg("The miners are getting worse each day. Please hurry if you can.");
				}
			}
			else if (character.Quests.HasCompleted(questId))
			{
				await dialog.Msg("The remedy worked perfectly! The affected miners are already showing improvement.");
				await dialog.Msg("Your contribution to this village will not be forgotten.");
			}
		});

		// Mysterious Trader Rokas
		//-------------------------------------------------------------------------
		AddNpc(147426, "[Mysterious Trader] Rokas", "f_siauliai_out", -1341, -1672, 45, async dialog =>
		{
			var character = dialog.Player;
			var questId = new QuestId("f_siauliai_out", 1003);

			dialog.SetTitle("Rokas");

			if (!character.Quests.Has(questId))
			{
				await dialog.Msg("{#666666}*A mysterious person examines a strange crystal, muttering to himself*{/}");
				await dialog.Msg("Hmm? A stranger approaches. Tell me, do you believe in fate?");

				var response = await dialog.Select("I've been searching for three pieces of an ancient broken sword hidden near this village. They were scattered during the chaos of the demon war.",
					Option("I'll help you find them", "help"),
					Option("What kind of sword?", "relics"),
					Option("Sounds suspicious...", "leave")
				);

				switch (response)
				{
					case "help":
						await dialog.Msg("Excellent! Your assistance is most appreciated.");

						if (await dialog.YesNo("The sword pieces are hidden in three separate locations around the village. Will you retrieve all three broken sword pieces for me?"))
						{
							character.Quests.Start(questId);
							await dialog.Msg("Splendid! Look for the broken sword pieces somewhere in this village. They'll appear as ancient blade fragments.");
							await dialog.Msg("Be warned - the areas are infested with monsters. Stay alert.");
						}
						break;

					case "relics":
						await dialog.Msg("Pieces of an ancient legendary sword, shattered during a great battle before the war. Each piece still contains powerful magical energy.");
						await dialog.Msg("I tracked them to this region, but the monsters have made searching too dangerous for someone like me.");
						break;

					case "leave":
						await dialog.Msg("{#666666}*He shrugs*{/} Suspicious? Perhaps. But the sword pieces are real, and they're valuable.");
						await dialog.Msg("If you change your mind, I'll be here. These fragments aren't going anywhere without help.");
						break;
				}
			}
			else if (character.Quests.IsActive(questId))
			{
				var swordPieceCount = character.Inventory.CountItem(650522);

				if (swordPieceCount >= 3)
				{
					await dialog.Msg("{#666666}*He eagerly takes the sword pieces and examines them closely*{/}");
					await dialog.Msg("Remarkable! All three pieces, intact after all these years!");
					await dialog.Msg("{#666666}*He carefully fits the pieces together, and they begin to glow with magical energy*{/}");
					await dialog.Msg("The ancient power still flows through them. Collectors in Klaipeda will pay a fortune for these relics.");
					await dialog.Msg("You've done well. Here's your payment, plus a bonus for your efficiency.");

					character.Inventory.Remove(650522, 3, InventoryItemRemoveMsg.Given);
					character.Quests.Complete(questId);
				}
				else
				{
					await dialog.Msg($"Have you found the sword pieces? You have {swordPieceCount} of 3 so far.");
					await dialog.Msg("Search the village carefully. The sword fragments are well hidden.");
				}
			}
			else if (character.Quests.HasCompleted(questId))
			{
				await dialog.Msg("Those sword fragments will help us understand the ancient wars better. Such powerful artifacts should be preserved.");
				await dialog.Msg("Perhaps we'll work together again someday.");
			}
		});

		// Broken Sword Piece Collection Points
		//-------------------------------------------------------------------------
		void AddSwordPieceNpc(int pieceNumber, int x, int z)
		{
			AddNpc(47170, "Broken Sword Fragment", "f_siauliai_out", x, z, 45, async dialog =>
			{
				var character = dialog.Player;
				var questId = new QuestId("f_siauliai_out", 1003);

				if (!character.Quests.IsActive(questId))
				{
					await dialog.Msg("{#666666}*A fragment of an ancient broken sword, still faintly glowing with magical energy*{/}");
					return;
				}

				var variableKey = $"Melia.Quests.f_siauliai_out.Quest1003.SwordPiece{pieceNumber}";
				var collected = character.Variables.Perm.GetBool(variableKey, false);

				if (collected)
				{
					await dialog.Msg("{#666666}*You've already collected the sword piece from this location*{/}");
					return;
				}

				var result = await character.TimeActions.StartAsync("Extracting broken sword piece...", "Cancel", "SITGROPE", TimeSpan.FromSeconds(4));

				if (result == TimeActionResult.Completed)
				{
					character.Inventory.Add(650522, 1, InventoryAddType.PickUp);
					character.Variables.Perm.Set(variableKey, true);

					var currentCount = character.Inventory.CountItem(650522);
					character.ServerMessage($"Broken sword pieces collected: {currentCount}/3");

					if (currentCount >= 3)
					{
						character.ServerMessage("{#FFD700}All sword pieces collected! Return to Rokas.{/}");
					}
				}
				else
				{
					character.ServerMessage("Extraction cancelled.");
				}
			});
		}

		AddSwordPieceNpc(1, -2165, -1546);
		AddSwordPieceNpc(2, 1026, -847);
		AddSwordPieceNpc(3, 1592, 556);

		// Retired Adventurer Magnus
		//-------------------------------------------------------------------------
		AddNpc(20156, "[Retired Adventurer] Magnus", "f_siauliai_out", 371, -1108, 0, async dialog =>
		{
			var character = dialog.Player;
			var questId = new QuestId("f_siauliai_out", 1004);

			dialog.SetTitle("Magnus");

			if (!character.Quests.Has(questId))
			{
				await dialog.Msg("{#666666}*An elderly man stands with an empty look in his eyes*{/}");
				await dialog.Msg("Heh... another fresh face. You have the look of an adventurer about you.");

				var response = await dialog.Select("In my day, I explored every corner of this region. Now I'm just an old man with stories and regrets.",
					Option("Do you need help with something?", "help"),
					Option("Tell me a story", "story"),
					Option("I should get going", "leave")
				);

				switch (response)
				{
					case "help":
						await dialog.Msg("Help? {#666666}*He looks surprised*{/} Well... there is something, if you're willing.");

						if (await dialog.YesNo("I dropped my father's pendant somewhere in the village when I was fleeing from monsters. It's all I have left of him. Could you search for it?"))
						{
							character.Quests.Start(questId);
							await dialog.Msg("Thank you, young one. I believe I dropped it somewhere in the central area of the village.");
							await dialog.Msg("It's a simple copper pendant, but it means the world to me. Please bring it back if you find it.");
						}
						else
						{
							await dialog.Msg("I understand. It's just a sentimental trinket anyway.");
						}
						break;

					case "story":
						await dialog.Msg("Stories? I've got plenty. Did I tell you about the time I fought a Goblin King in the eastern caves?");
						await dialog.Msg("{#666666}*He pauses, looking wistful*{/}");
						await dialog.Msg("But that was before the war. Before everything changed. These days, I don't have the strength for such adventures.");
						break;

					case "leave":
						await dialog.Msg("Be careful out there. The monsters aren't what they used to be - they're more aggressive now.");
						break;
				}
			}
			else if (character.Quests.IsActive(questId))
			{
				if (character.Inventory.HasItem(664156))
				{
					await dialog.Msg("{#666666}*His hands tremble as he takes the pendant*{/}");
					await dialog.Msg("My father's pendant... I thought I'd lost it forever.");
					await dialog.Msg("{#666666}*He clutches it to his chest, tears in his eyes*{/}");
					await dialog.Msg("This pendant has been in my family for four generations. It's the only thing I have left from the old days.");
					await dialog.Msg("Here, take this. It's my old training blade. May it serve you better than these tired arms can wield it now.");

					character.Inventory.Remove(664156, 1, InventoryItemRemoveMsg.Given);
					character.Quests.Complete(questId);
				}
				else
				{
					await dialog.Msg("Have you found my pendant? It should be somewhere in the village central area.");
					await dialog.Msg("It's made of copper with my family crest engraved on it.");
				}
			}
			else if (character.Quests.HasCompleted(questId))
			{
				await dialog.Msg("{#666666}*He holds the pendant close*{/}");
				await dialog.Msg("Thank you again for returning this to me. You've given an old man his most precious memory back.");
			}
		});

		// Magnus's Pendant
		//-------------------------------------------------------------------------
		AddNpc(155003, "Pile of Dirt", "f_siauliai_out", -105, -1136, 0, async dialog =>
		{
			var character = dialog.Player;
			var questId = new QuestId("f_siauliai_out", 1004);
			var spawnedKey = $"Melia.Quests.f_siauliai_out.Quest1004.Pendant.Spawned";

			if (!character.Quests.IsActive(questId))
			{
				await dialog.Msg("{#666666}*A tarnished copper pendant lies half-buried in the dirt*{/}");
				return;
			}

			if (character.Inventory.HasItem(664156))
			{
				await dialog.Msg("{#666666}*You've already picked up the pendant*{/}");
				return;
			}

			var result = await character.TimeActions.StartAsync("Picking up pendant...", "Cancel", "SITGROPE", TimeSpan.FromSeconds(3));

			if (result == TimeActionResult.Completed)
			{
				character.Inventory.Add(664156, 1, InventoryAddType.PickUp);
				character.ServerMessage("Found Magnus's pendant!");
				character.ServerMessage("{#FFD700}Return the pendant to Magnus.{/}");
			}
			else
			{
				character.ServerMessage("Action cancelled.");
			}
		});

		// =====================================================================
		// EASTWOOD VILLAGE RUINS (Quest: Klaipeda/1005)
		// =====================================================================
		// SEVERE CURSE: This area is obviously corrupted (demon lord's direct touch)
		// Dark atmosphere, curse marks, cursed villagers
		// The broken amulet in the chest absorbs dark energies to break Aldric's curse
		// =====================================================================

		var curseQuestId = new QuestId("Klaipeda", 1005);

		// Village Entrance Sign
		//-------------------------------------------------------------------------
		AddNpc(40080, "Weathered Sign", "f_siauliai_out", 1893, 13, 0, async dialog =>
		{
			await dialog.Msg("{#666666}*A faded wooden sign reads:*{/}");
			await dialog.Msg("{#FF0000}EASTWOOD VILLAGE - QUARANTINE{/}");
			await dialog.Msg("{#FF0000}Below it, hastily carved: 'DO NOT ENTER. CURSE ACTIVE. SURVIVORS EVACUATED.'{/}");

			if (dialog.Player.Quests.IsActive(curseQuestId))
			{
				await dialog.Msg("{#FFFF00}The broken amulet might be somewhere in the ruins. It's said to absorb dark energies.{/}");
			}
		});

		// Memorial Stone
		//-------------------------------------------------------------------------
		AddNpc(47212, "Memorial Stone", "f_siauliai_out", 1903, 288, 45, async dialog =>
		{
			await dialog.Msg("{#666666}*A crude memorial stone stands here, covered in names*{/}");
			await dialog.Msg("'In memory of Eastwood Village. 36 souls lost to the demon lord's curse.'");
			await dialog.Msg("'May the goddesses guide you home.'");
			await dialog.Msg("{#666666}*Someone added beneath: 'Aldric survived. Last seen heading to Klaipeda.'{/}");
		});

		// Chest with Broken Amulet
		//-------------------------------------------------------------------------
		AddNpc(147341, "Ancient Chest", "f_siauliai_out", 2105, 500, 0, async dialog =>
		{
			var character = dialog.Player;

			if (!character.Quests.IsActive(curseQuestId))
			{
				await dialog.Msg("{#666666}*An old chest, covered in dust and curse marks*{/}");
				await dialog.Msg("{#FF0000}*You feel an overwhelming urge not to touch it*{/}");
				return;
			}

			var hasAmulet = character.Inventory.HasItem(668038);

			if (hasAmulet)
			{
				await dialog.Msg("{#666666}*The chest is empty - you've already taken the broken amulet*{/}");
				return;
			}

			var result = await character.TimeActions.StartAsync("Opening chest...", "Cancel", "SITGROPE", TimeSpan.FromSeconds(3));

			if (result == TimeActionResult.Completed)
			{
				await dialog.Msg("{#666666}*Inside the chest, you find a cracked amulet pulsing with dark energy*{/}");
				await dialog.Msg("{#006600}This must be the broken amulet Aldric mentioned. It seems to absorb the curse's dark energies.{/}");

				character.Inventory.Add(668038, 1, InventoryAddType.PickUp);
				await dialog.Msg("You obtained the Broken Amulet!");
			}
			else
			{
				character.ServerMessage("Opening cancelled.");
			}
		});

		// Cursed Villager #1
		//-------------------------------------------------------------------------
		AddNpc(47210, "Cursed Villager", "f_siauliai_out", 1819, 295, 90, async dialog =>
		{
			await dialog.Msg("{#666666}*A villager stands frozen in place, their body turned to stone*{/}");
			await dialog.Msg("{#666666}*Dark veins spread across the petrified surface like cracks in marble, pulsing with faint malevolent energy*{/}");
			await dialog.Msg("{#666666}*Their face is locked in an expression of terror - a final moment before the curse petrified them completely*{/}");
		});

		// Cursed Villager #2
		//-------------------------------------------------------------------------
		AddNpc(47210, "Cursed Villager", "f_siauliai_out", 1857, 508, 0, async dialog =>
		{
			await dialog.Msg("{#666666}*Another petrified figure, frozen mid-stride as if trying to flee*{/}");
			await dialog.Msg("{#666666}*Black veins web across their stone skin, thicker and more prominent than the other victim*{/}");
			await dialog.Msg("{#666666}*The curse spread quickly here - you can see the panic frozen in their posture*{/}");
			await dialog.Msg("{#666666}*A faint dark mist seeps from the cracks in the stone, evidence of the lingering curse*{/}");
		});
	}
}

//-----------------------------------------------------------------------------
// Quests
//-----------------------------------------------------------------------------

// Quest 1001: Goblin Problem
//-----------------------------------------------------------------------------
public class FSiauliaiOutGoblinProblemQuest : QuestScript
{
	protected override void Load()
	{
		SetId("f_siauliai_out", 1001);
		SetName("The Goblin Menace");
		SetDescription("Help Mine Foreman Karolis by clearing out the Goblin Spears that have been raiding the village's supply routes.");
		SetLocation("f_siauliai_out");
		SetAutoTracked(true);

		SetReceive(QuestReceiveType.Manual);
		SetCancelable(true);
		SetUnlock(QuestUnlockType.AllAtOnce);
		AddQuestGiver("[Mine Foreman] Karolis", "f_siauliai_out");

		// Kill goblins
		AddObjective("killGoblins", "Defeat Goblin Spears",
			new KillObjective(18, new[] { MonsterId.Goblin_Spear }));

		// Rewards
		AddReward(new ExpReward(700, 500));
		AddReward(new SilverReward(5000));
		AddReward(new ItemReward(640002, 10)); // HP potions
		AddReward(new ItemReward(640005, 10)); // SP potions
		AddReward(new ItemReward(601115, 1)); // Iron Bangle
		AddReward(new ItemReward(640080, 6)); // Lv1 EXP Cards
	}
}

// Quest 1002: Alchemist's Remedy
//-----------------------------------------------------------------------------
public class FSiauliaiOutAlchemistRemedyQuest : QuestScript
{
	protected override void Load()
	{
		SetId("f_siauliai_out", 1002);
		SetName("The Cure for Crystal Sickness");
		SetDescription("Gather Red Kepa Skins and Jukopus Cores for Village Alchemist Elara so she can create a remedy for the miners suffering from crystal contamination.");
		SetLocation("f_siauliai_out");
		SetAutoTracked(true);

		SetReceive(QuestReceiveType.Manual);
		SetCancelable(true);
		SetUnlock(QuestUnlockType.AllAtOnce);
		AddQuestGiver("[Village Alchemist] Elara", "f_siauliai_out");

		// Add quest item drops
		AddDrop(650463, 0.4f, MonsterId.Onion_Red);
		AddDrop(650464, 0.3f, MonsterId.Jukopus);

		// Collect ingredients
		AddObjective("collectKepa", "Collect Red Kepa Skins from Red Kepas",
			new CollectItemObjective(650463, 10));
		AddObjective("collectJukopus", "Collect Jukopus Cores from Jukopus",
			new CollectItemObjective(650464, 8));

		// Rewards
		AddReward(new ExpReward(800, 400));
		AddReward(new SilverReward(4000));
		AddReward(new ItemReward(640002, 8)); // HP potions
		AddReward(new ItemReward(640005, 8)); // SP potions
		AddReward(new ItemReward(926009, 1)); // Recipe - Miner Hammer
		AddReward(new ItemReward(640080, 5)); // Lv1 EXP Cards
	}

	public override void OnComplete(Character character, Quest quest)
	{
		// Remove quest items
		character.Inventory.Remove(650463, character.Inventory.CountItem(650463), InventoryItemRemoveMsg.Destroyed);
		character.Inventory.Remove(650464, character.Inventory.CountItem(650464), InventoryItemRemoveMsg.Destroyed);
	}

	public override void OnCancel(Character character, Quest quest)
	{
		// Remove quest items
		character.Inventory.Remove(650463, character.Inventory.CountItem(650463), InventoryItemRemoveMsg.Destroyed);
		character.Inventory.Remove(650464, character.Inventory.CountItem(650464), InventoryItemRemoveMsg.Destroyed);
	}
}

// Quest 1003: Ancient Sword Pieces
//-----------------------------------------------------------------------------
public class FSiauliaiOutAncientRelicsQuest : QuestScript
{
	protected override void Load()
	{
		SetId("f_siauliai_out", 1003);
		SetName("Fragments of the Ancient Blade");
		SetDescription("Help Mysterious Trader Rokas retrieve three pieces of an ancient broken sword hidden around Miner's Village. Search the village to find the legendary sword fragments.");
		SetLocation("f_siauliai_out");
		SetAutoTracked(true);

		SetReceive(QuestReceiveType.Manual);
		SetCancelable(true);
		SetUnlock(QuestUnlockType.AllAtOnce);
		AddQuestGiver("[Mysterious Trader] Rokas", "f_siauliai_out");

		// Collect broken sword pieces
		AddObjective("collectSwordPieces", "Collect broken sword pieces hidden around the village",
			new CollectItemObjective(650522, 3));

		// Rewards
		AddReward(new ExpReward(900, 600));
		AddReward(new SilverReward(12000));
		AddReward(new ItemReward(640100, 10)); // Small Recovery potions
		AddReward(new ItemReward(640080, 6)); // Lv1 EXP Cards
	}

	public override void OnComplete(Character character, Quest quest)
	{
		// Remove quest items
		character.Inventory.Remove(650522, character.Inventory.CountItem(650522), InventoryItemRemoveMsg.Destroyed);

		// Clear collection flags
		character.Variables.Perm.Remove("Melia.Quests.f_siauliai_out.Quest1003.SwordPiece1");
		character.Variables.Perm.Remove("Melia.Quests.f_siauliai_out.Quest1003.SwordPiece2");
		character.Variables.Perm.Remove("Melia.Quests.f_siauliai_out.Quest1003.SwordPiece3");
	}

	public override void OnCancel(Character character, Quest quest)
	{
		// Remove quest items
		character.Inventory.Remove(650522, character.Inventory.CountItem(650522), InventoryItemRemoveMsg.Destroyed);

		// Clear collection flags
		character.Variables.Perm.Remove("Melia.Quests.f_siauliai_out.Quest1003.SwordPiece1");
		character.Variables.Perm.Remove("Melia.Quests.f_siauliai_out.Quest1003.SwordPiece2");
		character.Variables.Perm.Remove("Melia.Quests.f_siauliai_out.Quest1003.SwordPiece3");
	}
}

// Quest 1004: Lost Pendant
//-----------------------------------------------------------------------------
public class FSiauliaiOutLostPendantQuest : QuestScript
{
	protected override void Load()
	{
		SetId("f_siauliai_out", 1004);
		SetName("A Father's Memory");
		SetDescription("Search Miner's Village for Magnus's lost copper pendant - a precious family heirloom that means everything to the retired adventurer.");
		SetLocation("f_siauliai_out");
		SetAutoTracked(true);

		SetReceive(QuestReceiveType.Manual);
		SetCancelable(true);
		SetUnlock(QuestUnlockType.AllAtOnce);
		AddQuestGiver("[Retired Adventurer] Magnus", "f_siauliai_out");

		// Find the pendant
		AddObjective("findPendant", "Find Magnus's copper pendant in the village",
			new CollectItemObjective(664156, 1));

		// Rewards
		AddReward(new ExpReward(400, 300));
		AddReward(new SilverReward(1500));
		AddReward(new ItemReward(640002, 4)); // HP potions
		AddReward(new ItemReward(640005, 4)); // SP potions
		AddReward(new ItemReward(640005, 1)); // Leather Sword
		AddReward(new ItemReward(640080, 2)); // Lv1 EXP Cards
	}

	public override void OnComplete(Character character, Quest quest)
	{
		// Remove quest items
		character.Inventory.Remove(664156, character.Inventory.CountItem(664156), InventoryItemRemoveMsg.Destroyed);
	}

	public override void OnCancel(Character character, Quest quest)
	{
		// Remove quest items
		character.Inventory.Remove(664156, character.Inventory.CountItem(664156), InventoryItemRemoveMsg.Destroyed);
	}
}

// =====================================================================
// EASTWOOD VILLAGE RUINS (Quest: Klaipeda/1005)
// =====================================================================
// SEVERE CURSE: This script petrifies the users in the area every
// few seconds.
// =====================================================================
public class FSiauliaiOutPetrificationZoneScript : GeneralScript
{
	// Configuration - Adjust these values as needed
	//-------------------------------------------------------------------------

	// Center of the petrification zone
	private readonly Position ZoneCenter = new Position(1807, 148, 341);

	// Radius of the zone in units
	private readonly float ZoneRadius = 400f;

	// How often to check and apply the debuff (in seconds)
	private readonly int CheckIntervalSeconds = 15;

	// Duration of the Petrification debuff (in seconds)
	private readonly int DebuffDurationSeconds = 3;

	// Buff level (affects strength of the debuff)
	private readonly int DebuffLevel = 1;

	//-------------------------------------------------------------------------

	private Timer _petrificationTimer;
	private Map _targetMap;

	protected override void Load()
	{
		// Get the map reference
		if (!ZoneServer.Instance.World.TryGetMap("f_siauliai_out", out var map))
		{
			Log.Error("Petrification Zone Script: Map 'f_siauliai_out' not found.");
			return;
		}

		_targetMap = map;

		// Start the periodic check timer
		_petrificationTimer = new Timer(
			CheckAndApplyPetrification,
			null,
			TimeSpan.FromSeconds(CheckIntervalSeconds),
			TimeSpan.FromSeconds(CheckIntervalSeconds)
		);
	}

	private void CheckAndApplyPetrification(object state)
	{
		if (_targetMap == null)
			return;

		try
		{
			// Get all characters currently on the map
			var characters = _targetMap.GetCharacters();

			foreach (var character in characters)
			{
				// Skip if character is dead
				if (character.IsDead)
					continue;

				// Calculate distance from zone center
				var distance = character.Position.Get2DDistance(ZoneCenter);

				// If character is within the zone radius, apply Petrification
				if (distance <= ZoneRadius)
				{
					character.StartBuff(
						BuffId.Petrification,
						DebuffLevel,
						0,
						TimeSpan.FromSeconds(DebuffDurationSeconds),
						character
					);
				}
			}
		}
		catch (Exception ex)
		{
			Log.Error($"Error in Petrification Zone: {ex.Message}");
		}
	}
}
