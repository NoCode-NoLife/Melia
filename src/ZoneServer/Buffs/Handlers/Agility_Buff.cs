using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Agility Buff, which increases the target's movement speed.
	/// </summary>
	[BuffHandler(BuffId.Agility_Buff)]
	public class Agility_Buff : BuffHandler
	{
		private const string VarName = "Melia.MovementSpeedBonus";

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

				if (caster.Abilities.Has(AbilityId.Enchanter8))
				{
					var ability = caster.Abilities.Get(AbilityId.Enchanter8);
					var Src_ReinforceAbilityBonus = ScriptableFunctions.Ability.Get("Src_ReinforceAbilityBonus");
					var abilityBonus = Src_ReinforceAbilityBonus(ability, "Enchanter_Agility");
					speedBonus += abilityBonus;
				}

				if (caster.Abilities.Has(AbilityId.Enchanter10))
				{
					var ability = caster.Abilities.Get(AbilityId.Enchanter10);
					var Src_ReinforceAbilityBonus = ScriptableFunctions.Ability.Get("Src_ReinforceAbilityBonus");
					var abilityBonus = Src_ReinforceAbilityBonus(ability, "Enchanter_Agility");
					speedBonus += abilityBonus;
				}

				// TODO: Reduce the STAMINA consuption rate

				buff.Vars.SetFloat(VarName, (float)speedBonus);

				target.Properties.Modify(PropertyName.MSPD_BM, (float)speedBonus);

				Send.ZC_MOVE_SPEED(target);				
			}				
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Target is Character character)
			{
				var target = buff.Target as Character;

				if (buff.Vars.TryGetFloat(VarName, out var bonus))
				{
					buff.Target.Properties.Modify(PropertyName.MSPD_BM, -bonus);
				}

				Send.ZC_MOVE_SPEED(character);
			}				
		}
	}
}
