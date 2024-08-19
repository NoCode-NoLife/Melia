using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Scouts.BulletMaker
{
	/// <summary>
	/// Handles the Bullet Maker's skill Freeze Bullet.
	/// </summary>
	[SkillHandler(SkillId.Bulletmarker_FreezeBullet)]
	public class FreezeBullet : ISelfSkillHandler
	{
		/// <summary>
		/// Handles the skill, applies a buff to self
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Direction dir)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			caster.StartBuff(BuffId.FreezeBullet_Buff, 1, 0, this.GetBuffDuration(skill), caster);

			Send.ZC_SKILL_READY(caster, skill, originPos, originPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, originPos, caster.Direction, Position.Zero);
			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster, null);
		}

		/// <summary>
		/// Returns the FreezeBullet Buff duration
		/// </summary>
		/// <param name="skill"></param>
		private TimeSpan GetBuffDuration(Skill skill)
		{
			return TimeSpan.FromSeconds(15 + skill.Level);
		}
	}
}
