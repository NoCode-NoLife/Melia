using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills.Handlers.Archers.Wugushi;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handle for the WideMiasma Debuff, which ticks damage every second.
	/// </summary>
	[BuffHandler(BuffId.WideMiasma_Debuff)]
	public class WideMiasma_Debuff : BuffHandler
	{
		public override void WhileActive(Buff buff)
		{
			if (buff.Target.IsDead)
				return;

			if (!buff.Caster.TryGetSkill(buff.SkillId, out var skill))
				return;

			if (!buff.Vars.GetBool("WideMiasma_Debuff.CrescendoBaneBuff"))
			{
				buff.Vars.SetBool("WideMiasma_Debuff.CrescendoBaneBuff", this.TryApplyCrescendoBaneBuff(buff));
			}

			Wugushi_WideMiasma.BuffDealsDamage(buff, skill);
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
