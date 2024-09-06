using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Pads;

namespace Melia.Zone.Skills.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handler for the Wugushi skill Zhendu.
	/// </summary>
	[SkillHandler(SkillId.Wugushi_Zhendu)]
	public class Wugushi_Zhendu : ISelfSkillHandler
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

			if (caster.IsAbilityActive(AbilityId.Wugushi7))
			{
				var spendSp = skill.Properties.GetFloat(PropertyName.SpendSP) / 2;
				if (!caster.TrySpendSp(spendSp))
				{
					caster.ServerMessage(Localization.Get("Not enough SP."));
					return;
				}
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);
			caster.StartBuff(BuffId.Zhendu_Buff, skill.Level, 0, TimeSpan.FromMinutes(30), caster);

			var effectId = ForceId.GetNew();

			var pad = new Pad(PadName.Archer_Zhendu, caster, skill, new Square(caster.Position, caster.Direction, 1, 1));
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(1);

			caster.Map.AddPad(pad);

			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, null);

			// Reduces the Poison property resistance of enemies
			// within 150 by 10% per attribute level when [Zhendu] is used
			// Increase 50% SP consumption
			if (caster.IsAbilityActive(AbilityId.Wugushi7))
			{
				var radius = 150;
				var maxTargets = 10;
				var center = caster.Position;
				var splashArea = new Circle(center, radius);

				var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea).LimitRandom(maxTargets);

				foreach (var target in targets)
				{
					var poisonDef = target.Properties.GetFloat(PropertyName.Poison_Def);
					target.Properties.SetFloat(PropertyName.Poison_Def_BM, -(poisonDef * 0.1f));
				}
			}
		}
	}
}
