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

	interface ITargetGroundSkillHandler
	{
		void Handle(Skill skill, Character caster, Position position, List<IEntity> targets);
	}

	class TargetedSkillHandler : ITargetedSkillHandler
	{
		public void Handle(Skill skill, Character caster, IEntity target)
		{
			if (skill.Data.OverHeat != 0)
				skill.OverHeatCount++;
			Send.ZC_OVERHEAT_CHANGED(caster, skill);
			if (skill.Data.OverHeat == 0 || skill.Data.OverHeat == skill.OverHeatCount)
			{
				Send.ZC_COOLDOWN_CHANGED(caster, skill);
				skill.OverHeatCount = 0;
			}

			var damage = caster.GetRandomPAtk() + 100;
			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, damage);
			// Unsafe cast for now we're only dealing with monsters
			if (target != null)
			{
				var monster = (Monster)target;
				if (monster.TakeDamage(damage, caster, 0))
					Send.ZC_SKILL_CAST_CANCEL(caster, target);
			}
		}
	}

	class TargetedGroundSkillHandler : ITargetGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position position, List<IEntity> targets)
		{
			if (skill.Data.OverHeat != 0)
				skill.OverHeatCount++;
			Send.ZC_OVERHEAT_CHANGED(caster, skill);
			if (skill.Data.OverHeat == 0 || skill.Data.OverHeat == skill.OverHeatCount)
			{
				Send.ZC_COOLDOWN_CHANGED(caster, skill);
				skill.OverHeatCount = 0;
			}
			var damage = caster.GetRandomPAtk() + 100;
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, position.X, position.Y, position.Z, null, 0);
			foreach (var target in targets)
			{
				//Send.ZC_SKILL_MELEE_GROUND(caster, skill, target.Position.X, target.Position.Y, target.Position.Z, null, 0);
				var monster = (Monster)target;
				if (monster.TakeDamage(damage, caster, 2))
					Send.ZC_SKILL_CAST_CANCEL(caster, target);
			}
		}
	}

	class GroundSkillHandler : IGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position position)
		{
			if (skill.Data.OverHeat != 0)
				skill.OverHeatCount++;
			Send.ZC_OVERHEAT_CHANGED(caster, skill);
			if (skill.Data.OverHeat == 0 || skill.Data.OverHeat == skill.OverHeatCount)
			{
				Send.ZC_COOLDOWN_CHANGED(caster, skill);
				skill.OverHeatCount = 0;
			}
			Send.ZC_SKILL_READY(caster, skill, caster.Position, position);
			switch (skill.Id)
			{
				case 20007:
					caster.Map.GetVisibleMonsters(caster);
					var targets = caster.Map.GetAttackableMonstersInRange(position.X, position.Y, position.Z, (int)skill.Data.MaxRange).ToList<IEntity>();
					var damage = caster.GetRandomPAtk() + 100;
					Send.ZC_SKILL_MELEE_GROUND(caster, skill, position.X, position.Y, position.Z, targets, damage);
					foreach (var target in targets)
					{
						Send.ZC_NORMAL_SkillParticleEffect(caster, 1234);
						Send.ZC_SYNC_START(caster, 1234, 1);
						Send.ZC_NORMAL_Skill_16(caster, target, position);
						Send.ZC_SYNC_END(caster, 1234, 0);
						//Send.ZC_SKILL_MELEE_GROUND(caster, skill, target.Position.X, target.Position.Y, target.Position.Z, null, 0);
						var monster = (Monster)target;
						if (monster.TakeDamage(damage, caster, 0))
							Send.ZC_SKILL_CAST_CANCEL(caster, target);
					}
					break;
				case 30001:
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
					break;
				default:
					//Send.ZC_SYNC_START(caster, 1234, 1);
					//Send.ZC_SYNC_END(caster, 1234, 0);
					//Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, 1234, skill.Data.HitDelay);

					targets = caster.Map.GetAttackableMonstersInRange(position.X, position.Y, position.Z, (int)skill.Data.SplashRange).ToList<IEntity>();
					damage = caster.GetRandomPAtk() + 100;
					Send.ZC_SKILL_MELEE_GROUND(caster, skill, position.X, position.Y, position.Z, targets, damage);
					foreach (var target in targets)
					{
						//Send.ZC_SKILL_MELEE_GROUND(caster, skill, target.Position.X, target.Position.Y, target.Position.Z, null, 0);
						var monster = (Monster)target;
						if (monster.TakeDamage(damage, caster, 0))
							Send.ZC_SKILL_CAST_CANCEL(caster, target);
					}
					break;
			}
		}
	}

	interface ISkillHandler
	{
		void Handle(Skill skill, Character caster, IEntity target = null, int damage = 0);
	}
}
