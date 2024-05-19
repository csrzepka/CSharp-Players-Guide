/*
Challenge: Simula's Soup [100 XP]

Simula is impressed with how you reconstructed the box with an enumeration.
When the box opened you saw a glowing emerald gem inside. You don't know what
it is, but it seems important. Also in the box were three vials of powder
labeled HOT, SALTY, and SWEET.

"Finally! I can make soup again!" Simula says. She casually tosses the small
glowing gem to you but is wholly focused on the powders. "You stick around and
help me make soup with your programming skills, and I'll tell you what that
gem does."

She pulls out a cookpot, knocks the clutter off the table with a quick sweep of
her arm, and begins cooking. She says, "I'm the best soup maker in town, and
you're in for a treat. I've got recipes for soup, stew, and gumbo. I've got
mushrooms, chicken, carrots, and potatoes for ingredients. And thanks to you
getting that box open, I've got seasonings again! Spicy, salty, and sweet
seasoning. Pick a recipe, an ingredient, and a seasoning, and I'll make it. Use
your programming skills to help us track what we make."

Objectives:
- Define enumerations for the three variations on food: type (soup, stew,
  gumbo), main ingredient (mushrooms, chicken, carrots, potatoes), and
  seasoning (spicy, salty, sweet).
- Make a tuple variable to represent a soup composed of the three above
  enumeration types.
- Let the user pick a type, main ingredient, and seasoning from the allowed
  choices and fill the tuple with the results. Hint: You could give the user a
  menu to pick from or simply compare the user's text input against specific
  strings to determine which enumeration value represents their choice.
- When done, display the contents of the soup tuple variable in a format like
  "Sweet Chicken Gumbo." Hint: You don't need to convert the enumeration value
  back to a string. Simply displaying an enumeration value with Write or
  WriteLine will display the name of the enumeration value.
*/

// MAIN

(Dish, Ingredient, Seasoning) soup;

Console.WriteLine("What dish would you like?");
string dishText = AskForString("Soup, Stew, or Gumbo:");
soup.Item1 = ConvertToDish(dishText);

Console.WriteLine("What main ingredient would you like?");
string ingredientText = AskForString("Mushrooms, Chicken, Carrots, or Potaotes:");
soup.Item2 = ConvertToIngredient(ingredientText);

Console.WriteLine("Finally, what seasoning would you like?");
string seasoningText = AskForString("Spicy, Salty, or Sweet:");
soup.Item3 = ConvertToSeasoning(seasoningText);

Console.Write("Amazing! You got a ");
Console.Write(soup.Item3 + " "); // Seasoning
Console.Write(soup.Item2 + " "); // Main ingredient
Console.Write(soup.Item1); // Dish
Console.WriteLine("!");

// METHODS

string AskForString(string text)
{
    Console.Write(text + " ");
    return Console.ReadLine() ?? "";
}

Dish ConvertToDish(string dishText) => dishText.ToLower() switch
{
    "soup"  => Dish.Soup,
    "stew"  => Dish.Stew,
    "gumbo" => Dish.Gumbo,
    _       => Dish.Soup
};

Ingredient ConvertToIngredient(string ingredientText) => ingredientText.ToLower() switch
{
    "mushrooms" => Ingredient.Mushrooms,
    "chicken"   => Ingredient.Chicken,
    "carrots"   => Ingredient.Carrots,
    "potatoes"  => Ingredient.Potatoes,
    _           => Ingredient.Mushrooms
};

Seasoning ConvertToSeasoning(string seasoningText) => seasoningText.ToLower() switch
{
    "spicy" => Seasoning.Spicy,
    "salty" => Seasoning.Salty,
    "sweet" => Seasoning.Sweet,
    _       => Seasoning.Spicy
};

// ENUMS

enum Dish
{
    Soup,
    Stew,
    Gumbo
}

enum Ingredient
{
    Mushrooms,
    Chicken,
    Carrots,
    Potatoes
}

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
}