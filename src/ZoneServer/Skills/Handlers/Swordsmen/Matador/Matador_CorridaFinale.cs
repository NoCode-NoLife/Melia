using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Abilities.Handlers.Swordsmen.Peltasta;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Matador
{
	/// <summary>
	/// Handler for the Matador skill Corrida Finale
	/// </summary>
	[SkillHandler(SkillId.Matador_CorridaFinale)]
	public class Matador_CorridaFinale : ISelfSkillHandler
	{
		/// <summary>
		/// Handles skill, dashes backwards
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

			Send.ZC_SKILL_READY(caster, skill, caster.Position, Position.Zero);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, caster.Handle, caster.Position, dir, Position.Zero);
			Send.ZC_SKILL_MELEE_TARGET(caster, skill, caster, null);

			CallSafe(this.CreatePad(skill, caster));
		}

		/// <summary>
		/// Moves the pad forward
		/// creator is facing.
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		/// <returns></returns>
		private async Task CreatePad(Skill skill, ICombatEntity caster)
		{
			var delay = TimeSpan.FromMilliseconds(350);
			await Task.Delay(delay);

			var pad = new Pad(PadName.Matador_CorridaFinale, caster, skill, new Square(caster.Position.GetRelative(caster.Direction, 200), caster.Direction.Backwards, 120, 60));
			pad.Trigger.LifeTime = TimeSpan.FromSeconds(4.5f);
			pad.Position = caster.Position.GetRelative(caster.Direction, 200);
			pad.Direction = caster.Direction.Backwards;
			pad.Trigger.Subscribe(TriggerType.Enter, this.OnCollisionEnter);
			pad.Variables.SetBool("OpositeDirection", false);

			caster.Map.AddPad(pad);

			// Corrida Finale: Encore
			// Spawns another Bull that runs on the oposite direction
			if (caster.IsAbilityActive(AbilityId.Matador15))
			{
				var secondDelay = TimeSpan.FromSeconds(2f);
				await Task.Delay(secondDelay);

				var pad2 = new Pad(PadName.Matador_CorridaFinale, caster, skill, new Square(caster.Position.GetRelative(caster.Direction.Backwards, 200), caster.Direction, 120, 60));
				pad2.Trigger.LifeTime = TimeSpan.FromSeconds(4.5f);
				pad2.Position = caster.Position.GetRelative(caster.Direction.Backwards, 200);
				pad2.Direction = caster.Direction;
				pad2.Trigger.Subscribe(TriggerType.Enter, this.OnCollisionEnter);
				pad2.Variables.SetBool("OpositeDirection", true);

				caster.Map.AddPad(pad2);
			}
		}

		/// <summary>
		/// Called when an actor enters the skill pad's trigger area.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnCollisionEnter(object sender, PadTriggerActorArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;
			var target = args.Initiator;

			if (pad.Trigger.AtCapacity)
				return;

			if (!creator.CanAttack(target))
				return;

			this.Attack(pad.Skill, creator, target);
		}

		/// <summary>
		/// Attacks the target one time.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		private void Attack(Skill skill, ICombatEntity caster, ICombatEntity target)
		{
			var modifier = SkillModifier.MultiHit(6);

			var knockBackInfo = new KnockBackInfo(caster.Position, target.Position, HitType.KnockBack, 55, -210);
			target.Position = knockBackInfo.ToPosition;

			Send.ZC_KNOCKDOWN_INFO(caster, target, knockBackInfo);

			var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);

			var targetSize = SizeType.M;

			if (target is Mob mob)
				targetSize = mob.Data.Size;

			// Increase Final Damage by 20% against Large and Boss monsters
			if (targetSize == SizeType.L || target.Rank == MonsterRank.Boss)
				modifier.FinalDamageMultiplier += 0.2f;

			target.TakeDamage(skillHitResult.Damage, caster);

			var hit = new HitInfo(caster, target, skill, skillHitResult.Damage, skillHitResult.Result, modifier.HitCount, TimeSpan.FromMilliseconds(150));

			Send.ZC_HIT_INFO(caster, target, hit);
		}
	}
}
