using System.Linq;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handle for the Virus Debuff, which ticks damage while active.
	/// </summary>
	/// <remarks>
	/// NumArg1: None
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Virus_Debuff)]
	public class Virus_Debuff : BuffHandler
	{
		private const int MaxSpreadAmount = 5;
		private const int SpreadRange = 25;

		public override void WhileActive(Buff buff)
		{
			// Once the target is dead we spread the virus to nearby entities once
			if (buff.Target.IsDead)
			{
				if (!buff.Vars.ActivateOnce("Spread"))
					this.SpreadVirus(buff);

				return;
			}

			if (!buff.Caster.TryGetSkill(buff.SkillId, out var skill))
				return;

			buff.Target.TakeSkillHit(buff.Caster, skill);
			Crescendo_Bane_Buff.TryApply(buff);
		}

		private void SpreadVirus(Buff buff)
		{
			var targetsInRange = buff.Target.Map.GetAttackableEntitiesInRange(buff.Caster, buff.Target.Position, SpreadRange);
			var spreadTargets = targetsInRange.Where(a => !a.IsBuffActive(BuffId.Virus_Debuff));

			foreach (var spreadTarget in spreadTargets.LimitRandom(MaxSpreadAmount))
				spreadTarget.StartBuff(BuffId.Virus_Debuff, buff.NumArg1, buff.NumArg2, buff.Duration, buff.Caster, buff.SkillId);
		}
	}
}
