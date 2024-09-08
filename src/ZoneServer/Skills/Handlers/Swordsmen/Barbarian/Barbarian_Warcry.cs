using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting.AI;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Util;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Barbarian
{
	/// <summary>
	/// Handler for the Barbarian skill Warcry
	/// </summary>
	[SkillHandler(SkillId.Barbarian_Warcry)]
	public class Barbarian_Warcry : ISelfSkillHandler
	{
		private const float BuffRemoveChancePerLevel = 33f;

		/// <summary>
		/// Handles skill, debuffing nearby enemies
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

			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster, null);

			var splashParam = skill.GetSplashParameters(caster, caster.Position, caster.Position, length: 0, width: 100, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Circle, splashParam);

			var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

			var maxTargets = 10;
			if (caster.TryGetActiveAbilityLevel(AbilityId.Barbarian1, out var barbarian1Level))
				maxTargets += barbarian1Level;

			var debuffDuration = 10;
			if (caster.TryGetActiveAbilityLevel(AbilityId.Barbarian2, out var barbarian2Level))
				debuffDuration += barbarian2Level * 2;

			foreach (var target in targets.LimitRandom(maxTargets))
			{
				target.StartBuff(BuffId.Warcry_Debuff, skill.Level, 0, TimeSpan.FromSeconds(debuffDuration), caster);

				var buffRemoveChance = BuffRemoveChancePerLevel * skill.Level;
				if (RandomProvider.Get().Next(1000) < buffRemoveChance)
				{
					if (target.Components.TryGet<BuffComponent>(out var buffComponent))
						buffComponent.RemoveRandomBuff();
				}
			}

			// This is not mentioned in the description, but the skill_bytool
			// still includes it.
			caster.StartBuff(BuffId.Warcry_Buff, skill.Level, targets.Count, TimeSpan.FromSeconds(10), caster);
		}
	}
}
