using System;
using System.Reflection;

namespace Melia.Shared.Scripting
{
	/// <summary>
	/// Extension methods for Roslyn CSharpCodeProvider.
	/// </summary>
	public static class CSharpCodeProviderExtensions
	{
		private const BindingFlags _privateField = BindingFlags.NonPublic | BindingFlags.Instance;

		/// <summary>
		/// Sets the compiler's time to live via reflection.
		/// </summary>
		/// <remarks>
		/// By default the roslyn compiler only sticks around for a few
		/// seconds, which adds its start up time to the compilation time.
		/// By changing this compiling becomes faster on restarts.
		/// </remarks>
		/// <param name="codeProvider"></param>
		/// <param name="timeToLive"></param>
		public static void SetCompilerServerTimeToLive(this Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider codeProvider, TimeSpan timeToLive)
		{
			var compilerSettingField = typeof(Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider).GetField("_compilerSettings", _privateField);
			var compilerSettings = compilerSettingField.GetValue(codeProvider);

			var timeToLiveField = compilerSettings.GetType().GetField("_compilerServerTimeToLive", _privateField);
			timeToLiveField.SetValue(compilerSettings, (int)timeToLive.TotalSeconds);
		}

		/// <summary>
		/// Sets the compiler's full path to the roslyn compiler via
		/// reflection.
		/// </summary>
		/// <remarks>
		/// By default the roslyn compiler expects to find its exe in
		/// "bin/roslyn/", this overrides the path so the folder doesn't
		/// need to be copied to where the application is.
		/// </remarks>
		/// <param name="codeProvider"></param>
		/// <param name="fullPath"></param>
		public static void SetCompilerFullPath(this Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider codeProvider, string fullPath)
		{
			var compilerSettingField = typeof(Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider).GetField("_compilerSettings", _privateField);
			var compilerSettings = compilerSettingField.GetValue(codeProvider);

			var timeToLiveField = compilerSettings.GetType().GetField("_compilerFullPath", _privateField);
			timeToLiveField.SetValue(compilerSettings, fullPath);
		}
	}
}
