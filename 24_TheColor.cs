/* 
Boss Battle: The Color [100 XP]

The second pedestal asks you to create a Color class to represent a color. The
color consists of three parts or channels: red, green, and blue, which indicate
how much those channels are lit up. Each channel can be from 0 to 255. 0 means
completely off; 255 means completely on.

The pedestal also includes some other names, with a set of numbers indicating
their specific values for each channel. These are commonly used colors:
- White (255, 255, 255),
- Black (0, 0, 0),
- Red (255, 0, 0),
- Orange (255, 165, 0),
- Yellow (255, 255, 0),
- Green (0, 128, 0),
- Blue (0, 0, 255), 
- Purple (128, 0, 128).

Objectives:
- Define a new Color class with properties for its red, green, and blue
  channels.
- Add appropriate constructors that you feel make sense for creating new Color
  objects.
- Create static properties to define the eight commonly used colors for easy
  access.
- In your main method, make two Color typed variables. Use a constructor to
  create a color instance and use a static property for the other. Display each
  of their red, green, and blue channel values.
*/

// MAIN

Color color1 = new Color(80, 120, 200);
Color color2 = Color.CreateOrange();

Console.WriteLine($"({color1.Red}, {color1.Green}, {color1.Blue})");
Console.WriteLine($"({color2.Red}, {color2.Green}, {color2.Blue})");

// CLASSES

public class Color
{
    public byte Red { get; }
    public byte Green { get; }
    public byte Blue { get; }

    public Color(byte red, byte green, byte blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }

    public static Color CreateWhite() => new(255, 255, 255);
    public static Color CreateBlack() => new(0, 0, 0);
    public static Color CreateRed() => new(255, 0, 0);
    public static Color CreateOrange() => new(255, 165, 0);
    public static Color CreateYellow() => new(255, 255, 0);
    public static Color CreateGreen() => new(0, 128, 0);
    public static Color CreateBlue() => new(0, 0, 255);
    public static Color CreatePurple() => new(128, 0, 128);
}
