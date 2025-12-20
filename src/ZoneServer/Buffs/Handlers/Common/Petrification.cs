using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Petrify, Petrified..
	/// </summary>
	[BuffHandler(BuffId.Petrification)]
	public class Petrification : BuffHandler
	{
		public override void OnActivate(Buff buff, ActivationType activationType)
		{
			var caster = buff.Caster;
			var target = buff.Target;

			Send.ZC_SHOW_EMOTICON(target, "I_emo_petrify", buff.Duration);
			Send.ZC_PLAY_SOUND(target, "skl_eff_debuff_stone");

			if (target is Character character)
				AddPropertyModifier(buff, character, PropertyName.Jumpable, -1);
		}

		public override void OnEnd(Buff buff)
		{
			var target = buff.Target;

			if (target is Character character)
				RemovePropertyModifier(buff, character, PropertyName.Jumpable);
		}
	}
}
