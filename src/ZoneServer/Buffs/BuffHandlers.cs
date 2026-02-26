using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Melia.Shared.Game.Const;
using Melia.Zone.Abilities;
using Melia.Zone.Buffs.Base;
using Melia.Zone.Scripting;
using Melia.Zone.Skills;
using Melia.Zone.Skills.Combat;
using Melia.Zone.World.Actors;

namespace Melia.Zone.Buffs
{
	/// <summary>
	/// Buff handler collection and manager.
	/// </summary>
	public class BuffHandlers
	{
		private readonly Dictionary<BuffId, IBuffHandler> _buffHandlers = new();

		/// <summary>
		/// Creates a new buff handler manager.
		/// </summary>
		public BuffHandlers()
		{
			this.LoadHandlersFromAssembly(Assembly.GetExecutingAssembly());
		}

		/// <summary>
		/// Loads ability handlers marked with an ability handler
		/// attribute in the given assembly.
		/// </summary>
		/// <remarks>
		/// Searches the given assembly for classes implementing the <see
		/// cref="IAbilityHandler"/> interface and marked with the <see
		/// cref="AbilityHandlerAttribute"/>. The handlers are then
		/// registered for the ability ids specified in the attribute.
		/// </remarks>
		/// <param name="assembly">Assembly to search for handlers.</param>
		public void LoadHandlersFromAssembly(Assembly assembly)
		{
			foreach (var type in assembly.GetTypes().Where(a => typeof(IBuffHandler).IsAssignableFrom(a) && !a.IsInterface))
			{
				foreach (var attr in type.GetCustomAttributes<BuffHandlerAttribute>())
				{
					var handler = (IBuffHandler)Activator.CreateInstance(type);
					var buffIds = attr.BuffIds;

					foreach (var buffId in buffIds)
						this.Register(buffId, handler);
				}
			}
		}

		/// <summary>
		/// Registers a buff handler for the given buff id.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="handler"></param>
		public void Register(BuffId buffId, IBuffHandler handler)
		{
			lock (_buffHandlers)
				_buffHandlers[buffId] = handler;

			this.LoadCombatEvents(buffId, handler);
			ScriptableFunctions.Load(handler);
		}

		/// <summary>
		/// Sets up events for the combat events/hooks the handler implements.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="handler"></param>
		private void LoadCombatEvents(BuffId buffId, IBuffHandler handler)
		{
			// Implement hooks via scriptable functions that call the given
			// handler for now. In terms of performance this isn't the absolute
			// best solution, but it is very flexible, and using scriptable
			// functions is idiomatic inside our combat scripting system.

			void registerAttackFunc(string name, CombatCalcHookFunction func)
			{
				ScriptableFunctions.Combat.Register(name, (attacker, target, skill, modifier, skillHitResult) =>
				{
					if (attacker.TryGetBuff(buffId, out var buff))
						func(buff, attacker, target, skill, modifier, skillHitResult);

					return 0;
				});
			}

			void registerDefenseFunc(string name, CombatCalcHookFunction func)
			{
				ScriptableFunctions.Combat.Register(name, (attacker, target, skill, modifier, skillHitResult) =>
				{
					if (target.TryGetBuff(buffId, out var buff))
						func(buff, attacker, target, skill, modifier, skillHitResult);

					return 0;
				});
			}

			if (handler is IBuffCombatAttackBeforeCalcHandler beforeCalcAttackHandler) registerAttackFunc("SCR_Combat_BeforeCalc_Attack_" + buffId, beforeCalcAttackHandler.OnAttackBeforeCalc);
			if (handler is IBuffCombatDefenseBeforeCalcHandler beforeCalcDefenseHandler) registerDefenseFunc("SCR_Combat_BeforeCalc_Defense_" + buffId, beforeCalcDefenseHandler.OnDefenseBeforeCalc);

			if (handler is IBuffCombatAttackAfterCalcHandler afterCalcAttackHandler) registerAttackFunc("SCR_Combat_AfterCalc_Attack_" + buffId, afterCalcAttackHandler.OnAttackAfterCalc);
			if (handler is IBuffCombatDefenseAfterCalcHandler afterCalcDefenseHandler) registerDefenseFunc("SCR_Combat_AfterCalc_Defense_" + buffId, afterCalcDefenseHandler.OnDefenseAfterCalc);

			if (handler is IBuffCombatAttackBeforeBonusesHandler beforeBonusesAttackHandler) registerAttackFunc("SCR_Combat_BeforeBonuses_Attack_" + buffId, beforeBonusesAttackHandler.OnAttackBeforeBonuses);
			if (handler is IBuffCombatDefenseBeforeBonusesHandler beforeBonusesDefenseHandler) registerDefenseFunc("SCR_Combat_BeforeBonuses_Defense_" + buffId, beforeBonusesDefenseHandler.OnDefenseBeforeBonuses);

			if (handler is IBuffCombatAttackAfterBonusesHandler afterBonusesAttackHandler) registerAttackFunc("SCR_Combat_AfterBonuses_Attack_" + buffId, afterBonusesAttackHandler.OnAttackAfterBonuses);
			if (handler is IBuffCombatDefenseAfterBonusesHandler afterBonusesDefenseHandler) registerDefenseFunc("SCR_Combat_AfterBonuses_Defense_" + buffId, afterBonusesDefenseHandler.OnDefenseAfterBonuses);
		}

		private delegate void CombatCalcHookFunction(Buff buff, ICombatEntity attacker, ICombatEntity target, Skill skill, SkillModifier modifier, SkillHitResult skillHitResult);

		/// <summary>
		/// Returns true if a handler was registered for the given buff.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public bool Has(BuffId buffId)
		{
			lock (_buffHandlers)
				return _buffHandlers.ContainsKey(buffId);
		}

		/// <summary>
		/// Returns the buff handler for the given buff. Returns null if
		/// no handler was found.
		/// </summary>
		/// <param name="buffId"></param>
		/// <returns></returns>
		public IBuffHandler GetHandler(BuffId buffId)
		{
			lock (_buffHandlers)
			{
				if (_buffHandlers.TryGetValue(buffId, out var handler))
					return handler;
			}

			return null;
		}

		/// <summary>
		/// Returns handler for the given buff via out. Returns false if
		/// no handler was found.
		/// </summary>
		/// <param name="buffId"></param>
		/// <param name="handler"></param>
		/// <returns></returns>
		public bool TryGetHandler(BuffId buffId, out IBuffHandler handler)
		{
			lock (_buffHandlers)
				return _buffHandlers.TryGetValue(buffId, out handler);
		}
	}
}
