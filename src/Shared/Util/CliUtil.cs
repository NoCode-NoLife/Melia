// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Melia.Shared.Util
{
	public static class CliUtil
	{
		private const string TitlePrefix = "Melia : ";

		private static readonly string[] Logo = new string[]
		{
			@"                 ___                    ",
			@" /'\_/`\        /\_ \    __             ",
			@"/\      \     __\//\ \  /\_\     __     ",
			@"\ \ \__\ \  /'__`\\ \ \ \/\ \  /'__`\   ",
			@" \ \ \_/\ \/\  __/ \_\ \_\ \ \/\ \L\.\_ ",
			@"  \ \_\\ \_\ \____\/\____\\ \_\ \__/.\_\",
			@"   \/_/ \/_/\/____/\/____/ \/_/\/__/\/_/",
		};

		private static readonly string[] Credits = new string[]
		{
			@"by the Aura Project",
		};

		/// <summary>
		/// Writes logo and credits to Console.
		/// </summary>
		/// <param name="color">Color of the logo.</param>
		public static void WriteHeader(string consoleTitle, ConsoleColor color)
		{
			Console.Title = TitlePrefix + consoleTitle;

			Console.ForegroundColor = color;
			WriteLinesCentered(Logo);

			Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.White;
			WriteLinesCentered(Credits);

			Console.ResetColor();
			WriteSeperator();
		}

		/// <summary>
		/// Writes seperator in form of 80 underscores to Console.
		/// </summary>
		public static void WriteSeperator()
		{
			Console.WriteLine("".PadLeft(Console.WindowWidth, '_'));
		}

		/// <summary>
		/// Writes lines to Console, centering them as a group.
		/// </summary>
		/// <param name="lines"></param>
		private static void WriteLinesCentered(string[] lines)
		{
			var longestLine = lines.Max(a => a.Length);
			foreach (var line in lines)
				WriteLineCentered(line, longestLine);
		}

		/// <summary>
		/// Writes line to Console, centering it either with the string's
		/// length or the given length as reference.
		/// </summary>
		/// <param name="line"></param>
		/// <param name="referenceLength">Set to greater than 0, to use it as reference length, to align a text group.</param>
		private static void WriteLineCentered(string line, int referenceLength = -1)
		{
			if (referenceLength < 0)
				referenceLength = line.Length;

			Console.WriteLine(line.PadLeft(line.Length + Console.WindowWidth / 2 - referenceLength / 2));
		}

		public static void LoadingTitle()
		{
			if (!Console.Title.StartsWith("* "))
				Console.Title = "* " + Console.Title;
		}

		public static void RunningTitle()
		{
			Console.Title = Console.Title.TrimStart('*', ' ');
		}

		/// <summary>
		/// Waits for the return key, and closes the application afterwards.
		/// </summary>
		/// <param name="exitCode"></param>
		/// <param name="wait"></param>
		public static void Exit(int exitCode, bool wait = true)
		{
			if (wait)
			{
				Log.Info("Press Enter to exit.");
				Console.ReadLine();
			}
			Log.Info("Exiting...");
			Environment.Exit(exitCode);
		}

		/// <summary>
		/// Returns whether the application runs with admin rights or not.
		/// </summary>
		public static bool CheckAdmin()
		{
			var id = WindowsIdentity.GetCurrent();
			var principal = new WindowsPrincipal(id);

			return principal.IsInRole(WindowsBuiltInRole.Administrator);
		}
	}
}
