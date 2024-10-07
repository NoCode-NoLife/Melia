User Folder
=============================================================================

Melia uses 2 folders to organize databases, configurations, scripts, etc:
"system" and "user". The developers only make changes in system, leaving
the user folder to the user.

When loading data, the user folder is treated with a higher priority,
making it possible for you to extend and modify things without touching
the system files. This ensures that there will never be any conflicts
when updating, you could copy a new version of Melia over the old one,
overwriting everything, without losing your modifications.

While it's technically possible for you to just make your changes in the
system folder, it's strongly recommended you only use user. Not only is
it safer during updates, it also makes backups and similar operations
much simpler. For example, if you wanted to start clean, all you have
to do is download a new copy of Melia, copy your user folder to the new
Melia folder, and you're done. All your settings and customizations are
there.

- [Configuration](#configuration)
- [Databases](#databases)
- [Scripts](#scripts)

## Configuration

Conf files are loaded from the system folder first, from `system/conf/`.
In each file you can see something like

```
include "/user/conf/channel.conf"
```
  
at the bottom. This instructs the server to include that file, if it exists.
Values found in there will overwrite the things in the system's file.

For example, to change the password for your database, you would take a look
at `system/conf/database.conf`, copy the line `pass : `, paste it into a new
file at `user/conf/database.conf`, and change it to `pass : yourpassword`.
The server would read the system's file, jump over to your file at the end,
and overwrite the "pass" option with your setting.

## Databases

Databases in "db" are a little more special than configuration files,
but the normal use cases, like adding or modifying items and monsters
are straight forward enough.

Like with conf files, the server reads the files in system first and
jumps over to user afterwards. This is done internally, without an
explicit include. Again, the values are replaced, or added, from user.

## Scripts

The script lists work similar to conf files, in that the lists in system
include lists from user. The server then loads all script files specified
in the lists, with the user folder being treated with a higher priority.
This means if you put a script in the same exact location in the user
folder as an official script in the system folder, the server will load
the user file instead of the one in system. This way you can easily
override entire scripts.

```text
user\scripts\npc\city\c_Klaipe.cs > system\scripts\npc\city\c_Klaipe.cs
```
