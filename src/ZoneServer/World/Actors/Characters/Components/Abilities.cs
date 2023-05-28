using System.Collections.Generic;
using System.Linq;
using Melia.Shared.Tos.Const;
using Melia.Zone.Network;
using Melia.Zone.Skills;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// A character's abilities.
	/// </summary>
	public class Abilities : CharacterComponent
	{
		private readonly Dictionary<AbilityId, Ability> _abilities = new Dictionary<AbilityId, Ability>();

		/// <summary>
		/// Returns amount of abilities.
		/// </summary>
		public int Count { get { lock (_abilities) return _abilities.Count; } }

		/// <summary>
		/// Creates a new instance for character.
		/// </summary>
		/// <param name="character"></param>
		public Abilities(Character character) : base(character)
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
			Send.ZC_ADDON_MSG(this.Character, AddonMessage.RESET_ABILITY_ACTIVE, "Swordman28");

			return true;
		}
	}
}
