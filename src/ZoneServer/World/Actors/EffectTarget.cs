using System.Collections.Concurrent;
using Melia.Shared.Game.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.World.Maps;

namespace Melia.Zone.World.Actors
{
	/// <summary>
	/// An actor that can have attachable effects.
	/// </summary>
	public interface IEffectTarget : IActor
	{
		/// <summary>
		/// Returns a list of effects that are attached to the actor.
		/// </summary>
		ConcurrentBag<AttachableEffect> AttachableEffects { get; }
	}

	public static class IEffectTargetExtensions
	{
		/// <summary>
		/// Attaches an effect to the actor that is displayed alongside it
		/// and updates clients.
		/// </summary>
		/// <param name="actor"></param>
		/// <param name="effect"></param>
		public static void AttachEffect(this IEffectTarget actor, AttachableEffect effect)
		{
			actor.AttachableEffects.Add(effect);

			if (actor.Map != Map.Limbo)
				Send.ZC_NORMAL.AttachEffect(actor, effect);
		}

		/// <summary>
		/// Removes all attached effects and updates clients.
		/// </summary>
		/// <param name="actor">
		public static void ClearEffects(this IEffectTarget actor)
		{
			actor.AttachableEffects.Clear();

			if (actor.Map != Map.Limbo)
				Send.ZC_NORMAL.ClearEffects(actor);
		}
	}

	/// <summary>
	/// An effect that can be attached to an actor.
	/// </summary>
	public class AttachableEffect
	{
		/// <summary>
		/// Returns the name of the effect in form of a packet string.
		/// </summary>
		public string PacketString { get; }

		/// <summary>
		/// Returns the effect's size multiplier.
		/// </summary>
		public float Scale { get; }

		/// <summary>
		/// Gets or sets the base location the effect appears at, such as
		/// "Top" to display it above an NPC.
		/// </summary>
		public EffectLocation Location { get; set; }

		/// <summary>
		/// Gets or sets the offset the effect appears at, relative to the
		/// base location.
		/// </summary>
		public Position Offset { get; set; }

		/// <summary>
		/// Creates a new attachable effect.
		/// </summary>
		/// <param name="packetString"></param>
		/// <param name="scale"></param>
		public AttachableEffect(string packetString, float scale)
			: this(packetString, scale, EffectLocation.Bottom, Position.Zero)
		{
		}

		/// <summary>
		/// Creates a new attachable effect.
		/// </summary>
		/// <param name="packetString"></param>
		/// <param name="scale"></param>
		/// <param name="location"></param>
		public AttachableEffect(string packetString, float scale, EffectLocation location)
			: this(packetString, scale, location, Position.Zero)
		{
		}

		/// <summary>
		/// Creates a new attachable effect.
		/// </summary>
		/// <param name="packetString"></param>
		/// <param name="scale"></param>
		/// <param name="location"></param>
		/// <param name="offset"></param>
		public AttachableEffect(string packetString, float scale, EffectLocation location, Position offset)
		{
			this.PacketString = packetString;
			this.Scale = scale;
			this.Location = location;
			this.Offset = offset;
		}
	}
}
