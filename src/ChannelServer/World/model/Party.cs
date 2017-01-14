using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Melia.Channel.World.model
{
	public class Party
	{
		// List of members
		private List<Character> _members;

		// invitation is pending
		private bool _invitePending;

		// timeout invitation
		private long _invitePendingTimeout;

		// Task to broadcast party position
		private Timer _partyPositionTask;

		// Constructor
		public Party(Character leader)
		{
			_members = new List<Character>();
			_members.Add(leader);
		}


	}

	
}
