using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Melia.Shared.Util;
using Melia.Shared.World;
using Melia.Shared.World.Shapes;

namespace Melia.Channel.World.AI
{
	public class AIMonster : AIEntity
	{
		private int _attackTimeout;
		private const int MAX_ATTACK_TIMEOUT = 50; // Ticks amount.
		Timer _aiTask;
		private int _globalAggro;

		protected Monster _entityMonster;

		public AIMonster(Monster owner) : base(owner)
		{
			_entityMonster = (Monster)_entity;

			_globalAggro = -10;
		}

		public override void Process(Object obj)
		{
			onEvtThink();
		}

		protected override void onEvtThink()
		{
			//Log.Debug("onEventThink called, intention {0}", this.GetIntention() );
			if (_thinking)
				return;

			_thinking = true;

			switch (GetIntention())
			{
				case IntentionTypes.AI_INTENTION_ACTIVE:
					{
						thinkActive();
						break;
					}
				case IntentionTypes.AI_INTENTION_ATTACK:
					{
						thinkAttack();
						break;
					}
				default:
					break;

			}

			_thinking = false;
		}

		protected void thinkActive()
		{
			//Log.Debug("thinkActive called. _globalAggro {0}", _globalAggro);

			// Check if just spawned, to prevent attack right away
			if (_globalAggro != 0)
			{
				_globalAggro = (_globalAggro < 0) ? _globalAggro + 1 : _globalAggro - 1;
			}

			if (_globalAggro >= 0)
			{
				IEntity mostHated = _entityMonster.GetMostHated();
				if (mostHated != null)
				{
					this.SetIntention(IntentionTypes.AI_INTENTION_ATTACK, mostHated);
				} else
				{
					this.SetIntention(IntentionTypes.AI_INTENTION_IDLE);
				}
			}
		}

		protected void thinkAttack()
		{
			//Log.Debug("thinkAttack {0}", _attackTarget);
			if (_entity == null || !_entity.CanShoot())
			{
				return;
			}

			// Attack timeout passed, set it to walk instead of running
			if (_attackTimeout < GameTimeController.Instance.GetGameTicks())
			{
				//Log.Debug("is running: {0}", _entity.IsRunning());
				if (_entity.IsRunning())
				{
					//Log.Debug("Make the monster walk for the rest of the attack");
					// Start walking again
					_entity.SetWalking();

					// Calculate new attack timeout
					_attackTimeout = MAX_ATTACK_TIMEOUT + GameTimeController.Instance.GetGameTicks();
				}

			}

			// Check if target is still there or attack has timeout
			if (_attackTarget == null || _attackTimeout < GameTimeController.Instance.GetGameTicks())
			{
				if (_attackTarget != null)
					_entityMonster.StopHating(_attackTarget);

				SetIntention(IntentionTypes.AI_INTENTION_ACTIVE);

				_entityMonster.SetWalking();

				return;
			}

			Skill attackSkill = ((Monster)_entity).mainAttackSkill;
			Circle skillRange = new Circle(_entity.Radius + attackSkill.GetData().MaxRange);
			skillRange.Position = _entity.Position;

			//Log.Debug("attackSkill r {0} _entity r {1} attacker r {2} ", attackSkill.GetData().MaxRange, _entity.Radius, ((Actor)_attackTarget).Radius);
			//Log.Debug("Distance {0}", _entity.Position.Get2DDistance(_attackTarget.Position));

			if (skillRange.IntersectWith(_attackTarget.CollisionShape))
			{
				((Monster)_entity).UseMainAttack(_attackTarget);
			} else
			{
				this.moveToEntity(_attackTarget, (int)attackSkill.GetData().MaxRange);
			}
			
		}

		protected override void onEvtAttacked(IEntity attacker)
		{
			//Log.Debug("onEvtAttacked Called - attacker: {0}", attacker.Handle);
			_attackTimeout = MAX_ATTACK_TIMEOUT + GameTimeController.Instance.GetGameTicks();

			// Set the _globalAggro to 0 to permit attack even just after spawn
			if (_globalAggro < 0)
			{
				_globalAggro = 0;
			}

			// Try add this attacker to aggroList
			_entityMonster.AddDamageHate(attacker, 0, 1);

			if (!_entity.IsAttacking)
				_entity.SetAttackState(true);

			if (!_entity.IsRunning())
				_entity.SetRunning();


			if (this.GetIntention() != IntentionTypes.AI_INTENTION_ATTACK)
			{
				SetIntention(IntentionTypes.AI_INTENTION_ATTACK, attacker);
			} else
			{
				// Check if most hated changed, attack the most hated.
				if (_entityMonster.GetMostHated() != this._attackTarget)
				{
					SetIntention(IntentionTypes.AI_INTENTION_ATTACK, attacker);
				}
			}
		}

		public override void ChangeIntention(IntentionTypes newItenntion, object arg0 = null, object arg1 = null)
		{
			if (newItenntion == IntentionTypes.AI_INTENTION_IDLE)
			{
				StopAITask();
				base.ChangeIntention(newItenntion, arg0, arg1);
				return;
			}

			base.ChangeIntention(newItenntion, arg0, arg1);

			this.StartAITask();


		}

		public void StartAITask()
		{;
			//Log.Debug("StartAITask");
			if (_aiTask == null)
			{
				_aiTask = TasksPoolManager.Instance.AddGeneralTaskAtFixedRate(this.Process, null, 1000, 1000);
			}
				
		}

		public void StopAITask()
		{
			//Log.Debug("StopAITask");
			if (_aiTask != null)
			{
				_aiTask.Dispose();
				_aiTask = null;
			}
		}

		protected override void onIntentionAttack(IEntity entityToAttack)
		{
			_attackTimeout = MAX_ATTACK_TIMEOUT + GameTimeController.Instance.GetGameTicks();
			base.onIntentionAttack(entityToAttack);
		}

		protected override void onIntentionIdle()
		{
			if (_entity.IsAttacking)
				_entity.SetAttackState(false);
			base.onIntentionIdle();
		}

	}
}
