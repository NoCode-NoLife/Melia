using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Pads
{
	/// <summary>
	/// Describes a handler for a pad that can handle creation events.
	/// </summary>
	public interface ICreatePadHandler : IPadHandler
	{
		/// <summary>
		/// Called when the pad is created and added to a map.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		void Created(object sender, PadTriggerArgs args);
	}

	/// <summary>
	/// Describes a handler for a pad that can handle destroy events.
	/// </summary>
	public interface IDestroyPadHandler : IPadHandler
	{
		/// <summary>
		/// Called when pad is destroyed and removed from its current map.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		void Destroyed(object sender, PadTriggerArgs args);
	}

	/// <summary>
	/// Describes a handler for a pad that can handle enter events.
	/// </summary>
	public interface IEnterPadHandler : IPadHandler
	{
		/// <summary>
		/// Called when an actor enters the pad.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		void Entered(object sender, PadTriggerActorArgs args);
	}

	/// <summary>
	/// Describes a handler for a pad that can handle leave events.
	/// </summary>
	public interface ILeavePadHandler : IPadHandler
	{
		/// <summary>
		/// Called when an actor leaves the pad.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		void Left(object sender, PadTriggerActorArgs args);
	}

	/// <summary>
	/// Describes a handler for a pad that can handle update events.
	/// </summary>
	public interface IUpdatePadHandler : IPadHandler
	{
		/// <summary>
		/// Called in regular intervals while the pad is on a map.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		void Updated(object sender, PadTriggerArgs args);
	}

	/// <summary>
	/// Empty interface marking pad handlers.
	/// </summary>
	public interface IPadHandler
	{
	}
}
