using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Channel.World.SkillHandlers;
using Melia.Shared.Util;

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
		private double _tickRate = 500.0;

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
		public bool isPermanent;

		/// <summary>
		/// SkillDataComponent attached for this effect
		/// </summary>
		public SkillDataComponent skillComp;

		/// <summary>
		/// level of Stack for this effect
		/// </summary>
		public int stackLevel;

		/// <summary>
		/// Constructor for SkillEffect
		/// </summary>
		public SkillEffect(SkillDataComponent skillComp)
		{
			// Skilleffect needs to have a skill to have proper initialization
			if (skillComp.skill == null)
				return;

			// Handle ID initialization
			Handle = ChannelServer.Instance.World.CreateHandle();

			// Initialize variables
			this.skillComp = skillComp;
			stackLevel = 1;
			expireTime = DateTime.Now.AddSeconds(skillComp.skill.Data.buffLifeInSeconds);
			isPermanent = skillComp.skill.Data.buffIsPermanent;

			// 
			_lastProcessTime = DateTime.Now;
			_lastStackTime = DateTime.Now;

		}

		/// <summary>
		/// It creates and return an instance of this effect, initializing it with provided SkillDataComponent
		/// </summary>
		/// <param name="skillComp">SkillDataComponent used to initialize the new instance</param>
		virtual public SkillEffect NewInstance(SkillDataComponent skillComp)
		{
			return new SkillEffect(skillComp);
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

		/// <summary>
		/// Process function. Called every Entity' tick from the SkillEffectManager.
		/// </summary>
		public void Process()
		{
			// Check if we need to tick this process
			TimeSpan diff = DateTime.Now - _lastProcessTime;
			if (diff.TotalMilliseconds >= _tickRate)
			{
				_lastProcessTime = DateTime.Now; /// Or should be "=+ _tickRate" to prevent jumping ticks in laggy moments?
				OnTimer();
			}

			// Check if we need to tick for effect stack
			if (skillComp.skill.Data.buffCanStack)
			{
				diff = DateTime.Now - _lastStackTime;
				if (diff.TotalMilliseconds >= this.tickStackRate)
				{
					// Call OnStack() for this effect
					_lastStackTime = DateTime.Now;
					OnStack();

				}
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
		/// Virtual function called when this effect is applied again on the same target, and is a stackable effect.
		/// </summary>
		virtual public void OnStack()
		{
			this.stackLevel += 1;
			skillComp.target.skillEffectsManager.AddEffect(this);
		}
	}
}
