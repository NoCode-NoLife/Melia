// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using Melia.Shared.Util;

namespace Melia.Shared.Network
{
	/// <summary>
	/// Specifies required methods for packet handlers.
	/// </summary>
	/// <typeparam name="Connection"></typeparam>
	public interface IPacketHandler<TConnection> where TConnection : Connection
	{
		/// <summary>
		/// Handles packet from connection.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		void Handle(TConnection conn, Packet packet);
	}

	/// <summary>
	/// A packet handler that runs other handlers based on their op.
	/// </summary>
	/// <typeparam name="Connection"></typeparam>
	public abstract class PacketHandler<TConnection> : IPacketHandler<TConnection> where TConnection : Connection
	{
		private Dictionary<int, PacketHandlerFunc> _handlers;

		/// <summary>
		/// A delegate used to handle a packet.
		/// </summary>
		/// <typeparam name="Connection"></typeparam>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		public delegate void PacketHandlerFunc(TConnection conn, Packet packet);

		/// <summary>
		/// Creates new packet handler.
		/// </summary>
		public PacketHandler()
		{
			_handlers = new Dictionary<int, PacketHandlerFunc>();
		}

		/// <summary>
		/// Runs handler for packet's op if there is one.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		public void Handle(TConnection conn, Packet packet)
		{
			PacketHandlerFunc handler;

			lock (_handlers)
				_handlers.TryGetValue(packet.Op, out handler);

			if (handler == null)
			{
				this.OnUnknownPacket(conn, packet);
				return;
			}

			handler(conn, packet);
		}

		/// <summary>
		/// Called when there's no handler for an op.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		protected virtual void OnUnknownPacket(TConnection conn, Packet packet)
		{
			Log.Debug("PacketHandler: No handler found for '{0:X4}', {1}.\n{2}", packet.Op, Op.GetName(packet.Op), packet.ToString());
		}

		/// <summary>
		/// Registers handler for op.
		/// </summary>
		/// <param name="op"></param>
		/// <param name="handler"></param>
		public void Register(int op, PacketHandlerFunc handler)
		{
			lock (_handlers)
				_handlers[op] = handler;
		}

		/// <summary>
		/// Registers handler for op.
		/// </summary>
		/// <param name="op"></param>
		/// <param name="handler"></param>
		public void Register(int op, IPacketHandler<TConnection> handler)
		{
			lock (_handlers)
				_handlers[op] = handler.Handle;
		}

		/// <summary>
		/// Registers all methods of this class that have a packet handler attribute.
		/// </summary>
		public void RegisterMethods()
		{
			foreach (var method in this.GetType().GetMethods())
			{
				foreach (PacketHandlerAttribute attr in method.GetCustomAttributes(typeof(PacketHandlerAttribute), false))
				{
					var func = (PacketHandlerFunc)Delegate.CreateDelegate(typeof(PacketHandlerFunc), this, method);
					foreach (var op in attr.Ops)
						this.Register(op, func);
				}
			}
		}
	}

	/// <summary>
	/// Specifies ops that the packet handler can be used for.
	/// </summary>
	public class PacketHandlerAttribute : Attribute
	{
		/// <summary>
		/// Ops the handler can be used for.
		/// </summary>
		public int[] Ops { get; private set; }

		/// <summary>
		/// Creates new packet handler attribute.
		/// </summary>
		/// <param name="ops"></param>
		public PacketHandlerAttribute(params int[] ops)
		{
			this.Ops = ops;
		}
	}
}
