using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Channel.World.SkillHandlers;
using Melia.Channel.World.SectorActors;
using Melia.Channel.Network;
using Melia.Shared.Data.Database;

namespace Melia.Channel.World.SkillEffects
{
	public class IncreaseSkillLevel : SkillEffect
	{
		private int _appliesCount;
		private int _maxAppliesCount;
		/// <summary>
		/// Constructor
		/// </summary>
		public IncreaseSkillLevel(SkillEffectData effectData, SkillDataComponent skillComp) : base(effectData, skillComp)
		{
			this.behaviorType = EffectBehaviorType.BUFF;
			_appliesCount = 0;
			_maxAppliesCount = effectData.Amount;
		}

		/// <summary>
		/// It creates and return an instance of this effect, initializing it with provided SkillDataComponent
		/// </summary>
		/// <param name="skillComp">SkillDataComponent used to initialize the new instance</param>
		public override SkillEffect NewInstance(SkillEffectData effectData, SkillDataComponent skillComp)
		{
			return new Heal(effectData, skillComp);
		}

		/// <summary>
		/// This is a virtual function called when this effect got added in target.
		/// </summary>
		public override void OnAdd()
		{
			Log.Debug("Subs");
			ChannelServer.Instance.World.SubscribeToEvent(WorldManager.EventTypes.PERFORM_CAST, PerformCast, skillComp.target.Handle);
			this.skillComp.target.IncreaseSkillLevel = true;
		}

		/// <summary>
		/// Virtual function called when this effects got removed from target.
		/// </summary>
		public override void OnRemove()
		{
			Log.Debug("Unsbs");
			ChannelServer.Instance.World.UnsubscribeFromEvent(WorldManager.EventTypes.PERFORM_CAST, PerformCast, skillComp.target.Handle);
			this.skillComp.target.IncreaseSkillLevel = false;
		}

		/// <summary>
		/// Function that is delegated to the World's event system. It will be invoked on EventTypes.PERFORM_CAST event.
		/// </summary>
		public EventResult PerformCast(EventData evData)
		{
			// Since its called in "perform cast" and not "performed cast", it will deactivate the effect in the NEXT cast.
			_appliesCount++;
			if (_appliesCount > _maxAppliesCount)
			{
				this.skillComp.target.skillEffectsManager.RemoveEffectsBySkill(this.skillComp.skill);
			}

			return null;
		}
	}
}
