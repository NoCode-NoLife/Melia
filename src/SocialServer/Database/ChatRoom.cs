using System;
using System.Collections.Generic;
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
		public long Id { get; }

		/// <summary>
		/// Get or set the chat room's name.
		/// </summary>
		public string Name { get; set; } = "";

		/// <summary>
		/// Returns the chat room's type.
		/// </summary>
		public ChatRoomType Type { get; set; } = ChatRoomType.Group;

		/// <summary>
		/// Returns the account of the chat room's owner.
		/// </summary>
		public Account Owner { get; set; }

		/// <summary>
		/// Returns the number of members in the chat room.
		/// </summary>
		public int MemberCount
		{
			get
			{
				lock (_members)
					return _members.Count;
			}
		}

		/// <summary>
		/// Creates new chat room.
		/// </summary>
		/// <param name="owner"></param>
		public ChatRoom(Account owner)
			: this("", ChatRoomType.OneToOne, owner)
		{
		}

		/// <summary>
		/// Creates new chat room.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="type"></param>
		/// <param name="owner"></param>
		public ChatRoom(string name, ChatRoomType type, Account owner)
		{
			this.Id = SocialServer.Instance.ChatManager.GetNewChatId();

			this.Name = name;
			this.Type = type;
			this.Owner = owner;
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
				_members.Add(account);
		}

		/// <summary>
		/// Removes a member from a chat room.
		/// </summary>
		/// <param name="account"></param>
		public void RemoveMember(Account account)
		{
			lock (_members)
				_members.Remove(account);
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

	/// <summary>
	/// Represents a message in a chat room
	/// </summary>
	public class ChatMessage
	{
		/// <summary>
		/// Returns the account of the chat message's sender.
		/// </summary>
		public Account Sender { get; }

		/// <summary>
		/// Returns the account of the chat message's recipient.
		/// </summary>
		public Account Recipient { get; }

		/// <summary>
		/// Returns the message that was sent.
		/// </summary>
		public string Message { get; }

		/// <summary>
		/// Returns the time the message was sent.
		/// </summary>
		public DateTime SentTime { get; } = DateTime.Now;

		/// <summary>
		/// Creates new chat message.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="message"></param>
		public ChatMessage(Account sender, string message)
			: this(sender, null, message)
		{
		}

		/// <summary>
		/// Creates new chat message.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="recipient"></param>
		/// <param name="message"></param>
		public ChatMessage(Account sender, Account recipient, string message)
		{
			this.Sender = sender;
			this.Recipient = recipient;
			this.Message = message;
		}
	}

	/// <summary>
	/// Specifies a chat room's type.
	/// </summary>
	public enum ChatRoomType
	{
		/// <summary>
		/// The chat is between two users.
		/// </summary>
		OneToOne = 0,

		/// <summary>
		/// The chat is between friends?
		/// </summary>
		Friends = 1,

		/// <summary>
		/// The chat is between a group of users.
		/// </summary>
		Group = 3,
	}
}
