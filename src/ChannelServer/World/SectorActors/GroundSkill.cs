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
	public class GroundSkill : Actor, IVisitor
	{
		public float range;
		public int SkillId;
		public bool fired;
		public int delayRemove = 200;
		public DateTime timeFired;
		public int ownerHandle;
		public Map Map { get; set; }
		public Skill ownerSkill;

		public DateTime timeEndLife;
		public DateTime nextProcessTime;
		public int countTargets;
		public int maxCounterTargets;
		public DateTime preDelay;
		public double processTickInterval;
		public List<SkillResult> skillResults;
		public List<Actor> processTargets;
		public List<Actor> lastProcessTargets;

		public void Init()
		{
			this.range = 0.0f;
			this.Handle = ChannelServer.Instance.World.CreateHandle();
		}

		public void Init(Map map, Skill oSkill, int oHandle, Position pos, Direction dir)
		{
			this.range = 0.0f;
			this.Handle = ChannelServer.Instance.World.CreateHandle();

			Map = map;
			ownerSkill = oSkill;
			ownerHandle = oHandle;
			this.Position = pos;
			this.Direction = dir;

			this.maxCounterTargets = 10; /// TODO
			

			skillResults = new List<SkillResult>();
			processTargets = new List<Actor>();
			lastProcessTargets = new List<Actor>();
		}

		public void Enable()
		{
			this.timeEndLife = DateTime.Now.AddSeconds(ownerSkill.Data.LifeInSeconds);
			this.preDelay = DateTime.Now;
			this.nextProcessTime = DateTime.Now;


			this.processTickInterval = 1000; // Buff ticks

			this.CollisionShape = GetSkillShape();

			// Set Skill Actor into Map.
			Map.AddSkill(this);
			// Broadcast effect.
			Character caster = Map.GetCharacter(ownerHandle);
			Send.ZC_NORMAL_Skill(caster, ownerSkill, this.Position, new Direction(0.707f, 0.707f), true, this.Handle);
		}

		public void Disable()
		{
			Send.ZC_NORMAL_Skill(Map.GetCharacter(ownerHandle), ownerSkill, this.Position, new Melia.Shared.World.Direction(0.707f, 0.707f), false, this.Handle);

			// Remove skill from all current affected entities
			lock (this.lastProcessTargets)
			{
				foreach (var actor in this.lastProcessTargets)
				{
					this.OnLeave(actor);
				}
			}

			this.ToDestroy = true;
		}

		public Shape GetSkillShape()
		{
			Shape skillShape;
			switch (ownerSkill.Data.SplashType)
			{
				case SplashType.Square:
					skillShape = new Circle(10.0f);
					//skillShape = new Square(this.Data.SplashHeight, this.Data.SplashHeight);
					break;
				case SplashType.Circle:
					skillShape = new Circle(10.0f);
					break;
				case SplashType.Fan:
					skillShape = new Cone(ownerSkill.Data.SplashAngle, ownerSkill.Data.SplashRange);
					break;
				default:
					skillShape = new Circle(ownerSkill.Data.SplashRange);
					break;
			}

			return skillShape;
		}

		public bool OnVisit(Actor actor)
		{
			// check if attackable (Target mask!)
			/*
			if (entity.GetType() != typeof(Character))
				return true;
			*/

			this.countTargets++;


			int actorIndex = this.lastProcessTargets.IndexOf(actor);
			if (actorIndex == -1)
			{
				this.processTargets.Add(actor);
				this.OnEnter(actor);
			}
			else
			{
				this.processTargets.Add(actor);
				this.lastProcessTargets.RemoveAt(actorIndex);
			}

			if (countTargets >= maxCounterTargets)
				return false;



			

			/*
			Character thisCharacter = Map.GetCharacter(ownerHandle);
			thisCharacter.ProcessSkill(this, entity);
			*/



			return true;
		}

		public void OnEnter(Actor actor)
		{
			Log.Debug("OnEnter {0}", actor.ToString());
			var sResult = this.ownerSkill.ProcessSkill(actor);
			if (sResult != null)
				skillResults.Add(sResult);
		}

		public void OnLeave(Actor actor)
		{
			Log.Debug("OnLeave {0}", actor.ToString());
			if (actor is IEntity)
			{
				IEntity entityActor = (IEntity)actor;
				entityActor.StopSkillEffects(this.ownerSkill);
			}

		}

		public bool IntersectWith(Actor actor)
		{
			//Log.Debug("IntersectWith {0}. MyShape {1} OtherShape {2}", actor, this.CollisionShape.ToString(), actor.CollisionShape.ToString());
			return this.CollisionShape.IntersectWith(actor.CollisionShape);
		}

		public void Process()
		{


			if (this.timeEndLife < DateTime.Now)
			{
				this.Disable();
			}
			if (fired && !ownerSkill.Data.IsDot)
			{
				if ((timeFired.AddMilliseconds((double)delayRemove) < DateTime.Now))
				{
					this.Disable();
				}
				return;
			}

			// Predelay

			if (this.preDelay > DateTime.Now)
				return;

			// Check if its time to process this actor
			if (this.nextProcessTime > DateTime.Now)
				return;

			this.nextProcessTime = DateTime.Now.AddMilliseconds(this.processTickInterval);

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

			this.processTargets = new List<Actor>();
			this.skillResults = new List<SkillResult>();
			this.countTargets = 0;
			Map.SectorManager.Visit(this.Position, this, this.ownerSkill.Data.SplashRange);

			// At this time "lastProcessTargets" contains those actors that leaved 
			foreach (var actor in this.lastProcessTargets)
			{
				this.OnLeave(actor);
			}

			this.lastProcessTargets = processTargets;

			// If targets in this visit
			if (this.countTargets > 0)
			{
				// Send packet about attack result!
				Character caster = Map.GetCharacter(ownerHandle);
				Send.ZC_SKILL_HIT_INFO(caster, this.skillResults);
				// Skill processed particle effect
				if (!fired)
					Send.ZC_NORMAL_ParticleEffect(Map.GetCharacter(ownerHandle), this.Handle, 1);
			}
			else if (!this.ownerSkill.Data.IsInstant)
				return;

			// Set skill as fired
			fired = true;
			timeFired = DateTime.Now;

		}
	}
}
