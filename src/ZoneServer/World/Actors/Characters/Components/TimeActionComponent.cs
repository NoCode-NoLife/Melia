using System;
using System.Threading;
using System.Threading.Tasks;
using Melia.Zone.Network;
using Yggdrasil.Scheduling;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// Controls a time action, displaying a progress bar that fills
	/// up over time.
	/// </summary>
	public class TimeActionComponent : CharacterComponent, IUpdateable
	{
		private readonly object _syncLock = new();

		private TimeAction _activeTimeAction;
		private TimeSpan _remainingTime;
		private TimeActionCallback _callback;

		private SemaphoreSlim _resumeSignal;

		/// <summary>
		/// Returns true if a time action is currently active.
		/// </summary>
		public bool IsActive { get { lock (_syncLock) return _activeTimeAction != null; } }

		/// <summary>
		/// Creates a new time action component.
		/// </summary>
		/// <param name="character"></param>
		public TimeActionComponent(Character character) : base(character)
		{
		}

		/// <summary>
		/// Starts a time action and calls the callback once it's complete
		/// or was cancelled.
		/// </summary>
		/// <param name="displayText"></param>
		/// <param name="animationName"></param>
		/// <param name="duration"></param>
		/// <param name="callback"></param>
		public void Start(string displayText, string buttonText, string animationName, TimeSpan duration, TimeActionCallback callback)
		{
			var timeAction = new TimeAction(displayText, buttonText, animationName, duration);

			this.End(TimeActionResult.Cancelled);
			this.Start(timeAction, callback);
		}

		/// <summary>
		/// Starts a time action, potentially replacing the currently
		/// active one.
		/// </summary>
		/// <param name="timeAction"></param>
		/// <param name="callback"></param>
		private void Start(TimeAction timeAction, TimeActionCallback callback)
		{
			lock (_syncLock)
			{
				_activeTimeAction = timeAction;
				_remainingTime = timeAction.Duration;
				_callback = callback;
			}

			Send.ZC_NORMAL.TimeActionStart(this.Character, timeAction);
		}

		/// <summary>
		/// Starts a time action and returns once it completed or was
		/// cancelled.
		/// </summary>
		/// <param name="displayText"></param>
		/// <param name="buttonText"></param>
		/// <param name="animationName"></param>
		/// <param name="duration"></param>
		/// <returns></returns>
		public async Task<TimeActionResult> StartAsync(string displayText, string buttonText, string animationName, TimeSpan duration)
		{
			this.End(TimeActionResult.Cancelled);

			TimeAction timeAction;

			lock (_syncLock)
			{
				_activeTimeAction = timeAction = new TimeAction(displayText, buttonText, animationName, duration);
				_remainingTime = timeAction.Duration;
				_resumeSignal = new SemaphoreSlim(0);
			}

			Send.ZC_NORMAL.TimeActionStart(this.Character, timeAction);

			await _resumeSignal.WaitAsync();

			return timeAction.Result;
		}

		/// <summary>
		/// Ends the currently active time action with the given result.
		/// </summary>
		/// <param name="result"></param>
		public void End(TimeActionResult result)
		{
			TimeAction timeAction;
			TimeActionCallback callback;
			SemaphoreSlim resumeSignal;

			lock (_syncLock)
			{
				if (_activeTimeAction == null)
					return;

				timeAction = _activeTimeAction;
				callback = _callback;
				resumeSignal = _resumeSignal;

				_activeTimeAction = null;
				_remainingTime = TimeSpan.MaxValue;
				_callback = null;
				_resumeSignal = null;
			}

			timeAction.Result = result;

			callback?.Invoke(this.Character, timeAction);
			resumeSignal?.Release();

			Send.ZC_NORMAL.TimeActionEnd(this.Character);
		}

		/// <summary>
		/// Called regularly to update a potentially active time action.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			lock (_syncLock)
			{
				if (_activeTimeAction == null)
					return;

				_remainingTime -= elapsed;
				if (_remainingTime > TimeSpan.Zero)
					return;

				this.End(TimeActionResult.Completed);
			}
		}
	}

	/// <summary>
	/// Contains all information about a time action.
	/// </summary>
	public class TimeAction
	{
		/// <summary>
		/// Returns the text displayed with the progress bar.
		/// </summary>
		public string DisplayText { get; }

		/// <summary>
		/// Returns the text displayed on the button.
		/// </summary>
		public string ButtonText { get; }

		/// <summary>
		/// Returns the name of the animation the character is put into.
		/// </summary>
		public string AnimationName { get; }

		/// <summary>
		/// Returns the duration of the time action.
		/// </summary>
		public TimeSpan Duration { get; }

		/// <summary>
		/// Returns the result of the time action.
		/// </summary>
		public TimeActionResult Result { get; internal set; }

		/// <summary>
		/// Creates a new time action.
		/// </summary>
		/// <param name="displayText"></param>
		/// <param name="buttonText"></param>
		/// <param name="animationName"></param>
		/// <param name="duration"></param>
		public TimeAction(string displayText, string buttonText, string animationName, TimeSpan duration)
		{
			this.DisplayText = displayText;
			this.ButtonText = buttonText;
			this.AnimationName = animationName;
			this.Duration = duration;
		}
	}

	/// <summary>
	/// The result of a time action.
	/// </summary>
	public enum TimeActionResult
	{
		/// <summary>
		/// No result (yet).
		/// </summary>
		None,

		/// <summary>
		/// The time action completed.
		/// </summary>
		Completed,

		/// <summary>
		/// The time action was cancelled.
		/// </summary>
		Cancelled,

		/// <summary>
		/// The time action was cancelled by the actor moving.
		/// </summary>
		CancelledByMove,
	}

	/// <summary>
	/// A function that is called once a time action completes.
	/// </summary>
	/// <param name="character"></param>
	/// <param name="timeAction"></param>
	public delegate void TimeActionCallback(Character character, TimeAction timeAction);
}
