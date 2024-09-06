using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills.Handlers.Archers.Wugushi;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handle for the JincanGu Debuff (GoldenFrog), which ticks damage every second.
	/// </summary>
	[BuffHandler(BuffId.JincanGu_Abil_Debuff)]
	public class JincanGu_Abil_Debuff : BuffHandler
	{
		private const string AdditionalHits = "Wugushi.JincanGu_Abil_Debuff";
		private const int AdditionalHitsCount = 5;

		public override void WhileActive(Buff buff)
		{
			if (buff.Target.IsDead)
				return;

			if (!buff.Caster.TryGetSkill(buff.SkillId, out var skill))
				return;

			if (!buff.Vars.GetBool("JincanGu_Abil_Debuff.CrescendoBaneBuff"))
			{
				buff.Vars.SetBool("JincanGu_Abil_Debuff.CrescendoBaneBuff", this.TryApplyCrescendoBaneBuff(buff));
			}

			Wugushi_JincanGu.BuffDealsDamage(buff, skill);
			var additionalHitsCount = buff.Vars.GetInt(AdditionalHits);

			// We are Damaging 5x additional hits
			if (additionalHitsCount <= AdditionalHitsCount && additionalHitsCount >= 1)
			{
				var remaningAdditionalHits = buff.Vars.GetInt(AdditionalHits);
				buff.Vars.SetInt(AdditionalHits, remaningAdditionalHits - 2);

				Wugushi_JincanGu.BuffDealsDamage(buff, skill);
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
