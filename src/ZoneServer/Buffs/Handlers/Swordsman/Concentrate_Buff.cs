using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Concentrate Buff.
	/// </summary>
	[BuffHandler(BuffId.Concentrate_Buff)]
	public class Concentrate_Buff : BuffHandler
	{
		private const string HitsVarName = "Melia.HitsLeft";

		public override void OnStart(Buff buff)
		{
			var skillLevel = buff.NumArg1;

			buff.Vars.SetFloat(HitsVarName, skillLevel * 2);
		}

		/// <summary>
		/// Adds bonus damage to the modifier if the attacker has the
		/// Concentrate buff.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="modifier"></param>
		public static void TryAddBonus(ICombatEntity attacker, SkillModifier modifier)
		{
			if (!attacker.Components.Get<BuffComponent>().TryGet(BuffId.Concentrate_Buff, out var concentrateBuff))
				return;

			if (!concentrateBuff.Vars.TryGetFloat(HitsVarName, out var hitsLeft))
				return;

			hitsLeft--;

			if (hitsLeft > 0)
				concentrateBuff.Vars.SetFloat(HitsVarName, hitsLeft);
			else
				attacker.Components.Get<BuffComponent>().Remove(BuffId.Concentrate_Buff);

			var bonusDamage = concentrateBuff.NumArg2;
			modifier.BonusDamage += bonusDamage;
		}
	}
}
