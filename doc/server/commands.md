Commands
=============================================================================

Player and GM commands are a command system built into the normal
in-game chat. Commands are prefixed by `>` by default, followed by the
command name and usually a few parameters. Additionally, commands can be
used on other players if the command supports it and the user has the
required authority level. For this, the prefix must be used twice,
followed by the command and the target player's team name. For example,
while `>item 123` will spawn the item with the id 123 in your inventory,
the command ``>item John 123`` will spawn the same item in John's
inventory instead.

Commands can be used by anyone from the in-game chat, as long as they
have the required authority level. For example, to spawn items using the
command `>item`, you need an authority level of at least 50 by default.
The required authority levels and the command prefix can be configured
in the file `system/conf/commands.conf`, which also serves as a
simplified list of available commands.

The easiest way to change your authority level, to turn you into a GM so
to speak, is to type the console command

```
auth accountname level
```

into the login server's window. Just replace `accountname` with your
account name, `level` with your desired authority level, and press
return to execute it. Make sure you're not logged into your account
while executing the command. By default, level 99 will give you access
to all commands Melia has to offer.
