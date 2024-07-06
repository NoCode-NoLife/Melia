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
			if (buff.Target is Character targetCharacter)
			{
				// It is not applied to characters without Shoes
				if (!(targetCharacter.Inventory.GetEquip(EquipSlot.Shoes) is DummyEquipItem))
				{
					var skillLevel = buff.NumArg1;

					// formula retrieved from client files.
					var speedBonus = 1 + (skillLevel * 0.3);

					if (buff.Caster is Character)
					{
						var characterCaster = buff.Caster as Character;

						if (characterCaster.Components.Get<AbilityComponent>().Has(AbilityId.Enchanter10))
						{
							var abilityBonus = buff.NumArg2;
							speedBonus += abilityBonus;
						}
					}

					var staminaRateBonus = (5 + skillLevel) / 100;

					buff.Vars.SetFloat(VarNameMVSD, (float)speedBonus);
					buff.Vars.SetFloat(VarNameSTA, (float)staminaRateBonus);

					targetCharacter.Properties.Modify(PropertyName.MSPD_BM, (float)speedBonus);
					targetCharacter.Properties.Modify(PropertyName.MOVESTA_RATE_BM, (float)staminaRateBonus);

					Send.ZC_MOVE_SPEED(targetCharacter);
				}
			}
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Target is Character targetCharacter)
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

				Send.ZC_MOVE_SPEED(targetCharacter);
			}
		}
	}
}
