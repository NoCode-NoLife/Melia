using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.World.Actors;
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
		private Dictionary<ICombatEntity, CancellationTokenSource> _cancellationTokenSource = new Dictionary<ICombatEntity, CancellationTokenSource>();

		public override void OnStart(Buff buff)
		{
			var bonus = 600;
			buff.Vars.SetFloat(VarName, bonus);

			buff.Target.Properties.Modify(PropertyName.RSta_BM, bonus);

			var cancellationTokenSource = new CancellationTokenSource();

			if (!_cancellationTokenSource.ContainsKey(buff.Target))
				_cancellationTokenSource.Add(buff.Target, cancellationTokenSource);

			this.WhileActive(buff, cancellationTokenSource.Token);
		}

		public override void OnEnd(Buff buff)
		{
			if (buff.Vars.TryGetFloat(VarName, out var bonus))
				buff.Target.Properties.Modify(PropertyName.RSta_BM, -bonus);

			if (_cancellationTokenSource.ContainsKey(buff.Target))
			{
				_cancellationTokenSource[buff.Target].Cancel();
				_cancellationTokenSource.Remove(buff.Target);
			}				
		}

		private async void WhileActive(Buff buff, CancellationToken cancellationToken)
		{
			while (!cancellationToken.IsCancellationRequested)
			{
				var character = buff.Target as Character;

				if (character != null)
				{
					if (character.Hp < character.MaxHp)
					{
						character.ModifyHp((int)(character.MaxHp * 0.1f));
					}

					if (character.Sp < character.MaxSp)
					{
						character.ModifySp((int)(character.MaxSp * 0.1f));
					}
				}

				await Task.Delay(TimeSpan.FromSeconds(10));
			}
		}
	}
}
