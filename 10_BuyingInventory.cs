/*
Challenge: Buying Inventory [100 XP]

It is time to resupply. A nearby outfitter shop has the supplies you need but
is so disorganized that they cannot sell things to you. "Can't sell if I can't
find the price list," Tortuga, the owner, tells you as he turns over and
attempts to go back to sleep in his reclining chair in the corner.

There's a simple solution: use your programming powers to build something to
report the prices of various pieces of equipment, based on the user's
selection:

The following items are available:
1 - Rope
2 - Torches
3 - Climbing Equipment
4 - Clean Water
5 - Machete
6 - Canoe
7 - Food Supplies
What number do you want to see the price of? 2
Torches cost 15 gold.

You search around the shop and find ledgers that show the following prices for
these items: Rope: 10 gold, Torches: 15 gold, Climbing Equipment: 25 gold,
Clean Water: 1 gold, Machete: 20 gold, Canoe: 200 gold, Food Supplies: 1 gold.

Objectives:
- Build a program that will show the menu illustrated above.
- Ask the user to enter a number from the menu.
- Using the information above, use a switch (either type) to show the item's
  cost.
*/

// choice select
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

switch (choice)
{
    case 1: // Rope
        Console.WriteLine("Rope cost 10 gold.");
        break;
    case 2: // Torches
        Console.WriteLine("Torches cost 15 gold.");
        break;
    case 3: // Climbing Equipment
        Console.WriteLine("Climbing Equipment cost 25 gold.");
        break;
    case 4: // Clean Water
        Console.WriteLine("Clean Water cost 1 gold.");
        break;
    case 5: // Machete
        Console.WriteLine("Machete cost 20 gold.");
        break;
    case 6: // Canoe
        Console.WriteLine("Canoe cost 200 gold.");
        break;
    case 7: // Food Supplies
        Console.WriteLine("Food Supplies cost 1 gold.");
        break;
    default:
        Console.WriteLine("Apologies. I do not know that one.");
        break;
}
