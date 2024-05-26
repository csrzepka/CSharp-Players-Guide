/* 
Boss Battle: The Locked Door [100 XP]

The fourth pedestal demands constructing a door class with a locking mechanism
that requires a unique numeric code to unlock. You have done something similar
before without using a class, but the locking mechanism is new. The door should
only unlock if the passcode is the right one. The following statements describe
how the door works.
- An open door can always be closed.
- A closed (but not locked) door can always be opened.
- A closed door can always be locked.
- A locked door can be unlocked, but a numeric passcode is needed, and the door
  will only unlock if the code supplied matches the door's current passcode.
- When a door is created, it must be given an initial passcode.
- Additionally, you should be able to change the passcode by supplying the
  current code and a new one. The passcode should only change if the correct,
  current code is given.

Objectives:
- Define a Door class that can keep track of whether it is locked, open, or
  closed.
- Make it so you can perform the four transitions defined above with methods.
- Build a constructor that requires the starting numeric passcode.
- Build a method that will allow you to change the passcode for an existing
  door by supplying the current passcode and new passcode. Only change the
  passcode if the current passcode is correct.
- Make your main method ask the user for a starting passcode, then create a new
  Door instance. Allow the user to attempt the four transitions described above
  (open, close, lock, unlock) and change the code by typing in text commands.
*/

// MAIN

int passcode = AskForInt("Enter a passcode for the door:");
Door door = new Door(passcode);
Console.Clear();

Console.WriteLine($"""
    You can perform the following actions:
    - open
    - close
    - lock
    - unlock
    - change passcode
    """);

while (true)
{
    Console.Write($"The door is {door.State}. What do you want to do? ");
    string action = Console.ReadLine() ?? "";

    switch (action)
    {
        case "open":
            door.Open();
            break;
        case "close":
            door.Close();
            break;
        case "lock":
            door.Lock();
            break;
        case "unlock":
            int passcodeAttempt = AskForInt("Enter the passcode:");
            door.Unlock(passcodeAttempt);
            break;
        case "change passcode":
            int oldPasscode = AskForInt("Enter old passcode:");
            int newPasscode = AskForInt("Enter new passcode:");
            door.ChangePasscode(oldPasscode, newPasscode);
            break;
        default:
            Console.WriteLine("Unknown command.");
            break;
    }
}

// METHODS

int AskForInt(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}

// CLASSES

public class Door
{
    public DoorState State { get; private set; }
    private int Passcode { get; set; }

    public Door(int passcode)
    {
        State = DoorState.Closed;
        Passcode = passcode;
    }

    public void Close()
    {
        if (State == DoorState.Open)
            State = DoorState.Closed;
    }

    public void Open()
    {
        if (State == DoorState.Closed)
            State = DoorState.Open;
    }

    public void Lock()
    {
        if (State == DoorState.Closed)
            State = DoorState.Locked;
    }

    public void Unlock(int passcode)
    {
        if (State == DoorState.Locked && Passcode == passcode)
            State = DoorState.Closed;
    }

    public void ChangePasscode(int oldPasscode, int newPasscode)
    {
        if (Passcode == oldPasscode)
            Passcode = newPasscode;
    }
}

// ENUMS

public enum DoorState { Locked, Open, Closed }
