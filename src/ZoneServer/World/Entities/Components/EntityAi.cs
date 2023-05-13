using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Melia.Zone.Network;
using Melia.Zone.World.Entities.Components.AI;
using Melia.Zone.World.Entities.Components.AI.Events;
using Melia.Shared.Tos.Const;
using Melia.Shared.EntityComponents;
using Melia.Shared.Util;
using Melia.Shared.World;

namespace Melia.Zone.World.Entities.Components
{
	/// <summary>
	/// An AI component, that controls an entity.
	/// </summary>
	public partial class EntityAi : IUpdatableComponent
	{
		public void Update(TimeSpan elapsed)
		{
		}
	}
}
