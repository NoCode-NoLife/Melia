using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Util;
using Melia.Channel.Network;
using Melia.Shared.World;
using Melia.Shared.World.Shapes;
using Melia.Shared.Data.Database;

namespace Melia.Channel.World.SectorActors
{
	/// <summary>
	/// GroundSkill class is a Sector actor (placeable in a sector) representing a ground skill.
	/// It acts like a trigger, that executes a skill when visited by other actors.
	/// </summary>
	public class GroundSkill : Actor, IVisitor
	{
		/// <summary>
		/// Internal variable that controls the next tick time
		/// </summary>
		private DateTime _nextProcessTime;

		/// <summary>
		/// It contains the amoung of targets affected by this GroundSkill at a given moment.
		/// </summary>
		private int _countTargets;

		/// <summary>
		/// Max amount of targets that this GroundSkill can affect at the same time.
		/// </summary>
		private int _maxCounterTargets = 10;

		/// <summary>
		/// It indicates the interval of miliseconds between ticks for this GroundSkill
		/// </summary>
		private double _processTickInterval;

		/// <summary>
		/// A list of targets processed foreach visit to this GroundSkill
		/// </summary>
		private List<Actor> _processTargets;

		/// <summary>
		/// A list of targets processed in the previous visit to this GroundSkill
		/// </summary>
		private List<Actor> _lastProcessTargets;

		/// <summary>
		/// Flag determining if this GroundSkill was at least fired once.
		/// </summary>
		public bool fired;

		/// <summary>
		/// Datetime indicating when this GroundSkill was fired the first time.
		/// </summary>
		public DateTime timeFired;

		/// <summary>
		/// Miliseconds that delays the removal of this GroundSkill after fired.
		/// Only for NO-DoT skills
		/// </summary>
		public int delayRemove = 200;

		/// <summary>
		/// Handle of the owner of this GroundSkill
		/// NOTE: Currently is assuming Character Handle!!
		/// </summary>
		public IEntity owner;

		/// <summary>
		/// The map where this GroundSkill is placed
		/// </summary>
		public Map Map { get; set; }

		/// <summary>
		/// The skill associated to this GroundSkill
		/// </summary>
		public Skill ownerSkill;

		/// <summary>
		/// DateTime indicating when this GroundSkill will end.
		/// </summary>
		public DateTime timeEndLife;

		/// <summary>
		/// preDelay controls the delay before this GroundSkill is active.
		/// </summary>
		public DateTime preDelay;

		/// <summary>
		/// The results of skills applied to targets
		/// </summary>
		public List<SkillResult> skillResults;

		/// <summary>
		/// Generic counter used from Skill Effects, to keep records in GroundSkill actor, about interactions of effects.
		/// </summary>
		public int interactions;

		/// <summary>
		/// Generic counter Max value.
		/// </summary>
		public int maxInteractions;

		/// <summary>
		/// Basic Initialization
		/// </summary>
		public void Init()
		{
			// Create Handle ID for this actor
			this.Handle = ChannelServer.Instance.World.CreateHandle();
		}

		/// <summary>
		/// Initialization
		/// </summary>
		/// <param name="map">Map for this GroundSkill</param>
		/// <param name="oSkill">Skill for this GroundSkill</param>
		/// <param name="oHandle">Owner Handle</param>
		/// <param name="pos">Position</param>
		/// <param name="dir">Direction</param>
		public void Init(Map map, Skill oSkill, IEntity owner, Position pos, Direction dir)
		{
			// Create Handle ID for this actor
			this.Handle = ChannelServer.Instance.World.CreateHandle();

			// Initialize variables
			skillResults = new List<SkillResult>();
			_processTargets = new List<Actor>();
			_lastProcessTargets = new List<Actor>();

			Map = map;
			ownerSkill = oSkill;
			this.owner = owner;

			// Set Pos/Dir of this Placeable Actor.
			this.Position = pos;
			this.Direction = dir;

			// Set amount of targets that can interact with this GroundSkill at the same time.
			_maxCounterTargets = 10; /// TODO

			// Initialize interactions counter
			this.interactions = 0;
			this.maxInteractions = oSkill.GetData().MaxInteractions;


		}

		/// <summary>
		/// This function enables the GroundSkill .
		/// From this moment, the GroundSkill will be placed in the map and notify clients about it.
		/// </summary>
		public void Enable()
		{
			// Initialize DateTime variables
			this.timeEndLife = DateTime.Now.AddSeconds(ownerSkill.GetData().LifeInSeconds);
			this.preDelay = DateTime.Now;
			_nextProcessTime = DateTime.Now;

			// Set tick interval
			_processTickInterval = 1000; /// TODO

			// Set collisionShape
			this.CollisionShape = GetSkillShape();

			// Set Skill Actor into Map.
			Map.AddSkill(this);

			// Broadcast effect.
			Log.Debug("skill {0} level {1}", ownerSkill.Id, ownerSkill.level);
			if (ownerSkill.GetData().EffectId > 0) 
				Send.ZC_NORMAL_Skill(owner, ownerSkill, this.Position, new Direction(0.707f, 0.707f), true, this.Handle);
		}

		/// <summary>
		/// This function disables the GroundSkill.
		/// Set the actor to destroy, remove the skill effects in all actors affected by this GroundSkill, and notify the clients.
		/// </summary>
		public void Disable()
		{
			Send.ZC_NORMAL_Skill(owner, ownerSkill, this.Position, new Melia.Shared.World.Direction(0.707f, 0.707f), false, this.Handle);

			// If this skill is controlling all affected targets, remove skill from all current affected entities
			if (this.ownerSkill.GetData().EffectsDependOnSkill)
			{
				lock (_lastProcessTargets)
				{
					foreach (var actor in _lastProcessTargets)
					{
						this.OnLeave(actor);
					}
				}
			}

			this.ToDestroy = true;
		}

