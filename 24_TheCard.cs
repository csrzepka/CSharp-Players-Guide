/* 
Boss Battle: The Card [100 XP]

The digital Realms of C# have playing cards like ours but with some
differences. Each card has a color (red, green, blue, yellow) and a rank (the
numbers 1 through 10, followed by the symbols $, %, ^, and &). The third
pedestal requires that you create a class to represent a card of this nature.

Objectives:
- Define enumerations for card colors and card ranks.
- Define a Card class to represent a card with a color and a rank, as described
  above.
- Add properties or methods that tell you if a card is a number or symbol card
  (the equivalent of a face card).
- Create a main method that will create a card instance for the whole deck
  (every color with every rank) and display each (for example, "The Red
  Ampersand" and "The Blue Seven").
- Answer this question: Why do you think we used a color enumeration here but
  made a color class in the previous challenge?
*/

// MAIN

Card[] deck = new Card[56];

// create deck cards
int index = 0;
foreach (CardColor color in (CardColor[]) Enum.GetValues(typeof(CardColor)))
    foreach (CardRank rank in (CardRank[]) Enum.GetValues(typeof(CardRank)))
        deck[index++] = new Card() { Color = color, Rank = rank };

foreach (Card card in deck)
    Console.WriteLine($"The {card.Color} {card.Rank}");

// CLASSES

public class Card
{
    public required CardColor Color { get; init; }
    public required CardRank Rank { get; init; }

    public bool IsNumber() => Rank < CardRank.DollarSign;
}

// ENUMS

public enum CardColor { Red, Green, Blue, Yellow }
public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }

/// Answer this question: Why do you think we used a color enumeration here but
/// made a color class in the previous challenge?
/// 
// In the previous challenge, we wanted fields/properties that described the
// color, making a color class better suited for the problem. Here, we only
// have four possible colors that the cards can be, like a category. Because
// we are using the colors as categories and do not need to store any
// information in them, an enumeration is better suited for the problem.
