/*
The Properties of Arrows [100 XP]

Vin Fletcher once again has run to catch up to you for help with his arrows.
"My apologies, Programmer! This will be the last time I bother you. My cousin,
Flynn Vetcher, is the only other arrow maker in the area. He doesn't care for
his craft and makes wildly dangerous and overpriced arrows. But people keep
buying them because they think my GetLength() methods are harder to work with
than his public _length fields. I don't want to give up the protections we just
gave these arrows, but I remember you saying something about properties. Maybe
you could use those to make my arrows easier to work with?"

Objectives:
- Modify your Arrow class to use properties instead of `GetX` and `SetX`
  methods.
- Ensure the whole program can still run, and Vin can keep creating arrows with
  it.
*/

// MAIN

string arrowheadText = AskForString("Arrowhead [steel, wood, obsidian]:");
Arrowhead arrowhead = ConvertToArrowhead(arrowheadText);

float shaftLength = AskForFloatInRange("Shaft length [between 60 and 100]:", 60.0f, 100.0f);

string fletchingText = AskForString("Fletching [plastic, turkey feathers, goose feathers]:");
Fletching fletching = ConvertToFletching(fletchingText);

Arrow arrow = new(arrowhead, shaftLength, fletching);
Console.WriteLine($"Arrow cost: {arrow.Cost} gold");

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
    public Arrowhead Arrowhead { get; }
    public float ShaftLength { get; }
    public Fletching Fletching { get; }

    public Arrow(Arrowhead arrowhead, float shaftLength, Fletching fletching)
    {
        Arrowhead = arrowhead;
        ShaftLength = shaftLength;
        Fletching = fletching;
    }

    public float Cost
    {
        get
        {
            float cost = 0.0f;

            // Arrowhead cost
            cost += Arrowhead switch
            {
                Arrowhead.Steel    => 10.0f,
                Arrowhead.Wood     => 3.0f,
                Arrowhead.Obsidian => 5.0f,
                _                  => 0.0f,
            };

            // Shaft length cost
            cost += ShaftLength * 0.05f;

            // Fletching cost
            cost += Fletching switch
            {
                Fletching.Plastic       => 10.0f,
                Fletching.TurkeyFeather => 5.0f,
                Fletching.GooseFeather  => 3.0f,
                _                       => 0.0f,
            };

            return cost;
        }
    }
}

// ENUMERATIONS

enum Arrowhead { Steel, Wood, Obsidian };
enum Fletching { Plastic, TurkeyFeather, GooseFeather };
