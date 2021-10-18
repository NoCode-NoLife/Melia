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
		/// Makes entity walk to a random position in its spawn area.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - int  minDistance  Minimum distance to walk. (optional)
		/// - int  maxDistance  Maximum distance to walk. (optional)
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("wander")]
		protected int Wander(IntPtr L)
		{
			var minDistance = 30;
			var maxDistance = 50;

			if (lua_gettop(L) > 0)
				minDistance = luaL_checkinteger(L, 1);

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
		/// Makes entity move to a specific position.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - number  x  Position to move to on the X axis.
		/// - number  z  Position to move to on the Z axis.
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("moveto")]
		protected int MoveTo(IntPtr L)
		{
			var x = (float)luaL_checknumber(L, 1);
			var z = (float)luaL_checknumber(L, 2);
			lua_settop(L, 0);

			var destination = new Position(x, 0, z);

			if (this.Entity.Map.Ground.IsValidPosition(destination))
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
		/// Makes entity move a certain distance, relative to its current
		/// position.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - number  x  Distance to move on the X axis.
		/// - number  z  Distance to move on the Z axis.
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("moverel")]
		protected int MoveRelative(IntPtr L)
		{
			var addX = (float)luaL_checknumber(L, 1);
			var addZ = (float)luaL_checknumber(L, 2);
			lua_settop(L, 0);

			var destination = this.Entity.Position;
			destination.X += addX;
			destination.Z += addZ;

			if (this.Entity.Map.Ground.IsValidPosition(destination))
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
		/// Makes entity move a certain distance in a random direction.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - number  radius  Distance to move.
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("movernd")]
		protected int MoveRandom(IntPtr L)
		{
			var radius = (float)luaL_checknumber(L, 1);
			lua_settop(L, 0);

			var destination = this.Entity.Position.GetRandomInRange2D((int)radius, _rnd);

			if (this.Entity.Map.Ground.IsValidPosition(destination))
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
		/// - number  min  Minimum value. (optional)
		/// - number  max  Maximum value - 1. (optional)
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

		/// <summary>
		/// Makes entity turn in a random direction.
		/// </summary>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("turnrnd")]
		protected int TurnRandom(IntPtr L)
		{
			// Official monsters seem to only randomly turn in the 4 major
			// directions.
			var angle = _rnd.Next(0, 4) * 90;
			var dir = new Direction(angle);

			// Should Entity really have Rotate? We might want a new
			// interface for "creatures", entities that walk around,
			// and are different from, say item monsters.
			//this.Entity.Rotate(dir); 

			this.Entity.Direction = dir;
			Send.ZC_ROTATE(this.Entity);

			return lua_yield(L, 0);
		}

		/// <summary>
		/// Makes entity turn in a specific direction.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - number  direction  Direction to turn to, between 0 and 7.
		/// </remarks>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("turndir")]
		protected int TurnDirection(IntPtr L)
		{
			var dirIndex = luaL_checknumber(L, 1) % 8;
			lua_settop(L, 0);

			var dir = new Direction(dirIndex * 45);

			this.Entity.Direction = dir;
			Send.ZC_ROTATE(this.Entity);

			return lua_yield(L, 0);
		}

		/// <summary>
		/// Makes entity turn to the given entity.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - int  handle  Handle of the entity to turn to. (optional)
		/// </remarks>
		/// <example>
		/// turnaway()
		/// turnaway(TARGET)
		/// </example>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("turnto")]
		protected int TurnTo(IntPtr L)
		{
			var handle = lua_gettop(L) >= 1 ? luaL_checkinteger(L, 1) : this.GetOtherEntityHandle();
			lua_settop(L, 0);

			handle = this.ResolveHandle(handle);

			if (handle != 0 && this.Entity.Map.TryGetCombatEntity(handle, out var otherEntity))
			{
				var dir = this.Entity.Position.GetDirection(otherEntity.Position);

				this.Entity.Direction = dir;
				Send.ZC_ROTATE(this.Entity);
			}

			return lua_yield(L, 0);
		}

		/// <summary>
		/// Makes entity turn away from the given entity.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - int  handle  Handle of the entity to turn away from. (optional)
		/// </remarks>
		/// <example>
		/// turnaway()
		/// turnaway(TARGET)
		/// </example>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("turnaway")]
		protected int TurnAway(IntPtr L)
		{
			var handle = lua_gettop(L) >= 1 ? luaL_checkinteger(L, 1) : this.GetOtherEntityHandle();
			lua_settop(L, 0);

			handle = this.ResolveHandle(handle);

			if (handle != 0 && this.Entity.Map.TryGetCombatEntity(handle, out var otherEntity))
			{
				var dir = otherEntity.Position.GetDirection(this.Entity.Position);

				this.Entity.Direction = dir;
				Send.ZC_ROTATE(this.Entity);
			}

			return lua_yield(L, 0);
		}

		/// <summary>
		/// Makes entity turn away from the given entity.
		/// </summary>
		/// <remarks>
		/// Arguments:
		/// - int  handle  Handle of the entity to follow. (optional)
		/// - int  maxDistance  Maximum distance the target entity may be away.
		/// </remarks>
		/// <example>
		/// follow(50)
		/// follow(TARGET, 50)
		/// </example>
		/// <param name="L"></param>
		/// <returns></returns>
		[ScriptFunction("follow")]
		protected int Follow(IntPtr L)
		{
			var argc = lua_gettop(L);

			int handle, maxDistance;
			if (argc >= 2)
			{
				handle = luaL_checkinteger(L, 1);
				maxDistance = luaL_checkinteger(L, 2);
			}
			else
			{
				handle = this.GetOtherEntityHandle();
				maxDistance = luaL_checkinteger(L, 1);
			}

			lua_settop(L, 0);

			handle = this.ResolveHandle(handle);

			if (handle != 0 && this.Entity.Map.TryGetCombatEntity(handle, out var otherEntity))
			{
				if (!this.Entity.Position.InRange2D(otherEntity.Position, maxDistance))
				{
					var dest = this.Entity.Position.GetRelative(otherEntity.Position, -maxDistance + 10);
					if (this.Entity.Components.TryGet<Movement>(out var component))
						component.MoveTo(dest);
				}
			}

			return lua_yield(L, 0);
		}
	}
}
