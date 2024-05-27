/* 
Boss Battle: The Point [75 XP]

The first pedestal asks you to create a Point class to store a point in two
dimensions. Each point is represented by an x-coordinate (x), a side-to-side
distance from a special central point called the origin, and a y-coordinate
(y), an up-and-down distance away from the origin.

Objectives:
- Define a new Point class with properties for X and Y.
- Add a constructor to create a point from a specific x- and y-coordinate.
- Add a parameterless constructor to create a point at the origin (0, 0).
- In you main method, create a point at (2, 3) and another at (-4, 0). Display
  these points on the console window in the format (x, y) to illustrate that
  the class works.
- Answer this question: Are your X and Y properties immutable? Why did you
  choose what you did?
*/

// MAIN

Point p1 = new Point(2, 3);
Point p2 = new Point(-4, 0);

Console.WriteLine($"({p1.X}, {p1.Y})");
Console.WriteLine($"({p2.X}, {p2.Y})");

// CLASSES

public class Point
{
	public float X { get; set; }
	public float Y { get; set; }

	public Point(float x, float y) { X = x; Y = y; }
	public Point() { X = 0; Y = 0; }
}

//// Answer this question: Are your X and Y properties immutable?
// No, my X and Y properties are not immutable. You can tell this is the case
// because they both have public setters, so the values can be changed.
//
//// Why did you choose what you did?
// I did not see any reason that the Point class should be immutable. With the
// current described functionality, the Point class is merely an object to 
// represent point-based data, and it would make sense to be able to change
// that data over time, like in the Asteroids example, where X and Y position
// variables need to be updated as they drift through space.
//
// However, I recognize that because the problem did not specify that we would
// want the Point class to be mutable, it could be better to make it immutable
// until we have a reason to change it, which would better follow Rule #4 from
// Level 23 on Object-Oriented Design (Designs should not have unused or
// unnecessary elements), where the setters are both unused and unnessary in
// this context.
