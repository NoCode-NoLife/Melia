using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Melia.Zone.Scripting
{
	/// <summary>
	/// A collection of functions that can be registered and retrieved by
	/// name.
	/// </summary>
	public interface IDelegateCollection
	{
		/// <summary>
		/// Tries to create and register a function under the given name
		/// from the method. Return false if the attempt failed.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="method"></param>
		/// <returns></returns>
		bool TryRegister(string name, MethodInfo method);
	}

	/// <summary>
	/// A collection of functions that can be registered and retrieved by
	/// name.
	/// </summary>
	/// <typeparam name="TDelegate"></typeparam>
	public class DelegateCollection<TDelegate> : IDelegateCollection where TDelegate : Delegate
	{
		private readonly object _syncLock = new();

		private readonly Dictionary<string, TDelegate> _funcs = new();
		private readonly Dictionary<object, FunctionOverride<TDelegate>> _overrides = new();

		/// <summary>
		/// Registers the function with the given name.
		/// </summary>
		/// <param name="funcName"></param>
		/// <param name="func"></param>
		public void Register(string funcName, TDelegate func)
		{
			lock (_syncLock)
			{
				if (_funcs.TryGetValue(funcName, out var overriddenFunc))
				{
					var funcOverride = new FunctionOverride<TDelegate>(funcName, overriddenFunc, func);
					_overrides[func] = funcOverride;
				}

				_funcs[funcName] = func;
			}
		}

		/// <summary>
		/// Tries to create and register a function under the given name
		/// from the method. Return false if the attempt failed.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="method"></param>
		/// <returns></returns>
		public bool TryRegister(string name, MethodInfo method)
		{
			if (!this.TryCreateDelegate(method, out var func))
				return false;

			this.Register(name, func);
			return true;
		}

		/// <summary>
		/// Returns the function with the given name.
		/// </summary>
		/// <param name="funcName"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">
		/// Thrown if no matching function was found.
		/// </exception>
		public TDelegate Get(string funcName)
		{
			lock (_syncLock)
			{
				if (!_funcs.TryGetValue(funcName, out var func))
					throw new ArgumentException($"Function '{funcName}' not found.");

				return func;
			}
		}

		/// <summary>
		/// Returns the function with the given name via out. Returns false
		/// if no matching function could be found.
		/// </summary>
		/// <param name="funcName"></param>
		/// <param name="func"></param>
		/// <returns></returns>
		public bool TryGet(string funcName, out TDelegate func)
		{
			lock (_syncLock)
				return _funcs.TryGetValue(funcName, out func);
		}

		/// <summary>
		/// Looks up a function that was overridden by the given function
		/// and returns it via out. Returns false if no such function was
		/// found.
		/// </summary>
		/// <remarks>
		/// If a function is registered with the same name as an existing
		/// function, a reference to the overriden function is stored and
		/// can be retrieved via this method. This allows overriding
		/// functions to access the original function, its functionality,
		/// and its results.
		/// </remarks>
		/// <param name="func"></param>
		/// <param name="overriddenFunc"></param>
		/// <returns></returns>
		public bool TryGetOverridden(TDelegate func, out TDelegate overriddenFunc)
		{
			lock (_syncLock)
			{
				if (_overrides.TryGetValue(func, out var funcOverride))
				{
					overriddenFunc = funcOverride.OverriddenFunc;
					return true;
				}
			}

			overriddenFunc = null;
			return false;
		}

		/// <summary>
		/// Looks up the oldest function that was overriden by the given
		/// function and its earlier overrides and returns it via out.
		/// Returns false if there's no overrides.
		/// </summary>
		/// <remarks>
		/// If a function is registered with the same name as an existing
		/// function, a reference to the overriden function is stored and
		/// can be retrieved via <see cref="TryGetOverridden"/>. By looping
		/// through the chain of overrides, the original function can be
		/// found, which this method is a shortcut for.
		/// 
		/// A potential application of this method is looking up the
		/// original core scriptable function, to get the original
		/// functionality and results.
		/// </remarks>
		/// <param name="func"></param>
		/// <param name="originalFunc"></param>
		/// <returns></returns>
		public bool TryGetOriginal(TDelegate func, out TDelegate originalFunc)
		{
			originalFunc = null;

			while (this.TryGetOverridden(func, out var overriddenFunc))
			{
				originalFunc = overriddenFunc;
				func = overriddenFunc;
			}

			return originalFunc != null;
		}

		/// <summary>
		/// Removes the function with the given name.
		/// </summary>
		/// <param name="funcName"></param>
		public void Remove(string funcName)
		{
			lock (_syncLock)
			{
				_funcs.Remove(funcName);

				var overrides = _overrides.Values.Where(a => a.Name == funcName);
				foreach (var overrideEntry in overrides)
					_overrides.Remove(overrideEntry.NewFunc);
			}
		}

		/// <summary>
		/// Removes all functions.
		/// </summary>
		public void Clear()
		{
			lock (_syncLock)
			{
				_funcs.Clear();
				_overrides.Clear();
			}
		}

		/// <summary>
		/// Returns true if this collection manages methods with the given
		/// signature.
		/// </summary>
		/// <param name="method"></param>
		/// <returns></returns>
		public bool CheckSignature(MethodInfo method)
		{
			var delegateType = typeof(TDelegate);
			var invokeInfo = delegateType.GetMethod("Invoke");

			if (method.ReturnType != invokeInfo.ReturnType)
				return false;

			var parameters = method.GetParameters();
			var invokeParameters = invokeInfo.GetParameters();

			if (parameters.Length != invokeParameters.Length)
				return false;

			for (var i = 0; i < parameters.Length; ++i)
			{
				if (parameters[i].ParameterType != invokeParameters[i].ParameterType)
					return false;
			}

			return true;
		}

		/// <summary>
		/// Checks method's signature against the delegate type and creates
		/// the delegate if it matches, returning it via out. Returns false
		/// if signature didn't match.
		/// </summary>
		/// <param name="method"></param>
		/// <param name="func"></param>
		/// <returns></returns>
		private bool TryCreateDelegate(MethodInfo method, out TDelegate func)
		{
			if (!this.CheckSignature(method))
			{
				func = null;
				return false;
			}

			func = (TDelegate)Delegate.CreateDelegate(typeof(TDelegate), null, method);
			return true;
		}
	}

	/// <summary>
	/// Information about a function override.
	/// </summary>
	/// <typeparam name="TDelegate"></typeparam>
	internal class FunctionOverride<TDelegate> where TDelegate : Delegate
	{
		/// <summary>
		/// Returns the shared reference name of the function that was overridden.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Returns a reference to the original function that was overridden.
		/// </summary>
		public TDelegate OverriddenFunc { get; set; }

		/// <summary>
		/// Returns a reference to the new function that overrides the original one.
		/// </summary>
		public TDelegate NewFunc { get; set; }

		/// <summary>
		/// Creates new instance.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="originalFunc"></param>
		/// <param name="newFunc"></param>
		public FunctionOverride(string name, TDelegate originalFunc, TDelegate newFunc)
		{
			this.Name = name;
			this.OverriddenFunc = originalFunc;
			this.NewFunc = newFunc;
		}

		/// <summary>
		/// Returns a string representation of the function override,
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return $"{this.NewFunc.Method.Name} : {this.OverriddenFunc.Method.Name} ({this.Name})";
		}
	}
}
