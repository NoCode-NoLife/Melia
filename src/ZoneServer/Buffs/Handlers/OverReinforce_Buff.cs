using System;
using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Over Reinforce Buff, which increases the target's physical and magic attack
	/// </summary>
	[BuffHandler(BuffId.OverReinforce_Buff)]
	public class OverReinforce_Buff : BuffHandler
	{
		private const string VarName = "Melia.MagicAndPhysicalAttackBonus";

		public override void OnStart(Buff buff)
		{
			var target = buff.Target as Character;

			if (target != null)
			{
				var caster = buff.Caster as Character;

				var maxpatk = caster.Properties.GetFloat(PropertyName.MAXPATK);
				var minpatk = caster.Properties.GetFloat(PropertyName.MINPATK);

				var skillLevel = buff.NumArg1;

				// Algorithm retrieved from client files.
				var rate = 0.015f + skillLevel * 0.004f;

				// TODO: check if vaivora 'ITEM_VIBORA_Empowering' is being used

				var attackBonus = ((maxpatk + minpatk) / 2) * rate;

				attackBonus = (float)Math.Floor(attackBonus);

				if (caster.Components.Get<AbilityComponent>().Has(AbilityId.Enchanter15))
				{
					var SCR_Get_SkillFactor = ScriptableFunctions.Skill.Get("SCR_Get_SkillFactor");
					if (caster.Skills.TryGet(buff.SkillId, out var skill))
					{
						var abilityBonus = SCR_Get_SkillFactor(skill);
						attackBonus += abilityBonus;
					}
				}

				buff.Vars.SetFloat(VarName, attackBonus);

				buff.Target.Properties.Modify(PropertyName.MATK_BM, attackBonus);
				buff.Target.Properties.Modify(PropertyName.PATK_BM, attackBonus);
			}
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target as Character;

			if (target != null)
			{
				if (buff.Vars.TryGetFloat(VarName, out var bonus))
				{
					buff.Target.Properties.Modify(PropertyName.MATK_BM, -bonus);
					buff.Target.Properties.Modify(PropertyName.PATK_BM, -bonus);
				}
			}
		}
	}
}
