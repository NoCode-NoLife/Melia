Melia
==============================

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
------------------------------
Melia is only compatible to the latest iTOS client,
compatibility to any other clients or versions is
not guaranteed, and in fact unlikely.

State of Development
------------------------------
Unfortunately, Melia hasn't been in active development for years, though
there's been some recent activity again. At the current time, Melia is
mostly compatible to the latest version of iToS again, you're very welcome
to work on Melia, make pull requests, and ask questions on the chat at any
time. However, don't expect much outside of some base features yet.

The features that are currently working are the following:
- Login Server
  - [x] Character management
- Channel Server
  - [x] Getting in-game
  - [x] Chat
  - [x] Inventory management
  - [x] Equipment
  - [ ] Stats
  - [x] Skill list
  - [x] Very basic test melee combat
  - [x] NPC dialog
  - [ ] NPC shops
  - [x] Monster spawning via script

Requirements
------------------------------

### Running on Linux/macOS

- [Mono 5](https://www.mono-project.com/download/stable/)
- [MySQL 5](https://dev.mysql.com/downloads/mysql/5.7.html)

### Running on Windows

- [.NET 4.6.2 Runtime](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net462-offline-installer)
- [MySQL 5](https://dev.mysql.com/downloads/mysql/5.7.html)

### Building on Linux

- [Mono 5](https://www.mono-project.com/download/stable/)
- [Mono Develop](https://www.monodevelop.com/download/)

### Building on macOS

- [Mono 5](https://www.mono-project.com/download/stable/)
- [Mono Develop](https://www.monodevelop.com/download/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)


### Building on Windows

- [.NET 4.6.2 SDK](https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net462-developer-pack-offline-installer)
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) (Visual Studio 2017 or later) (Community Edition is free)

Installation
------------------------------
* Compile Melia
* Run `sql/main.sql` to setup the database
* Copy `system/conf/database.conf` to `user/conf/`,
  adjust the necessary values and remove the rest.

Afterwards, you should be able to start Melia via the provided scripts or
directly from the bin directories. If not, or if you need a more detailed guide,
head over to our forum, the chat, or the wiki.

Contribution
------------------------------
Check the file CONTRIBUTING.md for instructions on how you may contribute.

Links
------------------------------
* GitHub: https://github.com/NoCode-NoLife/melia
* Backlog: [https://github.com/NoCode-NoLife/melia/issues](https://github.com/NoCode-NoLife/melia/issues?utf8=%E2%9C%93&q=is%3Aissue+is%3Aopen+label%3Abacklog)
* Wiki: https://github.com/NoCode-NoLife/melia/wiki
* Forum: https://nocodenolife.org/forum/65-melia/
* Chat: https://discord.gg/5sszEgw

Build Status
------------------------------
[![Build Status](https://travis-ci.org/NoCode-NoLife/melia.png?branch=master)](https://travis-ci.org/aura-project/melia)
