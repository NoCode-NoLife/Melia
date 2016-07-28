using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.World.SkillHandlers;
using Melia.Shared.Util;
using Melia.Shared.World;
using Melia.Shared.Data.Database;
using System.Threading;

namespace Melia.Channel.World.SkillEffects
{
	/// <summary>
	/// SkillEffect represent to an Effect that REMAINS in the target, after the skill is executed.
	/// It gives the chance of affecting the target in time.
	/// 
	/// A clear example of this is a BUFF, or a DoT skill.
	/// 
	/// SkillEffects are attached to Skills. Several effects can be attached to a single skill.
	/// </summary>
	public class SkillEffect
	{
		public Actor owner; /// TODO

		/// <summary>
		/// Handle ID for this effect. Every effect has to have its own identifier.
		/// </summary>
		public int Handle;

		/// <summary>
		/// Internal variable used to control tick in this effect
		/// </summary>
		private DateTime _lastProcessTime;

		/// <summary>
		/// Miliseconds indicating the interval between ticks
		/// </summary>
		private double _tickRate = 1000.0;

		/// <summary>
		/// Internal variable used to control tick for effect stacking in this effect.
		/// </summary>
		private DateTime _lastStackTime;

		/// <summary>
		/// Miliseconds indicating the interval between stack ticks
		/// </summary>
		public double tickStackRate = 1000.0;

		/// <summary>
		/// Time when this effect will expire by itself, being removed from target
		/// </summary>
		public DateTime expireTime;

		/// <summary>
		/// Boolean indicating if this effect doesnt have a expire time.
		/// </summary>
		//public bool isPermanent;

		/// <summary>
		/// SkillDataComponent attached for this effect
		/// </summary>
		public SkillDataComponent skillComp;

		/// <summary>
		/// level of Stack for this effect
		/// </summary>
		public int stackLevel;
		/// <summary>
		/// How this effect behaves
		/// </summary>
		public EffectBehaviorType behaviorType;

		public SkillEffectData Data { get; set; }

		protected EffectState _state;
		protected Timer _futureTask;
		protected DateTime _effectStartTime;
		protected DateTime _effectEndTime;

		/// <summary>
		/// Constructor for SkillEffect
		/// </summary>
		public SkillEffect(SkillEffectData effectData, SkillDataComponent skillComp)
		{
			// Skilleffect needs to have a skill to have proper initialization
			if (skillComp.skill == null)
				return;

			// Handle ID initialization
			Handle = ChannelServer.Instance.World.CreateHandle();

			this.Data = effectData;

			// Initialize variables
			this.skillComp = skillComp;
			stackLevel = 1;
			expireTime = DateTime.Now.AddSeconds(this.Data.LifeTime);
			//expireTime = DateTime.Now.AddSeconds(skillComp.skill.Data.buffLifeInSeconds);
			//isPermanent = skillComp.skill.Data.buffIsPermanent;

			// 
			_lastProcessTime = DateTime.Now;
			_lastStackTime = DateTime.Now;

			_state = EffectState.CREATED;

		}

		public static SkillEffect GetSkillEffect(string effectType, SkillEffectData effectData, SkillDataComponent skillComp)
		{
			switch (effectType)
			{
				case "SAFETY_ZONE":
					return new EffectSafetyZone(effectData, skillComp);
				case "HEAL":
					return new Heal(effectData, skillComp);
				case "GUARDIAN_SAINT":
					return new GuardianSaint(effectData, skillComp);
				case "INC_SKILL_LEVEL":
					return new IncreaseSkillLevel(effectData, skillComp);
				case "FADE":
					return new Fade(effectData, skillComp);
				case "DAMAGE":
					return new Damage(effectData, skillComp);
				case "CURE":
					return new Cure(effectData, skillComp);
				case "DEPROTECTED_ZONE":
					return new DeprotectedZone(effectData, skillComp);
				default:
					Log.Error("Skill {0} tried to instance an invalid EffectType {1}", skillComp.skill.Id, effectType);
					return null;
			}
		}

		/// <summary>
		/// It creates and return an instance of this effect, initializing it with provided SkillDataComponent
		/// </summary>
		/// <param name="skillComp">SkillDataComponent used to initialize the new instance</param>
		virtual public SkillEffect NewInstance(SkillEffectData effectData, SkillDataComponent skillComp)
		{
			return new SkillEffect(effectData, skillComp);
		}

		/// <summary>
		/// Get the skillId for this effect
		/// </summary>
		public int GetSkillId()
		{
			if (skillComp.skill != null)
				return skillComp.skill.Id;

			return -1;
		}

		public void StartTask()
		{
			TasksPoolManager.Instance.AddGeneralTask(startScheduledEffect, null, 0);
		}

		public void Exit()
		{
			_state = EffectState.FINISHING;
			startScheduledEffect();
		}

		public void startScheduledEffect(Object obj = null)
		{

			if (_state == EffectState.CREATED)
			{
				_state = EffectState.WORKING;
				_effectStartTime = DateTime.Now;
				_effectEndTime = _effectStartTime.AddSeconds(this.Data.LifeTime);

				this.OnAdd();

				// schedule next task
				if (this.behaviorType == EffectBehaviorType.BUFF)
				{
					_futureTask = TasksPoolManager.Instance.AddGeneralTaskAtFixedRate(startScheduledEffect, null, (int)_tickRate, (int)_tickRate);
				}
				else
				{
					_futureTask = TasksPoolManager.Instance.AddGeneralTask(startScheduledEffect, null, (int)this.Data.LifeTime * 1000);
				}
			}

			if (_state == EffectState.WORKING)
			{
				this.OnTimer();

				if (!this.Data.IsPermanent && _effectEndTime < DateTime.Now)
				{
					_state = EffectState.FINISHING;
				}
			}

			if (_state == EffectState.FINISHING)
			{
				if (_futureTask != null)
				{
					_futureTask.Dispose();
					_futureTask = null;
				}
				this.OnRemove();
			}
		}

		/// <summary>
		/// This is a virtual function called when this effect got added in target.
		/// </summary>
		virtual public void OnAdd() { }

		/// <summary>
		/// Virtual function called when this effects got removed from target.
		/// </summary>
		virtual public void OnRemove() { }

		/// <summary>
		/// Virtual function called on every process tick for this effect
		/// </summary>
		virtual public void OnTimer() { }

		/// <summary>
		/// For instant skills
		/// </summary>
		virtual public SkillResult Instant() { return null;  }

		/// <summary>
		/// Virtual function called when this effect is applied again on the same target, and is a stackable effect.
		/// </summary>
		virtual public void OnStack()
		{
			skillComp.target.skillEffectsManager.AddEffect(this);
		}
	}

	public enum EffectBehaviorType
	{
		NONE = 0,
		INSTANT = 1,
		BUFF = 2,
	}

	public enum EffectState
	{
		CREATED,
		WORKING,
		FINISHING,
	}
}
