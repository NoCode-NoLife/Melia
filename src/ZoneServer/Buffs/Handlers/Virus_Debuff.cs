using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.Skills.Combat;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Virus Debuff, which ticks damage every second.
	/// </summary>
	[BuffHandler(BuffId.Virus_Debuff)]
	public class Virus_Debuff : BuffHandler
	{
		private const string varName = "Melia.SpreadTargets";

		public override void OnStart(Buff buff)
		{
			buff.Vars.SetInt(varName, 0);
		}

		public override void WhileActive(Buff buff)
		{
			var casterCharacter = buff.Caster as Character;

			if (casterCharacter != null)
			{
				// The damage amount is unknow, for now we are dealing
				// the same amount as the original skill hit is passed as NumberArg2
				buff.Target.TakeDamage(buff.NumArg2, casterCharacter);

				var hit = new HitInfo(casterCharacter, buff.Target, null, buff.NumArg2, HitResultType.Hit);
				hit.ForceId = ForceId.GetNew();

				Send.ZC_HIT_INFO(casterCharacter, buff.Target, null, hit);
			}
		}
	}
}
