using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Shared.Util.TaskHelper;

namespace Melia.Zone.Skills.Handlers.Archers.Wugushi
{
	/// <summary>
	/// Handler for the skill Golden Frog (JincanGu)
	/// </summary>
	[SkillHandler(SkillId.Wugushi_JincanGu)]
	public class Wugushi_JincanGu : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, creates an area of effect that damages the enemies inside
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

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, farPos, caster.Position.GetDirection(farPos), Position.Zero);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);

			CallSafe(this.CreateAttackArea(skill, caster, farPos));
		}

		/// <summary>
		/// Execute the skill, create the area of the skill's effect
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="farPos"></param>
		/// <param name="direction"></param>
		private async Task CreateAttackArea(Skill skill, ICombatEntity caster, Position farPos)
		{
			await Task.Delay(200);

			Send.ZC_NORMAL.SkillProjectile(caster, "I_cleric_jincangu_force_mash#Dummy_effect_shoot",
				0.4f, "", 1, farPos, 10, 0.6f, 0, 200);

			await Task.Delay(600);

			var pad = new Pad(PadName.Archer_JincanGu_Abil, caster, skill, new Circle(farPos, 100));
			pad.Position = new Position(pad.Trigger.Area.Center.X, caster.Position.Y, pad.Trigger.Area.Center.Y);
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(10);
			pad.Trigger.MaxActorCount = 10;
			pad.Trigger.UpdateInterval = TimeSpan.FromMilliseconds(250);
			pad.Trigger.Subscribe(TriggerType.Update, this.OnTriggerUpdate);

			caster.Map.AddPad(pad);
		}

		/// <summary>
		/// Called when an actor enters the area of the skill's effect.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnTriggerUpdate(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var skill = args.Skill;

			var targets = pad.Trigger.GetAttackableEntities(caster);
			// TODO: Limit the amount of targets to 4 while in PVP scenarios
			var maxAmount = 10;
			var i = 0;

			foreach (var target in targets)
			{
				if (++i >= maxAmount)
					break;

				if (!target.IsBuffActive(BuffId.JincanGu_Abil_Debuff))
					target.StartBuff(BuffId.JincanGu_Abil_Debuff, skill.Level, (int)skill.Id, TimeSpan.FromSeconds(60), caster);
			}
		}
	}
}
