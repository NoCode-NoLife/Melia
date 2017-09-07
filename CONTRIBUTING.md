Filing issues
=============================================================================

Before filing an issue, use the search function to see if a similar
issue might exist already.

Bugs
-----------------------------------------------------------------------------
If you've found a bug in Melia, please create a new issue just for that
one bug, explaining what was going on when it happened and how it can
be reproduced. If necessary, you may include screen shots or videos as
well.

However, keep in mind that Melia is still very early in development,
and something not working might not be a bug, but simply something
nobody has worked on yet.

Suggestions
-----------------------------------------------------------------------------
We are happy to listen to your ideas on how to improve Melia as a server
emulator, just create an issue for your idea, and we will take a look at
it. Please understand that our main focus is emulating the main game though,
and suggestions for custom NPCs, or completely custom features that have
little to do with the game might be out-of-scope for us.

Discussions
----------------------------------------------------------------------------
If you're working on a feature for Melia and you want to let others know
about it, get their input, or talk about how to best implement or how
to change something, create an issue for that discussion, which will
serve as the thread for discussing that one topic.

We're in this together, and the more we work together, the better Melia
will be.

Contributing code
=============================================================================

We welcome contributions via pull requests (PR), be it new features,
bug fixes, or updates. To make the process of reviewing and merging
your PR as comfortable as possible for all involved parties, we ask
you to follow the following guidelines.

- Your pull request should be as concice as possible, focusing
  on as few related things as possible (for example: one PR per bug fix).
- Your commit messages should be clear and descriptive (for example:
  "Fixed bug XY", "Added feature YZ").
- You should give a short description of what your PR accomplishes.
- The PR should be based on a resonably recent fork of the `master` branch.
- Your code should follow the coding conventions below.
- Big changes to the code base should be discussed in issues before
  they are pushed, to discuss potential implementions and to get an
  overview of what all contributors are working on.

Coding conventions
------------------------------
## C#
* Base: [MS Naming Guidelines](http://msdn.microsoft.com/en-us/library/xzf533w0%28v=vs.71%29.aspx),
        [MS C# Coding Conventions](http://msdn.microsoft.com/en-us/library/ff926074.aspx)
* Exceptions:
  * Use `_camelCase` for private fields and `this.PascalCase` for
    properties, public fields, and methods.
  * Use tabs, not spaces.
* Comment lines shouldn't exceed ~80 characters, other lines' lengths
  are irrevelant.
* Excessive usage of the auto-formatting feature is encouraged.
  (Addon Suggestion: [Format document on Save](https://marketplace.visualstudio.com/items?itemName=mynkow.FormatdocumentonSave))
* Regions should be used sparingly.
* A space should be used after a comment. For example, `// comment`.
* Property setters and getters should be simple and not do anything
  that is not directly related to setting or getting the value.
  They should not run complicated calculations or send packets.
* Pure getter methods should be avoided in favor of properties,
  unless they do more than just returning a value.

EditorConfig compatible IDEs like VS2017 will automatically switch to
formatting settings that match the coding conventions as much as possible.

## JSON
* Our JSON based databases are arrays of objects on the lowest indent level.
  Only sub-objects and -array may be indented with tabs.
* All keys should use `camelCase` and no quotation.
* All values should use a representing type. For example, bool instead
  of "YES" and "NO" strings.
* No comments should be placed at the end of lines.
* Comments should only be used sparingly, to categorize data. Comments
  that explain data or functions should go into the header.
* A space should be used after a comment. For example, `// comment`.

## Lua
* Lua scripts should use tabs for indention.
* Words in variables and functions should run together, as done in standard
  Lua, e.g. `somefunction`. Underscores are acceptable as separators in
  some situations, such as between the name and the "category" of a
  function, e.g. `npchandler_nameofnpc`.
* Constants should be all upper-case, with words separated by underscores.
  For example, `SOME_CONSTANT`.
* Locals should be used in favor of globals whenever possible.
* A space should be used after a comment. For example, `-- comment`.

Branching Strategy
------------------------------
`master` is the stable branch, geared towards normal users. It should be
compilable and working at all times, with little to no debug or test code.

For every feature or fix that goes beyond a handful of lines, a branch is
created, that acts as a kind of "beta" branch for that feature.
These branches aren't merged into master until a core developer has
reviewed the code.
