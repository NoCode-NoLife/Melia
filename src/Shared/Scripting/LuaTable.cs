using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Melia.Shared.Scripting
{
	/// <summary>
	/// An entry in a Lua table.
	/// </summary>
	public class LuaTableEntry
	{
		/// <summary>
		/// Returns the identifier of the entry, either an integer or a
		/// string.
		/// </summary>
		public object Key { get; set; }

		/// <summary>
		/// Returns the value of the entry.
		/// </summary>
		public object Value { get; set; }

		/// <summary>
		/// Creates new entry.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public LuaTableEntry(object key, object value)
		{
			this.Key = key;
			this.Value = value;
		}
	}

	/// <summary>
	/// A table with a series of arbitrarily typed values that are indexed
	/// by either integers or strings.
	/// </summary>
	public class LuaTable
	{
		private readonly List<LuaTableEntry> _indexedEntries = new List<LuaTableEntry>();
		private readonly List<LuaTableEntry> _namedEntries = new List<LuaTableEntry>();

		private string _serialized;
		private bool _dirty = true;

		/// <summary>
		/// Returns the string size of the serialized table.
		/// </summary>
		public int SerializedSize => this.Serialize().Length;

		/// <summary>
		/// Adds value to the end of the table with a numeric index.
		/// </summary>
		/// <param name="value"></param>
		public void Insert(object value)
		{
			var key = _indexedEntries.Count + 1;

			_indexedEntries.Add(new LuaTableEntry(key, value));
			_dirty = true;
		}

		/// <summary>
		/// Inserts value at the specified numeric index.
		/// </summary>
		/// <param name="index"></param>
		/// <param name="value"></param>
		public void Insert(int index, object value)
		{
			_indexedEntries.Insert(index, new LuaTableEntry(0, value));

			for (var i = index; i < _indexedEntries.Count; ++i)
				_indexedEntries[i].Key = i + 1;

			_dirty = true;
		}

		/// <summary>
		/// Adds value under the given string key.
		/// </summary>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public void Insert(string key, object value)
		{
			_namedEntries.Add(new LuaTableEntry(key, value));
			_dirty = true;
		}

		/// <summary>
		/// Removes all values from the table.
		/// </summary>
		public void Clear()
		{
			_indexedEntries.Clear();
			_namedEntries.Clear();

			_dirty = true;
		}

		/// <summary>
		/// Returns the value with the given key from the table.
		/// Returns null if key is a string that no value was found
		/// for.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Thrown if a numeric key is outside the range of the integer
		/// indexed values of the table.
		/// </exception>
		/// <exception cref="ArgumentException"><
		/// Thrown if key type is neither an integer nor a string.
		/// /exception>
		public object this[object key]
		{
			get
			{
				switch (key)
				{
					case int index:
					{
						if (index < 0 || index >= _indexedEntries.Count)
							throw new ArgumentOutOfRangeException();

						return _indexedEntries[index].Value;
					}
					case string name:
					{
						var entry = _namedEntries.FirstOrDefault(a => a.Key.ToString() == name);
						return entry?.Value;
					}

					default: throw new ArgumentException($"Unsupported key type: {key.GetType().Name}");
				}
			}
		}

		/// <summary>
		/// Serializes the table into a Lua string.
		/// </summary>
		/// <returns></returns>
		public string Serialize()
		{
			if (_dirty || _serialized == null)
			{
				var sb = new StringBuilder();

				if (_indexedEntries.Count == 0 && _namedEntries.Count == 0)
				{
					sb.Append("{}");
				}
				else
				{
					sb.Append("{ ");

					foreach (var entry in _indexedEntries)
					{
						var index = (int)entry.Key;
						var value = this.SerializeValue(entry.Value);

						sb.AppendFormat("[{0}] = {1}, ", index, value);
					}

					foreach (var entry in _namedEntries)
					{
						var index = entry.Key.ToString();
						var value = this.SerializeValue(entry.Value);

						sb.AppendFormat("[\"{0}\"] = {1}, ", index, value);
					}

					sb.Remove(sb.Length - 2, 2);
					sb.Append(" }");
				}

				_serialized = sb.ToString();
				_dirty = false;
			}

			return _serialized;
		}

		/// <summary>
		/// Serializes the given value for use in a Lua string.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		private string SerializeValue(object value)
		{
			switch (value)
			{
				case null: return "nil";
				case bool boolVal: return boolVal ? "true" : "false";
				case int intVal: return intVal.ToString();
				case float floatVal: return floatVal.ToString("g", CultureInfo.InvariantCulture);
				case double doubleVal: return doubleVal.ToString("g", CultureInfo.InvariantCulture);
				case string stringVal: return "\"" + stringVal.Replace("\"", "\\\"") + "\"";
				case LuaTable tableVal: return tableVal.Serialize();
			}

			throw new ArgumentException($"Unsupported type: {value.GetType().Name}");
		}

		/// <summary>
		/// Iterates over all entries in the table.
		/// </summary>
		/// <returns></returns>
		public IEnumerable<LuaTableEntry> Pairs()
		{
			foreach (var entry in _indexedEntries)
				yield return entry;

			foreach (var entry in _namedEntries)
				yield return entry;
		}

		/// <summary>
		/// Iterates over all integer indexed entries in the table.
		/// </summary>
		/// <returns></returns>
		public IEnumerable<LuaTableEntry> IPairs()
		{
			foreach (var entry in _indexedEntries)
				yield return entry;
		}
	}
}
