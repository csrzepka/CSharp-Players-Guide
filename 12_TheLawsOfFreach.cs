/*
Challenge: The Laws of Freach [50 XP]

The town of Freach had an awful looping disaster. The lead investigator found
that it was a faulty ++ operator in an old for loop, but the town council has
chosen to ban all loops but the foreach loop. Yet Freach uses the code
presented earlier in this level to compute the minimum and average value in an
int array. They have hired you to rework their existing for-based code to use
foreach loops instead.

Objectives:
- Start with the code for computing an array's minimum and average values in
  the section Some Examples with Arrays, starting on page 94.
- Modify the code to use foreach loops instead of for loops.
*/

// Min Value Example:
// int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
//
// int currentSmallest = int.MaxValue; // Start higher than anything in the array.
// for (int index = 0; index < array.Length; index++)
// {
// 	if (array[index] < currentSmallest)
// 		currentSmallest = array[index];
// }
//
// Console.WriteLine(currentSmallest);

// Average Value Example:
// int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
//
// int total = 0;
// for (int index = 0; index < array.Length; index++)
// 	total += array[index];
//
// float average = (float)total / array.Length;
// Console.WriteLine(average);

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

// Min Value
int currentSmallest = int.MaxValue; // Start with high value
foreach (int x in array)
    if (x < currentSmallest) currentSmallest = x;

Console.WriteLine(currentSmallest);

// Average Value
int total = 0;
foreach (int x in array)
    total += x;

float average = (float)total / array.Length;
Console.WriteLine(average);
