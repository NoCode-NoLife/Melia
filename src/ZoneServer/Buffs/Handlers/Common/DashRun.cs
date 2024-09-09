using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Abilities.Handlers.Swordsmen.Barbarian;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Yggdrasil.Logging;

namespace Melia.Zone.Buffs.Handlers.Common
{
	/// <summary>
	/// Handler DashRun, the movement speed buff for running.
	/// </summary>
	[BuffHandler(BuffId.DashRun)]
	public class DashRun : BuffHandler
	{
		/// <summary>
		/// Starts the buff, increasing the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var target = (Character)buff.Target;
			var speedBonus = this.GetSpeedBonus(target);

			// Usually the game uses DashRun to signal that the actor
			// is dashing, and this increases the amount of stamina
			// used during movement in Recovery. This does work, but
			// it would be nice to have control over the usage amount
			// from the buff itself. This isn't quite possible as long
			// as we limit ourselves to properties and the client's
			// formulas though, as there is no "stamina usage" property.
			// I'll leave it like this for now, but we might want to
			// think about adding a "modifier" system that lets us
			// modify properties temporarily outside of the normal
			// system.

			// Set dash property and add movement speed bonus
			target.Properties.SetFloat(PropertyName.DashRun, 1);
			target.Properties.Modify(PropertyName.MSPD_BM, speedBonus);

			Send.ZC_MOVE_SPEED(target);

			// DashRun doesn't have an update time by default, but we want to
			// make some checks on its update, so we're going to change this.
			buff.UpdateTime = TimeSpan.FromMilliseconds(100);
			buff.NextUpdateTime = DateTime.Now.Add(buff.UpdateTime);
		}

		/// <summary>
		/// Ends buff, resetting the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			var target = (Character)buff.Target;
			var speedBonus = this.GetSpeedBonus(target);

			target.Properties.SetFloat(PropertyName.DashRun, 0);
			target.Properties.Modify(PropertyName.MSPD_BM, -speedBonus);

			Send.ZC_MOVE_SPEED(target);
		}

		/// <summary>
		/// Executed regularly while the buff is active, stops it once
		/// the target is out of stamina.
		/// </summary>
		/// <param name="buff"></param>
		public override void WhileActive(Buff buff)
		{
			var target = (Character)buff.Target;

			var minStamina = target.Properties.GetFloat(PropertyName.Sta_Runable);

			if (target.Properties.Stamina < minStamina)
				target.StopBuff(BuffId.DashRun);

			Barbarian28.TryApplyBuff(target);
		}

		/// <summary>
		/// Returns the speed bonus granted while running.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		private float GetSpeedBonus(Character target)
		{
			return 13;
		}
	}
}
