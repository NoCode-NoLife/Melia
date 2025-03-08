﻿using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Pads;
using Melia.Zone.World.Actors.Monsters;
using static Melia.Zone.Skills.SkillUseFunctions;
using Melia.Shared.World;

namespace Melia.Zone.Buffs.Handlers.Clerics.Sadhu
{
	/// <summary>
	/// Handler for the Out Of Body Experience (OOBE) Anila Buff
	/// which makes the character go back to original position after a while
	/// and leave an effect that damages enemies on hit by a wave effect.
	/// </summary>
	[BuffHandler(BuffId.OOBE_Moksha_Buff)]
	public class OOBE_Moksha_Buff : Sadhu_BuffHandler_Base
	{
		/// <summary>
		/// Starts buff, adding an event handler for
		/// the death of the dummy character.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="activationType"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var caster = buff.Caster;

			// Don't continue if the caster is not a Character
			if (caster is not Character casterCharacter)
				return;

			var dummyCharacter = casterCharacter.Map.GetCharacter((int)buff.NumArg2);

			if (dummyCharacter != null)
				dummyCharacter.Died += this.OnDummyDied;			
		}

		/// <summary>
		/// Executes the buff handler's end behavior.
		/// Does not actually end or remove the buff.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			var caster = buff.Caster;

			// Ignore if the caster is not a Character
			if (caster is not Character casterCharacter)
				return;

			// [Arts] Spirit Expert: Wandering Soul: Instead of letting the player control the spirit,
			// It spawns an clone character in form of a spirit that is controlled by AI.
			// So we need to identify the Source character that will be used on the buff ending.
			var characterSkillHandling = casterCharacter is DummyCharacter dummyCharacter && dummyCharacter.Owner.IsAbilityActive(AbilityId.Sadhu35)
				? dummyCharacter.Owner
				: caster;

			// Don't continue if the caster doesn't have the skill.
			if (!characterSkillHandling.TryGetSkill(SkillId.Sadhu_Moksha, out var skill))
				return;

			characterSkillHandling.SetAttackState(true);

			// Creates the Pad that will handles the buff ending effect that damages while enemies are inside.
			var pad = new Pad(PadName.Sadhu_Moksha_Pad, characterSkillHandling, skill, new Circle(caster.Position, 100));

			pad.Position = caster.Position;
			pad.Trigger.MaxActorCount = 10;
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(5);
			pad.Trigger.UpdateInterval = TimeSpan.FromSeconds(1);
			pad.Trigger.Subscribe(TriggerType.Update, this.OnUpdate);
			pad.Trigger.Subscribe(TriggerType.Destroy, this.OnDestroyPad);

			caster.Map.AddPad(pad);

			// [Arts] Spirit Expert: Wandering Soul - AI Controlled Spirit
			if (casterCharacter is DummyCharacter dummyCharacter2 && dummyCharacter2.Owner.IsAbilityActive(AbilityId.Sadhu35))
			{
				Send.ZC_SKILL_READY(dummyCharacter2.Owner, caster, skill, caster.Position, caster.Position);
				Send.ZC_NORMAL.UpdateSkillEffect(dummyCharacter2.Owner, caster.Handle, caster.Position, caster.Direction, Position.Zero);
				Send.ZC_SKILL_MELEE_GROUND(dummyCharacter2.Owner, caster, skill, caster.Position, ForceId.GetNew(), null);
			}
			else // Spirit was controlled by the player
			{
				skill.IncreaseOverheat();
			}

			// [Arts] Spirit Expert: Wandering Soul: AI Controlled Spirit
			// Removes the clone character (spirit) from the map.
			if (casterCharacter is DummyCharacter dummyCharacter3 && dummyCharacter3.Owner.IsAbilityActive(AbilityId.Sadhu35))
			{
				this.RemoveSpritCloneCharacter(dummyCharacter3);
				return;
			}

			// Restore character move speed
			casterCharacter.Properties.Modify(PropertyName.MSPD_BM, -buff.NumArg1);

			Send.ZC_NORMAL.EndOutOfBodyBuff(casterCharacter, BuffId.OOBE_Moksha_Buff);
			Send.ZC_NORMAL.UpdateModelColor(casterCharacter, 255, 255, 255, 255, 0.01f);
			Send.ZC_PLAY_SOUND(casterCharacter, "skl_eff_yuchae_end_2");

			this.ReturnToBody(casterCharacter, (int)buff.NumArg2);
		}

		/// <summary>
		/// Called in regular intervals while the pad is on a map.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnUpdate(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var skill = args.Skill;

			var targets = pad.Trigger.GetAttackableEntities(caster);

			// The explosion has its own maximum target count which is separate from the skill
			var maxTargets = pad.Trigger.MaxActorCount;

			if (ZoneServer.Instance.Conf.World.DisableSDR)
				maxTargets = int.MaxValue;

			foreach (var target in targets.LimitRandom(maxTargets))
			{
				this.Attack(skill, caster, target);
			}
		}

		/// <summary>
		/// Executes end attack when the pad ends.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnDestroyPad(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;

			this.EndAttack(pad.Skill, creator, (ISplashArea)pad.Area);
		}

		/// <summary>
		/// Pad's attack handler.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private void Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var skillHitResult = SCR_SkillHit(caster, target, skill);

			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult, TimeSpan.FromMilliseconds(0));

			Send.ZC_HIT_INFO(caster, target, hit);
		}

		/// <summary>
		/// Executes the end attack when the skill's pad ends.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private void EndAttack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
		{
			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			// The explosion has its own maximum target count which is separate from the skill
			var maxTargets = 10;

			if (ZoneServer.Instance.Conf.World.DisableSDR)
				maxTargets = int.MaxValue;

			foreach (var target in targets.LimitRandom(maxTargets))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);

				target.TakeDamage(skillHitResult.Damage, caster);

				// 6 Consecutive hits instead of a single packet
				for (int i = 0; i < 6; i++)
				{
					var hit = new HitInfo(caster, target, skill, skillHitResult, TimeSpan.FromMilliseconds(i * 150));
					Send.ZC_HIT_INFO(caster, target, hit);
				}
			}
		}
	}
}
