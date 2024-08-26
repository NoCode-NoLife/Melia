using System;
using Melia.Shared.Game.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs.Handlers.Scouts.BulletMaker
{
	/// <summary>
	/// Handle for the FreezeBullet Cold Debuff, which freezes the enemy for 2 seconds upon reaching 4 stacks
	/// </summary>
	[BuffHandler(BuffId.FreezeBullet_Cold_Debuff)]
	public class FreezeBullet_Cold_Debuff : BuffHandler
	{
		public override void OnStart(Buff buff)
		{
			if (!buff.Vars.GetBool("Slow_FreezeBullet_Cold_Debuff"))
			{
				var reduceMspd = buff.Target.Properties.GetFloat(PropertyName.MSPD) * 0.5f;

				AddPropertyModifier(buff, buff.Target, PropertyName.MSPD_BM, -reduceMspd);
				Send.ZC_MSPD(buff.Target);

				buff.Vars.SetBool("Slow_FreezeBullet_Cold_Debuff", true);
			}

			if (buff.OverbuffCounter >= 4)
			{
				buff.Target.StartBuff(BuffId.Freeze, 0f, 0f, TimeSpan.FromSeconds(2), buff.Caster);
				buff.Stop();
			}
		}

		public override void OnEnd(Buff buff)
		{
			RemovePropertyModifier(buff, buff.Target, PropertyName.MSPD_BM);
			Send.ZC_MSPD(buff.Target);
			buff.Vars.SetBool("Slow_FreezeBullet_Cold_Debuff", false);
		}
	}
}
