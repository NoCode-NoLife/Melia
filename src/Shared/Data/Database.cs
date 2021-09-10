using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MsgPack.Serialization;

namespace Melia.Shared.Data
{
	public interface IDatabase
	{
		/// <summary>
		/// Amount of entries.
		/// </summary>
		int Count { get; }

		/// <summary>
		/// Removes all entries.
		/// </summary>
		void Clear();

		/// <summary>
		/// Loads file if it exists, raises exception otherwise.
		/// </summary>
		/// <param name="path">File to load</param>
		/// <param name="clear">Clear database before loading?</param>
		/// <returns></returns>
		int Load(string path, bool clear);

		/// <summary>
		/// Loads multiple files, ignores missing ones.
		/// </summary>
		/// <param name="files">Files to load</param>
		/// <param name="cache">Path to an optional cache file (null for none)</param>
		/// <param name="clear">Clear database before loading?</param>
		/// <returns></returns>
		int Load(string[] files, string cache, bool clear);

		/// <summary>
		/// List of exceptions caught while loading the database.
		/// </summary>
		List<DatabaseWarningException> Warnings { get; }
	}

	public abstract class Database<TList, TInfo> : IDatabase, IEnumerable<TInfo>
		where TInfo : class, new()
		where TList : ICollection, new()
	{
		public TList Entries = new TList();
		protected List<DatabaseWarningException> _warnings = new List<DatabaseWarningException>();

		public List<DatabaseWarningException> Warnings { get { return _warnings; } }

		public int Count { get { return this.Entries.Count; } }

		public abstract void Clear();

		public abstract int Load(string path, bool clear);
		public abstract int Load(string[] files, string cache, bool clear);

		public abstract IEnumerator<TInfo> GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}
	}

	public abstract class DatabaseBase<TList, TInfo> : Database<TList, TInfo>
		where TInfo : class, new()
		where TList : ICollection, new()
	{
		public override int Load(string path, bool clear)
		{
			if (clear)
				this.Clear();

			this.Warnings.Clear();

			this.LoadFromFile(path);

			return this.Entries.Count;
		}

		public override int Load(string[] files, string cache, bool clear)
		{
			if (clear)
				this.Clear();

			this.Warnings.Clear();

			var fromFiles = false;
			if (cache == null || !File.Exists(cache))
			{
				fromFiles = true;
			}
			else
			{
				if (files.Any(file => File.GetLastWriteTime(file) > File.GetLastWriteTime(cache)))
				{
					fromFiles = true;
				}
			}

			if (!fromFiles)
			{
				if (!this.LoadFromCache(cache))
					this.LoadFromFiles(files);
			}
			else
			{
				this.LoadFromFiles(files);
				if (cache != null)
					this.CreateCache(cache);
			}

			this.AfterLoad();

			return this.Entries.Count;
		}

		protected void LoadFromFiles(string[] paths)
		{
			foreach (var path in paths.Where(a => File.Exists(a)))
				this.LoadFromFile(path);
		}

		protected bool LoadFromCache(string path)
		{
			try
			{
				using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
				{
					var serializer = MessagePackSerializer.Get<TList>();
					this.Entries = serializer.Unpack(stream);
				}
			}
			catch (IOException)
			{
				// One server trying to read while the other one is still
				// creating the cache.
				return false;
			}
			catch (TypeInitializationException)
			{
				// Hotfix for issue #20 in Aura

				this.Warnings.Add(new DatabaseWarningException("MsgPack failed to deserialize cache. " +
				"This is usually caused by an incorrect version of the MsgPack library. " +
				"Please download and compile the latest version of MsgPack (https://github.com/msgpack/msgpack-cli), " +
				"then place the generated dll in Aura's Lib folder. Lastly, recompile Aura."));

				return false;
			}

			return true;
		}

		protected bool CreateCache(string path)
		{
			// Only create cache if everything went smoothly.
			if (this.Entries.Count > 0 && this.Warnings.Count == 0)
			{
				try
				{
					using (var stream = new FileStream(path, FileMode.OpenOrCreate))
					{
						var serializer = MessagePackSerializer.Get<TList>();
						serializer.Pack(stream, this.Entries);
					}

					return true;
				}
				catch (IOException)
				{
					// Multiple servers trying to create the cache, doesn't matter if one fails.
				}
			}

			return false;
		}

		protected abstract void LoadFromFile(string path);

		protected virtual void AfterLoad() { }
	}
}
