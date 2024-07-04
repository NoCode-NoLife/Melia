using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using static Melia.Zone.Skills.SkillUseFunctions;
using Melia.Shared.Game.Const;

namespace Melia.Zone.Skills.Handlers.Enchanter
{
	/// <summary>
	/// Handler for the Enchanter skill Enchant Aura.
	/// </summary>
	[SkillHandler(SkillId.Enchanter_EnchantAura)]
	public class EnchantAura : IGroundSkillHandler
	{
		private const float SPTickAmount = 21f;

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

			Send.ZC_NORMAL.Skill_88(caster, caster, skill);


			var buffComponent = caster.Components.Get<BuffComponent>();

			if (buffComponent != null && buffComponent.Has(BuffId.EnchantAura_Buff))
			{
				var x = skill.Vars.GetFloat("Melia.EchantAura.X");
				var y = skill.Vars.GetFloat("Melia.EchantAura.Y");
				var z = skill.Vars.GetFloat("Melia.EchantAura.Z");
				var id = skill.Vars.GetInt("Melia.EchantAura.EffectId");

				this.RemoveSkillEffect(skill, caster, new Position(x, y, z), id);
				return;
			}

			var castedPos = caster.Position;
			var effectId = ForceId.GetNew();

			skill.Vars.SetFloat("Melia.EchantAura.X", castedPos.X);
			skill.Vars.SetFloat("Melia.EchantAura.Y", castedPos.Y);
			skill.Vars.SetFloat("Melia.EchantAura.Z", castedPos.Z);
			skill.Vars.SetInt("Melia.EchantAura.EffectId", effectId);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);			
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Position.GetDirection(caster.Position), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, originPos, ForceId.GetNew(), null);

			this.AreaOfEffect(skill, caster, castedPos, effectId);
		}

		/// <summary>
		/// Area of effect that ticks dealing damage on the enemies inside
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="position"></param>
		/// <param name="effectId"></param>
		private async void AreaOfEffect(Skill skill, ICombatEntity caster, Position position, int effectId)
		{
			var buffComponent = caster.Components.Get<BuffComponent>();

			if (buffComponent == null)
				return;

			await Task.Delay(TimeSpan.FromMilliseconds(200));

			Send.ZC_NORMAL.GroundEffect_59(caster, caster.Direction, "Enchanter_EnchantAura", skill.Id, caster.Position, effectId, true);

			var radius = 80;
			var center = position.GetRelative(position, radius);
			var splashArea = new Circle(center, radius);

			Debug.ShowShape(caster.Map, splashArea, edgePoints: false);

			if (buffComponent != null && !buffComponent.Has(BuffId.EnchantAura_Buff))
			{
				caster.StartBuff(BuffId.EnchantAura_Buff, TimeSpan.Zero);
			}

			await Task.Delay(TimeSpan.FromSeconds(1));

			while (buffComponent.Has(BuffId.EnchantAura_Buff))
			{
				await Task.Delay(2000);

				// Cancel if the caster has not enough SP
				if (!caster.TrySpendSp(SPTickAmount))
				{
					this.RemoveSkillEffect(skill, caster, position, effectId);
					break;
				}

				var character = caster as Character;

				if ((character != null && !character.Connection.LoggedIn) || caster.IsDead)
				{
					this.RemoveSkillEffect(skill, caster, position, effectId);
					break;
				}

				// Attack targets
				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
				var damageDelay = TimeSpan.FromMilliseconds(45);
				var skillHitDelay = skill.Properties.HitDelay;

				foreach (var target in targets.LimitBySDR(caster, skill))
				{
					var skillHitResult = SCR_SkillHit(caster, target, skill);
					target.TakeDamage(skillHitResult.Damage, caster);

					var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
					Send.ZC_SKILL_HIT_INFO(target, skillHit);
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

			var buffComponent = caster.Components.Get<BuffComponent>();

			if (buffComponent != null && buffComponent.Has(BuffId.EnchantAura_Buff))
			{
				buffComponent.Remove(BuffId.EnchantAura_Buff);
			}

			Send.ZC_NORMAL.GroundEffect_59(caster, caster.Direction, "Enchanter_EnchantAura", skill.Id, position, effectId, false);
		}
	}
}
