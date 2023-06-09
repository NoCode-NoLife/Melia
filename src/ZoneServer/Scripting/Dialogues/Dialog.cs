using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Zone.Network;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.Monsters;
using Yggdrasil.Logging;

namespace Melia.Zone.Scripting.Dialogues
{
	/// <summary>
	/// Manages a dialog between a player and an NPC and allows sending
	/// of messages to the player.
	/// </summary>
	public class Dialog
	{
		private const string NpcNameSeperator = "*@*";
		private const string NpcDialogTextSeperator = "\\";
		private static readonly Regex ReplaceWhitespace = new Regex(@"\s+", RegexOptions.IgnoreCase | RegexOptions.Compiled);

		private string _response;
		private readonly SemaphoreSlim _resumeSignal = new SemaphoreSlim(0);
		private readonly CancellationTokenSource _cancellation = new CancellationTokenSource();

		/// <summary>
		/// Returns a reference to the character that initiated the dialog.
		/// </summary>
		public Character Player { get; }

		/// <summary>
		/// Returns a reference to the NPC the player is talking to.
		/// </summary>
		public Npc Npc { get; }

		/// <summary>
		/// Gets or sets the dialog's current state.
		/// </summary>
		internal DialogState State { get; set; }

		/// <summary>
		/// Returns the data for a potentially open shop.
		/// </summary>
		internal ShopData Shop { get; private set; }

		/// <summary>
		/// Returns the title that's display on the dialog window.
		/// </summary>
		public string Title { get; private set; }

		/// <summary>
		/// Returns the name of the NPC dialog to use for displaying
		/// a portrait.
		/// </summary>
		public string Portrait { get; private set; }

		/// <summary>
		/// Creates and prepares a new dialog between the player and
		/// the NPC.
		/// </summary>
		/// <param name="player"></param>
		/// <param name="npc"></param>
		public Dialog(Character player, Npc npc)
		{
			this.Player = player;
			this.Npc = npc;
		}

		/// <summary>
		/// Starts dialog by calling the NPC's dialog function.
		/// </summary>
		/// <exception cref="InvalidOperationException"></exception>
		internal void Start()
		{
			if (this.Npc.DialogFunc == null)
				throw new InvalidOperationException($"NPC '{this.Npc.Name}' doesn't have a dialog function assigned to it.");

			this.Start(this.Npc.DialogFunc);
		}

		/// <summary>
		/// Starts dialog by calling the given function.
		/// </summary>
		/// <param name="dialogFunc"></param>
		internal async void Start(DialogFunc dialogFunc)
		{
			if (this.State != DialogState.NotStarted)
				throw new InvalidOperationException("Dialog was already started.");

			this.State = DialogState.Active;

			try
			{
				await dialogFunc(this);
				this.Close();
			}
			catch (OperationCanceledException)
			{
				// Thrown to get out of the async chain.
			}
			catch (Exception ex)
			{
				Log.Error("Dialog: During dialog between player '{0}' and NPC '{1}': {2}", this.Player.Name, this.Npc.Name, ex);
			}

			this.State = DialogState.Ended;
		}

		/// <summary>
		/// Sets response and resumes dialog after a Select.
		/// </summary>
		/// <param name="response"></param>
		internal void Resume(string response)
		{
			if (this.State != DialogState.Waiting)
				throw new InvalidOperationException($"The dialog is not paused and waiting for a response.");

			_response = response;
			_resumeSignal.Release();

			// The selection window doesn't disappear on its own,
			// so we have to close it manually before continuing.
			// We'll assume we're in the process of selecting
			// something if we actually got a response.
			if (response != null)
				Send.ZC_DIALOG_CLOSE(this.Player.Connection);
		}

		/// <summary>
		/// Sets the title to display on the dialog window. Set to null
		/// for the default title.
		/// </summary>
		/// <param name="title"></param>
		public void SetTitle(string title)
			=> this.Title = title;

		/// <summary>
		/// Sets the dialog class to use in message, which affects the
		/// displayed portrait. Set to null for the default.
		/// </summary>
		/// <param name="portrait"></param>
		public void SetPortrait(string portrait)
			=> this.Portrait = portrait;

		/// <summary>
		/// Returns delegates that translate strings to the language
		/// selected by the player.
		/// </summary>
		/// <param name="L"></param>
		/// <param name="LN"></param>
		public void PlayerLocalization(out Func<string, string> L, out Func<string, string, int, string> LN)
		{
			L = this.Player.Localizer.Get;
			LN = this.Player.Localizer.GetPlural;
		}

