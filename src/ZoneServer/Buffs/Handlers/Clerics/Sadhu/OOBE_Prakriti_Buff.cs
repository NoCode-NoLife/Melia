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
	/// and creates an effect that damages enemies inside
	/// </summary>
	[BuffHandler(BuffId.OOBE_Prakriti_Buff)]
	public class OOBE_Prakriti_Buff : BuffHandler
	{
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

			var skillCharacter = casterCharacter.IsDummy && casterCharacter.Owner.IsAbilityActive(AbilityId.Sadhu35)
				? casterCharacter.Owner
				: caster;

			if (skillCharacter.TryGetSkill(SkillId.Sadhu_Prakriti, out var skill))
			{
				skillCharacter.SetAttackState(true);

				var pad = new Pad(PadName.Sadhu_Prakriti_Pad, skillCharacter, skill, new Circle(caster.Position, 90));

				pad.Position = new Position(pad.Trigger.Area.Center.X, caster.Position.Y, pad.Trigger.Area.Center.Y);
				pad.Trigger.MaxActorCount = 10;
				pad.Trigger.LifeTime = TimeSpan.FromSeconds(10);
				pad.Trigger.UpdateInterval = TimeSpan.FromSeconds(1);
				pad.Trigger.Subscribe(TriggerType.Update, this.OnUpdate);

				caster.Map.AddPad(pad);

				// [Arts] Spirit Expert: Wandering Soul
				if (casterCharacter.Owner != null && casterCharacter.Owner.IsAbilityActive(AbilityId.Sadhu35))
				{
					Send.ZC_SKILL_READY(casterCharacter.Owner, caster, skill, caster.Position, caster.Position);
					Send.ZC_NORMAL.UpdateSkillEffect(casterCharacter.Owner, caster.Handle, caster.Position, caster.Direction, Position.Zero);
					Send.ZC_SKILL_MELEE_GROUND(casterCharacter.Owner, caster, skill, caster.Position, ForceId.GetNew(), null);
				}
				else
				{
					skill.IncreaseOverheat();
				}
			}

			// [Arts] Spirit Expert: Wandering Soul
			if (casterCharacter.Owner != null && casterCharacter.Owner.IsAbilityActive(AbilityId.Sadhu35))
			{
				this.RemoveDummyCharacter(casterCharacter);
				return;
			}

			casterCharacter.Properties.Modify(PropertyName.MSPD_BM, -buff.NumArg1);

			Send.ZC_NORMAL.EndOutOfBodyBuff(casterCharacter, BuffId.OOBE_Prakriti_Buff);
			Send.ZC_NORMAL.UpdateModelColor(casterCharacter, 255, 255, 255, 255, 0.01f);

			Send.ZC_PLAY_SOUND(casterCharacter, "skl_eff_yuchae_end_2");

			this.ReturnToBody(casterCharacter, (int)buff.NumArg2);
		}

		/// <summary>
		/// Remove the dummy character from the map
		/// </summary>
		/// <param name="character"></param>
		private void RemoveDummyCharacter(Character character)
		{
			if (character.Owner is Character ownerCharacter)
				Send.ZC_OWNER(ownerCharacter, character, 0);

			Send.ZC_LEAVE(character);

			character.Map.RemoveDummyCharacter(character);
		}

		/// <summary>
		/// Makes the character returns to original position
		/// and also get ride of the dummy character
		/// </summary>
		/// <param name="character"></param>
		/// <param name="dummyHandle"></param>
		private void ReturnToBody(Character character, int dummyHandle)
		{
			var dummyCharacter = character.Map.GetDummyCharacter(dummyHandle);

			if (dummyCharacter == null)
				return;

			character.Position = dummyCharacter.Position;
			character.Direction = dummyCharacter.Direction;
			Send.ZC_ROTATE(character);
			Send.ZC_SET_POS(character, dummyCharacter.Position);
			Send.ZC_OWNER(character, dummyCharacter, 0);
			Send.ZC_LEAVE(dummyCharacter);
			character.Map.RemoveDummyCharacter(dummyCharacter);			
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
				target.StartBuff(BuffId.Common_Hold, 0, 0, TimeSpan.FromMilliseconds(5500), caster);
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
			var skillHitResult = SCR_SkillHit(caster, target, skill);

			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult);
			hit.Type = HitType.Type33;

			Send.ZC_HIT_INFO(caster, target, hit);
		}

		/// <summary>
		/// Called when the dummy character died
		/// disappeared.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="killer"></param>
		private void OnDummyDied(Character character, ICombatEntity killer)
		{
			character.Owner.StopBuff(BuffId.OOBE_Prakriti_Buff);
		}
	}
}
