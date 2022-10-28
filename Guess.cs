public class Guess
{
    private int level = 0;
    public int Value { get; set; }
    public int Cycle { get; set; }
    public Guess(int level)
    {
        this.level = level;
        Random rand = new Random();
        var options = 10 * level;
        Cycle = options / 5;
        Value = rand.Next(1, options);
    }
    public void Refresh()
    {
        Random rand = new Random();
        var options = 10 * level;
        Cycle = options / 5;
        Value = rand.Next(1, options);
    }
    public int Check(int unique)
    {
        if (Value > unique)
        {
            return 1;
        }
        else if (Value < unique)
        {
            return -1;
        }
        return 0;
    }
}