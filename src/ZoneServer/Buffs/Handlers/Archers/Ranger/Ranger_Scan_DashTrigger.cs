using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;

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
		private const float BaseCooldownReduction = 500f;
		private const float CooldownReductionPerLevel = 300f;

		public override void WhileActive(Buff buff)
		{
			var caster = buff.Caster;

			if (!caster.TryGetSkill(SkillId.Ranger_Scan, out var scanSkill))
				return;

			if (scanSkill.IsOnCooldown && caster.IsBuffActive(BuffId.DashRun))
			{
				var skillLevel = buff.NumArg1;
				var reduction = TimeSpan.FromMilliseconds(BaseCooldownReduction + CooldownReductionPerLevel * skillLevel);

				scanSkill.ReduceCooldown(reduction);
			}
		}
	}
}
