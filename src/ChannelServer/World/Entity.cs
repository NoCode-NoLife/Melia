// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using Melia.Shared.World;

namespace Melia.Channel.World
{
	public interface IEntity
	{
		int Handle { get; }
		int Hp { get; }
		Map Map { get; }
		Position Position { get; }
	}

	public interface IEntityEvent
	{
		/// <summary>
		/// Event thrown on death
		/// </summary>
		event EventHandler<EntityEventArgs> Died;
	}

	public class EntityEventArgs : EventArgs
	{
		public int Handle { get; set; }

		public EntityEventArgs(int handle)
		{
			this.Handle = handle;
		}
	}
}
