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
			melua_opensafelibs(L);

			lua_atpanic(L, CreateFunctionReference(L, this.OnPanic));

			this.RegisterScriptFunctions();

			var loadResult = luaL_loadfile(L, filePath);
			if (loadResult != 0)
			{
				Log.Error("MonsterAi: Failed to load AI script. Error: {0}", lua_tostring(L, -1));
				L = IntPtr.Zero;
				return;
			}

			var callResult = lua_pcall(L, 0, 0, 0);
			if (callResult != 0)
			{
				Log.Error("MonsterAi: Failed to load AI script. Error: {0}", lua_tostring(L, -1));
				L = IntPtr.Zero;
				return;
			}
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

			if (_currentRoutine == null)
				return;

			var routineResult = _currentRoutine.Execute(elapsed);
			switch (routineResult)
			{
				// Keep going while the routine is still running
				case RoutineResult.Running:
					return;

				// Clear routine and advance state to get the next
				// routine
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

			var result = lua_resume(L, 0);
			if (result != 0 && result != LUA_YIELD)
			{
				Log.Error("MonsterAi: Error while advancing state: {0}", lua_tostring(L, -1));
				lua_settop(L, 0);
				return;
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

			var rnd = RandomProvider.Get();
			var waitTimeMs = rnd.Next(min, max + 1);

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

			var rnd = RandomProvider.Get();
			var distance = rnd.Next(minDistance, maxDistance + 1);

			// Try to find a valid random destination. If we can't find
			// one in a reasonable amount of time, just let the AI wait
			// for a moment.
			var destination = Position.Zero;
			var validDest = false;

			for (var i = 0; i < 50; ++i)
			{
				destination = this.InitialPosition.GetRandomInRange2D(distance, rnd);

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

			return lua_yield(L, 0);
		}

		/// <summary>
		/// Prints debug message.
		/// </summary>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("logdebug")]
		protected int LogDebug(IntPtr L)
		{
			var msg = luaL_checkstring(L, 1);
			lua_settop(L, 0);

			Log.Debug(msg);

			return 0;
		}
	}
}
