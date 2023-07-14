using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors.Characters;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handler for the campfire Buff, which increases the target's HP/SP and Stamina recovery
	/// crit rate.
	/// </summary>
	[BuffHandler(BuffId.campfire_Buff)]
	public class campfire_Buff : BuffHandler
	{
		private const string VarName = "Melia.StaminaRecovery";

		public override void OnStart(Buff buff)
		{
			var bonus = 600;
			buff.Vars.SetFloat(VarName, bonus);

			buff.Target.Properties.Modify(PropertyName.RSta_BM, bonus);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(VarName, out var bonus))
				buff.Target.Properties.Modify(PropertyName.RSta_BM, -bonus);
		}

		public override void WhileActive(Buff buff)
		{
			var target = buff.Target;
			var maxHp = target.Properties.GetFloat(PropertyName.MHP);

			if (target.Hp < maxHp)
			{
				target.Heal(maxHp * 0.1f, 0);
			}

			var character = target as Character;

			if (character != null)
			{
				if (character.Sp < character.MaxSp)
				{
					character.ModifySp(character.MaxSp * 0.1f);
				}
			} 		
		}
	}
}
