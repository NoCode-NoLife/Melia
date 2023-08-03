Melia Localization
=============================================================================

Localization in Melia is done through a "gettext"-like system, which is
commonly used for this type of work in many areas. The server reads the
".po" file specified in the configuration from the localization folder
and uses the translated lines. If a line is not translated, it uses the
original, English version instead.

Since we frequently add and change lines in both the core and NPCs, the
files that come with Melia might not always be up-to-date, and we might
also not be able to support all languages ourselves. You can edit and
generate new files from the source files yourself though using various
tools. We recommand the free "Poedit": http://poedit.net/

Here's a short description on how to create a new translation using Poedit.

* Open Poedit
* Click "File > New..."
* Select the language you want to work on
* Save file, for example as "user/localization/de-DE.po" for a German
  translation. The name of the file is what you put as "language" in
  localization.conf, in this case "de-DE".
* Click "Extract from sources"
* Select Melia's root folder as the base path and add the "src" and
  "system" folders in the first list, of paths to include.
* Switch to the "Translation properties", enter any project name, and
  select "UTF-8" as source code charset.
* Switch to the "Source keywords" and add the following new items,
  without quotation:
  "Localization.Get:1"
  "Localization.GetPlural:1,2"
  "Localization.GetParticular:1c,2"
  "Localization.GetParticularPlural:1c,2,3"
  "L:1"
  "LN:1,2"
  "LX:1c,2"
  "LXN:1c,2,3"
  These are the function names the program will look for to get strings.
  `Localization.Get...` is usually used inside the core, while the other
  methods are used in scripts for various things.
* After clicking OK, Poedit will search all files for translatable texts.
  Once it's done searching you can start translating, by selecting a line
  and adding the translation at the bottom.
* Finally, save the file and you're done. It should now use the strings
  in that file after you told Melia to use it in localization.conf.
  You can also create a "en-US.po" file to replace default phrases
  without changing the language.

After creating a ".po" file once you can simply open it with Poedit again,
fix translations, or update the catalogue, which makes it read the source
again, adding new lines to it for you to translate while keeping what you've
done so far.
