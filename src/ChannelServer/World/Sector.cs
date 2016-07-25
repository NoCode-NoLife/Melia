using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Melia.Shared.World;
using Melia.Shared.Util;

namespace Melia.Channel.World
{
	public class Sector
	{
		/// <summary>
		/// List of entities for this sector
		/// </summary>
		private List<Actor> _entities;

		/// <summary>
		/// List of characters for this sector
		/// </summary>
		private List<Character> _characters;

		/// <summary>
		/// neighbor sectors
		/// </summary>
		private Sector[] _neighbors;

		/// <summary>
		/// Index of this sector in the sectorManager
		/// </summary>
		public int index { get; set; }

		/// <summary>
		/// Active flag, indicating if this sector is active (or sleeping)
		/// </summary>
		private bool _active;

		/// <summary>
		/// Active flag, indicating if this sector is active (or sleeping)
		/// </summary>
		private Timer _neighborsTask;

		/// <summary>
		/// Config flag, indicating seconds of delay to activate neighbors after this sector gets activated
		/// </summary>
		public const int NEIGHBORS_ACTIVATE_DELAY_TIME = 5;

		/// <summary>
		/// Initialize a sector
		/// </summary>
		public Sector()
		{
			_entities = new List<Actor>();
			_characters = new List<Character>();
			_neighbors = new Sector[8];

			_active = false;
		}

		/// <summary>
		/// Add an actor to this sector
		/// </summary>
		public bool Add(Actor entity)
		{
			lock (_entities)
				_entities.Add(entity);

			if (entity is Character)
			{
				lock (_characters)
				{
					_characters.Add((Character)entity);

					if (_characters.Count == 1)
					{
						// Activate sector
						this.StartActivation();
					}
				}
			}
			return true;
		}

		/// <summary>
		/// Removes an actor from this sector
		/// </summary>
		public bool Remove(Actor entity)
		{
			lock (_entities)
				_entities.Remove(entity);

			if (entity is Character)
			{
				lock (_characters)
				{
					_characters.Remove((Character)entity);

					if (_characters.Count == 0)
					{
						// Activate sector
						this.StartDeactivation();
					}
				}
			}
			return true;
		}

		/// <summary>
		/// Link a sector to another sector, given a direction 
		/// </summary>
		public void LinkSector(SectorDirection direction, Sector sector)
		{
			if (sector == null)
				return;

			this._neighbors[(int)direction] = sector;
		}

		/// <summary>
		/// Performs a visit for a given visitor and range, to all reachable entities in this sector.
		/// </summary>
		private void VisitInternal(Position pos, IVisitor visitor, float range)
		{
			// Tell all entities about this visit
			lock (_entities)
			{
				foreach (var entity in _entities)
				{
					if (visitor == (IVisitor)entity)
						continue;

					if (entity == null)
						continue;

					if (visitor.IntersectWith(entity) == false)
						continue;

					if (visitor.OnVisit(entity) == false)
						return;
				}
			}
		}

		/// <summary>
		/// Visits a given point+range in this sector and all neighbor sectors
		/// </summary>
		public void Visit(Position pos, IVisitor visitor, float range)
		{
			// Visit this sector
			VisitInternal(pos, visitor, range);
			// Visit all neighbors
			for (int i = 0; i < 8; i++)
			{
				if (this._neighbors[i] == null)
					continue;

				this._neighbors[i].VisitInternal(pos, visitor, range);
			}
		}

		public List<Actor> GetActorsAtRange(Position pos, float range)
		{
			// Visit this sector
			var actorsAtRange = GetActorsAtRangeInternal(pos, range);
			// Visit all neighbors
			for (int i = 0; i < 8; i++)
			{
				if (this._neighbors[i] == null)
					continue;

				actorsAtRange.AddRange(this._neighbors[i].GetActorsAtRangeInternal(pos, range));
			}

			return actorsAtRange;
		}

