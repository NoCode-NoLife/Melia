using Melia.Shared.Network;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Maps;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Melia.Zone.Network
{
	/// <summary>
	/// A class that is able to send packets to an arbitrary destination.
	/// </summary>
	public interface ISender
	{
		void Send(Packet packet);
	}

	/// <summary>
	/// A sender that sends packets to a character's connection.
	/// </summary>
	public readonly struct SingleConnectionSender : ISender
	{
		/// <summary>
		/// Returns the connection to which packets will be sent.
		/// </summary>
		public IConnection Connection { get; }

		/// <summary>
		/// Creates new instance for character's connection.
		/// </summary>
		/// <param name="character"></param>
		public SingleConnectionSender(Character character)
			: this(character.Connection)
		{
		}

		/// <summary>
		/// Creates new instance for the given connection.
		/// </summary>
		/// <param name="conn"></param>
		public SingleConnectionSender(IConnection conn)
		{
			this.Connection = conn;
		}

		/// <summary>
		/// Sends the packet to the connection.
		/// </summary>
		/// <param name="packet"></param>
		public readonly void Send(Packet packet)
		{
			this.Connection.Send(packet);
		}
	}

	/// <summary>
	/// A sender that sends packets to all characters on the map.
	/// </summary>
	public readonly struct MapBroadcastSender : ISender
	{
		/// <summary>
		/// Returns the map packets will be broadcasted on.
		/// </summary>
		public Map Map { get; }

		/// <summary>
		/// Creates new instance for the map the actor is on.
		/// </summary>
		/// <param name="source"></param>
		public MapBroadcastSender(IActor source)
			: this(source.Map)
		{
		}

		/// <summary>
		/// Creates new instance for the given map.
		/// </summary>
		/// <param name="map"></param>
		public MapBroadcastSender(Map map)
		{
			this.Map = map;
		}

		/// <summary>
		/// Broadcasts the packet to all characters on the map.
		/// </summary>
		/// <param name="packet"></param>
		public readonly void Send(Packet packet)
		{
			this.Map.Broadcast(packet);
		}
	}

	/// <summary>
	/// A sender that sends packets to all characters within the sight of
	/// a specific actor.
	/// </summary>
	public readonly struct SightBroadcastSender : ISender
	{
		/// <summary>
		/// Returns the actor who will act as the source location of the
		/// broadcast.
		/// </summary>
		public IActor Source { get; }

		/// <summary>
		/// Returns whether the source actor will also receive the packet.
		/// </summary>
		/// <remarks>
		/// By default, this is true.
		/// </remarks>
		public bool IncludeSource { get; }

		/// <summary>
		/// Creates new instance for the given actor.
		/// </summary>
		/// <param name="source"></param>
		public SightBroadcastSender(IActor source)
			: this(source, true)
		{
		}

		/// <summary>
		/// Creates new instance for the given actor.
		/// </summary>
		/// <param name="source"></param>
		/// <param name="includeSource"></param>
		public SightBroadcastSender(IActor source, bool includeSource = true)
		{
			this.Source = source;
			this.IncludeSource = includeSource;
		}

		/// <summary>
		/// Sends the packet to all characters within view range of the
		/// source actor.
		/// </summary>
		/// <param name="packet"></param>
		public readonly void Send(Packet packet)
		{
			this.Source.Map.Broadcast(packet, this.Source, this.IncludeSource);
		}
	}
}
