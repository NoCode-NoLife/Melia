//--- Melia Script ----------------------------------------------------------
// Stylist Custom NPC
//--- Description -----------------------------------------------------------
// Allows players to change their hair style and color.
//--- Details ---------------------------------------------------------------
// Due to the way the game handles hair types it's not possible to easily
// iterate over the available types and specific numbers of colors within
// them, since the number of styles varies between genders, same as the
// number and types of colors per style. As such, we need to constantly
// iterate over all styles and pick out the next/previous one that makes
// sense to get a RO-like stylist.
//---------------------------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;
using Melia.Shared.Data.Database;
using Melia.Shared.Tos.Const;
using Melia.Zone;
using Melia.Zone.Scripting;
using Melia.Zone.Scripting.Dialogues;
using static Melia.Zone.Scripting.Shortcuts;

public class CustomNpcStylist : GeneralScript
{
	public override void Load()
	{
		AddNpc(57223, L("[Stylist] Jeremy"), "c_Klaipe", -66, -547, 180, NpcDialog);
	}

	private async Task NpcDialog(Dialog dialog)
	{
		var pc = dialog.Player;
		var hairType = GetHairType(pc.Gender, pc.Hair);

		dialog.SetTitle(L("Jeremy"));

		var selection = await dialog.Select(L("What can I do for you today?"),
			Option(L("Change Hair Style"), "hair"),
			Option(L("Change Hair Color"), "color"),
			Option(L("Nothing"), "end")
		);

		if (selection == "end")
		{
			await dialog.Msg(L("Please come back any time."));
			return;
		}

		var changeType = selection == "hair" ? StyleChangeType.Hair : StyleChangeType.Color;
		var direction = RotationDirection.Forward;

		await dialog.Msg(L("Good decision, one should treat themselves once in a while."));

		while (true)
		{
			var options = GetOptions(direction);

			pc.ChangeHair(hairType.Index);

			selection = await dialog.Select(LF("This style is called \"{0} (#{1})\", what do you think?", L(hairType.Name), hairType.Index), options);

			switch (selection)
			{
				case "next":
				{
					if (changeType == StyleChangeType.Hair)
						hairType = GetNextStyle(pc.Gender, hairType);
					else
						hairType = GetNextColor(pc.Gender, hairType);

					direction = RotationDirection.Forward;
					break;
				}
				case "prev":
				{
					if (changeType == StyleChangeType.Hair)
						hairType = GetPrevStyle(pc.Gender, hairType);
					else
						hairType = GetPrevColor(pc.Gender, hairType);

					direction = RotationDirection.Backward;
					break;
				}
				case "jump":
				{
					var jumpStr = await dialog.Input(L("Which style would you like to see, do you have a number for me?"));

					if (!int.TryParse(jumpStr, out var index))
					{
						await dialog.Msg(L("Hm... Not a number, is it?"));
						break;
					}

					hairType = GetHairType(pc.Gender, index);
					if (hairType == null)
					{
						await dialog.Msg(L("I'm sorry, I don't know that style."));
						break;
					}

					break;
				}
				default:
				{
					await dialog.Msg(L("Hm, hm, I agree. That style does suit you. Please come back any time."));
					return;
				}
			}
		}
	}

	private DialogOption[] GetOptions(RotationDirection dir)
	{
		var options = new DialogOption[4];

		if (dir == RotationDirection.Forward)
		{
			options[0] = Option(L("Next"), "next");
			options[1] = Option(L("Previous"), "prev");
		}
		else
		{
			options[0] = Option(L("Previous"), "prev");
			options[1] = Option(L("Next"), "next");
		}

		options[2] = Option(L("Jump"), "jump");
		options[3] = Option(L("I like it"), "end");
		return options;
	}

	private HairTypeData GetHairType(Gender gender, int index)
		=> ZoneServer.Instance.Data.HairTypeDb.Entries.FirstOrDefault(a => a.Gender == gender && a.Index == index);

	private HairTypeData GetHairType(Gender gender, string className)
		=> ZoneServer.Instance.Data.HairTypeDb.Entries.FirstOrDefault(a => a.Gender == gender && a.ClassName == className);

	private HairTypeData GetNextStyle(Gender gender, HairTypeData curType)
	{
		var list = gender == Gender.Male ? MaleStyles : FemaleStyles;
		var index = Array.IndexOf(list, curType.ClassName);
		var nextIndex = index + 1;

		if (nextIndex >= list.Length)
			nextIndex = 0;

		var className = list[nextIndex];
		return GetHairType(gender, className);
	}

	private HairTypeData GetPrevStyle(Gender gender, HairTypeData curType)
	{
		var list = gender == Gender.Male ? MaleStyles : FemaleStyles;
		var index = Array.IndexOf(list, curType.ClassName);
		var prevIndex = index - 1;

		if (prevIndex < 0)
			prevIndex = list.Length - 1;

		var className = list[prevIndex];
		return GetHairType(gender, className);
	}

	private HairTypeData GetNextColor(Gender gender, HairTypeData curType)
	{
		var result = (HairTypeData)null;

		foreach (var hairType in ZoneServer.Instance.Data.HairTypeDb.Entries)
		{
			if (hairType.Gender == gender && hairType.ClassName == curType.ClassName)
			{
				if (hairType.Index > curType.Index)
				{
					result = hairType;
					break;
				}

				if (result == null)
					result = hairType;
			}
		}

		return result;
	}

	private HairTypeData GetPrevColor(Gender gender, HairTypeData curType)
	{
		var result = (HairTypeData)null;

		foreach (var hairType in ZoneServer.Instance.Data.HairTypeDb.Entries)
		{
			if (hairType.Gender == gender && hairType.ClassName == curType.ClassName)
			{
				if (hairType.Index == curType.Index && result != null)
					break;

				result = hairType;
			}
		}

		return result;
	}

	private readonly string[] MaleStyles = ZoneServer.Instance.Data.HairTypeDb.Entries.Where(a => a.Gender == Gender.Male).OrderBy(a => a.Index).Select(a => a.ClassName).Distinct().ToArray();
	private readonly string[] FemaleStyles = ZoneServer.Instance.Data.HairTypeDb.Entries.Where(a => a.Gender == Gender.Female).OrderBy(a => a.Index).Select(a => a.ClassName).Distinct().ToArray();

	private enum StyleChangeType
	{
		Hair,
		Color,
	}

	private enum RotationDirection
	{
		Forward,
		Backward,
	}
}
