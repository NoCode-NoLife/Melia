using System;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills.Combat;
using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors;
using Melia.Zone.Skills.Handlers.Archers.Wugushi;

namespace Melia.Zone.Buffs.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handle for the Virus Debuff, which ticks damage while active.
	/// </summary>
	[BuffHandler(BuffId.Virus_Debuff)]
	public class Virus_Debuff : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			var damageTickDelay = buff.Data.UpdateTime;

			Crescendo_Bane_Buff.TryApply(buff.Caster, ref damageTickDelay);

			buff.UpdateTime = damageTickDelay;
		}

		public override void WhileActive(Buff buff)
		{
			var target = buff.Target;

			if (target.Hp > 0)
			{
				if (!buff.Caster.TryGetSkill(buff.SkillId, out var skill))
					return;

				if (!buff.Vars.GetBool("Virus_Debuff.CrescendoBaneBuff"))
				{
					buff.Vars.SetBool("Virus_Debuff.CrescendoBaneBuff", this.TryApplyCrescendoBaneBuff(buff));
				}

				Wugushi_WugongGu.BuffDealsDamage(buff, skill);
			}
			else
			{
				const int maxSpreadAmount = 5;

				// Spreads to nearby targets
				foreach (var spreadTarget in target.Map.GetAttackableEntitiesInRange(buff.Caster, target.Position, 25).LimitRandom(maxSpreadAmount))
				{
					spreadTarget.StartBuff(BuffId.Virus_Debuff, buff.NumArg1, buff.NumArg2, TimeSpan.FromSeconds(10), buff.Caster);
				}
			}
		}

		/// <summary>
		/// Returns true if CrescendoBane is active and UpdateTime was modified
		/// </summary>
		/// <param name="buff"></param>
		private bool TryApplyCrescendoBaneBuff(Buff buff)
		{
			var damageTickDelay = buff.Data.UpdateTime;
			var applied = Crescendo_Bane_Buff.TryApply(buff.Caster, ref damageTickDelay);
			buff.UpdateTime = damageTickDelay;
			return applied;
		}
	}
}