		/// <summary>
		/// This function creates the ShapeType of this GroundSkill.
		/// </summary
		public Shape GetSkillShape()
		{
			Shape skillShape;
			switch (ownerSkill.GetData().SplashType)
			{
				case SplashType.Square:
					skillShape = new Circle(10.0f);
					//skillShape = new Square(this.Data.SplashHeight, this.Data.SplashHeight);
					break;
				case SplashType.Circle:
					skillShape = new Circle(10.0f);
					break;
				case SplashType.Fan:
					skillShape = new Cone(ownerSkill.GetData().SplashAngle, ownerSkill.GetData().SplashRange);
					break;
				default:
					skillShape = new Circle(ownerSkill.GetData().SplashRange);
					break;
			}

			return skillShape;
		}

		/// <summary>
		/// This function is called from a sector (see SectorManager) when a IVisitor could be interacting with Actor.
		/// Actual interaction should be confirmed inside OnVisit.
		/// </summary>
		public bool OnVisit(Actor actor)
		{
			// check if attackable (Target mask!)
			if (actor is IEntity)
			{
				if ((this.ownerSkill.GetData().TargetType & this.ownerSkill.owner.GetTargetType((IEntity)actor)) == Shared.Const.TargetType.NONE)
				{
					return true;
				}
			} else
			{
				return true;
			}

			// At this point, the target is a valid target

			// Increment the amount of affected targets
			_countTargets++;

			// Check if this visitor was already colliding with this GroundSkill in the last tick.
			int actorIndex = _lastProcessTargets.IndexOf(actor);
			if (actorIndex == -1)
			{
				// Visitor is a new target, add it to the list of current targets, and execute OnEnter()
				_processTargets.Add(actor);
				this.OnEnter(actor);
			}
			else
			{
				// Visitor is an old target, add it to the list of current targets anyway, but remove from previous list.
				_processTargets.Add(actor);
				_lastProcessTargets.RemoveAt(actorIndex);
			}

			// Avoid processing more visitors than allowed by this GroundSkill
			if (_countTargets >= _maxCounterTargets)
				return false;

			return true;
		}

		/// <summary>
		/// This function is called everytime a new visitor collides with this GroundSkill
		/// </summary>
		public void OnEnter(Actor actor)
		{
			// Process skill in target
			var sResult = this.ownerSkill.ProcessSkill(actor, this);
			// Add result to list for later processing
			if (sResult != null)
			{
				skillResults.Add(sResult);
			}
		}

		/// <summary>
		/// This function is called everytime a visitor get out of the range of GroundSkill
		/// </summary>
		public void OnLeave(Actor actor)
		{
			// Remove all skill effects from target
			if (actor is IEntity)
			{
				IEntity entityActor = (IEntity)actor;
				entityActor.StopSkillEffects(this.ownerSkill);
			}

		}

		/// <summary>
		/// This function is called from a sector (see SectorManager) to check if this visitor is interacting with an actor.
		/// </summary>
		public bool IntersectWith(Actor actor)
		{
			return this.CollisionShape.IntersectWith(actor.CollisionShape);
		}

		/// <summary>
		/// This function is called in every Map's tick. It controls all GroundSkill's behavior.
		/// </summary>
		public void Process()
		{
			// Disables the GroundSkill if reached his LifeTime.
			if (this.timeEndLife < DateTime.Now)
			{
				this.Disable();
			}

			// If the skill was already fired, and is a one-time skill, disable it.
			if (fired && !ownerSkill.GetData().IsDot)
			{
				// Disable it after a given delay. This usually gives time to effect to happen in client.
				if ((timeFired.AddMilliseconds((double)delayRemove) < DateTime.Now))
				{
					this.Disable();
				}
				return;
			}

			// Predelay
			if (this.preDelay > DateTime.Now)
				return;

			// Check if its time to process this GroundSkill
			if (_nextProcessTime > DateTime.Now)
				return;

			// Set next process time
			_nextProcessTime = DateTime.Now.AddMilliseconds(_processTickInterval);

			// Check if owner is dead
			/// TODO
			///
			/*
			if (ownerDead)
			{
				this.ToDestroy = true;
				return;
			}
			*/

			// Initialize these in every process' loop
			_processTargets = new List<Actor>();
			this.skillResults = new List<SkillResult>();
			_countTargets = 0;

			// Make a visit to all entities in the skill range looking for new targets
			Map.SectorManager.Visit(this.Position, this, this.ownerSkill.GetData().SplashRange);

			// At this time "lastProcessTargets" contains those actors that leaved 
			foreach (var actor in _lastProcessTargets)
			{
				// Call leave in every actor that leaved the area.
				this.OnLeave(actor);
			}

			// Set 
			_lastProcessTargets = _processTargets;

			// If targets in this visit
			if (_countTargets > 0)
			{
				// Send packet about attack result!
				Send.ZC_SKILL_HIT_INFO(owner, this.skillResults);
				// Skill processed particle effect
				if (!fired)
					Send.ZC_NORMAL_ParticleEffect(owner, this.Handle, 1);
			}
			// Prevent this GroundSkill to be marked as fired, if its not an one-time skill
			else if (!this.ownerSkill.GetData().IsInstant)
				return;

			// Set skill as fired
			fired = true;
			timeFired = DateTime.Now;

		}
	}
}
