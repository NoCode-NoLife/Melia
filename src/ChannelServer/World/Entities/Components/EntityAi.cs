using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Melia.Channel.Network;
using Melia.Channel.World.Entities.Components.AI;
using Melia.Channel.World.Entities.Components.AI.Events;
using Melia.Shared.EntityComponents;
using Melia.Shared.Util;
using Melia.Shared.World;
using static MeluaLib.Melua;

namespace Melia.Channel.World.Entities.Components
{
	/// <summary>
	/// An AI component, that controls an entity.
	/// </summary>
	public partial class EntityAi : IUpdatableComponent
	{
		private const int HateThreshold = 100;

		private IRoutine _currentRoutine;
		private IntPtr GL, NL;

		private readonly Random _rnd = new Random(RandomProvider.GetSeed());
		private readonly List<AiEventCallback> _eventCallbacks = new List<AiEventCallback>();
		private readonly Queue<IAiEvent> _events = new Queue<IAiEvent>();

		private int _maxTargetDistance = 200;
		private int _aggroRange = 100;

		// The AI keeps track of how much it hates another entity by way
		// of "hate levels", which increase by different amounts depending
		// on the other entities' actions, such as standing close by or
		// attacking the AI's entity.
		private readonly Dictionary<int, float> _hateLevels = new Dictionary<int, float>();
		private float _hateNearby = 20; // per second
		private float _hateGetHit = 100;

		/// <summary>
		/// Returns the entity this AI belongs to.
		/// </summary>
		public IEntity Entity { get; }

		/// <summary>
		/// Returns the position of the entity when the AI was
		/// created.
		/// </summary>
		public Position InitialPosition { get; private set; }

		/// <summary>
		/// Returns the name of the current state.
		/// </summary>
		public string CurrentStateName { get; private set; } = "idle";

		/// <summary>
		/// Returns the AI's current master.
		/// </summary>
		public int MasterHandle { get; private set; }

		/// <summary>
		/// Returns the AI's current target.
		/// </summary>
		public int TargetHandle { get; private set; }

		/// <summary>
		/// Creates AI for entity.
		/// </summary>
		/// <param name="entity"></param>
		/// <param name="aiName"></param>
		public EntityAi(IEntity entity, string aiName)
		{
			this.Entity = entity;
			this.InitialPosition = entity.Position;

			this.SetUpScript(aiName);
		}

		/// <summary>
		/// Loads the AI script.
		/// </summary>
		/// <param name="aiName"></param>
		private void SetUpScript(string aiName)
		{
			// For simplicity, we'll just create one Lua state per AI for
			// now. Resource-wise that's not very efficient though, and
			// a global state and a Lua thread per AI will be better.
			// I'm kind of curious if we could get away with this though...

			var filePath = "system/scripts/ai/" + aiName + ".lua";
			if (!File.Exists(filePath))
			{
				Log.Error("EntityAi: AI script '{0}' not found.", aiName);
				return;
			}

			GL = luaL_newstate();

			melua_openlib(GL, new[]
			{
				new LuaLib("", meluaopen_basesafe),
				new LuaLib("table", luaopen_table),
				new LuaLib("string", luaopen_string),
				new LuaLib("math", luaopen_math),
			});

			lua_atpanic(GL, CreateFunctionReference(GL, this.OnPanic));

			this.RegisterScriptFunctions();

			if (!this.LoadScript("system/scripts/ai/shared.lua"))
			{
				GL = IntPtr.Zero;
				return;
			}

			if (!this.LoadScript(filePath))
			{
				GL = IntPtr.Zero;
				return;
			}

			lua_getglobal(GL, "init");
			if (lua_isfunction(GL, -1))
			{
				var result = lua_resume(GL, 0);
				if (result != 0 && result != LUA_YIELD)
					Log.Error("EntityAi: Error while exuting init function: {0}", lua_tostring(GL, -1));
			}

			lua_settop(GL, 0);
		}

		/// <summary>
		/// Loads the script at the given path, returns false if loading
		/// failed.
		/// </summary>
		/// <param name="filePath"></param>
		/// <returns></returns>
		private bool LoadScript(string filePath)
		{
			var loadResult = luaL_loadfile(GL, filePath);
			if (loadResult != 0)
			{
				Log.Error("EntityAi: Failed to read script. Error: {0}", lua_tostring(GL, -1));
				GL = IntPtr.Zero;
				return false;
			}

			var callResult = lua_pcall(GL, 0, 0, 0);
			if (callResult != 0)
			{
				Log.Error("EntityAi: Failed to load script. Error: {0}", lua_tostring(GL, -1));
				return false;
			}

			return true;
		}

