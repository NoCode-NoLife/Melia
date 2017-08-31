Filing issues
=============================================================================

TODO

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
* Avoid overuse of regions.

EditorConfig compatible IDEs like VS2017 will automatically switch to
formatting settings that match the coding conventions as much as possible.

Branching Streategy
------------------------------
`master` is the stable branch, geared towards normal users. It should be
compilable and working at all times, with little to no debug or test code.

For every feature or fix that goes beyond a handful of lines, a branch is
created, that acts as a kind of "beta" branch for that feature.
These branches aren't merged into master until a core developer has
reviewed the code.
