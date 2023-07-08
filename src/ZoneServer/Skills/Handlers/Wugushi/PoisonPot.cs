using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.Skills.Combat;
using System.Collections.Generic;
using System.Threading;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Enchanter
{
	/// <summary>
	/// Handler for the Wugushi skill Poison Pot.
	/// </summary>
	[SkillHandler(SkillId.Wugushi_ThrowGuPot)]
	public class PoisonPot : IGroundSkillHandler
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

			if (!caster.Position.InRange2D(farPos, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, farPos, caster.Position.GetDirection(farPos), Position.Zero);
			Send.ZC_NORMAL.Skill_6(caster as Character, "I_archer_poison_pot_force#Bip01 R Hand", 0.5f, "", 1, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);

			// Start the task
			Task.Run(() => AreaOfEffect(skill, caster, farPos));
		}

		async Task AreaOfEffect(Skill skill, ICombatEntity caster, Position farPos)
		{
			await Task.Delay(600);

			Send.ZC_NORMAL.Skill_59(caster as Character, "Archer_VerminPot", skill.Id, farPos, caster.Position.GetDirection(farPos), true);

			// Radius seems precise
			var radius = 45;
			var center = farPos.GetRelative(farPos, radius);
			var splashArea = new Circle(center, radius);

			using (var cancellationTokenSource = new CancellationTokenSource())
			{
				cancellationTokenSource.CancelAfter(TimeSpan.FromSeconds(15));

				while (!cancellationTokenSource.IsCancellationRequested)
				{
					// Attack targets
					var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

					var hits = new List<SkillHitInfo>();

					foreach (var target in targets.LimitRandom(6))
					{
						if (!target.Components.Get<BuffComponent>().Has(BuffId.Archer_VerminPot_Debuff))
						{
							target.StartBuff(BuffId.Archer_VerminPot_Debuff, TimeSpan.FromSeconds(15), caster, skill);
						}
					}

					await Task.Delay(200);
				}

				Send.ZC_NORMAL.Skill_59(caster as Character, "Archer_VerminPot", skill.Id, farPos, caster.Position.GetDirection(farPos), false);
			}
		}
	}
}
