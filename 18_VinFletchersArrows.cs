/*
Challenge: Vin Fletcher's Arrows [100 XP]

Vin Fletcher is a skilled arrow maker. He asks for your help building a new
class to represent arrows and determine how much he should sell them for. "A
tiny fragment of my soul goes into each arrow; I care not for money; I just
need to be able to recoup my costs and get food on the table," he says.

Each arrow has three parts: the arrowhead (steel, wood, or obsidian), the
shaft (a length between 60 and 100 cm long), and the fletching (plastic,
turkey feathers, or goose feathers).

His costs are as follows: For arrowheads, steel costs 10 gold, wood costs 3
gold, and obsidian costs 5 gold. For fletching, plastic costs 10 gold, turkey
feathers cost 5 gold, and goose feathers cost 3 gold. For the shaft, the price
depends on the length: 0.05 gold per centimeter.

Objectives:
- Define a new Arrow class with fields for arrowhead type, fletching type, and
  length. (Hint: arrowhead types and fletching types might be good
  enumerations.)
- Allow a user to pick the arrowhead, fletching type, and length and then
  create a new Arrow instance.
- Add a GetCost method that returns its cost as a float based on the numbers
  above, and use this to display the arrow's cost.
*/

// MAIN

string arrowheadText = AskForString("Arrowhead [steel, wood, obsidian]:");
Arrowhead arrowhead = ConvertToArrowhead(arrowheadText);

float shaftLength = AskForFloatInRange("Shaft length [between 60 and 100]:", 60.0f, 100.0f);

string fletchingText = AskForString("Fletching [plastic, turkey feathers, goose feathers]:");
Fletching fletching = ConvertToFletching(fletchingText);

Arrow arrow = new(arrowhead, shaftLength, fletching);
Console.WriteLine($"Arrow cost: {arrow.GetCost()} gold");

// METHODS

float AskForFloatInRange(string text, float min, float max)
{
    while (true)
    {
        Console.Write(text + " ");
        float length = float.Parse(Console.ReadLine() ?? "0");

        if (length >= min && length <= max)
            return length;
    }

}

string AskForString(string text)
{
    Console.Write(text + " ");
    return Console.ReadLine() ?? "";
}

Arrowhead ConvertToArrowhead(string arrowheadText) => arrowheadText.ToLower() switch
{
    "steel"    => Arrowhead.Steel,
    "wood"     => Arrowhead.Wood,
    "obsidian" => Arrowhead.Obsidian,
    _          => Arrowhead.Wood
};

Fletching ConvertToFletching(string fletchingText) => fletchingText.ToLower() switch
{
    "plastic"         => Fletching.Plastic,
    "turkey feathers" => Fletching.TurkeyFeather,
    "goose feathers"  => Fletching.GooseFeather,
    _                 => Fletching.GooseFeather
};

// CLASSES

class Arrow
{
    public Arrowhead _arrowhead;
    public float     _shaftLength;
    public Fletching _fletching;

    public Arrow(Arrowhead arrowhead, float shaftLength, Fletching fletching)
    {
        _arrowhead = arrowhead;
        _shaftLength = shaftLength;
        _fletching = fletching;
    }

    public float GetCost()
    {
        float cost = 0.0f;

        // Arrowhead cost
        cost += _arrowhead switch
        {
            Arrowhead.Steel    => 10.0f,
            Arrowhead.Wood     => 3.0f,
            Arrowhead.Obsidian => 5.0f,
            _                  => 0.0f,
        };

        // Shaft length cost
        cost += _shaftLength * 0.05f;

        // Fletching cost
        cost += _fletching switch
        {
            Fletching.Plastic       => 10.0f,
            Fletching.TurkeyFeather => 5.0f,
            Fletching.GooseFeather  => 3.0f,
            _                       => 0.0f,
        };

        return cost;
    }
}

// ENUMERATIONS

enum Arrowhead { Steel, Wood, Obsidian };
enum Fletching { Plastic, TurkeyFeather, GooseFeather };
