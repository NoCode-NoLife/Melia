using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Buffs.Handlers.Swordsman.Highlander
{
	/// <summary>
	/// Handle for the Cross Guard Buff, which increases the target's block rate,
	/// but prevents evasion.
	/// </summary>
	[BuffHandler(BuffId.CrossGuard_Buff)]
	public class CrossGuard_Buff : BuffHandler
	{
		private const float BlkRateBonusPerLevel = 0.01f;
		private const float DebuffDuration = 5f;

		public override void OnStart(Buff buff)
		{
			AddPropertyModifier(buff, buff.Target, PropertyName.BLK_RATE_BM, this.GetBlkBonus(buff));
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
		/// Handles Cross Guard's hit effects. Returns false if the target doesn't
		/// have the buff.
		/// </summary>
		/// <remarks>
		/// The behavior of this buff has changed over time, but generally it
		/// applies (de)buffs and might put the Cross Guard skill on cooldown.
		/// </remarks>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <returns></returns>
		public static bool TryApplyEffect(ICombatEntity attacker, ICombatEntity target)
		{
			if (!target.TryGetBuff(BuffId.CrossGuard_Buff, out var buff))
				return false;

			// this previously instead applied a debuff to the attacker
			// attacker.StartBuff(BuffId.CrossGuard_Debuff, buff.NumArg1, 0, TimeSpan.FromSeconds(DebuffDuration), target);

			target.StartBuff(BuffId.CrossGuard_Damage_Buff, buff.NumArg1, 0, TimeSpan.FromSeconds(DebuffDuration), target);

			if (target.Components.TryGet<SkillComponent>(out var skills) && skills.TryGet(SkillId.Highlander_CrossGuard, out var skill))
				skill.StartCooldown(TimeSpan.FromSeconds(15));

			return true;
		}
	}
}
