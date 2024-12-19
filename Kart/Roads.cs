

    internal class Roads
    {
    public string Name { get; }
    public string Difficulty { get; }
    public string Description { get; }

    public Roads(string name, string difficulty, string description)
    {
        Name = name;
        Difficulty = difficulty;
        Description = description;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name}: {Difficulty},   {Description}");
    }

    }

