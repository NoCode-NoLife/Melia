using System;
using System.Threading.Tasks;
using Yggdrasil.Network.Communication;

namespace Melia.Web.Controllers
{
	/// <summary>
	/// Extensions for the inter-server communicator.
	/// </summary>
	internal static class CommunicatorExtensions
	{
		/// <summary>
		/// Sends a request to the receiver and waits for a response.
		/// Returns either the response or null if the request failed.
		/// </summary>
		/// <remarks>
		/// This method is not 100% reliable and was only created for
		/// demonstration purposes. It will be removed in the future
		/// once this functionality is built into the communicator.
		/// </remarks>
		/// <typeparam name="TMessage"></typeparam>
		/// <param name="comm"></param>
		/// <param name="reqMessage"></param>
		/// <returns></returns>
		internal static async Task<TMessage> RequestResponse<TMessage>(this Communicator comm, string receiver, ICommMessage reqMessage) where TMessage : ICommMessage
		{
			var waitResponseType = typeof(TMessage);
			var responseMessage = default(ICommMessage);
			var timeout = DateTime.Now.AddSeconds(2);

			void onMessageReceived(string sender, ICommMessage message)
			{
				if (message.GetType() == typeof(TMessage))
					responseMessage = message;
			}

			comm.MessageReceived += onMessageReceived;

			try
			{
				comm.Send(receiver, reqMessage);
			}
			catch
			{
				return default;
			}

			do { await Task.Delay(1); }
			while (responseMessage == null && DateTime.Now < timeout);

			comm.MessageReceived -= onMessageReceived;

			return (TMessage)responseMessage;
		}
	}
}
