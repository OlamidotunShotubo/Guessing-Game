Console.WriteLine("Welcome to the Guessing Game.");
Console.WriteLine("(1-10)");
var tries = 0; var value = 0;
Random rand = new Random();
value = rand.Next(1, 10);
do
{
    Console.WriteLine(" ");
    Console.WriteLine("Input your Guess");
    int input = int.Parse(Console.ReadLine());
    if (input > value)
    {
        Console.WriteLine("Input is Greater Than Value");
        tries += 1;
    }
    if (input < value)
    {
        Console.WriteLine("Input is Less Than Value");
        tries += 1;
    }
    if (tries == 2)
    {
        Console.WriteLine($"The value is {value}");
    }
    if (input == value)
    {
        Console.WriteLine("Your Input is the same as value");
    }
} while (tries < 2);
Console.Read();