		/// <summary>
		/// Registers the functions the script can use.
		/// </summary>
		private void RegisterScriptFunctions()
		{
			foreach (var method in this.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				foreach (ScriptFunctionAttribute attr in method.GetCustomAttributes(typeof(ScriptFunctionAttribute), false))
				{
					var func = (LuaNativeFunction)Delegate.CreateDelegate(typeof(LuaNativeFunction), this, method);
					melua_register(GL, attr.Name, CreateFunctionReference(GL, func));
				}
			}
		}

		/// <summary>
		/// Called when an unhandled error occurs in the script.
		/// </summary>
		/// <param name="L"></param>
		/// <returns></returns>
		private int OnPanic(IntPtr L)
		{
			var error = string.Format("unprotected error in call to Lua API ({0})", lua_tostring(L, -1));

			Log.Error("Lua panic: " + error);
			return 0;
		}

		/// <summary>
		/// Queues up event for the AI to react to on the next tick.
		/// </summary>
		/// <param name="aiEvent"></param>
		public void QueueEvent(IAiEvent aiEvent)
		{
			lock (_events)
				_events.Enqueue(aiEvent);
		}

		/// <summary>
		/// Resets AI, clearing its targets and going back to its idle state.
		/// </summary>
		private void Reset()
		{
			this.CurrentStateName = "idle";
			this.TargetHandle = 0;
			_hateLevels.Clear();

			lua_settop(GL, 0);
		}

		/// <summary>
		/// Updates the AI, executing one tick.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			// Don't do anything if the scripts weren't loaded successfully.
			if (GL == IntPtr.Zero)
				return;

			// Don't do anything if the entity is dead
			if (this.Entity.IsDead)
				return;

			this.HandleEvents();
			this.UpdateHate(elapsed);
			this.UpdateTarget();
			this.UpdateState();
			this.Tick(elapsed);
		}

		/// <summary>
		/// Executes one tick of the AI.
		/// </summary>
		private void Tick(TimeSpan elapsed)
		{
			// Get a thread to run the states on if we don't have one.
			// If there aren't any on the stack, create one.
			if (NL == IntPtr.Zero)
			{
				if (lua_gettop(GL) == 0)
					NL = lua_newthread(GL);
				else
					NL = lua_tothread(GL, -1);
			}

			// If no routine is active, start the current state function,
			// which should create routines.
			if (_currentRoutine == null)
			{
				lua_getglobal(NL, this.CurrentStateName);
				if (!lua_isfunction(NL, -1))
				{
					Log.Warning("EntityAi: Function '{0}' not defined.", this.CurrentStateName);
					lua_settop(NL, 0);
					return;
				}

				var stateResult = lua_resume(NL, 0);
				if (stateResult != 0 && stateResult != LUA_YIELD)
				{
					Log.Error("EntityAi: Error while executing '{0}': {1}", this.CurrentStateName, lua_tostring(NL, -1));

					// Don't continue if an error occurred.
					GL = IntPtr.Zero;
					return;
				}
			}

			// If we don't have a routine even after calling the state
			// function, don't do anything.
			if (_currentRoutine == null)
				return;

			// Execute the current routine
			var routineResult = _currentRoutine.Execute(elapsed);
			switch (routineResult)
			{
				// Keep going while the routine is still running
				case RoutineResult.Running:
					return;

				// Clear routine and continue, to resume the script
				case RoutineResult.Success:
				{
					this.ResetRoutine();
					break;
				}

				// Clear routine and return, to restart the state
				case RoutineResult.Fail:
				{
					this.ResetRoutine();
					return;
				}
			}

			// If the current routine was completed, resume the script,
			// so we can get the next routine. We might not have a new
			// routine after this call if the state function ended,
			// but the next tick will take care of that and restart
			// the state.
			var result = lua_resume(NL, 0);
			if (result != 0 && result != LUA_YIELD)
			{
				Log.Error("EntityAi: Error while advancing state: {0}", lua_tostring(NL, -1));

				GL = IntPtr.Zero;
				return;
			}

			// If the state reached its end and there's more than one thread
			// on the stack, pop one, so we get back to the previous state.
			if (result == 0 && lua_gettop(GL) > 1)
			{
				lua_pop(GL, 1);
			}
		}

