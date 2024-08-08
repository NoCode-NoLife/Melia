using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
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

			this.CreateAttackArea(skill, caster, farPos, caster.Direction);
		}

		/// <summary>
		/// Execute the skill, create the area of the skill's effect
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="farPos"></param>
		/// <param name="direction"></param>
		private async void CreateAttackArea(Skill skill, ICombatEntity caster, Position farPos, Direction direction)
		{
			var pos1 = farPos.GetRelative(direction, 50);
			var pos2 = pos1.GetRelative(direction, 50);
			var pos3 = pos2.GetRelative(direction, 50);

			var circle1 = new Circle(pos1, 50);
			var circle2 = new Circle(pos2, 50);
			var circle3 = new Circle(pos3, 50);

			await Task.Delay(TimeSpan.FromMilliseconds(100));

			Send.ZC_NORMAL.SkillProjectile(caster, "E_scout_TreGranata#Dummy_R_HAND", 0.75f, "F_explosion125_explosion2", 2.5f, pos1, 70f, 0.3f, 0, 600);
			Send.ZC_NORMAL.SkillProjectile(caster, "E_scout_TreGranata#Dummy_R_HAND", 0.75f, "F_explosion125_explosion2", 2.5f, pos2, 70f, 0.3f, 0, 600);
			Send.ZC_NORMAL.SkillProjectile(caster, "E_scout_TreGranata#Dummy_R_HAND", 0.75f, "F_explosion125_explosion2", 2.5f, pos3, 70f, 0.3f, 0, 600);
			Send.ZC_NORMAL.SkillProjectile(caster, "", 0.75f, "", 2.5f, pos2, 70f, 0.3f, 0, 600);

			await Task.Delay(TimeSpan.FromMilliseconds(400));

			var pad1 = new Pad(PadName.Arditi_TreGranata, caster, skill, circle1);
			pad1.Position = pos1;
			pad1.Trigger.LifeTime = TimeSpan.FromSeconds(10);
			pad1.Trigger.MaxActorCount = 15;

			var pad2 = new Pad(PadName.Arditi_TreGranata, caster, skill, circle2);
			pad2.Position = pos2;
			pad2.Trigger.LifeTime = TimeSpan.FromSeconds(10);
			pad2.Trigger.MaxActorCount = 15;

			var pad3 = new Pad(PadName.Arditi_TreGranata, caster, skill, circle3);
			pad3.Position = pos3;
			pad3.Trigger.LifeTime = TimeSpan.FromSeconds(10);
			pad3.Trigger.MaxActorCount = 15;
			pad3.Trigger.UpdateInterval = TimeSpan.FromSeconds(1);

			var pad4Position = farPos.GetRelative(direction, 25);

			var pad4 = new Pad(PadName.Arditi_TreGranata_DamagePad, caster, skill, new Square(pad4Position, caster.Direction, 150, 50));
			pad4.Position = new Position(pad4.Trigger.Area.Center.X, pad4Position.Y, pad4.Trigger.Area.Center.Y);
			pad4.Trigger.LifeTime = TimeSpan.FromSeconds(10);
			pad4.Trigger.UpdateInterval = TimeSpan.FromSeconds(1);
			pad4.Trigger.Subscribe(TriggerType.Update, this.OnUpdate);

			caster.Map.AddPad(pad1);
			caster.Map.AddPad(pad2);
			caster.Map.AddPad(pad3);
			caster.Map.AddPad(pad4);
		}

		/// <summary>
		/// Called in regular intervals while the pad is on a map.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnUpdate(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var skill = args.Skill;

			var targets = pad.Trigger.GetAttackableEntities(caster);

			foreach (var target in targets.LimitBySDR(caster, skill))
			{
				this.Attack(skill, caster, target);
			}
		}

		/// <summary>
		/// Area of effect that ticks dealing damage on the enemies inside
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		private void Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var skillHitResult = SCR_SkillHit(caster, target, skill);

			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult);
			Send.ZC_HIT_INFO(caster, target, hit);
		}
	}
}
