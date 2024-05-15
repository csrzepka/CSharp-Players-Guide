/*
Challenge: Discounted Inventory [50 XP]

After sorting through Tortuga's outfitter shop and making it viable again,
Tortuga realizes you've put him back in business. He wants to repay the favor
by giving you a 50% discount on anything you buy from him, and he wants you to
modify your program to reflect that.

After asking the user for a number, the program should also ask for their name.
If the name supplied is your name, cut the price in half before reporting it to
the user.

Objectives:
- Modify your program from before to also ask the user for their name.
- If their name equals your name, divide the cost in half.
*/

// NOTE: Code modified from other example to practice with switch expressions.

// Raw String Literals introduced in the C# 11 expansion, added to level 8
Console.WriteLine("""
    The following items are available:
    1 - Rope
    2 - Torches
    3 - Climbing Equipment
    4 - Clean Water
    5 - Machete
    6 - Canoe
    7 - Food Supplies
    """);

Console.Write("What number do you want to see the price of? ");
int choice = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your name? ");
string name = Console.ReadLine();

float discount = (name == "Chris" ? 0.5f : 1.0f );

string response;
response = choice switch
{
    1 => $"Rope cost {10 * discount} gold.",
    2 => $"Torches cost {15 * discount} gold.",
    3 => $"Climbing Equipment cost {25 * discount} gold.",
    4 => $"Clean Water cost {1 * discount} gold.",
    5 => $"Machete cost {20 * discount} gold.",
    6 => $"Canoe cost {200 * discount} gold.",
    7 => $"Food Supplies cost {1 * discount} gold.",
    _ => "Apologies. I do not know that one."
};

Console.WriteLine(response);
