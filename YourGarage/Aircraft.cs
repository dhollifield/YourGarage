namespace YourGarage;
public class Aircraft : Vehicle
{
    public virtual void Fly()
    {
        Console.WriteLine($"The {Color} aircraft engine is buzzing and the aircraft is flying.");
    }

    public void Land()
    {
        Console.WriteLine("Safely touching down.");
    }

}
