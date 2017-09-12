// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see licence.txt in the main folder

using Melia.Shared.World.ObjectProperties;

namespace Melia.Channel.World
{
	/// <summary>
	/// Represents an identifiable object with properties.
	/// </summary>
	public interface IPropertyObject
	{
		/// <summary>
		/// The object's globally unique id.
		/// </summary>
		long ObjectId { get; }

		/// <summary>
		/// The object's properties.
		/// </summary>
		Properties Properties { get; }
	}
}
