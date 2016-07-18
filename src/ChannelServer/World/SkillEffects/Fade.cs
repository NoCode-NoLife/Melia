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
	class Fade : SkillEffect
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Fade(SkillEffectData effectData, SkillDataComponent skillComp) : base(effectData, skillComp)
		{
			
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
			Log.Debug("SBISCRIBE to CASTER PERFORM_CAST: CASTER:{0} TARGET: {1} !!!!!", skillComp.caster.Handle, skillComp.target.Handle);
			ChannelServer.Instance.World.SubscribeToEvent(WorldManager.EventTypes.PERFORM_CAST, PerformCast, skillComp.target.Handle);
			this.skillComp.target.IsFade = true;
		}

		/// <summary>
		/// Virtual function called when this effects got removed from target.
		/// </summary>
		public override void OnRemove()
		{
			Log.Debug("UNSBISCRIBE to CASTER PERFORM_CAST: CASTER:{0} TARGET: {1} !!!!!", skillComp.caster.Handle, skillComp.target.Handle);
			ChannelServer.Instance.World.UnsubscribeFromEvent(WorldManager.EventTypes.PERFORM_CAST, PerformCast, skillComp.target.Handle);
			this.skillComp.target.IsFade = false;
		}

		/// <summary>
		/// Function that is delegated to the World's event system. It will be invoked on EventTypes.PERFORM_CAST event.
		/// </summary>
		public EventResult PerformCast(EventData evData)
		{
			Log.Debug("Called PerformCast in Fade");
			this.skillComp.target.skillEffectsManager.RemoveEffectsBySkill(this.skillComp.skill);
			return null;
		}
	}
}
