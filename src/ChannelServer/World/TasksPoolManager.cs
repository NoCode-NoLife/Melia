using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Melia.Channel.World
{
	public class TasksPoolManager
	{
		public static readonly TasksPoolManager Instance = new TasksPoolManager();

		public List<Timer> generalTimers;

		private TasksPoolManager()
		{
			generalTimers = new List<Timer>();
		}


		public Timer AddGeneralTask(TimerCallback action, Object obj, int delay)
		{
			return new Timer(action, obj, delay, Timeout.Infinite);
		}

		public Timer AddGeneralTaskAtFixedRate(TimerCallback action, Object obj, int initial, int delay)
		{
			return new Timer(action, obj, initial, delay);
		}

		public void RemoveGeneralTask(Timer t, double delay)
		{
			//t.Change(Timeout.Infinite, Timeout.Infinite);
			t.Dispose();
			t = null;
		}

	}
}
