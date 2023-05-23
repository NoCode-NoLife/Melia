using Yggdrasil.Composition;

namespace Melia.Zone.World.Actors.CombatEntities.Components
{
	/// <summary>
	/// A component for a combat entity.
	/// </summary>
	public abstract class CombatEntityComponent : IComponent
	{
		/// <summary>
		/// Returns the owner of this component.
		/// </summary>
		public ICombatEntity Entity { get; }

		/// <summary>
		/// Initializes component's properties.
		/// </summary>
		/// <param name="entity"></param>
		public CombatEntityComponent(ICombatEntity entity)
		{
			this.Entity = entity;
		}
	}
}
