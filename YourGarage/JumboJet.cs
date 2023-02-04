namespace YourGarage;
public class JumboJet : Vehicle, IFlying, IGasPowered
{
    public int CrewCapacity { get; set; } 
    public int MinRunwayLength { get; set; }
    public int NumberOfEngines { get; set; }
    public int MaxAltitude { get ; set; }
    public double FuelCapacity { get; set; }

    public void ServeMeal()
    {
        Console.WriteLine();
    }

    public void Fly()
    {
        Console.WriteLine("After the engine warms up for a while you taxi forever and then finally take off with a roar.");
    }

    public void Land()
    {
        Console.WriteLine("You descend gradually from 40,000 feet before touching down.");
    }

    public void Refuel()
    {
        throw new NotImplementedException();
    }
}
