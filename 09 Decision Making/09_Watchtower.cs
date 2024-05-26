/*
Challenge: Watchtower [100 XP]

There are watchtowers in the region around Consolas that can alert you when an
enemy is spotted. With some help from you, they can tell you which direction
the enemy is from the watchtower.

     x<0  x=0  x>0
    ┌────┬────┬────┐
y>0 │ NW ┆ N  ┆ NE │
    ├┄┄┄┄┼┄┄┄┄┼┄┄┄┄┤
y=0 │ W  ┆ !  ┆ E  │
    ├┄┄┄┄┼┄┄┄┄┼┄┄┄┄┤
y<0 │ SW ┆ S  ┆ SE │
    └────┴────┴────┘

Objectives:
- Ask the user for an x and y value. These are coordinates of the enemy
  relative to the watchtower's location.
- Using the diagram above, if statements, and relational operators, display
  a message about what direction the enemy is coming from. For example,
  "The enemy is to the northwest!" or "The enemy is here!"
*/

Console.Write("Enter x coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x < 0)
{
    if (y > 0)
        Console.WriteLine("The enemy is to the northwest!");
    else if (y == 0)
        Console.WriteLine("The enemy is to the west!");
    else if (y < 0)
        Console.WriteLine("The enemy is to the southwest!");
}
else if (x == 0)
{
    if (y > 0)
        Console.WriteLine("The enemy is to the north!");
    else if (y == 0)
        Console.WriteLine("The enemy is here!");
    else if (y < 0)
        Console.WriteLine("The enemy is to the south!");
}
else if (x > 0)
{
    if (y > 0)
        Console.WriteLine("The enemy is to the northeast!");
    else if (y == 0)
        Console.WriteLine("The enemy is to the east!");
    else if (y < 0)
        Console.WriteLine("The enemy is to the southeast!");
}
