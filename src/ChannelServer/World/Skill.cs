using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.World;
using Melia.Shared.World.Shapes;
using System.Threading;
using Melia.Channel.Network;
using Melia.Shared.Util;
using Melia.Channel.World.SectorActors;
using Melia.Shared.Const;
using Melia.Channel.World.SkillHandlers;
using Melia.Channel.World.SkillEffects;

namespace Melia.Channel.World
{
	/// <summary>
	/// This class represents a skill for a given actor. 
	/// Even when sharing Id with other skills, to actos that have the same skill ID, will have different Skill class instances.
	/// </summary>
	public class Skill : Actor
	{
		/// <summary>
		/// 
		/// </summary>
		private static long _worldId = 0x0030000000000000;

		/// <summary>
		/// Skill ID
		/// </summary>
		public int Id;

		public long WorldId { get; private set; }

		/// <summary>
		/// Skill level
		/// </summary>
		public int level;

		/// <summary>
		/// Skill's owner entity
		/// </summary>
		public IEntity owner;

		/// <summary>
		/// List of effects for this skill (this should be moved to SkillData?)
		/// </summary>
		public List<SkillEffect> effects;

		/// <summary>
		/// Skill static data, retrieved from config files.
		/// </summary>
		public SkillData Data;

		DateTime preparationTimeStart;
		int charges;
		Timer preparationTimer;
		Timer castingTimer;

		/// <summary>
		/// Skill handler class
		/// </summary>
		public SkillHandler SkHandler { get; set; }

		/// <summary>
		/// Skill constructor class
		/// </summary
		/// <param name="skillId">The Skill ID provided by SkillData</param>
		/// <param name="level">The level of this skill</param>
		public Skill(int skillId, int level)
		{
			this.WorldId = Interlocked.Increment(ref _worldId);
			this.level = level;
			this.Id = skillId;
			this.LoadData();

			/// TODO
			// This should be moved to SkillData, and make sure every skill has a valid handler!
			SkillHandler skHandler;
			if (ChannelServer.Instance.SkillHandlers.TryGetValue(this.Id, out skHandler))
			{
				this.SkHandler = skHandler;
			} else
			{
				Log.Error("This skillID has no handler: {0}", this.Id);
			}

		}

		/// <summary>
		/// Set skill level
		/// </summary>
		/// <param name="newLevel">Level to set</param>
		public bool SetLevel(int newLevel)
		{
			this.level = newLevel;
			this.LoadData(); // Load new skill level Data.
			return true;
		}

		/// <summary>
		/// Loads skill data from data files.
		/// </summary>
		public void LoadData()
		{
			if (this.Id == 0)
				throw new InvalidOperationException("Skill id wasn't set before calling LoadData.");

			//this.Data = ChannelServer.Instance.Data.SkillDb.Find(this.Id);
			this.Data = ChannelServer.Instance.Data.SkillDb.FindSkill(this.Id, this.level);
			if (this.Data  == null)
				throw new NullReferenceException("No skill data found for '" + this.Id + "' level '" + this.level + "'.");
		}

		public SkillData GetData()
		{
			if (owner.IncreaseSkillLevel)
			{
				SkillData nextLevelData;
				int maxLevel = ChannelServer.Instance.Data.SkillTreeDb.GetSkillMaxLevel(this.Id);
				if (maxLevel > 0 && maxLevel > this.level)
				{
					nextLevelData = ChannelServer.Instance.Data.SkillDb.FindSkill(this.Id, (this.level + 1));
					if (nextLevelData != null)
						return nextLevelData;
				}
				
				
			}
			return Data;
		}

		/// <summary>
		/// This function is called when the skill is activated, so the actor requested to use it.
		/// It is in charge of making sure all conditions are met for that purpose, and call Cast() when appropiate.
		/// </summary>
		public void Activate(SkillDataComponent skillComp = null)
		{
			this.charges = 0;

			// Check if skill can be activated
			if (!CanActivate())
			{
				return;
			}

			// Set elegible locks to caster
			/// TODO
			/// 
			owner.SetAttackState(true);

			if (GetActivationTime() == 0)
			{
				ReadyToCast(skillComp);
			} 
			else
			{
				this.castingTimer = new Timer(ReadyToCast, skillComp, GetActivationTime(), Timeout.Infinite);

			}

			this.owner.ShootTime = new Timer(new TimerCallback(ShootTimeTask), null, this.GetData().ShootTime, Timeout.Infinite);

		}

		public void PrepareSkill()
		{
			preparationTimeStart = DateTime.Now;

			this.owner.PreparingSkillId = this.Data.Id;

			int chargesCount = this.GetData().Charges;
			if (chargesCount <= 0)
			{
				chargesCount = 1;
			}

			this.preparationTimer = new Timer(Prepared, null, (int)this.GetData().PreparationTime * 1000, 1000);

		}

