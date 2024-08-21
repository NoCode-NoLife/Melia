using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.Scripting.AI;
using Melia.Zone.World.Actors.CombatEntities.Components;

namespace Melia.Zone.Buffs.Handlers.Swordsmen.Peltasta
{
	/// <summary>
	/// Handle for the Capote Debuff, which increases the thread from the mob to the caster
	/// </summary>
	[BuffHandler(BuffId.Capote_Debuff)]
	public class Capote_Debuff : BuffHandler
	{
		private const float DecreaseCrtResRate = -0.15f;

		public override void OnStart(Buff buff)
		{
			var target = buff.Target;
			var caster = buff.Caster;

			Send.ZC_NORMAL.UpdateModelColor(target, 150, 160, 255, 255, 1.5f);

			AddPropertyModifier(buff, target, PropertyName.CRTDR_BM, DecreaseCrtResRate);

			if (target.Components.TryGet<AiComponent>(out var component))			
				component.Script.QueueEventAlert(new TauntEventAlert(target, caster));
			
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;
			var caster = buff.Caster;

			Send.ZC_NORMAL.UpdateModelColor(target, 255, 255, 255, 255, 1);

			RemovePropertyModifier(buff, target, PropertyName.CRTDR_BM);

			if (target.Components.TryGet<AiComponent>(out var component))
				component.Script.QueueEventAlert(new DecreaseHateEventAlert(target, caster));			
		}
	}
}
