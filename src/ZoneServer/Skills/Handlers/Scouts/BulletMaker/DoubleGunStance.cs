using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Scouts.BulletMaker
{
	/// <summary>
	/// Handles the Bullet Maker's skill Double Gun Stance.
	/// </summary>
	[SkillHandler(SkillId.Bulletmarker_DoubleGunStance)]
	public class DoubleGunStance : ISelfSkillHandler
	{
		/// <summary>
		/// Handles the skill start the Double Gun Stance buff
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="dir"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Direction dir)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			if (caster is Character casterCharacter)
			{
				var rightHand = casterCharacter.Inventory.GetItem(EquipSlot.RightHand);
				if (rightHand == null || rightHand.Data.EquipType1 != EquipType.Pistol)
					return;
			}

			if (caster.IsBuffActive(BuffId.DoubleGunStance_Buff))
			{
				Send.ZC_NORMAL.UpdateNormalAttackSkill(caster, SkillId.Pistol_Attack);
				caster.StopBuff(BuffId.DoubleGunStance_Buff);
			}
			else
			{
				Send.ZC_NORMAL.UpdateNormalAttackSkill(caster, SkillId.DoubleGun_Attack);
				caster.StartBuff(BuffId.DoubleGunStance_Buff, 1, 0, TimeSpan.Zero, caster);
			}

			Send.ZC_SKILL_READY(caster, skill, originPos, originPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, originPos, caster.Direction, Position.Zero);
			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster, null);			
		}
	}
}
