using Melia.Zone.Buffs.Base;
using Melia.Shared.Tos.Const;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for DaggerSlash_Buff, which affects the character attack.
	/// </summary>
	[BuffHandler(BuffId.DaggerSlash_Buff)]
	public class DaggerSlash_Buff : BuffHandler
	{
		/// <summary>
		/// Starts buff, modifying the attack.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			// TODO: Something with the attack based on number of daggers equiped.
		}

		/// <summary>
		/// Ends the buff, resetting the attack.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			// TODO: Reset
		}
	}
}
