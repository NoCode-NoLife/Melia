using System;
using System.Collections.Generic;
using System.Linq;
using Melia.Social.Network;
using Melia.Social.World;

namespace Melia.Social.Database
{
	/// <summary>
	/// Represents a chat room.
	/// </summary>
	public class ChatRoom
	{
		private readonly List<ChatMember> _members = new();
		private readonly List<ChatMessage> _messages = new();
		private readonly HashSet<long> _invites = new();

		/// <summary>
		/// Returns the chat room's globally unique id.
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
		/// Returns the account id of the chat room's owner.
		/// </summary>
		public long OwnerId { get; set; }

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
		/// <param name="name"></param>
		/// <param name="type"></param>
		public ChatRoom(string name, ChatRoomType type)
		{
			this.Id = SocialServer.Instance.ChatManager.GetNewChatId();

			this.Name = name;
			this.Type = type;
		}

		/// <summary>
		/// Returns list of all members in the chat room.
		/// </summary>
		/// <returns></returns>
		public ChatMember[] GetMembers()
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
		/// <remarks>
		/// The first member to be added to a chat room becomes its
		/// creator if no creator was set yet.
		/// </remarks>
		/// <param name="user"></param>
		public void AddMember(SocialUser user)
			=> this.AddMember(new ChatMember(this.Id, user.Id, user.TeamName));

		/// <summary>
		/// Add a member to the chat room.
		/// </summary>
		/// <remarks>
		/// The first member to be added to a chat room becomes its
		/// creator if no creator was set yet.
		/// </remarks>
		/// <param name="member"></param>
		public void AddMember(ChatMember member)
		{
			lock (_members)
				_members.Add(member);

			if (this.OwnerId == 0)
				this.OwnerId = member.AccountId;
		}

		/// <summary>
		/// Removes a member from a chat room.
		/// </summary>
		/// <param name="accountId"></param>
		public void RemoveMember(long accountId)
		{
			lock (_members)
				_members.RemoveAll(m => m.AccountId == accountId);
		}

		/// <summary>
		/// Returns true if the chat has a member with the given team name.
		/// </summary>
		/// <param name="teamName"></param>
		/// <returns></returns>
		public bool IsMember(string teamName)
		{
			lock (_members)
				return _members.Any(a => a.TeamName == teamName);
		}

		/// <summary>
		/// Add a message to the chat room.
		/// </summary>
		/// <param name="message"></param>
		public void AddMessage(ChatMessage message)
		{
			lock (_messages)
				_messages.Add(message);

			lock (_members)
			{
				foreach (var member in _members)
				{
					if (SocialServer.Instance.UserManager.TryGet(member.AccountId, out var user) && user.TryGetConnection(out var conn))
					{
						Send.SC_NORMAL.CreateRoom(conn, this);
						Send.SC_NORMAL.AddMessage(conn, this, message);
					}
				}
			}
		}

		/// <summary>
		/// Marks the room a having open invites, created by the given inviter.
		/// </summary>
		/// <param name="inviterId"></param>
		public void CreateInvite(long inviterId)
		{
			lock (_invites)
				_invites.Add(inviterId);
		}

		/// <summary>
		/// Removes the open invite created by the given inviter.
		/// </summary>
		/// <param name="inviterId"></param>
		public void RevokeInvite(long inviterId)
		{
			lock (_invites)
				_invites.Remove(inviterId);
		}

		/// <summary>
		/// Returns true if there are open invites created by the given inviter.
		/// </summary>
		/// <param name="inviterId"></param>
		/// <returns></returns>
		public bool HasInvites(long inviterId)
		{
			lock (_invites)
				return _invites.Contains(inviterId);
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
