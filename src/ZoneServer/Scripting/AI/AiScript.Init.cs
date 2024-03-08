using System;
using System.Collections.Generic;
using System.Reflection;
using Melia.Shared.Game.Const;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Scripting.AI
{
	public abstract partial class AiScript
	{
		private readonly static Dictionary<string, Type> AiScriptTypes = new Dictionary<string, Type>();

		/// <summary>
		/// Initializes the AI script upon loading.
		/// </summary>
		/// <returns></returns>
		public bool Init()
		{
			var type = this.GetType();

			foreach (var attribute in type.GetCustomAttributes<AiAttribute>())
				Register(attribute.Name, type);

			return true;
		}

		/// <summary>
		/// Registers the given AI script.
		/// </summary>
		/// <typeparam name="TAiScript"></typeparam>
		/// <param name="aiName"></param>
		public static void Register<TAiScript>(string aiName) where TAiScript : AiScript
			=> Register(aiName, typeof(TAiScript));

		/// <summary>
		/// Registers the given AI script.
		/// </summary>
		/// <param name="aiName"></param>
		/// <param name="aiType"></param>
		/// <exception cref="ArgumentException"></exception>
		public static void Register(string aiName, Type aiType)
		{
			if (!aiType.IsSubclassOf(typeof(AiScript)))
				throw new ArgumentException($"Type '{aiType.Name}' does not inherit '{nameof(AiScript)}'.");

			AiScriptTypes[aiName] = aiType;
		}

		/// <summary>
		/// Attempts to create an AI script for the given entity and returns
		/// it via out. Returns false if no matching AI script was found.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="entity"></param>
		/// <param name="aiScript"></param>
		/// <returns></returns>
		public static bool TryCreate(string name, ICombatEntity entity, out AiScript aiScript)
		{
			aiScript = null;

			if (!AiScriptTypes.TryGetValue(name, out var type))
				return false;

			aiScript = (AiScript)Activator.CreateInstance(type);
			aiScript.InitFor(entity);

			return true;
		}
	}
}
