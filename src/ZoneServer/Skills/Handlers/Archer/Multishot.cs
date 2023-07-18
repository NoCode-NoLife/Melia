using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Extensions;
using Yggdrasil.Logging;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Archer
{
	/// <summary>
	/// Handler for the Archer skill Multishot.
	/// </summary>
	[SkillHandler(SkillId.Archer_Multishot)]
	public class Multishot : IGroundSkillHandler, IDynamicCasted
	{
		private const float SplashRadius = 30;
		private const int TotalHits = 10;
		private readonly static TimeSpan DelayBetweenHits = TimeSpan.FromMilliseconds(120);

		/// <summary>
		/// Called when the user starts casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
			Send.ZC_PLAY_SOUND(caster, "voice_archer_multishot_cast");
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			Send.ZC_STOP_SOUND(caster, "voice_archer_multishot_cast");
		}

		/// <summary>
		/// Handles skill, damaging targets.
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

			if (!caster.InSkillUseRange(skill, farPos))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			skill.IncreaseOverheat();
			caster.TurnTowards(farPos);
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			var splashArea = new Circle(farPos, SplashRadius);
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
			try
			{
				var hits = new List<SkillHitInfo>();

				for (var i = 0; i < TotalHits; ++i)
				{
					// TODO: Try to optimize this to not get all targets
					//   every time, though we might want/need that?
					var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
					var targetPos = splashArea.OriginPos;

					if (targets.Count != 0)
					{
						var target = targets.Random();
						if (!caster.CanAttack(target))
							continue;

						var skillHitResult = SCR_SkillHit(caster, target, skill);

						target.TakeDamage(skillHitResult.Damage, caster);
						targetPos = target.Position;

						var hit = new HitInfo(caster, target, skill, skillHitResult.Damage, skillHitResult.Result);
						Send.ZC_HIT_INFO(caster, target, skill, hit);
					}

					// It seems like the game uses ZC_SYNC_* packets
					// to control how and when packets such as this
					// are actually handled by the client instead of
					// sending them on precise timers, though timers
					// also seem to get employed... Needs more research.
					Send.ZC_NORMAL.SkillProjectile(caster, "I_arrow013_mash_yellow#Dummy_Force", TimeSpan.FromMilliseconds(600), "F_explosion092_hit", TimeSpan.FromMilliseconds(600), targetPos);

					if (i < TotalHits - 1)
						await Task.Delay(DelayBetweenHits);
				}

				Send.ZC_SKILL_DISABLE(caster as Character);
			}
			catch (Exception ex)
			{
				Log.Error("Multishot: Attack failed. Error: {0}", ex);
			}
		}
	}
}
