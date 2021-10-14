using System;
using System.IO;
using System.Reflection;
using Melia.Channel.Network;
using Melia.Channel.World.Entities.Components.AI;
using Melia.Channel.World.Entities.Components.AI.Routines;
using Melia.Shared.EntityComponents;
using Melia.Shared.Util;
using Melia.Shared.World;
using static MeluaLib.Melua;

namespace Melia.Channel.World.Entities.Components
{
	/// <summary>
	/// An AI component, that controls a monster.
	/// </summary>
	public class MonsterAi : IUpdatableComponent
	{
		private IRoutine _currentRoutine;
		private IntPtr L;

		private readonly Random _rnd = new Random(RandomProvider.GetSeed());

		/// <summary>
		/// Returns the monster this AI belongs to.
		/// </summary>
		public Monster Monster { get; }

		/// <summary>
		/// Returns the position of the monster when the AI was
		/// created.
		/// </summary>
		public Position InitialPosition { get; private set; }

		/// <summary>
		/// Creates AI for monster.
		/// </summary>
		/// <param name="monster"></param>
		/// <param name="aiName"></param>
		public MonsterAi(Monster monster, string aiName)
		{
			this.Monster = monster;
			this.InitialPosition = monster.Position;

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
				Log.Error("MonsterAi: AI script '{0}' not found.", aiName);
				return;
			}

			L = luaL_newstate();

			melua_openlib(L, new[]
			{
				new LuaLib("", meluaopen_basesafe),
				new LuaLib("table", luaopen_table),
				new LuaLib("string", luaopen_string),
				new LuaLib("math", luaopen_math),
			});

			lua_atpanic(L, CreateFunctionReference(L, this.OnPanic));

			this.RegisterScriptFunctions();

			if (!this.LoadScript("system/scripts/ai/shared.lua"))
			{
				L = IntPtr.Zero;
				return;
			}

			if (!this.LoadScript(filePath))
			{
				L = IntPtr.Zero;
				return;
			}
		}

		/// <summary>
		/// Loads the script at the given path, returns false if loading
		/// failed.
		/// </summary>
		/// <param name="filePath"></param>
		/// <returns></returns>
		private bool LoadScript(string filePath)
		{
			var loadResult = luaL_loadfile(L, filePath);
			if (loadResult != 0)
			{
				Log.Error("MonsterAi: Failed to read script. Error: {0}", lua_tostring(L, -1));
				L = IntPtr.Zero;
				return false;
			}

			var callResult = lua_pcall(L, 0, 0, 0);
			if (callResult != 0)
			{
				Log.Error("MonsterAi: Failed to load script. Error: {0}", lua_tostring(L, -1));
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
					melua_register(L, attr.Name, CreateFunctionReference(L, func));
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
		/// Updates the AI, executing one tick.
		/// </summary>
		/// <param name="elapsed"></param>
		public void Update(TimeSpan elapsed)
		{
			// Don't do anything if the scripts weren't loaded successfully.
			if (L == IntPtr.Zero)
				return;

			// If no routine is active, start the current state function,
			// which should create routines.
			if (_currentRoutine == null)
			{
				lua_getglobal(L, "idle");
				if (!lua_isfunction(L, -1))
				{
					Log.Error("MonsterAi: Idle function not defined.");
					lua_settop(L, 0);
					return;
				}

				var stateResult = lua_resume(L, 0);
				if (stateResult != 0 && stateResult != LUA_YIELD)
				{
					Log.Error("MonsterAi: Error while exuting state function: {0}", lua_tostring(L, -1));
					lua_settop(L, 0);
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
			var result = lua_resume(L, 0);
			if (result != 0 && result != LUA_YIELD)
			{
				Log.Error("MonsterAi: Error while advancing state: {0}", lua_tostring(L, -1));
				lua_settop(L, 0);
			}
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
		/// Start Wait routine.
		/// </summary>
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
		/// Starts Wander routine.
		/// </summary>
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
			var pos = this.Monster.Position;

			for (var i = 0; i < 50; ++i)
			{
				destination = this.InitialPosition.GetRandomInRange2D(maxDistance, _rnd);

				// Skip destination if it's too close the current position
				if (pos.InRange2D(destination, minDistance) || !pos.InRange2D(destination, maxDistance))
					continue;

				// Use the destination if it's valid
				if (this.Monster.Map.Ground.IsValidPosition(destination))
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
		/// Shows emoticon for monster.
		/// </summary>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("emoticon")]
		protected int Emoticon(IntPtr L)
		{
			var emoticonName = luaL_checkstring(L, 1);
			lua_settop(L, 0);

			Send.ZC_SHOW_EMOTICON(this.Monster, emoticonName, 2000);

			return 0;
		}

		/// <summary>
		/// Makes monster say something.
		/// </summary>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("say")]
		protected int Say(IntPtr L)
		{
			var msg = lua_tostring(L, 1);

			lua_settop(L, 0);

			Send.ZC_CHAT(this.Monster, msg);

			return 0;
		}

		/// <summary>
		/// Prints debug message.
		/// </summary>
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
