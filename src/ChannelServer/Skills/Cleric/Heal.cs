using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.Skills.Cleric
{
	/// <summary>
	/// Handler for the Archer skill Multishot.
	/// </summary>
	[SkillHandler(SkillId.Cleric_Heal)]
	class Heal : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="castPosition"></param>
		/// <param name="targetPosition"></param>
		public void Handle(Skill skill, Character caster, Position castPosition, Position targetPosition)
		{
			// This is just a test for a dedicated skill handler, the code
			// was largely copied from the default handler for now, without
			// referencing logs. And the packets are definitely not right
			// yet.

			var castRange = castPosition.Get3DDistance(targetPosition);
			if (castRange > skill.Data.MaxRange)
			{
				Log.Warning("Thrust: Player {0} cast skill farther than max range ({1} > {2}).", caster.Name, castRange, skill.Data.MaxRange);
				return;
			}

			if (skill.SpendSp > 0)
				caster.ModifySp(-skill.SpendSp);

			skill.IncreaseOverheat();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, targetPosition);

			// The hitbox seems pretty small, there's presumably more going
			// into this. Double the splash range for the width for now.
			var radius = (int)skill.Data.SplashRange * 2;

			var targets = caster.Map.GetAttackableEntitiesInRectangle(caster, castPosition, targetPosition, radius);
			var healAmount = (int)(caster.GetRandomMagicAmplification() * skill.Data.SkillFactor / 100f);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, targetPosition, null, 0);
			caster.ModifyHp(healAmount);
			caster.Buffs.AddOrUpdate(BuffId.Heal_Overload_Buff);
		}
	}
}
