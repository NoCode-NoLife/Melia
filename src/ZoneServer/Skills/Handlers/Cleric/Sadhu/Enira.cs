using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Cleric.SadHu
{
	/// <summary>
	/// Handler for the Sadhu skill Enira (Anila).
	/// </summary>
	[SkillHandler(SkillId.Sadhu_Anila)]
	public class Enira : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, makes the character out of body.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.IsBuffActive(BuffId.OOBE_Soulmaster_Buff) || caster is not Character casterCharacter)
				return;

			// This skill doesn't enter on Cooldown on the first usage.
			// On the second usage it will return to the original body.
			if (caster.IsBuffActive(BuffId.OOBE_Anila_Buff))
			{
				this.ReturnToBody(caster, skill, farPos);
				return;
			}

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			farPos = caster.Position.GetRelative(caster.Direction, 30);

			caster.SetAttackState(true);
			this.SkillReady(caster, skill, farPos);
			Send.ZC_PLAY_SOUND(caster, "skl_eff_yuchae_start_2");

			var moveSpeedBonus = this.GetMoveSpeedBonus(skill);
			casterCharacter.Properties.Modify(PropertyName.MSPD_BM, moveSpeedBonus);

			var dummyCharacter = this.SpawnDummyClone(casterCharacter);

			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke013_blue_smoke", farPos, 1, 0.7f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke013_blue_smoke", dummyCharacter.Position, 1.5f, 0.3f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke058_blue", farPos, 3f, 0.5f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke058_blue", dummyCharacter.Position, 3, 0.5f, 0, 0, 0);

			casterCharacter.Position = farPos;
			Send.ZC_SET_POS(casterCharacter, farPos);

			Send.ZC_NORMAL.UpdateModelColor(casterCharacter, 255, 200, 100, 150, 0.01f);			
			Send.ZC_NORMAL.UnkDynamicCastStart(casterCharacter, SkillId.None);

			Send.ZC_PLAY_ANI(dummyCharacter, 5289, true, false);

			this.SendAvailableSkills(casterCharacter);

			casterCharacter.StartBuff(BuffId.OOBE_Anila_Buff, moveSpeedBonus, dummyCharacter.Handle, TimeSpan.FromSeconds(10), casterCharacter);
			casterCharacter.StartBuff(BuffId.Skill_NoDamage_Buff, TimeSpan.FromSeconds(10));
			dummyCharacter.StartBuff(BuffId.Skill_NoDamage_Buff, TimeSpan.FromSeconds(10));
			dummyCharacter.StartBuff(BuffId.ReduceDmgCommonAbil_Buff, TimeSpan.Zero);
		}

		/// <summary>
		/// Returns the move speed bonus, sometimes the value can be negative
		/// </summary>
		/// <param name="skill"></param>
		private float GetMoveSpeedBonus(Skill skill)
		{
			return 18 - (skill.Level + 6);
		}

		/// <summary>
		/// Spawns a dummy character that will looks like the original character
		/// </summary>
		/// <param name="casterCharacter"></param>
		private Character SpawnDummyClone(Character casterCharacter)
		{
			// We are loading a new Character from the DB
			var dummyCharacter = ZoneServer.Instance.Database.GetCharacter(casterCharacter.AccountId, casterCharacter.DbId);

			dummyCharacter.Position = casterCharacter.Position;
			dummyCharacter.Direction = casterCharacter.Direction;

			casterCharacter.Map.AddDummyCharacter(dummyCharacter);

			Send.ZC_ENTER_PC(casterCharacter.Connection, dummyCharacter, true);
			Send.ZC_OWNER(casterCharacter, dummyCharacter, casterCharacter.Handle);
			Send.ZC_PLAY_ANI(dummyCharacter, 13705, false, true);
			Send.ZC_UPDATED_PCAPPEARANCE(dummyCharacter);

			Send.ZC_NORMAL.HeadgearVisibilityUpdate(dummyCharacter);

			return dummyCharacter;
		}

		/// <summary>
		/// Sends the to the client the list of available skills to cast
		/// </summary>
		/// <param name="casterCharacter"></param>
		private void SendAvailableSkills(Character casterCharacter)
		{
			var skillTreeData = ZoneServer.Instance.Data.SkillTreeDb.FindSkills(JobId.Sadhu, 45);

			foreach (var availableSkill in casterCharacter.Skills.GetList())
			{
				var isSadhuSkill = false;

				for (int i = 0; i < skillTreeData.Length; i++)
				{
					if (skillTreeData[i].SkillId == availableSkill.Id)
					{
						isSadhuSkill = true;
						break;
					}
				}

				// We are skipping all Sadhu skills besides this current own (that may be used a second time)
				if (isSadhuSkill && availableSkill.Id != SkillId.Sadhu_Anila)
					continue;

				Send.ZC_NORMAL.EnableUseSkillWhileOutOfBody(casterCharacter, BuffId.OOBE_Anila_Buff, (int)availableSkill.Id);
			}
		}

		/// <summary>
		/// Makes the character returns to original body position
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="farPos"></param>
		private async void ReturnToBody(ICombatEntity caster, Skill skill, Position farPos)
		{
			Send.ZC_SKILL_READY(caster, skill, caster.Position, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, farPos, caster.Direction, Position.Zero, 1);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, ForceId.GetNew(), null);

			await Task.Delay(TimeSpan.FromMilliseconds(750));

			skill.IncreaseOverheat();

			if (caster.TryGetBuff(BuffId.OOBE_Soulmaster_Buff, out var buff))
				buff.End();

			caster.StopBuff(BuffId.OOBE_Anila_Buff);
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
