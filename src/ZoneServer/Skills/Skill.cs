using System;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Game.Const;
using Melia.Shared.ObjectProperties;
using Melia.Shared.World;
using Melia.Zone.Network;
using Melia.Zone.Skills.SplashAreas;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Yggdrasil.Logging;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;

namespace Melia.Zone.Skills
{
	public class Skill : IPropertyObject, IUpdateable
	{
		private static long ObjectIds = ObjectIdRanges.Skills;

		private readonly object _ctsLock = new();
		private CancellationTokenSource _cts;
		private int _runnerCount;

		/// <summary>
		/// Returns a reference to the cancellation token associated with
		/// the latest usage of the skill.
		/// </summary>
		/// <remarks>
		/// Every time the skill is used, a new cancellation token is
		/// created, which can used to check for cancellation requests
		/// during that usage.
		///
		/// If the skill is cast again while a previously started task
		/// still holds onto an old token, that token will be cancelled,
		/// while the token returned by the skill will be a new one.
		/// </remarks>
		public CancellationToken CancellationToken => _cts?.Token ?? CancellationToken.None;

		/// <summary>
		/// Returns true if any running tasks are associated with the
		/// skill, having been started using Run.
		/// </summary>
		/// <remarks>
		/// As skills are mostly stateless, whether they're active or not
		/// depends on whether parts of them are still being executed on
		/// tasks. Tasks started using Run are kept track of and the skill
		/// is considered running until they return.
		/// </remarks>
		public bool IsRunning => Interlocked.CompareExchange(ref _runnerCount, 0, 0) > 0;

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
		/// Update: We used to check id ranges here, but we found the "keywords"
		/// or tags on the skill data by now, which include the "NormalSkill"
		/// tag. We'll assume that to be the way to determine normal attacks for
		/// now.
		public bool IsNormalAttack => this.Data.Tags.Has(SkillTag.NormalSkill);

		/// <summary>
		/// Returns true if the skill is a monster skill.
		/// </summary>
		/// <remarks>
		/// We're currently using the id range to determine whether a skill is a
		/// monster skill, though a check for the skill name prefix "Mon_" might
		/// also be a valid check.
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
		/// Reduces the skill's cooldown by the given amount of time.
		/// </summary>
		/// <remarks>
		/// If no cooldown is active for the given id, this method does nothing.
		/// </remarks>
		/// <param name="reduction"></param>
		public void ReduceCooldown(TimeSpan reduction)
		{
			this.Owner.Components.Get<CooldownComponent>().ReduceCooldown(this.Data.CooldownGroup, reduction);
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
		/// Prepares the skill for the possibility of cancelling it and
		/// its effects.
		/// </summary>
		/// <remarks>
		/// Creates a new cancellation token source that will be used for
		/// running tasks related to the skill using Run/RunFree. This
		/// source's token will be checked against when determining
		/// whether the skill should be cancelled or not, which can be
		/// done by calling Cancel.
		/// </remarks>
		public void PrepareCancellation()
		{
			lock (_ctsLock)
			{
				if (_cts != null)
					this.Cancel();

				_cts = new();
			}

			Interlocked.Exchange(ref _runnerCount, 0);
		}

		/// <summary>
		/// Cancels the skill and its ongoing effects.
		/// </summary>
		/// <remarks>
		/// Cancels the token source associated with the skill, cancelling
		/// any non-free tasks that are currently running.
		/// </remarks>
		public void Cancel()
		{
			lock (_ctsLock)
			{
				if (_cts != null)
				{
					_cts.Cancel();
					_cts.Dispose();
					_cts = null;
				}
			}

			Interlocked.Exchange(ref _runnerCount, 0);
		}

		/// <summary>
		/// Runs the given task in a thread-safe manner.
		/// </summary>
		/// <remarks>
		/// Runs the task in association with the skill's current
		/// cancellation token, cancelling the task if the token is
		/// cancelled, effectively stopping the skill execution.
		///
		/// Note that only tasks started with this method, or which are
		/// manually given the skill's cancellation token, will be
		/// terminated on cancelling the skill. Tasks that aren't
		/// associated with the skill's token, such as freeform Task.Delay
		/// calls, will be unaffected.
		///
		/// In addition to being cancellable, tasks using this method are
		/// also tracked to determine whether a skill is active, with the
		/// idea being that a skill is active as long as its directly
		/// associated tasks have not yet returned.
		/// </remarks>
		/// <param name="task"></param>
		public void Run(Task task)
		{
			Interlocked.Increment(ref _runnerCount);

			task.WaitAsync(_cts.Token).ContinueWith(t =>
			{
				Interlocked.Decrement(ref _runnerCount);

				if (t.Exception != null)
					Log.Error("An exception occured while running '{0}' for '{1}': {2}", this.Id, this.Owner.Name, t.Exception);
			});
		}

		/// <summary>
		/// Runs the given task in a thread-safe manner.
		/// </summary>
		/// <remarks>
		/// Runs the task without associating it with the skill's current
		/// cancellation token, allowing it to keep running freely, even
		/// if the skill is cancelled. For manual cancellation checks, the
		/// skill's CancellationToken can be used, which should be saved
		/// immediately after invoking the task if necessary.
		///
		/// Note that the task will only keep running if tasks don't check
		/// against the skill's cancellation token. A free task that uses
		/// the skill's Wait method will be cancelled just like a non-free
		/// running task. For this reason, free tasks should use other
		/// tasks to delay execution, such as Task.Delay.
		/// </remarks>
		/// <param name="task"></param>
		public void RunFree(Task task)
		{
			task.ContinueWith(t =>
			{
				if (t.Exception != null)
					Log.Error("An exception occured while running '{0}' for '{1}': {2}", this.Id, this.Owner.Name, t.Exception);
			});
		}

		/// <summary>
		/// Returns a task that waits for the given amount of time.
		/// </summary>
		/// <remarks>
		/// Uses Task.Delay with the skill's current cancellation token to
		/// cancel if the skill is cancelled. For ease of use, this method
		/// should be used in non-free tasks associated with the skill.
		/// </remarks>
		/// <param name="time"></param>
		/// <returns></returns>
		public async Task Wait(TimeSpan time)
		{
			if (time > TimeSpan.Zero)
				await Task.Delay(time, _cts.Token);
		}
	}
}
