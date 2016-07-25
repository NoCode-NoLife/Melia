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

		protected override void onIntentionAttack(IEntity entityToAttack)
		{
			//Log.Debug("onIntentionAttack Called - entityToAttack: {0}", entityToAttack.Handle);
			if (entityToAttack == null)
			{
				return;
			}

			if (this.GetIntention() == IntentionTypes.AI_INTENTION_ATTACK)
			{
				// Check if changed target
				if (entityToAttack != _attackTarget)
				{
					// Change intention to attack
					this.ChangeIntention(IntentionTypes.AI_INTENTION_ATTACK);

					// Set attack target
					_attackTarget = entityToAttack;

					// Stop follow just n case
					this.StopFollow();

					// Think
					this.onEvtThink();
				}
			}
			else
			{
				// Change intention to attack
				this.ChangeIntention(IntentionTypes.AI_INTENTION_ATTACK);

				// Set attack target
				_attackTarget = entityToAttack;

				// Stop follow just n case
				this.StopFollow();

				// Think
				this.onEvtThink();
			}
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
