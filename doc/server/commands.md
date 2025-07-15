Commands
=============================================================================

Player and GM commands are a command system built into the normal
in-game chat. Commands are prefixed by `>` by default, followed by
the command name and usually a few parameters. Commands can also be
used on others, by using the prefix twice and using the target's name
after the command name. For example: `>>item John 123`, will spawn
the item with the id 123 in John's inventory, instead of your own.

GM commands can technically be used by anyone from the in-game chat,
as long as they have the required authority level. For example, to
spawn items using the command `>item` you need an authority level of
at least 50 by default. The required authority levels and the command
prefix can be configured in the conf file `system/conf/commands.conf`,
which serves as a kind of command list, that also includes short comments
about what each command does.

The easiest way to change your authority level, to "turn you" into a GM,
is to type the console command

```
auth accountname level
```

into the login server's window, replacing accoutname with your account name,
level with your desired authority level, and pressing return to execute it.
Make sure you're not logged into your account while executing the command.
Level 99 will give you access to all commands Melia has to offer.
