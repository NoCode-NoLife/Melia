using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Items;

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
			if (buff.Caster is Character casterCharacter)
			{
				// It is not applied to characters without Gloves
				if (buff.Caster is Character targetCaster && !(targetCaster.Inventory.GetEquip(EquipSlot.Gloves) is DummyEquipItem))
				{
					// Apply penalty when the CASTER Max Physical Attack is lower than the TARGET Max Physical Attack
					// TODO: Find out the exactly value of the penalty (We are applying 50%)
					var casterMaxPAtk = casterCharacter.Properties.GetFloat(PropertyName.MAXPATK);
					var targetMaxPAtk = targetCaster.Properties.GetFloat(PropertyName.MAXPATK);
					var penaltyValue = casterMaxPAtk < targetMaxPAtk ? 0.5f : 1f;

					var skillLevel = buff.NumArg1;

					var data = ZoneServer.Instance.Data.SkillDb.Find("Enchanter_EnchantGlove");

					var initialHitRateBonus = data.Factor + (skillLevel * data.FactorByLevel);
					var hitRateBonus = initialHitRateBonus * penaltyValue;

					if (casterCharacter.Components.Get<AbilityComponent>().Has(AbilityId.Enchanter9))
					{
						var SCR_Get_SkillFactor = ScriptableFunctions.Skill.Get("SCR_Get_SkillFactor");
						if (casterCharacter.Skills.TryGet(buff.SkillId, out var skill))
						{
							var abilityBonus = SCR_Get_SkillFactor(skill);
							hitRateBonus += abilityBonus;
						}
					}

					if (casterCharacter.Components.Get<AbilityComponent>().Has(AbilityId.Enchanter14))
					{
						var SCR_Get_SkillFactor = ScriptableFunctions.Skill.Get("SCR_Get_SkillFactor");
						casterCharacter.Skills.TryGet(buff.SkillId, out var skill);
						if (skill != null)
						{
							var abilityBonus = SCR_Get_SkillFactor(skill);
							hitRateBonus += abilityBonus;
						}
					}

					buff.Vars.SetFloat(VarName, hitRateBonus);

					buff.Target.Properties.Modify(PropertyName.HR_BM, hitRateBonus);
				}
			}
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Target is Character)
			{
				if (buff.Vars.TryGetFloat(VarName, out var bonus))
				{
					buff.Target.Properties.Modify(PropertyName.HR_BM, -bonus);
				}
			}
		}
	}
}
