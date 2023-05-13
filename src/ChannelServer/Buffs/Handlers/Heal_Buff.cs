using Melia.Channel.Buffs.Base;
using Melia.Channel.World;
using Melia.Shared.Tos.Const;

namespace Melia.Channel.Buffs.Handlers
{
	/// <summary>
	/// Handler for Heal_Buff, that heals on use.
	/// </summary>
	[BuffHandler(BuffId.Heal_Buff)]
	public class HealBuffHandler : BuffHandler
	{
		/// <summary>
		/// Starts the buff, healing the target.
		/// </summary>
		/// <param name="buff"></param>
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;

			//target.Heal(HealType.Hp, (int)(target.Properties.GetFloat(PropertyId.PC.MHP) * 5) / 100);
		}
	}
}
