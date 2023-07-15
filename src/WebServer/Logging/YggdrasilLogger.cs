using Swan.Logging;

namespace Melia.Web.Logging
{
	/// <summary>
	/// Log message redirector.
	/// </summary>
	public class YggdrasilLogger : ILogger
	{
		private readonly Yggdrasil.Logging.LogLevel _filter;

		/// <summary>
		/// Returns the maximum log level this logger is looking for.
		/// </summary>
		public LogLevel LogLevel => LogLevel.None;

		/// <summary>
		/// Creates new logger.
		/// </summary>
		/// <param name="filter"></param>
		public YggdrasilLogger(Yggdrasil.Logging.LogLevel filter)
		{
			_filter = filter;
		}

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
			var yggdrasilLevel = GetYggdrasilLogLevel(logEvent.MessageType);
			if ((_filter & yggdrasilLevel) != 0)
				return;

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

		/// <summary>
		/// Returns the log level that's equivalent to the given one.
		/// </summary>
		/// <param name="swanLevel"></param>
		/// <returns></returns>
		private static Yggdrasil.Logging.LogLevel GetYggdrasilLogLevel(LogLevel swanLevel)
		{
			switch (swanLevel)
			{
				default:
				case LogLevel.Info: return Yggdrasil.Logging.LogLevel.Info;
				case LogLevel.Warning: return Yggdrasil.Logging.LogLevel.Warning;
				case LogLevel.Error: return Yggdrasil.Logging.LogLevel.Error;
				case LogLevel.Fatal: return Yggdrasil.Logging.LogLevel.Error;
				case LogLevel.Trace: return Yggdrasil.Logging.LogLevel.Debug;
				case LogLevel.Debug: return Yggdrasil.Logging.LogLevel.Debug;
			}
		}
	}
}
