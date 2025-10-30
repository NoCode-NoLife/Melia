using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Skills.Handlers.Clerics.Sadhu
{
	/// <summary>
	/// Base skill class Sadhu skills.
	/// </summary>
	public class Sadhu_Skill_Base
	{
		/// <summary>
		/// Handles a sadhu skill for the given BuffId.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		/// <param name="buffId"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target, BuffId buffId)
		{
			// The skill casting of this skill requires Soul Master Buff.
			if (!caster.IsBuffActive(BuffId.OOBE_Soulmaster_Buff) || caster is not Character casterCharacter)
				return;

			// This will happens in the second usage: returns to body.
			if (caster.IsBuffActive(buffId))
			{
				this.ReturnToBody(caster, skill, farPos, buffId);
				return;
			}

			// Prevents from spamming the skills if
			// somehow the user bypass clients checks
			if (casterCharacter.IsOutOfBody())
				return;

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			farPos = caster.Position.GetRelative2D(caster.Direction, 30);
			caster.SetAttackState(true);
			this.SkillReady(caster, skill, farPos);

			// Checks if the [Arts] Spirit Expert: Wandering Soul is active.
			// This will switch the flow of the skill. Instead of letting
			// the player be the sprit and control it, a clone AI based will be created.
			if (caster.IsAbilityActive(AbilityId.Sadhu35))
			{
				this.CreateAISpiritClone(skill, casterCharacter, originPos, farPos, target, buffId);
				return;
			}

			var moveSpeedBonus = this.GetMoveSpeedBonus(skill);

			// A dummy character, it will stays on the old character position
			// While the player apparence will assume the spirit form.
			var dummyCharacter = casterCharacter.Clone(caster.Position);

			Send.ZC_PLAY_ANI(dummyCharacter, "BORN", false);
			Send.ZC_PLAY_ANI(dummyCharacter, "skl_OOBE_loop", true);
			Send.ZC_NORMAL.UnkDynamicCastStart(dummyCharacter, SkillId.None);

			this.SkillEffects(casterCharacter, dummyCharacter, dummyCharacter.Position, farPos);

			casterCharacter.Position = farPos;
			Send.ZC_SET_POS(casterCharacter, farPos);

			Send.ZC_NORMAL.UpdateModelColor(casterCharacter, 255, 200, 100, 150, 0.01f);
			Send.ZC_NORMAL.UnkDynamicCastStart(casterCharacter, SkillId.None);

			this.SendAvailableSkills(casterCharacter, buffId, skill);

			dummyCharacter.StartBuff(BuffId.ReduceDmgCommonAbil_Buff, 0, 0, TimeSpan.FromSeconds(10), dummyCharacter);
			casterCharacter.StartBuff(buffId, moveSpeedBonus, dummyCharacter.Handle, TimeSpan.FromSeconds(10), casterCharacter);
		}

		/// <summary>
		/// Creates a clone of the character (spirit) that attacks nearby
		/// entities and disappears after a few seconds leaving an effect
		/// that works similar as skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="casterCharacter"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		/// <param name="buffId"></param>
		public void CreateAISpiritClone(Skill skill, Character casterCharacter, Position originPos, Position farPos, ICombatEntity target, BuffId buffId)
		{
			skill.IncreaseOverheat();

			// Clones the character that will be perform
			// attacks to nearby enemies and leave an buff skill
			// once it disappears or dies.
			var spirit = casterCharacter.Clone(farPos);

			this.SkillEffects(casterCharacter, spirit, spirit.Position, farPos);
			Send.ZC_SET_POS(spirit, farPos);

			Send.ZC_NORMAL.UpdateModelColor(spirit, 255, 200, 100, 150, 0.01f);
			Send.ZC_NORMAL.UnkDynamicCastStart(spirit, SkillId.None);

			spirit.StartBuff(buffId, 0, 0, TimeSpan.FromSeconds(3), spirit);

			var aiComponent = new AiComponent(spirit, "SadhuDummy");
			aiComponent.Script.SetMaster(casterCharacter);

			spirit.Components.Add(aiComponent);
		}

		/// <summary>
		/// Creates the skill's related effects and play animations.
		/// </summary>
		/// <param name="character"></param>
		/// <param name="target"></param>
		/// <param name="position"></param>
		/// <param name="farPos"></param>
		private void SkillEffects(Character character, IActor target, Position position, Position farPos)
		{
			Send.ZC_PLAY_SOUND(character, "skl_eff_yuchae_start_2");
			Send.ZC_GROUND_EFFECT(character, "I_only_quest_smoke013_blue_smoke", farPos, 1, 0.7f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(character, "I_only_quest_smoke013_blue_smoke", position, 1.5f, 0.3f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(character, "I_only_quest_smoke058_blue", farPos, 3f, 0.5f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(character, "I_only_quest_smoke058_blue", position, 3, 0.5f, 0, 0, 0);			
		}

		/// <summary>
		/// Returns the move speed bonus, sometimes the value can be negative.
		/// </summary>
		/// <param name="skill"></param>
		private float GetMoveSpeedBonus(Skill skill)
		{
			return skill.Id == SkillId.Sadhu_Prakriti ? 18 - (skill.Level + 6) : 18;
		}

		/// <summary>
		/// Sends the list of available skills to cast to the client.
		/// </summary>
		/// <param name="casterCharacter"></param>
		/// <param name="buffId"></param>
		/// <param name="skill"></param>
		private void SendAvailableSkills(Character casterCharacter, BuffId buffId, Skill skill)
		{
			var sadhuSkillIds = new HashSet<SkillId>(ZoneServer.Instance.Data.SkillTreeDb.FindSkills(JobId.Sadhu, 45).Select(s => s.SkillId));

			foreach (var availableSkill in casterCharacter.Skills.GetList())
			{
				// Skip if it's a Sadhu skill other than the current skill
				if (sadhuSkillIds.Contains(availableSkill.Id) && availableSkill.Id != skill.Id)
					continue;

				Send.ZC_NORMAL.EnableUseSkillWhileOutOfBody(casterCharacter, buffId, availableSkill.Id);
			}
		}

		/// <summary>
		/// Makes the character (spirit) returns to original body position.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="farPos"></param>
		/// <param name="buffId"></param>
		private async void ReturnToBody(ICombatEntity caster, Skill skill, Position farPos, BuffId buffId)
		{
			Send.ZC_SKILL_READY(caster, skill, caster.Position, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, farPos, caster.Direction, Position.Zero, 1);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, ForceId.GetNew(), null);

			await Task.Delay(TimeSpan.FromMilliseconds(750));

			// This skill doesn't enter on cooldown on the first usage.
			// But at the second usage it will return to the original
			// body then it trigger the cooldown.
			skill.IncreaseOverheat();

			caster.StopBuff(buffId);
		}

		/// <summary>
		/// Triggers the skill usage and sends it to nearby characters.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="farPos"></param>
		private void SkillReady(ICombatEntity caster, Skill skill, Position farPos)
		{
			Send.ZC_SKILL_READY(caster, skill, caster.Position, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, farPos, caster.Direction, Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, ForceId.GetNew(), null);
		}
	}
}
