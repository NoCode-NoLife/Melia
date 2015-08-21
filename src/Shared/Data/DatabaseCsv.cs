// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Melia.Shared.Data
{
	/// <summary>
	/// CSV database base class
	/// </summary>
	/// <typeparam name="TList">Type of the list managed by this database</typeparam>
	/// <typeparam name="TInfo">Data type</typeparam>
	public abstract class DatabaseCsvBase<TList, TInfo> : DatabaseBase<TList, TInfo>
		where TInfo : class, new()
		where TList : ICollection, new()
	{
		private int _min;

		protected DatabaseCsvBase()
		{
			var attr = this.GetType().GetMethod("ReadEntry", BindingFlags.NonPublic | BindingFlags.Instance).GetCustomAttributes(typeof(MinFieldCountAttribute), true);
			if (attr.Length > 0)
				_min = (attr[0] as MinFieldCountAttribute).Count;
		}

		protected override void LoadFromFile(string path)
		{
			using (var csv = new CsvReader(path))
			{
				foreach (var entry in csv.Next())
				{
					try
					{
						if (entry.Count < _min)
							throw new FieldCountException(_min, entry.Count);

						this.ReadEntry(entry);
					}
					catch (CsvDatabaseWarningException ex)
					{
						ex.Line = entry.Line;
						ex.Source = path.Replace("\\", "/");
						this.Warnings.Add(ex);
						continue;
					}
					catch (OverflowException)
					{
						this.Warnings.Add(new CsvDatabaseWarningException(Path.GetFileName(path), entry.Line, "Variable not fit for number (#{0}).", entry.Pointer));
						continue;
					}
					catch (FormatException)
					{
						this.Warnings.Add(new CsvDatabaseWarningException(Path.GetFileName(path), entry.Line, "Number format exception."));
						continue;
					}
				}
			}
		}

		protected abstract void ReadEntry(CsvEntry entry);
	}

	/// <summary>
	/// CSV database holding a data list
	/// </summary>
	/// <typeparam name="TInfo">Data type</typeparam>
	public abstract class DatabaseCsv<TInfo> : DatabaseCsvBase<List<TInfo>, TInfo> where TInfo : class, new()
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
	/// CSV database holding a data dictionary
	/// </summary>
	/// <typeparam name="TIndex">Type of the dictionary key</typeparam>
	/// <typeparam name="TInfo">Data type</typeparam>
	public abstract class DatabaseCsvIndexed<TIndex, TInfo> : DatabaseCsvBase<Dictionary<TIndex, TInfo>, TInfo> where TInfo : class, new()
	{
		public override IEnumerator<TInfo> GetEnumerator()
		{
			return ((IEnumerable<TInfo>)this.Entries.Values).GetEnumerator();
		}

		public TInfo Find(TIndex key)
		{
			return this.Entries.GetValueOrDefault(key);
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

	public class MinFieldCountAttribute : Attribute
	{
		public int Count { get; protected set; }

		public MinFieldCountAttribute(int count)
		{
			this.Count = count;
		}
	}
}
