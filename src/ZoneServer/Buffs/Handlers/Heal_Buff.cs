using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for Heal_Buff, which is primarily triggered by Cleric_Heal.
	/// </summary>
	[BuffHandler(BuffId.Heal_Buff)]
	public class HealBuffHandler : BuffHandler
	{
		/// <summary>
		/// Starts the buff, healing the target.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			// According to the skill description of Heal, the healing
			// amount "depends on the caster's healing values", which
			// is unfortunately pretty vague. We also have a "Heal
			// Factor", which is 150% on skill level 1 and increases
			// with the skill level. I suspect there's more factors,
			// such as INT and MNA, but I can't say for sure.
			// So, we'll just make something up for now and wait until
			// the Cleric players complain that our numbers are horribly
			// wrong =)
			// 
			// Reference:
			// - Level 7 Cleric, Level 1 Heal, 7 INT, 14 MNA, 869 MHP: 57 Self Heal

			var caster = buff.Caster;
			var target = buff.Target;
			var ratio2 = buff.NumArg1;

			var healAmount = target.Properties.GetFloat(PropertyName.MHP) * 0.05f;
			healAmount *= ratio2 / 100f;

			if (caster.Components.Get<BuffComponent>().TryGet(BuffId.PatronSaint_Buff, out var patronSaitBuff))
			{
				var healBonus = patronSaitBuff.NumArg1 * 0.05f;
				healAmount *= 1f + healBonus;
			}

			target.Heal(healAmount, 0);

			var maxHp = target.Properties.GetFloat(PropertyName.MHP);
			Send.ZC_HEAL_INFO(target, healAmount, maxHp, HealType.Hp);
		}
	}
}
