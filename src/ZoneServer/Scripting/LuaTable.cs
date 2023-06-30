using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Melia.Zone.Scripting
{
	public class LuaTableEntry
	{
		public object Key { get; set; }
		public object Value { get; set; }

		public LuaTableEntry(object key, object value)
		{
			this.Key = key;
			this.Value = value;
		}
	}

	public class LuaTable
	{
		private readonly List<LuaTableEntry> _indexedEntries = new List<LuaTableEntry>();
		private readonly List<LuaTableEntry> _namedEntries = new List<LuaTableEntry>();

		public void Insert(object value)
		{
			var key = _indexedEntries.Count + 1;
			_indexedEntries.Add(new LuaTableEntry(key, value));
		}

		public void Insert(int index, object value)
		{
			_indexedEntries.Insert(index, new LuaTableEntry(0, value));

			for (var i = index; i < _indexedEntries.Count; ++i)
				_indexedEntries[i].Key = i + 1;
		}

		public void Insert(string key, object value)
		{
			_namedEntries.Add(new LuaTableEntry(key, value));
		}

		public void Clear()
		{
			_indexedEntries.Clear();
			_namedEntries.Clear();
		}

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

		public string Serialize()
		{
			var sb = new StringBuilder();

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

			return sb.ToString();
		}

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

		public IEnumerable<LuaTableEntry> Pairs()
		{
			foreach (var entry in _indexedEntries)
				yield return entry;

			foreach (var entry in _namedEntries)
				yield return entry;
		}

		public IEnumerable<LuaTableEntry> IPairs()
		{
			foreach (var entry in _indexedEntries)
				yield return entry;
		}
	}
}
