using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Components;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handle for the Freeze Debuff
	/// </summary>
	[BuffHandler(BuffId.Freeze)]
	public class Freeze : BuffHandler, IBuffCombatDefenseBeforeCalcHandler
	{
		public override void OnExtend(Buff buff)
		{
			buff.Target.AddState(StateType.Stunned, buff.Duration);
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
			if (Feature.IsEnabled("FreezeAffectsElement"))
			{
				modifier.DefenseAttribute = AttributeType.Ice;
			}
		}
	}
}
