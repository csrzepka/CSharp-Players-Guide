/*
Challenge: Hunted [100 XP]

While traveling through Consolas late at night, a swarm of spiderlike machines,
displaced by the Manticore spot you and begin to chase you. These hunter
machines use light flashes to signal each other in the darkness. You get lucky
and pin down one of the machines on a rooftop, away from the others, and
inspect how it works. There appears to be a hibernation command in the machine
that you think you could mimic, shutting down the whole swarm.

After a bit more analysis, it looks like the command consists of a flashing
light with a brightness of 4, 8, 15, 16, 23, and then 43 lumens. This pattern
must repeat forever to keep the swarm in hibernation.

Hurry up! You hear the spider machines skittering around the walls of the
building below you. Time is running short!

Objectives:
- Create a program that makes an array containing the sequence of numbers 4, 8,
  15, 16, 23, 42. You must use a collection expression, as shown above. Store
  this in a variable.
- Within a while (true) (or another infinite loop construct), display only the
  first number in the array (for example, Console.WriteLine(numbers[0]);).
- Within the loop, allocate a new array. Populate it with values from the
  current sequence of numbers, but move everything forward one slot while
  moving the current first item at the back of the array. The recently
  displayed number is now at the back of the array, and a new value is ready to
  be displayed.
- Note: You may use a simple for loop to populate the new array, but see if you
  can use the spread operator (discussed in the expansion above), a range
  operator (discussed in the book), and a collection expression.
*/

int[] numbers = [ 4, 8, 15, 16, 23, 42 ];

while (true)
{
    Console.WriteLine(numbers[0]);

    int[] newOrder = [ ..numbers[1..], numbers[0] ];
    numbers = newOrder;
}
