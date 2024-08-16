using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Abilities
{
	/// <summary>
	/// Ability handler collection and manager.
	/// </summary>
	public class AbilityHandlers
	{
		private readonly Dictionary<AbilityId, IAbilityHandler> _handlers = new();

		/// <summary>
		/// Creates a new ability handler manager.
		/// </summary>
		public AbilityHandlers()
		{
			this.LoadHandlersFromAssembly();
		}

		/// <summary>
		/// Loads ability handlers marked with a ability handler attribute in
		/// the current assembly.
		/// </summary>
		private void LoadHandlersFromAssembly()
		{
			foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
			{
				var attributes = type.GetCustomAttributes(typeof(AbilityHandlerAttribute), false);
				if (attributes == null || attributes.Length == 0)
					continue;

				var handler = Activator.CreateInstance(type) as IAbilityHandler;
				var abilityIds = (attributes.First() as AbilityHandlerAttribute).Ids;

				foreach (var abilityId in abilityIds)
					this.Register(abilityId, handler);
			}
		}

		/// <summary>
		/// Registers a ability handler for the given ability id.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <param name="handler"></param>
		public void Register(AbilityId abilityId, IAbilityHandler handler)
		{
			lock (_handlers)
				_handlers[abilityId] = handler;

			this.LoadCombatEvents(abilityId, handler);
		}

		/// <summary>
		/// Sets up events for the combat events/hooks the handler implements.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <param name="handler"></param>
		private void LoadCombatEvents(AbilityId abilityId, IAbilityHandler handler)
		{
			// Implement hooks via scriptable functions that call the given
			// handler for now. In terms of performance this isn't the absolute
			// best solution, but it is very flexible, and using scriptable
			// functions is idiomatic inside our combat scripting system.

			void registerAttackFunc(string name, CombatCalcHookFunction func)
			{
				ScriptableFunctions.Combat.Register(name, (attacker, target, skill, modifier, skillHitResult) =>
				{
					if (attacker.TryGetAbility(abilityId, out var ability) && ability.Active)
						func(ability, attacker, target, skill, modifier, skillHitResult);

					return 0;
				});
			}

			void registerDefenseFunc(string name, CombatCalcHookFunction func)
			{
				ScriptableFunctions.Combat.Register(name, (attacker, target, skill, modifier, skillHitResult) =>
				{
					if (target.TryGetAbility(abilityId, out var ability))
						func(ability, attacker, target, skill, modifier, skillHitResult);

					return 0;
				});
			}

			if (handler is IAbilityCombatAttackBeforeCalcHandler beforeCalcAttackHandler) registerAttackFunc("SCR_Combat_BeforeCalc_Attack_" + abilityId, beforeCalcAttackHandler.OnAttackBeforeCalc);
			if (handler is IAbilityCombatDefenseBeforeCalcHandler beforeCalcDefenseHandler) registerDefenseFunc("SCR_Combat_BeforeCalc_Defense_" + abilityId, beforeCalcDefenseHandler.OnDefenseBeforeCalc);

			if (handler is IAbilityCombatAttackAfterCalcHandler afterCalcAttackHandler) registerAttackFunc("SCR_Combat_AfterCalc_Attack_" + abilityId, afterCalcAttackHandler.OnAttackAfterCalc);
			if (handler is IAbilityCombatDefenseAfterCalcHandler afterCalcDefenseHandler) registerDefenseFunc("SCR_Combat_AfterCalc_Defense_" + abilityId, afterCalcDefenseHandler.OnDefenseAfterCalc);

			if (handler is IAbilityCombatAttackBeforeBonusesHandler beforeBonusesAttackHandler) registerAttackFunc("SCR_Combat_BeforeBonuses_Attack_" + abilityId, beforeBonusesAttackHandler.OnAttackBeforeBonuses);
			if (handler is IAbilityCombatDefenseBeforeBonusesHandler beforeBonusesDefenseHandler) registerDefenseFunc("SCR_Combat_BeforeBonuses_Defense_" + abilityId, beforeBonusesDefenseHandler.OnDefenseBeforeBonuses);

			if (handler is IAbilityCombatAttackAfterBonusesHandler afterBonusesAttackHandler) registerAttackFunc("SCR_Combat_AfterBonuses_Attack_" + abilityId, afterBonusesAttackHandler.OnAttackAfterBonuses);
			if (handler is IAbilityCombatDefenseAfterBonusesHandler afterBonusesDefenseHandler) registerDefenseFunc("SCR_Combat_AfterBonuses_Defense_" + abilityId, afterBonusesDefenseHandler.OnDefenseAfterBonuses);
		}

		private delegate void CombatCalcHookFunction(Ability ability, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult);

		/// <summary>
		/// Returns true if a handler was registered for the given ability.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <returns></returns>
		public bool Has(AbilityId abilityId)
		{
			lock (_handlers)
				return _handlers.ContainsKey(abilityId);
		}

		/// <summary>
		/// Returns the ability handler for the given ability. Returns null if
		/// no handler was found.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <returns></returns>
		public IAbilityHandler GetHandler(AbilityId abilityId)
		{
			lock (_handlers)
			{
				if (_handlers.TryGetValue(abilityId, out var handler))
					return handler;
			}

			return null;
		}

		/// <summary>
		/// Returns handler for the given ability via out. Returns false if
		/// no handler was found.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <param name="handler"></param>
		/// <returns></returns>
		public bool TryGetHandler(AbilityId abilityId, out IAbilityHandler handler)
		{
			lock (_handlers)
				return _handlers.TryGetValue(abilityId, out handler);
		}
	}
}
