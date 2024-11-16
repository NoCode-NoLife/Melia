using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Logging;
using Yggdrasil.Util;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archers.QuarrelShooter
{
	/// <summary>
	/// Handles the Quarrel Shooter skill Teardown
	/// </summary>
	[SkillHandler(SkillId.QuarrelShooter_Teardown)]
	public class QuarrelShooter_Teardown : IGroundSkillHandler
	{
		int[] enemyTargetIds = [47452, 58283, 58284, 58285, 58287, 57709, 57417, 46013, 58288, 800032, 800033, 800034, 800035, 800036, 800037, 800038, 800039, 800040, 800041];
		int[] friendlyTargetIds = [47452, 57417, 46013];
		private const float maxRange = 50f;

		/// <summary>
		/// Handles skill, insta-killing designated targets
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			if (target == null)
			{
				caster.ServerMessage(Localization.Get("No target."));
				return;
			}			

			if (target is Mob mob) //&& (caster.CanAttack(mob) && enemyTargetIds.Contains(mob.Data.Id) || friendlyTargetIds.Contains(mob.Data.Id)))
			{
				if (caster.Position.Get2DDistance(target.Position) > maxRange)
				{
					caster.ServerMessage(Localization.Get("Too far away."));
					return;
				}

				skill.IncreaseOverheat();
				caster.TurnTowards(target);
				caster.SetAttackState(true);

				CallSafe(this.Attack(skill, caster, mob));
			}
			else
			{
				caster.ServerMessage(Localization.Get("Invalid Target."));
				return;
			}
		}

		/// <summary>
		/// Destroys the target
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		private async Task Attack(Skill skill, ICombatEntity caster, Mob target)
		{
			var hitDelay = TimeSpan.FromMilliseconds(300);

			await Task.Delay(hitDelay);

			// TODO: Probably missing a packet here to display the death animation
			target.Kill(caster);
		}
	}
}
