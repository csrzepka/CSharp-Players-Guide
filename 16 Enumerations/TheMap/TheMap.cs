/*
Challenge: The Map [150 XP]

You've recently purchased a map of the island you've arrived at, but it isn't
formatted well, and you know you can do better by putting the map data into a
program. While you sit in a tavern, warmed by a large fire that is repelling a
chill from the wind outside, sipping on a hot apple cider and munching on
rustic bread and tangy cheese, you sit down to make a map program.

After carefully studying the map you've got, you sketch out on the paper that
this is what the map is suppose to look like when presented well:
┌────┬────┬────┬────┬────┬────┬────┬────┐
│ ~~ │    │ () │    │ ~~ │    │ ~~ │ ~~ │
├────┼────┼────┼────┼────┼────┼────┼────┤
│ ^^ │    │    │    │ ~~ │    │    │ ~~ │
├────┼────┼────┼────┼────┼────┼────┼────┤
│ ~~ │ ^^ │    │    │    │    │    │    │
├────┼────┼────┼────┼────┼────┼────┼────┤
│ ~~ │ ~~ │ ^^ │ () │ ^^ │ ~~ │ ~~ │ ~~ │
└────┴────┴────┴────┴────┴────┴────┴────┘
The gray waves ("~~") are water, and the others are different types of land.
The empty spaces are plain land ("  "), the two inverted "v" symvols are
mountains ("^^"), and the dots are cities ("()").

Objectives:
- Define an enumeration to represent the four types of terrain found in the map
  above.
- Create a 2D array that uses your new enumeration in your main method. Fill in
  its values to mirror the map shown above.
- Write a method to display the map above in the console window using "~~" to
  represent water, "^^" to represent mountains, "()" to represent cities, and
  " " to represent open land.
- Set up your main method to call your new method, passing it the map array.
- Hint: Two nested for loops are a good way to loop through the whole map.
- Hint: Consider a switch expression to convert from the specific enumeration
  values to their text representations.
*/

// using C#12 collection expressions:
Terrain[][] map =
[
    [ Terrain.Water,     Terrain.Plains,    Terrain.City,      Terrain.Plains, Terrain.Water,     Terrain.Plains, Terrain.Water,  Terrain.Water ],
    [ Terrain.Mountains, Terrain.Plains,    Terrain.Plains,    Terrain.Plains, Terrain.Water,     Terrain.Plains, Terrain.Plains, Terrain.Water ],
    [ Terrain.Water,     Terrain.Mountains, Terrain.Plains,    Terrain.Plains, Terrain.Plains,    Terrain.Plains, Terrain.Plains, Terrain.Plains ],
    [ Terrain.Water,     Terrain.Water,     Terrain.Mountains, Terrain.City,   Terrain.Mountains, Terrain.Water,  Terrain.Water,  Terrain.Water ],
];

DisplayMap(map);

// METHODS

void DisplayMap(Terrain[][] map)
{
    foreach (Terrain[] row in map)
    {
        foreach (Terrain terrain in row)
        {
            string terrainText = TerrainToString(terrain);
            Console.Write(terrainText + " ");
        }

        Console.WriteLine();
    }
}

string TerrainToString(Terrain terrain) => terrain switch
{
    Terrain.Water     => "~~",
    Terrain.Mountains => "^^",
    Terrain.Plains    => "  ",
    Terrain.City      => "()",
    _                 => "  "
};

// ENUMS

enum Terrain { Water, Mountains, Plains, City }
