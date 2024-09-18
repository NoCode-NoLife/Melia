using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.Skills.SplashAreas;
using Melia.Shared.World;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Buffs.Handlers.Clerics.Sadhu
{
	/// <summary>
	/// Handler for the Out Of Body Experience (OOBE) Posession Buff
	/// which makes the character go back to original position after a while
	/// and leave an effect that damages enemies inside
	/// </summary>
	[BuffHandler(BuffId.OOBE_Possession_Buff)]
	public class OOBE_Possession_Buff : Sadhu_BuffHandler_Base
	{
		private const int MaxTargets = 7;
		// The skill tooltip says that a movement hold just be applied
		// but it doesn't happen. For that reason I left this here in that case it changes
		private const bool ApplySelfHold = false;

		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var caster = buff.Caster;

			// [Arts] Spirit Expert: Wandering Soul
			if (caster.IsAbilityActive(AbilityId.Sadhu35) || caster is not Character casterCharacter)
				return;

			var dummyCharacter = casterCharacter.Map.GetDummyCharacter((int)buff.NumArg2);

			if (dummyCharacter != null)
			{
				dummyCharacter.Died += this.OnDummyDied;
			}
		}

		public override void OnEnd(Buff buff)
		{
			var caster = buff.Caster;

			if (caster is not Character casterCharacter)
				return;

			var skillCharacter = casterCharacter is DummyCharacter dummyCharacter && dummyCharacter.Owner.IsAbilityActive(AbilityId.Sadhu35)
				? dummyCharacter.Owner
				: caster;

			if (skillCharacter.TryGetSkill(SkillId.Sadhu_Possession, out var skill))
			{
				skillCharacter.SetAttackState(true);

				this.AreaOfEffect(skillCharacter, skill, caster.Position);

				if (ApplySelfHold && casterCharacter is not DummyCharacter)
					skillCharacter.StartBuff(BuffId.Common_Hold, TimeSpan.FromMilliseconds(this.GetHoldTime(skill)));

				// [Arts] Spirit Expert: Wandering Soul
				if (casterCharacter is DummyCharacter dummyCharacter2 && dummyCharacter2.Owner.IsAbilityActive(AbilityId.Sadhu35))
				{
					Send.ZC_SKILL_READY(dummyCharacter2.Owner, caster, skill, caster.Position, caster.Position);
					Send.ZC_NORMAL.UpdateSkillEffect(dummyCharacter2.Owner, caster.Handle, caster.Position, caster.Direction, Position.Zero);
					Send.ZC_SKILL_MELEE_GROUND(dummyCharacter2.Owner, caster, skill, caster.Position, ForceId.GetNew(), null);
				}
				else
				{
					skill.IncreaseOverheat();
				}
			}

			// [Arts] Spirit Expert: Wandering Soul
			if (casterCharacter is DummyCharacter dummyCharacter3 && dummyCharacter3.Owner.IsAbilityActive(AbilityId.Sadhu35))
			{
				this.RemoveDummyCharacter(dummyCharacter3);
				return;
			}

			casterCharacter.Properties.Modify(PropertyName.MSPD_BM, -buff.NumArg1);

			Send.ZC_NORMAL.EndOutOfBodyBuff(casterCharacter, BuffId.OOBE_Possession_Buff);
			Send.ZC_NORMAL.UpdateModelColor(casterCharacter, 255, 255, 255, 255, 0.01f);

			Send.ZC_PLAY_SOUND(casterCharacter, "skl_eff_yuchae_end_2");

			this.ReturnToBody(casterCharacter, (int)buff.NumArg2);
		}

		/// <summary>
		/// Returns the amount of hold time in milliseconds
		/// </summary>
		/// <param name="skill"></param>
		private int GetHoldTime(Skill skill)
		{
			return 1000 + (300 * skill.Level);
		}

		/// <summary>
		/// Creates the Area of Effect
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		private void AreaOfEffect(ICombatEntity caster, Skill skill, Position position)
		{
			Send.ZC_GROUND_EFFECT(caster, "F_spread_out026_mint", position, 3f, 3f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(caster, "F_explosion086_mint", position, 1.2f, 3f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(caster, "F_burstup047_mint", position, 0.7f, 3f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(caster, "F_pattern025_loop", position, 1.5f, 3f, 0, 0, 0);

			var circle = new Circle(position, 120);
			var targets = caster.Map.GetAttackableEntitiesIn(caster, circle);

			foreach (var target in targets.LimitRandom(MaxTargets))
			{
				this.Attack(skill, caster, target);
			}
		}

		/// <summary>
		/// Attacks the target
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		private void Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var modifier = SkillModifier.MultiHit(5);
			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult, TimeSpan.FromMilliseconds(200));

			Send.ZC_HIT_INFO(caster, target, hit);
		}
	}
}
