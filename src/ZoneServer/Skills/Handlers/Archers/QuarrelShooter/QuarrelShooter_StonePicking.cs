using System;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Yggdrasil.Util;

namespace Melia.Zone.Skills.Handlers.Archers.QuarrelShooter
{
	/// <summary>
	/// Handler for the Quarrel Shooter skill Pick Stone.
	/// </summary>
	[SkillHandler(SkillId.QuarrelShooter_StonePicking)]
	public class QuarrelShooter_StonePicking : IGroundSkillHandler
	{
		private const int StoneBulletId = 645503;


		/// <summary>
		/// Handles skill, acquiring Stone Bullets
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

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, originPos, null);

			var quantity = skill.Level;

			// Initially, the quantity was random between 1 and skill.level
			// unless you had QuarrelShooter6

			//if (!caster.IsAbilityActive(AbilityId.QuarrelShooter6)) { 
			//	quantity = RandomProvider.Get().Next(skill.Level);
			//}

			if (caster.Components.TryGet<InventoryComponent>(out var inventory)) 
			{
				inventory.Add(StoneBulletId, quantity, InventoryAddType.PickUp);
			}
		}
	}
}
