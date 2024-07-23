using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Melia.Zone.Buffs.Base;
using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.Skills.Combat;
using Melia.Zone.Skills;
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
			this.LoadHandlersFromAssembly();
		}

		/// <summary>
		/// Loads buff handlers marked with a buff handler attribute in
		/// the current assembly.
		/// </summary>
		private void LoadHandlersFromAssembly()
		{
			foreach (var type in Assembly.GetExecutingAssembly().GetTypes())
			{
				var attributes = type.GetCustomAttributes(typeof(BuffHandlerAttribute), false);
				if (attributes == null || attributes.Length == 0)
					continue;

				var handler = Activator.CreateInstance(type) as IBuffHandler;
				var buffIds = (attributes.First() as BuffHandlerAttribute).BuffIds;

				foreach (var buffId in buffIds)
					this.Register(buffId, handler);
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

			void registerFunc(string name, CombatCalcHookFunction func)
			{
				ScriptableFunctions.Combat.Register(name, (attacker, target, skill, modifier, skillHitResult) =>
				{
					if (attacker.TryGetBuff(buffId, out var buff))
						func(buff, attacker, target, skill, modifier, skillHitResult);

					return 0;
				});
			}

			if (handler is IBuffCombatAttackBeforeCalcHandler beforeCalcAttackHandler) registerFunc("SCR_Combat_BeforeCalc_Attack_" + buffId, beforeCalcAttackHandler.OnAttackBeforeCalc);
			if (handler is IBuffCombatDefenseBeforeCalcHandler beforeCalcDefenseHandler) registerFunc("SCR_Combat_BeforeCalc_Defense_" + buffId, beforeCalcDefenseHandler.OnDefenseBeforeCalc);

			if (handler is IBuffCombatAttackAfterCalcHandler afterCalcAttackHandler) registerFunc("SCR_Combat_AfterCalc_Attack_" + buffId, afterCalcAttackHandler.OnAttackAfterCalc);
			if (handler is IBuffCombatDefenseAfterCalcHandler afterCalcDefenseHandler) registerFunc("SCR_Combat_AfterCalc_Defense_" + buffId, afterCalcDefenseHandler.OnDefenseAfterCalc);

			if (handler is IBuffCombatAttackBeforeBonusesHandler beforeBonusesAttackHandler) registerFunc("SCR_Combat_BeforeBonuses_Attack_" + buffId, beforeBonusesAttackHandler.OnAttackBeforeBonuses);
			if (handler is IBuffCombatDefenseBeforeBonusesHandler beforeBonusesDefenseHandler) registerFunc("SCR_Combat_BeforeBonuses_Defense_" + buffId, beforeBonusesDefenseHandler.OnDefenseBeforeBonuses);

			if (handler is IBuffCombatAttackAfterBonusesHandler afterBonusesAttackHandler) registerFunc("SCR_Combat_AfterBonuses_Attack_" + buffId, afterBonusesAttackHandler.OnAttackAfterBonuses);
			if (handler is IBuffCombatDefenseAfterBonusesHandler afterBonusesDefenseHandler) registerFunc("SCR_Combat_AfterBonuses_Defense_" + buffId, afterBonusesDefenseHandler.OnDefenseAfterBonuses);
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
