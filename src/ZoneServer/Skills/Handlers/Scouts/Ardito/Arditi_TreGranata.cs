using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Pads;
using Melia.Zone.Pads.Handlers;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Ardito
{
	/// <summary>
	/// Handler for the Ardito skill Tre Granata.
	/// </summary>
	[SkillHandler(SkillId.Arditi_TreGranata)]
	public class Arditi_TreGranata : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="designatedTarget"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity designatedTarget)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			if (!caster.Position.InRange2D(farPos, skill.Data.MaxRange))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, 0, originPos, caster.Direction, Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);

			skill.Run(this.CreateAttackArea(skill, caster, farPos, caster.Direction));
		}

		/// <summary>
		/// Execute the skill, create the area of the skill's effect
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="farPos"></param>
		/// <param name="direction"></param>
		private async Task CreateAttackArea(Skill skill, ICombatEntity caster, Position farPos, Direction direction)
		{
			var pos1 = farPos.GetRelative2D(direction, 50);
			var pos2 = pos1.GetRelative2D(direction, 50);
			var pos3 = pos2.GetRelative2D(direction, 50);
			var pos4 = farPos.GetRelative2D(direction, 25);

			await skill.Wait(100);

			Send.ZC_NORMAL.SkillProjectile(caster, "E_scout_TreGranata#Dummy_R_HAND", 0.75f, "F_explosion125_explosion2", 2.5f, pos1, 70f, 0.3f, 0, 600);
			Send.ZC_NORMAL.SkillProjectile(caster, "E_scout_TreGranata#Dummy_R_HAND", 0.75f, "F_explosion125_explosion2", 2.5f, pos2, 70f, 0.3f, 0, 600);
			Send.ZC_NORMAL.SkillProjectile(caster, "E_scout_TreGranata#Dummy_R_HAND", 0.75f, "F_explosion125_explosion2", 2.5f, pos3, 70f, 0.3f, 0, 600);
			Send.ZC_NORMAL.SkillProjectile(caster, "", 0.75f, "", 2.5f, pos2, 70f, 0.3f, 0, 600);

			await skill.Wait(400);

			var pad1 = Pad.Create(PadName.Arditi_TreGranata, caster, skill, pos1, new Circle(pos1, 50), new PadOptions
			{
				LifeTime = TimeSpan.FromSeconds(10),
				MaxActorCount = 15,
				UnkF3 = 150,
			});

			var pad2 = Pad.Create(PadName.Arditi_TreGranata, caster, skill, pos2, new Circle(pos2, 50), new PadOptions
			{
				LifeTime = TimeSpan.FromSeconds(10),
				MaxActorCount = 15,
				UnkF3 = 150,
			});

			var pad3 = Pad.Create(PadName.Arditi_TreGranata, caster, skill, pos3, new Circle(pos3, 50), new PadOptions
			{
				LifeTime = TimeSpan.FromSeconds(10),
				UpdateInterval = TimeSpan.FromSeconds(1),
				MaxActorCount = 15,
				UnkF3 = 150,
			});

			var pad4 = Pad.Create(PadName.Arditi_TreGranata_DamagePad, caster, skill, pos4, new Square(pos4, caster.Direction, 150, 50), new PadOptions
			{
				LifeTime = TimeSpan.FromSeconds(10),
				UpdateInterval = TimeSpan.FromSeconds(1),
				UnkF3 = 150,
			});

			caster.Map.AddPad(pad1);
			caster.Map.AddPad(pad2);
			caster.Map.AddPad(pad3);
			caster.Map.AddPad(pad4);
		}
	}

	/// <summary>
	/// Handler for the Arditi_TreGranata pad,
	/// </summary>
	[PadHandler(PadName.Arditi_TreGranata_DamagePad)]
	public class Arditi_TreGranata_DamagePad : IUpdatePadHandler
	{
		/// <summary>
		/// Applies damage to targets inside the pad every update.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Updated(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var skill = args.Skill;

			var targets = pad.Trigger.GetAttackableEntities(caster);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);

				target.TakeDamage(skillHitResult.Damage, caster);

				var hit = new HitInfo(caster, target, skill, skillHitResult);
				Send.ZC_HIT_INFO(caster, target, hit);
			}
		}
	}
}
