using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting.AI;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Peltasta
{
	/// <summary>
	/// Handle for the Ole Debuff, which increases the thread from the mob to the caster
	/// </summary>
	[BuffHandler(BuffId.Ole_Debuff)]
	public class Ole_Debuff : BuffHandler
	{
		private const float DecreaseCrtResRate = -0.15f;

		public override void OnStart(Buff buff)
		{
			var target = buff.Target;
			var caster = buff.Caster;

			if (target.Components.TryGet<AiComponent>(out var component))
				component.Script.QueueEventAlert(new TauntEventAlert(target, caster));
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;
			var caster = buff.Caster;

			if (target.Components.TryGet<AiComponent>(out var component))
				component.Script.QueueEventAlert(new DecreaseHateEventAlert(target, caster));
		}
	}
}
