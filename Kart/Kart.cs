

internal class Kart
{
    public string Color { get; }
    public int MaxSpeed { get; } 
    public string Name { get; }
    public int Number { get; }

    public Kart(int number, string name, string color, int maxspeed) {

        Number = number;
        Name = name;
        Color = color;
        MaxSpeed = maxspeed;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Kart {Number} {Name}:  {Color},  Maxspeed: {MaxSpeed} km/h");
    }

    }

