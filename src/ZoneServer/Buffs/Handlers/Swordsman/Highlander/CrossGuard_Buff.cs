using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Characters.Components;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Highlander
{
	/// <summary>
	/// Handle for the Cross Guard Buff, which increases the target's block rate,
	/// but prevents evasion.  It also inflicts a buff if you get hit while
	/// having it, which also puts the skill on cooldown.
	/// </summary>
	[BuffHandler(BuffId.CrossGuard_Buff)]
	public class CrossGuard_Buff : BuffHandler
	{
		private const float BlkRateBonusPerLevel = 0.01f;
		private const float DebuffDuration = 5f;

		public override void OnStart(Buff buff)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.BLK_RATE_BM, GetBlkBonus(buff));
			AddPropertyModifier(buff, buff.Target, PropertyName.DR_RATE_BM, -1f);
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.BLK_RATE_BM);
			RemovePropertyModifier(buff, buff.Target, PropertyName.DR_RATE_BM);
		}

		/// <summary>
		/// Returns the Block bonus to use
		/// </summary>
		/// <param name="buff"></param>
		/// <returns></returns>
		private float GetBlkBonus(Buff buff)
		{
			// Some forum posts suggest your base level may affect the formula?
			return BlkRateBonusPerLevel * buff.NumArg1;
		}

		/// <summary>
		/// Called when a CrossGuard user gets hit
		/// Applies a buff to the CrossGuard user, and also
		/// adds a 15 second cooldown to CrossGuard
		/// Returns false if the target doesn't have the buff
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		public static bool TryHitCrossGuardEffect(ICombatEntity attacker, ICombatEntity target)
		{
			if (!target.TryGetBuff(BuffId.CrossGuard_Buff, out var buff))
			{
				return false;
			}

			// this previously instead applied a debuff to the attacker
			// attacker.StartBuff(BuffId.CrossGuard_Debuff, buff.NumArg1, 0, TimeSpan.FromSeconds(DebuffDuration), target);

			target.StartBuff(BuffId.CrossGuard_Damage_Buff, buff.NumArg1, 0, TimeSpan.FromSeconds(DebuffDuration), target);
			
			if (target is Character targetCharacter && target.Components.TryGet<CooldownComponent>(out var cooldownComponent))
			{
				if (targetCharacter.Skills.TryGet(SkillId.Highlander_CrossGuard, out var skill))
				{
					cooldownComponent.Start(skill.Data.CooldownGroup, TimeSpan.FromSeconds(15));
					Send.ZC_OVERHEAT_CHANGED(targetCharacter, skill);
				}
			}

			return true;
		}
	}
}
