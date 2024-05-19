/*
Challenge: Simula's Test [100 XP]

As you move through the village of Enumerant, you notice a short, cloaked
figure following you. Not being one to enjoy a mysterious figure tailing you,
you seize a moment to confront the figure. "Don't be alarmed!" she says. "I am
Simula. They are saying you're a Programmer. Is this true?" You answer in the
affirmative, and Simula's eyes widen. "If you are truly a Programmer, you will
be able to help me. Follow me." She leads you to backstreet and into a dimly
lit hovel. She hands you a small, locked chest. "We haven't seen any
Programmers in these lands in a long time. And especially not ones that can
craft types. If you are a True Programmer, you will want what is in that chest.
And if you are a True Programmer, I will gladly give it to you to aid you in
your quest."

The chest is a small box you can hold in your hand. The lid can be open, closed
(but unlocked), or locked. You'd normally be able to go between these states,
opening, closing, locking, and unlocking the box, but the box is broken. You
need to create a program with an enumeration to recreate this locking
mechanism. The image below shows how you can move between the three states:

           close              lock
┌────────┐ -----> ┌────────┐ -----> ┌────────┐
│  OPEN  │        │ CLOSED │        │ LOCKED │
└────────┘ <----- └────────┘ <----- └────────┘
            open             unlock

Nothing happens if you attempt an impossible action in the current state, like
opening a locked box.

The program below shows what usng this might look like:
```
The chest is locked. What do you want to do? unlock
The chest is unlocked. What do you want to do? open
The chest is open. What do you want to do? close
The chest is unlocked. What do you want to do?
```

Objectives:
- Define an enumeration for the state of the chest.
- Make a variable whose type is this new enumeration.
- Write code to allow you to manipulate the chest with the lock, unlock, open,
  and close commands, but ensure that you don't transition between states that
  don't support it.
- Loop forever, asking for the next command.
*/

ChestState chest = ChestState.Locked;

while (true)
{
    string state = ChestStateToString(chest);
    string actionText = AskForString($"The chest is {state}. What do you want to do?");
    ChestAction action = StringToChestAction(actionText);

    switch (action)
    {
        case ChestAction.Open:
            if (chest == ChestState.Closed) chest = ChestState.Open;
            break;
        case ChestAction.Close:
            if (chest == ChestState.Open) chest = ChestState.Closed;
            break;
        case ChestAction.Lock:
            if (chest == ChestState.Closed) chest = ChestState.Locked;
            break;
        case ChestAction.Unlock:
            if (chest == ChestState.Locked) chest = ChestState.Closed;
            break;
        default:
            break;
    }
}

// METHODS

string AskForString(string text)
{
    Console.Write(text + " ");
    return Console.ReadLine() ?? "";
}

string ChestStateToString(ChestState state) => state switch
{
    ChestState.Open   => "open",
    ChestState.Closed => "unlocked",
    ChestState.Locked => "locked"
};

ChestAction StringToChestAction(string action) => action.ToLower() switch
{
    "open"   => ChestAction.Open,
    "close"  => ChestAction.Close,
    "lock"   => ChestAction.Lock,
    "unlock" => ChestAction.Unlock,
    _        => ChestAction.Unknown
};

// ENUMS

enum ChestState
{
    Open,
    Closed,
    Locked
}

enum ChestAction
{
    Open,
    Close,
    Lock,
    Unlock,
    Unknown
}
