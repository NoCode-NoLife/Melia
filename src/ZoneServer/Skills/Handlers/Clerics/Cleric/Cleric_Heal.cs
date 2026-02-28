using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Geometry;
using Yggdrasil.Geometry.Shapes;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Clerics.Cleric
{
	/// <summary>
	/// Handler for the Cleric skill Heal.
	/// </summary>
	[SkillHandler(SkillId.Cleric_Heal)]
	public class Cleric_Heal : IGroundSkillHandler
	{
		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			this.ExecuteHeal(caster, target, skill);

			caster.StartBuff(BuffId.Heal_Overload_Buff, TimeSpan.FromSeconds(3));

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);
		}

		/// <summary>
		/// Heals the target or spawns heal pads.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		private void ExecuteHeal(ICombatEntity caster, ICombatEntity target, Skill skill)
		{
			if (!Feature.IsEnabled("DirectClericHeal"))
				this.TriggerHeal(caster, skill);
			else
				this.BuffHeal(caster, target, skill);
		}

		/// <summary>
		/// Heals target directly with a buff.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		private void BuffHeal(ICombatEntity caster, ICombatEntity target, Skill skill)
		{
			Send.ZC_NORMAL.PlayEffect(target, "F_cleric_heal_active_ground_new");

			// TODO: Do we actually need the Heal_Buff? Feels like we could
			//   just heal the target. But maybe there's a reason for it?
			var ratio2 = 150f + (skill.Level - 1) * 103f;
			var healDuration = TimeSpan.FromSeconds(1);

			target.StartBuff(BuffId.Heal_Buff, ratio2, 0, healDuration, caster);
		}

		/// <summary>
		/// Deals damage to the target.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		private void DamageHeal(ICombatEntity caster, ICombatEntity target, Skill skill)
		{
			Send.ZC_NORMAL.PlayEffect(target, "F_cleric_heal_active_ground_new");

			var skillHitResult = SCR_SkillHit(caster, target, skill);

			// According to the description of the old version of Heal
			// the Attack amount was equal to the Heal Factor, so we'll
			// simply copy the formula for the heal buff amount for now.
			var rate = 150f + (skill.Level - 1) * 103f;
			skillHitResult.Damage *= rate / 100f;

			target.TakeDamage(skillHitResult.Damage, caster);

			var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, TimeSpan.Zero, TimeSpan.Zero);
			Send.ZC_SKILL_HIT_INFO(target, skillHit);
		}

		/// <summary>
		/// Spawns heal pads on the ground that heal targets on contact.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		private void TriggerHeal(ICombatEntity caster, Skill skill)
		{
			var tileShape = new[]
			{
				10,  4,  1,  7,  13,
				11,  5,  2,  8,  14,
				12,  6,  3,  9,  15,
			};

			var refPos = caster.Position.GetRelative2D(caster.Direction, 30);

			var level = skill.Level;

			// As I currently don't have a log of the old Heal skill,
			// we'll estimate the size of the tiles. The effect scale
			// is about ~0.02 per unit.
			var size = 20;
			var scale = size * 0.02f;

			// Iterate over the shape array by row and column. Each value
			// represents a skill level required for that tile to be
			// spawned. If the caster's skill level is high enough, the
			// x and y offsets are used to calculate the position on the
			// tile grid and the monster is spawned.
			for (var yi = 0; yi < 3; ++yi)
			{
				for (var xi = 0; xi < 5; ++xi)
				{
					var minLevel = tileShape[xi + yi * 5];
					if (level < minLevel)
						continue;

					var pos = refPos.GetRelative2D(caster.Direction.Left, (xi - 2) * size);
					pos = pos.GetRelative2D(caster.Direction, yi * size);

					var area = PolygonF.Rectangle(pos, new Vector2F(size, size), caster.Direction.NormalDegreeAngle);

					var trigger = new Npc(12082, "", new Location(caster.Map.Id, pos), caster.Direction);
					trigger.Vars.Set("Melia.HealCaster", caster);
					trigger.Vars.Set("Melia.HealSkill", skill);
					trigger.SetTriggerArea(area);
					trigger.SetEnterTrigger("CLERIC_HEAL_ENTER", this.OnEnterHealingPad);

					trigger.DisappearTime = DateTime.Now.AddSeconds(10);
					caster.Map.AddMonster(trigger);

					Send.ZC_NORMAL.AttachEffect(trigger, "F_cleric_heal_loop_ground_cleric01_3", scale);
				}
			}
		}

		/// <summary>
		/// Called when a target enters a healing pad.
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		private Task OnEnterHealingPad(TriggerActorArgs args)
		{
			if (args.Initiator is not ICombatEntity initiator)
				return Task.CompletedTask;

			// I don't know how exactly the heal pads worked in the past,
			// but since it's my understanding that buffs can't be applied
			// if they're already active, someone walking over multiple
			// pads would only get healed once, but they could still
			// trigger the pads. This check will prevent that.
			if (initiator.Components.Get<BuffComponent>().Has(BuffId.Heal_Buff))
				return Task.CompletedTask;

			if (args.Trigger is not Npc trigger)
				return Task.CompletedTask;

			var caster = trigger.Vars.Get<ICombatEntity>("Melia.HealCaster");
			var skill = trigger.Vars.Get<Skill>("Melia.HealSkill");

			if (trigger.Vars.ActivateOnce("Melia.HealTriggered"))
			{
				if (initiator is Character)
				{
					this.BuffHeal(caster, initiator, skill);
				}
				else
				{
					if (initiator.MoveType != MoveType.Flying)
						this.DamageHeal(caster, initiator, skill);
				}

				Send.ZC_NORMAL.ClearEffects(trigger);
				trigger.DisappearTime = DateTime.Now.AddSeconds(1);
			}

			return Task.CompletedTask;
		}

		/// <summary>
		/// Returns the amount of SP the skill uses.
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		[SkillSpOverride(SkillId.Cleric_Heal)]
		public float GetSpendSp(Skill skill)
		{
			var SCR_Get_SpendSP = ScriptableFunctions.Skill.Get("SCR_Get_SpendSP");

			var value = SCR_Get_SpendSP(skill);

			// The exact formula to increase the SP cost by based on
			// overbuffing is currently unknown
			var overbuffCount = skill.Owner.GetOverbuffCount(BuffId.Heal_Overload_Buff);
			value += (value * 0.5f * overbuffCount);

			// "Bonus effects are applied when the caster has advanced
			// into certain classes"
			if (skill.Owner.Components.TryGet<JobComponent>(out var jobs))
			{
				// "Priest: Decreases SP consumption by 25"
				if (jobs.Has(JobId.Priest))
					value -= 25;

				// "Pardoner: Decreases SP consumption by 50"
				if (jobs.Has(JobId.Pardoner))
					value -= 50;
			}

			return (int)Math.Max(0, value);
		}
	}
}