		/// <summary>
		/// Updates which state is currently being used, based on the
		/// AI's target.
		/// </summary>
		private void UpdateState()
		{
			if (this.TargetHandle == 0)
				this.CurrentStateName = "idle";
			else
				this.CurrentStateName = "aggro";
		}

		/// <summary>
		/// Updates the AI's target, checking the current or searching
		/// for a new one.
		/// </summary>
		private void UpdateTarget()
		{
			var targetHandle = this.TargetHandle;

			if (targetHandle == 0)
			{
				this.FindTarget();
				return;
			}

			// Reset if target became unavailable
			if (!this.TryGetTarget(out var target))
			{
				this.Reset();
				return;
			}

			// Reset if the target died or got out of range
			if (target.IsDead || !target.Position.InRange2D(this.Entity.Position, _maxTargetDistance))
			{
				this.Reset();
				return;
			}
		}

		/// <summary>
		/// Updates the AI's hate, increasing it for nearby enemies and
		/// resetting it for ones that disappeared.
		/// </summary>
		/// <param name="elapsed"></param>
		private void UpdateHate(TimeSpan elapsed)
		{
			// Focus on hating the current target
			if (this.TargetHandle != 0)
				return;

			// Get potential nearby targets
			var potentialTargets = this.Entity.Map.GetEntities(a => a != this.Entity && a.Position.InRange2D(this.Entity.Position, _aggroRange));

			// Reset hate for targets that are not potential targets anymore
			if (_hateLevels.Count != 0)
			{
				var hateHandles = _hateLevels.Keys.ToArray();
				foreach (var handle in hateHandles)
				{
					var target = potentialTargets.FirstOrDefault(a => a.Handle == handle);
					if (target == null)
						_hateLevels.Remove(handle);
				}
			}

			// Increase hate for all potential targets
			foreach (var target in potentialTargets)
			{
				if (!this.DoesHate(target))
					continue;

				if (!_hateLevels.TryGetValue(target.Handle, out var hate))
					hate = 0;

				// Raise hate, up to the threshold where the AI starts
				// targetting enemies. This way we get to the point of
				// aggro, but don't keep increasing the hate afterwards.
				if (hate < HateThreshold)
					_hateLevels[target.Handle] = hate + _hateNearby * (float)elapsed.TotalSeconds;
			}
		}

		/// <summary>
		/// Returns true if the AI's entity hates the given entity.
		/// </summary>
		/// <param name="otherEntity"></param>
		/// <returns></returns>
		private bool DoesHate(IEntity otherEntity)
		{
			// I want us to be able to script what kinds of entities
			// the AI can hate, but for now, AIs hate everything that
			// is different than them.

			// Can't hate items
			if (otherEntity.Type == EntityType.Item)
				return false;

			// Don't hate while having a master for now. I assume the
			// behavior of pets is controllable? (Assuming that they
			// do combat at all.)
			if (this.MasterHandle != 0)
				return false;

			// Hate everything that has a different type
			return (this.Entity.Type != otherEntity.Type);
		}

		/// <summary>
		/// Searches for a new target for the AI.
		/// </summary>
		private void FindTarget()
		{
			if (_hateLevels.Count == 0)
				return;

			var handle = -1;
			var highest = -1f;

			foreach (var kv in _hateLevels)
			{
				handle = kv.Key;
				var hate = kv.Value;

				if (hate > highest)
					highest = hate;
			}

			if (highest != -1 && highest > HateThreshold)
			{
				this.TargetHandle = handle;
				this.ResetRoutine();

				NL = IntPtr.Zero;
				lua_settop(GL, 0);
			}
		}

		/// <summary>
		/// Returns the AI's current target if it's still on the same map.
		/// </summary>
		/// <param name="target"></param>
		/// <returns></returns>
		private bool TryGetTarget(out ICombatEntity target)
		{
			var targetHandle = this.TargetHandle;
			target = null;

			if (targetHandle == 0)
				return false;

			if (!this.Entity.Map.TryGetCombatEntity(targetHandle, out target))
				return false;

			return true;
		}

		/// <summary>
		/// Handles all queued up events.
		/// </summary>
		private void HandleEvents()
		{
			lock (_events)
			{
				while (_events.Count > 0)
					this.HandleEvent(_events.Dequeue());
			}
		}

