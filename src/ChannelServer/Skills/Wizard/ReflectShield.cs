using System;
using Melia.Channel.Network;
using Melia.Channel.Skills.Base;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Channel.Skills.Wizard
{
	/// <summary>
	/// Handler for the Wizard skill Reflect Shield.
	/// </summary>
	[SkillHandler(SkillId.Wizard_ReflectShield)]
	public class ReflectShield : ISelfSkillHandler
	{
		public void Handle(Skill skill, Character caster, Position castPosition, Direction direction)
		{
			var castRange = caster.Position.Get3DDistance(castPosition);
			if (castRange > skill.Data.MaxRange)
			{
				Log.Warning("Reflect Shield: Player {0} cast skill farther than max range ({1} > {2}).", caster.Name, castRange, skill.Data.MaxRange);
				return;
			}

			if (skill.SpendSp > 0)
			{
				if (caster.Sp >= skill.SpendSp)
					return;
				caster.ModifySp(-skill.SpendSp);
			}

			skill.IncreaseOverheat();

			// Position2 is sent using previously targeted entity's position?
			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL_Skill_1D(caster, caster);

			var skillHandle = ChannelServer.Instance.World.CreateHandle();
			// Sent 3 times, not too sure why
			Send.ZC_SYNC_START(caster, skillHandle, 1);
			Send.ZC_SYNC_END(caster, skillHandle, 0);
			Send.ZC_SYNC_EXEC_BY_SKILL_TIME(caster, skillHandle, 200);
			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster);

			// Add Buff Id: ReflectShield_Buff Duration: 1800000
			// Properties Added ZC_OBJECT_PROPERTY [7180, 50]
		}
	}
}
