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
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Wizards.Pyromancer
{
	/// <summary>
	/// Handler for the Pyromancer skill Firewall, spawning firewall pads
	/// to stop and damage enemies.
	/// </summary>
	[SkillHandler(SkillId.Pyromancer_FireWall)]
	public class Firewall : IDynamicCasted, IGroundSkillHandler
	{
		private const int MaxCastDistance = 210;
		private const int FirewallPadSize = 15;

		/// <summary>
		/// Called when starting to cast the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
			Send.ZC_PLAY_SOUND_Gendered(caster, "voice_wiz_m_firewall_cast", "voice_wiz_firewall_cast");
		}

		/// <summary>
		/// Called when ending the skill cast.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			Send.ZC_STOP_SOUND_Gendered(caster, "voice_wiz_m_firewall_cast", "voice_wiz_firewall_cast");
		}

		/// <summary>
		/// Called after the skill finished the dynamic cast to actually
		/// spawn the firewall.
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

			var defaultTargetPos = caster.Position.GetRelative2D(caster.Direction, 25);
			var targetPos = skill.Vars.Get("Melia.ToolGroundPos", defaultTargetPos);

			if (!caster.Position.InRange2D(targetPos, MaxCastDistance))
			{
				caster.ServerMessage(Localization.Get("Too far away."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_NORMAL.UpdateSkillEffect(caster, target, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			skill.RunFree(CreateFirewallHorizontal(caster, skill, targetPos));

			// Ability "[Arts] Fire Wall: Crossfire"
			if (caster.IsAbilityActive(AbilityId.Pyromancer31))
				skill.RunFree(CreateFirewallVertical(caster, skill, targetPos));
		}

		/// <summary>
		/// Creates a horizontal wall in front of the caster at the given
		/// position.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="targetPos"></param>
		/// <returns></returns>
		public static async Task CreateFirewallHorizontal(ICombatEntity caster, Skill skill, Position targetPos)
		{
			var direction = caster.GetDirection(targetPos);
			var leftMost = targetPos.GetRelative2D(direction.Left, FirewallPadSize * 3.5f);

			for (var i = 0; i < 8; ++i)
			{
				var pos = leftMost.GetRelative2D(direction.Right, i * FirewallPadSize);

				CreateFirewallPad(caster, skill, pos, direction);
				await skill.Wait(50, false);
			}
		}

		/// <summary>
		/// Creates a vertical wall in front of the caster at the given
		/// position.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="targetPos"></param>
		/// <returns></returns>
		public static async Task CreateFirewallVertical(ICombatEntity caster, Skill skill, Position targetPos)
		{
			var direction = caster.GetDirection(targetPos);
			var topMost = targetPos.GetRelative2D(direction, FirewallPadSize * 3.5f);

			for (var i = 0; i < 8; ++i)
			{
				var pos = topMost.GetRelative2D(direction.Backwards, i * FirewallPadSize);

				CreateFirewallPad(caster, skill, pos, direction);
				await skill.Wait(50, false);
			}
		}

		/// <summary>
		/// Creates a firewall pad at the given position.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		/// <param name="targetPos"></param>
		/// <param name="orientationDirection"></param>
		public static void CreateFirewallPad(ICombatEntity caster, Skill skill, Position targetPos, Direction orientationDirection)
		{
			var useCount = 5;

			// Ability "[Arts] Fire Wall: Crossfire"
			if (caster.IsAbilityActive(AbilityId.Pyromancer31))
				useCount *= 2;

			var area = Square.Simple(targetPos, orientationDirection, FirewallPadSize, FirewallPadSize);
			//Debug.ShowShape(caster.Map, area, TimeSpan.FromSeconds(15), true, true);

			var pad = Pad.Create(PadName.Pyromancer_FireWall, caster, skill, targetPos, area, new PadOptions
			{
				LifeTime = TimeSpan.FromSeconds(15),
				MaxUseCount = useCount,
			});

			caster.Map.AddPad(pad);
		}
	}

	/// <summary>
	/// Handlers for the pads typically created by the Pyromancers'
	/// Firewall skill.
	/// </summary>
	[PadHandler(PadName.Pyromancer_FireWall)]
	public class Pyromancer_FireWall_Pad : IEnterPadHandler, IUpdatePadHandler
	{
		/// <summary>
		/// Called when an actor enters the pad.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Entered(object sender, PadTriggerActorArgs args)
		{
			this.DealDamage(args.Trigger, args.Creator, args.Skill);
		}

		/// <summary>
		/// Called in regular intervals.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Updated(object sender, PadTriggerArgs args)
		{
			this.DealDamage(args.Trigger, args.Creator, args.Skill);
		}

		/// <summary>
		/// Deals damage to enemies currently on the pad.
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="caster"></param>
		/// <param name="skill"></param>
		public void DealDamage(Pad pad, ICombatEntity caster, Skill skill)
		{
			var targets = pad.Trigger.GetAttackableEntities(caster);
			if (targets.Count == 0)
				return;

			foreach (var target in targets.LimitRandom(3))
			{
				var skillHitResult = SCR_SkillHit(caster, target, skill);

				skillHitResult.KnockBack.Type = KnockBackType.KnockBack;
				skillHitResult.KnockBack.Velocity = 150;
				skillHitResult.KnockBack.VAngle = 10;

				var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, TimeSpan.Zero, TimeSpan.Zero);

				skillHit.ApplyDamage();
				skillHit.ApplyKnockBack();

				Send.ZC_HIT_INFO(caster, target, skillHit.HitInfo);
				Send.ZC_KNOCKBACK_INFO(caster, target, skillHit.KnockBackInfo);
			}

			pad.Trigger.IncreaseUseCount();
		}
	}
}