		public void Prepared(Object obj)
		{
			if (this.charges < this.GetData().Charges) {
				this.charges++;
				Send.ZC_NORMAL_Unkown_3a(this.owner, "I_SYS_Text_Effect_None", "LV " + this.charges);
			}

			if (this.charges >= this.GetData().Charges)
			{
				this.preparationTimer.Change(Timeout.Infinite, Timeout.Infinite);
				this.preparationTimer.Dispose();
			}

			
		}

		public void PrepareSkillEnd()
		{
			if (this.preparationTimer != null)
			{
				this.preparationTimer.Change(Timeout.Infinite, Timeout.Infinite);
				this.preparationTimer.Dispose();
			}
		}

		public void ReadyToCast(Object obj)
		{
			if (this.castingTimer != null)
			{
				this.castingTimer.Change(Timeout.Infinite, Timeout.Infinite);
				this.castingTimer.Dispose();
			}

			Send.ZC_SKILL_READY(owner, this.Id, owner.Position, this.Position);

			if (owner is Character)
			{
				Character caster = (Character)owner;

				// Consume mana
				caster.SetCurrentSp(caster.Sp - (int)this.GetData().SpendSP);
			}

			PerformCast((SkillDataComponent)obj);
		}

		/// <summary>
		/// This function is in charge of checking if all conditions are met to activate the skill
		/// </summary>
		private bool CanActivate()
		{

			if (this.GetData().PreparationTime > 0)
			{			
				if (owner.PreparingSkillId != this.Id || this.preparationTimeStart.AddSeconds(this.GetData().PreparationTime) > DateTime.Now)
					return false;

				owner.PreparingSkillId = 0;
			}

			if (owner is Character)
			{
				Character caster = (Character)owner;
				// Check if caster has enough SP
				if (caster.Sp < (int)this.GetData().SpendSP)
				{
					Log.Debug("caster {0} has no enough sp to cast skill {1}, currentSp{3} neededSp{2}", caster.Handle, this.Data.Id, this.GetData().SpendSP, caster.Sp);
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Get activation time
		/// </summary>
		public int GetActivationTime()
		{
			/// TODO
			// Get skill activation time
			// Apply modifiers if any.
			return this.GetData().HitDelay;
			
		}

		/// <summary>
		/// Performs the skill cast. 
		/// At this point, we dont have to worry about sp/item consumitions or any other actor's requeriment. The skill is ready to be casted.
		/// </summary>
		private void PerformCast(SkillDataComponent skillComp = null)
		{
			var map = owner.Map;

			// Send event
			EventData evData = new EventData();
			evData.entity = this.owner;
			evData.skill = this;

			ChannelServer.Instance.World.SendEvent(WorldManager.EventTypes.PERFORM_CAST, evData, this.owner.Handle);

			// Process skill
			switch (this.Id)
			{
				case 40003:
					/*
					this.Data.EffectId = 2562067;
					this.Data.IsDot = true;
					this.Data.LifeInSeconds = 20;
					this.Data.MaxInteractions = 2;
					*/

					Dictionary<Stat, StatModifier> skillStatModifiers = new Dictionary<Stat, StatModifier>();
					StatModifier statMod;
					statMod.stat = Stat.Evasion;
					statMod.modifierType = StatModifierType.Addition;
					statMod.modifierValue = 30f;
					skillStatModifiers.Add(statMod.stat, statMod);
					
					statMod.stat = Stat.DR_BM;
					statMod.modifierType = StatModifierType.Addition;
					statMod.modifierValue = 1f;
					skillStatModifiers.Add(statMod.stat, statMod);
					this.GetData().statModifiers = skillStatModifiers;

					/*
					this.Data.buffId = 94;
					this.Data.buffIsPermanent = true;
					this.Data.buffLifeInSeconds = 0;
					this.Data.buffCanStack = false;
					*/

					/*
					this.effects = new List<SkillEffect>();
					this.effects.Add(new EffectSafetyZone(new SkillDataComponent()));
					*/
					break;
				case 40004:
					/*
					this.Data.EffectId = 190323;
					this.Data.IsDot = true;
					*/
					/*
					this.Data.buffId = 142;
					this.Data.buffIsPermanent = true;
					this.Data.buffLifeInSeconds = 0;
					this.Data.buffCanStack = true;
					*/
					/*
					this.Data.LifeInSeconds = 6;
					*/
					Dictionary<Stat, StatModifier> skillStatModifiers2 = new Dictionary<Stat, StatModifier>();
					StatModifier statMod2;
					statMod2.stat = Stat.PDEF;
					statMod2.modifierType = StatModifierType.Addition;
					statMod2.modifierValue = -2f;
					skillStatModifiers2.Add(statMod2.stat, statMod2);

					statMod2.stat = Stat.MDEF;
					statMod2.modifierType = StatModifierType.Addition;
					statMod2.modifierValue = -2f;
					skillStatModifiers2.Add(statMod2.stat, statMod2);
					this.GetData().statModifiers = skillStatModifiers2;

					/*
					this.effects = new List<SkillEffect>();
					this.effects.Add(new EffectSafetyZone(new SkillDataComponent()));
					*/
					break;

				case 40007:
					this.GetData().EffectId = 190323;
					this.GetData().IsDot = false;
					/*
					this.Data.buffId = 142;
					this.Data.buffIsPermanent = false;
					this.Data.buffLifeInSeconds = 60;
					this.Data.buffCanStack = false;
					*/
					this.GetData().LifeInSeconds = 10;
					this.GetData().EffectsDependOnSkill = false;

					Dictionary<Stat, StatModifier> skillStatModifiers3 = new Dictionary<Stat, StatModifier>();
					StatModifier statMod3;
					statMod3.stat = Stat.PDEF;
					statMod3.modifierType = StatModifierType.Addition;
					statMod3.modifierValue = -2f;
					skillStatModifiers3.Add(statMod3.stat, statMod3);
					this.GetData().statModifiers = skillStatModifiers3;

					/*
					this.effects = new List<SkillEffect>();
					this.effects.Add(new GuardianSaint(new SkillDataComponent()));
					*/
					break;
				case 100:
					this.GetData().IsDot = false;
					this.GetData().IsInstant = true;
					break;
				case 40005:
					break;
				case 20001:
				case 4:
					this.Data.Type = SkillType.ACTOR;
					break;
				case 50045:
					this.Data.Type = SkillType.GROUND;
					break;
				default:
					break;
			}

			// Depends of the skillType, the skill is casted in different ways, and different things are prepared.
			Log.Debug("Cast type: {0}", this.GetData().Type);
			switch (this.GetData().Type)
			{
				// GROUND SKILL
				case SkillType.GROUND:
					{
						// Create ground skill actor
						GroundSkill PESkill = new GroundSkill();

						// Calculate its position and direction
						Position skillPosition;
						if (this.GetData().TargetType == TargetType.SELF)
						{
							skillPosition = new Position(owner.Direction.Cos + owner.Position.X, owner.Position.Y, owner.Direction.Sin + owner.Position.Z);
						} else
						{
							//skillPosition = new Position(40 * owner.Direction.Cos + owner.Position.X, owner.Position.Y, 40 * owner.Direction.Sin + owner.Position.Z);
							skillPosition = new Position(200 * owner.Direction.Cos + owner.Position.X, owner.Position.Y, 200 * owner.Direction.Sin + owner.Position.Z);
						}
						
						var skillDirection = new Direction(owner.Direction.Cos, owner.Direction.Sin);

						// Initialize other specific variables
						if (this.GetData().MaxInteractions > 0)
						{
							PESkill.maxInteractions = this.GetData().MaxInteractions;
						}

						// Initialize ground skill
						PESkill.Init(map, this, owner, skillPosition, skillDirection);
						
						// Place skill actor in map
						PESkill.Enable();

						// Notify client
						Send.ZC_NORMAL_Unkown_1c(owner, 0, owner.Position, owner.Direction, this.Position);
						Send.ZC_SKILL_MELEE_GROUND(owner, this.Id, this.Position, this.Direction); // This packet should be sent from inside SkillGround?
						break;
					}
				case SkillType.ACTOR:
					{
						// Calculate direction to target
						if (skillComp.target != null)
						{
							this.Direction = new Direction(Math2.AngleBetweenTwoEntity(owner.Position, skillComp.target.Position));
						}


						Send.ZC_NORMAL_Unkown_1c(owner, 0, owner.Position, this.Direction, this.Position);

						if (skillComp.target == null)
						{
							Send.ZC_NORMAL_Unkown_3f(owner, this, this.Direction);
							return;
						}
							

						// Check if target is in reach.
						Actor targetActor = null;
						if (skillComp.target is Actor)
						{
							targetActor = (Actor)skillComp.target;
						}
						var sResult = this.SkHandler.ProcessSkill(targetActor, this, null);

						if (sResult != null)
							Send.ZC_SKILL_FORCE_TARGET(this.owner, this, sResult);

						break;
					}
				default:
					/// ERROR
					break;
			}

		}

		public void ShootTimeTask(Object obj)
		{
			this.owner.ShootTime.Dispose();
			this.owner.ShootTime = null;
		}

		/// <summary>
		/// This function process the skill in a given actor.
		/// </summary>
		/// <param name="target">The target actor where this skill will be applied</param>
		/// <param name="originator">The actor originating this skill. Not necessarely the caster!</param>
		public SkillResult ProcessSkill(Actor target, Actor originator)
		{

			if (this.SkHandler != null)
			{
				return this.SkHandler.ProcessSkill(target, this, originator);
			}
			return null;
		}

	}

	/// <summary>
	/// SkillResult is a container class, that holds skill result values when applied a skill to an actor, for future processing.
	/// </summary>
	public class SkillResult
	{
		public IEntity actor;
		public int skillHandle;
		public int targetHandle;
		public float value;
		public int type;
	}
}
