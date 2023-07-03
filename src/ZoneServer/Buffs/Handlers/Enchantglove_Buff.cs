using System.Collections.Generic;
using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Items;
using MySqlX.XDevAPI.Relational;
using static Mysqlx.Notice.Warning.Types;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Enchant Glove Buff, which increases the target's accuracy (Hit Rate)
	/// </summary>
	[BuffHandler(BuffId.Enchantglove_Buff)]
	public class Enchantglove_Buff : BuffHandler
	{
		private const string VarName = "Melia.HitRateBonus";

		public override void OnStart(Buff buff)
		{
			var target = buff.Target as Character;

			// It is not applyed to characters without Gloves
			if (target != null && !(target.Inventory.GetEquip(EquipSlot.Gloves) is DummyEquipItem))
			{
				var caster = buff.Caster as Character;

				// Apply penality when the CASTER Max Physical Attack is lower than the TARGET Max Physical Attack
				// TODO: Find out the exacly value of the penality (We are applying 50%)
				var casterMaxPAtk = caster.Properties.GetFloat(PropertyName.MAXPATK);
				var targetMaxPAtk = target.Properties.GetFloat(PropertyName.MAXPATK);
				var penalityValue = casterMaxPAtk < targetMaxPAtk ? 0.5f : 1f;

				var skillLevel = buff.NumArg1;

				var data = ZoneServer.Instance.Data.SkillDb.Find("Enchanter_EnchantGlove");

				var initialHitRateBonus = data.Factor + (skillLevel * data.FactorByLevel);
				var hitRateBonus = initialHitRateBonus * penalityValue;

				if (caster.Abilities.Has(AbilityId.Enchanter9))
				{
					var ability = caster.Abilities.Get(AbilityId.Enchanter9);
					var Src_ReinforceAbilityBonus = ScriptableFunctions.Ability.Get("Src_ReinforceAbilityBonus");
					var abilityBonus = Src_ReinforceAbilityBonus(ability, "Enchanter_EnchantGlove");
					hitRateBonus += abilityBonus;
				}

				if (caster.Abilities.Has(AbilityId.Enchanter14))
				{
					var ability = caster.Abilities.Get(AbilityId.Enchanter14);
					var Src_ReinforceAbilityBonus = ScriptableFunctions.Ability.Get("Src_ReinforceAbilityBonus");
					var abilityBonus = Src_ReinforceAbilityBonus(ability, "Enchanter_EnchantGlove");
					hitRateBonus += abilityBonus;
				}

				buff.Vars.SetFloat(VarName, hitRateBonus);

				buff.Target.Properties.Modify(PropertyName.HR_BM, hitRateBonus);
			}
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target as Character;

			if (target != null)
			{
				if (buff.Vars.TryGetFloat(VarName, out var bonus))
				{
					buff.Target.Properties.Modify(PropertyName.HR_BM, -bonus);
				}
			}
		}
	}
}
