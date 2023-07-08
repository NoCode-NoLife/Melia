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
using static Melia.Zone.Skills.SkillUseFunctions;
using Melia.Zone.Skills.Combat;
using System.Threading;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Enchanter
{
	/// <summary>
	/// Handler for the Enchanter skill Enchant Aura.
	/// </summary>
	[SkillHandler(SkillId.Enchanter_EnchantAura)]
	public class EnchantAura : IGroundSkillHandler
	{
		private Task _areaOfEffect;
		private CancellationTokenSource _cancellationTokenSource;

		/// <summary>
		/// Handles the skill, creates an area of effect that damages the enemies inside
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			Send.ZC_NORMAL.Skill_88(caster as Character, skill);
			caster.SetAttackState(true);

			// Cancel the area of effect task
			if (_areaOfEffect != null)
			{
				Send.ZC_SKILL_CAST_CANCEL(caster);
				_cancellationTokenSource?.Cancel();
				_areaOfEffect = null;
				var character = caster as Character;
				if (character.Buffs.Has(BuffId.EnchantAura_Buff))
				{
					var buff = character.Buffs.Get(BuffId.EnchantAura_Buff);
					buff.End();
				}
				Send.ZC_NORMAL.Skill_59(character, "skl_eff_merkabah_dead", skill.Id, caster.Position, false);
				return;
			}

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);			
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Position.GetDirection(caster.Position), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, originPos, ForceId.GetNew(), null);

			// Create a new cancellation token source
			_cancellationTokenSource = new CancellationTokenSource();

			// Start the task
			_areaOfEffect = Task.Run(() => AreaOfEffect(_cancellationTokenSource.Token, skill, caster, caster.Position));
		}

		private async Task AreaOfEffect(CancellationToken cancellationToken, Skill skill, ICombatEntity caster, Position position)
		{
			await Task.Delay(TimeSpan.FromMilliseconds(200));

			var character = caster as Character;
			Send.ZC_NORMAL.Skill_59(character, "skl_eff_merkabah_dead", skill.Id, caster.Position, true);

			if (!character.Buffs.Has(BuffId.EnchantAura_Buff))
			{
				character.StartBuff(BuffId.EnchantAura_Buff, TimeSpan.FromMinutes(60));
			}

			while (true)
			{
				// Check if cancellation is requested
				if (cancellationToken.IsCancellationRequested)
				{
					break;
				}

				// Delay for 3 seconds
				await Task.Delay(3000);

				// Cancel if the caster has not enough SP
				if (!caster.TrySpendSp(skill))
				{
					break;
				}

				// HardCoded for the moment, seems precisa tho
				var radius = 80;
				var center = position.GetRelative(position, radius);
				var splashArea = new Circle(center, radius);

				Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

				// Attack targets
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
				var damageDelay = TimeSpan.FromMilliseconds(150);


				foreach (var target in targets)
				{
					var skillHitResult = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult.Damage, caster);

					var hit = new HitInfo(caster, target, skill, skillHitResult.Damage, skillHitResult.Result);

					Send.ZC_HIT_INFO(caster, target, skill, hit);

					var skillHitResult2 = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult2.Damage, caster);

					var hit2 = new HitInfo(caster, target, skill, skillHitResult2.Damage, skillHitResult2.Result);

					Send.ZC_HIT_INFO(caster, target, skill, hit2);

					Send.ZC_GROUND_EFFECT(caster as Character, target, "SOLO_DUNGEON_MINI_ANCIENT_QUEST");
				}
			}
		}
	}
}
