using System;
using System.Threading.Tasks;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Skills.Handlers.Sapper
{
	/// <summary>
	/// Handler for the Sapper skill Spike Shooter.
	/// </summary>
	[SkillHandler(SkillId.Sapper_SpikeShooter)]
	public class SpikeShooter : IGroundSkillHandler
	{
		/// <summary>
		/// Handles the skill, creates an object on the floor that continues to fire arrows
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

			this.PlaceObject(caster, skill);
		}

		/// <summary>
		/// Places the trap object on the floor
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		private async void PlaceObject(ICombatEntity caster, Skill skill)
		{
			var character = caster as Character;
			var farPos = caster.Position.GetRelative(caster.Direction, 6);

			var effectId = ForceId.GetNew();
			Send.ZC_NORMAL.GroundEffect_59(character, "Archer_SpikeShooter", skill.Id, farPos, effectId, true);

			Send.ZC_SKILL_READY(caster, skill, caster.Position, caster.Position);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, caster.Direction, caster.Position);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, caster.Position, ForceId.GetNew(), null);

			await Task.Delay(200);

			this.Attack(caster, skill, farPos, caster.Direction, effectId);
		}

		/// <summary>
		/// Executes the actual attack after a delay.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="farPos"></param>
		/// <param name="effectId"></param>
		private async void Attack(ICombatEntity caster, Skill skill, Position farPos, Direction direction, int effectId)
		{
			while(true)
			{
				var leftPos = farPos.GetRelative(direction.Left, 4.5f);
				var rightPos = farPos.GetRelative(direction.Left, 4.5f);

				var leftMovPos = leftPos.GetRelative(direction, 30);
				var rightMovPos = rightPos.GetRelative(direction, 30);

				Send.ZC_NORMAL.MoveEffect(caster, "I_arrow009", ForceId.GetNew(), "FAST", 500, leftPos, leftMovPos);
				Send.ZC_NORMAL.MoveEffect(caster, "I_arrow009", ForceId.GetNew(), "FAST", 500, rightPos, rightMovPos);

				await Task.Delay(TimeSpan.FromMilliseconds(1000));
			}

			// Send.ZC_NORMAL.GroundEffect_59(caster as Character, "Archer_SpikeShooter", skill.Id, farPos, effectId, false);
		}
	}
}
