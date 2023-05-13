using Melia.Zone.World;

namespace Melia.Zone.Buffs.Base
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
