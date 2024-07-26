using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.Skills.Combat;
using static Melia.Zone.Skills.SkillUseFunctions;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;

namespace Melia.Zone.Skills.Handlers.Enchanter
{
	/// <summary>
	/// Handler for the Wugushi skill Poison Pot.
	/// </summary>
	[SkillHandler(SkillId.Wugushi_ThrowGuPot)]
	public class PoisonPot : IGroundSkillHandler
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

			Send.ZC_NORMAL.SkillProjectile(caster, "I_archer_poison_pot_force#Bip01 R Hand",
				TimeSpan.FromMilliseconds(500), "", TimeSpan.FromSeconds(1), farPos, 10, 0.6f, 0, 500);

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, ForceId.GetNew(), null);

			this.CreateAttackArea(skill, caster, farPos);
		}

		/// <summary>
		/// Execute the skill, create the area of the skill's effect
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="farPos"></param>
		/// <param name="direction"></param>
		private async void CreateAttackArea(Skill skill, ICombatEntity caster, Position farPos)
		{
			await Task.Delay(600);

			var pad = new Pad(PadName.Archer_VerminPot, caster, skill, new Circle(farPos, 55));
			pad.Position = new Position(pad.Trigger.Area.Center.X, caster.Position.Y, pad.Trigger.Area.Center.Y);
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(15);
			pad.Trigger.MaxActorCount = 6;
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
			var maxAmount = 6;
			var i = 0;

			foreach (var target in targets)
			{
				if (++i >= maxAmount)
					break;

				var damageMultiplier = 1f;

				if (caster.TryGetBuff(BuffId.Zhendu_Buff, out var buff))
					damageMultiplier = buff.NumArg1;

				var skillHitResult = SCR_SkillHit(caster, target, skill);
				skillHitResult.Damage *= damageMultiplier;

				if (!target.IsBuffActive(BuffId.Archer_VerminPot_Debuff))
					target.StartBuff(BuffId.Archer_VerminPot_Debuff, skill.Level, skillHitResult.Damage, TimeSpan.FromSeconds(15), caster);
			}
		}
	}
}
