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
Melia is not being actively developed at the current time, and hasn't been
since the game's release. As a result the implemented features are few,
and the only updates that are regularly made are to keep up the compatibility
to the latest client. However, you're very welcome to work on Melia, make
pull requests, and ask questions on the chat at any time.

The features that are currently working are the following:
- Login Server
  - Character management
- Channel Server
  - Chat
  - Inventory management
  - Equipment
  - Stats
  - Skill list
  - Very basic test melee combat

Requirements
------------------------------
To *run* Melia, you need
* .NET 4.5 (Mono 4 or above)
* MySQL 5 compatible database

To *compile* Melia, you need
* C# 7 compiler, such as:
  * [Visual Studio](http://www.visualstudio.com/en-us/products/visual-studio-express-vs.aspx) (2017 or later)
  * [Monodevelop](http://monodevelop.com/) (With Mono version 5 or greater)

Installation
------------------------------
* Compile Melia
* Run `sql/main.sql` to setup the database
* Copy `system/conf/database.conf` to `user/conf/`,
  adjust the necessary values and remove the rest.

Afterwards, you should be able to start Melia via the provided scripts or
directly from the bin directories. If not, or if you need a more detailed guide,
head over to our [Gitter chat](https://gitter.im/aura-project/melia) or [wiki](https://github.com/aura-project/melia/wiki).

Contribution
------------------------------
Check the file CONTRIBUTING.md for instructions on how you may contribute.

Links
------------------------------
* GitHub: https://github.com/aura-project
* Chat: https://gitter.im/aura-project/melia
* Backlog: [https://github.com/aura-project/melia/issues](https://github.com/aura-project/aura/issues?utf8=%E2%9C%93&q=is%3Aissue+is%3Aopen+label%3Abacklog)
* Wiki: https://github.com/aura-project/melia/wiki
* Forum: https://nocodenolife.org/forum/65-melia/

Build Status
------------------------------
[![Build Status](https://travis-ci.org/aura-project/melia.png?branch=master)](https://travis-ci.org/aura-project/melia)
