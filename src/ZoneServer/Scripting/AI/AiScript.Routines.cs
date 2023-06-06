using System;
using System.Collections;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Util;

namespace Melia.Zone.Scripting.AI
{
	public abstract partial class AiScript
	{
		private readonly Random _rnd = new Random(RandomProvider.GetSeed());

		/// <summary>
		/// Moves entity to a random location within the given distance.
		/// </summary>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		protected IEnumerable MoveRandom(int min = 25, int max = 50)
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
				yield return this.MoveTo(destination);
			else
				yield return this.Wait(2000);

			yield break;
		}

		/// <summary>
		/// Moves entity to the given destination.
		/// </summary>
		/// <param name="destination"></param>
		/// <returns></returns>
		protected IEnumerable MoveTo(Position destination)
		{
			var movement = this.Entity.Components.Get<Movement>();
			var moveTime = movement.MoveTo(destination);

			yield return this.Wait(moveTime);
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
			if (!ZoneServer.Instance.Data.PacketStringDb.TryFind(packetString, out var data))
				throw new ArgumentException($"Packet string '{packetString}' not found.");

			Send.ZC_SHOW_EMOTICON(this.Entity, data.Id, TimeSpan.FromSeconds(2));
			yield break;
		}
	}
}
