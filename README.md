Melia
==============================

Melia is an open-source server emulator written in C#. It's solely being
developed for educational purposes, learning about programming, MMORPGs,
maintaining huge projects, working with other people, and improving knowledge.
It's not about playing a game or competing with any services provided by
IMCGAMES or its partners, and we don't endorse such actions.

Melia is completely free and licensed under the GNU GPL.
As such, every user is free to use Melia and choose how to use it.

Compatibility
------------------------------
Melia is currently being developed for the iCBT client, and is
most likely only compatible to that version.

Requirements
------------------------------
To *run* Melia, you need
* .NET 4.5 (Mono 3.0+)
* MySQL 5 compatible database

To *compile* Melia, you need
* C# 5 compiler, such as:
  * [Visual Studio](http://www.visualstudio.com/en-us/products/visual-studio-express-vs.aspx) (2012 or later)
  * [Monodevelop](http://monodevelop.com/) (With mono version 3 or greater)
  * [SharpDevelop](http://www.icsharpcode.net/OpenSource/SD/) (Version 4.4 or greater)

Installation
------------------------------
* Compile Melia
* Run `sql/main.sql` to setup the database
* Copy `system/conf/database.conf` to `user/conf/`,
  adjust the necessary values and remove the rest.

Afterwards, you should be able to start Melia via the provided scripts or
directly from the bin directories.
