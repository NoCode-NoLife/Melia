using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
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
	public class Concentrate_Buff : BuffHandler, IBuffCombatBeforeCalcHandler
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
		public void OnBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!buff.Vars.TryGetFloat(HitsVarName, out var hitsLeft))
				return;

			if (--hitsLeft <= 0)
			{
				attacker.StopBuff(buff.Id);
				return;
			}

			buff.Vars.SetFloat(HitsVarName, hitsLeft);

			var bonusDamage = buff.NumArg2;
			modifier.BonusDamage += bonusDamage;
		}
	}
}
