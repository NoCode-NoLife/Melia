using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Melia.Channel.Skills.Base;
using Melia.Channel.Skills.General;
using Melia.Shared.Tos.Const;

namespace Melia.Channel.Skills
{
	/// <summary>
	/// Skill handler collection and manager.
	/// </summary>
	public class SkillHandlers
	{
		private ITargetedSkillHandler _defaultTargetedHandler = new TargetedSkillHandler();
		private IGroundSkillHandler _defaultGroundHandler = new GroundSkillHandler();
		private ITargetGroundSkillHandler _defaultTargetedGroundHandler = new TargetedGroundSkillHandler();

		private readonly Dictionary<SkillId, ITargetedSkillHandler> _targetedHandlers = new Dictionary<SkillId, ITargetedSkillHandler>();
		private readonly Dictionary<SkillId, IGroundSkillHandler> _groundHandlers = new Dictionary<SkillId, IGroundSkillHandler>();
		private readonly Dictionary<SkillId, ITargetGroundSkillHandler> _targetedGroundHandlers = new Dictionary<SkillId, ITargetGroundSkillHandler>();

		/// <summary>
		/// Creates a new skill handler manager.
		/// </summary>
		public SkillHandlers()
		{
			this.LoadHandlersFromAssembly();
		}

		/// <summary>
		/// Loads skill handlers marked with a skill handler attribute in
		/// the current assembly.
		/// </summary>
		private void LoadHandlersFromAssembly()
		{
			// TODO: Could we possibly have a skill handler base type that
			//   supports all types of skills? So we don't need 3 different
			//   types of handlers?

			foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
			{
				var attributes = type.GetCustomAttributes(typeof(SkillHandlerAttribute), false);
				if (attributes == null || attributes.Length == 0)
					continue;

				var handler = Activator.CreateInstance(type);
				var skillIds = (attributes.First() as SkillHandlerAttribute).SkillIds;

				switch (handler)
				{
					case ITargetedSkillHandler h:
					{
						foreach (var skillId in skillIds)
							_targetedHandlers[skillId] = h;
						break;
					}
					case IGroundSkillHandler h:
					{
						foreach (var skillId in skillIds)
							_groundHandlers[skillId] = h;
						break;
					}
					case ITargetGroundSkillHandler h:
					{
						foreach (var skillId in skillIds)
							_targetedGroundHandlers[skillId] = h;
						break;
					}
				}
			}
		}

		/// <summary>
		/// Returns the skill handler for the given skill. If no specific
		/// handler was found, the default handler is returned.
		/// </summary>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public ITargetedSkillHandler GetTargeted(SkillId skillId)
		{
			if (_targetedHandlers.TryGetValue(skillId, out var handler))
				return handler;

			return _defaultTargetedHandler;
		}

		/// <summary>
		/// Returns the skill handler for the given skill. If no specific
		/// handler was found, the default handler is returned.
		/// </summary>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public IGroundSkillHandler GetGround(SkillId skillId)
		{
			if (_groundHandlers.TryGetValue(skillId, out var handler))
				return handler;

			return _defaultGroundHandler;
		}

		/// <summary>
		/// Returns the skill handler for the given skill. If no specific
		/// handler was found, the default handler is returned.
		/// </summary>
		/// <param name="skillId"></param>
		/// <returns></returns>
		public ITargetGroundSkillHandler GetTargetedGround(SkillId skillId)
		{
			if (_targetedGroundHandlers.TryGetValue(skillId, out var handler))
				return handler;

			return _defaultTargetedGroundHandler;
		}
	}
}