		/// <summary>
		/// Handles the given event.
		/// </summary>
		/// <param name="aiEvent"></param>
		private void HandleEvent(IAiEvent aiEvent)
		{
			if (aiEvent is HitEvent hitEvent)
			{
				var handle = hitEvent.AttackerHandle;

				if (!_hateLevels.TryGetValue(handle, out var hate))
					hate = 0;

				_hateLevels[handle] = hate + _hateGetHit;

				var attacker = this.Entity.Map.GetCharacter(handle);
				if (attacker != null)
				{
					this.Entity.Direction = this.Entity.Position.GetDirection(attacker.Position);
					Send.ZC_ROTATE(this.Entity);
				}

				var callback = _eventCallbacks.FirstOrDefault(a => a.StateName == this.CurrentStateName && a.EventName == aiEvent.EventName);
				if (callback != null && this.ExecuteEvent(callback.CallbackName, aiEvent) != LuaFuncResult.Yielded)
				{
					lua_settop(GL, 0);
					return;
				}
			}
		}

		/// <summary>
		/// Executes the function with the given name and returns whether
		/// it yielded.
		/// </summary>
		/// <param name="callbackName"></param>
		/// <param name="aiEvent"></param>
		/// <returns></returns>
		private LuaFuncResult ExecuteEvent(string callbackName, IAiEvent aiEvent)
		{
			// Clear stack and any states that were potentially running.
			_currentRoutine = null;
			lua_settop(GL, 0);

			NL = lua_newthread(GL);

			lua_getglobal(NL, callbackName);
			if (!lua_isfunction(NL, -1))
			{
				Log.Error("EntityAi: Function '{0}' not defined.", callbackName);
				lua_settop(NL, 0);
				return LuaFuncResult.Fail;
			}

			var argc = aiEvent.PushArguments(NL);

			var stateResult = lua_resume(NL, argc);
			if (stateResult != 0 && stateResult != LUA_YIELD)
			{
				Log.Error("EntityAi: Error while exuting state function: {0}", lua_tostring(NL, -1));
				lua_settop(NL, 0);
				return LuaFuncResult.Fail;
			}

			// If the function completed, nothing yielded, so pop
			// the newly created thread and let the AI get back to
			// its current state on the next tick.
			if (stateResult == 0)
			{
				lua_settop(GL, 0);
				return LuaFuncResult.Success;
			}

			return LuaFuncResult.Yielded;
		}

		/// <summary>
		/// Returns the handle that the given integer references.
		/// </summary>
		/// <remarks>
		/// The AI scripts may pass special ids to specify what entity
		/// they want to use a routine with, such as their master or
		/// their current target. This method returns the respective
		/// handle for the requested id, or falls back to simply
		/// returning the given handle.
		/// </remarks>
		/// <param name="handle"></param>
		/// <returns></returns>
		private int ResolveHandle(int handle)
		{
			switch (handle)
			{
				case HandleId.Me: return this.Entity.Handle;
				case HandleId.Master: return this.MasterHandle;
				case HandleId.Target: return this.TargetHandle;

				default: return handle;
			}
		}

		/// <summary>
		/// Returns the default handle for the "other entity" for the
		/// current state. Returns 0 if no fitting handle could be
		/// found.
		/// </summary>
		/// <remarks>
		/// The returned handle is the one you're most likely to want
		/// for the current state. For example, during aggro, the "other
		/// entity" is most likely the current aggro target, while during
		/// idle, the other entity is most likely the entity's master.
		/// This method is intended for use with script functions that
		/// have optional handle arguments.
		/// </remarks>
		/// <returns></returns>
		private int GetOtherEntityHandle()
		{
			switch (this.CurrentStateName)
			{
				case "idle": return this.MasterHandle;
				case "aggro": return this.TargetHandle;

				default: return 0;
			}
		}

		/// <summary>
		/// Sets this AI's master.
		/// </summary>
		/// <param name="entity"></param>
		public void SetMaster(IEntity entity)
		{
			this.MasterHandle = entity.Handle;

			lua_pushboolean(GL, true);
			lua_setglobal(GL, "HAS_MASTER");
		}

		public enum LuaFuncResult
		{
			Success,
			Fail,
			Yielded,
		}

		/// <summary>
		/// Starts the routine.
		/// </summary>
		/// <param name="routine"></param>
		private void StartRoutine(IRoutine routine)
		{
			_currentRoutine = routine;
		}

		/// <summary>
		/// Clears the current routine.
		/// </summary>
		private void ResetRoutine()
		{
			_currentRoutine = null;
		}
	}
}
