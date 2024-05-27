Console.Write("Enter the clock input number: ");
int tickTock = Convert.ToInt32(Console.ReadLine());

if (tickTock % 2 == 0)
    Console.WriteLine("Tick");
else
    Console.WriteLine("Tock");
