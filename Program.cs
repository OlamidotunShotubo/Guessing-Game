Console.WriteLine("Guessing Game Beta");
Console.WriteLine("Input your level of choice");
Console.WriteLine("Level (1) - Minimum");
Console.WriteLine("Level (100) - Maximum");
var tries = 0; int levels = 0;
Console.WriteLine("Pls Input the Level of choice");
levels = int.Parse(Console.ReadLine());
var guess = new Guess(levels);
do
{
    Console.WriteLine(" ");
    Console.WriteLine("Input your Guess");
    int input = int.Parse(Console.ReadLine());

    if (guess.Check(input) > 0)
    {
        Console.WriteLine("Input is Less Than Value");
    }
    if (guess.Check(input) < 0)
    {
        Console.WriteLine("Input is Greater Than Value");
    }

    if (guess.Check(input) == 0)
    {
        Console.WriteLine("Your Input is the same as value");
    }
    tries += 1;
    if (tries == guess.Cycle || guess.Check(input) == 0)
    {
        Console.WriteLine($"The value is {guess.Value}");
        Console.WriteLine("Type (r) if u would like to play again");
        Console.WriteLine("Would you like to change the Level");
        Console.WriteLine("Pick (y) if you do");
        var restart = Console.ReadLine();
        if (restart == "y")
        {
            Console.WriteLine("Pls Input the Level of choice");
            levels = int.Parse(Console.ReadLine());
        }

        if (restart == "r")
        {
            tries = 0;
            guess.Refresh();
        }
    }
} while (tries < guess.Cycle);
Console.Read();