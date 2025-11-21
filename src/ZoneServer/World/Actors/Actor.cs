using System.Collections.Concurrent;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Components;
using Melia.Zone.World.Actors.Effects;
using Melia.Zone.World.Maps;

namespace Melia.Zone.World.Actors
{
	/// <summary>
	/// An object that can be placed on a map.
	/// </summary>
	public interface IActor
	{
		/// <summary>
		/// Returns the actor's unique handle.
		/// </summary>
		int Handle { get; }

		/// <summary>
		/// Returns the actor's display name.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Returns the map the actor is currently on.
		/// </summary>
		Map Map { get; set; }

		/// <summary>
		/// Returns the actor's position on its current map.
		/// </summary>
		Position Position { get; set; }

		/// <summary>
		/// Returns the direction the actor is facing.
		/// </summary>
		Direction Direction { get; set; }

		/// <summary>
		/// Returns the actor's visibility.
		/// </summary>
		public ActorVisibility Visibility { get; set; }

		/// <summary>
		/// Returns a list of effects that are attached to the actor.
		/// </summary>
		ConcurrentBag<AttachableEffect> AttachableEffects { get; }
	}

	/// <summary>
	/// An object that can be placed on a map.
	/// </summary>
	public abstract class Actor : IActor
	{
		/// <summary>
		/// Returns a list of effects that are attached to the actor.
		/// </summary>
		public ConcurrentBag<AttachableEffect> AttachableEffects { get; } = new ConcurrentBag<AttachableEffect>();

		/// <summary>
		/// Returns the effects component for this actor.
		/// </summary>
		public EffectsComponent Effects { get; }

		/// <summary>
		/// Returns the actor's unique handle.
		/// </summary>
		public int Handle { get; } = ZoneServer.Instance.World.CreateHandle();

		/// <summary>
		/// Creates a new actor instance.
		/// </summary>
		public Actor()
		{
			this.Effects = new EffectsComponent(this);
		}

		/// <summary>
		/// Returns the actor's display name.
		/// </summary>
		public abstract string Name { get; set; }

		/// <summary>
		/// Returns the map the actor is currently on.
		/// </summary>
		public Map Map
		{
			get => _map;
			set => _map = value ?? Map.Limbo;
		}
		private Map _map = Map.Limbo;

		/// <summary>
		/// Returns the actor's position on its current map.
		/// </summary>
		public Position Position { get; set; }

		/// <summary>
		/// Returns the direction the actor is facing.
		/// </summary>
		public Direction Direction { get; set; }

		/// <summary>
		/// Gets or sets the actor's visibility.
		/// </summary>
		public ActorVisibility Visibility { get; set; } = ActorVisibility.Everyone;


		/// <summary>
		/// Attaches an effect to the actor that is displayed alongside it.
		/// </summary>
		/// <param name="packetString"></param>
		/// <param name="scale"></param>
		public void AttachEffect(string packetString, float scale = 1)
		{
			var effect = new AttachableEffect(packetString, scale);
			this.AttachableEffects.Add(effect);

			if (this.Map != Map.Limbo)
				Send.ZC_NORMAL.AttachEffect(this, effect.PacketString, effect.Scale);
		}

		/// <summary>
		/// Adds an effect to the actor.
		/// </summary>
		/// <param name="effect">The effect to add.</param>
		public void AddEffect(Effect effect)
		{
			this.Effects.AddEffect(effect);
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
		/// Creates a new attachable effect.
		/// </summary>
		/// <param name="packetString"></param>
		/// <param name="scale"></param>
		public AttachableEffect(string packetString, float scale)
		{
			this.PacketString = packetString;
			this.Scale = scale;
		}
	}

	/// <summary>
	/// Defines an actor's visibility.
	/// </summary>
	public enum ActorVisibility
	{
		NoOne,
		Individual,
		Party,
		Track,
		Everyone,
		Always,
	}
}
