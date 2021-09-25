using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.World.Entities;
using Melia.Shared.Const;

namespace Melia.Channel.Buffs.Base
{
	public interface IBuffHandler
	{
		void OnStart(BuffId buffId, ICombatEntity target);
		void WhileActive(BuffId buffId, ICombatEntity target);
		void OnEnd(BuffId buffId, ICombatEntity target);
	}
}
