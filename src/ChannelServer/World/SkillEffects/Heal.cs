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
using Melia.Shared.Const;

namespace Melia.Channel.World.SkillEffects
{
	public class Heal : SkillEffect
	{
		private int _healAmount;
		private bool _isPercent;
		/// <summary>
		/// Constructor
		/// </summary>
		public Heal(SkillEffectData effectData, SkillDataComponent skillComp) : base(effectData, skillComp)
		{
			this.behaviorType = EffectBehaviorType.INSTANT;
			_healAmount = effectData.Amount;
			_isPercent = effectData.IsPercent;
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
		public override SkillResult Instant() {

			TargetType targetType = this.skillComp.caster.GetTargetType(this.skillComp.target);

			if ((targetType == TargetType.MONSTER && this.skillComp.caster is Character) || targetType == TargetType.ENEMY)
			{
				// Heal effect makes damage to enemies.

				int damage = Formulas.INTAttack(this.Data.Amount, this.skillComp.caster);

				this.skillComp.target.TakeDamage(damage, this.skillComp.caster);

				SkillResult sResult = new SkillResult();
				sResult.actor = (Entity)this.skillComp.target;
				sResult.targetHandle = this.skillComp.target.Handle;
				sResult.skillHandle = this.skillComp.skill.Handle;
				sResult.value = damage;
				sResult.type = 1;

				return sResult;
			}

			if (this.skillComp.target is Character)
			{
				if (this.skillComp.target.Hp < this.skillComp.target.MaxHp)
				{
					SkillResult sResult = new SkillResult();
					sResult.actor = (Entity)this.skillComp.target;
					sResult.targetHandle = this.skillComp.target.Handle;
					sResult.skillHandle = this.skillComp.skill.Handle;
					sResult.type = 0;
					sResult.value = 0;

					if (this.skillComp.skill.Id == 40001)
						sResult.value = this.skillComp.target.Heal(Formulas.Heal40001(this.skillComp.skill, this.skillComp.caster, this), _isPercent);

					return sResult;
				}
			}

			return null;
		} 

		/// <summary>
		/// Virtual function called when this effects got removed from target.
		/// </summary>
		public override void OnRemove() {

		}
	}
}
