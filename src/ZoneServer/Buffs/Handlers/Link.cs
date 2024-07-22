using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for the Link (de)buff, which links targets together to receive
	/// shared damage.
	/// </summary>
	[BuffHandler(BuffId.Link)]
	public class Link : BuffHandler, IBuffCombatDefenseAfterCalcHandler
	{
		/// <summary>
		/// Applies link to the specified targets.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="targets"></param>
		/// <param name="duration"></param>
		public static void Apply(ICombatEntity caster, IEnumerable<ICombatEntity> targets, TimeSpan duration)
		{
			foreach (var target in targets)
			{
				// As every target can only be part of one link, we'll first remove
				// any existing links they might have
				if (target.TryGetBuff(BuffId.Link, out var existingLink))
				{
					var existingTargets = existingLink.Vars.Get<IEnumerable<ICombatEntity>>("Melia.LinkMembers");
					foreach (var existingTarget in existingTargets)
						existingTarget.StopBuff(BuffId.Link);
				}

				// Then apply a new buff and remember the linked targets
				var linkBuff = target.StartBuff(BuffId.Link, 0, 0, duration, caster);
				linkBuff.Vars.Set("Melia.LinkMembers", targets);

				Send.ZC_NORMAL.PlayTextEffect(target, caster, "SHOW_BUFF_TEXT", (float)BuffId.Link, null, "Item");
			}
		}

		/// <summary>
		/// Breaks the target's current link.
		/// </summary>
		/// <param name="target"></param>
		public static void Remove(ICombatEntity target)
		{
			if (!target.TryGetBuff(BuffId.Link, out var linkBuff))
				return;

			// It's currently unclear whether this should break the full link or
			// only remove the target from the link. We'll simply break it for
			// now, since I don't feel like writing a workaround for locking
			// this shared target list to remove one of them.

			var linkTargets = linkBuff.Vars.Get<IEnumerable<ICombatEntity>>("Melia.LinkMembers");
			foreach (var linkTarget in linkTargets)
				linkTarget.StopBuff(BuffId.Link);
		}

		/// <summary>
		/// Applies the buff's effect during the combat calculations.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="modifier"></param>
		/// <param name="skillHitResult"></param>
		public void OnDefenseAfterCalc(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult)
		{
			if (!buff.Vars.TryGet<IEnumerable<ICombatEntity>>("Melia.LinkMembers", out var linkTargets))
				return;

			// Is the shared damage really the full amount? That would seem like
			// a lot to me, but who knows. TBD.
			var sharedDamage = (int)skillHitResult.Damage;

			foreach (var linkTarget in linkTargets)
			{
				if (linkTarget.IsDead || linkTarget.Handle == target.Handle)
					continue;

				linkTarget.TakeSimpleHit(sharedDamage, attacker, skill.Id);
			}
		}
	}
}
