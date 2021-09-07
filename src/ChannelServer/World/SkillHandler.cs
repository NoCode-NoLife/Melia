using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.Network;
using Melia.Shared.Data.Database;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.World
{
	/// <summary>
	/// Targeted skill handler interface when the client provides a target
	/// </summary>
	public interface ITargetedSkillHandler
	{
		void Handle(Skill skill, Character caster, IAttackableEntity target);
	}

	/// <summary>
	/// Ground skill handler when the client provides target cast 
	/// location, it be the same cast position as when a buff is casted
	/// like heal or double attack
	/// </summary>
	public interface IGroundSkillHandler
	{
		void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition);
	}

	/// <summary>
	/// Targeted ground skill handler when the client provides targets
	/// </summary>
	public interface ITargetGroundSkillHandler
	{
		void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition, IEnumerable<IAttackableEntity> targets);
	}

	/// <summary>
	/// Targeted skill handler implmentation when the client provides a target
	/// </summary>
	public class TargetedSkillHandler : ITargetedSkillHandler
	{
		public void Handle(Skill skill, Character caster, IAttackableEntity target)
		{
			if (skill.CanOverheat)
				skill.OverheatCounter++;
			Send.ZC_OVERHEAT_CHANGED(caster, skill);
			if (!skill.CanOverheat || skill.IsOverheated)
			{
				Send.ZC_COOLDOWN_CHANGED(caster, skill);
				skill.OverheatCounter = 0;
			}

			var damage = caster.GetRandomPAtk() + 100;
			Send.ZC_SKILL_FORCE_TARGET(caster, target, skill, damage);
			if (target != null)
			{
				if (target.TakeDamage(damage, caster, DamageVisibilityModifier.Invisible))
					Send.ZC_SKILL_CAST_CANCEL(caster, target);
			}
		}
	}

	/// <summary>
	/// Targeted ground skill implementation when the client provides targets
	/// </summary>
	public class TargetedGroundSkillHandler : ITargetGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition, IEnumerable<IAttackableEntity> targets)
		{
			if (skill.Data.Overheat != 0)
				skill.OverheatCounter++;
			Send.ZC_OVERHEAT_CHANGED(caster, skill);
			if (!skill.CanOverheat || skill.IsOverheated)
			{
				Send.ZC_COOLDOWN_CHANGED(caster, skill);
				skill.ResetOverheat();
			}
			var damage = caster.GetRandomPAtk() + 100;
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition.X, targetPosition.Y, targetPosition.Z, null, 0);
			foreach (var target in targets)
			{
				var monster = (Monster)target;
				if (monster.TakeDamage(damage, caster, DamageVisibilityModifier.Skill))
					Send.ZC_SKILL_CAST_CANCEL(caster, target);
			}
		}
	}

	/// <summary>
	/// Generic Buff Skill Handler
	/// </summary>
	public class BuffSkillHandler : IGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition)
		{
			if (!skill.CanOverheat || skill.IsOverheated)
			{
				Send.ZC_COOLDOWN_CHANGED(caster, skill);
				skill.OverheatCounter = 0;
			}
		}
	}

	/// <summary>
	/// Generic Ground Skill Handler
	/// </summary>
	public class GroundSkillHandler : IGroundSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition)
		{
			var castedRange = castPosition.Get3DDistance(targetPosition);
			if (castedRange > skill.Data.MaxRange)
			{
				Log.Warning("Player {0} casted skill with id {1} farther than max range, casted range: {2} > max range: {3}.", caster.Name, skill.Id, castedRange, skill.Data.MaxRange);
				return;
			}
			// Enabled for testing max range calculations
			else
				Log.Info("Player {0} casted skill with id {1} within max range, casted range: {2} > max range: {3}.", caster.Name, skill.Id, castedRange, skill.Data.MaxRange);
			if (skill.CanOverheat)
				skill.OverheatCounter++; // Replace with IncreaseOverheat, it's more verbose?
			Send.ZC_OVERHEAT_CHANGED(caster, skill);
			if (!skill.CanOverheat || skill.IsOverheated)
			{
				Send.ZC_COOLDOWN_CHANGED(caster, skill);
				skill.ResetOverheat();
			}
			Send.ZC_SKILL_READY(caster, skill, caster.Position, targetPosition);
			switch (skill.Id)
			{
				case 20007:
					var targets = caster.Map.GetAttackableMonstersInRange(targetPosition.X, targetPosition.Y, targetPosition.Z, (int)skill.Data.SplashRange);
					var damage = caster.GetRandomPAtk() + 100;
					Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition.X, targetPosition.Y, targetPosition.Z, targets, damage);
					foreach (var target in targets)
					{
						Send.ZC_NORMAL_SkillParticleEffect(caster, 1234);
						Send.ZC_SYNC_START(caster, 1234, 1);
						Send.ZC_NORMAL_Skill_16(caster, target, targetPosition);
						Send.ZC_SYNC_END(caster, 1234, 0);
						var monster = (Monster)target;
						if (monster.TakeDamage(damage, caster, 0))
							Send.ZC_SKILL_CAST_CANCEL(caster, target);
					}
					break;
				case 30001:
					targets = caster.Map.GetAttackableMonstersInRange(targetPosition.X, targetPosition.Y, targetPosition.Z, (int)skill.Data.SplashRange);
					damage = caster.GetRandomPAtk();
					Send.ZC_NORMAL_Skill_4E(caster, skill.Id, 1);
					Send.ZC_NORMAL_Skill(caster, skill, targetPosition, caster.Direction, true);
					Send.ZC_NORMAL_Unknown_06(caster, targetPosition);
					Send.ZC_SYNC_START(caster, 1234, 1);
					Send.ZC_SYNC_END(caster, 1234, 0);
					Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, 1234, skill.Data.HitDelay);
					Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition.X, targetPosition.Y, targetPosition.Z, null, 0);
					Send.ZC_SYNC_EXEC(caster, 1234);
					for (var i = 0; i < 10; i++)
					{
						Task.Delay(skill.Data.HitDelay).ContinueWith(_ =>
						{
							Send.ZC_NORMAL_Unknown_06(caster, targetPosition);
							Send.ZC_SYNC_START(caster, 1234, 1);
							Send.ZC_SYNC_END(caster, 1234, -0.2f);
							Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, 1234, skill.Data.HitDelay);
							Send.ZC_SYNC_EXEC(caster, 1234);
							foreach (var target in targets)
							{
								var monster = (Monster)target;
								if (monster.TakeDamage(damage, caster, DamageVisibilityModifier.Hit, i+1))
									Send.ZC_SKILL_CAST_CANCEL(caster, target);
							}
						});
					}
					Send.ZC_SKILL_DISABLE(caster);
					break;
				default:
					targets = caster.Map.GetAttackableMonstersInRange(targetPosition.X, targetPosition.Y, targetPosition.Z, (int)skill.Data.SplashRange);
					damage = caster.GetRandomPAtk() + 100;
					Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition.X, targetPosition.Y, targetPosition.Z, targets, damage);
					foreach (var target in targets)
					{
						var monster = (Monster)target;
						if (monster.TakeDamage(damage, caster, 0))
							Send.ZC_SKILL_CAST_CANCEL(caster, target);
					}
					break;
			}
		}
	}
}
