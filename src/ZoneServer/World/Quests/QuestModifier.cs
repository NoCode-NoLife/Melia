using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Zone.World.Quests
{
	/// <summary>
	/// Base class for quest modifiers.
	/// </summary>
	public abstract class QuestModifier
	{
		/// <summary>
		/// Called when a quest that uses this modifier is initially loaded.
		/// The modifier should set up its progress tracking here, such as
		/// subscribing to events.
		/// </summary>
		/// <remarks>
		/// Every quest modifier is loaded only once, to keep track of
		/// the progress of all modifiers that use this type.
		/// </remarks>
		public virtual void Load()
		{
		}

		/// <summary>
		/// Called when the quests that used this modifier were unloaded.
		/// The modifier should clean up its progress tracking measures
		/// here, such as unsubscribing from events.
		/// </summary>
		public virtual void Unload()
		{
		}
	}
}
