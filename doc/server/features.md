Features
=============================================================================

The features data file controls whether certain functionalities are
enabled or disabled on the server, such as the availability of certain
items and jobs, or the behavior of skills, among many other things. It's
essentially a list of toggles that let you customize your gameplay
experience to your liking.

Hierarchy
-----------------------------------------------------------------------------

The data is organized in a tree structure, where a parent feature can have
any number of child features. Consider the following example, with six
features. "ReBuild" is the overall parent, followed by its child
"MovementRevamp", and its children, "FreeRunning", "FreeDashingInCities",
and so on.

system/data/features.txt
```json
{ name: "ReBuild", enabled: true, children: [
	{ name: "MovementRevamp", enabled: true, children: [
		{ name: "FreeRunning", enabled: true },
		{ name: "FreeDashingInCities", enabled: true },
		{ name: "DashingForAll", enabled: true },
		{ name: "FreeJumping", enabled: true },
	]},
```

If you change the enabled value of "ReBuild" to false, you disable not
only "ReBuild", but also all of its children. This also applies if you
take "ReBuild" and put it on its own, either further down in the system
features file or a separate features file in the user folder.

user/data/features.txt
```json
{ name: "ReBuild", enabled: false },
```

The above line would disable all six "ReBuild" features seen in the first
example. If you wanted to disable all but one of them, you could first
disable "ReBuild" and then enable the one you want. For example:

user/data/features.txt
```json
{ name: "ReBuild", enabled: false },
{ name: "DashingForAll", enabled: true },
```

Keep in mind that every time you enable or disable a feature, you also
enable and disable all of its children, which makes order important. If
you first enabled "DashingForAll" and then disabled "ReBuild", you would
effectively disable "DashingForAll" again, because it's a child of
"ReBuild".

We expect you to most commonly enable entire feature branches at once,
disable some feature you don't like, or enable features of later patches.
For these cases, you should simply cherry pick the specific features, put
them into the features file in the user folder, and remember to put a
feature's children after the feature itself, just like in the example
above.
