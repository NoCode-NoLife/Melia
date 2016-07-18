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
	class Damage : SkillEffect
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public Damage(SkillEffectData effectData, SkillDataComponent skillComp) : base(effectData, skillComp)
		{

		}

		/// <summary>
		/// It creates and return an instance of this effect, initializing it with provided SkillDataComponent
		/// </summary>
		/// <param name="skillComp">SkillDataComponent used to initialize the new instance</param>
		public override SkillEffect NewInstance(SkillEffectData effectData, SkillDataComponent skillComp)
		{
			return new Damage(effectData, skillComp);
		}

		/// <summary>
		/// This is a virtual function called when this effect got added in target.
		/// </summary>
		public override void OnAdd()
		{
			this.skillComp.target.TakeDamage(this.Data.Amount, this.skillComp.caster);
		}

		/// <summary>
		/// Virtual function called when this effects got removed from target.
		/// </summary>
		public override void OnRemove()
		{

		}
	}
}
