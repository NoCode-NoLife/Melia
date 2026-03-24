using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Zone.Network;
using Melia.Zone.Pads;
using Melia.Zone.Pads.Handlers;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scouts.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Taglio.
	/// </summary>
	[SkillHandler(SkillId.Arditi_Taglio)]
	public class Arditi_Taglio : IDynamicCasted
	{
		/// <summary>
		/// Called when the user starts casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			// Taglio: Tenacity
			// - Duration changed to 5 seconds
			// - Movement speed increase effect removed
			// - Cooldown increased by 10 seconds
			if (!caster.IsAbilityActive(AbilityId.Arditi19))
			{
				var moveSpeed = this.GetBonusMoveSpeed();
				caster.Properties.Modify(PropertyName.MSPD_BM, moveSpeed);
				Send.ZC_MSPD(caster);
			}

			// Use a fix buff duration, as to not rely on the client to end
			// the cast in time.
			var maxCastingTime = this.GetMaxCastTime(caster);
			caster.StartBuff(BuffId.Taglio_Buff, TimeSpan.FromSeconds(maxCastingTime));

			Send.ZC_PLAY_SOUND_Gendered(caster, "voice_war_atk_long_cast", "voice_atk_long_cast_f");

			var pad = Pad.Create(PadName.Arditi_Taglio, caster, skill, caster.Position, new Square(caster.Position, caster.Direction, 45, 30), new PadOptions
			{
				LifeTime = TimeSpan.FromSeconds(maxCastingTime),
				UpdateInterval = TimeSpan.FromMilliseconds(250),
				MaxActorCount = 10,

				Angle = 0,
				Distance = 0,
				UnkF3 = 150,
			});

			caster.Map.AddPad(pad);
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			caster.StopBuff(BuffId.Taglio_Buff);

			if (caster is Character casterCharacter)
				Send.ZC_NORMAL.UnkDynamicCastEnd(casterCharacter, skill.Id, 2.1f);

			Send.ZC_STOP_SOUND_Gendered(caster, "voice_war_atk_long_cast", "voice_atk_long_cast_f");

			// Taglio: Tenacity
			if (!caster.IsAbilityActive(AbilityId.Arditi19))
			{
				var moveSpeed = this.GetBonusMoveSpeed();
				caster.Properties.Modify(PropertyName.MSPD_BM, -moveSpeed);
				Send.ZC_MSPD(caster);
			}
		}

		/// <summary>
		/// Returns the Bonus MoveSpeed
		/// </summary>
		/// <returns></returns>
		private float GetBonusMoveSpeed()
		{
			return 10f;
		}

		/// <summary>
		/// Returns the Max CastTime in seconds
		/// </summary>
		/// <returns></returns>
		private float GetMaxCastTime(ICombatEntity caster)
		{
			return caster.IsAbilityActive(AbilityId.Arditi19) ? 5f : 2f;
		}
	}

	/// <summary>
	/// Handler for the Arditi_Taglio pad.
	/// </summary>
	[PadHandler(PadName.Arditi_Taglio)]
	public class Arditi_Taglio_Pad : IUpdatePadHandler
	{
		/// <summary>
		/// Apply damage to targets in the pad area every update.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Updated(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var skill = args.Skill;

			args.Trigger.Position = args.Creator.Position;

			var targets = pad.Trigger.GetAttackableEntities(caster);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);

				target.TakeDamage(skillHitResult.Damage, caster);

				var hit = new HitInfo(caster, target, skill, skillHitResult, TimeSpan.FromMilliseconds(100));
				Send.ZC_HIT_INFO(caster, target, hit);

				// Ability - Taglio: Remove Knockback
				if (!caster.IsAbilityActive(AbilityId.Arditi8))
				{
					var kb = new KnockBackInfo(caster.Position, target.Position, skill);
					target.Position = kb.ToPosition;
					target.AddState(StateType.KnockedBack, kb.Time);

					Send.ZC_KNOCKDOWN_INFO(caster, target, kb);
				}
			}
		}
	}
}
