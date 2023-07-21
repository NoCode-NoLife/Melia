using System;
using System.Threading.Tasks;
using EmbedIO;
using Newtonsoft.Json;
using Swan.Logging;

namespace Melia.Web.Serializer
{
	/// <summary>
	/// Provides custom response serializer callbacks.
	/// </summary>
	public static class CustomResponseSerializer
	{
		private static readonly ResponseSerializerCallback ChunkedEncodingBaseSerializer = GetBaseSerializer(false);
		private static readonly ResponseSerializerCallback BufferingBaseSerializer = GetBaseSerializer(true);

		/// <summary>
		/// Sends data in a HTTP response without serialization.
		/// </summary>
		/// <param name="bufferResponse"><see langword="true"/> to write the response body to a memory buffer first,
		/// then send it all together with a <c>Content-Length</c> header; <see langword="false"/> to use chunked
		/// transfer encoding.</param>
		/// <returns>A <see cref="ResponseSerializerCallback"/> that can be used to serialize data to a HTTP response.</returns>
		/// <remarks>
		/// <para><see cref="string"/>s and one-dimensional arrays of <see cref="byte"/>s
		/// are sent to the client unchanged; every other type is converted to a string.</para>
		/// <para>The <see cref="IHttpResponse.ContentType">ContentType</see> set on the response is used to negotiate
		/// a compression method, according to request headers.</para>
		/// <para>Strings (and other types converted to strings) are sent with the encoding specified by <see cref="IHttpResponse.ContentEncoding"/>.</para>
		/// </remarks>
		public static ResponseSerializerCallback None(bool bufferResponse)
			=> bufferResponse ? BufferingBaseSerializer : ChunkedEncodingBaseSerializer;

		private static ResponseSerializerCallback GetBaseSerializer(bool bufferResponse)
			=> async (context, data) =>
			{
				if (data is null)
				{
					return;
				}

				var isBinaryResponse = data is byte[];

				if (!context.TryDetermineCompression(context.Response.ContentType, out var preferCompression))
				{
					preferCompression = true;
				}

				if (isBinaryResponse)
				{
					var responseBytes = (byte[])data;
					using (var stream = context.OpenResponseStream(bufferResponse, preferCompression))
						await stream.WriteAsync(responseBytes, 0, responseBytes.Length).ConfigureAwait(false);
				}
				else
				{
					var responseString = data is string stringData ? stringData : data.ToString() ?? string.Empty;
					using (var text = context.OpenResponseText(context.Response.ContentEncoding, bufferResponse, preferCompression))
						await text.WriteAsync(responseString).ConfigureAwait(false);
				}
			};

		/// <summary>
		/// Asynchronously deserializes a request body in JSON format, using JSON.NET.
		/// </summary>
		/// <typeparam name="TData">The expected type of the deserialized data.</typeparam>
		/// <param name="context">The <see cref="IHttpContext"/> whose request body is to be deserialized.</param>
		/// <returns>A <see cref="Task{TResult}">Task</see>, representing the ongoing operation,
		/// whose result will be the deserialized data.</returns>
		public static async Task<TData> GetRequestDataAsyncJson<TData>(this IHttpContext context)
		{
			using (var reader = context.OpenRequestText())
			using (var jsonReader = new JsonTextReader(reader))
			{
				var serializer = new JsonSerializer();
				try
				{
					return await Task.FromResult(serializer.Deserialize<TData>(jsonReader));
				}
				catch (Exception)
				{
					$"[{context.Id}] Cannot convert JSON request body to {typeof(TData).Name}, sending 400 Bad Request..."
						.Warn($"{nameof(CustomResponseSerializer)}.{nameof(GetRequestDataAsyncJson)}");

					throw HttpException.BadRequest("Incorrect request data format.");
				}
			}
		}
	}
}
