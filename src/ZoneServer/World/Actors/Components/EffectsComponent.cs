using System;
using System.Collections.Generic;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Effects;
using Yggdrasil.Geometry.Shapes;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World.Actors.Components
{
	/// <summary>
	/// Component that manages actor effects.
	/// </summary>
	public class EffectsComponent : IUpdateable
	{
		private readonly Dictionary<string, Effect> _effects = new Dictionary<string, Effect>();

		/// <summary>
		/// Returns the number of effects.
		/// </summary>
		public int Count
		{
			get
			{
				lock (_effects)
					return _effects.Count;
			}
		}

		/// <summary>
		/// Returns the component's owner.
		/// </summary>
		public IActor Owner { get; }

		/// <summary>
		/// Creates a new effects component.
		/// </summary>
		/// <param name="owner">The actor that owns this component.</param>
		public EffectsComponent(IActor owner)
		{
			this.Owner = owner;
		}

		/// <summary>
		/// Adds an effect with an auto-generated name.
		/// </summary>
		/// <param name="effect">The effect to add.</param>
		public void AddEffect(Effect effect)
		{
			lock (_effects)
			{
				var effectName = $"{_effects.Count}";
				_effects.Add(effectName, effect);
				this.BroadcastEffectAddition(effect);
			}
		}

		/// <summary>
		/// Sends an effect to all players that can currently see the owner.
		/// </summary>
		/// <param name="effect">The effect to show.</param>
		private void BroadcastEffectAddition(Effect effect)
		{
			if (this.Owner?.Map == null)
				return;

			// Get all characters within a generous visibility range of the owner.
			var charactersInRange = this.Owner.Map.GetActorsIn<Character>(new CircleF(this.Owner.Position, 1000f));

			foreach (var character in charactersInRange)
			{
				// Check if the character is connected and can actually see the owner actor.
				if (character.Connection != null && character.CanSee(this.Owner))
				{
					effect.ShowEffect(character.Connection, this.Owner);
				}
			}
		}

		/// <summary>
		/// Shows all effects to a specific connection.
		/// </summary>
		/// <param name="connection">The connection to show effects to.</param>
		public void ShowEffects(IZoneConnection connection)
		{
			lock (_effects)
			{
				foreach (var effect in _effects.Values)
					effect.ShowEffect(connection, this.Owner);
			}
		}

		/// <summary>
		/// Removes an effect with a given name.
		/// </summary>
		/// <param name="effectName">The name of the effect to remove.</param>
		public void RemoveEffect(string effectName)
		{
			if (string.IsNullOrEmpty(effectName))
				return;

			lock (_effects)
			{
				if (_effects.TryGetValue(effectName, out var effect))
				{
					effect.OnRemove(this.Owner);
					_effects.Remove(effectName);
				}
			}
		}

		/// <summary>
		/// Updates the component, calling Update on all IUpdateable effects.
		/// </summary>
		/// <param name="elapsed">Time elapsed since last update.</param>
		public void Update(TimeSpan elapsed)
		{
			lock (_effects)
			{
				foreach (var effect in _effects.Values)
				{
					if (effect is IUpdateable updateable)
						updateable.Update(elapsed);
				}
			}
		}
	}
}
