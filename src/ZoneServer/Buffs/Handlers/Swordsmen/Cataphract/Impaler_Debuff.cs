using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Cataphract
{
	/// <summary>
	/// Buff handler for Impaler Debuff, which reduces def and makes it
	/// impossible to block or dodge.
	/// This also needs to prevent you from taking any action
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Impaler_Debuff)]
	public class Impaler_Debuff : BuffHandler, IBuffCombatDefenseBeforeCalcHandler
	{
		public const float DefPenalty = 0.3f;

		/// <summary>
		/// Starts buff, attaching the entity to the spear
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;
			var caster = buff.Caster;

			var reduceDef = target.Properties.GetFloat(PropertyName.DEF) * DefPenalty;

			AddPropertyModifier(buff, target, PropertyName.DEF_BM, -reduceDef);

			Send.ZC_ATTACH_TO_OBJ(target, caster, "Dummy_Impaler", "", 0.01f, 1, 1, "", 1, 0, 1);
		}

		/// <summary>
		/// Ends the buff, freeing the entity
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;
			var caster = buff.Caster;

			RemovePropertyModifier(buff, target, PropertyName.DEF_BM);

			Send.ZC_DETACH_FROM_OBJ(target, caster);
		}


		/// <summary>
		/// Applies the debuff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnDefenseBeforeCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			modifier.Unblockable = true;
			modifier.ForcedHit = true;
		}
	}
}
