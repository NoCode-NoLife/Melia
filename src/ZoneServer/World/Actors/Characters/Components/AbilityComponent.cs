using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// A character's abilities.
	/// </summary>
	public class AbilityComponent : CharacterComponent
	{
		private readonly Dictionary<AbilityId, Ability> _abilities = new();

		/// <summary>
		/// Returns amount of abilities.
		/// </summary>
		public int Count { get { lock (_abilities) return _abilities.Count; } }

		/// <summary>
		/// Creates a new instance for character.
		/// </summary>
		/// <param name="character"></param>
		public AbilityComponent(Character character) : base(character)
		{
		}

		/// <summary>
		/// Adds ability without updating the client. Overwrites existing
		/// abilities.
		/// </summary>
		/// <param name="ability"></param>
		public void AddSilent(Ability ability)
		{
			lock (_abilities)
				_abilities[ability.Id] = ability;
		}

		/// <summary>
		/// Adds ability and updates client. Overwrites existing abilities.
		/// </summary>
		/// <param name="ability"></param>
		public void Add(Ability ability)
		{
			this.AddSilent(ability);
			Send.ZC_ABILITY_LIST(this.Character);
		}

		/// <summary>
		/// Removes the ability with the given id, returns false if it
		/// didn't exist.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <returns></returns>
		public bool Remove(AbilityId abilityId)
		{
			lock (_abilities)
				return _abilities.Remove(abilityId);
		}

		/// <summary>
		/// Returns list of all abilities.
		/// </summary>
		/// <returns></returns>
		public Ability[] GetList()
		{
			lock (_abilities)
				return _abilities.Values.ToArray();
		}

		/// <summary>
		/// Returns a list of abilities that match the given predicate.
		/// </summary>
		/// <param name="predicate"></param>
		/// <returns></returns>
		public Ability[] GetList(Func<Ability, bool> predicate)
		{
			lock (_abilities)
				return _abilities.Values.Where(predicate).ToArray();
		}

		/// <summary>
		/// Returns the level of the given ability. Returns 0 if the
		/// character doesn't have the ability.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <returns></returns>
		public int GetLevel(AbilityId abilityId)
		{
			lock (_abilities)
			{
				if (_abilities.TryGetValue(abilityId, out var ability))
					return ability.Level;
			}

			return 0;
		}

		/// <summary>
		/// Returns true if character has the ability at at least the
		/// given level.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <returns></returns>
		public bool Has(AbilityId abilityId, int level = 0)
		{
			var ability = this.Get(abilityId);
			return (ability != null && ability.Level >= level);
		}

		/// <summary>
		/// Returns true if the character has the given ability and it's
		/// toggled on. Abilities that aren't toggleable are considered
		/// always-on.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <returns></returns>
		public bool IsActive(AbilityId abilityId)
			=> this.Get(abilityId)?.Active ?? false;

		/// <summary>
		/// Returns the given ability via out if it exists and is active.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <param name="ability"></param>
		/// <returns></returns>
		public bool TryGetActive(AbilityId abilityId, out Ability ability)
		{
			ability = this.Get(abilityId);
			return (ability != null && ability.Active);
		}

		/// <summary>
		/// Returns the given ability via out if it exists, regardless of
		/// whether it's active or not.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <param name="ability"></param>
		/// <returns></returns>
		public bool TryGet(AbilityId abilityId, out Ability ability)
		{
			ability = this.Get(abilityId);
			return (ability != null);
		}

		/// <summary>
		/// Returns the ability with the given id, or null if it didn't
		/// exist.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <returns></returns>
		public Ability Get(AbilityId abilityId)
		{
			lock (_abilities)
			{
				_abilities.TryGetValue(abilityId, out var ability);
				return ability;
			}
		}

		/// <summary>
		/// Returns the ability with the given id, or null if it didn't
		/// exist.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <returns></returns>
		public Ability Get(string abilityClassName)
		{
			lock (_abilities)
				return _abilities.Values.FirstOrDefault(a => a.Data.ClassName == abilityClassName);
		}

		/// <summary>
		/// Returns the total modifier of the given type for the category
		/// based on all active abilities. May return 0 if there are no
		/// relevant modifiers.
		/// </summary>
		/// <remarks>
		/// Category and type refer to the category an ability relates to
		/// and the modifier types respectively. The type essentially
		/// declares which skill property is being modified, while the
		/// category will usually be the name of the skill the modifier
		/// applies to. However, due to changes in skill names, some
		/// categories may no longer exist in the form of actual skills,
		/// such as "Barbarian_HelmChopper".
		/// </remarks>
		/// <param name="category"></param>
		/// <param name="type"></param>
		/// <returns></returns>
		public int GetModifier(string category, AbilityModifierType type)
		{
			// TODO: Cache the modifier and invalidate cache on ability
			// changes.

			var result = 0;

			lock (_abilities)
			{
				foreach (var ability in _abilities.Values)
				{
					if (!ability.Active || !ability.Data.Categories.Contains(category))
						continue;

					if (ability.Data.Modifiers.TryGetValue(type, out var modifier))
						result += modifier;
				}
			}

			return result;
		}

		/// <summary>
		/// Adds the ability at the given level. If it already exists
		/// its level is updated.
		/// </summary>
		/// <param name="abilityId"></param>
		/// <param name="level"></param>
		public void Learn(AbilityId abilityId, int level)
		{
			lock (_abilities)
			{
				if (_abilities.TryGetValue(abilityId, out var ability))
					ability.Level = level;
				else
					_abilities[abilityId] = new Ability(abilityId, level);
			}

			Send.ZC_ABILITY_LIST(this.Character);
		}

		/// <summary>
		/// Toggles ability with the given class name on or off.
		/// Returns whether it was successfully toggled.
		/// </summary>
		/// <param name="className"></param>
		/// <returns></returns>
		public bool Toggle(string className)
		{
			var data = ZoneServer.Instance.Data.AbilityDb.Find(className);
			if (data == null || data.Passive)
				return false;

			var ability = this.Get(data.Id);
			if (ability == null)
				return false;

			ability.Active = !ability.Active;

			Send.ZC_OBJECT_PROPERTY(this.Character.Connection, ability);
			Send.ZC_ADDON_MSG(this.Character, AddonMessage.RESET_ABILITY_ACTIVE, 0, "Swordman28");

			return true;
		}
	}
}
