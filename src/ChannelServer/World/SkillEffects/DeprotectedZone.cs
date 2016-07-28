using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Channel.World.SkillHandlers;
using Melia.Channel.World.SectorActors;
using Melia.Shared.Data.Database;
using Melia.Shared.Const;

namespace Melia.Channel.World.SkillEffects
{
	/// <summary>
	/// DeprotectedZone 
	/// </summary>
	public class DeprotectedZone : SkillEffect
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public DeprotectedZone(SkillEffectData effectData, SkillDataComponent skillComp) : base(effectData, skillComp)
		{
			this.behaviorType = EffectBehaviorType.BUFF;
		}

		/// <summary>
		/// It creates and return an instance of this effect, initializing it with provided SkillDataComponent
		/// </summary>
		/// <param name="skillComp">SkillDataComponent used to initialize the new instance</param>
		public override SkillEffect NewInstance(SkillEffectData effectData, SkillDataComponent skillComp)
		{
			return new DeprotectedZone(effectData, skillComp);
		}

		/// <summary>
		/// This is a virtual function called when this effect got added in target.
		/// </summary>
		public override void OnAdd()
		{
			// Add stats modifiers to target
			Skill skill = skillComp.skill;
			var statMods = skill.GetData().statModifiers.Values.ToList();
			for (int i = 0; i < statMods.Count; i++)
			{
				StatModifier sm = statMods[i];
				skillComp.target.statsManager.AddStatMod(this.Handle, sm);
			}
		}

		/// <summary>
		/// Virtual function called when this effects got removed from target.
		/// </summary>
		public override void OnRemove()
		{
			skillComp.target.statsManager.RemoveStatMods(this.Handle);
		}

		public override void OnTimer()
		{
			this.OnStack();
			base.OnTimer();
		}

		/// <summary>
		/// Virtual function called when this effect is applied again on the same target, and is a stackable effect.
		/// </summary>
		public override void OnStack()
		{
			//
			base.OnStack();

			// Add stats mods to target, based on stack level

			Skill skill = skillComp.skill;
			var statMods = skill.GetData().statModifiers.Values.ToList();
			for (int i = 0; i < statMods.Count; i++)
			{
				StatModifier sm = statMods[i];
				sm.modifierValue = (int) (-1 * Math.Ceiling((float)skill.GetData().Level / 2));
				skillComp.target.statsManager.AddStatMod(this.Handle, sm);
			}
		}

	}
}
