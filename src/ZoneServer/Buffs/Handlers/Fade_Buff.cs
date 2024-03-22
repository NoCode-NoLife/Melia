using System.Linq;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting.AI;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Fade Buff, which resets the target's threat levels.
	/// </summary>
	[BuffHandler(BuffId.Fade_Buff)]
	public class Fade_Buff : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			var target = buff.Target;
			var monstersOnMap = target.Map.GetMonsters();

			// TODO: Inefficient, but we currently don't have a better way
			//   to get all monsters that are hating the buff's target.
			//   We should improve this at some point.
			foreach (var monster in monstersOnMap.OfType<ICombatEntity>())
			{
				if (!monster.Components.TryGet<AiComponent>(out var component))
					continue;

				component.Script.QueueEventAlert(new HateResetAlert(target));
			}
		}
	}
}
