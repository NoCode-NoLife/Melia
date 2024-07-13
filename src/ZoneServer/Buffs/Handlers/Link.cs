using System;
using System.Collections.Generic;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for the Link (de)buff, which links targets together to receive
	/// shared damage.
	/// </summary>
	[BuffHandler(BuffId.Link)]
	public class Link : BuffHandler
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
		/// Attempts to share damage with entities linked to the target.
		/// Returns false if the target is not linked or the link is invalid.
		/// </summary>
		/// <param name="attacker"></param>
		/// <param name="target"></param>
		/// <param name="skill"></param>
		/// <param name="damage"></param>
		/// <returns></returns>
		public static bool TryShareDamage(ICombatEntity attacker, ICombatEntity target, Skill skill, float damage)
		{
			if (!target.TryGetBuff(BuffId.Link, out var linkBuff))
				return false;

			if (!linkBuff.Vars.TryGet<IEnumerable<ICombatEntity>>("Melia.LinkMembers", out var linkTargets))
				return false;

			foreach (var linkTarget in linkTargets)
			{
				if (linkTarget.IsDead || linkTarget.Handle == target.Handle)
					continue;

				linkTarget.TakeSimpleHit(damage, attacker, skill.Id);
			}

			return true;
		}
	}
}
