Spawns
=============================================================================

Monsters
-----------------------------------------------------------------------------

Monster spawners manage a certain population of usually aggressive NPCs
(mobs) by automatically spawning and respawning them as needed, across one
or multiple areas. It's possible to create a simple monster spawner with
a fixed area and population, but spawners are also capable of spreading
their potential population across multiple areas.

This is an example of a simple monster spawner. It keeps up a population
of 10 to 15 Kepas, respawning them with a delay of 30 seconds, all within
the same area on the map "f_siauliai_west". The population will scale up
as monsters are killed, but it won't exceed the maximum of 15.

```cs
AddSpawner(MonsterId.Onion, min: 10, max: 20, Seconds(30), "f_siauliai_west", Rectangle(-1603, -634, 80));
```

An example of a more complex monster spawner might look like this, where
the population is spread across multiple areas for a more dynamic and less
predictable experience.

It creates a spawner with the identifier "f_siauliai_west.Example" that
manages a population of 20 to 40 Kepas, as well as a series of spawn
points, or areas, that the spawner will utilize to spawn the monsters.
The spawn points simply reference the identifier of the spawner to
associate them with.

```cs
AddSpawner("f_siauliai_west.Example", MonsterId.Onion, min: 20, max: 40);
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1545, -1109, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1942, -1147, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1719, -765, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1977, -439, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1893, 58, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1681, -1208, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-2062, -1299, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1846, -994, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1934, -120, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1832, 282, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1812, -419, 80));
```

It's also possible for multiple spawners to share the same spawn points,
for a more varied monster population. This example would keep a certain
population of both Kepas and Leaf Bugs across the same areas on the map.

```cs
AddSpawner("f_siauliai_west.Example", MonsterId.Onion, min: 20, max: 40);
AddSpawner("f_siauliai_west.Example", MonsterId.Leaf_Diving, min: 20, max: 20);
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1545, -1109, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1545, -1109, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1942, -1147, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1719, -765, 80));
AddSpawnPoint("f_siauliai_west.Example", "f_siauliai_west", Rectangle(-1977, -439, 80));
```

For more examples, please see the existing map scripts, such as the one
for "f_siauliai_west" in the scripts folder.

### API

```cs
AddSpawner(int monsterClassId, int amount, TimeSpan respawn, string map, IShapeF area)
AddSpawner(int monsterClassId, int amount, TimeSpan respawn, string map, IShapeF area, TendencyType tendency)
AddSpawner(int monsterClassId, int min, int max, TimeSpan respawn, string map, IShapeF area)
AddSpawner(int monsterClassId, int min, int max, TimeSpan respawn, string map, IShapeF area, TendencyType tendency)
AddSpawner(int monsterClassId, int min, int max, TimeSpan initialSpawn, TimeSpan minRespawn, TimeSpan maxRespawn, string map, IShapeF area, TendencyType tendency)

AddSpawner(string identifier, int monsterClassId, int amount, TimeSpan respawn = default, TendencyType tendency = TendencyType.Peaceful)
AddSpawner(string identifier, int monsterClassId, int min, int max, TimeSpan respawn = default, TendencyType tendency = TendencyType.Peaceful)
AddSpawner(string identifier, int monsterClassId, int min, int max, TimeSpan initialSpawn, TimeSpan minRespawn, TimeSpan maxRespawn, TendencyType tendency)

AddSpawnPoint(string identifier, string mapClassName, IShapeF area)
```