		/// <summary>
		/// Prepares message to get ready to be sent to the client.
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		private string FrameMessage(string message)
		{
			if (IsLocalizationKey(message))
				return WrapLocalizationKey(message);

			message = this.ReplaceCustomCodes(message);
			message = this.AddNpcIdenty(message);

			return message;
		}

		/// <summary>
		/// Adds NPC name and portrait to message.
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		private string AddNpcIdenty(string message)
		{
			// Prepend title, controlling title displayed on the dialog
			// window.
			if (!message.Contains(NpcNameSeperator) && !message.Contains(NpcDialogTextSeperator))
			{
				var dialogTitle = this.GetNpcDialogTitle();
				message = dialogTitle + NpcNameSeperator + message;
			}

			// Prepend dialog class name if one was set. This controls the
			// portrait and also the title if no custom title was set.
			if (!message.Contains(NpcDialogTextSeperator) && this.Portrait != null)
			{
				message = this.Portrait + NpcDialogTextSeperator + message;
			}

			return message;
		}

		/// <summary>
		/// Returns the title to display on the dialog window.
		/// </summary>
		/// <returns></returns>
		private string GetNpcDialogTitle()
		{
			if (this.Title != null)
				return this.Title;

			// If not title was set, we use the NPC's name, and
			// since NPCs often times use a two line name, with a
			// tag and their actual name, we need to remove excess
			// whitespaces and line breaks from it, so it displays
			// properly, in one line, during the dialog.
			// Could possibly be done once on creation.

			var dialogDisplayName = this.Npc.Name;
			dialogDisplayName = dialogDisplayName.Replace("{nl}", " ");
			dialogDisplayName = dialogDisplayName.Replace("[", "");
			dialogDisplayName = dialogDisplayName.Replace("]", "");
			dialogDisplayName = ReplaceWhitespace.Replace(dialogDisplayName, " ");

			return dialogDisplayName;
		}

		/// <summary>
		/// Replaces custom codes in message.
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		private string ReplaceCustomCodes(string message)
		{
			// {pcname} Character name
			if (message.IndexOf("{pcname}") != -1)
				message = message.Replace("{pcname}", this.Player.Name);

			// {teamname} Character team name
			if (message.IndexOf("{teamname}") != -1)
				message = message.Replace("{teamname}", this.Player.TeamName);

			// {fullname} Character name + team name
			if (message.IndexOf("{fullname}") != -1)
				message = message.Replace("{fullname}", this.Player.Name + " " + this.Player.TeamName);

			return message;
		}

		/// <summary>
		/// Returns true if value looks like a localization key.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		internal static bool IsLocalizationKey(string value)
		{
			return (value.StartsWith("ETC_") || value.StartsWith("QUEST_"));
		}

		/// <summary>
		/// Wraps key with dictonary id code.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		internal static string WrapLocalizationKey(string key)
		{
			if (key.StartsWith("@dicID_^*$") && key.EndsWith("$*^"))
				return key;

			return ("@dicID_^*$" + key + "$*^");
		}

		/// <summary>
		/// Sends message to player, adding to any messages already
		/// in the dialog box..
		/// </summary>
		/// <param name="format"></param>
		/// <param name="args"></param>
		public async Task Msg(string format, params object[] args)
		{
			if (args.Length > 0)
				format = string.Format(format, args);

			await this.Msg(format);
		}

		/// <summary>
		/// Sends message to player, adding to any messages already
		/// in the dialog box.
		/// </summary>
		/// <param name="text"></param>
		public async Task Msg(string text)
		{
			text = this.FrameMessage(text);
			Send.ZC_DIALOG_OK(this.Player.Connection, text);

			await this.GetClientResponse();
		}

		/// <summary>
		/// Shows a menu with options to select from, returns the key
		/// of the selected option.
		/// </summary>
		/// <param name="text">Text to display with the options.</param>
		/// <param name="options">List of options to select from.</param>
		/// <returns></returns>
		public async Task<string> Select(string text, params DialogOption[] options)
		{
			// Go through SelectSimple to get the integer response
			// and then look up the key in the options to return it.

			var optionsTexts = options.Select(a => a.Text);
			var selectedIndex = await this.Select(text, optionsTexts);

			var response = options[selectedIndex - 1].Key;
			return response;
		}

		/// <summary>
		/// Shows a menu with options to select from and returns the
		/// index of the selected option, starting at 1. Returns 0 in
		/// case of errors.
		/// </summary>
		/// <param name="text">Text to display with the options.</param>
		/// <param name="options">List of options to select from.</param>
		/// <returns></returns>
		public async Task<int> Select(string text, params string[] options)
			=> await this.Select(text, (IEnumerable<string>)options);

