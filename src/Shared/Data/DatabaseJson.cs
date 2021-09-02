// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data
{
	/// <summary>
	/// Base class for JSON databases
	/// </summary>
	/// <typeparam name="TList"></typeparam>
	/// <typeparam name="TInfo"></typeparam>
	public abstract class DatabaseJsonBase<TList, TInfo> : DatabaseBase<TList, TInfo>
		where TInfo : class, new()
		where TList : ICollection, new()
	{
		protected override void LoadFromFile(string path)
		{
			using (var fs = new StreamReader(path))
			using (var reader = new JsonTextReader(fs))
			{
				try
				{
					var array = JArray.Load(reader);

					foreach (var entry in array)
					{
						var obj = entry as JObject;
						if (obj == null) continue;

						try
						{
							this.ReadEntry(obj);
						}
						catch (MandatoryValueException ex)
						{
							this.Warnings.Add(new MandatoryValueException(path, ex.Key, obj));
							continue;
						}
						catch (DatabaseWarningException ex)
						{
							this.Warnings.Add(new DatabaseWarningException(ex.Message + ", in " + Environment.NewLine + obj.ToString(), path));
							continue;
						}
						catch (OverflowException)
						{
							this.Warnings.Add(new DatabaseWarningException("Number to big or too small for variable, in " + Environment.NewLine + obj.ToString(), path));
							continue;
						}
					}
				}
				catch (JsonReaderException ex)
				{
					// Throw to stop the server, databases depend on each
					// other, skipping one could lead to problems.
					throw new DatabaseErrorException(ex.Message, path);
				}
			}
		}

		protected abstract void ReadEntry(JObject entry);
	}

	/// <summary>
	/// JSON database holding a data list
	/// </summary>
	/// <typeparam name="TInfo">Data type</typeparam>
	public abstract class DatabaseJson<TInfo> : DatabaseJsonBase<List<TInfo>, TInfo> where TInfo : class, new()
	{
		public override IEnumerator<TInfo> GetEnumerator()
		{
			return ((IEnumerable<TInfo>)this.Entries).GetEnumerator();
		}

		public override void Clear()
		{
			this.Entries.Clear();
		}
	}

	/// <summary>
	/// JSON database holding a data dictionary
	/// </summary>
	/// <typeparam name="TIndex">Type of the dictionary key</typeparam>
	/// <typeparam name="TInfo">Data type</typeparam>
	public abstract class DatabaseJsonIndexed<TIndex, TInfo> : DatabaseJsonBase<Dictionary<TIndex, TInfo>, TInfo> where TInfo : class, new()
	{
		public override IEnumerator<TInfo> GetEnumerator()
		{
			return ((IEnumerable<TInfo>)this.Entries.Values).GetEnumerator();
		}

		public TInfo Find(TIndex key)
		{
			return this.Entries.GetValueOrDefault(key);
		}

		public bool TryFind(TIndex key, out TInfo info)
		{
			return this.Entries.TryGetValue(key, out info);
		}

		public bool Exists(TIndex key)
		{
			return this.Entries.ContainsKey(key);
		}

		public override void Clear()
		{
			this.Entries.Clear();
		}
	}

	public class MandatoryValueException : DatabaseWarningException
	{
		public string Key { get; private set; }

		public MandatoryValueException(string path, string key, JObject obj)
			: base("Missing mandatory value '" + key + "', in " + Environment.NewLine + obj.ToString(), path)
		{
			this.Key = key;
		}
	}

	internal static class JsonExtensions
	{
		internal static bool ReadBool(this JObject obj, string key, bool def = false) { return (bool)(obj[key] ?? def); }
		internal static byte ReadByte(this JObject obj, string key, byte def = 0) { return (byte)(obj[key] ?? def); }
		internal static sbyte ReadSByte(this JObject obj, string key, sbyte def = 0) { return (sbyte)(obj[key] ?? def); }
		internal static short ReadShort(this JObject obj, string key, short def = 0) { return (short)(obj[key] ?? def); }
		internal static ushort ReadUShort(this JObject obj, string key, ushort def = 0) { return (ushort)(obj[key] ?? def); }
		internal static int ReadInt(this JObject obj, string key, int def = 0) { return (int)(obj[key] ?? def); }
		internal static uint ReadUInt(this JObject obj, string key, uint def = 0) { return (uint)(obj[key] ?? def); }
		internal static long ReadLong(this JObject obj, string key, long def = 0) { return (long)(obj[key] ?? def); }
		internal static ulong ReadULong(this JObject obj, string key, ulong def = 0) { return (ulong)(obj[key] ?? def); }
		internal static float ReadFloat(this JObject obj, string key, float def = 0) { return (float)(obj[key] ?? def); }
		internal static double ReadDouble(this JObject obj, string key, double def = 0) { return (double)(obj[key] ?? def); }
		internal static string ReadString(this JObject obj, string key, string def = "") { return (string)(obj[key] ?? def); }

		/// <summary>
		/// Reads the array with the given key from the object and returns
		/// its values as an array of the given type. If the key doesn't
		/// exist, the default value is returned. If the default value is
		/// null, instead of null, an empty list is returned.
		/// </summary>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="obj"></param>
		/// <param name="key"></param>
		/// <param name="def"></param>
		/// <returns></returns>
		internal static TValue[] ReadArray<TValue>(this JObject obj, string key, TValue[] def = null)
		{
			if (!obj.ContainsKey(key))
				return def ?? new TValue[0];

			return obj[key].Select(a => a.ToObject<TValue>()).ToArray();
		}

		/// <summary>
		/// Reads the array with the given key from the object and returns
		/// its values as a list. If the key doesn't exist, the default
		/// value is returned. If the default value is null, instead of
		/// null, an empty list is returned.
		/// </summary>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="obj"></param>
		/// <param name="key"></param>
		/// <param name="def"></param>
		/// <returns></returns>
		internal static List<TValue> ReadList<TValue>(this JObject obj, string key, List<TValue> def = null)
		{
			if (!obj.ContainsKey(key))
				return def ?? new List<TValue>();

			return obj[key].Select(a => a.ToObject<TValue>()).ToList();
		}

		/// <summary>
		/// Reads the field's value as a string and attempts to convert
		/// it to the enum. Returns the default if the key didn't exist.
		/// </summary>
		/// <typeparam name="TEnum"></typeparam>
		/// <param name="obj"></param>
		/// <param name="key"></param>
		/// <param name="def"></param>
		/// <returns></returns>
		internal static TEnum ReadEnum<TEnum>(this JObject obj, string key, TEnum def = default(TEnum))
		{
			if (!obj.ContainsKey(key))
				return def;

			var str = obj.ReadString(key);

			return (TEnum)Enum.Parse(typeof(TEnum), str);
		}

		/// <summary>
		/// Returns true if the object contains any of the given keys.
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="keys"></param>
		/// <returns></returns>
		internal static bool ContainsAnyKeys(this JObject obj, params string[] keys)
		{
			if (keys.Length == 1)
				return (obj[keys[0]] != null);

			return keys.Any(key => obj[key] != null);
		}

		/// <summary>
		/// Returns true if object contains all keys.
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="keys"></param>
		/// <returns></returns>
		internal static bool ContainsKeys(this JObject obj, params string[] keys)
		{
			if (keys.Length == 1)
				return (obj[keys[0]] != null);

			return keys.All(key => obj[key] != null);
		}

		/// <summary>
		/// Returns true if object containes key.
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		internal static bool ContainsKey(this JObject obj, string key)
		{
			return (obj[key] != null);
		}

		/// <summary>
		/// Throws exception if one of the keys is missing from the object.
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="keys"></param>
		/// <exception cref="MandatoryValueException"></exception>
		internal static void AssertNotMissing(this JObject obj, params string[] keys)
		{
			foreach (var key in keys)
			{
				if (obj[key] == null)
					throw new MandatoryValueException(null, key, obj);
			}
		}
	}
}
