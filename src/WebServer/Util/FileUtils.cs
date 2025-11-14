using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Melia.Web.Util
{
	/// <summary>
	/// Utility class for file operations.
	/// </summary>
	public static class FileUtils
	{
		/// <summary>
		/// Computes MD5 hash of the given byte array.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string GetMD5Hash(byte[] input)
		{
			var md5 = MD5.Create();
			var array = md5.ComputeHash(input);
			var stringBuilder = new StringBuilder();

			for (var i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}

			return stringBuilder.ToString();
		}

		/// <summary>
		/// Reads a file and returns its contents as a byte array.
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns></returns>
		public static byte[] FileToByteArray(string fileName)
		{
			byte[] fileData = null;

			using (var fs = File.OpenRead(fileName))
			{
				using (var binaryReader = new BinaryReader(fs))
				{
					fileData = binaryReader.ReadBytes((int)fs.Length);
				}
			}
			return fileData;
		}
	}
}