		/// <summary>
		/// Shows a menu with options to select from and returns the
		/// index of the selected option, starting at 1. Returns 0 in
		/// case of errors.
		/// </summary>
		/// <param name="text">Text to display with the options.</param>
		/// <param name="options">List of options to select from.</param>
		/// <returns></returns>
		public async Task<int> Select(string text, IEnumerable<string> options)
		{
			text = this.FrameMessage(text);

			var arguments = new List<string>();
			arguments.Add(text);
			arguments.AddRange(options);

			Send.ZC_DIALOG_SELECT(this.Player.Connection, arguments);

			var response = await this.GetClientResponse();

			// Parse selected index
			if (!int.TryParse(_response, out var selectedIndex))
			{
				Log.Warning("Dialog.SelectSimple: Unexpected non-integer response '{0}'.", _response);
				selectedIndex = 0;
			}
			// Check range
			else if (selectedIndex < 0 || selectedIndex > options.Count())
			{
				Log.Warning("Dialog.SelectSimple: Unexpected out-of-range response '{0}/{1}'.", selectedIndex, options.Count());
				selectedIndex = 0;
			}

			return selectedIndex;
		}

		/// <summary>
		/// Sends dialog input message, showing a message and a text field
		/// for the user to put in a string.
		/// </summary>
		/// <param name="message"></param>
		/// <returns></returns>
		public async Task<string> Input(string message)
		{
			message = this.FrameMessage(message);
			Send.ZC_DIALOG_STRINGINPUT(this.Player.Connection, message);

			var response = await this.GetClientResponse();
			return response;
		}

		/// <summary>
		/// Waits for the client to respond and returns the response.
		/// </summary>
		/// <returns></returns>
		private async Task<string> GetClientResponse()
		{
			this.State = DialogState.Waiting;
			await _resumeSignal.WaitAsync(_cancellation.Token);
			this.State = DialogState.Active;

			return _response;
		}

		/// <summary>
		/// Closes the dialog.
		/// </summary>
		/// <exception cref="OperationCanceledException"></exception>
		public void Close()
		{
			Send.ZC_DIALOG_CLOSE(this.Player.Connection);
			throw new OperationCanceledException("Dialog closed by script.");
		}

		/// <summary>
		/// Opens the shop with the given name for the player.
		/// </summary>
		/// <param name="shopName"></param>
		public async Task OpenShop(string shopName)
		{
			if (!ZoneServer.Instance.Data.ShopDb.TryFind(shopName, out var shopData))
				throw new ArgumentException($"Shop '{shopName}' not found.");

			await this.OpenShop(shopData);
		}

		/// <summary>
		/// Opens the given shop for the player.
		/// </summary>
		/// <param name="shopData"></param>
		public async Task OpenShop(ShopData shopData)
		{
			this.Shop = shopData;

			// If this is a custom shop, we need to set it up on the client
			// by executing some custom Lua code.
			if (shopData.IsCustom)
			{
				var sb = new StringBuilder();
				sb.Append("M_SET_CUSTOM_SHOP({");

				foreach (var productData in shopData.Products.Values)
				{
					sb.AppendFormat("{{{0},{1},{2},{3}}},", productData.Id, productData.ItemId, productData.Amount, productData.PriceMultiplier);

					// One script call can only hold so many items,
					// but we could split it up into multiple calls
					// if necessary.
					if (sb.Length > ClientScript.ScriptMaxLength)
						throw new InvalidOperationException($"Shop '{shopData.Name}' contains too many items.");
				}

				sb.Append("})");

				Send.ZC_EXEC_CLIENT_SCP(this.Player.Connection, sb.ToString());
				Send.ZC_DIALOG_TRADE(this.Player.Connection, "MeliaCustomShop");
			}
			else
			{
				Send.ZC_DIALOG_TRADE(this.Player.Connection, shopData.Name);
			}

			await this.GetClientResponse();
		}
	}

	/// <summary>
	/// A function that can be called to handle a dialog.
	/// </summary>
	/// <param name="dialog"></param>
	/// <returns></returns>
	public delegate Task DialogFunc(Dialog dialog);

	/// <summary>
	/// A function that returns a variable number of options and returns
	/// which one was selected.
	/// </summary>
	/// Necessary because you can't use params in Func/Action.
	/// <param name="options"></param>
	/// <returns></returns>
	public delegate Task<int> DialogSelectFunc(params string[] options);
}
