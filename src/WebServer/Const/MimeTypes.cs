namespace Melia.Web.Const
{
	/// <summary>
	/// Simple lookup table for common MIME types used in the web server.
	/// </summary>
	public static class MimeTypes
	{
		// Shortcuts for our most commonly used types
		public const string Json = Application.Json;

		public static class Application
		{
			public const string Binary = "application/octet-stream";
			public const string Json = "application/json";
			public const string Xml = "application/xml";
		}

		public static class Audio
		{
			public const string Midi = "audio/midi";
			public const string Mp3 = "audio/mpeg";
			public const string Ogg = "audio/ogg";
			public const string Wav = "audio/wav";
		}

		public static class Images
		{
			public const string Gif = "image/gif";
			public const string Jpeg = "image/jpeg";
			public const string Png = "image/png";
			public const string Svg = "image/svg+xml";
			public const string Webp = "image/webp";
		}

		public static class Text
		{
			public const string Css = "text/css";
			public const string Html = "text/html";
			public const string Markdown = "text/markdown";
			public const string Plain = "text/plain";
		}

		public static class Video
		{
			public const string Mp4 = "video/mp4";
			public const string Webm = "video/webm";
			public const string Ogg = "video/ogg";
		}
	}
}
