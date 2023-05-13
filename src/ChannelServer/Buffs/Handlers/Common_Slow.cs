using Melia.Channel.Buffs.Base;
using Melia.Channel.World;
using Melia.Shared.Tos.Const;

namespace Melia.Channel.Buffs.Handlers
{
	/// <summary>
	/// Handler for Common_Slow, which affects the movement speed on use.
	/// </summary>
	[BuffHandler(BuffId.Common_Slow)]
	public class CommonSlowHandler : BuffHandler
	{
		/// <summary>
		/// Starts buff, modifying the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			// TODO: Something with Move Speed
		}

		/// <summary>
		/// Ends the buff, resetting the movement speed.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnEnd(Buff buff)
		{
			// TODO: Reset move speed
		}
	}
}
