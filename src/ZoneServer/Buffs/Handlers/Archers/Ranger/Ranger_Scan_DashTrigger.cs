using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;
using Yggdrasil.Logging;

namespace Melia.Zone.Buffs.Handlers.Archers.Ranger
{
	/// <summary>
	/// Buff handler for Ranger Scan DashTrigger, which reduces
	/// Scan's cooldown while you're dashing.
	/// </summary>
	/// <remarks>
	/// NumArg1: Skill Level
	/// NumArg2: None
	/// </remarks>
	[BuffHandler(BuffId.Ranger_Scan_DashTrigger)]
	public class Ranger_Scan_DashTrigger : BuffHandler
	{
		private const float baseCooldownReduction = 500f;
		private const float cooldownReductionPerLevel = 300f;

		public override void WhileActive(Buff buff)
		{
			var caster = buff.Caster;

			if (caster.TryGetSkill(SkillId.Ranger_Scan, out var scan))
			{				
				if (scan.IsOnCooldown && caster.IsBuffActive(BuffId.DashRun))
				{
					scan.ReduceCooldown(TimeSpan.FromMilliseconds(baseCooldownReduction + cooldownReductionPerLevel * buff.NumArg1));
				}
			}
		}
	}
}
