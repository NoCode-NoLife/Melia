using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.Network;
using Melia.Shared.Data.Database;
using Melia.Shared.World;

namespace Melia.Channel.World
{
	interface ITargetedSkillHandler
	{
		void Handle(Skill skill, Character caster, IEntity target);
	}

	interface IGroundSkillHandler
	{
		void Handle(Skill skill, Character caster, Position position);
	}

	class GroundSkillHandler : IGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position position)
		{
			// To Do move pre-cast logic into Character.CanCast?
			if (skill.Data.OverHeat != 0)
				Send.ZC_OVERHEAT_CHANGED(caster, skill);
			if (skill.Data.CoolDown != 0)
				Send.ZC_COOLDOWN_CHANGED(caster, skill);
			if (skill.Data.BasicSp != 0)
			{
				var requiredSp = (int)skill.Data.BasicSp + (skill.Data.LvUpSpendSp * skill.Level - 1);
				if (caster.Sp < requiredSp)
					return;
				caster.Sp -= (int)skill.Data.BasicSp;
				Send.ZC_UPDATE_SP(caster);
			}
			var targets = caster.Map.GetAttackableMonstersInRange(position.X, position.Y, position.Z, (int)skill.Data.SplashRange);
			Send.ZC_SKILL_READY(caster, skill, caster.Position, position);
			Send.ZC_NORMAL_Skill_4E(caster, skill.Id, 1);
			Send.ZC_NORMAL_Skill(caster, skill, position, caster.Direction, true);
			Send.ZC_NORMAL_Unknown_06(caster, position);
			Send.ZC_SYNC_START(caster, 1234, 1);
			Send.ZC_SYNC_END(caster, 1234, 0);
			Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, 1234, skill.Data.HitDelay);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, position.X, position.Y, position.Z, null, 0);
			Send.ZC_SYNC_EXEC(caster, 1234);
			// Skill Cast Duration? Cancel's Visible Animation Otherwise you stay in casting animation
			Send.ZC_SKILL_DELAY(caster);

			foreach(var target in targets)
			{
				var damage = caster.GetRandomPAtk() + 100;
				if (target.TakeDamage(damage, caster, skill))
					Send.ZC_SKILL_CAST_CANCEL(caster, target);
			}
		}
	}


	interface ISkillHandler
	{
		void Handle(Skill skill, Character caster, IEntity target = null, int damage = 0);
	}

	/// <summary>
	/// Original Skill Handler Example
	/// </summary>
	class SkillHandler : ISkillHandler
	{
		/// <summary>
		/// This should use Generic IEntity but since TakeDamage doesn't exist in IEntity
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="damage"></param>
		public void Handle(Skill skill, Character caster, IEntity target = null, int damage = 0)
		{
			switch (skill.Data.SplashType)
			{
				case SplashType.Circle:
					Send.ZC_SKILL_RANGE_CIRCLE(caster, target, skill, target.Position);
					break;
			}
			switch (skill.Data.UseType)
			{
				case SkillUseType.FORCE:
					Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, damage);
					break;
				case SkillUseType.MELEE_GROUND:
					if (skill.Data.OverHeat != 0)
						Send.ZC_OVERHEAT_CHANGED(caster, skill);
					if (skill.Data.CoolDown != 0)
						Send.ZC_COOLDOWN_CHANGED(caster, skill);
					Send.ZC_SKILL_READY(caster, skill, caster.Position, target.Position);
					Send.ZC_NORMAL_Skill_4E(caster, skill.Id, 1);
					Send.ZC_NORMAL_Skill(caster, skill, target.Position, caster.Direction, true);
					Send.ZC_NORMAL_Unknown_06(caster, target.Position);
					Send.ZC_SYNC_START(caster, 1234, 1);
					Send.ZC_SYNC_END(caster, 1234, 0);
					Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, 1234, skill.Data.HitDelay);
					Send.ZC_SKILL_MELEE_GROUND(caster, skill, target.Position.X, target.Position.Y, target.Position.Z, target, damage);
					for (var i = 1; i < 10; i++)
					{
						Send.ZC_SYNC_START(caster, 1234, 1);
						Send.ZC_SYNC_END(caster, 1234, 0);
						Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, 1234, skill.Data.HitDelay);
					}
					Send.ZC_SYNC_EXEC(caster, 1234);
					// Skill Cast Duration? Cancel's Visible Animation Otherwise you stay in casting animation
					Send.ZC_SKILL_DELAY(caster);
					break;
			}
		}
	}
}
