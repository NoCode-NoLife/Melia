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

### Melia.Serialize

Serializes the given object into a string. Supports serializing tables.

Parameters:
- obj (any): The object to serialize.

Returns:
- (string): The serialized string.

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

- key (any) The key used to identify this transaction.
- data (any) The data received from the server.

### Melia.Comm.Recv

-- Ends receival of data from the server and passes it to the callback.

Parameters:
- key (any): The key used to identify this transaction.
- callback (string): The function to call the data with.
