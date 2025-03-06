using System;

namespace Melia.Shared.Scripting
{
	// Just a copy of the attribute from Yggdrasil because I don't want to update
	// the using directives in all of the scripts right now.

	/// <summary>
	/// Attribute for methods in scripts, to mark them as subscribers
	/// for events in the EventManager.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class OnAttribute : Yggdrasil.Events.OnAttribute
	{
		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="eventNames"></param>
		public OnAttribute(params string[] eventNames) : base(eventNames)
		{
		}
	}
}
