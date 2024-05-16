/*
Challenge: The Replicator of D'To [100 XP]

While searching an abandoned storage building containing strange artifacts, you
uncover the ancient Replicator of D'To. This can replicate the contents of any
int array into another array. But it appears broken and needs a Programmer to
reforge the magic that allows it to replicate once again.

Objectives:
- Make a program that creates an array of length 5.
- Ask the user for five numbers and put them in the array.
- Make a second array of length 5.
- Use a loop to copy the values out of the original array and into the new one.
- Display the contents of both arrays one at a time to illustrate that the
  Replicator of D'To works again.
*/

int[] array = new int[5];

Console.WriteLine("Enter 5 values to fill an array:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int[] copyArray = new int[5];

Console.WriteLine("Copying the array values to a second array...");
for (int i = 0; i < copyArray.Length; i++)
    copyArray[i] = array[i];

Console.WriteLine("Values of both arrays:");
for (int i = 0; i < 5; i++)
    Console.WriteLine($"{i}: {array[i]}, {copyArray[i]}");
