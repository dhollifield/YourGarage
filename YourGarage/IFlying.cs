namespace YourGarage;

internal interface IFlying
{

    public int MaxAltitude { get; set; }
    void Fly();
    void Land();

}
