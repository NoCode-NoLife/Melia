using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.World.AI
{
	interface IControl
	{
		void SetIntention(IntentionTypes newIntention, Object arg0 = null, Object arg1 = null);
		IntentionTypes GetIntention();

		void notifyEvent(AIEventTypes aiEvent, Object arg0 = null, Object arg1 = null);
	}

	public enum IntentionTypes
	{
		AI_INTENTION_IDLE,
		AI_INTENTION_ACTIVE,
		AI_INTENTION_REST,
		AI_INTENTION_ATTACK,
		AI_INTENTION_CAST,
		AI_INTENTION_MOVETO,
		AI_INTENTION_FOLLOW,
	}

	public enum AIEventTypes
	{
		AI_EVENT_THINK,
		AI_EVENT_ATTACKED,
		AI_EVENT_READY_TO_ACT,
		AI_EVENT_DEAD,
		AI_EVENT_ARRIVED,
	}
}
