using Melia.Channel.World;

namespace Melia.Channel.Buffs.Base
{
	/// <summary>
	/// Buff Handler Interface
	/// </summary>
	public interface IBuffHandler
	{
		void OnStart(Buff buff);
		void WhileActive(Buff buff);
		void OnEnd(Buff buff);
	}
}
