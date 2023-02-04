namespace YourGarage;

internal interface IGasPowered
{
    double FuelCapacity { get; set; }
    void Refuel();
}
