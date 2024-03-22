Melia
=============================================================================

Melia is an open-source MMORPG server, developed as a collaborative affort
of programmers from all around the world. We're aiming to create a server
software that provides a stable and extensible platform for users to build
their own projects on top of, while giving developers the oppurtunity to
learn and hone their skills in a familar environment.

This project is very explicilty not about playing a game or competing
with any services provided by game developers or publishers, and we don't
endorse such actions. We're here to learn and create, not to steal or
destroy.

Client
-----------------------------------------------------------------------------

Melia does not have a client of its own at this time. Instead, it's designed
to be network compatible with the latest client of the international
version of ToS, which is freely available on Steam.

State of Development
-----------------------------------------------------------------------------

Melia has been in semi-active development for several years, and is
being worked on more or less depending on the time and motivation of
the available developers. The server is functional and provides many
of the typical features you would expect from an online RPG, but
there's still a way to go before we'd call it truly playable.

Specifically, some of the major features that are working are as follows:
- Characters (creation, deletion, etc.)
- Inventory (managing items, equipping, etc.)
- Chat
- Stats
- Skills
  - Distrbution of skill points
  - Basic and experimental combat, incl. monster AI
  - Basic and experimental support for select skills
- NPC dialogues and shops
- Monster spawns
- Quests

Requirements
-----------------------------------------------------------------------------

### Pre-requisites

- InnoDB compatible server, such as:
  - [MySQL 5](https://dev.mysql.com/downloads/mysql/5.7.html) or
    [MariaDB 10](https://mariadb.org/download/)

### Building on Linux/macOS

- [Mono 5](https://www.mono-project.com/download/stable/)
- [Mono Develop](https://www.monodevelop.com/download/)

### Building on Windows

- [.NET 4.6.2 SDK](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net462-developer-pack-offline-installer)
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) (2017 or later) (Community Edition is free)

### Running on Linux/macOS

- [Mono 5](https://www.mono-project.com/download/stable/)

### Running on Windows

- [.NET 4.6.2 Runtime](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net462-offline-installer)

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

