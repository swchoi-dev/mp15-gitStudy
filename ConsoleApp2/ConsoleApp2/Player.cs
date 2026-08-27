namespace ConsoleApp2;

public class Player
{
    private string _name;
    private int _level;

    public string Name => _name;

    public int Level => _level;
    
    public Player(string name, int level)
    {
        _name = name;
        _level = level;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Level: {_level}");
    }
}