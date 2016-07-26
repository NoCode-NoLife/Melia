using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.World;

namespace Melia.Channel.World.AI
{
	public class AIPlayer : AIEntity
	{
		private Character _character;


		public AIPlayer(Character character) : base(character)
		{
			_character = character;
		}

		protected override void onEvtThink()
		{
			if (_thinking)
				return;

			_thinking = true;

			switch (GetIntention())
			{
				case IntentionTypes.AI_INTENTION_ATTACK:
					{
						ThinkAttack();
						break;
					}
				default:
					break;

			}

			_thinking = false;
		}

		private void ThinkAttack()
		{
			_character.CastSkill(_skill, _attackTarget);
		}

		protected override void onIntentionMoveTo(Position pos)
		{
			// Prevent movement while casting.
			if (_character.ShootTime != null)
				return;

			base.onIntentionMoveTo(pos);

			_character.MoveTo(pos, 0);
		}

		protected override void onIntentionAttack(IEntity entityToAttack, Skill skill)
		{
			// Prevent attacking when in the middle of an attack.
			if (_character.ShootTime != null)
				return;

			base.onIntentionAttack(entityToAttack, skill);

			_attackTarget = entityToAttack;

			this.onEvtThink();
		
		}

	}
}
