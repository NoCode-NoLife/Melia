using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;
using Yggdrasil.Util;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Restrain Buff, which reduces maximum HP
	/// in exchange for a chance to stun on normal attacks.
	/// </summary>
	[BuffHandler(BuffId.Restrain_Buff)]
	public class Restrain : BuffHandler
	{
		private const string VarName = "Melia.MaxHPPenalty";
		private const float MaxHPDropBase = 50f;
		private const float MaxHPDropPerLevel = 28f;
		private const float StunDuration = 3f;

		public override void OnStart(Buff buff)
		{
			var penalty = this.GetMaxHPPenalty(buff);
			buff.Vars.SetFloat(VarName, penalty);

			buff.Target.Properties.Modify(PropertyName.MHP_BM, -penalty);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(VarName, out var penalty))
				buff.Target.Properties.Modify(PropertyName.MHP_BM, penalty);
		}

		private float GetMaxHPPenalty(Buff buff)
		{
			var skillLevel = buff.NumArg1;
			return MaxHPDropBase + skillLevel * MaxHPDropPerLevel;
		}


		/// <summary>
		/// Attempts to stun the target
		/// Returns false if the caster doesn't have the buff, the skill isn't allowed to stun the target,
		/// or the target resists the stun attempt
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="damage"></param>
		/// <returns></returns>
		public static bool StunTarget(ICombatEntity attacker, ICombatEntity target, Skill skill, Random rnd)
		{
			if (!attacker.TryGetBuff(BuffId.Restrain_Buff, out var restrainBuff))
				return false;

			if (!skill.IsNormalAttack)
				return false;

			var stunChance = restrainBuff.NumArg2;

			if (rnd.Next(100) < stunChance)
			{
				target.StartBuff(BuffId.Stun, skill.Level, 0, TimeSpan.FromSeconds(StunDuration), attacker);
				return true;
			}

			return false;
		}
	}
}
