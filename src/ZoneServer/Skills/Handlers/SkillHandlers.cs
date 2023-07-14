using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Melia.Shared.Tos.Const;
using Melia.Zone.Skills.Handlers.Base;

namespace Melia.Zone.Skills.Handlers
{
	/// <summary>
	/// Skill handler collection and manager.
	/// </summary>
	public class SkillHandlers
	{
		private readonly Dictionary<SkillId, ISkillHandler> _handlers = new Dictionary<SkillId, ISkillHandler>();
		private readonly Dictionary<SkillId, int> _priorities = new Dictionary<SkillId, int>();

		/// <summary>
		/// Initializes the skill handlers, loading all it can find in
		/// the executing assembly.
		/// </summary>
		public void Init()
		{
			this.LoadHandlersFromAssembly();
		}

		/// <summary>
		/// Loads skill handlers marked with a skill handler attribute in
		/// the current assembly.
		/// </summary>
		private void LoadHandlersFromAssembly()
		{
			foreach (var type in Assembly.GetExecutingAssembly().GetTypes().Where(a => typeof(ISkillHandler).IsAssignableFrom(a) && !a.IsInterface))
			{
				foreach (var attr in type.GetCustomAttributes<SkillHandlerAttribute>())
				{
					var handler = (ISkillHandler)Activator.CreateInstance(type);
					var skillIds = attr.SkillIds;

					foreach (var skillId in skillIds)
					{
						if (_priorities.TryGetValue(skillId, out var priority))
						{
							if (priority > attr.Priority)
								continue;
						}

						_handlers[skillId] = handler;
						_priorities[skillId] = attr.Priority;
					}
				}
			}
		}

		/// <summary>
		/// Returns the handler for the given skill. If no handlers was
		/// set up, null is returned.
		/// </summary>
		/// <typeparam name="TSkillHandler"></typeparam>
		/// <param name="skillId"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if the handler for the given skill doesn't match the
		/// requested type argument.
		/// </exception>
		public TSkillHandler GetHandler<TSkillHandler>(SkillId skillId) where TSkillHandler : ISkillHandler
		{
			if (!_handlers.TryGetValue(skillId, out var handler))
				return default;

			if (!(handler is TSkillHandler tHandler))
				throw new ArgumentException($"The skill handler for '{skillId}' is not of type '{typeof(TSkillHandler).Name}'.");

			return tHandler;
		}

		/// <summary>
		/// Returns the handler for the given skill via out. Returns false
		/// if no handler was set up for the skill.
		/// </summary>
		/// <typeparam name="TSkillHandler"></typeparam>
		/// <param name="skillId"></param>
		/// <param name="handler"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if the handler for the given skill doesn't match the
		/// requested type argument.
		/// </exception>
		public bool TryGetHandler<TSkillHandler>(SkillId skillId, out TSkillHandler handler) where TSkillHandler : ISkillHandler
		{
			handler = this.GetHandler<TSkillHandler>(skillId);
			return handler != null;
		}
	}
}
