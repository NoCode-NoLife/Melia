using Melia.Channel.World;

namespace Melia.Channel.Buffs.Base
{
	/// <summary>
	/// Base class for buff handlers.
	/// </summary>
	public abstract class BuffHandler : IBuffHandler
	{
		/// <summary>
		/// Starts the buff, adding the initial effects.
		/// </summary>
		/// <param name="buff"></param>
		public virtual void OnStart(Buff buff)
		{
		}

		/// <summary>
		/// Called regularly, for effects that occur during while the
		/// buff is active.
		/// </summary>
		/// <param name="buff"></param>
		public virtual void WhileActive(Buff buff)
		{
		}

		/// <summary>
		/// Ends the buff, resetting any changes the buff made.
		/// </summary>
		/// <param name="buff"></param>
		public virtual void OnEnd(Buff buff)
		{
		}
	}
}
