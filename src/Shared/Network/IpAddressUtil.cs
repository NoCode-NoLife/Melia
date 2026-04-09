using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace Melia.Shared.Network
{
	/// <summary>
	/// Utility for IP-related operations.
	/// </summary>
	public class IpAddressUtil
	{
		/// <summary>
		/// Attempts to resolve a hostname to an IPv4 address.
		/// </summary>
		/// <param name="host">The hostname to resolve.</param>
		/// <param name="ip">The resolved IPv4 address, if successful.</param>
		/// <returns>A <see cref="ResolveResult"/> indicating the outcome of the resolution.</returns>
		public static ResolveResult TryResolve(string host, out string ip)
		{
			if (Regex.IsMatch(host, @"^\d{1,3}(\.\d{1,3}){3}$"))
			{
				ip = host;
				return ResolveResult.AlreadyIp;
			}

			try
			{
				var addresses = Dns.GetHostAddresses(host);
				var ipv4Address = addresses.FirstOrDefault(a => a.AddressFamily == AddressFamily.InterNetwork);

				if (ipv4Address != null)
				{
					ip = ipv4Address.ToString();
					return ResolveResult.Resolved;
				}
				else
				{
					ip = null;
					return ResolveResult.Fail;
				}
			}
			catch (Exception)
			{
				ip = null;
				return ResolveResult.Error;
			}
		}
	}

	public enum ResolveResult
	{
		AlreadyIp,
		Resolved,
		Fail,
		Error,
	}
}
