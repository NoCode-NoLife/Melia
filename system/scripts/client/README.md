Client Scripts
=============================================================================

All scripts in this folder and its sub-folders are sent to the client
on connection, for the client to execute. This way, the server can make
changes to the client's behavior.

Limitations
-----------------------------------------------------------------------------

With how flexible Lua is, you can do a lot by sending the client Lua code
to execute. There is one limitation however: The scripts can't be longer
than 2048 characters per file. This means that you might have to get a
little creative when creating large scripts, and separate them into sub-
functions, that you distribute over multiple files.

We recommend to use an editor that shows the number of characters in the
file, and that you try to write as little code as possible to accomplish
any given task. If all else fails, you could use a Lua minifier, though
that should be the absolute last resort.

Conventions
-----------------------------------------------------------------------------

To organize these scripts, create one folder for every group of them.
For example, the scripts that fix personal shops might all go into a
sub-folder called "personal_shops". The files should be named in a way,
that they load in the right order. For example, 001.lua through 003.lua
might contain the functions, while 004.lua contains the code that runs
when it's sent to the client, which uses the functions.

The code itself should ideally be written in a way that it will do its
job every time the code is executed. The client scripts are sent to the
client right after the player made it in-game, at which point it's safe
to modify the UI. The scripts should be able to handle reloads, however.
When the reloadscripts command is executed, the scripts are reloaded and
then sent to all clients again, which the scripts should account for.
For example, if you created new controls, these should be removed before
adding them, so that they only exist once after a reload.

If you overwrite functions, general purpose ones in particular, make sure
to not break their original behavior. For example, if you overwrite the
function `GetClassByType`, which is used all over, always save a reference
to the original function and use it, only modifying as much as absolutely
necessary about the return value. This ensures that the function still
works as intended, and that repeated overwrites also keep working.
