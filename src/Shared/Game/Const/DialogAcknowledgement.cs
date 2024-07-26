using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Game.Const
{
	/// <summary>
	/// Reports to the server the type of dialog acknowledgement.
	/// </summary>
	public enum DialogAcknowledgement : int
	{
		DialogEscape = -1,
		DialogCancel = 0,
		DialogOk = 1,
	};
}
