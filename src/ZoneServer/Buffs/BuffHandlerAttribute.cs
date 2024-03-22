using System;
using Melia.Shared.Game.Const;

namespace Melia.Zone.Buffs
{
	/// <summary>
	/// Used to mark buff handler classes, which are then automatically
	/// loaded by the buff handler manager.
	/// </summary>
	public class BuffHandlerAttribute : Attribute
	{
		/// <summary>
		/// Returns the ids of the buffs this handler is supposed to
		/// be used for.
		/// </summary>
		public BuffId[] BuffIds { get; }

		/// <summary>
		/// Creates new attribute for the buff ids.
		/// </summary>
		/// <param name="buffIds"></param>
		public BuffHandlerAttribute(params BuffId[] buffIds)
		{
			this.BuffIds = buffIds;
		}
	}
}
