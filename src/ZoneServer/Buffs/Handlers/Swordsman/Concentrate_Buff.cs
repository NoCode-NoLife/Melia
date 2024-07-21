using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Concentrate Buff.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Bonus Damage
	/// </remarks>
	[BuffHandler(BuffId.Concentrate_Buff)]
	public class Concentrate_Buff : BuffHandler
	{
		private const string HitsVarName = "Melia.HitsLeft";

		public override void OnStart(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			var maxHitCount = skillLevel * 2;

			buff.Vars.SetFloat(HitsVarName, maxHitCount);
		}

		/// <summary>
		/// Adds bonus damage to the modifier if the attacker has the
		/// Concentrate buff.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		[ScriptableFunction]
		public static float SCR_Combat_BeforeCalc_Concentrate_Buff(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!attacker.TryGetBuff(BuffId.Concentrate_Buff, out var concentrateBuff))
				return 0;

			if (!concentrateBuff.Vars.TryGetFloat(HitsVarName, out var hitsLeft))
				return 0;

			hitsLeft--;

			if (hitsLeft > 0)
				concentrateBuff.Vars.SetFloat(HitsVarName, hitsLeft);
			else
				attacker.StopBuff(BuffId.Concentrate_Buff);

			var bonusDamage = concentrateBuff.NumArg2;
			modifier.BonusDamage += bonusDamage;

			return 0;
		}
	}
}
