using System;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Pads;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads.Components;
using Yggdrasil.Composition;
using Yggdrasil.Geometry;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.World.Actors.Pads
{
	/// <summary>
	/// Represents a pad, which are zones on the map that trigger events.
	/// </summary>
	/// <remarks>
	/// The exact classification of pads is currently still in the air.
	/// We're considering them their own type of actor that are typically
	/// created by skills, though they might just as well be a type of
	/// monster.
	/// </remarks>
	public class Pad : Actor, IUpdateable
	{
		/// <summary>
		/// Gets or sets the pad's name.
		/// </summary>
		public override string Name { get; set; }

		/// <summary>
		/// Returns the actor that created the pad.
		/// </summary>
		public IActor Creator { get; }

		/// <summary>
		/// Returns the skill the pad was created by.
		/// </summary>
		public Skill Skill { get; }

		/// <summary>
		/// Returns the pad's area, defining the trigger zone.
		/// </summary>
		public IShapeF Area { get; }

		/// <summary>
		/// Gets or sets the pad's first numeric argument, which is
		/// typically used for the pad's "angle".
		/// </summary>
		/// <remarks>
		/// It's currently unknown what exactly this property does. It can
		/// be found in pad-related packets and in the skill bytool data
		/// (element "Pos", argument "Angle"), but it doesn't appear to
		/// have any effect on the pad or its visuals.
		///
		/// Initially we called this property "Angle" due to the bytool
		/// data, but it's been reportedly found to contain different
		/// values in some cases, like Centurion skills.
		/// </remarks>
		public float NumArg1 { get; set; }

		/// <summary>
		/// Gets or sets the pad's second numeric argument, which is
		/// typically used as "distance".
		/// </summary>
		/// <remarks>
		/// It's currently unknown what exactly this property does. It can
		/// be found in pad-related packets and in the skill bytool data
		/// (element "Pos", argument "Dist"), but it doesn't appear to
		/// have any effect on the pad or its visuals.
		///
		/// Initially we called this property "Distance" due to the bytool
		/// data, but it's been reportedly found to contain different
		/// values in some cases, like Centurion skills.
		/// </remarks>
		public float NumArg2 { get; set; }

		/// <summary>
		/// Gets or sets the pad's third numeric argument.
		/// </summary>
		/// <remarks>
		/// It's currently unknown what exactly this property does. It can
		/// be found in pad-related packets, but it doesn't appear to have
		/// any effect on the pad or its visuals.
		/// </remarks>
		public float NumArg3 { get; set; }

		/// <summary>
		/// Returns the pad's movement component.
		/// </summary>
		public PadMovementComponent Movement { get; }

		/// <summary>
		/// Returns the pad's trigger component.
		/// </summary>
		public TriggerComponent Trigger { get; }

		/// <summary>
		/// Returns the pad's components.
		/// </summary>
		public ComponentCollection Components { get; } = new();

		/// <summary>
		/// Returns the pad's variables.
		/// </summary>
		/// <remarks>
		/// This is a collection of variables that can be used to store temporary
		/// information about the pad. They are not saved and will be lost after
		/// the pad was destroyed.
		/// </remarks>
		public Variables Variables { get; } = new();

		/// <summary>
		/// Creates a new pad.
		/// </summary>
		/// <remarks>
		/// We currently allow null names for pads, in which case no
		/// handler will be registered, but this might change in the
		/// future. If at all possible, the official name of the pad
		/// should be used.
		/// </remarks>
		/// <param name="name">The name of the pad, as defined in the client and the PadName enum.</param>
		/// <param name="creator">The actor that created the pad.</param>
		/// <param name="skill">The skill that created the pad.</param>
		/// <param name="triggerArea">The area that defines the pad's trigger zone.</param>
		/// <exception cref="ArgumentException">
		/// Thrown if a handler with the given name does not exist.
		/// </exception>
		private Pad(string name, IActor creator, Skill skill, IShapeF triggerArea)
		{
			this.Name = name;
			this.Creator = creator;
			this.Skill = skill;
			this.Area = triggerArea;

			this.Position = creator.Position;
			this.Direction = creator.Direction;

			this.Components.Add(this.Movement = new PadMovementComponent(this));
			this.Components.Add(this.Trigger = new TriggerComponent(this, triggerArea));
		}

		/// <summary>
		/// Creates a new pad.
		/// </summary>
		/// <param name="name">The name of the pad, as defined in the client and the PadName enum.</param>
		/// <param name="creator">The actor that created the pad.</param>
		/// <param name="skill">The skill that created the pad.</param>
		/// <param name="triggerArea">The area that defines the pad's trigger zone.</param>
		/// <param name="options">Options that define additional properties for the pad.</param>
		/// <exception cref="ArgumentException">
		/// Thrown if a handler with the given name does not exist.
		/// </exception>
		public static Pad Create(string name, IActor creator, Skill skill, Position position, IShapeF triggerArea, PadOptions options)
		{
			var pad = new Pad(name, creator, skill, triggerArea);
			pad.Position = position;

			pad.NumArg1 = options.NumArg1;
			pad.NumArg2 = options.NumArg2;
			pad.NumArg3 = options.NumArg3;
			pad.Trigger.LifeTime = options.LifeTime;
			pad.Trigger.UpdateInterval = options.UpdateInterval;
			pad.Trigger.MaxActorCount = options.MaxActorCount;
			pad.Trigger.MaxUseCount = options.MaxUseCount;

			if (name != null)
				pad.RegisterHandler(name);

			return pad;
		}

		/// <summary>
		/// Looks up the handler for the given name and registers its methods
		/// as trigger events.
		/// </summary>
		/// <param name="name"></param>
		private void RegisterHandler(string name)
		{
			if (!ZoneServer.Instance.PadHandlers.TryGetHandler(name, out var handler))
				throw new ArgumentException($"No handler found for pad '{name}'.");

			if (handler is ICreatePadHandler create) this.Trigger.Subscribe(TriggerType.Create, create.Created);
			if (handler is IDestroyPadHandler destroy) this.Trigger.Subscribe(TriggerType.Destroy, destroy.Destroyed);
			if (handler is IEnterPadHandler enter) this.Trigger.Subscribe(TriggerType.Enter, enter.Entered);
			if (handler is ILeavePadHandler leave) this.Trigger.Subscribe(TriggerType.Leave, leave.Left);
			if (handler is IUpdatePadHandler update) this.Trigger.Subscribe(TriggerType.Update, update.Updated);
		}

		/// <summary>
		/// Called in regular intervals to update the pad and potentially raise
		/// its events.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			this.Components.Update(elapsed);
		}

		/// <summary>
		/// Destroys the pad, triggering its Destroyed event and removing it from
		/// its current map.
		/// </summary>
		public void Destroy()
		{
			this.Map?.RemovePad(this);
		}
	}
}
