using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using static Melia.Shared.Util.TaskHelper;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Matador
{
	/// <summary>
	/// Handler for the Matador skill Back Slide
	/// </summary>
	[SkillHandler(SkillId.Matador_BackSlide)]
	public class Matador_BackSlide : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, dashes backwards
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

			Send.ZC_SKILL_READY(caster, skill, caster.Position, Position.Zero);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, dir, Position.Zero);
			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster, null);

			caster.StartBuff(BuffId.BackSlide_MomentaryEvasion_Buff);

			CallSafe(this.AfterDash(skill, caster));
		}

		/// <summary>
		/// Handles skill, process after dash
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		private async Task AfterDash(Skill skill, ICombatEntity caster)
		{
			await Task.Delay(TimeSpan.FromMilliseconds(400));

			caster.StartBuff(BuffId.BackSlide_Buff, TimeSpan.FromSeconds(3));
			caster.StopBuff(BuffId.BackSlide_MomentaryEvasion_Buff);

			if (caster is Character character)
				Send.ZC_NORMAL.Unknow_7D(character, skill.Id);
		}
	}
}
