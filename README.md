Melia
==============================

Melia is an open-source MMORPG server software for the international client of Tree of Savior.
It's solely being developed for educational purposes, learning about programming, MMORPGs,
maintaining huge projects, working with other people, and improving knowledge.
It's not about playing a game or competing with any services provided by
IMCGAMES or its partners, and we don't endorse such actions.

Melia is completely free and licensed under the GNU GPL.
As such, every user is free to use Melia and choose how to use it,
in the context of its license.

Compatibility
------------------------------
Melia is compatible to version 164556 of the iTOS client.  
Compatibility to any other clients or versions is not guaranteed, and in fact unlikely.

Requirements
------------------------------
To *run* Melia, you need
* .NET 4.5 (Mono 3.0 or above)
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
directly from the bin directories. If not, or if you need a more detailed guide,
head over to our [forums](http://aura-project.org/forum/), [Gitter chat](https://gitter.im/aura-project/melia), or [wiki](https://github.com/aura-project/melia/wiki).

Contribution
------------------------------
There are 4 ways **you** can help us to improve Melia:

1. Research
2. Bug reports
3. Pull Requests
4. Releases on the forums

### 1. Research
Do research on NPCs, quests, skills, anything really that isn't implemented yet and
post it on our [research forum](http://aura-project.org/forum/forum/70-research/).
The information you post will help developers to implement the features. 

### 2. Bug reports
Report bugs on [GitHub](https://github.com/aura-project/melia/issues), so they can be fixed ASAP.

### 3+4. Code
The fastest way to get code contributions into the source is a pull request, which,
if well written, can be merged right in to *master*. To expediate this process, 
all pull requests must comply with our coding conventions below.

Alternatively you can make "casual" releases on the forum, which developers might pick up
as research or as a base to implement the features into the official source.

#### Coding conventions
* Base: [MS Naming Guidelines](http://msdn.microsoft.com/en-us/library/xzf533w0%28v=vs.71%29.aspx),
        [MS C# Coding Conventions](http://msdn.microsoft.com/en-us/library/ff926074.aspx)
* Exceptions:
  * Use `_private` for private fields and `this.Foobar` for properties, public fields, and methods.
  * Use tabs, not spaces.
* Comment lines shouldn't exceed ~80 characters, other lines' lengths are irrevelant.
* Excessive usage of the auto-formatting feature is encouraged. (Default VS settings)
* Avoid overuse of regions.

Branching Streategy
------------------------------
`master` is the stable branch, geared towards normal users. It should be
compilable and working at all times, with little to no debug or test code.

For every feature or fix that goes beyond a handful of lines, a branch is
created, that acts as a kind of "beta" branch for that feature.
These branches aren't merged into master until a core developer has
reviewed the code.

Links
------------------------------
* Forums: http://aura-project.org/
* GitHub: https://github.com/aura-project
* Gitter chat: https://gitter.im/aura-project/melia
* Backlog: [https://github.com/aura-project/melia/issues](https://github.com/aura-project/aura/issues?utf8=%E2%9C%93&q=is%3Aissue+is%3Aopen+label%3Abacklog)
* Wiki: https://github.com/aura-project/melia/wiki

Build Status
------------------------------
[![Build Status](https://travis-ci.org/aura-project/melia.png?branch=master)](https://travis-ci.org/aura-project/melia)

