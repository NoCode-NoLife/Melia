using Swan.Logging;

namespace Melia.Web.Logging
{
	/// <summary>
	/// Log message redirector.
	/// </summary>
	public class YggdrasilLogger : ILogger
	{
		/// <summary>
		/// Returns the maximum log level this logger is looking for.
		/// </summary>
		public LogLevel LogLevel => LogLevel.None;

		/// <summary>
		/// Disposes object.
		/// </summary>
		public void Dispose()
		{
		}

		/// <summary>
		/// Handles the log event, logging the messages with Yggdrasil's
		/// logger.
		/// </summary>
		/// <param name="logEvent"></param>
		public void Log(LogMessageReceivedEventArgs logEvent)
		{
			//switch (logEvent.MessageType)
			//{
			//	case LogLevel.Info: Yggdrasil.Logging.Log.Info(logEvent.Message); break;
			//	case LogLevel.Warning: Yggdrasil.Logging.Log.Warning(logEvent.Message); break;
			//	case LogLevel.Error: Yggdrasil.Logging.Log.Error(logEvent.Message); break;
			//	case LogLevel.Fatal: Yggdrasil.Logging.Log.Error(logEvent.Message); break;
			//	case LogLevel.Trace: Yggdrasil.Logging.Log.Error(logEvent.Message); break;
			//	case LogLevel.Debug: Yggdrasil.Logging.Log.Debug(logEvent.Message); break;
			//	default: Yggdrasil.Logging.Log.Debug(logEvent.Message); break;
			//}

			var type = "";
			switch (logEvent.MessageType)
			{
				case LogLevel.Info: type = "INF"; break;
				case LogLevel.Warning: type = "WRN"; break;
				case LogLevel.Error: type = "ERR"; break;
				case LogLevel.Fatal: type = "FTL"; break;
				case LogLevel.Trace: type = "TRC"; break;
				case LogLevel.Debug: type = "DBG"; break;
				default: logEvent.MessageType.ToString(); break;
			}

			if (string.IsNullOrWhiteSpace(logEvent.Source))
				Yggdrasil.Logging.Log.Debug("{1} >> {3}", logEvent.UtcDate.ToLocalTime(), type, logEvent.Source, logEvent.Message);
			else
				Yggdrasil.Logging.Log.Debug("{1} >> [{2}] {3}", logEvent.UtcDate.ToLocalTime(), type, logEvent.Source, logEvent.Message);
		}
	}
}
