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
		public long _worldId;

		/// <summary>
		/// Skill ID
		/// </summary>
		public int Id;

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
			this._worldId = Interlocked.Increment(ref _worldId) + 0x30000000000000;
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
		public void Activate()
		{
			Character caster = (Character)owner;
			// Check if skill can be activated
			if (!CanActivate())
			{
				return;
			}

			// Set elegible locks to caster
			/// TODO
			/// 
			caster.SetAttackState(true);

			if (GetActivationTime() == 0.0f)
			{
				Cast();
			} 
			else
			{
				// Fire Cast() after "ActivationTime"
				// We need a task system, so we can create a task to execute it when time is reached.
				/// TODO
			}

		}

		/// <summary>
		/// This function is in charge of checking if all conditions are met to activate the skill
		/// </summary>
		private bool CanActivate()
		{
			Character caster = (Character)owner;

			// Check if caster has enough SP
			if (caster.Sp < (int)this.GetData().SpendSP)
				return false;

			return true;
		}

		/// <summary>
		/// Get activation time
		/// </summary>
		public float GetActivationTime()
		{
			/// TODO
			// Get skill activation time
			// Apply modifiers if any.
			return 0.0f; // skill.Data. ??
			
		}

		/// <summary>
		/// This functions starts the skill Casting. But the actual cast will happen in PerformCast() (needed?)
		/// </summary>
		private void Cast()
		{
			Send.ZC_SKILL_READY((Character)owner, this.Id, owner.Position, this.Position);

			Character caster = (Character)owner;

			// Consume mana
			caster.SetCurrentSp((int)this.GetData().SpendSP);

			PerformCast();
		}

		/// <summary>
		/// Performs the skill cast. 
		/// At this point, we dont have to worry about sp/item consumitions or any other actor's requeriment. The skill is ready to be casted.
		/// </summary>
		private void PerformCast()
		{
			Character caster = (Character)owner;
			var map = ChannelServer.Instance.World.GetMap(caster.MapId);

			// Send event
			EventData evData = new EventData();
			evData.entity = this.owner;
			evData.skill = this;

			ChannelServer.Instance.World.SendEvent(WorldManager.EventTypes.PERFORM_CAST, evData, this.owner.Handle);

			// Process skill
			switch (this.Id)
			{
				case 40001:
					/*
					this.Data.EffectId = 2562065;
					this.Data.IsDot = false;
					this.Data.LifeInSeconds = 10;
					*/
					break;
				case 40002:
					/*
					this.Data.EffectId = 2562066;
					this.Data.IsDot = false;
					this.Data.LifeInSeconds = 10;
					*/
					break;
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
				default:
					this.GetData().EffectId = 0;
					break;

			}

			// Depends of the skillType, the skill is casted in different ways, and different things are prepared.
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
							skillPosition = new Position(caster.Direction.Cos + caster.Position.X, caster.Position.Y, caster.Direction.Sin + caster.Position.Z);
						} else
						{
							skillPosition = new Position(40 * caster.Direction.Cos + caster.Position.X, caster.Position.Y, 40 * caster.Direction.Sin + caster.Position.Z);
						}
						
						var skillDirection = new Direction(caster.Direction.Cos, caster.Direction.Sin);

						// Initialize other specific variables
						if (this.GetData().MaxInteractions > 0)
						{
							PESkill.maxInteractions = this.GetData().MaxInteractions;
						}

						// Initialize ground skill
						PESkill.Init(map, this, caster.Handle, skillPosition, skillDirection);
						
						// Place skill actor in map
						PESkill.Enable();

						// Notify client
						Send.ZC_NORMAL_Unkown_1c(caster, 0, caster.Position, caster.Direction, this.Position);
						Send.ZC_SKILL_MELEE_GROUND(caster, this.Id, this.Position, this.Direction); // This packet should be sent from inside SkillGround?
						break;
					}
				default:
					/// ERROR
					break;

			}

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
		public Entity actor;
		public int skillHandle;
		public int targetHandle;
		public float value;
		public int type;
	}
}
