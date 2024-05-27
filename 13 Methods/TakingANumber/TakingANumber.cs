/*
Challenge: Taking a Number [100 XP]

Many previous tasks have required getting a number from a user. To save time
writing this code repeatedly, you have decided to make a method to do this
common task.

Objectives:
- Make a method with the signature int AskForNumber(string text). Display the
  text parameter in the console window, get a response from the user, convert
  it to an int, and return it. This might look like this: 
  int result = AskForNumber("What is the airspeed velocity of an unladen 
  swallow?");
- Make a method with the signature: 
  int AskForNumberInRange(string text, int min, int max). 
  Only return if the entered number is between the min and max values. 
  Otherwise, ask again.
- Place these methods in at least one of your previous programs to improve it.
*/

/// <summary>
/// Prompts user with <string>text to enter a number and returns number.
/// </summary>
int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

/// <summary>
/// Prompt user to enter a number in range min to max, using message text.
/// Will ask user again until number is within range.
/// </summary>
int AskForNumberInRange(string text, int min, int max)
{
    int number;

    do
    {
        Console.Write(text + " ");
        number = Convert.ToInt32(Console.ReadLine());
    } 
    while (number < min || number > max);

    return number;
}

// Repeating Challenge: The Prototype (Level 11) with new methods
int number = AskForNumberInRange("User 1, enter a number between 0 and 100:", 0, 100);
Console.Clear();
Console.WriteLine("User 2, guess the number.");

while (true)
{
    int guess = AskForNumber("What is your next guess?");

    if (guess > number) Console.WriteLine($"{guess} is too high.");
    else if (guess < number) Console.WriteLine($"{guess} is too low.");
    else break;
}

Console.WriteLine("You guessed the number!");
