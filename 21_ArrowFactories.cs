/*
Challenge: Arrow Factories [100 XP]

Vin Fletcher sometimes makes custom-ordered arrows, but these are rare. Most of
the time, he sells one of the following standard arrows:
- The Elite Arrow, made from a steel arrowhead, plastic fletching, and a 95 cm
  shaft.
- The Beginner Arrow, made from a wood arrowhead, goose feathers, and a 75 cm
  shaft.
- The Marksman Arrow, made from a steel arrowhead, goose feathers, and a 65 cm
  shaft.
You can make static methods to make these specific variations of arrows easy.

Objectives:
- Modify your Arrow class one final time to include static methods of the form
  `public static Arrow CreateEliteArrow() { ... }` for each of the three above
  arrow types.
- Modify the program to allow users to choose one of these pre-defined types or
  a custom arrow. If they select one of the predefined styles, produce an Arrow
  instance using one of the new static methods. If they choose to make a custom
  arrow, use your earlier code to get their custom data about the desired arrow.
*/

// MAIN

Arrow arrow = GetArrow();
Console.WriteLine($"Arrow cost: {arrow.Cost} gold");

// METHODS

Arrow GetArrow()
{
    // Selection options
    Console.WriteLine("""
		What arrow would you like?
		1. Elite Arrow    (Steel Arrowhead, Plastic Fletching, 95cm shaft)
		2. Beginner Arrow (Wood Arrowhead, Goose Feathers, 75cm shaft)
		3. Marksman Arrow (Steel Arrowhead, Goose Feathers, 65cm shaft)
		4. Custom Arrow
		""");

    int selection = AskForIntInRange("Selection:", 1, 4);

    return selection switch
    {
        1 => Arrow.CreateEliteArrow(),
        2 => Arrow.CreateBeginnerArrow(),
        3 => Arrow.CreateMarksmanArrow(),
        _ => CreateCustomArrow()
    };
}

Arrow CreateCustomArrow()
{
    string arrowheadText = AskForString("Arrowhead [steel, wood, obsidian]:");
    Arrowhead arrowhead = ConvertToArrowhead(arrowheadText);

    float shaftLength = AskForFloatInRange("Shaft length [between 60 and 100]:", 60.0f, 100.0f);

    string fletchingText = AskForString("Fletching [plastic, turkey feathers, goose feathers]:");
    Fletching fletching = ConvertToFletching(fletchingText);

    return new Arrow(arrowhead, shaftLength, fletching);
}

float AskForFloatInRange(string text, float min, float max)
{
    while (true)
    {
        Console.Write(text + " ");
        float value = Convert.ToSingle(Console.ReadLine());
        if (value >= min && value <= max) return value;
    }
}

string AskForString(string text)
{
    Console.Write(text + " ");
    return Console.ReadLine() ?? "";
}

int AskForIntInRange(string text, int min, int max)
{
    while (true)
    {
        Console.Write(text + " ");
        int value = Convert.ToInt32(Console.ReadLine());
        if (value >= min && value <= max) return value;
    }
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

public class Arrow
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

    public static Arrow CreateEliteArrow() => new Arrow(Arrowhead.Steel, 95.0f, Fletching.Plastic);
    public static Arrow CreateBeginnerArrow() => new Arrow(Arrowhead.Wood, 75.0f, Fletching.GooseFeather);
    public static Arrow CreateMarksmanArrow() => new Arrow(Arrowhead.Steel, 65.0f, Fletching.GooseFeather);
}

// ENUMERATIONS

public enum Arrowhead { Steel, Wood, Obsidian };
public enum Fletching { Plastic, TurkeyFeather, GooseFeather };
