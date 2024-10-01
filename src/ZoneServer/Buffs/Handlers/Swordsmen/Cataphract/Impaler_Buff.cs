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
	/// Buff handler for Impaler Buff, which triggers the slam portion of Impaler.
	/// It needs to end if the skewered monster dies
	/// </summary>
	/// <remarks>
	/// caster in this case is the skewer monster
	/// </remarks>
	[BuffHandler(BuffId.Impaler_Buff)]
	public class Impaler_Buff : BuffHandler
	{
		/// <summary>
		/// Ends the buff, activating the overheat
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;
			
			if (target.TryGetSkill(SkillId.Cataphract_Impaler, out var skill))
			{
				skill.IncreaseOverheat();
			}
		}


		/// <summary>
		/// Checks to see if the entity died
		/// </summary>
		/// <param name="buff"></param>
		public override void WhileActive(Buff buff)
		{
			var caster = buff.Caster;
			var target = buff.Target;

			if (caster.IsDead)
				target.StopBuff(BuffId.Impaler_Buff);
		}
	}


}
