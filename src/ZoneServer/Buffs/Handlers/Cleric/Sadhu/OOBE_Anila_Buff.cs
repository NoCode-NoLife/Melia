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
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Buffs.Handlers.Cleric.Sadhu
{
	/// <summary>
	/// Handler for the Out Of Body Experience (OOBE) Anila Buff
	/// which makes the character go back to original position after a while
	/// and leave a effect that damages enemies on hit by a wave effect
	/// </summary>
	[BuffHandler(BuffId.OOBE_Anila_Buff)]
	public class OOBE_Anila_Buff : BuffHandler
	{
		public override void OnEnd(Buff buff)
		{
			var caster = buff.Caster;

			if (caster is not Character casterCharacter)
				return;

			if (caster.TryGetSkill(SkillId.Sadhu_Prakriti, out var skill))
			{
				caster.SetAttackState(true);

				var pad = new Pad(PadName.Sadhu_Anila_Effect_Pad, caster, skill, new Square(caster.Position, caster.Direction, 50, 65));
				
				// pad.Position = new Position(pad.Trigger.Area.Center.X, caster.Position.Y, pad.Trigger.Area.Center.Y);
				pad.Trigger.MaxActorCount = 7;
				pad.Trigger.LifeTime = TimeSpan.FromSeconds(10);
				pad.Trigger.Subscribe(TriggerType.Enter, this.OnCollisionEnter);

				caster.Map.AddPad(pad);
				skill.IncreaseOverheat();
			}

			casterCharacter.Properties.Modify(PropertyName.MSPD_BM, -buff.NumArg1);

			Send.ZC_NORMAL.EndOutOfBodyBuff(casterCharacter, BuffId.OOBE_Anila_Buff);
			Send.ZC_NORMAL.UpdateModelColor(casterCharacter, 255, 255, 255, 255, 0.01f);

			Send.ZC_PLAY_SOUND(casterCharacter, "skl_eff_yuchae_end_2");

			var dummyCharacter = casterCharacter.Map.GetDummyCharacter((int)buff.NumArg2);

			if (dummyCharacter != null)
			{
				casterCharacter.Position = dummyCharacter.Position;
				casterCharacter.Direction = dummyCharacter.Direction;
				Send.ZC_ROTATE(casterCharacter);
				Send.ZC_SET_POS(casterCharacter, dummyCharacter.Position);
				Send.ZC_OWNER(casterCharacter, dummyCharacter, 0);
				Send.ZC_LEAVE(dummyCharacter);
				casterCharacter.Map.RemoveDummyCharacter(dummyCharacter);
			}
		}

		/// <summary>
		/// Called when an actor enters the skill's pad area.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnCollisionEnter(object sender, PadTriggerActorArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;
			var target = args.Initiator;

			if (pad.Trigger.AtCapacity)
				return;

			if (!creator.CanAttack(target))
				return;

			this.Attack(pad.Skill, creator, target);
		}

		/// <summary>
		/// Area of effect that ticks dealing damage on the enemies inside
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		private void Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var modifier = SkillModifier.MultiHit(3);

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
			skillHitResult.HitCount = 3;

			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult);
			hit.Type = HitType.Normal;

			Send.ZC_HIT_INFO(caster, target, hit);
		}
	}
}
