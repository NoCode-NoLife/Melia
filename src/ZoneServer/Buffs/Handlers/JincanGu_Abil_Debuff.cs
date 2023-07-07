using System.Threading.Tasks;
using System.Threading;
using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.Skills.Combat;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Virus Debuff, which ticks damage every second.
	/// </summary>
	[BuffHandler(BuffId.JincanGu_Abil_Debuff)]
	public class JincanGu_Abil_Debuff : BuffHandler
	{
		public override void WhileActive(Buff buff)
		{
			var casterCharacter = buff.Caster as Character;

			if (casterCharacter != null)
			{
				// The damage amount is unknow, for now we are dealing the same amount as the original skill hit
				// TODO: Update this and make it do poison type damage
				var skillHitResult = SCR_SkillHit(casterCharacter, buff.Target, buff.Skill);
				buff.Target.TakeDamage(skillHitResult.Damage, casterCharacter);

				var hit = new HitInfo(casterCharacter, buff.Target, buff.Skill, skillHitResult.Damage, skillHitResult.Result);
				hit.ForceId = ForceId.GetNew();

				Send.ZC_HIT_INFO(casterCharacter, buff.Target, buff.Skill, hit);
			}
		}
	}
}
