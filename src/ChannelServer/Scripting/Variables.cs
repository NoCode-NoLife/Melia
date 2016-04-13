// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Melia.Channel.Scripting
{
	public class Variables
	{
		public VariableManager Temp { get; set; }
		public VariableManager Perm { get; set; }

		public Variables()
		{
			this.Temp = new VariableManager();
			this.Perm = new VariableManager();
		}
	}

	/// <summary>
	/// Dynamic variable manager, primarily for scripting.
	/// </summary>
	public class VariableManager
	{
		private Dictionary<string, object> _variables;

		/// <summary>
		/// Last time a variable was changed.
		/// </summary>
		public DateTime LastChange { get; private set; }

		/// <summary>
		/// Creates new variable manager.
		/// </summary>
		public VariableManager()
		{
			_variables = new Dictionary<string, object>();
		}

		/// <summary>
		/// Creates new variable manager and adds the given values.
		/// </summary>
		public VariableManager(IDictionary<string, object> values)
		{
			_variables = new Dictionary<string, object>(values);
		}

		/// <summary>
		/// Sets given variables.
		/// </summary>
		/// <param name="values"></param>
		public void Load(IDictionary<string, object> values)
		{
			lock (_variables)
			{
				foreach (var value in values)
					_variables[value.Key] = value.Value;
			}
		}

		/// <summary>
		/// Returns list of all variables as KeyValue collection.
		/// </summary>
		/// <returns></returns>
		public IDictionary<string, object> GetList()
		{
			lock (_variables)
				return new Dictionary<string, object>(_variables);
		}

		/// <summary>
		/// Variable access by string.
		/// </summary>
		/// <param name="key">Variable name</param>
		/// <returns></returns>
		public object this[string key]
		{
			get
			{
				object result;
				lock (_variables)
					_variables.TryGetValue(key, out result);
				return result;
			}
			set
			{
				lock (_variables)
				{
					_variables[key] = value;
					this.LastChange = DateTime.Now;
				}
			}
		}

		/// <summary>
		/// Returns the value for key, or def if variable doesn't exist.
		/// </summary>
		/// <typeparam name="T">Type to cast variable to.</typeparam>
		/// <param name="key">Variable name</param>
		/// <returns></returns>
		/// <exception cref="InvalidCastException">
		/// Thrown if variable is not of the expected type.
		/// </exception>
		public T Get<T>(string key, T def)
		{
			object result;
			lock (_variables)
			{
				if (!_variables.TryGetValue(key, out result))
					return def;
			}
			return (T)result;
		}
	}
}
