using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills.Handlers.Base;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters.Components;

namespace Melia.Zone.Skills.Handlers
{
	/// <summary>
	/// Skill handler collection and manager.
	/// </summary>
	public class SkillHandlers
	{
		private readonly Dictionary<SkillId, ISkillHandler> _handlers = new();
		private readonly Dictionary<SkillId, int> _priorities = new();

		/// <summary>
		/// Initializes the skill handlers, loading all it can find in
		/// the executing assembly.
		/// </summary>
		public void Init()
		{
			this.LoadHandlersFromAssembly(Assembly.GetExecutingAssembly());
		}

		/// <summary>
		/// Loads skill handlers marked with a skill handler attribute in
		/// the given assembly.
		/// </summary>
		/// <remarks>
		/// Searches the given assembly for classes implementing the <see
		/// cref="ISkillHandler"/> interface and marked with the <see
		/// cref="SkillHandlerAttribute"/>. The handlers are then
		/// registered for the skill ids specified in the attribute.
		/// </remarks>
		/// <param name="assembly">Assembly to search for handlers.</param>
		public void LoadHandlersFromAssembly(Assembly assembly)
		{
			foreach (var type in assembly.GetTypes().Where(a => typeof(ISkillHandler).IsAssignableFrom(a) && !a.IsInterface))
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

						this.Register(skillId, handler);
						_priorities[skillId] = attr.Priority;
					}
				}
			}
		}

		/// <summary>
		/// Registers a handler for the given skill id.
		/// </summary>
		/// <param name="skillId"></param>
		/// <param name="handler"></param>
		public void Register(SkillId skillId, ISkillHandler handler)
		{
			lock (_handlers)
				_handlers[skillId] = handler;

			this.LoadCombatEvents(skillId, handler);
			ScriptableFunctions.Load(handler);
		}

		/// <summary>
		/// Sets up events for the combat events/hooks the handler implements.
		/// </summary>
		/// <param name="skillId"></param>
		/// <param name="handler"></param>
		private void LoadCombatEvents(SkillId skillId, ISkillHandler handler)
		{
			// Implement hooks via scriptable functions that call the given
			// handler for now. In terms of performance this isn't the absolute
			// best solution, but it is very flexible, and using scriptable
			// functions is idiomatic inside our combat scripting system.

			void registerAttackFunc(string name, CombatCalcHookFunction func)
			{
				ScriptableFunctions.Combat.Register(name, (attacker, target, attackerSkill, modifier, skillHitResult) =>
				{
					if (attacker.Components.TryGet<SkillComponent>(out var skills) && skills.TryGet(skillId, out var skill))
						func(skill, attacker, target, attackerSkill, modifier, skillHitResult);

					return 0;
				});
			}

			void registerDefenseFunc(string name, CombatCalcHookFunction func)
			{
				ScriptableFunctions.Combat.Register(name, (attacker, target, attackerSkill, modifier, skillHitResult) =>
				{
					if (target.Components.TryGet<SkillComponent>(out var skills) && skills.TryGet(skillId, out var skill))
						func(skill, attacker, target, attackerSkill, modifier, skillHitResult);

					return 0;
				});
			}

			if (handler is ISkillCombatAttackBeforeCalcHandler beforeCalcAttackHandler) registerAttackFunc("SCR_Combat_BeforeCalc_Attack_" + skillId, beforeCalcAttackHandler.OnAttackBeforeCalc);
			if (handler is ISkillCombatDefenseBeforeCalcHandler beforeCalcDefenseHandler) registerDefenseFunc("SCR_Combat_BeforeCalc_Defense_" + skillId, beforeCalcDefenseHandler.OnDefenseBeforeCalc);

			if (handler is ISkillCombatAttackAfterCalcHandler afterCalcAttackHandler) registerAttackFunc("SCR_Combat_AfterCalc_Attack_" + skillId, afterCalcAttackHandler.OnAttackAfterCalc);
			if (handler is ISkillCombatDefenseAfterCalcHandler afterCalcDefenseHandler) registerDefenseFunc("SCR_Combat_AfterCalc_Defense_" + skillId, afterCalcDefenseHandler.OnDefenseAfterCalc);

			if (handler is ISkillCombatAttackBeforeBonusesHandler beforeBonusesAttackHandler) registerAttackFunc("SCR_Combat_BeforeBonuses_Attack_" + skillId, beforeBonusesAttackHandler.OnAttackBeforeBonuses);
			if (handler is ISkillCombatDefenseBeforeBonusesHandler beforeBonusesDefenseHandler) registerDefenseFunc("SCR_Combat_BeforeBonuses_Defense_" + skillId, beforeBonusesDefenseHandler.OnDefenseBeforeBonuses);

			if (handler is ISkillCombatAttackAfterBonusesHandler afterBonusesAttackHandler) registerAttackFunc("SCR_Combat_AfterBonuses_Attack_" + skillId, afterBonusesAttackHandler.OnAttackAfterBonuses);
			if (handler is ISkillCombatDefenseAfterBonusesHandler afterBonusesDefenseHandler) registerDefenseFunc("SCR_Combat_AfterBonuses_Defense_" + skillId, afterBonusesDefenseHandler.OnDefenseAfterBonuses);
		}

		private delegate void CombatCalcHookFunction(Skill skill, ICombatEntity attacker, ICombatEntity target, Skill attackerSkill, SkillModifier modifier, SkillHitResult skillHitResult);

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
			lock (_handlers)
			{
				if (!_handlers.TryGetValue(skillId, out var handler))
					return default;

				if (handler is not TSkillHandler tHandler)
					throw new ArgumentException($"The skill handler for '{skillId}' is not of type '{typeof(TSkillHandler).Name}'.");

				return tHandler;
			}
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
