using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Yggdrasil.Logging;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Buff handler for Behead: Bleeding, which deals damage
	/// every 1.5 seconds
	/// </summary>
	[BuffHandler(BuffId.Behead_Debuff)]
	public class Behead_Debuff : BuffHandler
	{
		public override void WhileActive(Buff buff)
		{
			if (!buff.Target.IsDead) { 
				var skill = new Skill(buff.Caster, SkillId.Assassin_Behead_DOT, (int)buff.NumArg1);

				buff.Target.TakeDamage(buff.NumArg2, buff.Caster);
				var hit = new HitInfo(buff.Caster, buff.Target, skill, buff.NumArg2, HitResultType.Hit);
				Send.ZC_HIT_INFO(buff.Caster, buff.Target, skill, hit);
			}
		}
	}
}
