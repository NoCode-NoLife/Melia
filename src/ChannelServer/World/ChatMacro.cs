using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Channel.World
{
	public class ChatMacro
	{
		/// <summary>
		/// Index where to place the macro in the UI.
		/// </summary>
		public int Index { get; set; }

		/// <summary>
		/// Content of the macro. This can be a classID ex. @dicID_^*$ETC_20151001_014770$*^.
		/// </summary>
		public string Message { get; set; }

		/// <summary>
		/// Pose associated with the macro.
		/// </summary>
		public int Pose { get; set; }

		public ChatMacro(int index, string message, int pose = 0)
		{
			this.Index = index;
			this.Message = message;
			this.Pose = pose;
		}

		/// <summary>
		/// Updates a chat macro.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="pose"></param>
		public void Update(string message, int pose)
		{
			this.Message = message;
			this.Pose = pose;
		}
	}
}
