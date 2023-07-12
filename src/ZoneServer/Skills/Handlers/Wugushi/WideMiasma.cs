using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.Skills.Combat;
using System.Collections.Generic;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Enchanter
{
	/// <summary>
	/// Handler for the Wugushi skill Golden Frog.
	/// </summary>
	[SkillHandler(SkillId.Wugushi_WideMiasma)]
	public class WideMiasma : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, creates an area of effect that damages the enemies inside
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="designatedTarget"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);
			caster.StartBuff(BuffId.WideMiasma_Buff, skill.Level, 0, TimeSpan.FromSeconds(10), caster);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Position.GetDirection(caster.Position), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, null);

			// Radius seems precise
			var radius = 150;
			var center = caster.Position.GetRelative(caster.Position, radius);
			var splashArea = new Circle(center, radius);

			// Start the task
			this.Attack(skill, caster, splashArea);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async void Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			await Task.Delay(TimeSpan.FromSeconds(1));

			Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

			// Attack targets
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			var hits = new List<SkillHitInfo>();

			foreach (var target in targets.LimitRandom(10))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);

				Send.ZC_SHOW_EMOTICON(target, "shootpad_spector", TimeSpan.FromMilliseconds(2000));
				target.StartBuff(BuffId.WideMiasma_Debuff, skill.Level, skillHitResult.Damage, TimeSpan.FromSeconds(15), caster);
				target.StartBuff(BuffId.DecreaseHeal_Debuff, skill.Level, skillHitResult.Damage, TimeSpan.FromSeconds(20), caster);
			}
		}
	}
}
