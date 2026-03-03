using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Gacha;
using Melia.Zone.World.Items;

namespace ScriptsZone.items
{
	public class GoddessBlessedCubesScript : GeneralScript
	{
		private readonly static Dictionary<string, GachaMachine> Machines = new();

		[ScriptableFunction]
		public void GACHA_SCP_GACHA_HAIRACC_001(Character character, Item item, string className, bool skipAnimation, int pullCount)
		{
			if (!Machines.TryGetValue(className, out var machine))
			{
				Machines[className] = machine = new GachaMachine(className, GachaMachineType.Capsule);

				machine.AddEntry(new GachaEntry("Drug_RedApple100_TA", 6, GachaRarity.Common));
				machine.AddEntry(new GachaEntry("Drug_BlueApple100_TA", 3, GachaRarity.Common));
				machine.AddEntry(new GachaEntry("Premium_repairPotion_TA", 2, GachaRarity.Common));
				machine.AddEntry(new GachaEntry("Drug_MSPD2_1h_TA", 2, GachaRarity.Common));
				machine.AddEntry(new GachaEntry("Hat_628174", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628255", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628195", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628193", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628196", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628205", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628237", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628270", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628271", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628272", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628273", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628274", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628275", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628276", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628277", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628278", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628279", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628280", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628281", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628282", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628283", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628284", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628285", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628286", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628287", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628288", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628289", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628256", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628181", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628230", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628101", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628202", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628197", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628207", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628241", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628261", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628245", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628180", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628206", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628110", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628248", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628115", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628231", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628189", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628182", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628203", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628260", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628219", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628227", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Hat_628246", 1, GachaRarity.Rare));
				machine.AddEntry(new GachaEntry("Moru_Gold_TA", 1, GachaRarity.SuperRare));
				machine.AddEntry(new GachaEntry("Moru_Silver_TA", 1, GachaRarity.SuperRare));
				machine.AddEntry(new GachaEntry("misc_gemExpStone_5000_TA", 1, GachaRarity.SuperRare));

				machine.AutoWeight(50, 11);
			}

			var animationSpeed = 1;
			if (skipAnimation)
				animationSpeed = 0;

			machine.Pull(character, pullCount, animationSpeed);
			character.Inventory.Remove(item, 1, InventoryItemRemoveMsg.Used);
		}
	}
}
