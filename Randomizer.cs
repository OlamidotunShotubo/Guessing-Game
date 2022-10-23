class GetValue
{
    internal int Number { get; set; }
    internal int Scramble()
    {
        int input = int.Parse(Console.ReadLine());
        Random rand = new Random();
        int value = 0;
        value = rand.Next(1, 50);
        if (input > value)
        {
            string output = "This Input is greater than the Value";
        }
        if (input < value)
        {
            string output = "This Input is Less than the Value";
        }
        return input;
    }
}