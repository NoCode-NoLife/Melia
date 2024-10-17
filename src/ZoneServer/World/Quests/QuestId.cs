using System;
using System.Text;
using Yggdrasil.Security.Hashing;

namespace Melia.Zone.World.Quests
{
	/// <summary>
	/// Namespaced quest id type.
	/// </summary>
	/// <remarks>
	/// Manages the separation of quest ids into namespaces, to reduce the
	/// risk of collisions between different quest scripts.
	/// </remarks>
	public readonly struct QuestId
	{
		/// <summary>
		/// Returns a quest id with the value 0.
		/// </summary>
		public static QuestId Zero => new(0);

		/// <summary>
		/// Returns the quest id's namespace id.
		/// </summary>
		public long NamespaceId { get; }

		/// <summary>
		/// Returns the quest id within the namespace.
		/// </summary>
		public long IdInNamespace { get; }

		/// <summary>
		/// Returns the quest id as a long.
		/// </summary>
		public long Value { get; }

		/// <summary>
		/// Creates new quest id.
		/// </summary>
		/// <param name="questNamespace"></param>
		/// <param name="id"></param>
		/// <exception cref="ArgumentOutOfRangeException"></exception>
		public QuestId(string questNamespace, long id)
		{
			// For backwards compatibility we'll allow raw ids for now,
			// though we might want to remove this eventually.
			if (questNamespace == null)
			{
				this.Value = id;
				return;
			}

			if (id < 1 || id > 0xFFFF)
				throw new ArgumentOutOfRangeException(nameof(id), "Quest id must be between 1 and 65535.");

			this.NamespaceId = GetNamespaceId(questNamespace);
			this.IdInNamespace = GetIdInNamespace(id);
			this.Value = this.NamespaceId | this.IdInNamespace;
		}

		/// <summary>
		/// Creates quest id from given long.
		/// </summary>
		/// <param name="id"></param>
		public QuestId(long id)
		{
			// In the past, quest ids were ints, so if the first half is 0,
			// it's an old-style id that doesn't have a namespace.
			var firstHalf = id >> 32;
			if (firstHalf == 0)
			{
				this.Value = id;
				return;
			}

			this.NamespaceId = GetNamespaceId(id);
			this.IdInNamespace = GetIdInNamespace(id);
			this.Value = id;
		}

		/// <summary>
		/// Returns true if this quest id is in th given namespace.
		/// </summary>
		/// <param name="checkNs"></param>
		/// <returns></returns>
		public bool IsNamespace(string checkNs)
		{
			var nsId = GetNamespaceId(checkNs);
			return this.NamespaceId == nsId;
		}

		/// <summary>
		/// Returns the namespace id for the given namespace.
		/// </summary>
		/// <param name="ns"></param>
		/// <returns></returns>
		private static long GetNamespaceId(string ns)
		{
			var nsBytes = Encoding.UTF8.GetBytes(ns);
			var nsHash = SHA1.Encode(nsBytes);

			return BitConverter.ToInt64(nsHash) << 16;
		}

		/// <summary>
		/// Returns the namespace id for the given id.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		private static long GetNamespaceId(long id)
		{
			return (long)((ulong)id & 0xFFFFFFFFFFFF0000);
		}

		/// <summary>
		/// Returns the id within the namespace for the given id.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		private static long GetIdInNamespace(long id)
		{
			return id & 0xFFFF;
		}

		/// <summary>
		/// Returns true if the given object is a quest id with the same value.
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			if (obj is QuestId other)
				return this.Value == other.Value;

			return false;
		}

		/// <summary>
		/// Returns true if the two quest ids have the same value.
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator ==(QuestId left, QuestId right)
		{
			return left.Equals(right);
		}

		/// <summary>
		/// Returns true if the two quest ids have different values.
		/// </summary>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <returns></returns>
		public static bool operator !=(QuestId left, QuestId right)
		{
			return !(left == right);
		}

		/// <summary>
		/// Returns a hash code for this quest id.
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			return HashCode.Combine(this.Value);
		}
	}
}
