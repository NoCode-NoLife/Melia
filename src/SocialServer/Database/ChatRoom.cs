using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melia.Shared.Network;

namespace Melia.Social.Database
{
	/// <summary>
	/// Represents a chat room.
	/// </summary>
	public class ChatRoom
	{
		public readonly List<Account> _members = new List<Account>();
		public readonly List<ChatMessage> _messages = new List<ChatMessage>();

		/// <summary>
		/// Unique chat room id
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Get or set the chat room's name.
		/// </summary>
		public string Name { get; set; } = "";

		/// <summary>
		/// Chat room's type
		/// </summary>
		public ChatRoomType Type { get; set; } = ChatRoomType.Group;

		/// <summary>
		/// Chat room's owner
		/// </summary>
		public Account Owner { get; set; }


		/// <summary>
		/// Returns the number of members in the chat room.
		/// </summary>
		/// <returns></returns>
		public int MemberCount()
		{
			lock (_members)
				return _members.Count;
		}

		/// <summary>
		/// Returns list of all members in the chat room.
		/// </summary>
		/// <returns></returns>
		public Account[] GetMembers()
		{
			lock (_members)
				return _members.ToArray();
		}

		/// <summary>
		/// Returns list of all messages in the chat room.
		/// </summary>
		/// <returns></returns>
		public ChatMessage[] GetMessages()
		{
			lock (_messages)
				return _messages.ToArray();
		}

		/// <summary>
		/// Add a member to the chat room.
		/// </summary>
		/// <param name="account"></param>
		public void AddMember(Account account)
		{
			lock (_members)
			{
				_members.Add(account);
			}
		}

		/// <summary>
		/// Removes a member from a chat room.
		/// </summary>
		/// <param name="account"></param>
		public void RemoveMember(Account account)
		{
			lock (_members)
			{
				_members.Remove(account);
			}
		}

		/// <summary>
		/// Add a message to the chat room.
		/// </summary>
		/// <param name="message"></param>
		public void AddMessage(ChatMessage message)
		{
			lock (_messages)
				_messages.Add(message);
		}

		/// <summary>
		/// Broadcasts packet to all characters on map.
		/// </summary>
		/// <param name="packet"></param>
		public virtual void Broadcast(Packet packet)
		{
			lock (_members)
			{
				foreach (var account in _members)
					account.Connection?.Send(packet);
			}
		}
	}

	public enum ChatRoomType
	{
		OneToOne = 0,
		Friends = 1,
		Group = 3,
	}

	/// <summary>
	/// Represents a message in a chat room
	/// </summary>
	public class ChatMessage
	{
		/// <summary>
		/// Chat message's sender
		/// </summary>
		public Account Sender { get; set; }

		/// <summary>
		/// Chat message's sender
		/// </summary>
		public Account Recipient { get; set; }

		/// <summary>
		/// Chat's message
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Chat's timestamp
		/// </summary>
		public DateTime TimeStamp { get; set; }
	}
}
