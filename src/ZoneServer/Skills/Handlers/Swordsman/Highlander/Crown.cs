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
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Util;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Swordsman.Highlander
{
    /// <summary>
    /// Handler for the Highlander skill Crown.
    /// </summary>
    [SkillHandler(SkillId.Highlander_Crown)]
    public class Highlander_Crown : IGroundSkillHandler
    {
        private const float DefPenetrationPerLevel = 0.01f;
        private const float BuffRemoveChancePerLevel = 33f;

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

            var splashParam = skill.GetSplashParameters(caster, originPos, farPos, length: 65, width: 25, angle: 0);
            var splashArea = skill.GetSplashArea(SplashType.Square, splashParam);

            Send.ZC_SKILL_READY(caster, skill, originPos, farPos);
            Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);

            this.Attack(skill, caster, splashArea);
        }

        /// <summary>
        /// Executes the actual attack after a delay.
        /// </summary>
        /// <param name="skill"></param>
        /// <param name="caster"></param>
        /// <param name="splashArea"></param>
        private async void Attack(Skill skill, ICombatEntity caster, ISplashArea splashArea)
        {
            var hitDelay = TimeSpan.FromMilliseconds(300);
            var damageDelay = TimeSpan.FromMilliseconds(50);
            var skillHitDelay = TimeSpan.Zero;

            await Task.Delay(hitDelay);

            var targets = caster.Map.GetAttackableEntitiesIn(caster, splashArea);
            var hits = new List<SkillHitInfo>();

            foreach (var target in targets.LimitBySDR(caster, skill))
            {
                var modifier = SkillModifier.MultiHit(2);
                modifier.DefensePenetrationRate = DefPenetrationPerLevel * skill.Level;

                var skillHitResult = SCR_SkillHit(caster, target, skill, modifier);
                target.TakeDamage(skillHitResult.Damage, caster);

                var skillHit = new SkillHitInfo(caster, target, skill, skillHitResult, damageDelay, skillHitDelay);
                skillHit.HitEffect = HitEffect.Impact;
                hits.Add(skillHit);

                var debuffTime = 5f + 0.5f * skill.Level;

                // In earlier versions, this skill instead inflicted Common_Shock
                target.StartBuff(BuffId.Crown_Armor_Debuff, skill.Level, 0, TimeSpan.FromSeconds(debuffTime), caster);

                var buffRemoveChance = BuffRemoveChancePerLevel * skill.Level;
                var rnd = RandomProvider.Get();
                if (rnd.Next(1000) < buffRemoveChance)
                {
                    if (target.Components.TryGet<BuffComponent>(out var buffComponent))
                    {
                        buffComponent.RemoveRandomBuff();
                    }
                }
            }

            Send.ZC_SKILL_HIT_INFO(caster, hits);
        }
    }
}
