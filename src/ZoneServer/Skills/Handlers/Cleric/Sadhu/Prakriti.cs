using System;
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
	/// Handler for the Sadhu skill Prakriti.
	/// </summary>
	[SkillHandler(SkillId.Sadhu_Prakriti)]
	public class Prakriti : IGroundSkillHandler
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

			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			farPos = caster.Position.GetRelative(caster.Direction, 30);

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			caster.StartBuff(BuffId.OOBE_Soulmaster_Buff, skill.Level, 0, TimeSpan.FromMinutes(30), caster);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, farPos, caster.Direction, Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, ForceId.GetNew(), null);

			Send.ZC_PLAY_SOUND(caster, "skl_eff_yuchae_start_2");

			casterCharacter.Properties.Modify(PropertyName.MSPD_BM, this.GetMoveSpeedBonus(skill));

			// We are loading a new Character from the DB
			var dummyCharacter = ZoneServer.Instance.Database.GetCharacter(casterCharacter.AccountId, casterCharacter.DbId);

			dummyCharacter.Position = caster.Position;
			dummyCharacter.Direction = caster.Direction;

			casterCharacter.Map.AddDummyCharacter(dummyCharacter);

			Send.ZC_ENTER_PC(casterCharacter.Connection, dummyCharacter, true);

			Send.ZC_OWNER(casterCharacter, dummyCharacter);
			Send.ZC_PLAY_ANI(dummyCharacter, 13705, false, true);
			Send.ZC_UPDATED_PCAPPEARANCE(dummyCharacter);

			Send.ZC_NORMAL.HeadgearVisibilityUpdate(dummyCharacter);

			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke013_blue_smoke", farPos, 1, 0.7f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke013_blue_smoke", dummyCharacter.Position, 1.5f, 0.3f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke058_blue", farPos, 3f, 0.5f, 0, 0, 0);
			Send.ZC_GROUND_EFFECT(casterCharacter, "I_only_quest_smoke058_blue", dummyCharacter.Position, 3, 0.5f, 0, 0, 0);

			casterCharacter.Position = farPos;
			Send.ZC_SET_POS(casterCharacter, farPos);

			Send.ZC_NORMAL.UpdateModelColor(casterCharacter, 255, 200, 100, 150, 0.01f);
			Send.ZC_PLAY_ANI(dummyCharacter, 5289, true, false);
			Send.ZC_NORMAL.UnkDynamicCastStart(casterCharacter, SkillId.None);

			foreach (var availableSkill in casterCharacter.Skills.GetList())
			{
				Send.ZC_NORMAL.EnableUseSkillWhileOutOfBody(casterCharacter, BuffId.OOBE_Prakriti_Buff, availableSkill.Id, true);
			}

			casterCharacter.StartBuff(BuffId.OOBE_Prakriti_Buff, this.GetMoveSpeedBonus(skill), dummyCharacter.Handle, TimeSpan.FromSeconds(10), casterCharacter);
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
	}
}
