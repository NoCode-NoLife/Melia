using System.Threading.Tasks;
using System.Threading;
using Melia.Shared.Tos.Const;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.Skills.Combat;
using static Melia.Zone.Skills.SkillUseFunctions;

namespace Melia.Zone.Buffs.Handlers
{
	/// <summary>
	/// Handle for the Latent Venom Debuff, which ticks damage every second.
	/// </summary>
	[BuffHandler(BuffId.LatentVenom_Debuff)]
	public class LatentVenom_Debuff : BuffHandler
	{
		private Task _tickDamage;
		private CancellationTokenSource _cancellationTokenSource;

		public override void OnStart(Buff buff)
		{
			_cancellationTokenSource = new CancellationTokenSource();
			_tickDamage = Task.Run(() => TickDamage(_cancellationTokenSource.Token, buff));
		}

		public override void OnEnd(Buff buff)
		{
			if (_tickDamage != null)
			{
				_cancellationTokenSource?.Cancel();
				_tickDamage = null;
			}
		}

		async Task TickDamage(CancellationToken cancellationToken, Buff buff)
		{
			while (true)
			{
				if (cancellationToken.IsCancellationRequested)
				{
					break;
				}

				await Task.Delay(1000);

				var casterCharacter = buff.Caster as Character;

				if (casterCharacter != null)
				{
					// The damage amount is unknow, for now we are dealing the same amount as the original skill hit
					// TODO: Update this and make it do poison type damage
					var skillHitResult = SCR_SkillHit(casterCharacter, buff.Target, buff.Skill);
					buff.Target.TakeDamage(skillHitResult.Damage, casterCharacter);

					var hit = new HitInfo(casterCharacter, buff.Target, buff.Skill, skillHitResult.Damage, skillHitResult.Result);
					hit.ForceId = ForceId.GetNew();

					Send.ZC_HIT_INFO(casterCharacter, buff.Target, buff.Skill, hit);
				}
			}
		}
	}
}
