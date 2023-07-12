using System;
using System.Threading.Tasks;
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

		public override async void WhileActive(Buff buff)
		{
			var character = buff.Target as Character;

			if (character.Hp < character.MaxHp)
			{
				character.ModifyHp(Convert.ToInt32(character.MaxHp * 0.1f));
			}

			if (character.Sp < character.MaxSp)
			{
				character.ModifySp(Convert.ToInt32(character.MaxSp * 0.1f));
			}

			await Task.Delay(TimeSpan.FromSeconds(10));
		}
	}
}