		private List<Actor> GetActorsAtRangeInternal(Position pos, float range)
		{
			List<Actor> actorsAtRange = new List<Actor>();
			lock (_entities)
			{
				foreach (var entity in _entities)
				{
					if (entity == null)
						continue;

					if (entity.Position.Get2DDistance(pos) - entity.Radius < range)
					{
						actorsAtRange.Add(entity);
					}
				}
			}
			return actorsAtRange;
		}

		public bool IsActive()
		{
			return _active;
		}

		public bool AreNeighborsActive()
		{
			// Check if this sector is active
			if (_active && _characters.Count > 0)
				return true;

			// Check if neighbors are active
			// Visit all neighbors
			for (int i = 0; i < 8; i++)
			{
				if (this._neighbors[i] == null)
					continue;

				if (this._neighbors[i]._active && this._neighbors[i]._characters.Count > 0)
					return true;
			}

			return false;
		}

		public void SetActive(bool newActiveValue)
		{
			if (_active == newActiveValue)
				return;

			_active = newActiveValue;

			switchAI(newActiveValue);

			/*
			if (_active)
				Log.Debug("Sector {0} ACTIVATED", this.index);
			else
				Log.Debug("Sector {0} DEACTIVATED", this.index);
			*/
		}

		public void switchAI(bool turnOn)
		{
			int count = 0;

			if (turnOn)
			{
				// Enable all AI in this sector
				lock (_entities)
				{
					foreach (var entity in _entities)
					{
						if (entity is Monster) {
							count++;
							Monster entityMonster = (Monster)entity;

							// Activate monster
							if (entityMonster.AI != null)
								((Monster)entity).AI.SetIntention(AI.IntentionTypes.AI_INTENTION_ACTIVE);
						}
					}
				}
			} else
			{
				// Disable all AI in this sector
				lock (_entities)
				{
					foreach (var entity in _entities)
					{
						if (entity is Monster)
						{
							Monster entityMonster = (Monster)entity;
							count++;
							// Activate monster

							// Stop movement
							entityMonster.MoveStop();

							// Remove all skill effects
							entityMonster.skillEffectsManager.RemoveAllEffects();

							// clear aggro list
							entityMonster.ClearAggroList();

							if (entityMonster.AI != null)
							{
								entityMonster.AI.SetIntention(AI.IntentionTypes.AI_INTENTION_IDLE);
							}

						}
					}
				}
			}

			//Log.Debug("Sector {0}, Monster affected {1}", this.index, count);
		}

		private void StartActivation()
		{
			SetActive(true);

			if (_neighborsTask != null)
			{
				_neighborsTask.Dispose();
			}

			Object obj = new Object();
			_neighborsTask = TasksPoolManager.Instance.AddGeneralTask(ProcessNeighborsActivation, obj, 1000 * NEIGHBORS_ACTIVATE_DELAY_TIME);
		}

		private void StartDeactivation()
		{
			if (_neighborsTask != null)
			{
				_neighborsTask.Dispose();
			}

			_neighborsTask = TasksPoolManager.Instance.AddGeneralTask(ProcessNeighborsActivation, null, 1000 * NEIGHBORS_ACTIVATE_DELAY_TIME);
		}

		public void ProcessNeighborsActivation(Object obj)
		{
			bool isActivating = (obj != null);

			if (isActivating)
			{
				// Visit all neighbors
				for (int i = 0; i < 8; i++)
				{
					if (this._neighbors[i] == null)
						continue;

					this._neighbors[i].SetActive(true);
				}
			} else
			{
				if (!this.AreNeighborsActive())
					this.SetActive(false);

				// Visit all neighbors
				for (int i = 0; i < 8; i++)
				{
					if (this._neighbors[i] == null)
						continue;

					if (!this._neighbors[i].AreNeighborsActive())
						this._neighbors[i].SetActive(false);
				}
			}


			
		}


	}

	/// <summary>
	/// Sector directions
	/// </summary>
	public enum SectorDirection : int
	{
		SECTOR_N = 0,
		SECTOR_NE = 1,
		SECTOR_E = 2,
		SECTOR_SE = 3,
		SECTOR_S = 4,
		SECTOR_SW = 5,
		SECTOR_W = 6,
		SECTOR_NW = 7
	}
}
