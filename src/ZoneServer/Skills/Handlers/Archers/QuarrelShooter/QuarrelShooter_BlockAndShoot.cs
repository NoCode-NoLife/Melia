using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;
using Yggdrasil.Util;
using static Melia.Shared.Util.TaskHelper;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsmen.Highlander
{
	/// <summary>
	/// Handler for the Quarrel Shooter skill Block and Shoot.
	/// </summary>
	[SkillHandler(SkillId.QuarrelShooter_BlockAndShoot)]
	public class QuarrelShooter_BlockAndShoot : IGroundSkillHandler, IDynamicCasted
	{
		private const int TotalHits = 6;

		public void StartDynamicCast(Skill skill, ICombatEntity caster)
		{
			//Send.ZC_PLAY_SOUND_Gendered(caster, "voice_archer_m_blockandshoot_cast", "voice_archer_f_blockandshoot_cast");

			// QuarrelShooter35 alters the buff significantly
			var coveredShotVersion = 0;
			if (caster.IsAbilityActive(AbilityId.QuarrelShooter35))
				coveredShotVersion++;

			caster.StartBuff(BuffId.BlockAndShoot_Buff, skill.Level, coveredShotVersion, TimeSpan.FromSeconds(3), caster);
		}

		/// <summary>
		/// Called when the user stops casting the skill.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		public void EndDynamicCast(Skill skill, ICombatEntity caster)
		{
			//Send.ZC_STOP_SOUND_Gendered(caster, "voice_archer_m_blockandshoot_cast", "voice_archer_f_blockandshoot_cast");
			caster.StopBuff(BuffId.BlockAndShoot_Buff);
		}


		/// <summary>
		/// Handles skill, creating a pad
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

			var splashParam = skill.GetSplashParameters(caster, originPos, originPos, length: 100, width: 50, angle: 0);
			var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

			Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

			CallSafe(this.SetPad(skill, caster, splashArea));
		}

		/// <summary>
		/// Places the pad
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="splashArea"></param>
		private async Task SetPad(Skill skill, ICombatEntity caster, ISplashArea padArea)
		{
			var initialDelay = TimeSpan.FromMilliseconds(300);
			var skillHitDelay = TimeSpan.Zero;

			await Task.Delay(initialDelay);

			// TODO Missing animation.  Needs MSL Pad Throw

			var pad = new Pad(PadName.QuarrelShooter_BlockAndShoot, caster, skill, padArea);
			pad.Position = caster.Position.GetRelative(caster.Direction, 50f);
			// Base target count 2, gains 1 more for every 3 AOE attack ratio
			pad.Trigger.MaxActorCount = 2 + (int)(caster.Properties.GetFloat(PropertyName.SR) / 3f);
			// Although the description says the cast lasts 3 seconds,
			// it actually only lasts a bit over 2 seconds, so the pad
			// hits slightly more often than 500ms to deal all 5 hits
			pad.Trigger.LifeTime = TimeSpan.FromMilliseconds(2400);
			pad.Trigger.UpdateInterval = TimeSpan.FromMilliseconds(400);
			pad.Trigger.Subscribe(TriggerType.Create, this.Attack);
			pad.Trigger.Subscribe(TriggerType.Update, this.Attack);

			caster.Map.AddPad(pad);
		}

		/// <summary>
		/// Called by the pad every 0.5 sec to damage
		/// targets inside of it
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		private void Attack(object sender, PadTriggerArgs args)
		{
			var pad = args.Trigger;
			var creator = args.Creator;
			var skill = args.Skill;

			// skill ends early if you stop the dynamic cast
			if (!creator.IsCasting())
			{
				pad.Destroy();
				return;
			}

			var damageDelay = TimeSpan.FromMilliseconds(50);
			var skillHitDelay = TimeSpan.Zero;

			var targets = pad.Trigger.GetAttackableEntities(creator);
			var hits = new List<SkillHitInfo>();

			foreach (var target in targets)
			{
				var modifier = SkillModifier.Default;

				// At some point this skill gained 15% of your shield's Def
				// modifier.BonusPAtk += GetBonusPAtk(creator);

				var skillHitResult = SCR_SkillHit(creator, target, skill);
				target.TakeDamage(skillHitResult.Damage, creator);

				var skillHit = new SkillHitInfo(creator, target, skill, skillHitResult, damageDelay, skillHitDelay);
				skillHit.HitEffect = HitEffect.Impact;

				hits.Add(skillHit);
			}

			Send.ZC_SKILL_HIT_INFO(creator, hits);
		}

		/// <summary>
		/// Calculates bonus PATK if using a shield
		/// </summary>
		/// <param name="caster"></param>
		private float GetBonusPAtk(ICombatEntity caster)
		{
			if (!caster.Components.TryGet<InventoryComponent>(out var inv))
				return 0;

			var lhItem = inv.GetItem(EquipSlot.LeftHand);
			if (lhItem.Data.EquipType1 != EquipType.Shield)
				return 0;

			var shieldDef = lhItem.Data.Def;
			var bonusPatk = 0.15f * shieldDef;

			return bonusPatk;
		}
	}
}
