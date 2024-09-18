using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Items;
using Yggdrasil.Logging;

namespace Melia.Zone.Skills.Handlers.Clerics.Sadhu
{
	/// <summary>
	/// Base skill class Sadhu skills.
	/// </summary>
	public class Sadhu_Skill_Base
	{
		/// <summary>
		/// Handles a sadhu skill for the given BuffId
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		/// <param name="buffId"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target, BuffId buffId)
		{
			if (!caster.IsBuffActive(BuffId.OOBE_Soulmaster_Buff) || caster is not Character casterCharacter)
				return;

			if (caster.IsAbilityActive(AbilityId.Sadhu35))
			{
				this.CreateClone(skill, caster, originPos, farPos, target, buffId);
				return;
			}

			// This skill doesn't enter on Cooldown on the first usage.
			// On the second usage it will return to the original body.
			if (caster.IsBuffActive(buffId))
			{
				this.ReturnToBody(caster, skill, farPos, buffId);
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

			var moveSpeedBonus = this.GetMoveSpeedBonus(skill);
			casterCharacter.Properties.Modify(PropertyName.MSPD_BM, moveSpeedBonus);

			var dummyCharacter = this.SpawnDummyClone(casterCharacter, caster.Position);

			Send.ZC_PLAY_ANI(dummyCharacter, "F_archer_bodkinpoint_finish2", false, true);
			Send.ZC_PLAY_SOUND(caster, "skl_eff_yuchae_start_2");
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke013_blue_smoke", farPos, 1, 0.7f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke013_blue_smoke", dummyCharacter.Position, 1.5f, 0.3f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke058_blue", farPos, 3f, 0.5f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke058_blue", dummyCharacter.Position, 3, 0.5f, 0, 0, 0);

			casterCharacter.Position = farPos;
			Send.ZC_SET_POS(casterCharacter, farPos);

			Send.ZC_NORMAL.UpdateModelColor(casterCharacter, 255, 200, 100, 150, 0.01f);
			Send.ZC_NORMAL.UnkDynamicCastStart(casterCharacter, SkillId.None);

			Send.ZC_PLAY_ANI(dummyCharacter, "E_cleric_ProtectionOfGoddess_ground_red##1.1", true, false);

			this.SendAvailableSkills(casterCharacter, buffId, skill);

			casterCharacter.StartBuff(buffId, moveSpeedBonus, dummyCharacter.Handle, TimeSpan.FromSeconds(10), casterCharacter);
		}

		/// <summary>
		/// Creates a clone of the character that attacks nearby
		/// entities and disappears after a while leaving an effect
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		/// <param name="buffId"></param>
		public void CreateClone(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target, BuffId buffId)
		{
			if (!caster.IsBuffActive(BuffId.OOBE_Soulmaster_Buff) || caster is not Character casterCharacter)
				return;

			// This skill doesn't enter on Cooldown on the first usage.
			// On the second usage it will return to the original body.
			if (caster.IsBuffActive(buffId))
			{
				this.ReturnToBody(caster, skill, farPos, buffId);
				return;
			}

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			farPos = caster.Position.GetRelative(caster.Direction, 20);

			caster.SetAttackState(true);
			skill.IncreaseOverheat();

			this.SkillReady(caster, skill, caster.Position);

			var moveSpeedBonus = this.GetMoveSpeedBonus(skill);

			var dummyCharacter = this.SpawnDummyClone(casterCharacter, farPos);

			Send.ZC_PLAY_SOUND(caster, "skl_eff_yuchae_start_2");
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke013_blue_smoke", farPos, 1, 0.7f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke013_blue_smoke", dummyCharacter.Position, 1.5f, 0.3f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke058_blue", farPos, 3f, 0.5f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke058_blue", dummyCharacter.Position, 3, 0.5f, 0, 0, 0);
			Send.ZC_SET_POS(casterCharacter, dummyCharacter.Handle, farPos);
			Send.ZC_PLAY_ANI(dummyCharacter, "F_archer_bodkinpoint_finish2", false, true);

			Send.ZC_NORMAL.UpdateModelColor(casterCharacter, dummyCharacter.Handle, 255, 200, 100, 150, 0.01f);
			Send.ZC_NORMAL.UnkDynamicCastStart(casterCharacter, dummyCharacter.Handle, SkillId.None);

			dummyCharacter.StartBuff(buffId, 0, 0, TimeSpan.FromSeconds(3), dummyCharacter);

