using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Items;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Agility Buff, which increases the target's movement speed.
	/// </summary>
	[BuffHandler(BuffId.Agility_Buff)]
	public class Agility_Buff : BuffHandler
	{
		private const string VarNameMVSD = "Melia.MovementSpeedBonus";
		private const string VarNameSTA = "Melia.StaminaRateBonus";

		public override void OnStart(Buff buff)
		{
			var target = buff.Target as Character;

			// It is not applyed to characters without Shoes
			if (target != null && !(target.Inventory.GetEquip(EquipSlot.Shoes) is DummyEquipItem))
			{
				var skillLevel = buff.NumArg1;
				var caster = buff.Caster as Character;

				// Algorithm retrieved from client files.
				var speedBonus = 1 + (skillLevel * 0.3);

				if (caster != null && caster.Components.Get<AbilityComponent>().Has(AbilityId.Enchanter10))
				{
					var abilityBonus = buff.NumArg2;
					speedBonus += abilityBonus;
				}

				var staminaRateBonus = -0.5f;

				buff.Vars.SetFloat(VarNameMVSD, (float)speedBonus);
				buff.Vars.SetFloat(VarNameSTA, (float)staminaRateBonus);

				target.Properties.Modify(PropertyName.MSPD_BM, (float)speedBonus);
				target.Properties.Modify(PropertyName.MOVESTA_RATE_BM, (float)staminaRateBonus);

				Send.ZC_MOVE_SPEED(target);
			}
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Target is Character character)
			{
				var target = buff.Target as Character;

				if (buff.Vars.TryGetFloat(VarNameMVSD, out var bonus))
				{
					buff.Target.Properties.Modify(PropertyName.MSPD_BM, -bonus);
				}

				if (buff.Vars.TryGetFloat(VarNameSTA, out var bonusStamina))
				{
					buff.Target.Properties.Modify(PropertyName.MOVESTA_RATE_BM, bonusStamina);
				}

				Send.ZC_MOVE_SPEED(character);
			}
		}
	}
}
