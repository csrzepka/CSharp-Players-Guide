/*
Boss Battle: Hunting the Manticore [250 XP]

The Uncoded One's airship, the Manticore, has begun an all-out attack on the
city of Consolas. It must be destroyed, or the city will fall. Only by
combining Mylara's prototype, Skorin's cannon, and your programming skills will
you have a chance to win this fight. You must build a program that allows one
user — the pilot of the Manticore — to enter the airship's range from the city
and a second user — the city's defenses — to attempt to find what distance the
airship is at and destroy it before it can lay waste to the town.

The first user begins by secretly establishing how far the Manitcore is from
the city, in the range 0 to 100. The program then allows a second player to
repeatedly attempt to destroy the airship by picking the range to target until
either the city of Consolas or the Manticore is destroyed. In each attempt,
the player is told if they overshot (too far), fell short (not far enough), or
hit the Manticore. The damage dealt to the Manticore depends on the turn
number. For most turns, 1 point of damage is dealt. But if the turn number is a
multiple of 3, a fire blast deals 3 points of damage; a multiple of 5, an
electric blast deals 3 points of damage, and if it is a multiple of both 3 and
5, a mighty fire-electric blast deals 10 points of damage. The Manticore is
destroyed after taking 10 points of damage.

However, if the Manticore survives a turn, it will deal a guaranteed 1 point of
damage to the city of Consolas. The city can only take 15 points of damage
before being annihiliated.

Before a round begins, the user should see the current stats: the current round
number, the city's health, and the Manticore's health.

Objectives:
- Establish the game's starting state: the Manticore begins with 10 health
  points and the city with 15. The game starts at round 1.
- Ask the first player to choose the Manticore's distance from the city (0 to
  100). Clear the screen afterward.
- Run the game in a loop until either the Manticore's or the city's health
  reaches 0.
- Before the second player's turn, display the round number, the city's health,
  and the Manticore's health.
- Compute how much damage the cannon will deal this round: 10 points if the
  number is a multiple of both 3 and 5, 3 if it is a multiple of 3 or 5 (but
  not both), and 1 otherwise. Display this to the player.
- Get a target range from the second player and resolve its effect. Tell the
  user if they overshot (too far), fell short, or hit the Manticore. If it was
  a hit, reduce the Manticore's health by the expected amount.
- If the Manticore is still alive, reduce the city's health by 1.
- Advance to the next round.
- When the Manticore or the city's health reaches 0, end the game and display
  the outcome.
- Use different colors for different types of messages.
- Note: This is the largest program you have made so far. Expect it to take
  some time!
- Note: Use methods to focus on solving one problem at a time.
- Note: This version requires two players, but in the future, we will modify
  it to allow the computer to randomly place the Manticore so that it can be a
  single-player game.
*/
Console.Title = "Hunting the Manticore";

// Game variables
int cityHealth = 15;
int manticoreHealth = 10;
int round = 1;

// Player 1

int manticoreDistance = AskForNumberInRange("Player 1, how far away from the city do you want to station the Manticore?", 0, 100);
Console.Clear();

// Player 2

Console.WriteLine("Player 2, it is your turn.");

while (cityHealth > 0 && manticoreHealth > 0)
{
    // Display the status for the round.
    displayStatus(round, cityHealth, manticoreHealth);

    // Display the amount of damage expected on a hit.
    int damage = SkorinsCannon(round);

    // Get a guess from the player on the Manticore distance.
    int guess = AskForNumber("Enter desired cannon range:");

    // Display the outcome of the guess.
    if (guess > manticoreDistance)
    {
        Console.WriteLine("That round OVERSHOT the target.");
    }
    else if (guess < manticoreDistance)
    {
        Console.WriteLine("That round FELL SHORT of the target.");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.ForegroundColor = ConsoleColor.White;

        manticoreHealth -= damage; // update manticore health
    }

	// Deal damage to the city if the Manticore is still alive.
	if (manticoreHealth > 0) cityHealth--;

    // Go on to the next round.
    round++;
}

// Display the outcome of the game.
if (cityHealth > 0)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The Manticore was destroyed! The city of Consolas has been saved!");
}
else if (manticoreHealth > 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("The city of Consolas has fallen! The Manticore has destroyed the city!");
}
else
    Console.WriteLine("Game ended unexpectedly!");

// Wait before closing the game.
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Press any key to close...");
Console.ReadKey();

// ------------------------------- METHODS --------------------------------

/// <summary>
/// Gets a number fro mthe user, asking the prompt supplied by 'text'
/// </summary>
int AskForNumber(string text)
{
    Console.Write(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

/// <summary>
/// Gets a number from the user and ensures it is in the given range.
/// </summary>
int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber(text);
        if (number >= min && number <= max)
            return number;
    }
}

/// <summary>
/// Displays the status of the game, including the round number, and the health
/// of the city and the Manticore.
/// </summary>
void displayStatus(int round, int cityHealth, int manticoreHealth)
{
    // Save current console color
    ConsoleColor previousColor = Console.ForegroundColor;

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("-----------------------------------------------------------");
    
    Console.Write("STATUS:  ");

    Console.Write("Round: ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(round);

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("  City: ");
    displayHealth(cityHealth, 15);
    Console.Write("  Manticore: ");
    displayHealth(manticoreHealth, 10);

    Console.WriteLine();
    
    // Restore console color
    Console.ForegroundColor = previousColor;
}

/// <summary>
/// Displays heath as a fraction of max health, using colors as indicators.
/// Health color is:
/// - green if > 50%
/// - yellow if <= 50%, and > 10%
/// - red if <= 10%
/// </summary>
void displayHealth(int currentHealth, int maxHealth)
{
    // Save current console color
    ConsoleColor previousColor = Console.ForegroundColor;

    // Set health color
    float healthFraction = (float)currentHealth / maxHealth;
    if (healthFraction > 0.5f)
        Console.ForegroundColor = ConsoleColor.Green;
    else if (healthFraction > 0.1f)
        Console.ForegroundColor = ConsoleColor.Yellow;
    else
        Console.ForegroundColor = ConsoleColor.Red;

    Console.Write(currentHealth);

    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write($"/{maxHealth}");

    // Restore console color
    Console.ForegroundColor = previousColor;
}

/// <summary>
/// Prints expected damage done by Skorin's Magic Cannon based on the round and
/// returns the expeced damage. Prints if the a magic gem is being used.
/// </summary>
int SkorinsCannon(int round)
{
    int damage;

    bool fireGemActivates = round % 3 == 0;
    bool electricGemActivates = round % 5 == 0;

    // Save current console color
    ConsoleColor previousColor = Console.ForegroundColor;

    // Determine cannon damage and print if gem is being used.
    if (fireGemActivates && electricGemActivates)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Electric and Fire gems activated!");
        damage = 10;
    }
    else if (fireGemActivates)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fire gem activated!");
        damage = 3;
    }
    else if (electricGemActivates)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Electric gem activated!");
        damage = 3;
    }
    else
    {
        damage = 1;
    }

    // Print damage message
    ConsoleColor damageColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.Write("The cannon is expected to deal ");
    Console.ForegroundColor = damageColor;
    Console.Write(damage);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine(" damage this round.");

    // Restore console color
    Console.ForegroundColor = previousColor;
    
    return damage;
}
