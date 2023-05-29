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

- Your pull requests and commits should be as concice as possible, focusing
  on as few related things as possible. For example: one PR per bug fix.
- Your commit messages should be clear and descriptive. For example:
  "Fixed bug XY" or "Added feature YZ".
- You should give a short description of what your PR accomplishes.
- The PR should be based on a resonably recent fork of the `master` branch.
- Your code should follow the coding conventions below.
- Big changes to the code base should be discussed in issues before
  they are pushed, to discuss potential implementions and to get an
  overview of what all contributors are working on.

Coding conventions
-----------------------------------------------------------------------------
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
* Variable types should be ommited wherever appropriate, in favor of `var`.
* Unless the full name of a class is necessary to clarify to the compiler
  which class is to be used, the `using` directive should always be used,
  so the full name isn't necessary in the actual code. For example, use
  `Console.WriteLine(...)` over `System.Console.WriteLine(...)`.
* File names should generally not have prefixes, like for example "I" for a
  file containing an interface.

EditorConfig compatible IDEs like VS2017+ will automatically switch to
formatting settings that match the coding conventions as much as possible.

## JSON
* Our JSON based databases are arrays of objects on the lowest indent level.
  Only sub-objects and -arrays may be indented with tabs.
* All keys should use `camelCase` and no quotation.
* All values should use a representing type. For example, prefer a bool
  over "YES" and "NO" strings.
* No comments should be placed at the end of lines.
* Comments should be used sparingly, to categorize data. Comments
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

## Binary Templates
* Should use tabs for indention.
* Use PascalCase for structs and enums.
* Use camelCase for variables, fields, and functions.
* Optionally, UPPER_SNAKE_CASE may be used where appropriate, for the names
  of official structs, such as `APPEARANCE_PC`.
* A space should be used after a comment. For example, `// comment`.
* Every binary template should ideally document the version of the game
  it was created for and the changes that happened over time, in the
  Version and History sections of the header respectively.

Branching Strategy
-----------------------------------------------------------------------------

`master` is the stable branch, geared towards normal users. It should be
compilable and working at all times, with little to no debug or test code.

For every feature or fix that goes beyond a handful of lines, a
branch is created that acts as a kind of "beta" branch for that
feature. These branches are to be named appropriately, based on
their content and potentially the issues they reference. For example,
a branch for implementing feature Foobar, that is outlined in issue
#2447, might be named "feature/2447-foobar", and a branch for fixing
a skill bug in issue #1029 might be named "fix/1029-skill-bug".

Once the feature, fix, or update is complete, a PR is created, the branch
is reviewed by the maintainers, and then merged into `master`.

Fork and Pull Request Strategy
-----------------------------------------------------------------------------

For managing your work and pull requests for Melia as an outside
contributor, we recommend the following process.

1. Fork Melia on GitHub.
2. Add the main repository as a remote.
3. Pull the latest changes from Melia's `master` into your local branch
   regularly.
4. Never push to your fork's `master` branch directly.
5. Adopt the same branching strategy as lined out above.
6. Create pull requests from your branches to Melia's master once you're
   done.

With this approach, you always have a clean master to branch off of,
your changes naturally make their way into your fork by updating
from the upstream repository, and you keep your changes organized.

This is just a suggestions of course, and as long as you follow the other
guidelines, your fork is your fork.
