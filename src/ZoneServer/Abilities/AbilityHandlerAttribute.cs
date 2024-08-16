using System;
using Melia.Shared.Game.Const;

namespace Melia.Zone.Abilities
{
	/// <summary>
	/// Used to mark ability handler classes, which are then automatically
	/// loaded by the ability handler manager.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class AbilityHandlerAttribute : Attribute
	{
		/// <summary>
		/// Returns the ids of the abilities this handler is supposed to
		/// be used for.
		/// </summary>
		public AbilityId[] Ids { get; }

		/// <summary>
		/// Creates new attribute for the ability ids.
		/// </summary>
		/// <param name="ids"></param>
		public AbilityHandlerAttribute(params AbilityId[] ids)
		{
			this.Ids = ids;
		}
	}
}
