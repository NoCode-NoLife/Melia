using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;

namespace Melia.Channel.World
{
	public interface IVisitor
	{
		/// <summary>
		/// This function is called from a sector (see SectorManager) when a IVisitor could be interacting with Actor.
		/// Actual interaction should be confirmed inside OnVisit.
		/// </summary>
		bool OnVisit(Actor actor);
	}
}
