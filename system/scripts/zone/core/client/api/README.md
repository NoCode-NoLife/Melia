API Client Scripts
=============================================================================

These scripts provide both scripters and the server with QoL functions
to simplify interaction, communication, and customization. This document
goes over the functions added by the scripts.

## Overriding Functions

Functions to override client-defined functions and behavior.

### Melia.Backup

Creates a backup of the given global referece and returns it. This happens
only once, the backed up value does not change on repeat calls.

Parameters:
- original (string): The name of the original function.

Returns:
- (function): A reference to the original function.

### Melia.BackupIn

Creates a backup of the given global referece and returns it. This happens
only once, the backed up value does not change on repeat calls.

Parameters:
- parent (table): The parent table that contains the function.
- original (string): The name of the original function.

Returns:
- (function): A reference to the original function.

### Melia.Override

Overrides the original global function with the given name. The override
receives an additional first argument containing a reference to the
original function.

Parameters:
- parent (table): The parent table that contains the function.
- original (string): The name of the original function.
- override (function): The function to override the original with.

Returns:
- (function): A reference to the original function.

### Melia.OverrideIn

Overrides the original global function with the given name. The override
receives an additional first argument containing a reference to the
original function.

Parameters:
- original (string): The name of the original function.
- override (function): The function to override the original with.

Returns:
- (function): A reference to the original function.

## Utility Functions

Miscellaneous utility functions.

### Melia.Util.Serialize

Serializes the given object into a string. Supports serializing tables.

Parameters:
- obj (any): The object to serialize.

Returns:
- (string): The serialized string.

### Melia.Util.DicID

Wraps the given dictionary ID in dicID markup.

Parameters:
- dicId (string): The string to wrap, e.g. "UI_20150317_000736".

Returns:
- (string): The wrapped string, e.g. "@dicID_^*$UI_20150317_000736$*^".

## Logging Functions

Functions to log message using the client's loggin system.

### Melia.Info

Logs message using the client's logging system.

Parameters:
- format (string): The message text or format string.
- ... (any): Arguments to be used in the potential string formatting.

### Melia.Error

Logs message using the client's logging system.

Parameters:
- format (string): The message text or format string.
- ... (any): Arguments to be used in the potential string formatting.

### Melia.Warning

Logs message using the client's logging system.

Parameters:
- format (string): The message text or format string.
- ... (any): Arguments to be used in the potential string formatting.

## Execution Functions

Functions related to executing Lua code.

### Melia.DoString

Executes the given chunk of Lua code.

Parameters:
- code (string): The code to execute.

Returns:
- (bool): True if the code was executed successfully, false otherwise.

## Communication Functions

Functions to simplify communication between server and client.
The receival functions are primarily called by the server.

### Melia.Comm.BeginRecv

Initiates receival of data from the server.

Parameters:
- key (any): The key used to identify this transaction.

### Melia.Comm.Recv

Caches a chunk of data received from the server.

Parameters:
- key (any) The key used to identify this transaction.
- data (any) The data received from the server.

### Melia.Comm.Exec

Calls the callback with the data object collected under the key.

Parameters:
- key (any) The key used to identify this transaction.
- callback (function) Reference to the function to call.

The object passed to the callback has the following format:
```lua
{ ['key'] = ..., ['data'] = { ... } }
```

### Melia.Comm.ExecData

Calls the callback with the data collected under the key.

Parameters:
- key (any) The key used to identify this transaction.
- callback (function) Reference to the function to call.

The object passed to the callback has the following format:
```lua
{ ... }
```

### Melia.Comm.EndRecv

Ends receival of data from the server and clears the data collected
under the key.

Parameters:
- key (any): The key used to identify this transaction.

## UI Functions

Functions for customizing the UI.

### Melia.Ui.SysMenu.AddButton

Adds a button to the button menu on the bottom right of the screen.

Parameters:
- name (string): The button element's name. Must be unique.
- icon (string): The image to use for the button, e.g. "sysmenu_skill".
- tooltip (string): The tooltip to display when hovering over the button.
- callback (string): The function to call when the button is clicked.

### Melia.Ui.SysMenu.InsertButton

Inserts a button into the button menu on the bottom right of the screen.

Parameters:
- pos (number): The position to insert the button at.
- name (string): The button element's name. Must be unique.
- icon (string): The image to use for the button, e.g. "sysmenu_skill".
- tooltip (string): The tooltip to display when hovering over the button.
- callback (string): The function to call when the button is clicked.

### Melia.Ui.SysMenu.RemoveButton

Removes a button from the button menu on the bottom right of the screen.

Parameters:
- name (string): The name of the button to remove.

Default Buttons:
- BtnSystem
- BtnCollection
- BtnInstantDungeon
- BtnPet
- BtnMacro
- BtnFriends
- BtnParty
- BtnQuests
- BtnJournal
- BtnSkills
- BtnInventory
- BtnStatus
- BtnAdvancement
- BtnFishing
- BtnGuildPromo
- BtnPcBang

### Melia.Ui.SysMenu.Clear

Removes all buttons from the button menu on the bottom right of the screen.

Parameters:
- None

### Melia.Ui.SysMenu.SuspendRefresh

Temporarily suspends the refresh of the menu. This is reccomended for
when multiple buttons are added or removed at once, as every change
requires a removal and recreation of the entire menu.

Parameters:
- None

### Melia.Ui.SysMenu.ResumeRefresh

Enables refreshes of the menu again and executes one right away.

Parameters:
- None
