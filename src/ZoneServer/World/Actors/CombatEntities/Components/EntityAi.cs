using System;
using Yggdrasil.Composition;

namespace Melia.Zone.World.Actors.CombatEntities.Components
{
	/// <summary>
	/// An AI component, that controls an entity.
	/// </summary>
	public partial class EntityAi : CombatEntityComponent, IUpdatableComponent
	{
		public EntityAi(ICombatEntity entity) : base(entity)
		{
		}

		public void Update(TimeSpan elapsed)
		{
		}
	}
}
