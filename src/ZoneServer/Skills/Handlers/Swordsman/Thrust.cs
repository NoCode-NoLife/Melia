using System;
using System.Collections.Generic;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;

namespace Melia.Zone.Skills.Handlers.Swordsman
{
	/// <summary>
	/// Handler for the Swordsman skill Thrust.
	/// </summary>
	[SkillHandler(SkillId.Swordman_Thrust)]
	public class Thrust : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos)
		{
			// This is just a test for a dedicated skill handler, the code
			// was largely copied from the default handler for now, without
			// referencing logs. And the packets are definitely not right
			// yet.

			var splashAreaHeight = 60;

			// We'll ignore the data sent by the client and get the
			// positions ourselves, because players are dirty cheaters
			// who can't be trusted.
			originPos = caster.Position;
			farPos = originPos.GetRelative(caster.Direction, splashAreaHeight);

			if (skill.SpendSp > 0)
				caster.Properties.Modify(PropertyName.SP, -skill.SpendSp);

			skill.IncreaseOverheat();

			Send.ZC_SKILL_READY(caster, skill, caster.Position, farPos);

			// The hitbox seems pretty small, there's presumably more going
			// into this. Double the splash range for the width for now.
			//var radius = (int)skill.Data.SplashRange * 3;

			var splashArea = new Square(originPos, caster.Direction, 60, 14); // higher than Normal_Attack, but narrower
			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
			var damage = (int)(caster.GetRandomPAtk() * skill.Data.SkillFactor / 100f);

			var hits = new List<SkillHitInfo>();

			foreach (var target in targets)
			{
				target.TakeDamage(damage, caster);

				var skillHitInfo = new SkillHitInfo(caster, target, skill, damage, TimeSpan.FromMilliseconds(270), TimeSpan.FromMilliseconds(0));
				hits.Add(skillHitInfo);
			}

			// TODO: There's an issue with Thrust where the animation
			//   sometimes plays too early, but it happens somewhat
			//   randomly.

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);
			Send.ZC_SKILL_HIT_INFO(caster, hits);
		}
	}
}
