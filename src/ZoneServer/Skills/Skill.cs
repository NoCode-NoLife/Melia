using System;
using System.Threading;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.Skills
{
	public class Skill : IPropertyObject, IUpdateable
	{
		private static long ObjectIds = ObjectIdRanges.Skills;

		/// <summary>
		/// The skill's unique id.
		/// </summary>
		/// <remarks>
		/// We're basically assigning a new object id to every skill here,
		/// every time one is created. That *might* work, but we have to be
		/// careful. If there's a single case where the skill id needs to
		/// persist, we have to seriously rethink our approach to object
		/// ids, and potentially create a global pool on the database or
		/// something.
		/// </remarks>
		public long ObjectId { get; } = Interlocked.Increment(ref ObjectIds);

		/// <summary>
		/// Returns reference to the skill's properties.
		/// </summary>
		public SkillProperties Properties { get; }

		/// <summary>
		/// Returns reference to the skill's properties.
		/// </summary>
		Properties IPropertyHolder.Properties => this.Properties;

		/// <summary>
		/// Returns reference to the skill's owner.
		/// </summary>
		public ICombatEntity Owner { get; }

		/// <summary>
		/// Returns the skill's class id.
		/// </summary>
		public SkillId Id { get; }

		/// <summary>
		/// Gets or sets skill's level.
		/// </summary>
		public int Level { get; set; }

		/// <summary>
		/// Returns the amount of SP necessary to use the skill.
		/// </summary>
		public int SpendSp
			=> (int)this.Properties.GetFloat(PropertyName.SpendSP);

		/// <summary>
		/// Returns the skill's overheat count. If this value reaches the
		/// skill's maximum overheat, the skill goes on a cooldown.
		/// </summary>
		public int OverheatCounter { get; private set; }

		/// <summary>
		/// Returns the time until the skill's overheat counter is reset.
		/// </summary>
		public TimeSpan OverheatTimeRemaining { get; private set; }

		/// <summary>
		/// Returns reference to the skill's data from the file database.
		/// </summary>
		public SkillData Data { get; }

		/// <summary>
		/// Returns reference to the skill's cooldow ndata from the file
		/// database.
		/// </summary>
		public CooldownData CooldownData { get; }

		/// <summary>
		/// Returns reference to the skill's overheat data from the file
		/// database.
		/// </summary>
		public CooldownData OverheatData { get; }

		/// <summary>
		/// Returns the skill's temporary variables.
		/// </summary>
		public Variables Vars { get; } = new Variables();

		/// <summary>
		/// Returns whether this skill can overheat.
		/// </summary>
		public bool CanOverheat => this.Data.OverheatCount > 0;

		/// <summary>
		/// Returns whether the skill is currently overheated.
		/// </summary>
		public bool IsOverheated => this.CanOverheat && this.OverheatCounter >= this.Data.OverheatCount;

		/// <summary>
		/// Returns true if the skill is currently on cooldown.
		/// </summary>
		public bool IsOnCooldown => this.Owner.Components.Get<CooldownComponent>().IsOnCooldown(this.Data.CooldownGroup);

		/// <summary>
		/// Returns true if the skill is a normal attack.
		/// </summary>
		/// <remarks>
		/// This property is a temporary measure to not do this check randomly
		/// somewhere in the code. We'll need some more research to determine
		/// what exactly makes a normal attack and when they apply. Especially
		/// because it seems like this might differ based on your stance.
		/// </remarks>
		public bool IsNormalAttack => (int)this.Id <= 1000;

		/// <summary>
		/// Returns true if the skill is a monster skill
		/// </summary>
		/// <remarks>
		/// This property is a temporary measure to not do this check randomly
		/// somewhere in the code. We'll need some more research to determine
		/// what exactly makes a normal attack and when they apply. Especially
		/// because it seems like this might differ based on your stance.
		/// </remarks>
		public bool IsMonsterSkill => (int)this.Id >= 60000;

		/// <summary>
		/// Returns true if this skill is a passive skill.
		/// </summary>
		public bool IsPassive => this.Data.ActivationType == SkillActivationType.PassiveSkill;

		/// <summary>
		/// Creates a new instance.
		/// </summary>
		/// <param name="owner"></param>
		/// <param name="skillId"></param>
		/// <param name="level"></param>
		public Skill(ICombatEntity owner, SkillId skillId, int level)
		{
			this.Owner = owner;
			this.Id = skillId;
			this.Level = level;

			this.Data = ZoneServer.Instance.Data.SkillDb.Find(skillId) ?? throw new ArgumentException($"Unknown skill '{skillId}'.");
			this.CooldownData = ZoneServer.Instance.Data.CooldownDb.Find(this.Data.CooldownGroup) ?? throw new ArgumentException($"Unknown skill '{skillId}' cooldown group '{this.Data.CooldownGroup}'.");
			this.OverheatData = ZoneServer.Instance.Data.CooldownDb.Find(this.Data.OverheatGroup) ?? throw new ArgumentException($"Unknown skill '{skillId}' overheat group '{this.Data.OverheatGroup}'.");

			this.Properties = new SkillProperties(this);
		}

		/// <summary>
		/// Increases skill's overheat counter by 1 if the skill can
		/// overheat and updates the client. Activates cooldown once
		/// the max overheat is reached. Returns whether the skill
		/// overheated or not.
		/// </summary>
		/// <returns
		public bool IncreaseOverheat()
			=> this.IncreaseOverheat(this.Data.OverheatCount);

		/// <summary>
		/// Increases skill's overheat counter by 1 if the skill can
		/// overheat and updates the client. Activates cooldown once
		/// the max overheat is reached. Returns whether the skill
		/// overheated or not.
		/// </summary>
		/// <param name="overheatMaxCount"></param>
		/// <returns
		public bool IncreaseOverheat(int overheatMaxCount)
		{
			// No cooldowns for monsters
			if (this.Owner is not Character character)
				return false;

			// Increase counter regardless of whether the skill can
			// overheat. In both cases we will eventually get over
			// the overheat counter, in which case we reset the
			// overheat and go on cooldown.
			this.OverheatCounter++;
			this.OverheatTimeRemaining = this.OverheatData.OverheatResetTime;

			var overheated = false;
			if (this.OverheatCounter >= overheatMaxCount)
			{
				this.OverheatCounter = 0;
				this.OverheatTimeRemaining = TimeSpan.Zero;
				overheated = false;

				this.Owner.Components.Get<CooldownComponent>().Start(this.Data.CooldownGroup, this.Data.CooldownTime);
			}

			// Update the overheat after the max was checked so we reset it
			// to 0 if we went into cooldown
			Send.ZC_OVERHEAT_CHANGED(character, this);

			return overheated;
		}

		/// <summary>
		/// Resets the skill's overheat and puts it on a cooldown that lasts
		/// for the given amount of time.
		/// </summary>
		/// <param name="cooldownTime"></param>
		public void StartCooldown(TimeSpan cooldownTime)
		{
			if (this.Owner is not Character character)
				return;

			if (!this.Owner.Components.TryGet<CooldownComponent>(out var cooldownComponent))
				return;

			cooldownComponent.Start(this.Data.CooldownGroup, cooldownTime);

			this.OverheatCounter = 0;
			this.OverheatTimeRemaining = TimeSpan.Zero;

			Send.ZC_OVERHEAT_CHANGED(character, this);
		}


		/// <summary>
		/// Reduces the skill's cooldownTime
		/// </summary>
		/// <param name="cooldownTime"></param>
		public void ReduceCooldown(TimeSpan reductionTime)
		{
			if (this.Owner is not Character character)
				return;

			if (!this.Owner.Components.TryGet<CooldownComponent>(out var cooldownComponent))
				return;

			cooldownComponent.Reduce(this.Data.CooldownGroup, reductionTime);
		}

		/// <summary>
		/// Returns the minimum range to the target within which the skill
		/// can be used.
		/// </summary>
		/// <returns></returns>
		public float GetAttackRange()
		{
			// Guessed, see GetSplashArea. Take a little off the top,
			// so entities actually have to get into the splash area.
			//return this.Properties.GetFloat(PropertyName.SplHeight);

			// After testing splash height, it seems unlikely that that's
			// the way to get the min distance. It seems a little counter-
			// intuitive, but let's try MaxR, which seems to have rather
			// fitting values for this purpose.
			return this.Properties.GetFloat(PropertyName.MaxR);
		}

		/// <summary>
		/// Updates the skill's overheat.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			if (this.OverheatTimeRemaining > TimeSpan.Zero)
			{
				this.OverheatTimeRemaining = Math2.Max(TimeSpan.Zero, this.OverheatTimeRemaining - elapsed);

				// There's no need to update the client as it resets the
				// overheat counter automatically after the overheat reset
				// time passed
				if (this.OverheatTimeRemaining == TimeSpan.Zero)
					this.OverheatCounter = 0;
			}
		}

		/// <summary>
		/// Calculates positions and direction for use in splash areas.
		/// </summary>
		/// <param name="caster"></param>
		/// <param name="originPos"></param>
		/// <param name="farPos"></param>
		/// <param name="length"></param>
		/// <param name="width"></param>
		/// <param name="angle"></param>
		/// <returns></returns>
		public SplashParameters GetSplashParameters(ICombatEntity caster, Position originPos, Position farPos, float length, float width, float angle)
		{
			var result = new SplashParameters();

			result.Length = length;
			result.Width = width;
			result.Angle = angle;

			if (originPos == farPos)
				result.Direction = caster.Direction;
			else
				result.Direction = originPos.GetDirection(farPos);

			result.OriginPos = caster.Position;
			result.FarPos = result.OriginPos.GetRelative(result.Direction, length);

			return result;
		}

		/// <summary>
		/// Returns a splash area based on the given type and parameters.
		/// </summary>
		/// <param name="type"></param>
		/// <param name="param"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public ISplashArea GetSplashArea(SplashType type, SplashParameters param)
		{
			ISplashArea splashArea;

			switch (type)
			{
				case SplashType.Fan: splashArea = new Fan(param.OriginPos, param.Direction, param.Length, param.Angle); break;
				case SplashType.Square: splashArea = new Square(param.OriginPos, param.Direction, param.Length, param.Width); break;
				case SplashType.Circle: splashArea = new Circle(param.FarPos, param.Width); break;

				default: throw new ArgumentException($"Unsupported splash type: {type}");
			}

			//Debug.ShowShape(this.Owner.Map, splashArea);

			return splashArea;
		}

		/// <summary>
		/// Holds parameters for splash areas.
		/// </summary>
		public struct SplashParameters
		{
			/// <summary>
			/// The length of the splash area. Typically synonymous with
			/// the distance between the caster and the farthest point
			/// of the splash area.
			/// </summary>
			public float Length;

			/// <summary>
			/// The width of a rectangular splash area or the radius of
			/// a circular one.
			/// </summary>
			public float Width;

			/// <summary>
			/// The angle of a fan-shaped splash area.
			/// </summary>
			public float Angle;

			/// <summary>
			/// The direction in which the splash area is facing from
			/// the caster.
			/// </summary>
			public Direction Direction;

			/// <summary>
			/// The position of the caster.
			/// </summary>
			public Position OriginPos;

			/// <summary>
			/// The farthest position of the splash area.
			/// </summary>
			public Position FarPos;
		}
	}
}
