using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Characters;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Enchanter
{
	/// <summary>
	/// Handler for the Enchanter skill Enchant Aura.
	/// </summary>
	[SkillHandler(SkillId.Enchanter_EnchantAura)]
	public class EnchantAura : IGroundSkillHandler
	{
		private Dictionary<ICombatEntity, Task> _areasOfEffect = new Dictionary<ICombatEntity, Task>();
		private Dictionary<ICombatEntity, CancellationTokenSource> _cancellationTokensSource = new Dictionary<ICombatEntity, CancellationTokenSource>();

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

			Send.ZC_NORMAL.Skill_88(caster as Character, caster, skill);

			var castedPos = caster.Position;
			var effectId = ForceId.GetNew();
			Task areaOfEffect = null;

			if (_areasOfEffect.ContainsKey(caster))
				areaOfEffect = _areasOfEffect[caster];

			// Cancel the area of effect task
			if (areaOfEffect != null)
			{
				if (_areasOfEffect.ContainsKey(caster))
					_areasOfEffect.Remove(caster);

				if (_cancellationTokensSource.ContainsKey(caster))
					_cancellationTokensSource[caster].Cancel();

				this.RemoveSkillEffect(skill, caster, castedPos, effectId);
				return;
			}

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);			
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Position.GetDirection(caster.Position), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, originPos, ForceId.GetNew(), null);

			// Create a new cancellation token source
			var cancellationTokenSource = new CancellationTokenSource();

			if (!_cancellationTokensSource.ContainsKey(caster))
				_cancellationTokensSource.Add(caster, cancellationTokenSource);

			// Start the task
			var newAreaOfEffect = Task.Run(() => AreaOfEffect(cancellationTokenSource.Token, skill, caster, castedPos, effectId));

			if (!_areasOfEffect.ContainsKey(caster))
				_areasOfEffect.Add(caster, newAreaOfEffect);
		}

		/// <summary>
		/// Area of effect that ticks dealing damage on the enemies inside
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="position"></param>
		/// <param name="effectId"></param>
		private async Task AreaOfEffect(CancellationToken cancellationToken, Skill skill, ICombatEntity caster, Position position, int effectId)
		{
			await Task.Delay(TimeSpan.FromMilliseconds(200));

			var character = caster as Character;

			Send.ZC_NORMAL.GroundEffect_59(character, character.Direction, "Enchanter_EnchantAura", skill.Id, caster.Position, effectId, true);

			var radius = 80;
			var center = position.GetRelative(position, radius);
			var splashArea = new Circle(center, radius);

			Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

			if (!character.Buffs.Has(BuffId.EnchantAura_Buff))
			{
				character.StartBuff(BuffId.EnchantAura_Buff, TimeSpan.Zero);
			}

			await Task.Delay(TimeSpan.FromSeconds(1));

			while (true)
			{
				// Check if cancellation is requested
				if (cancellationToken.IsCancellationRequested)
				{
					if (_cancellationTokensSource.ContainsKey(caster))
						_cancellationTokensSource.Remove(caster);

					this.RemoveSkillEffect(skill, caster, position, effectId);
					break;
				}

				await Task.Delay(2000);

				// Cancel if the caster has not enough SP
				if (!caster.TrySpendSp(skill))
				{
					this.RemoveSkillEffect(skill, caster, position, effectId);
					break;
				}

				// Attack targets
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
				var damageDelay = TimeSpan.FromMilliseconds(150);

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					var skillHitResult = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult.Damage, caster);

					var hit = new HitInfo(caster, target, skill, skillHitResult);

					Send.ZC_HIT_INFO(caster, target, skill, hit);

					if (!target.IsDead)
					{
						var skillHitResult2 = SCR_SkillHit(caster, target, skill);
						target.TakeDamage(skillHitResult2.Damage, caster);

						var hit2 = new HitInfo(caster, target, skill, skillHitResult2);

						Send.ZC_HIT_INFO(caster, target, skill, hit2);
					}
				}
			}
		}

		/// <summary>
		/// Removes the skill effect on the floor.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="position"></param>
		/// <param name="effectId"></param>
		private void RemoveSkillEffect(Skill skill, ICombatEntity caster, Position position, int effectId)
		{
			Send.ZC_SKILL_CAST_CANCEL(caster);

			var character = caster as Character;
			if (character.Buffs.Has(BuffId.EnchantAura_Buff))
			{
				character.Buffs.Remove(BuffId.EnchantAura_Buff);
			}

			Send.ZC_NORMAL.GroundEffect_59(character, character.Direction, "Enchanter_EnchantAura", skill.Id, position, effectId, false);
		}
	}
}
