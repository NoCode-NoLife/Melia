Melia
=============================================================================

Melia is an open-source MMORPG server software for the international client
of Tree of Savior. It's solely being developed for educational purposes,
learning about programming, MMORPGs, maintaining huge projects, working with
other people, and improving knowledge. It's not about playing a game or
competing with any services provided by IMCGAMES or its partners, and we
don't endorse such actions.

Melia is completely free and licensed under the GNU GPL.
As such, every user is free to use Melia and choose how to use it,
in the context of its license.

Compatibility
-----------------------------------------------------------------------------
Melia is only compatible to the latest iTOS client, compatibility to any
other clients or versions is not guaranteed, and in fact unlikely.

State of Development
-----------------------------------------------------------------------------
After years of inactivity, Melia is currently in semi-active development
again. The server is functional and it's compatible with the latest
iToS client, but the server can't be called "playable" yet, as many
features and especially the content are still missing.

The major features that are currently working are as follows.

**Login Server**
- Character management (creation, deletion, etc.)

**Channel Server**
- Chat
- Inventory management (managing items, equipping, etc.)
- Stats
- Skills
  - Distrbution of skill points
  - Basic and experimental combat
  - Basic and experimental support for selected skills
- NPC dialogues
- NPC shops
- Monster spawns

Requirements
-----------------------------------------------------------------------------

### General Pre-requisites

- InnoDB compatible Server such as
  - [MySQL 5](https://dev.mysql.com/downloads/mysql/5.7.html) or
    [MariaDB 10](https://mariadb.org/download/)
- Sufficient hardware resources for the emulator.
  - Recommended: 1GB
  - Minimum: 256MB
- Sufficient storage for the database.
  - Recommended: 4GB
  - Minimum: 100MB

### Running on Linux/macOS

- [Mono 5](https://www.mono-project.com/download/stable/)

### Running on Windows

- [.NET 4.6.2 Runtime](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net462-offline-installer)

### Building on Linux/macOS

- [Mono 5](https://www.mono-project.com/download/stable/)
- [Mono Develop](https://www.monodevelop.com/download/)

### Building on Windows

- [.NET 4.6.2 SDK](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net462-developer-pack-offline-installer)
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) (2017 or later) (Community Edition is free)

Installation
-----------------------------------------------------------------------------
* Compile Melia
* Run `sql/main.sql` to setup the database
* Copy `system/conf/database.conf` to `user/conf/`,
  adjust the necessary values and remove the rest.

Afterwards, you should be able to start Melia via the provided scripts or
directly from the bin directories. If not, or if you need a more detailed
guide, head over to our forum, the chat, or the wiki.

Contribution
-----------------------------------------------------------------------------
Check the file CONTRIBUTING.md for instructions on how you may contribute.

Links
-----------------------------------------------------------------------------
* GitHub: https://github.com/NoCode-NoLife/melia
* Wiki: https://github.com/NoCode-NoLife/melia/wiki
* Forum: https://nocodenolife.org/forum/65-melia/
* Chat: https://discord.gg/5sszEgw

Build Status
-----------------------------------------------------------------------------
[![Build Status](https://travis-ci.org/NoCode-NoLife/melia.png?branch=master)](https://travis-ci.org/aura-project/melia)
