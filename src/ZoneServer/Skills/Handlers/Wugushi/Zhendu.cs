using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Wugushi
{
	/// <summary>
	/// Handler for the Wugushi skill Zhendu.
	/// </summary>
	[SkillHandler(SkillId.Wugushi_Zhendu)]
	public class Zhendu : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, applying a buff to the caster.
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

			caster.StartBuff(BuffId.Zhendu_Buff, skill.Level, 0, TimeSpan.FromMinutes(30), caster);

			var effectId = ForceId.GetNew();

			Send.ZC_NORMAL.GroundEffect_59(caster, caster.Direction, "M_GTOWER_STAGE_15", skill.Id, caster.Position, effectId, true);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Position.GetDirection(caster.Position), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, null);

			var casterCharacter = caster as Character;

			// Reduces the Poison property resistance of enemies within 150 by 10% per attribute level when [Zhendu] is used
			if (casterCharacter != null && casterCharacter.Abilities.Has(AbilityId.Wugushi7))
			{
				var radius = 150;
				var center = caster.Position;
				var splashArea = new Circle(center, radius);

				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);

				foreach (var target in targets)
				{
					var positonRes = target.Properties.GetFloat(PropertyName.Poison_Def);
					target.Properties.SetFloat(PropertyName.Poison_Def_BM, -(positonRes * 0.1f));
				}
			}
		}
	}
}
