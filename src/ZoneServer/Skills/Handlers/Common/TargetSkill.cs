using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using Yggdrasil.Util;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Common
{
	/// <summary>
	/// Handles ranged skills that target a single entity.
	/// </summary>
	[SkillHandler(SkillId.Bow_Attack, SkillId.Magic_Attack, SkillId.Pistol_Attack, SkillId.DoubleGun_Attack)]
	public class TargetSkill : ITargetSkillHandler
	{
		private const int DoubleAttackRate = 40;

		/// <summary>
		/// Handles usage of the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			Send.ZC_NORMAL.Skill_45(caster);

			skill.IncreaseOverheat();
			caster.TurnTowards(target);
			caster.SetAttackState(true);

			if (target == null)
			{
				Send.ZC_SKILL_FORCE_TARGET(caster, null, skill, null);
				return;
			}

			var damageDelay = TimeSpan.FromMilliseconds(500);
			var skillHitDelay = skill.Properties.HitDelay;

			var modifier = SkillModifier.Default;

			Send.ZC_SKILL_READY(caster, skill, caster.Position, target.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, caster.Position, caster.Direction, Position.Zero);

			if (skill.Id == SkillId.Pistol_Attack)
			{
				// Random chance to trigger double hit with pistol while buff is active
				if (caster.IsBuffActive(BuffId.DoubleAttack_Buff) && RandomProvider.Get().Next(100) < DoubleAttackRate)
				{
					modifier.HitCount = 2;
				}					
			}
			else if (skill.Id == SkillId.DoubleGun_Attack)
			{
				if (caster.IsBuffActive(BuffId.DoubleGunStance_Buff))
				{
					// Increase by one the stack count for Overheating buff
					if (!caster.IsBuffActive(BuffId.Outrage_Buff))
						caster.StartBuff(BuffId.Overheating_Buff, TimeSpan.FromSeconds(35));

					modifier.HitCount = 2;
				}
			}

			if (skill.Id == SkillId.DoubleGun_Attack || skill.Id == SkillId.Pistol_Attack)
			{
				if (caster.IsBuffActive(BuffId.FreezeBullet_Buff) && RandomProvider.Get().Next(100) < 30)
				{
					target.StartBuff(BuffId.Freeze, TimeSpan.FromSeconds(3));

					//[Arts] Freeze Bullet: Fog
					if (caster.IsAbilityActive(AbilityId.Bulletmarker16))
					{
						// Only one Pad will be created
						if (caster.TryGetSkill(SkillId.Bulletmarker_FreezeBullet, out var freezeSkill) && !freezeSkill.Vars.GetBool("Pad_" + PadName.Bulletmarker_FreezeBullet, false))
						{
							freezeSkill.Vars.SetBool("Pad_" + PadName.Bulletmarker_FreezeBullet, true);

							var pad = new Pad(PadName.Bulletmarker_FreezeBullet, caster, freezeSkill, new Circle(target.Position, 45));

							pad.Position = target.Position;
							pad.Trigger.LifeTime = TimeSpan.FromSeconds(8);
							pad.Trigger.UpdateInterval = TimeSpan.FromSeconds(1);
							pad.Trigger.MaxActorCount = 10;

							pad.Trigger.Subscribe(TriggerType.Update, this.OnFreezePadTriggerUpdate);

							caster.Map.AddPad(pad);
						}
					}
				}	
					
			}

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
			skillHit.ForceId = ForceId.GetNew();

			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, skillHit);
		}

		/// <summary>
		/// Called when an actor enters the area of the freeze pad.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnFreezePadTriggerUpdate(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var skill = args.Skill;

			var targets = pad.Trigger.GetAttackableEntities(caster);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				target.StartBuff(BuffId.FreezeBullet_Cold_Debuff, TimeSpan.FromSeconds(2));
			}
		}
	}
}
