User Folder
=============================================================================

The server uses two folders to organize its data: `system` and `user`.
While the project's developers primarily use the system folder, users
can extend and override the server's data from the user folder, without
worry of updates affecting their changes or causing conflicts.

This data includes databases, configurations, and scripts, and is treated
with a higher priority if placed in the user folder. That means that if
data is found in both folders, the server will use the one in the user folder
or extend the system data with it, depending on the data type.

While it's technically possible for you to simply edit the files in the
system folder to make your changes, it's strongly recommended you only
use the user folder. Not only is it safer during updates, it also makes
backups and similar operations much simpler.

This guide aims to explain the intricacies of this system, and how you
may customize your server using it.

## Table of Contents

- [Configuration](#configuration)
- [Databases](#databases)
- [Scripts](#scripts)

## Configuration

Conf files are first loaded from the system folder, but if you take a
closer look at them, you will notice an inclusion statement at the end
of each file that looks something like the following.

```
include "/user/conf/world.conf"
```

This instructs the server to read the same file from the user folder
once it's done with the one in the system folder, and in the process
it will overwrite any existing values with the ones you specified.

For example, to change the password for your database, you would create
the file `user/conf/database.conf` and copy the `pass: ` line from the
system's configuration file, at `system/conf/database.conf`, changing
the value to whatever your password is, like this: `pass : yourpassword`.

## Databases

The text-file databases found in the `db` sub-folder can be a little
more complex than the configuration files, in the sense that the exact
behavior of the overwrite depends a little on the database itself.
Some data types can't be overwritten or extended easily for example.
However, in most normal use cases, like adding or modifying items and
monsters, the process is fairly straight forward.

Every file found inside the system's data folder is automatically also
loaded from the user folder if it exists, and the data gets either
overwritten or extended.

For example, if you wanted to modify the weight of an item, you would
create a new file at `user/db/items.txt` and start a new list inside.

```json
[
{ itemId: 101101, className: "SWD01_101", name: "Old Gladius", type: "Equip", group: "Weapon", weight: 20, maxStack: 1, price: 400, sellPrice: 80, equipType1: "Sword", equipType2: "Sword", minLevel: 1, minAtk: 36, maxAtk: 38, attackType: "Slash", leftHandSkill: "Sword_Attack" },
]
```

While the Old Gladius is defined as heaving 90 weight in the system data,
the server would proceed to reading your user data, find the item with
the same id, read it, and overwrite the previously loaded entry,
effectively changing its weight to 20.

## Scripts

In a way, scripts work similar to conf files, though there's another
layer to it.

First we have the script lists, which specify which scripts to load,
like `system/scripts/zone/scripts_custom.txt` for the zone server.
If you look at these files, you might notice familar `include`
statements, like they're also found in the conf files. These essentially
work the same way, with the server starting in the system folder and
continuing to read the included files form user. Instead of overwriting
previously loaded values, however, any additional scripts found are
simply added to the list of scripts to load.

Additionally, there exists a `divert` statement, which stops
the server from reading the current file and redirects to the
given one if it exists. This is used in most script lists, like
`scripts_content.txt`, to allow overriding the system lists
entirely. Not loading any scripts is as simple as creating an
empty file at `user/scripts/zone/scripts.txt` this way. Which
scripts you load is then entirely up to you. But if you only
want to load some additional custom scripts, the `scripts_custom`
list uses a normal include, loading any scripts found in
`user/scripts/zone/scripts_custom.txt` in addition to the
other scripts.

One more feature with the scripts is that you can override specific
script files just by placing them in the same location inside the
user folder. If there's a script found at
`system/scripts/zone/custom/test.cs`, and you create a file at
`user/scripts/zone/custom/test.cs`, the user version will take
precedence over the one in system and the server will only load
that one. This allows you to customize specific scripts without
modifying the script lists.
