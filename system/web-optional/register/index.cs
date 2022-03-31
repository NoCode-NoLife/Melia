//--- Aura Script -----------------------------------------------------------
// Registration Page
//--- Description -----------------------------------------------------------
// Simple example of a registration page that allows users to create
// new accounts.
//---------------------------------------------------------------------------

using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Melia.Shared.Util;
using Melia.Web;
using Swebs;
using Swebs.RequestHandlers.CSharp;

public class RegistrationControllerScript : Controller
{
	public override void Handle(HttpRequestEventArgs args, string requestedPath, string localPath)
	{
		var request = args.Request;
		var response = args.Response;
		var server = args.Context.Server;

		var pageFolder = Path.GetDirectoryName(localPath);
		var templatePath = Path.Combine(pageFolder, "template.htm");

		var name = request.Parameter("name");
		var password1 = request.Parameter("password1");
		var password2 = request.Parameter("password2");

		var error = "";
		var success = "";

		if (name != null && password1 != null && password2 != null)
		{
			if (password1 != password2)
			{
				error = "The passwords don't match.";
				goto L_Send;
			}

			if (!Regex.IsMatch(name, @"^[0-9a-z]{4,32}$", RegexOptions.IgnoreCase))
			{
				name = "";
				error = "Invalid username, please use 4 to 32 alphanumeric characters.";
				goto L_Send;
			}

			if (password1.Length < 6 || password1.Length > 32)
			{
				error = "Invalid password.";
				goto L_Send;
			}

			if (WebServer.Instance.Database.AccountExists(name))
			{
				error = "Account already exists.";
				goto L_Send;
			}

			password1 = this.CreateMD5Hash(password1);
			WebServer.Instance.Database.CreateAccount(name, password1);

			Log.Info("New account created: {0}", name);

			name = "";
			success = "Account created successfully.";
		}

	L_Send:
		var engine = server.GetEngine("hbs");
		response.Send(engine.RenderFile(templatePath, new { error, success, name }));
	}
	
	/// <summary>
	/// Generate an MD5 hash
	/// </summary>
	/// <param name="input"></param>
	/// <returns></returns>
	private string CreateMD5Hash(string input)
	{
		// Step 1, calculate MD5 hash from input
		MD5 md5 = MD5.Create();
		byte[] inputBytes = Encoding.UTF8.GetBytes(input);
		byte[] hashBytes = md5.ComputeHash(inputBytes);

		// Step 2, convert byte array to hex string
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < hashBytes.Length; i++)
		{
			sb.Append(hashBytes[i].ToString("X2"));
		}
		return sb.ToString();
	}
}
