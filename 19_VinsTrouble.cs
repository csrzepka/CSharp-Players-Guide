/*
Challenge: Vin's Trouble [50 XP]

"Master Programmer!" Vin Fletcher shouts at you as he races to catch up to you.
"I have a problem. I created an arrow for a young man who took it and change
its length to be half as long as I had designed. It no longer fit in his bow
correctly and misfired. It sliced his hand pretty bad. He'll survive, but is
there any way we can make sure somebody doesn't change an arrow's length when
they walk away from my shop? I don't want to be the cause of such
self-inflicted pain." With your knowledge of information hiding, you know you
can help.

Objectives:
- Modify your Arrow class to have private instead of public fields.
- Add in getter methods for each of the fields that you have.
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
    while(true)
    {
        Console.Write(text + " ");
        float length = float.Parse(Console.ReadLine() ?? "0");
        
        if(length >= min && length <= max)
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
    private Arrowhead _arrowhead;
    private float     _shaftLength;
    private Fletching _fletching;

    public Arrow(Arrowhead arrowhead, float shaftLength, Fletching fletching)
    {
        _arrowhead = arrowhead;
        _shaftLength = shaftLength;
        _fletching = fletching;
    }

    public Arrowhead GetArrowhead() => _arrowhead;
    public float GetShaftLength() => _shaftLength;
    public Fletching GetFletching() => _fletching;

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
