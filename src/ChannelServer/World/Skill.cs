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
using Melia.Channel.World.SkillEffects;

namespace Melia.Channel.World
{
	public class Skill : Actor
	{
		public long _worldId;
		public int Id;
		public int level;
		public IEntity owner;

		public SkillData Data;
		public SkillEffect EffectHandler { get; set; }

		public Skill(int skillId, int level)
		{
			this._worldId = Interlocked.Increment(ref _worldId) + 0x30000000000000;
			this.level = level;
			this.Id = skillId;
			this.LoadData();

			/// TODO
			// This should be moved to SkillData, and make sure every skill has a valid effect!
			SkillEffect effect;
			if (ChannelServer.Instance.SkillEffects.TryGetValue(this.Id, out effect))
			{
				this.EffectHandler = effect;
			} else
			{
				Log.Error("This skillID has no effect: {0}", this.Id);
			}

		}

		public bool SetLevel(int newLevel)
		{
			this.level = newLevel;
			return true;
		}

		/// <summary>
		/// Loads skill data from data files.
		/// </summary>
		public void LoadData()
		{
			if (this.Id == 0)
				throw new InvalidOperationException("Skill id wasn't set before calling LoadData.");

			this.Data = ChannelServer.Instance.Data.SkillDb.Find(this.Id);
			if (this.Data == null)
				throw new NullReferenceException("No skill data found for '" + this.Id + "'.");
		}

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
				//castTimer = new Timer(Cast, null, GetActivationTime(), )
			}

		}

		private bool CanActivate()
		{
			Character caster = (Character)owner;

			// Check if caster has enough SP
			if (caster.Sp < (int)this.Data.SpendSP)
				return false;

			return true;
		}

		public float GetActivationTime()
		{
			return 0.0f;
		}

		private void Cast()
		{
			Send.ZC_SKILL_READY((Character)owner, this.Id, owner.Position, this.Position);

			Character caster = (Character)owner;

			// Consume mana
			caster.SetCurrentSp((int)this.Data.SpendSP);

			PerformCast();
		}

		private void PerformCast()
		{
			Character caster = (Character)owner;
			var map = ChannelServer.Instance.World.GetMap(caster.MapId);

			switch (this.Id)
			{
				case 40001:
					this.Data.EffectId = 2562065;
					this.Data.IsDot = false;
					this.Data.LifeInSeconds = 10;
					break;
				case 40002:
					this.Data.EffectId = 2562066;
					this.Data.IsDot = false;
					this.Data.LifeInSeconds = 10;
					break;
				case 40003:
					this.Data.EffectId = 2562067;
					this.Data.IsDot = true;
					this.Data.buffId = 94;
					this.Data.buffIsPermanent = true;
					this.Data.buffLifeInSeconds = 0;
					this.Data.buffCanStack = false;
					this.Data.LifeInSeconds = 10;
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
					this.Data.statModifiers = skillStatModifiers;
					break;
				case 40004:
					this.Data.EffectId = 190323;
					this.Data.IsDot = true;
					this.Data.buffId = 142;
					this.Data.buffIsPermanent = true;
					this.Data.buffLifeInSeconds = 0;
					this.Data.buffCanStack = true;
					this.Data.LifeInSeconds = 20;
					Dictionary<Stat, StatModifier> skillStatModifiers2 = new Dictionary<Stat, StatModifier>();
					StatModifier statMod2;
					statMod2.stat = Stat.Evasion;
					statMod2.modifierType = StatModifierType.Addition;
					statMod2.modifierValue = 30f;
					skillStatModifiers2.Add(statMod2.stat, statMod2);

					statMod2.stat = Stat.DR_BM;
					statMod2.modifierType = StatModifierType.Addition;
					statMod2.modifierValue = 1f;
					skillStatModifiers2.Add(statMod2.stat, statMod2);
					this.Data.statModifiers = skillStatModifiers2;
					break;
				case 100:
					this.Data.IsDot = false;
					this.Data.IsInstant = true;
					break;
				default:
					this.Data.EffectId = 0;
					break;

			}

			switch (this.Data.Type)
			{
				case SkillType.GROUND:
					{
						// Create skill actor
						GroundSkill PESkill = new GroundSkill();
						var skillPosition = new Position(40 * caster.Direction.Cos + caster.Position.X, caster.Position.Y, 40 * caster.Direction.Sin + caster.Position.Z);
						var skillDirection = new Direction(caster.Direction.Cos, caster.Direction.Sin);
						PESkill.Init(map, this, caster.Handle, skillPosition, skillDirection);
						// Place skill actor in map
						PESkill.Enable();
						Send.ZC_NORMAL_Unkown_1c(caster, 0, caster.Position, caster.Direction, this.Position);
						Send.ZC_SKILL_MELEE_GROUND(caster, this.Id, this.Position, this.Direction);
						break;
					}
				default:
					/// ERROR
					break;

			}

		}

		public SkillResult ProcessSkill(Actor target)
		{
			Log.Debug("ProcessSkill: {0}", this.Id);
			if (this.EffectHandler != null)
			{
				return this.EffectHandler.ProcessSkill(target, this);
			}
			return null;
			/*
			switch (this.Id)
			{
				case 40001:
					return SkillEffects.Heal.ProcessSkill(target, this);
				case 40002:
					return SkillEffects.Cure.ProcessSkill(target, this);
				case 40003:
					return SkillEffects.BuffSkill.ProcessSkill(target, this);
				case 40004:
					return SkillEffects.BuffSkill.ProcessSkill(target, this);
				case 100:
					return SkillEffects.Melee.ProcessSkill(target, this);
				default:
					return null;
				
			}
			*/

		}

	}

	public class SkillResult
	{
		public Actor actor;
		public int skillHandle;
		public int targetHandle;
		public float value;
		public int type;
	}
}
