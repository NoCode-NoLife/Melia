using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Melia.Shared.Data
{
	/// <summary>
	/// Collection of tags that may classify some of a data object's properties.
	/// </summary>
	public class Tags
	{
		private readonly HashSet<string> _tags = new();
		private readonly ReaderWriterLockSlim _lock = new();

		/// <summary>
		/// Creates a new, empty instance.
		/// </summary>
		public Tags()
		{
		}

		/// <summary>
		/// Creates a new instance with the given tags.
		/// </summary>
		/// <param name="tags"></param>
		public Tags(IEnumerable<string> tags)
		{
			_tags.UnionWith(tags);
		}

		/// <summary>
		/// Adds the tag to the collection.
		/// </summary>
		/// <param name="tag"></param>
		public void Add(string tag)
		{
			_lock.EnterWriteLock();
			try { _tags.Add(tag); }
			finally { _lock.ExitWriteLock(); }
		}

		/// <summary>
		/// Adds the tags to the collection.
		/// </summary>
		/// <param name="tags"></param>
		public void Add(IEnumerable<string> tags)
		{
			_lock.EnterWriteLock();
			try { _tags.UnionWith(tags); }
			finally { _lock.ExitWriteLock(); }
		}

		/// <summary>
		/// Removes the tag from the collection.
		/// </summary>
		/// <param name="tag"></param>
		public void Remove(string tag)
		{
			_lock.EnterWriteLock();
			try { _tags.Remove(tag); }
			finally { _lock.ExitWriteLock(); }
		}

		/// <summary>
		/// Returns true if the given tag is present in the collection.
		/// </summary>
		/// <param name="tag"></param>
		/// <returns></returns>
		public bool Has(string tag)
		{
			_lock.EnterReadLock();
			try { return _tags.Contains(tag); }
			finally { _lock.ExitReadLock(); }
		}

		/// <summary>
		/// Returns true if any of the given tags are present in the collection.
		/// </summary>
		/// <param name="tags"></param>
		/// <returns></returns>
		public bool HasAny(params string[] tags)
			=> tags.Any(this.Has);

		/// <summary>
		/// Returns true if all of the given tags are present in the collection.
		/// </summary>
		/// <param name="tags"></param>
		/// <returns></returns>
		public bool HasAll(params string[] tags)
			=> tags.All(this.Has);

		/// <summary>
		/// Creates a new instance from the given, semicolon-separated string.
		/// </summary>
		/// <example>
		/// var tags = Tags.FromString("NormalSkill;CloseQuarterSkill");
		/// tags.Has("NormalSkill"); // true
		/// tags.Has("UseBowSkill"); // false
		/// </example>
		/// <param name="tags"></param>
		/// <returns></returns>
		public static Tags FromString(string tags)
			=> new(tags.Split(';'));

		/// <summary>
		/// Returns a string representation of the tags.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
			=> string.Join(";", _tags);
	}

	/// <summary>
	/// Interface for objects that have tags.
	/// </summary>
	public interface ITagged
	{
		/// <summary>
		/// Returns the object's tags.
		/// </summary>
		Tags Tags { get; }
	}
}
