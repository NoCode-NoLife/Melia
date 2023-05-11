using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Network;
using Yggdrasil.Logging;

namespace Melia.Shared.Network2
{
	/// <summary>
	/// Manager for packet handlers.
	/// </summary>
	/// <typeparam name="TConnection"></typeparam>
	public class PacketHandler<TConnection>
	{
		protected Dictionary<int, PacketHandlerFunc> _handlerFuncs = new Dictionary<int, PacketHandlerFunc>();

		/// <summary>
		/// Creates new packet handler and loads handler methods on itself.
		/// </summary>
		public PacketHandler()
		{
			this.LoadMethods();
		}

		/// <summary>
		/// Loads methods with the PacketHandlerAttribute inside this class.
		/// </summary>
		public void LoadMethods()
		{
			foreach (var method in this.GetType().GetMethods())
			{
				foreach (var attr in method.GetCustomAttributes(typeof(PacketHandlerAttribute), false).Cast<PacketHandlerAttribute>())
				{
					var func = (PacketHandlerFunc)Delegate.CreateDelegate(typeof(PacketHandlerFunc), this, method);
					foreach (var op in attr.Ops)
						this.Add(op, func);
				}
			}
		}

		/// <summary>
		/// Sets handler for the given op.
		/// </summary>
		/// <param name="op"></param>
		/// <param name="func"></param>
		public void Add(int op, PacketHandlerFunc func)
		{
			lock (_handlerFuncs)
				_handlerFuncs[op] = func;
		}

		/// <summary>
		/// Handles the given packet for the connection.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		/// <returns></returns>
		public bool Handle(TConnection conn, Packet packet)
		{
			// Rewind packet, so it can be read from the start. This is
			// necessary for packets that were created on the server,
			// because their internal pointer points at the end of the
			// packet after it was created.
			packet.Rewind();

			PacketHandlerFunc func;
			lock (_handlerFuncs)
				_handlerFuncs.TryGetValue(packet.Op, out func);

			if (func == null)
			{
				this.OnUnknownPacket(conn, packet);
				return false;
			}

			func(conn, packet);
			return true;
		}

		/// <summary>
		/// Called for packets that have no handler defined.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		protected virtual void OnUnknownPacket(TConnection conn, Packet packet)
		{
			Log.Debug("PacketHandler: No handler found for '{0:X4}', {1}.\n{2}", packet.Op, Op.GetName(packet.Op), packet.ToString());
		}

		/// <summary>
		/// A function that handle a packet.
		/// </summary>
		/// <param name="conn"></param>
		/// <param name="packet"></param>
		public delegate void PacketHandlerFunc(TConnection conn, Packet packet);
	}

	/// <summary>
	/// Methods with this attribute may be loaded automatically as
	/// packet handlers via "LoadMethods".
	/// </summary>
	public class PacketHandlerAttribute : Attribute
	{
		/// <summary>
		/// Returns the opcodes this handler handles.
		/// </summary>
		public int[] Ops { get; private set; }

		/// <summary>
		/// Creates new attribute.
		/// </summary>
		/// <param name="ops"></param>
		public PacketHandlerAttribute(params int[] ops)
		{
			this.Ops = ops;
		}
	}
}
