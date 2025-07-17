using System;
using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Abilities.Handlers.Swordsmen.Peltasta;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Pads.Handlers.Swordsman.Matador
{
	/// <summary>
	/// Handler for the Corrida Finale Hidden pad, spawning fire on the floor
	/// </summary>
	[PadHandler(PadName.Matador_CorridaFinale_Hidden)]
	public class Matador_CorridaFinale_Hidden : ICreatePadHandler, IDestroyPadHandler
	{
		/// <summary>
		/// Called when the pad is created.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Created(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;

			pad.Trigger.MaxActorCount = 5;
			pad.Trigger.Subscribe(TriggerType.Update, this.OnTriggerUpdate);

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Matador_CorridaFinale_Hidden, 0.1500001f, 120, 15, true);
		}

		/// <summary>
		/// Called when the pad is destroyed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Destroyed(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;

			Send.ZC_NORMAL.PadUpdate(creator, pad, PadName.Matador_CorridaFinale_Hidden, 0.1500001f, 120, 15, false);
		}

		/// <summary>
		/// Called when an actor enters the area of the attack.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void OnTriggerUpdate(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var caster = args.Creator;
			var skill = args.Skill;

			var targets = pad.Trigger.GetAttackableEntities(caster);

			foreach (var target in targets.LimitRandom(pad.Trigger.MaxActorCount))
			{
				this.Attack(skill, caster, target);
			}
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
