/*
Challenge: The Prototype [100 XP]

Mylara, the captain of the Guard of Consolas, has approached you with the
beginnings of a plan to hunt down The Uncoded One's airship. "If we're going to
be able to track this thing down," she says, "we need you to make us a program
that can help us home in on a location." She lays out a plan for a program to
help with the hunt. One user, representing the airship pilot, picks a number
between 0 and 100. Another user, the hunter, will then attempt to guess the
number. The program will tell the hunter that they guessed correctly or that
the number is too high or too low. The program repeats until the hunter guesses
the number correctly. Mylara claims, "If we can build this program, we can use
what we learn to build a better version to hunt down The Uncoded One's 
airship."

Sample Program:
```
User 1, enter a number between 0 and 100: 27
```
After entering this number, the program should clear the screen and continue
like this:
```
User 2, guess the number.
What is your next guess? 50
50 is too high.
What is your next guess? 25
25 is too low.
What is your next guess? 27
You guessed the number!
```

Objectives:
- Build a program that will allow the user, the pilot, to enter a number.
- If the number is above 100 or less than 0, keep asking.
- Clear the screen once the program has collected a good number.
- Ask a second user, the hunter, to guess numbers.
- Indicate whether the user guessed too high, too low, or guessed right.
- Loop until they get it right, then end the program.
*/

// User 1
int number;
do
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    number = Convert.ToInt32(Console.ReadLine());
} 
while (number < 0 || number > 100); // Repeat if number not between 0 and 100.

Console.Clear();

// User 2
Console.WriteLine("User 2, guess a number.");

int guess;
do
{
    Console.Write("What is your next guess? ");
    guess = Convert.ToInt32(Console.ReadLine());

    if (guess > number)
        Console.WriteLine($"{guess} is too high.");
    else if (guess < number)
        Console.WriteLine($"{guess} is too low.");
}
while (guess != number);

Console.WriteLine("You guessed the number!");
