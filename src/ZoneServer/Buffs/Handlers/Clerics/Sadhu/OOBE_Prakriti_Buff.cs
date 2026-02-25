using System;
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
using Melia.Shared.World;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Buffs.Handlers.Clerics.Sadhu
{
	/// <summary>
	/// Handler for the Out Of Body Experience (OOBE) Prakriti Buff
	/// which makes the character go back to original position after a while
	/// and creates an effect that damages enemies inside.
	/// </summary>
	[BuffHandler(BuffId.OOBE_Prakriti_Buff)]
	public class OOBE_Prakriti_Buff : Sadhu_BuffHandler_Base
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

			AddPropertyModifier(buff, caster, PropertyName.MSPD_BM, (int)buff.NumArg1);

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

			RemovePropertyModifier(buff, caster, PropertyName.MSPD_BM);

			// Ignore if the caster is not a Character
			if (caster is not Character casterCharacter)
				return;

			// It spawns an clone character in form of a spirit that is controlled by AI.
			// So we need to identify the Source character that will be used on the buff ending.
			var skillCharacter = casterCharacter is DummyCharacter dummyCharacter && dummyCharacter.Owner.IsAbilityActive(AbilityId.Sadhu35)
				? dummyCharacter.Owner
				: caster;

			// Don't continue if the caster doesn't have the skill.
			if (!skillCharacter.TryGetSkill(SkillId.Sadhu_Prakriti, out var skill))
				return;

			skillCharacter.SetAttackState(true);

			// Creates the Pad that will handles the buff ending effect that damages while enemies are inside.
			var pad = new Pad(PadName.Sadhu_Prakriti_Pad, skillCharacter, skill, new Circle(caster.Position, 90));

			pad.Position = new Position(pad.Trigger.Area.Center.X, caster.Position.Y, pad.Trigger.Area.Center.Y);
			pad.Trigger.MaxActorCount = 10;
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(10);
			pad.Trigger.UpdateInterval = TimeSpan.FromSeconds(1);
			pad.Trigger.Subscribe(TriggerType.Update, this.OnUpdate);

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

			Send.ZC_NORMAL.EndOutOfBodyBuff(casterCharacter, BuffId.OOBE_Prakriti_Buff);
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

			foreach (var target in targets.LimitRandom(pad.Trigger.MaxActorCount))
			{
				if (caster.IsAbilityActive(AbilityId.Sadhu46) && !target.IsBuffActive(BuffId.OOBE_Prakriti_Sadhu46_Debuff))				
					target.StartBuff(BuffId.OOBE_Prakriti_Sadhu46_Debuff, 0, 0, TimeSpan.FromSeconds(60), caster);

				if (!target.IsBuffActive(BuffId.Common_Slow))
					target.StartBuff(BuffId.Common_Slow, 0, 0, TimeSpan.FromSeconds(1), caster);

				this.Attack(skill, caster, target);
			}
		}

		/// <summary>
		/// Attacks the target.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private void Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var dealsDamageCharacter = caster is DummyCharacter dummyCharacter && dummyCharacter.Owner.IsAbilityActive(AbilityId.Sadhu35)
				? dummyCharacter.Owner
				: caster;

			var skillHitResult = SCR_SkillHit(dealsDamageCharacter, target, skill);

			target.TakeDamage(skillHitResult.Damage, dealsDamageCharacter);

			var hit = new HitInfo(dealsDamageCharacter, target, skill, skillHitResult);
			hit.Type = HitType.Type33;

			Send.ZC_HIT_INFO(dealsDamageCharacter, target, hit);
		}
	}
}
