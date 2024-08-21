using Melia.Shared.Game.Const;
using Melia.Zone.Scripting;
using Melia.Zone.World;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.Buffs.Base
{
	/// <summary>
	/// Base class for buff handlers.
	/// </summary>
	public abstract class BuffHandler : IBuffHandler
	{
		/// <summary>
		/// Initializes buff handler.
		/// </summary>
		public BuffHandler()
		{
			ScriptableFunctions.Load(this);
		}

		/// <summary>
		/// Starts the buff, adding the initial effects.
		/// </summary>
		/// <param name="buff"></param>
		public virtual void OnStart(Buff buff)
		{
		}

		/// <summary>
		/// Called regularly, for effects that occur during while the
		/// buff is active.
		/// </summary>
		/// <param name="buff"></param>
		public virtual void WhileActive(Buff buff)
		{
		}

		/// <summary>
		/// Ends the buff, resetting any changes the buff made.
		/// </summary>
		/// <param name="buff"></param>
		public virtual void OnEnd(Buff buff)
		{
		}

		/// <summary>
		/// Returns the name of the variable used to store modifiers for
		/// the given property.
		/// </summary>
		/// <param name="propertyName"></param>
		/// <returns></returns>
		private static string GetModifierVarName(string propertyName)
			=> "Melia.Modifier." + propertyName;

		/// <summary>
		/// Modifies the property on the target and saves the value in the buff,
		/// to be able to later undo the change.
		/// </summary>
		/// <remarks>
		/// Repeated calls to this method will stack the modifications, while
		/// one call to RemovePropertyModifier will undo all of them.
		/// </remarks>
		/// <param name="buff"></param>
		/// <param name="target"></param>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		protected static void AddPropertyModifier(Buff buff, ICombatEntity target, string propertyName, float value)
		{
			var varName = GetModifierVarName(propertyName);

			if (buff.Vars.TryGetFloat(varName, out var oldValue))
				value += oldValue;

			buff.Vars.SetFloat(varName, value);
			target.Properties.Modify(propertyName, value);
		}

		/// <summary>
		/// Undoes the modifications done to the property on target from
		/// ApplyPropertyModifier.
		/// </summary>
		/// <param name="buff"></param>
		/// <param name="target"></param>
		/// <param name="propertyName"></param>
		protected static void RemovePropertyModifier(Buff buff, ICombatEntity target, string propertyName)
		{
			var varName = GetModifierVarName(propertyName);

			if (buff.Vars.TryGetFloat(varName, out var value))
			{
				target.Properties.Modify(propertyName, -value);
				buff.Vars.Remove(varName);
			}
		}

		/// <summary>
		/// Sets the value of a property modifier on the target.
		/// </summary>
		/// <remarks>
		/// Removes existing modifiers for the property and then applies the new one.
		/// This is essentially the same as calling RemovePropertyModifier followed
		/// by AddPropertyModifier.
		/// </remarks>
		/// <param name="buff"></param>
		/// <param name="target"></param>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		protected static void UpdatePropertyModifier(Buff buff, ICombatEntity target, string propertyName, float value)
			=> SetPropertyModifier(buff, target, propertyName, value);

		/// <summary>
		/// Updates the value of a property modifier on the target.
		/// </summary>
		/// <remarks>
		/// Removes existing modifiers for the property and then applies the new one.
		/// This is essentially the same as calling RemovePropertyModifier followed
		/// by AddPropertyModifier.
		/// </remarks>
		/// <param name="buff"></param>
		/// <param name="target"></param>
		/// <param name="propertyName"></param>
		/// <param name="value"></param>
		protected static void SetPropertyModifier(Buff buff, ICombatEntity target, string propertyName, float value)
		{
			RemovePropertyModifier(buff, target, propertyName);
			AddPropertyModifier(buff, target, propertyName, value);
		}
	}
}
