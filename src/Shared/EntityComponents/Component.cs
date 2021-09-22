using System;

namespace Melia.Shared.EntityComponents
{
	/// <summary>
	/// Base interface for components.
	/// </summary>
	public interface IComponent
	{
	}

	/// <summary>
	/// Base interface for updatable components.
	/// </summary>
	public interface IUpdatableComponent : IComponent
	{
		/// <summary>
		/// Updates object.
		/// </summary>
		/// <param name="elapsed"></param>
		void Update(TimeSpan elapsed);
	}
}
