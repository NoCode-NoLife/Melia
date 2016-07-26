using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;
using Melia.Shared.Util;

namespace Melia.Channel.World.AI
{
	public class AIEntity : AIBase
	{

		protected Actor _target;
		protected IEntity _attackTarget;
		protected IEntity _castTarget;
		protected Skill _skill;


		public AIEntity(Entity owner) : base(owner)
		{
			_target = null;
			_attackTarget = null;
		}

		protected override void onIntentionIdle()
		{
			// Set intention to idle
			ChangeIntention(IntentionTypes.AI_INTENTION_IDLE);

			// Stop actions and reset flags
			ClientStopMoving(new Position());
		}

		protected override void onIntentionActive()
		{
			// Check if already in this intention
			if (this.GetIntention() != IntentionTypes.AI_INTENTION_ACTIVE)
			{
				// Set new intention
				this.ChangeIntention(IntentionTypes.AI_INTENTION_ACTIVE);

				// Stop actions and reset flags
				this.ClientStopMoving(new Position());

				// Launch think event
				this.onEvtThink();
			}
		}

		protected override void onIntentionRest()
		{
			SetIntention(IntentionTypes.AI_INTENTION_REST);
		}

		protected override void onIntentionAttack(IEntity entityToAttack, Skill skill)
		{
			//Log.Debug("onIntentionAttack Called - entityToAttack: {0}", entityToAttack.Handle);
			_skill = skill;
			_attackTarget = entityToAttack;

			this.StopFollow();

			if (this.GetIntention() != IntentionTypes.AI_INTENTION_ATTACK)
				this.ChangeIntention(IntentionTypes.AI_INTENTION_ATTACK);

		}

		protected override void onIntentionCast(Skill skill, IEntity target)
		{
			this._castTarget = target;

			/// TODO (stop other actions
			/// 

			this._skill = skill;

			this.ChangeIntention(IntentionTypes.AI_INTENTION_CAST);

			this.notifyEvent(AIEventTypes.AI_EVENT_THINK);
		}

		protected override void onIntentionMoveTo(Position pos)
		{
			/// TODO
			/// 

			ChangeIntention(IntentionTypes.AI_INTENTION_MOVETO, pos);

			base.onIntentionMoveTo(pos);
		}

		protected override void onEvtThink()
		{
			base.onEvtThink(); 
		}

		protected override void onEvtArrived()
		{
			this.ClientStopMoving(new Position());

			onEvtThink();
		}
	}
}