			var aiComponent = new AiComponent(dummyCharacter, "SadhuDummy");
			aiComponent.Script.SetMaster(casterCharacter);

			dummyCharacter.Components.Add(aiComponent);
		}

		/// <summary>
		/// Returns the move speed bonus, sometimes the value can be negative
		/// </summary>
		/// <param name="skill"></param>
		private float GetMoveSpeedBonus(Skill skill)
		{
			return skill.Id == SkillId.Sadhu_Prakriti ? 18 - (skill.Level + 6) : 18;
		}

		/// <summary>
		/// Spawns a dummy character that will looks like the original character
		/// </summary>
		/// <param name="casterCharacter"></param>
		private Character SpawnDummyClone(Character casterCharacter, Position position)
		{
			var dummyCharacter = new DummyCharacter();

			dummyCharacter.DbId = casterCharacter.DbId;
			dummyCharacter.AccountId = casterCharacter.AccountId;
			dummyCharacter.Name = casterCharacter.Name;
			dummyCharacter.TeamName = casterCharacter.TeamName;
			dummyCharacter.JobId = casterCharacter.JobId;
			dummyCharacter.Gender = casterCharacter.Gender;
			dummyCharacter.Hair = casterCharacter.Hair;
			dummyCharacter.SkinColor = casterCharacter.SkinColor;
			dummyCharacter.MapId = casterCharacter.MapId;

			dummyCharacter.Position = position;
			dummyCharacter.Direction = casterCharacter.Direction;

			foreach (var item in casterCharacter.Inventory.GetEquip())
			{
				var newItem = new Item(item.Value.Id, item.Value.Amount);
				dummyCharacter.Inventory.SetEquipSilent(item.Key, newItem);
			}

			foreach (var job in casterCharacter.Jobs.GetList())
			{
				dummyCharacter.Jobs.AddSilent(new Job(dummyCharacter, job.Id));
			}

			foreach (var skill in casterCharacter.Skills.GetList())
			{
				var newSkill = new Skill(dummyCharacter, skill.Id, skill.Level);
				dummyCharacter.Skills.AddSilent(newSkill);
			}

			dummyCharacter.InitProperties();
			dummyCharacter.Properties.Stamina = (int)casterCharacter.Properties.GetFloat(PropertyName.MaxSta);
			dummyCharacter.UpdateStance();
			dummyCharacter.ModifyHpSafe(casterCharacter.MaxHp, out var hp, out var priority);

			dummyCharacter.Owner = casterCharacter;

			casterCharacter.Map.AddDummyCharacter(dummyCharacter);

			Send.ZC_ENTER_PC(casterCharacter.Connection, dummyCharacter);
			Send.ZC_OWNER(casterCharacter, dummyCharacter, casterCharacter.Handle);
			Send.ZC_UPDATED_PCAPPEARANCE(dummyCharacter);

			Send.ZC_NORMAL.HeadgearVisibilityUpdate(dummyCharacter);

			return dummyCharacter;
		}

		/// <summary>
		/// Sends the to the client the list of available skills to cast
		/// </summary>
		/// <param name="casterCharacter"></param>
		private void SendAvailableSkills(Character casterCharacter, BuffId buffId, Skill skill)
		{
			var skillTreeData = ZoneServer.Instance.Data.SkillTreeDb.FindSkills(JobId.Sadhu, 45);

			foreach (var availableSkill in casterCharacter.Skills.GetList())
			{
				var isSadhuSkill = false;

				for (var i = 0; i < skillTreeData.Length; i++)
				{
					if (skillTreeData[i].SkillId == availableSkill.Id)
					{
						isSadhuSkill = true;
						break;
					}
				}

				// We are skipping all Sadhu skills besides this current own (that may be used a second time)
				if (isSadhuSkill && availableSkill.Id != skill.Id)
					continue;

				Send.ZC_NORMAL.EnableUseSkillWhileOutOfBody(casterCharacter, buffId, (int)availableSkill.Id);
			}
		}

		/// <summary>
		/// Makes the character returns to original body position
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="farPos"></param>
		private async void ReturnToBody(ICombatEntity caster, Skill skill, Position farPos, BuffId buffId)
		{
			Send.ZC_SKILL_READY(caster, skill, caster.Position, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, farPos, caster.Direction, Position.Zero, 1);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, ForceId.GetNew(), null);

			await Task.Delay(TimeSpan.FromMilliseconds(750));

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
