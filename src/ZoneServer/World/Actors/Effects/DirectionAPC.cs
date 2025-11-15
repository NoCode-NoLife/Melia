using System;
using Melia.Zone.Network;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World.Actors.Effects
{
	/// <summary>
	/// Effect that animates an NPC along a track path.
	/// </summary>
	public class DirectionAPC : Effect, IUpdateable
	{
		private readonly static TimeSpan DefaultUpdateInterval = TimeSpan.FromSeconds(7);
		private DateTime _lastUpdate;

		/// <summary>
		/// Gets or sets the update interval for the animation.
		/// </summary>
		public TimeSpan UpdateInterval { get; set; } = DefaultUpdateInterval;

		/// <summary>
		/// Gets the track string name.
		/// </summary>
		public string EffectString { get; }

		/// <summary>
		/// Gets the track string ID.
		/// </summary>
		public int EffectId { get; }

		/// <summary>
		/// Gets the starting track index.
		/// </summary>
		public int I1 { get; }

		/// <summary>
		/// Gets the ending track index.
		/// </summary>
		public int I2 { get; }

		/// <summary>
		/// Gets the actor this effect is applied to.
		/// </summary>
		public IActor Actor { get; private set; }

		/// <summary>
		/// Gets the current track index.
		/// </summary>
		public int TrackIndex { get; private set; }

		/// <summary>
		/// Creates a new DirectionAPC effect.
		/// </summary>
		/// <param name="packetString">The track animation string</param>
		/// <param name="i1">Start index</param>
		/// <param name="i2">End index</param>
		public DirectionAPC(string packetString, int i1, int i2)
		{
			if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString, out var data))
			{
				throw new ArgumentException($"Packet string '{packetString}' not found.");
			}

			this.EffectString = packetString;
			this.EffectId = data.Id;
			this.I1 = i1;
			this.I2 = i2;
		}

		/// <summary>
		/// Shows the effect by initializing the track animation.
		/// </summary>
		/// <param name="conn">The connection to show the effect to.</param>
		/// <param name="actor">The actor that owns the effect.</param>
		public override void ShowEffect(IZoneConnection conn, IActor actor)
		{
			this.Actor = actor;
			this.TrackIndex = this.I1 - 1;
			Send.ZC_DIRECTION_APC(conn, actor, this.EffectId, this.I1, this.I2, (float)ZoneServer.Instance.World.WorldTime.Elapsed.TotalSeconds);
		}

		/// <summary>
		/// Updates the track animation.
		/// </summary>
		/// <param name="elapsed">Time elapsed since last update.</param>
		public void Update(TimeSpan elapsed)
		{
			var now = DateTime.Now;
			var sinceLastUpdate = now - _lastUpdate;

			if (sinceLastUpdate >= this.UpdateInterval && this.Actor != null)
			{
				if (this.TrackIndex >= this.I2)
					this.TrackIndex = 1;
				else
					this.TrackIndex += 1;

				Send.ZC_NORMAL.NPC_PlayTrack(this.Actor, this.EffectString, this.I1, this.TrackIndex, (float)ZoneServer.Instance.World.WorldTime.Elapsed.TotalSeconds);
				_lastUpdate = now;
			}
		}
	}
}
