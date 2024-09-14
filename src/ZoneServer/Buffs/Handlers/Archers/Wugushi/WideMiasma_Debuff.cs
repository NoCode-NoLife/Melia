using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handle for the WideMiasma Debuff, which ticks damage every second.
	/// </summary>
	/// <remarks>
	/// NumArg1: None
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.WideMiasma_Debuff)]
	public class WideMiasma_Debuff : BuffHandler
	{
		public override void WhileActive(Buff buff)
		{
			if (buff.Target.IsDead)
				return;

			if (!buff.Caster.TryGetSkill(buff.SkillId, out var skill))
				return;

			buff.Target.TakeSkillHit(buff.Caster, skill);
			Crescendo_Bane_Buff.TryApply(buff);
		}
	}
}
