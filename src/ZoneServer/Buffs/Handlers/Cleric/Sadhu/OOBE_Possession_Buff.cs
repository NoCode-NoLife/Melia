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

namespace Melia.Zone.Buffs.Handlers.Cleric.Sadhu
{
	/// <summary>
	/// Handler for the Out Of Body Experience (OOBE) Prakriti Buff
	/// which makes the character go back to original position after a while
	/// and leave an effect that damages enemies inside
	/// </summary>
	[BuffHandler(BuffId.OOBE_Possession_Buff)]
	public class OOBE_Possession_Buff : BuffHandler
	{
		private const int MaxTargets = 7;
		// The skill tooltip says that a movement hold just be applied
		// but it doesn't happen. For that reason I left this here in that case it changes
		private const bool ApplySelfHold = false;

		public override void OnStart(Buff buff)
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

			if (caster.TryGetSkill(SkillId.Sadhu_Possession, out var skill))
			{
				caster.SetAttackState(true);

				this.AreaOfEffect(caster, skill, caster.Position);

				if (ApplySelfHold)				
					casterCharacter.StartBuff(BuffId.Common_Hold, TimeSpan.FromMilliseconds(this.GetHoldTime(skill)));

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

			Send.ZC_NORMAL.EndOutOfBodyBuff(casterCharacter, BuffId.OOBE_Possession_Buff);
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
		/// Returns the amount of hold time in milliseconds
		/// </summary>
		/// <param name="skill"></param>
		private int GetHoldTime(Skill skill)
		{
			return 1000 + (300 * skill.Level);
		}

		/// <summary>
		/// Makes the chararacter returns to original position
		/// and also get ride of the dummy character
		/// </summary>
		/// <param name="character"></param>
		/// <param name="dummyHandle"></param>
		private void ReturnToBody(Character character, int dummyHandle)
		{
			var dummyCharacter = character.Map.GetDummyCharacter(dummyHandle);

			if (dummyCharacter != null)
			{
				character.Position = dummyCharacter.Position;
				character.Direction = dummyCharacter.Direction;
				Send.ZC_ROTATE(character);
				Send.ZC_SET_POS(character, dummyCharacter.Position);
				Send.ZC_OWNER(character, dummyCharacter, 0);
				Send.ZC_LEAVE(dummyCharacter);
				character.Map.RemoveDummyCharacter(dummyCharacter);
			}
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

		/// <summary>
		/// Called when the dummy character died
		/// disappeared.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="killer"></param>
		private void OnDummyDied(Character character, ICombatEntity killer)
		{
			character.Owner.StopBuff(BuffId.OOBE_Anila_Buff);
		}
	}
}
