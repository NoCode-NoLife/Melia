using System;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.L10N;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Melia.Zone.Scripting.ScriptableEvents;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Util;

namespace Melia.Zone.Skills.Handlers.Clerics.Cleric
{
	/// <summary>
	/// Handler for the Cleric skill Cure.
	/// </summary>
	[SkillHandler(SkillId.Cleric_Cure)]
	public class Cleric_Cure : IGroundSkillHandler
	{
		private const float RemoveChancePerLevel = 10; // %

		/// <summary>
		/// Handles skill, damaging targets.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		public void Handle(Skill skill, ICombatEntity caster, Position originPos, Position farPos, ICombatEntity target)
		{
			if (!caster.TrySpendSp(skill))
			{
				caster.ServerMessage(Localization.Get("Not enough SP."));
				return;
			}

			skill.IncreaseOverheat();
			caster.SetAttackState(true);

			this.RemoveDebuffs(caster, target, skill);

			caster.StartBuff(BuffId.Cure_Overload_Buff, TimeSpan.FromSeconds(5));

			Send.ZC_SKILL_MELEE_GROUND(caster, skill, farPos, null);
		}

		/// <summary>
		/// Clears all removable debuffs from the target by a certain chance.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		private void RemoveDebuffs(ICombatEntity caster, ICombatEntity target, Skill skill)
		{
			var rnd = RandomProvider.Get();
			var removeChance = this.GetRemoveChance(skill);

			var buffComponent = target.Components.Get<BuffComponent>();
			var buffs = buffComponent.GetList();

			foreach (var buff in buffs)
			{
				if (buff.Data.Type != BuffType.Debuff)
					continue;

				if (rnd.Next() < removeChance)
					buffComponent.Remove(buff.Id);
			}
		}

		/// <summary>
		/// Returns the chance to remove a debuff from the target.
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		private float GetRemoveChance(Skill skill)
		{
			return skill.Level * RemoveChancePerLevel;
		}

		/// <summary>
		/// Returns the amount of SP the skill uses.
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		[SkillSpOverride(SkillId.Cleric_Cure)]
		public float GetSpendSp(Skill skill)
		{
			var SCR_Get_SpendSP = ScriptableFunctions.Skill.Get("SCR_Get_SpendSP");

			var value = SCR_Get_SpendSP(skill);

			var overbuffCount = skill.Owner.GetOverbuffCount(BuffId.Cure_Overload_Buff);
			value += (value * 0.5f * overbuffCount);

			return value;
		}
	}
}
