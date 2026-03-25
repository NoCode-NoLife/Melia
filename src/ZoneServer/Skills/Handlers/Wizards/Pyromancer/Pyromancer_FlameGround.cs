using System;
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

namespace Melia.Zone.Skills.Handlers.Wizards.Pyromancer
{
	/// <summary>
	/// Handler for the Pyromancer skill Flame Ground, which creates
	/// a damaging area on the ground.
	/// </summary>
	[SkillHandler(SkillId.Pyromancer_FlameGround)]
	public class Pyromancer_FlameGround : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, creating the pad.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="target"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_NORMAL.UpdateSkillEffect(caster, target, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			var pad = Pad.Create(PadName.Pyromancer_FlameGround, caster, skill, caster.Position, new Circle(caster.Position, 100), new PadOptions
			{
				LifeTime = TimeSpan.FromMilliseconds(8100),
				MaxActorCount = 10,
			});

			caster.Map.AddPad(pad);
		}
	}

	/// <summary>
	/// Handler for the pad created by the Pyromancer Flame Ground skill.
	/// </summary>
	[PadHandler(PadName.Pyromancer_FlameGround)]
	public class Pyromancer_FlameGround_Pad : IPadHandler, IEnterPadHandler, ILeavePadHandler, IDestroyPadHandler, IUpdatePadHandler
	{
		/// <summary>
		/// Handles actors entering the pad.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Entered(object sender, PadTriggerActorArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var target = args.Initiator;

			if (caster.CanDamage(target))
				target.StartBuff(BuffId.FireWall_Debuff);
		}

		/// <summary>
		/// Handles actors leaving the pad.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Left(object sender, PadTriggerActorArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var target = args.Initiator;

			if (caster.CanDamage(target))
				target.StopBuff(BuffId.FireWall_Debuff);
		}

		/// <summary>
		/// Hides the pad when it's destroyed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Destroyed(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;

			var actors = pad.Trigger.GetActors<ICombatEntity>();
			foreach (var actor in actors)
				actor.StopBuff(BuffId.FireWall_Debuff);
		}

		/// <summary>
		/// Handles regular updates of the pad, dealing damage to actors
		/// within it.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Updated(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var skill = args.Skill;

			var targets = pad.Trigger.GetAttackableEntities(caster);

			foreach (var target in targets.Limit(pad.Trigger.MaxActorCount))
			{
				if (target.MoveType == MoveType.Flying)
					continue;

				target.TakeSkillHit(caster, skill);
			}
		}
	}
}
