﻿//--- Melia Script ----------------------------------------------------------
// Klaipeda NPCs
//--- Description -----------------------------------------------------------
// NPCs found in and around Klaipeda.
//---------------------------------------------------------------------------

using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class CKlaipeNpcScript : GeneralScript
{
	public override void Load()
	{
		// Equipment Merchant
		//-------------------------------------------------------------------------

		AddNpc(20111, "[Equipment Merchant] Dunkel", "c_Klaipe", 394, -475, 90.0, async dialog =>
		{
			dialog.SetTitle("Dunkel");
			dialog.SetPortrait("KLAPEDA_Akalabeth_basic28");

			var response = await dialog.Select("A lot of people seem to be coming thanks to Sir Uska's recruitment notice.{nl}Take a look around at your own pace without feeling anxious.",
				Option("Weapons", "weapon"),
				Option("Armor", "armor"),
				Option("Cancel", "cancel")
			);

			if (response == "weapon")
				await dialog.OpenShop("Klapeda_Weapon");
			else if (response == "armor")
				await dialog.OpenShop("Klapeda_Armor");
		});

		// Accessory Merchant
		//-------------------------------------------------------------------------

		AddNpc(20104, "[Accessory Merchant] Ronesa", "c_Klaipe", 269, -611, 90.0, async dialog =>
		{
			dialog.SetTitle("Ronesa");
			dialog.SetPortrait("Alfonso_Select_1");

			await dialog.Msg("Welcome.{nl}Only hard-to-find stuff here.");
			await dialog.OpenShop("Klapeda_Accessory");
		});

		// Klaipeda Girl
		//-------------------------------------------------------------------------

		AddNpc(20104, "Klaipeda Girl", "c_Klaipe", -225.8313, -848.0712, 90.0, async dialog =>
		{
			dialog.SetPortrait("KLAFEDA_NPC_05_basic01");

			if (Random(2) == 0)
				await dialog.Msg("I heard the town men can't make their way back because of the monsters.{nl}We have food but it will run out soon...");
			else
				await dialog.Msg("My father told me Klaipeda is also becoming a difficult place to live.{np}There are many people who want to buy things but it's not easy to get what they want.{nl}We have enough food supplies for now but it won't last long.");
		});

		// Worried Wife
		// Tells stories about the various goddesses.
		//-------------------------------------------------------------------------

		AddNpc(20147, "Worried Wife", "c_Klaipe", -107.036, -749.1073, 180.0, async dialog =>
		{
			dialog.SetPortrait("KLAPEDA_NPC_04_basic01");

			var response = await dialog.Select("As you may already know, our kingdom has five major goddesses and other goddesses who{nl}assist them. But nobody knows where all of them are now.",
				Option("Regarding the five goddesses", "goddesses"),
				Option("Leave", "leave")
			);

			while (response != "leave")
			{
				response = await dialog.Select("As you may know, the five goddesses are Laima, Zemyna, Vakarine, Gabija and Ausrine.",
					Option("About Goddess Ausrine", "ausrine"),
					Option("About Goddess Laima", "laima"),
					Option("About Goddess Gabija", "gabija"),
					Option("About Goddess Zemyna", "zemyna"),
					Option("About Goddess Vakarine", "vakarine"),
					Option("Leave", "leave")
				);

				switch (response)
				{
					case "ausrine":
						await dialog.Msg("Morning dawns after night, does it not? Goddess Ausrine is the one who brings us morning. {nl}Not only that, when we die, we go to her as well.");
						break;
					case "laima":
						await dialog.Msg("Goddess Laima... Actually, I don't know her that well. No one does, except for her priests. {nl}I heard she's the goddess of fate and foresight, but she has not once appeared before us.");
						break;
					case "gabija":
						await dialog.Msg("I pray to Goddess Gabija everyday. It keeps the house warm.{nl}As you may already know, Goddess Gabija controls fire and since I'm a housewife,{nl}I am close to fire as well.");
						break;
					case "zemyna":
						await dialog.Msg("My husband always prays to Goddess Zemyna.{nl}We can't afford getting on Her wrong side if we want our potatoes to grow.{nl}Zemyna is the goddess of the earth. She looks after the crops.{np}Speaking of which.{nl}About the plants overgrowing ever since Medzio Diena four years ago");
						break;
					case "vakarine":
						await dialog.Msg("Have you ever seen the stars glittering red in the night sky?{nl}That's the very symbol of Goddess Vakarine.{nl}She leads the evening star and wakes Goddess Ausrine the following day.{np}She also oversees energy and rest, so she is the guardian of travelers like you.{nl}Shout Goddess Vakarine's name three times when your legs hurt and you'll feel much better.");
						break;
				}
			}
		});

		// Swordsman Master
		// Swordsman ability trainer.
		//-------------------------------------------------------------------------

		AddNpc(20023, "[Swordsman Master] Rashua", "c_Klaipe", -92, 784, -45.0, async dialog =>
		{
			dialog.SetTitle("Rashua");
			dialog.SetPortrait("MASTER_SWORDMAN_basic2");

			await dialog.Msg("The capital may already be in ruins, but I will protect Klaipeda.");
		});
	}
}
