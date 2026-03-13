using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Swordsman
{
	/// <summary>
	/// Handle for the Concentrate Buff, which increases the damage of a
	/// certain number of attacks from the user.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: Bonus Damage
	/// </remarks>
	[BuffHandler(BuffId.Concentrate_Buff)]
	public class Concentrate_Buff : BuffHandler
	{
		private const string HitsVarName = "Melia.HitsLeft";

		/// <summary>
		/// Called every time the buff is activated, including overbuff.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="activationType"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
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
		[CombatCalcModifier(CombatCalcPhase.BeforeCalc, BuffId.Concentrate_Buff)]
		public void OnBeforeCalc(ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			// TODO: Move to a hit event handler, that is to be added,
			// to ensure this happens on actual hits and not during
			// calculations.

			if (!attacker.TryGetBuff(BuffId.Concentrate_Buff, out var buff))
				return;

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
