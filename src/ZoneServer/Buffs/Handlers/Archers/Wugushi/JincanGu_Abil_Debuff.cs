using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handle for the JincanGu Debuff (GoldenFrog), which ticks damage every second.
	/// </summary>
	/// <remarks>
	/// NumArg1: None
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.JincanGu_Abil_Debuff)]
	public class JincanGu_Abil_Debuff : BuffHandler
	{
		private const string AdditionalHitsDoneVar = "AdditionalHitsDone";
		private const int AdditionalHitsMaxCount = 5;

		public override void WhileActive(Buff buff)
		{
			if (buff.Target.IsDead)
				return;

			if (!buff.Caster.TryGetSkill(buff.SkillId, out var skill))
				return;

			buff.Target.TakeSkillHit(buff.Caster, skill);
			Crescendo_Bane_Buff.TryApply(buff);

			var additionalHitsDone = buff.Vars.GetInt(AdditionalHitsDoneVar);
			if (additionalHitsDone < AdditionalHitsMaxCount)
			{
				buff.Target.TakeSkillHit(buff.Caster, skill);
				buff.Vars.SetInt(AdditionalHitsDoneVar, additionalHitsDone + 1);
			}
		}
	}
}
