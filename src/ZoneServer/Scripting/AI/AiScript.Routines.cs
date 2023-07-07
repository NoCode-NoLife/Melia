using System;
using System.Collections;
using System.Linq;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Logging;
using Yggdrasil.Util;

namespace Melia.Zone.Scripting.AI
{
	public abstract partial class AiScript
	{
		private readonly Random _rnd = new Random(RandomProvider.GetSeed());

		/// <summary>
		/// Moves entity to a random location within the given distance.
		/// </summary>
		/// <param name="min">Minimum distance to move.</param>
		/// <param name="max">Maximum distance to move.</param>
		/// <param name="wait">If true, the routine doesn't return until the destination was reached.</param>
		/// <returns></returns>
		protected IEnumerable MoveRandom(int min = 35, int max = 50, bool wait = true)
		{
			min = 100;
			min = Math.Max(1, min);
			max = Math.Max(min, max);

			var radius = this.Random(min, max + 1);
			var destination = this.Entity.Position;
			var foundValidDest = false;

			for (var i = 0; i < 10; ++i)
			{
				destination = this.Entity.Position.GetRandomInRange2D(radius, _rnd);
				if (this.Entity.Map.Ground.IsValidPosition(destination))
				{
					foundValidDest = true;
					break;
				}
			}

			if (foundValidDest)
				yield return this.MoveTo(destination, wait);
			else if (wait)
				yield return this.Wait(2000);

			yield break;
		}

		/// <summary>
		/// Moves entity to the given destination.
		/// </summary>
		/// <param name="destination"></param>
		/// <param name="wait">If true, the routine doesn't return until the destination was reached.</param>
		/// <returns></returns>
		protected IEnumerable MoveTo(Position destination, bool wait = true)
		{
			var movement = this.Entity.Components.Get<MovementComponent>();
			var moveTime = movement.MoveTo(destination);

			if (wait)
				yield return this.Wait(moveTime);
			else
				yield break;
		}

		/// <summary>
		/// Stops entity movement.
		/// </summary>
		/// <returns></returns>
		protected IEnumerable StopMove()
		{
			this.Entity.Components.Get<MovementComponent>().Stop();
			yield break;
		}

		/// <summary>
		/// Makes entity say the given message.
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		protected IEnumerable Say(string message)
		{
			Send.ZC_CHAT(this.Entity, message);
			yield break;
		}

		/// <summary>
		/// Makes entity use the given emoticon.
		/// </summary>
		/// <param name="packetString"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		protected IEnumerable Emoticon(string packetString)
		{
			Send.ZC_SHOW_EMOTICON(this.Entity, packetString, TimeSpan.FromSeconds(2));
			yield break;
		}

		/// <summary>
		/// Returns a random skill the entity can use
		/// </summary>
		/// <param name="skill"></param>
		/// <returns></returns>
		protected bool TryGetRandomSkill(out Skill skill)
		{
			skill = null;

			if (!(this.Entity is Mob mob))
				return false;

			if (!mob.Data.Skills.Any())
				return false;

			// I thought we wouldn't need probabilities in the
			// monster skill data, but it actually would be convenient
			// to have. Though we have no source for them, so we'd have
			// to define them ourselves. Anyway, for now we'll just
			// always pick the first skill, assuming it's the default
			// attack for the given monster.

			//var rndSkillId = mob.Data.Skills.Random().SkillId;
			var rndSkillId = mob.Data.Skills.First().SkillId;

			// Should we give monsters a skill manager? We might not
			// actually need it, though we should probably at least
			// cache the skills if we create them on demand.
			skill = new Skill(this.Entity, rndSkillId, 1);

			return true;
		}

		/// <summary>
		/// Makes entity use the given skill on the target.
		/// </summary>
		/// <param name="skill"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		protected IEnumerable UseSkill(Skill skill, ICombatEntity target)
		{
			this.Entity.TurnTowards(target);

			if (!ZoneServer.Instance.SkillHandlers.TryGetHandler<ITargetSkillHandler>(skill.Id, out var handler))
			{
				Log.Warning($"AiScript: No handler found for skill '{skill.Id}'.");
				yield return this.Wait(2000);
				yield break;
			}

			handler.Handle(skill, this.Entity, target);

			yield return this.Wait(2000);
		}

		/// <summary>
		/// Makes entity play the given animation.
		/// </summary>
		/// <param name="packetString"></param>
		/// <returns></returns>
		protected IEnumerable Animation(string packetString)
		{
			Send.ZC_PLAY_ANI(this.Entity, packetString);
			yield break;
		}
	}
}
