using System;
using Melia.Shared.Data.Database;
using Yggdrasil.Network.Communication;

namespace Melia.Shared.Network.Inter.Messages
{
	/// <summary>
	/// Contains updated information about a server.
	/// </summary>
	[Serializable]
	public class ResServerInformationMessage : ICommMessage
	{
		/// <summary>
		/// Returns the type of the server.
		/// </summary>
		public ServerType ServerType { get; set; }

		/// <summary>
		/// Returns the server's processId
		/// </summary>
		public int ProcessId { get; set; }

		/// <summary>
		/// Returns the server's id.
		/// </summary>
		public int ServerId { get; set; }

		/// <summary>
		/// Returns the server's processName
		/// </summary>
		public string ProcessName { get; set; }

		/// <summary>
		/// Returns the server's status.
		/// </summary>
		public ServerStatus Status { get; set; }

		/// <summary>
		/// Returns the server's CPU usage percentage
		/// </summary>
		public float CpuUsagePercentage { get; set; }

		/// <summary>
		/// Returns the server's memory usage
		/// </summary>
		public float ProcessRamUsage { get; set; }

		/// <summary>
		/// Returns the server's total memory
		/// </summary>
		public ulong TotalRAM { get; set; }

		/// <summary>
		/// Returns the server's ip address
		/// </summary>
		public string ServerIp { get; set; }

		/// <summary>
		/// Creates a new message.
		/// </summary>
		/// <param name="serverType"></param>
		/// <param name="processId"></param>
		/// <param name="serverId"></param>
		/// <param name="processName"></param>
		/// <param name="status"></param>
		/// <param name="cpuUsagePercentage"></param>
		/// <param name="processRamUsage"></param>
		/// <param name="totalRAM"></param>
		/// <param name="serverIp"></param>
		public ResServerInformationMessage(ServerType serverType, int processId, int serverId, string processName, ServerStatus status, float cpuUsagePercentage, float processRamUsage, ulong totalRAM, string serverIp)
		{
			this.ServerType = serverType;
			this.ProcessId = processId;
			this.ServerId = serverId;
			this.ProcessName = processName;
			this.Status = status;
			this.CpuUsagePercentage = cpuUsagePercentage;
			this.ProcessRamUsage = processRamUsage;
			this.TotalRAM = totalRAM;
			this.ServerIp = serverIp;
		}
	}
}
