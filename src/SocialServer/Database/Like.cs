using System;
using System.Collections.Generic;
using Melia.Social.World;

namespace Melia.Social.Database
{
	/// <summary>
	/// Represents a like that was sent by a user.
	/// </summary>
	public class Like
	{
		/// <summary>
		/// Returns the id of the user who received the like.
		/// </summary>
		public long ReceiverId { get; }

		/// <summary>
		/// Returns the team name of the receiver.
		/// </summary>
		public string ReceiverName { get; }

		/// <summary>
		/// Returns the id of the user who sent the like.
		/// </summary>
		public long SenderId { get; }

		/// <summary>
		/// Returns the team name of the sender.
		/// </summary>
		public string SenderName { get; }

		/// <summary>
		/// Returns the time the like was sent.
		/// </summary>
		public DateTime Time { get; }

		/// <summary>
		/// Creates a new like.
		/// </summary>
		/// <param name="receiver"></param>
		/// <param name="sender"></param>
		public Like(SocialUser receiver, SocialUser sender)
			: this(receiver.Id, receiver.TeamName, sender.Id, sender.TeamName, DateTime.Now)
		{
		}

		/// <summary>
		/// Creates a new like.
		/// </summary>
		/// <param name="receiverId"></param>
		/// <param name="receiverName"></param>
		/// <param name="senderId"></param>
		/// <param name="senderName"></param>
		/// <param name="time"></param>
		public Like(long receiverId, string receiverName, long senderId, string senderName, DateTime time)
		{
			this.ReceiverId = receiverId;
			this.ReceiverName = receiverName;

			this.SenderId = senderId;
			this.SenderName = senderName;

			this.Time = time;
		}
	}

	/// <summary>
	/// Manages a collection of likes.
	/// </summary>
	public class LikeCollection
	{
		private readonly List<Like> _likes = new();

		/// <summary>
		/// Returns the number of likes in the collection.
		/// </summary>
		public int Count
		{
			get
			{
				lock (_likes)
					return _likes.Count;
			}
		}

		/// <summary>
		/// Returns all likes in the collection.
		/// </summary>
		/// <returns></returns>
		public Like[] GetAll()
		{
			lock (_likes)
				return _likes.ToArray();
		}

		/// <summary>
		/// Adds a like to the collection if it doesn't exist already.
		/// </summary>
		/// <param name="like"></param>
		public void Add(Like like)
		{
			lock (_likes)
			{
				if (!this.Exists(like.ReceiverId, like.SenderId))
					_likes.Add(like);
			}
		}

		/// <summary>
		/// Removes a like from the collection. Returns true if the like was
		/// removed successfully.
		/// </summary>
		/// <param name="receiverId"></param>
		/// <param name="senderId"></param>
		public bool Remove(long receiverId, long senderId)
		{
			lock (_likes)
			{
				var removedCount = _likes.RemoveAll(a => a.ReceiverId == receiverId && a.SenderId == senderId);
				return removedCount > 0;
			}
		}

		/// <summary>
		/// Returns true if a like exists between the two users.
		/// </summary>
		/// <param name="receiverId"></param>
		/// <param name="senderId"></param>
		/// <returns></returns>
		public bool Exists(long receiverId, long senderId)
		{
			lock (_likes)
				return _likes.Exists(a => a.ReceiverId == receiverId && a.SenderId == senderId);
		}
	}
}
