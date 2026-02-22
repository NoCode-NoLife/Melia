Web API
=============================================================================

The web server is integrated into the internal network of the Melia server
and is capable of communicating information between the core servers and
the web interface. This allows outside services or custom web pages to
display information about the server or accept instructions. Examples
of this include information about whether the server is online, how
many players are active, or sending broadcasts to them.


Public Endpoints
-----------------------------------------------------------------------------

The following endpoints are intended to be publically accessible for
interoperability. They may be used by websites, toplists, launchers,
etc.

### World Info

Returns information about the world, such as player count and rates.

Request: GET `/api/info/world/`

Example Output:
```json
{
	"result": 0,
	"serverOnline": true,
	"playersOnline": 20,
	"playersMax": 600,
	"worldSettings": {
		"ExpRate": 5000,
		"SilverDropAmount": 100,
		"SilverDropRate": 100,
		...
	}
}
```

### Server Info

Returns more detailed information about the servers and their states.

Request: GET `/api/info/servers/`

Example Output:
```json
{
  "result": 0,
  "servers": [
    {
      "Type": 0,
      "Id": 1,
      "Ip": "127.0.0.1",
      "Port": 2000,
      "InterPort": 6001,
      "CurrentPlayers": 0,
      "MaxPlayers": 100,
      "MapIds": [],
      "Status": 0
    },
    {
      "Type": 1,
      "Id": 1,
      "Ip": "127.0.0.1",
      "Port": 7001,
      "InterPort": 0,
      "CurrentPlayers": 0,
      "MaxPlayers": 100,
      "MapIds": [11, 12, ...]
	},
	...
}
```

### Account Creation

Creates new accounts. This feature must be enabled in `web.conf`.

Request: POST `/api/account/create/`

Example Input:
```json
{ "username": "myname", "password1": "mypassword", "password2": "mypassword" }
```

Example Outputs:
```json
{ "result": 0 }
{ "result": 1, "error": "The passwords do not match." }
{ "result": 1, "error": "The account name already exists." }
```

Secure Endpoints
-----------------------------------------------------------------------------

Unlike the public endpoints, these ones aren't intended for general
use and require an authentication key. The key in question is the inter
authentication key configured in `inter.conf`, which can be communicated
to the API via the `Authorization` header.

```text
Authorization: InterKey <YourKeyHere>
```

For security reasons, this key should _never_ be shared with any users
of your server and should not be included as part of any content sent
to the users' browsers, as they would otherwise be able to use it to
gain limited administrative access. Only ever use these endpoints from
secured environments, such as password-protected control-panels or
server-side scripts.

### Messaging all Players

Broadcasts a message to all active players.

Request: POST `/api/admin/message/all/`

Example Input:
```json
{ "sender": "Admin", "message": "Foobar!" }
```

Example Output:
```json
{ "result": 0 }
```

### Kick Player

Kicks the player with the given team name from the server if they're online.

Request: POST `/api/admin/kick/team/<teamName>/`

Example Output:
```json
{ "result": 0 }
```

### Kick Players on Map

Kicks all players that are currently on the given map on any channel.
The map name is the class name found in the map data, such as `c_Klaipe`.

Request: POST `/api/admin/kick/map/<mapName>/`

Example Output:
```json
{ "result": 0 }
```

### Kick All Players

Kicks all currently active players on all channels.

Request: POST `/api/admin/kick/all/`

Example Output:
```json
{ "result": 0 }
```
