using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Matador
{
	/// <summary>
	/// Handler for the Matador skill Capote
	/// </summary>
	[SkillHandler(SkillId.Matador_Capote)]
	public class Matador_Capote : ISelfSkillHandler
	{
		private const int MaxTargets = 10;

		/// <summary>
		/// Handles skill, applies a threat debuff to nearby monsters
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

			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, dir, Position.Zero);
			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster, null);

			var splashArea = new Circle(caster.Position, 400);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			foreach (var target in targets.LimitRandom(MaxTargets))
			{
				if (target.IsBuffActive(BuffId.ProvocationImmunity_Debuff))
					continue;

				target.StartBuff(BuffId.Capote_Debuff, 0, 0, this.GetAggroDebuffDuration(skill), caster);
				target.StartBuff(BuffId.ProvocationImmunity_Debuff, 0, 0, TimeSpan.FromSeconds(30), caster);
			}
		}

		/// <summary>
		/// Returns the Capote Debuff (aggro) duration
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		private TimeSpan GetAggroDebuffDuration(Skill skill)
		{
			return TimeSpan.FromSeconds(10 + (skill.Level));
		}
	}
}
