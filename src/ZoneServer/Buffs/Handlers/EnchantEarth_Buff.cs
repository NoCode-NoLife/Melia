using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Enchant Earth Buff, which increases the target's block penetration
	/// </summary>
	[BuffHandler(BuffId.EnchantEarth_Buff)]
	public class EnchantEarth_Buff : BuffHandler
	{
		private const string VarName = "Melia.BlockPenetrationBonus";

		public override void OnStart(Buff buff)
		{
			var target = buff.Target as Character;

			if (target != null)
			{
				var caster = buff.Caster as Character;

				// Apply penality when the CASTER Max Physical Attack is lower than the TARGET Max Physical Attack
				// TODO: Find out the exacly value of the penality (We are applying 50%)
				var casterMaxPAtk = caster.Properties.GetFloat(PropertyName.MAXPATK);
				var targetMaxPAtk = target.Properties.GetFloat(PropertyName.MAXPATK);
				var penalityValue = casterMaxPAtk < targetMaxPAtk ? 0.5f : 1f;

				var skillLevel = buff.NumArg1;

				var data = ZoneServer.Instance.Data.SkillDb.Find(SkillId.Enchanter_EnchantEarth);
				// Level 1 => 5 + 1*1 = 6%
				var initialBlockPenBonus = data.Factor + (skillLevel * data.FactorByLevel);
				var blockPenetrationBonus = initialBlockPenBonus * penalityValue;

				if (caster.Components.Get<AbilityComponent>().Has(AbilityId.Enchanter10))
				{
					var SCR_Get_SkillFactor = ScriptableFunctions.Skill.Get("SCR_Get_SkillFactor");
					if (caster.Skills.TryGet(buff.SkillId, out var skill))
					{
						var abilityBonus = SCR_Get_SkillFactor(skill);
						blockPenetrationBonus += abilityBonus;
					}
				}

				buff.Vars.SetFloat(VarName, blockPenetrationBonus);

				buff.Target.Properties.Modify(PropertyName.BLK_BREAK_BM, blockPenetrationBonus);
			}
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target as Character;

			if (target != null)
			{
				if (buff.Vars.TryGetFloat(VarName, out var bonus))
				{
					buff.Target.Properties.Modify(PropertyName.BLK_BREAK_BM, -bonus);
				}
			}
		}
	}
}
