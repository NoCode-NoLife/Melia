using System;
using System.Collections.Generic;
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
		private readonly Dictionary<string, TDelegate> _funcs = new();

		/// <summary>
		/// Registers the function with the given name.
		/// </summary>
		/// <param name="funcName"></param>
		/// <param name="func"></param>
		public void Register(string funcName, TDelegate func)
		{
			lock (_funcs)
				_funcs[funcName] = func;
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
			lock (_funcs)
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
			lock (_funcs)
				return _funcs.TryGetValue(funcName, out func);
		}

		/// <summary>
		/// Removes the function with the given name.
		/// </summary>
		/// <param name="funcName"></param>
		public void Remove(string funcName)
		{
			lock (_funcs)
				_funcs.Remove(funcName);
		}

		/// <summary>
		/// Removes all functions.
		/// </summary>
		public void Clear()
		{
			lock (_funcs)
				_funcs.Clear();
		}

		/// <summary>
		/// Returns true if the method has the given signature.
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
}
