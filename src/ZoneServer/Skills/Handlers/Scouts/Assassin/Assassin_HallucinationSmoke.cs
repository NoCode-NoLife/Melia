using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Scouts.Assassin
{
	/// <summary>
	/// Handler for the Assassin skill Hallucination Smoke
	/// </summary>
	[SkillHandler(SkillId.Assassin_HallucinationSmoke)]
	public class Assassin_HallucinationSmoke : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			CallSafe(this.SetPad(skill, caster));
		}

		/// <summary>
		/// Places the pad
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task SetPad(Skill skill, ICombatEntity caster)
		{
			var initialDelay = TimeSpan.FromMilliseconds(300);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(initialDelay);

			var pad = new Pad(PadName.Assassin_HallucinationSmoke, caster, skill, new Circle(caster.Position, 50));
			pad.Position = caster.Position;
			pad.Trigger.MaxActorCount = 8;
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(skill.Level + 5);
			pad.Trigger.Subscribe(TriggerType.Enter, this.ApplyDebuff);

			caster.Map.AddPad(pad);
		}

		/// <summary>
		/// Called by the pad when anything enters the smoke
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void ApplyDebuff(object sender, PadTriggerActorArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;
			var target = args.Initiator;
			var skill = args.Skill;

			// At some point, this applied HallucinationSmoke_Buff to the creator
			//if (target == creator)
			//	target.StartBuff(BuffId.HallucinationSmoke_Buff, skill.Level, 0, TimeSpan.FromSeconds(20), creator);

			if (pad.Trigger.AtCapacity)
				return;

			if (!creator.CanAttack(target))
				return;

			// Assassin18 applies a special debuff.  Only one enemy can have this
			// debuff at a time, so we use a character variable to track it.
			if (creator.IsAbilityActive(AbilityId.Assassin18) && creator is Character character && !character.Variables.Temp.Has("Melia.AssassinationTarget"))
			{
				character.Variables.Temp.SetInt("Melia.AssassinationTarget", target.Handle);
				target.StartBuff(BuffId.Assassin_Target_Debuff, skill.Level, 0, TimeSpan.FromSeconds(15), creator);
			}

			// Assassin11 causes damage when the effect wears off
			// We calculate the damage now but don't apply it.
			// It's not clear how much damage was dealt, we'll assume
			// it just used the skill's factor for now
			var endingDamage = 0f;
			if (creator.IsAbilityActive(AbilityId.Assassin11))
			{
				var modifier = SkillModifier.Default;

				// Increase damage by 10% if target is under the effect of
				// Assassination Target from the caster
				if (target.TryGetBuff(BuffId.Assassin_Target_Debuff, out var assassinTargetDebuff))
				{
					if (assassinTargetDebuff.Caster == creator)
						modifier.DamageMultiplier += 0.10f;
				}

				var skillHitResult = SCR_SkillHit(creator, target, skill);
				endingDamage = skillHitResult.Damage;
			}

			target.StartBuff(BuffId.HallucinationSmoke_Debuff, skill.Level, endingDamage, TimeSpan.FromSeconds(20), creator);
		}
	}
}
