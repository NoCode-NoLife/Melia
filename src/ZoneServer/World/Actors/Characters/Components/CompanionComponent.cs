using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Monsters;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// Manages all companion-related data and behavior for a <see cref="Character"/>.
	/// 
	/// This includes maintaining the in-memory list of companions, 
	/// providing lookup and query utilities, and ensuring proper 
	/// synchronization between the game world, network clients, 
	/// and the persistent database.
	/// </summary>
	public class CompanionComponent : CharacterComponent
	{
		private readonly List<Companion> _companions = new();

		/// <summary>
		/// Initializes a new instance of the <see cref="CompanionComponent"/> class
		/// for the specified character.
		/// </summary>
		/// <param name="character">The character that owns this companion component.</param>
		public CompanionComponent(Character character) : base(character)
		{
		}

		/// <summary>
		/// Returns true if this character currently has any companions.
		/// </summary>
		public bool HasCompanions
		{
			get
			{
				lock (_companions)
					return _companions.Count > 0;
			}
		}

		/// <summary>
		/// Gets the currently active companion, or <c>null</c> if no companion is active.
		/// </summary>
		public Companion ActiveCompanion
		{
			get
			{
				lock (_companions)
					return _companions.Find(companion => companion.IsActivated);
			}
		}

		/// <summary>
		/// Adds a companion to the character's companion list.
		/// Optionally sends an update packet to the client.
		/// </summary>
		/// <param name="companion">The companion to add.</param>
		/// <param name="silently">
		/// If <c>true</c>, suppresses sending companion info updates to the client.
		/// </param>
		public void AddCompanion(Companion companion, bool silently = false)
		{
			lock (_companions)
				_companions.Add(companion);

			if (!silently)
				Send.ZC_NORMAL.PetInfo(this.Character);
		}

		/// <summary>
		/// Creates a new companion entry in the database and adds it to the character.
		/// </summary>
		/// <param name="companion">The companion to create and register.</param>
		public void CreateCompanion(Companion companion)
		{
			ZoneServer.Instance.Database.CreateCompanion(this.Character.AccountId, this.Character.DbId, companion);
			this.AddCompanion(companion);
		}

		/// <summary>
		/// Retrieves a copy of all companions owned by this character.
		/// </summary>
		/// <returns>A new list containing all companions.</returns>
		public IList<Companion> GetList()
		{
			lock (_companions)
				return _companions.ToList();
		}

		/// <summary>
		/// Retrieves a filtered copy of all companions matching a given condition.
		/// </summary>
		/// <param name="predicate">A filtering function used to select companions.</param>
		/// <returns>
		/// A new list of companions that satisfy the specified <paramref name="predicate"/>.
		/// </returns>
		public IList<Companion> GetList(Func<Companion, bool> predicate)
		{
			lock (_companions)
				return _companions.Where(predicate).ToList();
		}

		/// <summary>
		/// Returns a companion by its unique object ID, or <c>null</c> if not found.
		/// </summary>
		/// <param name="companionId">The unique ID of the companion to find.</param>
		/// <returns>The matching <see cref="Companion"/> or <c>null</c>.</returns>
		public Companion GetCompanion(long companionId)
		{
			lock (_companions)
				return _companions.Find(c => c.ObjectId == companionId);
		}

		/// <summary>
		/// Attempts to find a companion matching the specified predicate.
		/// </summary>
		/// <param name="predicate">A function to test each companion against.</param>
		/// <param name="companion">
		/// When this method returns, contains the found companion if one matched; otherwise <c>null</c>.
		/// </param>
		/// <returns><c>true</c> if a matching companion was found; otherwise, <c>false</c>.</returns>
		public bool TryGetCompanion(Predicate<Companion> predicate, out Companion companion)
		{
			lock (_companions)
				companion = _companions.Find(predicate);

			return companion != null;
		}
	}
}
