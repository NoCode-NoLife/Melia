using System;

namespace Melia.Zone.Pads.Handlers
{
	/// <summary>
	/// Used to mark pad handler classes, which are then automatically
	/// used by named pads.
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class PadHandlerAttribute : Attribute
	{
		/// <summary>
		/// Returns the names of the pads this handler is supposed to
		/// be used for.
		/// </summary>
		public string[] PadNames { get; }

		/// <summary>
		/// Returns the priority of the handler. Handlers with higher
		/// priority are preferred over handlers with lower priority.
		/// </summary>
		public int Priority { get; }

		/// <summary>
		/// Creates new attribute for the pad names.
		/// </summary>
		/// <param name="padNames"></param>
		public PadHandlerAttribute(params string[] padNames)
		{
			this.PadNames = padNames ?? [];
			this.Priority = 100;
		}
	}
}
