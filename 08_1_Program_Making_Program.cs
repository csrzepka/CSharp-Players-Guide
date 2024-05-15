Console.WriteLine("What units do you want to use?");
string units = Console.ReadLine();

Console.WriteLine("What C# type do you want to use?");
string type = Console.ReadLine();

string program = $$"""
    Console.WriteLine("Enter the width (in {{units}}) of the triangle: ");
    {{type}} width = {{type}}.Parse(Console.ReadLine());
    Console.WriteLine("Enter the height (in {{units}}) of the triangle: ");
    {{type}} height = {{type}}.Parse(Console.ReadLine());
    {{type}} result = width * height / 2;
    Console.WriteLine($"{result} square {{units}}");
    """;

Console.Write(program);

// Console.WriteLine("Enter the width (in cm) of the triangle: ");
// int width = int.Parse(Console.ReadLine());
// Console.WriteLine("Enter the height (in cm) of the triangle: ");
// int height = int.Parse(Console.ReadLine());
// int result = width * height / 2;
// Console.WriteLine($"{result} square cm");