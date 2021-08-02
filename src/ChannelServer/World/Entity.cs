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
		event EventHandler<OnEntityEventArgs> Died; 
	}

	public class OnEntityEventArgs : EventArgs
	{
		public OnEntityEventArgs(int handle) {
			this.Handle = handle;
		}
		public int Handle { get; set; }
	}
}
