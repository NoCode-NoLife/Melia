using System;
using Melia.Channel.Network;
using Melia.Channel.World.Entities.Components.AI;
using Melia.Channel.World.Entities.Components.AI.Events;
using Melia.Channel.World.Entities.Components.AI.Routines;
using Melia.Shared.Util;
using Melia.Shared.World;
using static MeluaLib.Melua;

namespace Melia.Channel.World.Entities.Components
{
	/// <summary>
	/// Scripting functions for EntityAi.
	/// </summary>
	public partial class EntityAi
	{
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
