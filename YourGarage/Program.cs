using YourGarage;


    // Build a collection of all vehicles that fly
    // With a single `foreach`, have each vehicle Fly()

    // Build a collection of all vehicles that operate on roads
    // With a single `foreach`, have each road vehicle Drive()

    // Build a collection of all vehicles that operate on water
    // With a single `foreach`, have each water vehicle Drive()


List<IFlying> fliers = new List<IFlying>
{
    new JumboJet(){CrewCapacity = 10, MinRunwayLength = 1000, NumberOfEngines = 4, FuelCapacity = 1500.67, Color = "white", Occupancy = 227 },
    new Sesna(){NumberOfPropBlades = 3, WeightLimit = 1000, FuelCapacity = 1500.67, Color = "blue", Occupancy = 150 },
    new Glider(){Material = "particle board", Color = "orange", Occupancy = 2 }
};

foreach (IFlying flier in fliers)
{
    ((Vehicle)flier).Occupancy = 33; 
    flier.Fly();
    flier.Land();
}