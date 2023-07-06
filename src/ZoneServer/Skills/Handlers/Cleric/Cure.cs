using System;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.L10N;
using Melia.Shared.Tos.Const;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Scripting.Dialogues;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Geometry;
using Yggdrasil.Geometry.Shapes;
using Yggdrasil.Util;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Skills.Handlers.Cleric
{
	/// <summary>
	/// Handler for the Cleric skill Cure.
	/// </summary>
	[SkillHandler(SkillId.Cleric_Cure)]
	public class Cure : IGroundSkillHandler
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
	}
}
