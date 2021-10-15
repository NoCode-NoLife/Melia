using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Melia.Channel.Network;
using Melia.Channel.World.Entities.Components.AI;
using Melia.Channel.World.Entities.Components.AI.Events;
using Melia.Channel.World.Entities.Components.AI.Routines;
using Melia.Shared.EntityComponents;
using Melia.Shared.Util;
using Melia.Shared.World;
using static MeluaLib.Melua;

namespace Melia.Channel.World.Entities.Components
{
	/// <summary>
	/// An AI component, that controls an entity.
	/// </summary>
	public class EntityAi : IUpdatableComponent
	{
		private IRoutine _currentRoutine;
		private IntPtr GL, NL;

		private readonly Random _rnd = new Random(RandomProvider.GetSeed());
		private readonly List<AiEventCallback> _eventCallbacks = new List<AiEventCallback>();
		private readonly Queue<IAiEvent> _events = new Queue<IAiEvent>();

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
					Log.Error("EntityAi: Function '{0}' not defined.", this.CurrentStateName);
					lua_settop(NL, 0);
					return;
				}

				var stateResult = lua_resume(NL, 0);
				if (stateResult != 0 && stateResult != LUA_YIELD)
				{
					Log.Error("EntityAi: Error while exuting state function: {0}", lua_tostring(NL, -1));
					lua_settop(NL, 0);
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
				lua_settop(NL, 0);
			}

			// If the state reached its end and there's more than one thread
			// on the stack, pop one, so we get back to the previous state.
			if (result == 0 && lua_gettop(GL) > 1)
			{
				lua_pop(GL, 1);
			}
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
				// Handle aggroing...

				var attacker = this.Entity.Map.GetCharacter(hitEvent.AttackerHandle);
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

		/// <summary>
		/// Sets up a callback for an event.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - string  stateName  Name of the state during which to reach to the event.
		/// - string  eventName  Name of the event.
		/// - string  callbackName  Name of the function to call to handle the event.
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("on")]
		protected int OnEvent(IntPtr L)
		{
			var stateName = luaL_checkstring(L, 1);
			var eventName = luaL_checkstring(L, 2);
			var callbackName = luaL_checkstring(L, 3);

			lua_settop(L, 0);

			_eventCallbacks.Add(new AiEventCallback(stateName, eventName, callbackName));

			return 0;
		}

		/// <summary>
		/// Makes AI wait for a certain amount of time.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - int  min  Minimum wait time in milliseconds.
		/// - int  max  Maximum wait time in milliseconds. (optional)
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("wait")]
		protected int Wait(IntPtr L)
		{
			var min = luaL_checkinteger(L, 1);
			var max = min;

			if (lua_gettop(L) > 1)
				max = luaL_checkinteger(L, 2);

			lua_settop(L, 0);

			var waitTimeMs = _rnd.Next(min, max + 1);

			var routine = new WaitRoutine(TimeSpan.FromMilliseconds(waitTimeMs));
			this.StartRoutine(routine);

			return lua_yield(L, 0);
		}

		/// <summary>
		/// Makes entity walk to a random position nearby.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - int  minDistance  Minimum distance to walk.
		/// - int  maxDistance  Maximum distance to walk. (optional)
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("wander")]
		protected int Wander(IntPtr L)
		{
			var minDistance = luaL_checkinteger(L, 1);
			var maxDistance = minDistance;

			if (lua_gettop(L) > 1)
				maxDistance = luaL_checkinteger(L, 2);

			lua_settop(L, 0);

			// Try to find a valid random destination. If we can't find
			// one in a reasonable amount of time, just let the AI wait
			// for a moment.
			var destination = Position.Zero;
			var validDest = false;
			var pos = this.Entity.Position;

			for (var i = 0; i < 50; ++i)
			{
				destination = this.InitialPosition.GetRandomInRange2D(maxDistance, _rnd);

				// Skip destination if it's too close the current position
				if (pos.InRange2D(destination, minDistance) || !pos.InRange2D(destination, maxDistance))
					continue;

				// Use the destination if it's valid
				if (this.Entity.Map.Ground.IsValidPosition(destination))
				{
					validDest = true;
					break;
				}
			}

			if (validDest)
			{
				var routine = new MoveToRoutine(this, destination);
				this.StartRoutine(routine);
			}
			else
			{
				this.StartRoutine(new WaitRoutine(TimeSpan.FromSeconds(2)));
			}

			return lua_yield(L, 0);
		}

		/// <summary>
		/// Shows emoticon for entity.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - string  emoticonName
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("emoticon")]
		protected int Emoticon(IntPtr L)
		{
			var emoticonName = luaL_checkstring(L, 1);
			lua_settop(L, 0);

			Send.ZC_SHOW_EMOTICON(this.Entity, emoticonName, 2000);

			return 0;
		}

		/// <summary>
		/// Makes entity say something.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - string  message
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("say")]
		protected int Say(IntPtr L)
		{
			var msg = lua_tostring(L, 1);

			lua_settop(L, 0);

			Send.ZC_CHAT(this.Entity, msg);

			return 0;
		}

		/// <summary>
		/// Prints debug message.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - string  message
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("logdebug")]
		protected int LogDebug(IntPtr L)
		{
			var msg = lua_tostring(L, 1);
			lua_settop(L, 0);

			Log.Debug(msg);

			return 0;
		}

		/// <summary>
		/// Returns a random number.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - int  min  Minimum value. (optional)
		/// - int  max  Maximum value - 1. (optional)
		/// 
		/// Result:
		/// - No arguments: 0 ~ 100
		/// - 1 Argument:   0 ~ argument1
		/// - 2 Arguments:  argument1 ~ argument2 - 1
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("random")]
		protected int Random(IntPtr L)
		{
			int min = 0, max = 100 + 1;

			var argc = lua_gettop(L);

			if (argc > 0)
				max = luaL_checkinteger(L, 1);

			if (argc > 1)
			{
				min = max;
				max = luaL_checkinteger(L, 2);
			}

			lua_settop(L, 0);

			if (max < min)
				max = min;

			var result = _rnd.Next(min, max);
			lua_pushinteger(L, result);

			return 1;
		}

		/// <summary>
		/// Returns a random float number.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - float  min  Minimum value. (optional)
		/// - float  max  Maximum value - 1. (optional)
		/// 
		/// Result:
		/// - No arguments: 0.0 ~ 1.0
		/// - 1 Argument:   0.0 ~ argument1
		/// - 2 Arguments:  argument1 ~ argument2
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("randomf")]
		protected int RandomFloat(IntPtr L)
		{
			double min = 0, max = 1;

			var argc = lua_gettop(L);

			if (argc > 0)
				max = luaL_checknumber(L, 1);

			if (argc > 1)
			{
				min = max;
				max = luaL_checknumber(L, 2);
			}

			lua_settop(L, 0);

			if (max < min)
				max = min;

			var result = min + _rnd.NextDouble() * (max - min);
			lua_pushnumber(L, result);

			return 1;
		}
	}
}
