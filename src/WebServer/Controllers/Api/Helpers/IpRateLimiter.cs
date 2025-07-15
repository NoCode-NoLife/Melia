using System;
using System.Collections.Generic;

namespace Melia.Web.Controllers.Api.Helpers
{
	/// <summary>
	/// Simple rate limiter that keeps track of the number of requests made
	/// and blocks further requests for a certain time period after the limit
	/// was reached.
	/// </summary>
	internal class IpRateLimiter
	{
		private readonly Dictionary<string, IpRateLimitRequest> _requests = new();

		/// <summary>
		/// Gets or sets the number of requests that can be made per IP address
		/// before they're getting rate limited.
		/// </summary>
		public int MaxRequests { get; set; } = 10;

		/// <summary>
		/// Gets or sets the time period clients have to wait until they can make
		/// requests again after being rate limited.
		/// </summary>
		public TimeSpan Period { get; set; } = TimeSpan.FromMinutes(5);

		/// <summary>
		/// Creates a new instance with default settings.
		/// </summary>
		public IpRateLimiter()
		{
		}

		/// <summary>
		/// Creates a new instance with the given settings.
		/// </summary>
		/// <param name="maxRequests"></param>
		/// <param name="period"></param>
		public IpRateLimiter(int maxRequests, TimeSpan period)
		{
			this.MaxRequests = maxRequests;
			this.Period = period;
		}

		/// <summary>
		/// Determines whether the given IP address is currently rate limited.
		/// Returns true if the client has made too many requests and should
		/// have to wait.
		/// </summary>
		/// <param name="ip"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException"></exception>
		public bool IsRateLimited(string ip)
		{
			if (string.IsNullOrWhiteSpace(ip))
				throw new ArgumentException("IP address cannot be null or empty.", nameof(ip));

			lock (_requests)
			{
				if (!_requests.TryGetValue(ip, out var request))
				{
					_requests[ip] = request = new IpRateLimitRequest(ip);
					return false;
				}

				var now = DateTime.UtcNow;
				var timePassed = now - request.LastRequestTime;

				if (timePassed > this.Period)
				{
					request.RequestCount = 1;
					request.LastRequestTime = now;
					return false;
				}

				if (request.RequestCount < this.MaxRequests)
				{
					request.RequestCount++;
					return false;
				}
			}

			return true;
		}

		private class IpRateLimitRequest
		{
			public string IpAddress { get; set; }
			public int RequestCount { get; set; }
			public DateTime LastRequestTime { get; set; }

			public IpRateLimitRequest(string ipAddress)
			{
				this.IpAddress = ipAddress;
				this.RequestCount = 1;
				this.LastRequestTime = DateTime.UtcNow;
			}
		}
	}
}
